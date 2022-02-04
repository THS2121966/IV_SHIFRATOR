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
            iv_console_text_helper.Text = String.Empty;

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

        private static string[] IV_Console_Command_Check(string sended_text)
        {
            var last_created_commands = Console_Event.IV_Console_Get_Commands_List();
            string[] iv_defined_commands = new string[1] { String.Empty };

            foreach(string chosed_command in last_created_commands)
            {
                if (chosed_command.Substring(1, 1) == sended_text)
                {
                    iv_defined_commands[iv_defined_commands.Length - 1] = chosed_command;
                    Array.Resize(ref iv_defined_commands, iv_defined_commands.Length + 1);
                }
            }

            if (iv_defined_commands[iv_defined_commands.Length - 1] == null)
                Array.Resize(ref iv_defined_commands, iv_defined_commands.Length - 1);

            if (iv_defined_commands[0] != null && iv_defined_commands[0] != String.Empty)
                return iv_defined_commands;
            else
                return null;
        }

        private string[] iv_commands_list_defined;

        private void IV_Console_Send_Text_Hook(object sender, EventArgs e)
        {
            if(iv_console_send_panel.Text != null && iv_console_send_panel.Text != String.Empty)
                iv_commands_list_defined = IV_Console_Command_Check(iv_console_send_panel.Text);

            if(iv_commands_list_defined != null)
            {
                iv_console_text_helper.Text = iv_commands_list_defined[0];
                IVControlAnim_Event.IV_Animate_Control(iv_console_text_helper, false, false, 1, Siticone.Desktop.UI.AnimatorNS.AnimationType.Scale);
            }
            else
            {
                iv_commands_list_defined = null;
                iv_console_text_helper.Text = String.Empty;
                iv_console_text_helper.Visible = false;
            }
        }

        private void IV_B_Console_Send_Hook(object sender, EventArgs e)
        {
            if(iv_console_send_panel.Text != null && iv_console_send_panel.Text != String.Empty)
            {
                Console_Event.IV_Console_Send_Message(iv_console_send_panel.Text, 0);
                iv_console_send_panel.Text = String.Empty;
            }
        }

        private void IV_Console_Helper_Click_Hook(object sender, EventArgs e)
        {
            int command_next = 0;

            if(iv_commands_list_defined != null)
            {
                for (int next = 0; next < iv_commands_list_defined.Length; next++)
                    if (iv_commands_list_defined[next] == iv_console_text_helper.Text)
                        if (next != iv_commands_list_defined.Length - 1)
                            command_next = next + 1;
                        else
                            command_next = 0;

                iv_console_text_helper.Text = iv_commands_list_defined[command_next];
            }
        }

        private void IV_Console_Helper_DClick_Hook(object sender, EventArgs e)
        {
            if (iv_console_text_helper.Text != null && iv_console_text_helper.Text != String.Empty)
            {
                iv_commands_list_defined = null;
                iv_console_send_panel.Text = iv_console_text_helper.Text;
                iv_console_text_helper.Text = String.Empty;
                iv_console_text_helper.Visible = false;
            }
        }
    }
}
