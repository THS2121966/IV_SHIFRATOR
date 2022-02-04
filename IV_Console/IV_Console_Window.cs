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
using IVControlAnim;

namespace IV_Console
{
    public partial class IV_Console_Window : Form
    {
        public const string CONSOLE_LOGO = "IV Console";

        private bool iv_wnd_inited = false;
        private bool iv_wnd_escape_close_check = false;

        private Console_Event iv_console_logic;

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

            Console_Event.IV_Console_Send_Console_State(true);

            IV_Init_Think();
        }

        private const int MOVE_TO_CURSOR_FPS = 5;

        private void IV_Init_Think()
        {
            iv_wnd_move_to_cursor_anim.Interval = MOVE_TO_CURSOR_FPS;
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
                iv_close_dlg = MessageBox.Show("Close that Console?", CONSOLE_LOGO, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            else
                iv_close_dlg = DialogResult.Yes;

            if (iv_close_dlg != DialogResult.Yes)
            {
                e.Cancel = true;
                iv_console_b_exit.Visible = true;
            }
            else
            {
                Console_Event.IV_Console_Send_Console_State(false);

                iv_wnd_inited = false;
                e.Cancel = false;
            }
        }

        private void IV_WND_Move_Anim_Think(object sender, EventArgs e)
        {
            this.Location = Cursor.Position;
        }

        public SiticoneTextBox IV_Console_Get_Console_Text_Graph_Panel()
        {
            return iv_console_panel;
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

        private void IV_Console_Send_Text_Hook(object sender, EventArgs e)
        {

        }

        private void IV_B_Console_Send_Hook(object sender, EventArgs e)
        {

        }
    }
}
