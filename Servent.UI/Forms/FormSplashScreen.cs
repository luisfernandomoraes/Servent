using System;
using System.Windows.Forms;
using Servent.UI.Classes;

namespace Servent.UI.Forms
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
              FadeEffect.FadeForm(this,150);
        }
    }
}
