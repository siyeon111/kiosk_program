using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prtoject;
using System.Windows.Forms;

namespace prtojectfoam
{
    public partial class Form3 : Form
    {
        public event FormClosingEventHandler Form3Closing;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("카드 종류를 선택해주세요");
            }
            else
            {
                DialogResult result = MessageBox.Show("결제하시겠습니까?", "결제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("결제완료");
                    this.Close();

                }

            }

        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form3Closing?.Invoke(this, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
