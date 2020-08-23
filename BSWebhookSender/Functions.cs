using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Web;

namespace BSWebhookSender
{
    //변수지정
    internal class Functions
    {
        private static byte[] Post(string url, NameValueCollection pairs)
        {
            byte[] result;
            using (WebClient webClient = new WebClient())
            {
                result = webClient.UploadValues(url, pairs);
            }
            return result;
        }

        public static void Promotion(List<string> URLs, string Content, string SenderName)
        {
            foreach (string url in URLs)
            {
                Functions.SendWebhook(url, Content, SenderName);
            }
        }

        private static void SendWebhook(string URL, string content, string username)
        {
            try
            {
                Functions.Post(URL, new NameValueCollection
                {
                    {
                        "username",
                        username
                    },
                    {
                        "content",
                        content
                    }
                });
            }
            catch
            { }
        }

        public static string[] ReadFile(string path)
        {
            string text = null;
            using (StreamReader streamReader = new StreamReader(path))
            {
                text = streamReader.ReadToEnd();
            }
            char[] separator = new char[]
            {
                '|'
            };
            return text.Split(separator);
        }
        public static void SaveFile(string path, List<string> items)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (string str in items)
                {
                    streamWriter.WriteLine(str + "|");
                }
            }
        }
        public Functions()
        {
        }
    }
}