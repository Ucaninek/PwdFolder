namespace PwdFolder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            L_Greet = new Label();
            P_ProtectFolder = new Panel();
            TB_Password = new MaskedTextBox();
            B_ProtectFolder = new Button();
            L_MiddleText = new Label();
            P_ProtectFolder.SuspendLayout();
            SuspendLayout();
            // 
            // L_Greet
            // 
            L_Greet.Dock = DockStyle.Top;
            L_Greet.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Greet.Location = new Point(0, 0);
            L_Greet.Name = "L_Greet";
            L_Greet.Size = new Size(324, 35);
            L_Greet.TabIndex = 0;
            L_Greet.Text = "Helo";
            L_Greet.TextAlign = ContentAlignment.TopCenter;
            // 
            // P_ProtectFolder
            // 
            P_ProtectFolder.Controls.Add(TB_Password);
            P_ProtectFolder.Controls.Add(B_ProtectFolder);
            P_ProtectFolder.Dock = DockStyle.Bottom;
            P_ProtectFolder.Location = new Point(0, 260);
            P_ProtectFolder.Margin = new Padding(6);
            P_ProtectFolder.Name = "P_ProtectFolder";
            P_ProtectFolder.Padding = new Padding(3);
            P_ProtectFolder.Size = new Size(324, 76);
            P_ProtectFolder.TabIndex = 1;
            // 
            // TB_Password
            // 
            TB_Password.Dock = DockStyle.Top;
            TB_Password.Font = new Font("Segoe UI", 12F);
            TB_Password.Location = new Point(3, 3);
            TB_Password.Name = "TB_Password";
            TB_Password.PasswordChar = '•';
            TB_Password.Size = new Size(318, 29);
            TB_Password.TabIndex = 1;
            // 
            // B_ProtectFolder
            // 
            B_ProtectFolder.Dock = DockStyle.Bottom;
            B_ProtectFolder.Font = new Font("Segoe UI", 12F);
            B_ProtectFolder.Location = new Point(3, 34);
            B_ProtectFolder.Name = "B_ProtectFolder";
            B_ProtectFolder.Size = new Size(318, 39);
            B_ProtectFolder.TabIndex = 0;
            B_ProtectFolder.Text = "Protect Folder";
            B_ProtectFolder.UseVisualStyleBackColor = true;
            // 
            // L_MiddleText
            // 
            L_MiddleText.AutoEllipsis = true;
            L_MiddleText.Dock = DockStyle.Fill;
            L_MiddleText.Font = new Font("Segoe UI", 12F);
            L_MiddleText.ForeColor = SystemColors.ControlDarkDark;
            L_MiddleText.Location = new Point(0, 35);
            L_MiddleText.Name = "L_MiddleText";
            L_MiddleText.Size = new Size(324, 301);
            L_MiddleText.TabIndex = 2;
            L_MiddleText.Text = "label1";
            L_MiddleText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 336);
            Controls.Add(P_ProtectFolder);
            Controls.Add(L_MiddleText);
            Controls.Add(L_Greet);
            Name = "Form1";
            Text = "PwdFolder";
            P_ProtectFolder.ResumeLayout(false);
            P_ProtectFolder.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label L_Greet;
        private Panel P_ProtectFolder;
        private MaskedTextBox TB_Password;
        private Button B_ProtectFolder;
        private Label L_MiddleText;
    }
}
