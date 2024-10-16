using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4UK_Hitachi_IJP_Remote_Interface_Program
{
    public class cls_4UkLibrary
    {
        #region HITACHI_CLASS    

        #endregion
        #region HITACHI CODES
        public Char chSTX = (char)0x02;
        public Char chETX = (char)0x03;
        public Char chENQ = (char)0x05;
        public Char chACK = (char)0x06;
        public Char chNAK = (char)0x15;
        public Char chESC = (char)0x1B;
        public Char chDLE = (char)0x10;

        public Char chPSO = (char)0x07;
        public Char chPCC = (char)0x19;
        public Char chREM = (char)0xc0;

        public Char ch_DVC = (char)0x71;

        public Char chItem1 = (char)0x31;

        public Char ch_DVC_Off = (char)0x33;

        public Char chESC_2 = (char)0x1F;

        public Char ch_ONLINE = (char)0x73;
        public Char ch_OFLINE = (char)0x74;

        public Char ch_SO_STATUS = (char)0x31;

        public Char ch_SO_ONLINE = (char)0x31;
        public Char ch_SO_OFLINE = (char)0x30;
        public Char ch_SO_RECENA = (char)0x31;
        public Char ch_SO_RECDIS = (char)0x30;
        public Char ch_SO_OPSTOP = (char)0x30;
        public Char ch_SO_OPSTAN = (char)0x31;
        public Char ch_SO_OPREAD = (char)0x32;
        public Char ch_SO_STOPIN = (char)0x49;
        public Char ch_SO_OPTOFA = (char)0x5C;
        public Char ch_SO_NOWARN = (char)0x30;
        #endregion
    }
}
