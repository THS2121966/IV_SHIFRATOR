#define SIGN_PROTECT

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
        public static readonly string sh_event_logo = "Shifrator Event";

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
        private static readonly string[] sh_normal_kirill_2 = new string[33] { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
        private static readonly string[] sh_shifrated_kirill_default = new string[33] { "5", "3", "2", "7", "8", "9", "1", "4", "6", "g", "h", "k",
            "a", "v", "w", "x", "z", "y", "u", "o", "c", "t", "j", "b", "d", "r", "i", "f", "l", "R", "T", "Z", "A" };
        private static string[] sh_shifrated_kirill = sh_shifrated_kirill_default;
        private static bool sh_show_replacing_sign = false;

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
                        if (sh_show_replacing_sign)
                            MessageBox.Show(step + 1 + ") sended sign = " + sh_step_array[step]);
                    }
                    foreach(string sign in sh_step_array)
                    {
                        for (int i = 0; i < sh_normal_kirill.Length; i++)
                            if (sign == sh_normal_kirill[i] || sign == sh_normal_kirill_2[i])
                                for (int next = 0; next < sh_step_array.Length; next++)
                                    if (sign == sh_step_array[next])
                                        sh_step_array[next] = sh_shifrated_kirill[i];
                    }
                    foreach (string step in sh_step_array)
                    {
                        sh_created_text += step;
                    }
                    return true;
                }
                else
                {
                    string[] sh_step_array = new string[sh_sended_text.Length];

                    for (int step = 0; step < sh_step_array.Length; step++)
                    {
                        sh_step_array[step] = sh_sended_text.Substring(step, 1);
                        if (sh_show_replacing_sign)
                            MessageBox.Show(step + 1 + ") sended sign = " + sh_step_array[step]);
                    }
                    foreach (string sign in sh_step_array)
                    {
                        for (int i = 0; i < sh_normal_kirill.Length; i++)
                            if (sign == sh_shifrated_kirill[i])
                                for (int next = 0; next < sh_step_array.Length; next++)
                                    if (sign == sh_step_array[next] && next != 0)
                                        sh_step_array[next] = sh_normal_kirill[i];
                                    else if(sign == sh_step_array[next] && next == 0)
                                        sh_step_array[next] = sh_normal_kirill_2[i];
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

        public static void SH_Change_Sigh_Show_Replacing_State(bool state)
        {
            if (state)
                sh_show_replacing_sign = true;
            else
                sh_show_replacing_sign = false;
        }

        public static string[] SH_Get_Shifrated_Signs()
        {
            return sh_shifrated_kirill;
        }

        private static bool sh_shifrate_changed = false;

        public static bool SH_Shifrated_Is_Default_Check()
        {
            if (sh_shifrate_changed)
                return false;
            else
                return true;
        }

        public string SH_Get_Result()
        {
            return sh_created_text;
        }

        public void SH_Set_Default_Shifrated_Kirill()
        {
            Array.Resize(ref sh_shifrated_kirill, sh_shifrated_kirill_default.Length);
            for (int sign_index = 0; sign_index < sh_shifrated_kirill.Length; sign_index++)
                sh_shifrated_kirill[sign_index] = sh_shifrated_kirill_default[sign_index];
            sh_shifrate_changed = false;
        }

        public void SH_Set_New_Shifrated_Kirill(string set_signs)
        {
            sh_shifrate_changed = true;
            Array.Resize(ref sh_shifrated_kirill, set_signs.Length);
            for (int array_index = 0; array_index < sh_shifrated_kirill.Length; array_index++)
                sh_shifrated_kirill[array_index] = set_signs.Substring(array_index, 1);

            if (SH_Loading_Window.sh_loading_core.sh_realised_version >= 0.15)
                if (sh_shifrated_kirill.Length != sh_shifrated_kirill_default.Length)
                {
                    MessageBox.Show("Shifrate table sign's count less than normal sign's table!!! Adding next sign's from default shifrate table...", sh_event_logo,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    int sh_last_added_sign = sh_shifrated_kirill.Length;
                    Array.Resize(ref sh_shifrated_kirill, sh_shifrated_kirill_default.Length);
                    for (int sign_add = sh_last_added_sign; sign_add < sh_shifrated_kirill.Length; sign_add++)
                    {
                        sh_shifrated_kirill[sign_add] = sh_shifrated_kirill_default[sign_add];
                    }
                }

            MessageBox.Show("Sign's are replaced sucessfull!!!", sh_event_logo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SH_Set_Text(string text, bool deshifrate = false)
        {
            sh_sended_text = text;
            sh_deshifrate = deshifrate;
            if(SH_Shifrate_State())
                MessageBox.Show("Shifrating state Was GOOD!!!", sh_event_logo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Shifrating state Was BAD!!! Tell a Programmer!!!", sh_event_logo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
