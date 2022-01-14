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
        }

        public static SH_Main_Menu sh_m_m = new SH_Main_Menu();

        private readonly Timer sh_time_to_next = new Timer();
        private readonly Timer sh_time_close = new Timer();
        private const int sh_time01_fps = 150;

        private void SH_Realise_Think(int fps)
        {
            sh_time_to_next.Interval = fps;
            sh_time_to_next.Tick += SH_Load_Think;
            sh_time_to_next.Enabled = true;

            sh_time_close.Interval = fps - 50;
            sh_time_close.Tick += SH_Close_Think;
        }

        private void SH_Load_Think(object sender, EventArgs e)
        {
            if(sh_loading_w_p_bar.Value != 100)
                sh_loading_w_p_bar.Value += 10;
            else
            {
                sh_time_to_next.Enabled = false;
                this.Visible = false;
                if(sh_m_m.sh_m_m_loaded)
                    sh_m_m.Visible = true;
            }
        }

        public void SH_Send_Chose_Command()
        {
            sh_time_close.Enabled = true;
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
    }
}
