﻿using System.Globalization;

namespace EventGate.Services.Name
{
    public class NameService:INameService
    {
        public string ConvertName(string name)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(name);
        }
    }
}
