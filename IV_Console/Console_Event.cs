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
        private readonly Color[] iv_console_color_palette = new Color[(int)IV_Message_Level.All] {Color.FromArgb(45, 45, 45), 
            Color.FromArgb(50, 50, 150), Color.FromArgb(150, 150, 0), Color.FromArgb(250, 30, 0), Color.FromArgb(30, 250, 30), Color.FromArgb(250, 80, 80)};

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

        public void IV_Console_Send_Message(string sended_text, IV_Message_Level message_level, bool send_next = true)
        {
            var iv_text_box = iv_graph_console.IV_Console_Get_Console_Text_Graph_Panel();
            string send_text;
            if (send_next)
                send_text = sended_text + "\n";
            else
                send_text = sended_text;

            Color sended_color;

            foreach (Color apply_color in iv_console_color_palette)
                if (apply_color == iv_console_color_palette[(int)message_level])
                    sended_color = iv_console_color_palette[(int)message_level];

            iv_text_box.Text = send_text;
        }
    }
}
