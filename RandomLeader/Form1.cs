using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLeader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

 

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            Random rand = new Random();
            // int leader = rand.Next(0, 40);
            DialogResult result;
            string leaderList = "曹操|刘备|孙坚|马腾|刘焉|董卓|刘表|袁绍|袁术|张鲁|吕布|公孙瓒|公孙度|刘虞|韩馥|司马懿|孔融|陶谦|王朗|严白虎|刘繇|张济|孟获|张角|何进|丁原|韩玄|金旋|赵范|刘度";
            string[] leaders = leaderList.Split('|');
            do
            {

                string randomLeader = leaders[rand.Next(0, leaders.Length)];
                string caption = "随机结果";
                MessageBoxButtons buttons = MessageBoxButtons.RetryCancel;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                result = MessageBox.Show(this, randomLeader, caption, buttons, icon);
            } while (result == DialogResult.Retry);
            Environment.Exit(0);
        }

    }
}
