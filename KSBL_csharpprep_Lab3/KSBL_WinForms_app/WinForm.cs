using System;
using System.Windows.Forms;
using KSBL_Class_Library;
using KSBL_Class_Library.Mobile;

namespace KSBL_Win_Forms_app
{
    public partial class SelectPlaybackComponent : Form
    {
        public SelectPlaybackComponent(Mobile mobile, IOutput output)
        {
            InitializeComponent();
            Mobile = mobile;
            Mobile.Output = output;
        }

        public Mobile Mobile { get; set; }

        public int IndexPlaybackComponent { get; set; }
        public int IndexChargeComponent { get; set; }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            IndexPlaybackComponent = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            IndexPlaybackComponent = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            IndexPlaybackComponent = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            IndexPlaybackComponent = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.AppendText(Mobile.SelectPlaybackComponent(IndexPlaybackComponent));
            if (Mobile.PlaybackComponent != null)
                textBox1.AppendText(Mobile.Play(new object()));

            textBox1.AppendText(Environment.NewLine);

            textBox1.AppendText(Mobile.SelectChargeComponent(IndexChargeComponent));
            if (Mobile.ChargeComponent != null)
                textBox1.AppendText(Mobile.Charge());
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

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            IndexChargeComponent = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            IndexChargeComponent = 2;
        }
    }
}