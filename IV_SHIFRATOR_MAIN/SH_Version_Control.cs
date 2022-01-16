using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IV_SHIFRATOR_MAIN
{
    public class SH_Version_Control
    {
#if SHIFRATOR_VERSION_015
        private static readonly float sh_programm_ver = 0.15f;
#elif SHIFRATOR_VERSION_015_1
        private static readonly float sh_programm_ver = 0.151f;
#endif
        private static readonly string sh_programm_ver_text = "'Current programm ver' = '"+sh_programm_ver+"'";

        private bool sh_ver_realised = false;
        private float sh_version_sended;

        public SH_Version_Control()
        {

        }

        public SH_Version_Control(bool state)
        {
            if (state)
            {
                SH_Realise_Version();
            }
        }

        ~SH_Version_Control()
        {

        }

        public void SH_Realise_Version()
        {
            string sh_def_path = "./";
            string sh_ver_filename = "sh_version.shver";
            string sh_path = Path.Combine(sh_def_path, sh_ver_filename);

            if (!File.Exists(sh_path))
            {
                using (FileStream process = File.Create(sh_path))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        process.WriteByte(i);
                    }
                }
                StreamWriter sh_create_ver_file = new StreamWriter(sh_path);
                sh_create_ver_file.WriteLine(sh_programm_ver_text);
                sh_create_ver_file.Close();
                sh_version_sended = sh_programm_ver;
                sh_ver_realised = true;
            }
            else
            {
                StreamReader sh_check_ver_from_file = new StreamReader(sh_path);
                var sh_sended_ver = sh_check_ver_from_file.ReadLine();
                if (sh_sended_ver == null)
                    sh_sended_ver = sh_programm_ver_text;
                if (sh_sended_ver == sh_programm_ver_text)
                {
                    bool sh_recreate_ver_to_file = false;
                    if(sh_check_ver_from_file.ReadLine() == null)
                    {
                        sh_recreate_ver_to_file = true;
                    }
                    sh_check_ver_from_file.Close();
                    if(sh_recreate_ver_to_file)
                    {
                        StreamWriter sh_rect = new StreamWriter(sh_path);
                        sh_rect.WriteLine(sh_programm_ver_text);
                        sh_rect.Close();
                    }
                    sh_ver_realised = true;
                    sh_version_sended = sh_programm_ver;
                }
                else if(sh_sended_ver.Substring(1,22) != sh_programm_ver_text.Substring(1,22) || sh_sended_ver.Substring(22, 4) != sh_programm_ver_text.Substring(22, 4) 
                    && sh_sended_ver != String.Empty)
                {
                    sh_check_ver_from_file.Close();
                    MessageBox.Show("Version not readed from selected file!!! Tell a programmer!!! String = " + sh_sended_ver + ".",
                        "Shifrator Version Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sh_ver_realised = false;
                    SH_Loading_Window.sh_loading_core.Close();
                }
                else if(float.TryParse(sh_sended_ver.Substring(27, 3), out float sh_new_ver_include))
                {
                    sh_check_ver_from_file.Close();
                    sh_version_sended = sh_new_ver_include;
                    MessageBox.Show("Current sended version = "+sh_version_sended+".", "Shifrator Version Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sh_ver_realised = true;
                }
            }
        }

        public bool SH_Version_State_Get()
        {
            return sh_ver_realised;
        }

        public float SH_Version_Get()
        {
            if (SH_Version_State_Get())
                return sh_version_sended;
            else
                return 0;
        }
    }
}
