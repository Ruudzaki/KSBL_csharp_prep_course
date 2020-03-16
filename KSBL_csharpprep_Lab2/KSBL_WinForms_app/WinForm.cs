using System;
using System.Windows.Forms;
using KSBL_Class_Library.Components.Speaker;
using KSBL_Class_Library.Mobile;

namespace KSBL_WinForms_app
{
    public partial class SelectPlaybackComponent : Form
    {
        public SelectPlaybackComponent(Mobile mobile, IOutput output)
        {
            InitializeComponent();
            Mobile = mobile;
            Mobile.Output = output;
        }

        public int Index { get; set; }

        public Mobile Mobile { get; set; }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Index = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Index = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Index = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Index = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.AppendText(Mobile.SelectPlaybackComponentWinForm(Index));
            textBox1.AppendText(Mobile.Play(new object()));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Mobile.ToString();
        }

        private void SelectPlaybackComponent_Load(object sender, EventArgs e)
        {
        }
    }
}