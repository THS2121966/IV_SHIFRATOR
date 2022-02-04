using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_Console
{
    public class Console_Event
    {
        private static string[] iv_console_last_messages;


        public static string[] IV_Console_Get_Messages()
        {
            if (iv_console_last_messages != null)
                return iv_console_last_messages;
            else
                return null;
        }

        public void IV_Console_Send_Message(string sended_text)
        {

        }
    }
}
