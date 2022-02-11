using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVControlAnim
{
    class IVControlAnim_Event : IDisposable
    {
        public IVControlAnim_Event()
        {
        }

        public IVControlAnim_Event(Control chosed_panel, bool anim_hide, bool synced = false, int seconds = 5,
            Siticone.Desktop.UI.AnimatorNS.AnimationType anim_type = Siticone.Desktop.UI.AnimatorNS.AnimationType.Scale, bool anim_tip = false)
        {
            SH_Realise_Panels_Anim(chosed_panel, anim_hide, synced, seconds, anim_type, anim_tip);

            Dispose();
        }


        private static Control iv_anim_last_realised_control = null;
        private static Siticone.Desktop.UI.AnimatorNS.AnimationType iv_anim_last_used_animation_type = Siticone.Desktop.UI.AnimatorNS.AnimationType.Scale;

        public Control IV_Get_Last_Control()
        {
            if (iv_anim_last_realised_control != null)
                return iv_anim_last_realised_control;
            else
                MessageBox.Show("Control not saved in TEMP!!! Tell a programmer!!!", IV_Console.IV_Console_Window.CONSOLE_LOGO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        public Siticone.Desktop.UI.AnimatorNS.AnimationType IV_Get_Last_Anim()
        {
            return iv_anim_last_used_animation_type;
        }

        public static void IV_Animate_Control(Control chosed_panel, bool anim_hide, bool synced = false, int seconds = 5,
            Siticone.Desktop.UI.AnimatorNS.AnimationType anim_type = Siticone.Desktop.UI.AnimatorNS.AnimationType.Scale, bool anim_tip = false)
        {
            var ANIM = new IVControlAnim_Event();

            ANIM.SH_Realise_Panels_Anim(chosed_panel, anim_hide, synced, seconds, anim_type, anim_tip);

            ANIM.Dispose();
        }

        private Siticone.Desktop.UI.WinForms.SiticoneTransition sh_anim_panel;

        public void SH_Realise_Panels_Anim(Control chosed_panel, bool anim_hide, bool synced = false, int seconds = 5,
            Siticone.Desktop.UI.AnimatorNS.AnimationType anim_type = Siticone.Desktop.UI.AnimatorNS.AnimationType.Scale, bool anim_tip = false)
        {
            sh_anim_panel = new Siticone.Desktop.UI.WinForms.SiticoneTransition
            {
                AnimationType = anim_type,
                Interval = seconds
            };

            if (!anim_tip)
            {
                if (!anim_hide)
                {
                    if (!synced)
                        sh_anim_panel.Show(chosed_panel);
                    else
                        sh_anim_panel.ShowSync(chosed_panel);
                }
                else
                {
                    if (!synced)
                        sh_anim_panel.Hide(chosed_panel);
                    else
                        sh_anim_panel.HideSync(chosed_panel);
                }
            }
            else
            {
                sh_anim_panel.HideSync(chosed_panel);
                sh_anim_panel.Show(chosed_panel);
            }

            iv_anim_last_realised_control = chosed_panel;
            iv_anim_last_used_animation_type = anim_type;
        }

        public void Dispose()
        {
            sh_anim_panel.Dispose();

            iv_anim_last_realised_control = null;
            iv_anim_last_used_animation_type = Siticone.Desktop.UI.AnimatorNS.AnimationType.Scale;
        }
    }
}
