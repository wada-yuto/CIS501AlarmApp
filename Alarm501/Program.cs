using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();

            //make controller
            //make form1
            //pass controller items to form1
            Controller controller = new Controller(form1.AlarmOff, form1.GetSnoozeTime);
            form1.SetUp(controller.ReadFile, controller.CountLine, controller.StartReadingAtLine, controller.AlarmCheckLogic, controller.SnoozeButtonClickLogic, 
                controller.StopButtonClickLogic, controller.GetAlarmTime, controller.AddButtonClickLogic, controller.EditButtonClickLogic);
            Application.Run(form1);
        }
    }
}
