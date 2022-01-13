
namespace IV_SHIFRATOR_MAIN
{
    partial class SH_Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SH_Main_Menu));
            this.sh_sended_msg_box_01 = new System.Windows.Forms.TextBox();
            this.sh_button_shifrate = new System.Windows.Forms.Button();
            this.sh_button_deshifrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sh_sended_msg_box_01
            // 
            this.sh_sended_msg_box_01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_sended_msg_box_01.Location = new System.Drawing.Point(538, 403);
            this.sh_sended_msg_box_01.Multiline = true;
            this.sh_sended_msg_box_01.Name = "sh_sended_msg_box_01";
            this.sh_sended_msg_box_01.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sh_sended_msg_box_01.Size = new System.Drawing.Size(250, 35);
            this.sh_sended_msg_box_01.TabIndex = 0;
            this.sh_sended_msg_box_01.Text = "Type TEXT to Here!!!";
            this.sh_sended_msg_box_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sh_sended_msg_box_01.TextChanged += new System.EventHandler(this.SH_DES_Bar_Text_Changed_Hook);
            // 
            // sh_button_shifrate
            // 
            this.sh_button_shifrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_button_shifrate.BackColor = System.Drawing.Color.Lime;
            this.sh_button_shifrate.Location = new System.Drawing.Point(538, 374);
            this.sh_button_shifrate.Name = "sh_button_shifrate";
            this.sh_button_shifrate.Size = new System.Drawing.Size(75, 23);
            this.sh_button_shifrate.TabIndex = 1;
            this.sh_button_shifrate.Text = "SHIFRATE";
            this.sh_button_shifrate.UseVisualStyleBackColor = false;
            this.sh_button_shifrate.Click += new System.EventHandler(this.SH_B_Shifrate_Hook);
            // 
            // sh_button_deshifrate
            // 
            this.sh_button_deshifrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sh_button_deshifrate.BackColor = System.Drawing.Color.Red;
            this.sh_button_deshifrate.Location = new System.Drawing.Point(705, 374);
            this.sh_button_deshifrate.Name = "sh_button_deshifrate";
            this.sh_button_deshifrate.Size = new System.Drawing.Size(83, 23);
            this.sh_button_deshifrate.TabIndex = 2;
            this.sh_button_deshifrate.Text = "DESHIFRATE";
            this.sh_button_deshifrate.UseVisualStyleBackColor = false;
            this.sh_button_deshifrate.Click += new System.EventHandler(this.SH_B_DEShifrate_Hook);
            // 
            // SH_Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sh_button_deshifrate);
            this.Controls.Add(this.sh_button_shifrate);
            this.Controls.Add(this.sh_sended_msg_box_01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SH_Main_Menu";
            this.Text = "SHIFRATOR Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SH_M_M_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sh_sended_msg_box_01;
        private System.Windows.Forms.Button sh_button_shifrate;
        private System.Windows.Forms.Button sh_button_deshifrate;
    }
}