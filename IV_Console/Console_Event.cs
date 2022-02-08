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
        private static Color[] iv_console_last_m_colors;

        private static readonly Color[] iv_console_color_palette = new Color[(int)IV_Message_Level.All] {Color.FromArgb(45, 45, 45), 
            Color.FromArgb(50, 50, 150), Color.FromArgb(150, 150, 0), Color.FromArgb(250, 30, 0), Color.FromArgb(30, 250, 30), Color.FromArgb(250, 80, 80)};

        private const int MAX_CONSOLE_COMMANDS = 3;
        private static string[] iv_console_commands = new string[MAX_CONSOLE_COMMANDS] {"iv_command_hello", "iv_command_test", "clear" };
        private static IV_Con_Command_Index[] iv_console_commands_index = new IV_Con_Command_Index[MAX_CONSOLE_COMMANDS] { IV_Con_Command_Index.Console, 
            IV_Con_Command_Index.Console, IV_Con_Command_Index.Console };

        private static IV_Console_Window iv_graph_console;
        private static bool iv_console_graph_inited = false;

        public Console_Event()
        {
            if (!iv_console_graph_inited)
                iv_graph_console = new IV_Console_Window();

            IV_Console_Restore_Messages();
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

        public enum IV_Con_Command_Index
        {
            Console = 0,
            Programm_Added = 1,

            All = 2
        }

        public static string[] IV_Console_Get_Commands_List()
        {
            return iv_console_commands;
        }

        public static IV_Con_Command_Index[] IV_Con_Commands_Get_Commands_Index()
        {
            return iv_console_commands_index;
        }

        private static void IV_Con_Commands_Set_Commands_Index(IV_Con_Command_Index index)
        {
            Array.Resize(ref iv_console_commands_index, iv_console_commands_index.Length + 1);

            iv_console_commands_index[iv_console_commands_index.Length - 1] = index;
        }

        public static string[] IV_Con_Commands_Get_Commands_List()
        {
            return iv_console_commands;
        }

        public static void IV_Con_Commands_Set_New_Command(string command_name, IV_Con_Command_Index command_index)
        {
            Array.Resize(ref iv_console_commands, iv_console_commands.Length + 1);

            iv_console_commands[iv_console_commands.Length - 1] = command_name;
            IV_Con_Commands_Set_Commands_Index(command_index);
        }

        public static bool IV_Console_Get_Console_State()
        {
            return iv_console_graph_inited;
        }

        public static void IV_Console_Send_Console_State(bool state)
        {
            iv_console_graph_inited = state;

            if(state)
            {
                Console_Event.IV_Console_Send_Message("[" + IV_Console_Window.CONSOLE_LOGO + "] Initialising Console Grapth Window - Done!!!", Console_Event.IV_Message_Level.Info);
            }
        }

        /*public static string[] IV_Console_Get_Messages()
        {
            if (iv_console_last_messages != null)
                return iv_console_last_messages;
            else
                return null;
        }*/

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
            iv_console_last_m_colors = null;

            if (iv_text_table.Text != null && iv_text_table.Text != String.Empty)
                iv_text_table.Text = String.Empty;
        }

        public IV_Console_Window IV_Get_Console_Graph_WND()
        {
            return iv_graph_console;
        }

        public static void IV_Console_Send_Message(string sended_text, IV_Message_Level message_level, bool send_next = true)
        {
            System.Windows.Forms.TextBox iv_text_box = null;

            if (iv_console_graph_inited && iv_graph_console != null)
                iv_text_box = iv_graph_console.IV_Console_Get_Console_Text_Graph_Panel();

            string send_sign = "";

            if (send_next)
                send_sign += Environment.NewLine;

            Color sended_color = Color.Black;

            foreach (Color apply_color in iv_console_color_palette)
                if (apply_color == iv_console_color_palette[(int)message_level])
                    sended_color = iv_console_color_palette[(int)message_level];

            string send_text = " [" + message_level.ToString() + "] " + sended_text + send_sign;

            if (iv_console_graph_inited && iv_graph_console != null)
                iv_text_box.Text += send_text;

            if (iv_console_last_messages == null)
                iv_console_last_messages = new string[1];
            if (iv_console_last_m_colors == null)
                iv_console_last_m_colors = new Color[1];

            iv_console_last_messages[iv_console_last_messages.Length - 1] = send_text;
            Array.Resize(ref iv_console_last_messages, iv_console_last_messages.Length + 1);

            iv_console_last_m_colors[iv_console_last_m_colors.Length - 1] = sended_color;
            Array.Resize(ref iv_console_last_m_colors, iv_console_last_m_colors.Length + 1);
        }
    }
}
