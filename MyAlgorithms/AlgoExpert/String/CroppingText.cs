using System;
using System.Collections.Generic;
using System.Text;

namespace MyAlgorithms.AlgoExpert.String
{
    public class CroppingText
    {

        public string Method1(string text, int length)
        {
            string[] parts = text.Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach(string part in parts)
            {
                if ((sb.Length + part.Length) > length)
                    break;

                sb.Append(part);
                sb.Append(' ');
            }

            if (sb.Length == 0)
                return "";

            text = sb.ToString();
            text = text.Substring(0, text.Length - 1);
            return text;
        }


        //"Hola Mundo Estoy Squi"
        //5 -> ""
        //10 -> "Hola Mundo"
        //14 -> "Hola Mundo"

        public string Method2(string text, int length)
        {

            string[] newText = new string[length];

            for(int i = 0; i < text.Length; i++)
            {
                char s = text[i];

                if (s == ' ' && (i + 1) < text.Length && text.Substring(0, i + 1).Length >= length)
                    break;

                if(text.Substring(0, i).Length > length)
                    break;

                //newText[i] = s.ToString();
            }

            return newText.ToString();

        }





    }
}
