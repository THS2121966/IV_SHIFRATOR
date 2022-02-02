
namespace IV_Console
{
    partial class IV_Console_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IV_Console_Window));
            this.iv_console_b_exit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.iv_panel_control_buttons = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // iv_console_b_exit
            // 
            this.iv_console_b_exit.Animated = true;
            this.iv_console_b_exit.AutoRoundedCorners = true;
            this.iv_console_b_exit.BackColor = System.Drawing.Color.Transparent;
            this.iv_console_b_exit.BorderRadius = 12;
            this.iv_console_b_exit.CheckedState.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.CustomImages.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.DefaultAutoSize = true;
            this.iv_console_b_exit.DisabledState.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.FillColor = System.Drawing.Color.Red;
            this.iv_console_b_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iv_console_b_exit.ForeColor = System.Drawing.Color.White;
            this.iv_console_b_exit.HoverState.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.IndicateFocus = true;
            this.iv_console_b_exit.Location = new System.Drawing.Point(481, 3);
            this.iv_console_b_exit.Name = "iv_console_b_exit";
            this.iv_console_b_exit.ShadowDecoration.Parent = this.iv_console_b_exit;
            this.iv_console_b_exit.Size = new System.Drawing.Size(37, 27);
            this.iv_console_b_exit.TabIndex = 1;
            this.iv_console_b_exit.Text = "X";
            this.iv_console_b_exit.UseTransparentBackground = true;
            // 
            // iv_panel_control_buttons
            // 
            this.iv_panel_control_buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iv_panel_control_buttons.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.iv_panel_control_buttons.Location = new System.Drawing.Point(0, 0);
            this.iv_panel_control_buttons.Name = "iv_panel_control_buttons";
            this.iv_panel_control_buttons.Size = new System.Drawing.Size(520, 35);
            this.iv_panel_control_buttons.TabIndex = 0;
            // 
            // IV_Console_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(520, 605);
            this.Controls.Add(this.iv_console_b_exit);
            this.Controls.Add(this.iv_panel_control_buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IV_Console_Window";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IV_Console_Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton iv_console_b_exit;
        private System.Windows.Forms.Panel iv_panel_control_buttons;
    }
}