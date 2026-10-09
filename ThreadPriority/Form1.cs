using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadPriority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            label1.Text = "-Thread Starts -";


            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            Thread threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
            Thread threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));


            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadC.Priority = System.Threading.ThreadPriority.AboveNormal;
            threadD.Priority = System.Threading.ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();


            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();


            label1.Text = "-End of Thread-";
        }
    }
}
