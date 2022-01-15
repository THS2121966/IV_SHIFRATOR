using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            sh_b_save_text01.Visible = false;
            sh_b_write_created_file.Visible = false;
            sh_cb_logic_show_signs_op.Visible = false;
            if (SH_Loading_Window.sh_loading_core.sh_realised_version < 0.15f)
                sh_cb_num_text_for_file.Visible = false;

            SH_Save_Text_To_File_DLG.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }

        private void SH_M_M_Closed(object sender, FormClosedEventArgs e)
        {
            sh_m_m_loaded = false;
            SH_Loading_Window.sh_loading_core.SH_Send_Chose_Command();
        }

        private void SH_B_Shifrate_Hook(object sender, EventArgs e)
        {
            SHIFRATOR_Event sh_send = new SHIFRATOR_Event(sh_sended_msg_box_01.Text);
            sh_sended_msg_box_01.Text = sh_send.SH_Get_Result();
            sh_send.Dispose();
        }

        private void SH_B_DEShifrate_Hook(object sender, EventArgs e)
        {
            /*var dlg_result = MessageBox.Show("If you want to deshifrate correctly, please delete other sign or ' ' for correctly replacing!!!", "Warning!!!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);*/
            //if (dlg_result == DialogResult.OK)
            {
                SHIFRATOR_Event sh_send = new SHIFRATOR_Event(sh_sended_msg_box_01.Text, true);
                sh_sended_msg_box_01.Text = sh_send.SH_Get_Result();
                sh_send.Dispose();
            }
        }

        private void SH_DES_Bar_Text_Changed_Hook(object sender, EventArgs e)
        {
            if(sh_sended_msg_box_01.Text != String.Empty && sh_sended_msg_box_01.Text != sh_ds_box_text_empty)
            {
                sh_button_deshifrate.Visible = true;
                sh_button_shifrate.Visible = true;
                sh_b_save_text01.Visible = true;
                sh_b_write_created_file.Visible = true;
                sh_cb_logic_show_signs_op.Visible = true;
                if (SH_Loading_Window.sh_loading_core.sh_realised_version < 0.15f)
                    sh_cb_num_text_for_file.Visible = true;
            }
            else
            {
                sh_button_deshifrate.Visible = false;
                sh_button_shifrate.Visible = false;
                sh_b_save_text01.Visible = false;
                sh_b_write_created_file.Visible = false;
                sh_cb_logic_show_signs_op.Visible = false;
                if(SH_Loading_Window.sh_loading_core.sh_realised_version < 0.15f)
                    sh_cb_num_text_for_file.Visible = false;
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

        private void SH_Check_Sign_S_R_Hook(object sender, EventArgs e)
        {
            if (sh_cb_logic_show_signs_op.Checked)
                SHIFRATOR_Event.SH_Change_Sigh_Show_Replacing_State(true);
            else
                SHIFRATOR_Event.SH_Change_Sigh_Show_Replacing_State(false);
        }

        private void SH_DLG_Text_Saved_Hook(object sender, CancelEventArgs e)
        {
            StreamWriter sh_write_file = new StreamWriter(SH_Save_Text_To_File_DLG.FileName);
            if(!sh_num_text_f)
                sh_write_file.WriteLine(sh_sended_msg_box_01.Text);
            else
            {
                int length = sh_sended_msg_box_01.Text.Length;
                sh_write_file.WriteLine(length+") "+sh_sended_msg_box_01.Text);
            }
            sh_write_file.Close();

            MessageBox.Show("Current text saved to new file Successfully!!! File Name - "+ SH_Save_Text_To_File_DLG.FileName, "SHIFRATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SH_B_Save_To_File_Hook(object sender, EventArgs e)
        {
            SH_Save_Text_To_File_DLG.ShowDialog();
        }

        private void SH_B_Write_FIle_Hook(object sender, EventArgs e)
        {
            OpenFileDialog open_f_dlg = new OpenFileDialog
            {
                Title = "Shifrator Open File Dialog",
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };
            if (open_f_dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sh_read_file = new StreamReader(open_f_dlg.FileName);
                string sh_get_text_from_file;
                if (!sh_num_text_f)
                    sh_get_text_from_file = sh_read_file.ReadToEnd();
                else
                {
                    int length = sh_read_file.ReadToEnd().Length;
                    sh_get_text_from_file = length+") "+sh_read_file.ReadToEnd();
                }
                sh_read_file.Close();
                StreamWriter sh_write_file = new StreamWriter(open_f_dlg.FileName);
                sh_write_file.WriteLine(sh_get_text_from_file+sh_sended_msg_box_01.Text);
                sh_write_file.Close();
                MessageBox.Show("Current changes are saved Successfully!!! File Name - " + open_f_dlg.FileName, "SHIFRATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool sh_num_text_f = true;

        private void SH_CB_Num_Text_F_Hook(object sender, EventArgs e)
        {
            if (sh_cb_num_text_for_file.Checked)
                sh_num_text_f = true;
            else
                sh_num_text_f = false;
        }
    }
}
