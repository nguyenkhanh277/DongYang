using DongYang.Core.Domain;
using Registration.Core.License;
using System;
using System.Collections.Generic;
using System.Data;

namespace DongYang.Core
{
    public class GlobalConstants
    {
        #region Default Values
        public static string keySoft = "KSOFT";
        public static string saltSoft = "O12ab88cKh@nh";
        public static kLicense license;
        public static int language = 0;
        public static List<LanguageLibrary> languageLibrary = new List<LanguageLibrary>();
        public static int defaultSaltLength = 5;
        public static bool debugMode = true;
        public static string userId = "";
        public static string username = "";
        public static string fullName = "";
        public enum AuthorityGroupValue { Admin }
        public enum GenderValue { Female, Male }
        public enum StatusValue { NoUse, Using }
        public enum CompletedStatusValue { None, OK, Scrap }
        public enum ProductionStatusValue { None, OK, NG, Hold }
        public enum ActionValue { Confirm, Check, Approve, Import, Export }
        public enum LanguageValue { Vietnamese, English }
        #endregion
    }
}
