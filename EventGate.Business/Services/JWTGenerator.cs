using EventGate.Data.Entity;
using EventGate.Data.Repositories;
using EventGate.Data.Repositories.Interface;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Business.Services
{
    public static class JwtGenerator
    {
        public static async Task<string> GenerateToken(User user, List<string> roles, IUserPropository userRepository)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes("741bac7a1a7d01972e27a30532983596f1322e5b645f7d68d40d96eccaaedb1f");

            var vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            var localExpirationTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow.AddHours(1), vietnamTimeZone);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("username", user.UserName),
                    new Claim(ClaimTypes.Role, roles[0]),
                    new Claim(ClaimTypes.NameIdentifier, user.Id)

                }),
                Expires = localExpirationTime,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            var userExist = await userRepository.GetByIdAsync(user.Id);
            if (userExist != null)
            {
                userExist.VerificationToken = tokenString;
                userExist.VerificationTokenExpires = localExpirationTime;
                await userRepository.UpdateAsync(user.Id,userExist);
            }

            return tokenString;
        }

        private static List<InvalidToken> InvalidTokens = new List<InvalidToken>();

        public static void InvalidateToken(string token)
        {
            InvalidTokens.Add(new InvalidToken { Token = token, InvalidatedAt = DateTime.UtcNow });
        }
        public static bool IsTokenValid(string token)
        {
            // Clear expired tokens before checking validity
            ClearExpiredTokens();

            return !InvalidTokens.Any(t => t.Token == token);
        }

        private static void ClearExpiredTokens()
        {
            var expirationThreshold = DateTime.UtcNow.AddHours(-1); // Set your expiration duration

            InvalidTokens.RemoveAll(t => t.InvalidatedAt < expirationThreshold);
        }

        private class InvalidToken
        {
            public string Token { get; set; }
            public DateTime InvalidatedAt { get; set; }
        }

        public static string ExtractTokenFromHeader(string authHeader)
        {
            return authHeader.Substring("Bearer ".Length).Trim();
        }

        public static string ExtractUserIdFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            // Extract the user ID claim
            var uid = jsonToken?.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier))?.Value;
            if (uid == null)
            {
                uid = jsonToken?.Claims.FirstOrDefault(c => c.Type.Equals("nameid"))?.Value;
            }
            return uid;
        }

        public static string ExtractUserRoleFromToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

            // Extract the user ID claim
            var role = jsonToken?.Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Role))?.Value;
            if (role == null)
            {
                role = jsonToken?.Claims.FirstOrDefault(c => c.Type.Equals("role"))?.Value;
            }

            return role;
        }
    }
}
