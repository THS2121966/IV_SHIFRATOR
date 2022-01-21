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
    public partial class SH_Loading_Window : Form
    {
        public static SH_Loading_Window sh_loading_core;

        /*public static SH_Loading_Window SH_RELEASE_CORE()
        {
            sh_loading_core = new SH_Loading_Window();
            return sh_loading_core;
        }*/

        public SH_Loading_Window()
        {
            InitializeComponent();
            SH_Realise_Think(sh_time01_fps);
            sh_loading_core = this;

            Random i_random = new Random();
            sh_this_node = sh_help_nodes[i_random.Next(0, sh_help_nodes.Length - 1)];
            sh_nodes_label_01.Text = sh_this_node;

            Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow sh_loading_anim_chose = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow
            {
                AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_CENTER,
                Interval = 350,
                TargetForm = this
            };
        }

        public static SH_Main_Menu sh_m_m;

        private readonly Timer sh_time_to_next = new Timer();
        private readonly Timer sh_time_close = new Timer();
        private readonly Timer sh_time_text_anim = new Timer();
        private const int sh_time01_fps = 150;

        public static readonly string sh_logo = "SHIFRATOR";
        public static readonly string sh_logo_warning = sh_logo+" Warning!!!";
        public static readonly string sh_logo_error = sh_logo + " Error!!!";

        private static readonly string[] sh_help_nodes = new string[5] { "For correctly deshifrate, chose correct custom signs;", 
            "For Shifrate - Press 'SHIFRATE' Button;", "For Deshifrate - Press 'DESHIFRATE' Button;", "For Save/Write Files - Press Save/Write Button;", "Have a nice day/night! :D" };

        public float sh_realised_version;

        private void SH_Realise_Think(int fps)
        {
            sh_time_to_next.Interval = fps;
            sh_time_to_next.Tick += SH_Load_Think;
            sh_time_to_next.Enabled = true;

            sh_time_close.Interval = fps - 50;
            sh_time_close.Tick += SH_Close_Think;

            sh_time_text_anim.Interval = 50;
            sh_time_text_anim.Tick += SH_Text_Anim_Think;
        }

        private void SH_Load_Think(object sender, EventArgs e)
        {
            if(sh_loading_w_p_bar.Value == 10)
            {
                sh_next_node = SH_Next_Node(sh_this_node);
                sh_time_text_anim.Enabled = true;
            }

            if(sh_loading_w_p_bar.Value == 50)
            {
                sh_l_m_button_exit.Visible = true;
                sh_time_to_next.Enabled = false;
                SH_Version_Control sh_ver = new SH_Version_Control(true);
                if (sh_ver.SH_Version_State_Get())
                    sh_realised_version = sh_ver.SH_Version_Get();
                else
                    sh_realised_version = 0;
                sh_time_to_next.Enabled = true;
                sh_l_m_button_exit.Visible = false;
            }

            if(sh_loading_w_p_bar.Value != 100)
                sh_loading_w_p_bar.Value += 10;
            else if(sh_node_showed)
            {
                sh_time_to_next.Enabled = false;
                sh_time_text_anim.Enabled = false;
                sh_node_showed = false;
                this.Visible = false;
                sh_m_m = new SH_Main_Menu();
                if(sh_m_m.sh_m_m_loaded)
                    sh_m_m.Visible = true;
            }
        }

        private string sh_this_node = String.Empty;
        private string sh_next_node = String.Empty;
        private bool sh_previous_node_cleared = false;
        private bool sh_node_showed = false;

        private void SH_Text_Anim_Think(object sender, EventArgs e)
        {
            if(!sh_previous_node_cleared)
            {
                if (sh_this_node != String.Empty)
                {
                    sh_this_node = sh_this_node.Remove(sh_this_node.Length - 1, 1);
                    sh_nodes_label_01.Text = sh_this_node;
                }
                else
                    sh_previous_node_cleared = true;
            }
            else
            {
                if(sh_this_node.Length != sh_next_node.Length)
                {
                    sh_this_node += sh_next_node.Substring(sh_this_node.Length, 1);
                    sh_nodes_label_01.Text = sh_this_node;
                }
                else
                {
                    sh_next_node = SH_Next_Node(sh_this_node);
                    sh_previous_node_cleared = false;
                    sh_node_showed = true;
                }
            }
        }

        private string SH_Next_Node(string previous_node)
        {
            string chosed_text = String.Empty;

            for (int next = 0; next < sh_help_nodes.Length; next++)
            {
                if (previous_node == sh_help_nodes[next] && next != sh_help_nodes.Length - 1)
                    chosed_text = sh_help_nodes[next + 1];
                else if (previous_node == sh_help_nodes[next] && next == sh_help_nodes.Length - 1)
                    chosed_text = sh_help_nodes[0];
            }

            return chosed_text;
        }

        public void SH_Send_Chose_Command()
        {
            sh_time_close.Enabled = true;
            sh_nodes_label_01.Visible = false;
            sh_name_label01.Text = "Closing...";
            sh_loading_w_p_bar.Value = 0;
            this.Visible = true;
        }

        private void SH_Close_Think(object sender, EventArgs e)
        {
            if (sh_loading_w_p_bar.Value != 100)
                sh_loading_w_p_bar.Value += 10;
            else
            {
                sh_time_close.Enabled = false;
                sh_loading_w_p_bar.Value = 0;
                this.Close();
            }
        }

        private void SH_L_M_Loaded(object sender, EventArgs e)
        {
            sh_loading_w_p_bar.Visible = true;
        }

        private void SH_B_Exit_Clicked_Hook(object sender, EventArgs e)
        {
            sh_time_to_next.Enabled = false;
            sh_l_m_button_exit.Visible = false;
            SH_Send_Chose_Command();
        }
    }
}
