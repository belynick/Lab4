using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    internal class ApplicationLicense
    {
        public string TrialKey { get; set; }
        public string ProKey { get; set; }
        public LicenseLevel Level { get; set; }

        public enum LicenseLevel
        {
            Trial,
            Pro
        }

        public ApplicationLicense()
        {
            TrialKey = "Tr442163";
            ProKey = "Pr554162";
        }

        public void AllowTrial()
        {
            Console.WriteLine("Ви використовуєте Триальну версію.");
        }

        public void AllowCommon()
        {
            Console.WriteLine("Ви використовуєте Безкоштовну версію.");
        }

        public void AllowPro()
        {
            Console.WriteLine("Ви використовуєте Платну версію.");
        }
    }
}
