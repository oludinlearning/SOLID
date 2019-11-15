using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class UI_strings : IUIStrings
    {
        private readonly static string _FormName = "Вузы";
        private readonly static string _ButtonNext = "Следующая";
        private readonly static string _ButtonPrev = "Предыдущая";
        private readonly static string _MenuFile = "Файл";
        private readonly static string _MenuEdit = "Правка";
        private readonly static string _OutputBy = "Выводить по";
        private readonly static string _Language = "Язык";
        private readonly static string _Page = "Страница";
        public string[] language { get; set; } = { "Русский", "English", "Spanish" };

        public string FormName { get; set; } = _FormName;
        public string ButtonNext { get; set; } = _ButtonNext;
        public string ButtonPrev { get; set; } = _ButtonPrev;
        public string MenuFile { get; set; } = _MenuFile;
        public string MenuEdit { get; set; } = _MenuEdit;
        public string OutputBy { get; set; } = _OutputBy;
        public string Language { get; set; } = _Language;
        public string Page { get; set; } = _Page;

        IYandexTranslator IYandexTranslator = new YandexTranslator();
        public void SetDefaultLanguage()
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

        public void SetLanguage(string language)
        {
            FormName = IYandexTranslator.Translate(_FormName, language);
            ButtonNext = IYandexTranslator.Translate(_ButtonNext, language);
            ButtonPrev = IYandexTranslator.Translate(_ButtonPrev, language);
            MenuFile = IYandexTranslator.Translate(_MenuFile, language);
            MenuEdit = IYandexTranslator.Translate(_MenuEdit, language);
            OutputBy = IYandexTranslator.Translate(_OutputBy, language);
            Language = IYandexTranslator.Translate(_Language, language);
            Page = IYandexTranslator.Translate(_Page, language);
        }
    }
}
