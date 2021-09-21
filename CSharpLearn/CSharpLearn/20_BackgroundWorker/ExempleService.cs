using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn._20_BackgroundWorker
{
    public class ExempleService
    {

        //The following code is added when you drag a BackgroundWorker component onto a Form.
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

        public void Execute()
        {
            Console.WriteLine("Execute : BEGIN");

            //https://www.c-sharpcorner.com/uploadfile/mahesh/backgroundworker-in-C-Sharp/
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);

            Console.WriteLine("Execute : before  RunWorkerAsync");
            backgroundWorker1.RunWorkerAsync(2000);
            Console.WriteLine("Execute : after  RunWorkerAsync");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Execute : END");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("BackgroundWorker : BEGIN ");
            System.Threading.Thread.Sleep((int) e.Argument);
            Console.WriteLine("BackgroundWorker : END ");
        }
    }
}
