using System;
using Stylet;

namespace WpfAppMultiLanguage.Pages
{
    public class ShellViewModel : Screen
    {
        public void SwitchToEng()
        {
            WPFLocalizeExtension.Engine.LocalizeDictionary.Instance.Culture =
                System.Globalization.CultureInfo.GetCultureInfo("en-US");
        }

        public void SwitchToCn()
        {
            WPFLocalizeExtension.Engine.LocalizeDictionary.Instance.Culture =
                System.Globalization.CultureInfo.GetCultureInfo("zh-CN");
        }
    }
}
