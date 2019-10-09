using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAncAwait
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
            using (StreamReader reader = new StreamReader("C:\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;

                Thread.Sleep(5000);
            }

            return count;
        }

        private async void btnProcessFile_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            lblResult.Text = "Processing File. Please wait...";
            int count = await task;
            lblResult.Text = count.ToString() + " characters in file";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblResult.Text = "";
        }
    }
}
