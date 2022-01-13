using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IV_SHIFRATOR_MAIN
{
    public partial class SH_Main_Menu : Form
    {
        public bool sh_m_m_loaded = false;

        private static readonly string sh_ds_box_text_empty = "Type TEXT to Here!!!";

        private static readonly string[] sh_normal_kirill = new string[33] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
        private static readonly string[] sh_shifrated_kirill = new string[33] { "t", "gh", "g", "rs", "xn", "z", "rty", "sx", "za", "kl", "sse", "hf", 
            "sde", "efg", "ng", "xc", "hj", "y", "i", "op", "kls", "uio", "jk", "llm", "ty", "hkg", "gtyh", "tr", "esgb", "hjt", "hjgb", "gvbgh", "uiy" };

        public SH_Main_Menu()
        {
            InitializeComponent();
            sh_m_m_loaded = true;
            sh_sended_msg_box_01.Text = sh_ds_box_text_empty;
        }

        private void SH_M_M_Closed(object sender, FormClosedEventArgs e)
        {
            sh_m_m_loaded = false;
            SH_Loading_Window.sh_loading_core.Close();
        }

        private void SH_B_Shifrate_Hook(object sender, EventArgs e)
        {

        }

        private void SH_B_DEShifrate_Hook(object sender, EventArgs e)
        {

        }

        private bool sh_w_next_turn = false;

        private void SH_DES_Bar_Text_Changed_Hook(object sender, EventArgs e)
        {
            if (!sh_w_next_turn)
                sh_w_next_turn = true;
            else
                sh_w_next_turn = false;

            if (sh_sended_msg_box_01.Text == String.Empty && !sh_w_next_turn)
                sh_sended_msg_box_01.Text = sh_ds_box_text_empty;
        }
    }
}
