﻿using EventGate.Security;
using System.Globalization;
using System.Text;

namespace EventGate.Services.Token
{
    public class TokenDecode
    {
        private const string format = "M/d/yyyy h:mm:ss tt";
        public string Value { get; set; }
        public DateTime Expried { get; set; }

        public TokenDecode(string token)
        {
            string[] splitString = token.Split('.');

            string temp_1 = splitString[0];
            string temp_2 = splitString[1];

            this.Value = temp_1;
            this.Expried = DateTime.ParseExact(ShieldGuardFtBase64.Base64Decode(temp_2), format, CultureInfo.InvariantCulture);
        }
    }
}
