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

        public SH_Main_Menu()
        {
            InitializeComponent();
            sh_m_m_loaded = true;
            sh_sended_msg_box_01.Text = sh_ds_box_text_empty;
            sh_button_deshifrate.Visible = false;
            sh_button_shifrate.Visible = false;
        }

        private void SH_M_M_Closed(object sender, FormClosedEventArgs e)
        {
            sh_m_m_loaded = false;
            SH_Loading_Window.sh_loading_core.Close();
        }

        private void SH_B_Shifrate_Hook(object sender, EventArgs e)
        {
            SHIFRATOR_Event sh_send = new SHIFRATOR_Event(sh_sended_msg_box_01.Text);
            sh_sended_msg_box_01.Text = sh_send.SH_Get_Result();
            sh_send.Dispose();
        }

        private void SH_B_DEShifrate_Hook(object sender, EventArgs e)
        {
            SHIFRATOR_Event sh_send = new SHIFRATOR_Event(sh_sended_msg_box_01.Text, true);
            sh_sended_msg_box_01.Text = sh_send.SH_Get_Result();
            sh_send.Dispose();
        }

        private void SH_DES_Bar_Text_Changed_Hook(object sender, EventArgs e)
        {
            if(sh_sended_msg_box_01.Text != String.Empty && sh_sended_msg_box_01.Text != sh_ds_box_text_empty)
            {
                sh_button_deshifrate.Visible = true;
                sh_button_shifrate.Visible = true;
            }
            else
            {
                sh_button_deshifrate.Visible = false;
                sh_button_shifrate.Visible = false;
            }
        }

        private void SH_DS_Text_Clicked_Hook(object sender, EventArgs e)
        {
            if (sh_sended_msg_box_01.Text == sh_ds_box_text_empty)
                sh_sended_msg_box_01.Text = String.Empty;
        }

        private void SH_DS_Out_Of_Focus_Hook(object sender, EventArgs e)
        {
            if (sh_sended_msg_box_01.Text == String.Empty)
                sh_sended_msg_box_01.Text = sh_ds_box_text_empty;
        }
    }
}
