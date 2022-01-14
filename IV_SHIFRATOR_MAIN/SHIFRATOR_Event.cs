using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IV_SHIFRATOR_MAIN
{
    public class SHIFRATOR_Event : IDisposable
    {
        public SHIFRATOR_Event()
        {
            SH_Setup_Shifrator_Event();
        }

        public SHIFRATOR_Event(string text)
        {
            SH_Setup_Shifrator_Event(text);
            SH_Set_Text(text);
        }

        public SHIFRATOR_Event(string text, bool deshifrate)
        {
            SH_Setup_Shifrator_Event(text, deshifrate);
            SH_Set_Text(text, deshifrate);
        }

        private void SH_Setup_Shifrator_Event(string text = "", bool deshifrate = false)
        {
            sh_sended_text = text;
            sh_deshifrate = deshifrate;
        }

        public void Dispose()
        {
            sh_sended_text = null;
            sh_deshifrate = false;
        }

        ~SHIFRATOR_Event()
        {
            Dispose();
        }


        private static readonly string[] sh_normal_kirill = new string[33] { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
        private static readonly string[] sh_normal_kirill_2 = new string[33] { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Щ", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
        private static readonly string[] sh_shifrated_kirill = new string[33] { "tck", "ghm", "gsg", "rsa", "xna", "zya", "rty", "sxi", "zag", "klc", "sse", "hfy",
            "sde", "efg", "nng", "xxc", "hgj", "yhj", "ilm", "opw", "kls", "uio", "jkb", "llm", "tyc", "hkg", "gty", "tfr", "esb", "hjt", "hgb", "vgh", "uim" };

        private string sh_sended_text;
        private string sh_created_text;
        private bool sh_deshifrate;

        private bool SH_Shifrate_State()
        {
            if(sh_sended_text != String.Empty || sh_sended_text != null)
            {
                if(!sh_deshifrate)
                {
                    string[] sh_step_array = new string[sh_sended_text.Length];
                    for(int step = 0; step < sh_step_array.Length; step++)
                    {
                        sh_step_array[step] = sh_sended_text.Substring(step, 1);
                    }
                    for(int step = 0; step < sh_step_array.Length; step++)
                    {
                        foreach (string founded in sh_normal_kirill)
                            if (founded == sh_step_array[step])
                                sh_step_array[step] = sh_shifrated_kirill[step];
                        foreach (string founded in sh_normal_kirill_2)
                            if (founded == sh_step_array[step])
                                sh_step_array[step] = sh_shifrated_kirill[step];
                    }
                    foreach (string step in sh_step_array)
                    {
                        sh_created_text += step;
                    }
                    return true;
                }
                else
                {
                    string[] sh_step_array = new string[sh_sended_text.Length / 3];
                    for (int step = 0; step < sh_step_array.Length; step++)
                    {
                        sh_step_array[step] = sh_sended_text.Substring(step *3, 3);
                        //MessageBox.Show(step+") sended sign = "+sh_step_array[step]);
                    }
                    for (int step = 0; step < sh_step_array.Length; step++)
                    {
                        foreach (string founded in sh_shifrated_kirill)
                            if (founded == sh_step_array[step])
                                sh_step_array[step] = sh_normal_kirill[step];
                    }
                    foreach (string step in sh_step_array)
                    {
                        sh_created_text += step;
                    }
                    return true;
                }
            }
            return false;
        }

        public string SH_Get_Result()
        {
            return sh_created_text;
        }

        public void SH_Set_Text(string text, bool deshifrate = false)
        {
            sh_sended_text = text;
            sh_deshifrate = deshifrate;
            if(SH_Shifrate_State())
                MessageBox.Show("Shifrating state Was GOOD!!!", "SHIFRATOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Shifrating state Was BAD!!! Tell a Programmer!!!", "SHIFRATOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
