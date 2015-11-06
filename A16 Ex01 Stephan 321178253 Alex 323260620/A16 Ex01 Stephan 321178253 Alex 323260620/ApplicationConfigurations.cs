using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    class ApplicationConfigurations
    {
        private static readonly string sr_FileName;

        static ApplicationConfigurations()
        {
            sr_FileName = Application.ExecutablePath + ".configurations.xml";
        }



        private ApplicationConfigurations()
        {
        }


        private static ApplicationConfigurations s_ThisApplicationConfigurations;

        


        public static ApplicationConfigurations instanse
        {
            get
            {
                if (s_ThisApplicationConfigurations == null)
                {

                    s_ThisApplicationConfigurations = ApplicationConfigurations.LoadFromFileOrDefaultConfigurations();
                }

                return s_ThisApplicationConfigurations;
            }
        }

        public static ApplicationConfigurations LoadFromFileOrDefaultConfigurations()
        {
            return null;
        }
    }
}
