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
            L_MiddleText = new Label();
            TB_Password = new MaskedTextBox();
            P_Controls = new Panel();
            TC_Buttons = new TabControl();
            TP_UnprotectedFolder = new TabPage();
            B_ProtectFolder = new Button();
            TP_ProtectedFolder = new TabPage();
            button2 = new Button();
            button1 = new Button();
            P_Controls.SuspendLayout();
            TC_Buttons.SuspendLayout();
            TP_UnprotectedFolder.SuspendLayout();
            TP_ProtectedFolder.SuspendLayout();
            SuspendLayout();
            // 
            // L_Greet
            // 
            L_Greet.Dock = DockStyle.Top;
            L_Greet.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Greet.Location = new Point(0, 0);
            L_Greet.Name = "L_Greet";
            L_Greet.Size = new Size(324, 42);
            L_Greet.TabIndex = 0;
            L_Greet.Text = "Helo";
            L_Greet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // L_MiddleText
            // 
            L_MiddleText.AllowDrop = true;
            L_MiddleText.AutoEllipsis = true;
            L_MiddleText.Dock = DockStyle.Top;
            L_MiddleText.Font = new Font("Segoe UI", 12F);
            L_MiddleText.ForeColor = SystemColors.ControlDarkDark;
            L_MiddleText.Location = new Point(0, 42);
            L_MiddleText.Name = "L_MiddleText";
            L_MiddleText.Size = new Size(324, 295);
            L_MiddleText.TabIndex = 2;
            L_MiddleText.Text = "Drag a folder here to get started";
            L_MiddleText.TextAlign = ContentAlignment.MiddleCenter;
            L_MiddleText.DragDrop += L_MiddleText_DragDrop;
            L_MiddleText.DragEnter += L_MiddleText_DragEnter;
            L_MiddleText.DragLeave += L_MiddleText_DragLeave;
            // 
            // TB_Password
            // 
            TB_Password.Font = new Font("Segoe UI", 12F);
            TB_Password.Location = new Point(10, 6);
            TB_Password.Name = "TB_Password";
            TB_Password.PasswordChar = '•';
            TB_Password.Size = new Size(304, 29);
            TB_Password.TabIndex = 1;
            // 
            // P_Controls
            // 
            P_Controls.Controls.Add(TB_Password);
            P_Controls.Controls.Add(TC_Buttons);
            P_Controls.Dock = DockStyle.Bottom;
            P_Controls.Location = new Point(0, 216);
            P_Controls.Margin = new Padding(6);
            P_Controls.Name = "P_Controls";
            P_Controls.Padding = new Padding(3);
            P_Controls.Size = new Size(324, 120);
            P_Controls.TabIndex = 1;
            P_Controls.Visible = false;
            // 
            // TC_Buttons
            // 
            TC_Buttons.Controls.Add(TP_UnprotectedFolder);
            TC_Buttons.Controls.Add(TP_ProtectedFolder);
            TC_Buttons.Location = new Point(3, 41);
            TC_Buttons.Name = "TC_Buttons";
            TC_Buttons.SelectedIndex = 0;
            TC_Buttons.Size = new Size(318, 77);
            TC_Buttons.TabIndex = 3;
            // 
            // TP_UnprotectedFolder
            // 
            TP_UnprotectedFolder.Controls.Add(B_ProtectFolder);
            TP_UnprotectedFolder.Location = new Point(4, 24);
            TP_UnprotectedFolder.Name = "TP_UnprotectedFolder";
            TP_UnprotectedFolder.Padding = new Padding(3);
            TP_UnprotectedFolder.Size = new Size(310, 49);
            TP_UnprotectedFolder.TabIndex = 0;
            TP_UnprotectedFolder.Text = "Protect";
            TP_UnprotectedFolder.UseVisualStyleBackColor = true;
            // 
            // B_ProtectFolder
            // 
            B_ProtectFolder.Dock = DockStyle.Bottom;
            B_ProtectFolder.Font = new Font("Segoe UI", 12F);
            B_ProtectFolder.Location = new Point(3, 7);
            B_ProtectFolder.Name = "B_ProtectFolder";
            B_ProtectFolder.Size = new Size(304, 39);
            B_ProtectFolder.TabIndex = 1;
            B_ProtectFolder.Text = "Protect Folder";
            B_ProtectFolder.UseVisualStyleBackColor = true;
            // 
            // TP_ProtectedFolder
            // 
            TP_ProtectedFolder.Controls.Add(button2);
            TP_ProtectedFolder.Controls.Add(button1);
            TP_ProtectedFolder.Location = new Point(4, 24);
            TP_ProtectedFolder.Name = "TP_ProtectedFolder";
            TP_ProtectedFolder.Padding = new Padding(3);
            TP_ProtectedFolder.Size = new Size(310, 49);
            TP_ProtectedFolder.TabIndex = 1;
            TP_ProtectedFolder.Text = "Unlock";
            TP_ProtectedFolder.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(78, 43);
            button2.TabIndex = 3;
            button2.Text = "Remove Protection";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(87, 3);
            button1.Name = "button1";
            button1.Size = new Size(220, 43);
            button1.TabIndex = 2;
            button1.Text = "Unlock Folder";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 336);
            Controls.Add(P_Controls);
            Controls.Add(L_MiddleText);
            Controls.Add(L_Greet);
            Name = "Form1";
            Text = "PwdFolder";
            Load += Form1_Load;
            P_Controls.ResumeLayout(false);
            P_Controls.PerformLayout();
            TC_Buttons.ResumeLayout(false);
            TP_UnprotectedFolder.ResumeLayout(false);
            TP_ProtectedFolder.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label L_Greet;
        private Label L_MiddleText;
        private MaskedTextBox TB_Password;
        private Panel P_Controls;
        private TabControl TC_Buttons;
        private TabPage TP_UnprotectedFolder;
        private TabPage TP_ProtectedFolder;
        private Button B_ProtectFolder;
        private Button button2;
        private Button button1;
    }
}
