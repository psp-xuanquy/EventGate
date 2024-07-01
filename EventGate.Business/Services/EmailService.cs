﻿using EventGate.Business.Models.DTOs;
using EventGate.Business.Models.DTOs.Request;
using EventGate.Business.Services.Interface;
using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Routing.Template;
using MimeKit;
using Newtonsoft.Json.Linq;

namespace EventGate.Business.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailConfiguration _emailConfig;
        private readonly IUserPropository _userRepository;
        public EmailService(EmailConfiguration emailConfig, IUserPropository userPropository)
        {
            _emailConfig = emailConfig;
            _userRepository = userPropository;
        }
        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Event Gate", _emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(message.IsHtml ? MimeKit.Text.TextFormat.Html : MimeKit.Text.TextFormat.Text)
            {
                Text = message.Content
            };

            return emailMessage;
        }

        private void Send(MimeMessage mailMessage)
        {
            using var client = new SmtpClient();
            try
            {
                client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(_emailConfig.UserName, _emailConfig.Password);

                client.Send(mailMessage);
            }
            catch
            {
                //log an error message or throw an exception or both.
                throw;
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }

        public async Task<ServiceResult<string>> SendConfirmEmailAsync(string email)
        {
            var baseDirectory = AppContext.BaseDirectory;
            var templatePath = Path.Combine(baseDirectory, "EmailTemplate", "EmailConfirm.html");
            var htmlContent = GetEmailTemplate(templatePath);

            var userExist = await _userRepository.GetUserByEmail(email);

            if (userExist == null)
            {
                throw new Exception("User does not exist");
            }

            var token = userExist.VerificationToken;

            var link = $"https://eventgateapi.azurewebsites.net/api/Authentication/emailConfirm?id={userExist.Id}";
            htmlContent = htmlContent.Replace("{{UserName}}", userExist.UserName).Replace("{{Link}}", link);

            var message = new Message(new string[] { userExist.Email }, "[Confirm Email] Please verify your account in Event Gate", htmlContent, true);
            SendEmail(message);

            var result = new ServiceResult<string>();
            result.Status = 1;
            result.IsSuccess = true;
            result.Data = null;
            result.ErrorMessage = "Confirm Email Successfully";

            return result;
        }

        public string GetEmailTemplate(string templatePath)
        {
            if (File.Exists(templatePath))
            {
                return File.ReadAllText(templatePath);
            }
            throw new FileNotFoundException("Email template not found", templatePath);
        }
    }
}
