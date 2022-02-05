using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Console
{
    public class Console_Event
    {
        private static string[] iv_console_last_messages;
        private static readonly Color[] iv_console_color_palette = new Color[(int)IV_Message_Level.All] {Color.FromArgb(45, 45, 45), 
            Color.FromArgb(50, 50, 150), Color.FromArgb(150, 150, 0), Color.FromArgb(250, 30, 0), Color.FromArgb(30, 250, 30), Color.FromArgb(250, 80, 80)};

        private static readonly string[] iv_console_commands = new string[] {"iv_command_hello", "iv_command_test", "clear" };

        private static IV_Console_Window iv_graph_console;
        private static bool iv_console_graph_inited = false;

        public Console_Event()
        {
            if (!iv_console_graph_inited)
                iv_graph_console = new IV_Console_Window();
            else if (!iv_graph_console.Visible && iv_console_graph_inited)
                iv_graph_console.Visible = true;
        }

        public enum IV_Message_Level
        {
            Nope = 0,
            Info = 1,
            Warning = 2,
            Error = 3,

            Logic_Init = 4,
            Logic_Shutdown = 5,

            All = 6
        }

        public static string[] IV_Console_Get_Commands_List()
        {
            return iv_console_commands;
        }

        public static bool IV_Console_Get_Console_State()
        {
            return iv_console_graph_inited;
        }

        public static void IV_Console_Send_Console_State(bool state)
        {
            iv_console_graph_inited = state;
        }

        public static string[] IV_Console_Get_Messages()
        {
            if (iv_console_last_messages != null)
                return iv_console_last_messages;
            else
                return null;
        }

        private static void IV_Console_Restore_Messages()
        {
            if(iv_console_last_messages != null)
                if(iv_console_last_messages[0] != String.Empty)
                {
                    foreach(string message in iv_console_last_messages)
                    {
                        iv_graph_console.IV_Console_Get_Console_Text_Graph_Panel().Text += message;
                    }
                }
        }

        public static void IV_Console_Clear_Messages()
        {
            var iv_text_table = iv_graph_console.IV_Console_Get_Console_Text_Graph_Panel();

            iv_console_last_messages = null;

            if (iv_text_table.Text != null && iv_text_table.Text != String.Empty)
                iv_text_table.Text = String.Empty;
        }

        public IV_Console_Window IV_Get_Console_Graph_WND()
        {
            return iv_graph_console;
        }

        public static void IV_Console_Send_Message(string sended_text, IV_Message_Level message_level, bool send_next = true)
        {
            var iv_text_box = iv_graph_console.IV_Console_Get_Console_Text_Graph_Panel();
            string send_sign = "";

            if (send_next)
                send_sign += Environment.NewLine;

            Color sended_color;

            foreach (Color apply_color in iv_console_color_palette)
                if (apply_color == iv_console_color_palette[(int)message_level])
                    sended_color = iv_console_color_palette[(int)message_level];

            iv_text_box.Text += " [" + message_level.ToString() + "] " + sended_text + send_sign;

            if (iv_console_last_messages == null)
                iv_console_last_messages = new string[1];

            iv_console_last_messages[iv_console_last_messages.Length - 1] = sended_text + send_sign;
            Array.Resize(ref iv_console_last_messages, iv_console_last_messages.Length + 1);
        }
    }
}
