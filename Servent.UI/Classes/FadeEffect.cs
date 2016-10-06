using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Servent.UI.Classes
{
    public static class FadeEffect
    {

        /// <summary>
        /// Function used to fade out a form using a user defined number
        /// of steps
        /// </summary>
        /// <param name="f">The Windows form to fade out</param>
        /// <param name="numberOfSteps">The number of steps used to fade the form</param>
        public static void FadeForm(Form f, byte numberOfSteps)
        {
            float stepVal = (100f / numberOfSteps);
            float fOpacity = 0f;
            for (byte b = 0; b < numberOfSteps; b++)
            {
                f.Opacity = fOpacity / 100;
                f.Refresh();
                System.Threading.Thread.Sleep(30);
                fOpacity += stepVal;
            }
        }


    }
}
