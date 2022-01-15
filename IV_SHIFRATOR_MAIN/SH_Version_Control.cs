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
#endif
        private static readonly string sh_programm_ver_text = "'Current programm ver' =  '"+sh_programm_ver+"'";

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
                if (sh_sended_ver == sh_programm_ver_text)
                {
                    sh_check_ver_from_file.Close();
                    sh_ver_realised = true;
                    sh_version_sended = sh_programm_ver;
                }
                else
                {
                    sh_check_ver_from_file.Close();
                    MessageBox.Show("Version not readed from selected file!!! Tell a programmer!!! String = " + sh_sended_ver + ".",
                        "Shifrator Version Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sh_ver_realised = false;
                    SH_Loading_Window.sh_loading_core.Close();
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
