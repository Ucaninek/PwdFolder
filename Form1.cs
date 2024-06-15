using Transitions;

namespace PwdFolder
{
    public partial class Form1 : Form
    {
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
    }
}
