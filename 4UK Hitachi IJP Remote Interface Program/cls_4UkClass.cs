using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Windows.Forms;

namespace _4UK_Hitachi_IJP_Remote_Interface_Program
{
    public class cls_4UkClass
    {
        public static cls_4UkLibrary myLIBRARY = new cls_4UkLibrary();

        public static SerialPort mainCOMM;

        public static String comPORT;
        public static int comBAUD;
        public static byte[] bytBUFFER = new byte[32];
        public static int intIndex;

        public static String CAPTUREDDATA;
        public static StringBuilder serialBUFFER = new StringBuilder();

        public static void LOAD_COM_SETTINGS()
        {
            comPORT = Properties.Settings.Default["str_PORTN"].ToString();
            comBAUD = int.Parse(Properties.Settings.Default["str_BAUDRT"].ToString());
        }

        public static void SAVE_COM_SETTINGS()
        {
             Properties.Settings.Default["str_PORTN"] = comPORT;
             Properties.Settings.Default["str_BAUDRT"] = comBAUD;
        }
    }


}
