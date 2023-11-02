using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("c:\\Data\\Data.txt"))
            { 
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        /// <summary>
        ///this is the normal click event of the method in which we cant perform another process on the form because of CountCharachter method because it is processing for 5 sec after its processing time is over after that only we can change the size or move the form .
        /// </summary>

        //private void ProcessFile_Click(object sender, EventArgs e)
        //{
        //    lblcount.Text = "Processing file.please wait";
        //    int Count = CountCharacters();
        //    lblcount.Text = Count.ToString() + " charaters in file";
        //}


        private async void ProcessFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblcount.Text = "Processing file.please wait";
            int Count = await task;
            lblcount.Text = Count.ToString() + " charaters in file";
        }
        //   When we use the async MethodAttributes then we do the multiple task at the same time 
    }
}
