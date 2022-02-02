using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Siticone.Desktop.UI.WinForms;

namespace IV_Console
{
    public partial class IV_Console_Window : Form
    {
        private bool iv_wnd_inited = false;
        private bool iv_wnd_escape_close_check = false;

        public IV_Console_Window()
        {
            InitializeComponent();

            SiticoneAnimateWindow iv_wnd_anim = new SiticoneAnimateWindow
            {
                AnimationType = SiticoneAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE,
                Interval = 350,
                TargetForm = this
            };

            iv_wnd_inited = true;

            iv_wnd_move_to_cursor_anim.Interval = 5;
            iv_wnd_move_to_cursor_anim.Tick += IV_WND_Move_Anim_Think;
        }

        public bool IV_Get_Window_State()
        {
            return iv_wnd_inited;
        }

        public void IV_WND_Force_Close()
        {
            iv_wnd_escape_close_check = true;
            this.Close();
        }

        private void IV_Console_B_Exit_Hook(object sender, EventArgs e)
        {
            var iv_button_exit = sender as SiticoneButton;

            iv_button_exit.Visible = false;
            this.Close();
        }

        private void IV_Console_Close_Hook(object sender, FormClosingEventArgs e)
        {
            DialogResult iv_close_dlg;

            if (!iv_wnd_escape_close_check)
                iv_close_dlg = MessageBox.Show("Close that Console?", "IV Console", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            else
                iv_close_dlg = DialogResult.Yes;

            if (iv_close_dlg != DialogResult.Yes)
            {
                e.Cancel = true;
                iv_console_b_exit.Visible = true;
            }
            else
            {
                iv_wnd_inited = false;
                e.Cancel = false;
            }
        }

        private void IV_WND_Move_Anim_Think(object sender, EventArgs e)
        {
            this.Location = Cursor.Position;
        }

        private void IV_Enter_Focus_Hook(object sender, EventArgs e)
        {
            if (iv_wnd_inited && this.Visible)
                this.Opacity = 1.0D;
        }

        private void IV_Out_Focus_Hook(object sender, EventArgs e)
        {
            if(iv_wnd_inited && this.Visible)
                this.Opacity = 0.8D;
        }

        private bool iv_wnd_moved = false;
        private readonly Timer iv_wnd_move_to_cursor_anim = new Timer();

        private void IV_WND_Move_Hook(object sender, EventArgs e)
        {
            if(!iv_wnd_moved)
            {
                iv_wnd_moved = true;
                iv_panel_control_buttons.Cursor = Cursors.SizeAll;

                iv_wnd_move_to_cursor_anim.Enabled = true;
            }
        }

        private void IV_WND_Stop_Move_Hook(object sender, EventArgs e)
        {
            if(iv_wnd_moved)
            {
                iv_wnd_moved = false;
                iv_panel_control_buttons.Cursor = this.Cursor;

                iv_wnd_move_to_cursor_anim.Enabled = false;
            }
        }
    }
}
