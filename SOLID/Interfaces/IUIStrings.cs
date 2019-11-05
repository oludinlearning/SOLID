using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public interface IUIStrings
    {
        void SetDefaultLanguage();
        void SetLanguage(string language);
        string FormName { get; set; }
        string MenuFile { get; set; }
        string MenuEdit { get; set; }
        string OutputBy { get; set; }
        string Language { get; set; }
        string[] language { get; set; }
        string Page { get; set; }
        string ButtonNext { get; set; }
        string ButtonPrev { get; set; }

    }
}
