using Transitions;

namespace PwdFolder
{
    public partial class Form1 : Form
    {
        private bool allowDragDrop = true;

        public Form1()
        {
            InitializeComponent();
        }

        private static void HideAllTabsOnTabControl(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void SetMiddleText(string text)
        {
            Transition.run(L_MiddleText, "Text", text, new TransitionType_EaseInEaseOut(250));
        }

        private void SetBackColor(Color color)
        {
            Transition.run(this, "BackColor", color, new TransitionType_EaseInEaseOut(250));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideAllTabsOnTabControl(TC_Buttons);

            //Set the height of the controls so that tabs are hidden when launched and visible on designer
            P_Controls.Height = 90;
            TC_Buttons.Height = 10;
        }

        private void AnimateMiddleTextUpwards()
        {
            L_MiddleText.Height = 295;
            Transition.run(L_MiddleText, "Height", 205, new TransitionType_EaseInEaseOut(250));
        }

        private void L_MiddleText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data == null) return;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[]? files = (string[]?)e.Data.GetData(DataFormats.FileDrop, false);
                if (files == null && files?.Length == 0) return;

                if (files?.Length > 1)
                {
                    //Multiple folders
                    SetMiddleText("Please drag only one folder at a time");
                    return;
                }

                if (GetFileType(files![0]) != DroppedFileTypes.Invalid)
                {
                    //Valid folder or protected folder file
                    e.Effect = DragDropEffects.Copy;
                    SetBackColor(Color.White);
                    SetMiddleText("Drop the folder here");
                }
            }
        }

        private void L_MiddleText_DragLeave(object sender, EventArgs e)
        {
            SetBackColor(SystemColors.Control);
            SetMiddleText("Drag a folder here to get started");
        }

        enum DroppedFileTypes
        {
            Folder,
            ProtectedFolder,
            Invalid
        }

        private static DroppedFileTypes GetFileType(string folderPath)
        {
            if (Directory.Exists(folderPath)) return DroppedFileTypes.Folder;
            if (File.Exists(folderPath) && Path.GetExtension(folderPath) == ".pwf") return DroppedFileTypes.ProtectedFolder;
            return DroppedFileTypes.Invalid;
        }

        private void L_MiddleText_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None; //Reset the effect so cursor does not get stuck at Copy.
            if (e.Data == null) return;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[]? files = (string[]?)e.Data.GetData(DataFormats.FileDrop, false);
                if (files?.Length != 1) return;
                string file = files[0];
                var droppedFileType = GetFileType(file);
                switch (droppedFileType)
                {
                    case DroppedFileTypes.Folder:
                        //This is a normal folder, show the protection page.
                        TC_Buttons.SelectedTab = TP_Protect;
                        P_Controls.Show();

                        AnimateMiddleTextUpwards();
                        SetMiddleText($"Set a password for {Path.GetFileName(file)}");
                        break;
                    case DroppedFileTypes.ProtectedFolder:
                        //This is a protected folder file, show the unlock page.
                        TC_Buttons.SelectedTab = TP_Unlock;
                        P_Controls.Show();

                        AnimateMiddleTextUpwards();
                        SetMiddleText("Enter the password for {}");
                        break;
                }
            }
        }
    }
}
