﻿namespace _01.Logger.Models.Layouts
{
    using Models.Constrains;
    using System.Text;

    public class XmlLayout : ILayout
    {
        public string Format => this.GetFormat();

        private string GetFormat()
        {
            StringBuilder sb = new StringBuilder();
               sb
                .AppendLine("<log>")
                    .AppendLine("\t<date>{0}</date>")
                    .AppendLine("\t<level>{1}</level>")
                    .AppendLine("\t<message>{2}</message>")
                .AppendLine("<log>");
            return sb.ToString().TrimEnd();
        }
    }
}
