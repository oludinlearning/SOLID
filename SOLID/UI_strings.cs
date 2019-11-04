using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class UI_strings
    {
        private readonly static string _FormName = "Вузы";
        private readonly static string _ButtonNext = "Следующая";
        private readonly static string _ButtonPrev = "Предыдущая";
        private readonly static string _MenuFile = "Файл";
        private readonly static string _MenuEdit = "Правка";
        private readonly static string _OutputBy = "Выводить по";
        private readonly static string _Language = "Язык";
        private readonly static string _Page = "Страница";
        public readonly static string[] language = { "Русский", "English" };

        public static string FormName = _FormName;
        public static string ButtonNext = _ButtonNext;
        public static string ButtonPrev = _ButtonPrev;
        public static string MenuFile = _MenuFile;
        public static string MenuEdit = _MenuEdit;
        public static string OutputBy = _OutputBy;
        public static string Language = _Language;
        public static string Page = _Page;
        public static void SetDefaultLanguage()
        {
            FormName = _FormName;
            ButtonNext = _ButtonNext;
            ButtonPrev = _ButtonPrev;
            MenuFile = _MenuFile;
            MenuEdit = _MenuEdit;
            OutputBy = _OutputBy;
            Language = _Language;
            Page = _Page;
        }

        public static void SetLanguage(string language)
        {
            YandexTranslator yt = new YandexTranslator();
            FormName = yt.Translate(_FormName, language);
            ButtonNext = yt.Translate(_ButtonNext, language);
            ButtonPrev = yt.Translate(_ButtonPrev, language);
            MenuFile = yt.Translate(_MenuFile, language);
            MenuEdit = yt.Translate(_MenuEdit, language);
            OutputBy = yt.Translate(_OutputBy, language);
            Language = yt.Translate(_Language, language);
            Page = yt.Translate(_Page, language);
        }
    }
}
