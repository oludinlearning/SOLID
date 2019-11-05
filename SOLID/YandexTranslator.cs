using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SOLID
{
    public class YandexTranslator : IYandexTranslator
    {
        public static string key = "trnsl.1.1.20191103T222643Z.0c6fd91e8e01b50f.6876629e7b9f9f6d19e27a232137641f5391a747";
        //trnsl.1.1.20191103T222643Z.0c6fd91e8e01b50f.6876629e7b9f9f6d19e27a232137641f5391a747



        public string Translate(string s, string lang)
        {
            if (s.Length > 0)
            {

                WebRequest request = WebRequest.Create("https://translate.yandex.net/api/v1.5/tr.json/translate?"
                    + "key=" + key
                    + "&text=" + s
                    + "&lang=" + lang
                    + "&format=plain");

                WebResponse response = request.GetResponse();

                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string line;

                    if ((line = stream.ReadLine()) != null)
                    {
                        Translation translation = JsonConvert.DeserializeObject<Translation>(line);

                        s = "";

                        foreach (string str in translation.text)
                        {
                            s += str;
                        }
                    }
                }

                return s;
            }
            else
                return "";
        }
    }

    class Translation
    {
        public string code { get; set; }
        public string lang { get; set; }
        public string[] text { get; set; }
    }
}
