using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactParserLibrary.ReadWriteLibrary
{
    class Masks
    {
        static string skype = "Skype:";
        static string telephone = "Telephone:";
        static string eMail = "Email:";
        static string site = "Site:";

        public static string Skype
        {
            get { return skype; }
        }
        public static string Telephone
        {
            get { return telephone; }
        }
        public static string EMail
        {
            get { return eMail; }
        }
        public static string Site
        {
            get { return site; }
        }
    }
}
