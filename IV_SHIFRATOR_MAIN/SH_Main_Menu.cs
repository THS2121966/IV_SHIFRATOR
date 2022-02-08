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
using sh_loading_w = IV_SHIFRATOR_MAIN.SH_Loading_Window;

using sh_control_anim = IVControlAnim;
using Skybound.Gecko;
using IV_Console;

namespace IV_SHIFRATOR_MAIN
{
    public partial class SH_Main_Menu : Form
    {
        public bool sh_m_m_loaded = false;

        private static readonly string sh_ds_box_text_empty = "Type TEXT to Here!!!";
        private Color sh_default_menu_color;

        GeckoWebBrowser sh_web_browser;

        private static Console_Event sh_console_logic_hook = SH_Loading_Window.SH_Get_Console();
        private static IV_Console_Window sh_console_hook = sh_console_logic_hook.IV_Get_Console_Graph_WND();

        public SH_Main_Menu()
        {
            InitializeComponent();
            SH_INIT_Core();
            SH_INIT_UI();
            SH_INIT_Browser();
            SH_Think_Create();
        }

        private void SH_M_M_Closed(object sender, FormClosedEventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            sh_control_anim.IVControlAnim_Event.IV_Animate_Control(this, true, true, 3, Siticone.Desktop.UI.AnimatorNS.AnimationType.Rotate);

            sh_m_m_color_anim.Enabled = false;
            sh_cb_color_gradient.Checked = false;
            sh_m_m_loaded = false;
            sh_console_hook.IV_WND_Force_Close();
            SH_Loading_Window.sh_loading_core.SH_Send_Chose_Command();
        }

        private void SH_INIT_Core()
        {
            sh_m_m_loaded = true;
            sh_sended_msg_box_01.Text = sh_ds_box_text_empty;
            sh_default_menu_color = this.BackColor;
            sh_m_m_color_dlg.Color = sh_default_menu_color;
            sh_button_deshifrate.Visible = false;
            sh_button_shifrate.Visible = false;
            sh_b_save_text01.Visible = false;
            sh_b_write_created_file.Visible = false;
            sh_cb_logic_show_signs_op.Visible = false;

            Console_Event.IV_Con_Commands_Set_New_Command("exit", Console_Event.IV_Con_Command_Index.Programm_Added);

            SH_Save_Text_To_File_DLG.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
        }

        private void SH_INIT_UI()
        {
            Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow sh_loading_anim_chose = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow
            {
                AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_CENTER,
                Interval = 350,
                TargetForm = this
            };

            sh_color_main_style = new Siticone.Desktop.UI.WinForms.SiticoneColorTransition
            {
                StartColor = sh_default_menu_color,
                EndColor = Color.FromArgb(sh_default_menu_color.R - 30, sh_default_menu_color.G - 30, sh_default_menu_color.B - 30),
                ColorArray = new Color[] { sh_default_menu_color, Color.FromArgb(sh_default_menu_color.R - 30, sh_default_menu_color.G - 30, sh_default_menu_color.B - 30) },
                AutoTransition = true
            };
        }

        private void SH_INIT_Browser()
        {
            string sh_browser_src_path = "thirdparty\\xulrunner\\";
            string sh_programm_dir = Application.StartupPath;

#if !DEBUG
            string sh_dir = Path.Combine(sh_programm_dir, sh_browser_src_path);
#else
            string sh_dir = Path.Combine(sh_programm_dir, "..\\..\\"+sh_browser_src_path);
#endif
            Xpcom.Initialize(sh_dir);

            sh_web_browser = new Skybound.Gecko.GeckoWebBrowser
            {
                Parent = sh_browser_panel_01,
                BackColor = Color.Black,
                Visible = false,
                Dock = DockStyle.Fill
            };
        }

        private readonly Timer sh_advert_timer = new Timer();
        private readonly Timer sh_commands_check_timer = new Timer();

        private void SH_Think_Create()
        {
            sh_m_m_color_anim.Interval = 5;
            sh_m_m_color_anim.Tick += SH_M_M_Color_Style_Think;

            sh_advert_timer.Interval = 5000;
            sh_advert_timer.Tick += SH_Advert_Timer_Hook;
            sh_advert_timer.Enabled = true;

            sh_commands_check_timer.Interval = 15;
            sh_commands_check_timer.Tick += SH_Con_Command_Check_Commands_Think;
            sh_commands_check_timer.Enabled = true;
        }

        private void SH_Con_Command_Check_Commands_Think(object sender, EventArgs e)
        {
            if(IV_Console_Window.IV_Con_Command_Get_Programm_Sended_State())
            {
                var sended_command = IV_Console_Window.IV_Con_Command_Get_Programm_Command();

                if(sended_command.iv_con_command_index == Console_Event.IV_Con_Command_Index.Programm_Added)
                {
                    if (sended_command.iv_con_command == "exit")
                        this.Close();
                }
            }
        }

        private static readonly string[] sh_advert_link = new string[] { "https://vk.com/id504177837" };
        private bool sh_advert_inited = false;

        private void SH_Advert_Timer_Hook(object sender, EventArgs e)
        {
            sh_advert_timer.Enabled = false;

            Random sh_random = new Random();

            sh_web_browser.Visible = true;
            sh_control_anim.IVControlAnim_Event.IV_Animate_Control(sh_web_browser, false, false, 5, Siticone.Desktop.UI.AnimatorNS.AnimationType.Transparent, true);
            sh_advert_inited = true;
            sh_m_m_b_close_advert.Visible = true;
            if(this.Visible)
                sh_web_browser.Navigate(sh_advert_link[sh_random.Next(0, sh_advert_link.Length - 1)]);
        }

        private void SH_B_Shifrate_Hook(object sender, EventArgs e)
        {
            sh_control_anim.IVControlAnim_Event ANIM = new sh_control_anim.IVControlAnim_Event();

            SHIFRATOR_Event sh_send = new SHIFRATOR_Event(sh_sended_msg_box_01.Text);
            ANIM.SH_Realise_Panels_Anim(sh_sended_msg_box_01, true, true, 2, Siticone.Desktop.UI.AnimatorNS.AnimationType.Particles);
            sh_sended_msg_box_01.Text = sh_send.SH_Get_Result();
            ANIM.SH_Realise_Panels_Anim(sh_sended_msg_box_01, false, false, 1, Siticone.Desktop.UI.AnimatorNS.AnimationType.Particles);
            sh_send.Dispose();

            ANIM.Dispose();
        }

        private void SH_B_DEShifrate_Hook(object sender, EventArgs e)
        {
            sh_control_anim.IVControlAnim_Event ANIM = new sh_control_anim.IVControlAnim_Event();

            SHIFRATOR_Event sh_send = new SHIFRATOR_Event(sh_sended_msg_box_01.Text, true);
            ANIM.SH_Realise_Panels_Anim(sh_sended_msg_box_01, true, true, 2, Siticone.Desktop.UI.AnimatorNS.AnimationType.Particles);
            sh_sended_msg_box_01.Text = sh_send.SH_Get_Result();
            ANIM.SH_Realise_Panels_Anim(sh_sended_msg_box_01, false, false, 1, Siticone.Desktop.UI.AnimatorNS.AnimationType.Particles);
            sh_send.Dispose();

            ANIM.Dispose();
        }

        private void SH_DES_Bar_Text_Changed_Hook(object sender, EventArgs e)
        {
            sh_control_anim.IVControlAnim_Event ANIM = new sh_control_anim.IVControlAnim_Event();

            if (sh_sended_msg_box_01.Text != String.Empty && sh_sended_msg_box_01.Text != sh_ds_box_text_empty)
            {
                ANIM.SH_Realise_Panels_Anim(sh_b_load_signs_from_f, true, false, 2);
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
                ANIM.SH_Realise_Panels_Anim(sh_b_load_signs_from_f, false, false, 3);
            }

            ANIM.Dispose();
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

            MessageBox.Show("Current text saved to new file Successfully!!! File Name - "+ SH_Save_Text_To_File_DLG.FileName, sh_loading_w.sh_logo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            sh_control_anim.IVControlAnim_Event.IV_Animate_Control(sh_b_save_text01, false, false, 1, Siticone.Desktop.UI.AnimatorNS.AnimationType.Rotate, true);

            var iv_save_dlg = sender as SaveFileDialog;
            iv_save_dlg.Dispose();
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
                MessageBox.Show("Current changes are saved Successfully!!! File Name - " + open_f_dlg.FileName, sh_loading_w.sh_logo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                sh_control_anim.IVControlAnim_Event.IV_Animate_Control(sh_b_write_created_file, false, false, 1, Siticone.Desktop.UI.AnimatorNS.AnimationType.Rotate, true);
            }
            open_f_dlg.Dispose();
        }

        private bool sh_num_text_f = false;

        private void SH_CB_Num_Text_F_Hook(object sender, EventArgs e)
        {
            if (sh_cb_num_text_for_file.Checked)
                sh_num_text_f = true;
            else
                sh_num_text_f = false;
        }

        private void SH_B_Load_Signs_From_F_Hook(object sender, EventArgs e)
        {
            bool default_shifrate = false;

            if(!SHIFRATOR_Event.SH_Shifrated_Is_Default_Check())
            {
                var msg_box_question = MessageBox.Show("Resset sign's to default state?", sh_loading_w.sh_logo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg_box_question == DialogResult.Yes)
                    default_shifrate = true;
            }

            if (!default_shifrate)
            {
                OpenFileDialog sh_open_sign_file = new OpenFileDialog
                {
                    Title = "Shifrator Open File Dialog",
                    Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
                };
                if (sh_open_sign_file.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sh_read_from_file = new StreamReader(sh_open_sign_file.FileName);
                    SHIFRATOR_Event sh_sign_table_replace = new SHIFRATOR_Event();
                    sh_sign_table_replace.SH_Set_New_Shifrated_Kirill(sh_read_from_file.ReadLine());
                    sh_sign_table_replace.Dispose();
                    sh_read_from_file.Close();
                    var dlg_result = MessageBox.Show("Changing shifrated table was Sucessfull!!! Show New Sign's?", sh_loading_w.sh_logo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlg_result == DialogResult.Yes)
                    {
                        var sh_shifrated_signs = SHIFRATOR_Event.SH_Get_Shifrated_Signs();
                        int i = 1;
                        foreach (string sign in sh_shifrated_signs)
                        {
                            MessageBox.Show("Shifrated string #" + i + " = " + sign);
                            i++;
                        }
                    }
                }
                sh_open_sign_file.Dispose();
            }
            else
            {
                SHIFRATOR_Event sh_to_def = new SHIFRATOR_Event();
                sh_to_def.SH_Set_Default_Shifrated_Kirill();
                sh_to_def.Dispose();
                var dlg_result = MessageBox.Show("Changing shifrated table was Sucessfull!!! Show New Sign's?", sh_loading_w.sh_logo, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlg_result == DialogResult.Yes)
                {
                    var sh_shifrated_signs = SHIFRATOR_Event.SH_Get_Shifrated_Signs();
                    int i = 1;
                    foreach (string sign in sh_shifrated_signs)
                    {
                        MessageBox.Show("Shifrated string #" + i + " = " + sign);
                        i++;
                    }
                }
            }
        }

        private void SH_M_M_Showed_Hook(object sender, EventArgs e)
        {
            sh_control_anim.IVControlAnim_Event ANIM = new sh_control_anim.IVControlAnim_Event();

            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SH_Main_Menu));
            this.Icon = this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            ANIM.SH_Realise_Panels_Anim(sh_sended_msg_box_01, false, false, 2, Siticone.Desktop.UI.AnimatorNS.AnimationType.Mosaic, true);
            ANIM.SH_Realise_Panels_Anim(sh_b_load_signs_from_f, false, false, 3, Siticone.Desktop.UI.AnimatorNS.AnimationType.Particles);
            ANIM.SH_Realise_Panels_Anim(sh_b_back_color_change, false, false, 2, Siticone.Desktop.UI.AnimatorNS.AnimationType.Particles);

            ANIM.Dispose();
        }

        private bool sh_m_m_color_changed = false;

        private void SH_M_M_Color_B_Click_Hook(object sender, EventArgs e)
        {
            sh_control_anim.IVControlAnim_Event ANIM = new sh_control_anim.IVControlAnim_Event();

            DialogResult dlg_resset;

            if (sh_m_m_color_changed)
                dlg_resset = MessageBox.Show("Resset to default Color?", sh_loading_w.sh_logo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            else dlg_resset = DialogResult.No;

            if (dlg_resset != DialogResult.Yes)
            {
                if (sh_m_m_color_dlg.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = sh_m_m_color_dlg.Color;
                    if(sh_advert_inited)
                        sh_browser_panel_01.BackColor = sh_m_m_color_dlg.Color;
                    ANIM.SH_Realise_Panels_Anim(sh_cb_color_gradient, false, false, 1, Siticone.Desktop.UI.AnimatorNS.AnimationType.Transparent);
                    sh_m_m_color_changed = true;
                    sh_cb_color_gradient.Checked = false;
                }
            }
            else
            {
                this.BackColor = sh_default_menu_color;
                sh_browser_panel_01.BackColor = sh_default_menu_color;
                sh_m_m_color_dlg.Color = sh_default_menu_color;
                ANIM.SH_Realise_Panels_Anim(sh_cb_color_gradient, true, false, 1, Siticone.Desktop.UI.AnimatorNS.AnimationType.Transparent);
                sh_m_m_color_changed = false;
                sh_cb_color_gradient.Checked = false;
            }

            ANIM.Dispose();
        }

        private Siticone.Desktop.UI.WinForms.SiticoneColorTransition sh_color_main_style;
        private readonly Timer sh_m_m_color_anim = new Timer();

        private void SH_CB_Gradient_State_Hook(object sender, EventArgs e)
        {
            if (sh_cb_color_gradient.Checked)
            {
                sh_m_m_color_anim.Enabled = true;

                Color color_geted = sh_m_m_color_dlg.Color;

                if (color_geted.R < 50 || color_geted.G < 50 || color_geted.B < 50 || color_geted.R > 205 || color_geted.G > 205 || color_geted.B > 205)
                {
                    if (color_geted.R < 50)
                        color_geted = Color.FromArgb(50, color_geted.G, color_geted.B);
                    if (color_geted.G < 50)
                        color_geted = Color.FromArgb(color_geted.R, 50, color_geted.B);
                    if (color_geted.B < 50)
                        color_geted = Color.FromArgb(color_geted.R, color_geted.G, 50);
                    if (color_geted.R > 205)
                        color_geted = Color.FromArgb(205, color_geted.G, color_geted.B);
                    if (color_geted.G > 205)
                        color_geted = Color.FromArgb(color_geted.R, 205, color_geted.B);
                    if (color_geted.B > 205)
                        color_geted = Color.FromArgb(color_geted.R, color_geted.G, 205);
                }

                sh_color_main_style.StartColor = sh_m_m_color_dlg.Color;
                sh_color_main_style.EndColor = Color.FromArgb(color_geted.R + 50, color_geted.G + 50, color_geted.B + 50);

                sh_color_main_style.ColorArray = new Color[] {sh_m_m_color_dlg.Color, 
                    Color.FromArgb(color_geted.R - 10, color_geted.G - 10, color_geted.B - 10), 
                    Color.FromArgb(color_geted.R - 30, color_geted.G - 30, color_geted.B - 30),
                    Color.FromArgb(color_geted.R - 50, color_geted.G - 50, color_geted.B - 50),
                    Color.FromArgb(color_geted.R + 10, color_geted.G + 10, color_geted.B + 10),
                    Color.FromArgb(color_geted.R + 30, color_geted.G + 30, color_geted.B + 30),
                    Color.FromArgb(color_geted.R + 50, color_geted.G + 50, color_geted.B + 50)};
            }
            else
            {
                sh_m_m_color_anim.Enabled = false;
                this.BackColor = sh_m_m_color_dlg.Color;
                sh_browser_panel_01.BackColor = sh_m_m_color_dlg.Color;
            }
        }

        private void SH_M_M_Color_Style_Think(object sender, EventArgs e)
        {
            var next_color = sh_color_main_style.Value;
            this.BackColor = Color.FromArgb(next_color.R, next_color.G, next_color.B);
            if(sh_advert_inited)
                sh_browser_panel_01.BackColor = Color.FromArgb(next_color.R, next_color.G, next_color.B);
        }

        private int sh_logo_click_count = 0;

        private void SH_Logo_Click_Hook(object sender, EventArgs e)
        {
            if (sh_logo_click_count < 10)
                sh_logo_click_count++;
            else
            {
                sh_logo_click_count = 0;
                sh_control_anim.IVControlAnim_Event.IV_Animate_Control(sh_p_logo, false, false, 3, Siticone.Desktop.UI.AnimatorNS.AnimationType.Rotate, true);
            }
        }

        private void SH_B_Advert_Close_Hook(object sender, EventArgs e)
        {
            var sh_button_this = sender as Siticone.Desktop.UI.WinForms.SiticoneButton;
            sh_control_anim.IVControlAnim_Event.IV_Animate_Control(sh_button_this, true, false, 2, Siticone.Desktop.UI.AnimatorNS.AnimationType.Transparent);

            sh_web_browser.Visible = false;
            sh_web_browser.Dispose();
            sh_browser_panel_01.Visible = false;
            sh_advert_inited = false;
            sh_browser_panel_01.Dispose();
        }

        private void SH_B_Open_Console_Hook(object sender, EventArgs e)
        {
            if (sh_console_hook.IV_Get_Window_State() && !sh_console_hook.Visible)
                sh_console_hook.Visible = true;
            else if (sh_console_hook.IV_Get_Window_State() && sh_console_hook.Visible)
                sh_console_hook.Visible = false;
            else if (!sh_console_hook.IV_Get_Window_State())
            {
                SH_Loading_Window.SH_Realise_Console();

                sh_console_logic_hook = SH_Loading_Window.SH_Get_Console();
                sh_console_hook = sh_console_logic_hook.IV_Get_Console_Graph_WND();

                sh_console_hook.Visible = true;
            }
        }
    }
}
