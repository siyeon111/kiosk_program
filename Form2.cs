using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prtoject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace prtojectfoam
{
    public partial class Form2 : Form
    {
        System.Windows.Forms.TextBox textBox3;
        System.Windows.Forms.RichTextBox richTextBox10;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(ref System.Windows.Forms.TextBox txtbox1, ref System.Windows.Forms.RichTextBox txtbox2)
        {
            textBox3 = txtbox1;
            richTextBox10 = txtbox2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strOrder = "";
            richTextBox1.Text = "";

            if (rdbF15.Checked == true)
                strOrder += rdbF15.Text + "\n";
            if (rdbT30.Checked == true)
                strOrder += rdbT30.Text + "\n";

            if (rdbTosting.Checked == true)
                strOrder += rdbTosting.Text + "\n";
            if (rdbNottosting.Checked == true)
                strOrder += rdbNottosting.Text + "\n";

            if (rdbHoneyot.Checked == true)
                strOrder += rdbHoneyot.Text + "\n";
            if (rdbHati.Checked == true)
                strOrder += rdbHati.Text + "\n";
            if (rdbWiti.Checked == true)
                strOrder += rdbWiti.Text + "\n";
            if (rdbOrega.Checked == true)
                strOrder += rdbOrega.Text + "\n";
            if (rdbWhite.Checked == true)
                strOrder += rdbWhite.Text + "\n";
            if (rdbPlat.Checked == true)
                strOrder += rdbPlat.Text + "\n";

            if (rdbMocha.Checked == true)
                strOrder += rdbMocha.Text + "\n";
            if (rdbShu.Checked == true)
                strOrder += rdbShu.Text + "\n";
            if (rdbAmerican.Checked == true)
                strOrder += rdbAmerican.Text + "\n";

            if (ckbLettuce.Checked == true)
                strOrder += ckbLettuce.Text + "\n";
            if (ckbTomata.Checked == true)
                strOrder += ckbTomata.Text + "\n";
            if (ckbOe.Checked == true)
                strOrder += ckbOe.Text + "\n";
            if (ckbPimang.Checked == true)
                strOrder += ckbPimang.Text + "\n";
            if (ckbOnion.Checked == true)
                strOrder += ckbOnion.Text + "\n";
            if (ckbPikkle.Checked == true)
                strOrder += ckbPikkle.Text + "\n";
            if (ckbOlive.Checked == true)
                strOrder += ckbOlive.Text + "\n";

            if (ckbRanch.Checked == true)
                strOrder += ckbRanch.Text + "\n";
            if (ckbMayo.Checked == true)
                strOrder += ckbMayo.Text + "\n";
            if (ckbHot.Checked == true)
                strOrder += ckbHot.Text + "\n";
            if (ckbmustta.Checked == true)
                strOrder += ckbmustta.Text + "\n";
            if (ckbSweetonion.Checked == true)
                strOrder += ckbSweetonion.Text + "\n";
            if (ckbSweetchile.Checked == true)
                strOrder += ckbSweetchile.Text + "\n";
            if (ckbSalt.Checked == true)
                strOrder += ckbSalt.Text + "\n";
            if (ckbHucu.Checked == true)
                strOrder += ckbHucu.Text + "\n";

            if (ckbEggmayo.Checked == true)
                strOrder += ckbEggmayo.Text + "\n";
            if (ckbPeperoni.Checked == true)
                strOrder += ckbPeperoni.Text + "\n";
            if (ckbBacon.Checked == true)
                strOrder += ckbBacon.Text + "\n";
            if (ckbAvocado.Checked == true)
                strOrder += ckbAvocado.Text + "\n";
            if (ckbOmulet.Checked == true)
                strOrder += ckbOmulet.Text + "\n";

            if (rdbSet.Checked == true)
                strOrder += rdbSet.Text + "\n";
            if (rdbOnly.Checked == true)
                strOrder += rdbOnly.Text + "\n";

            if (rdbChoco.Checked == true)
                strOrder += rdbChoco.Text + "\n";
            if (rdbDoublecho.Checked == true)
                strOrder += rdbDoublecho.Text + "\n";
            if (rdbOtmil.Checked == true)
                strOrder += rdbOtmil.Text + "\n";
            if (rdbrazebery.Checked == true)
                strOrder += rdbrazebery.Text + "\n";
            if (rdbWhitechoco.Checked == true)
                strOrder += rdbWhitechoco.Text + "\n";

            if (rdbF15.Checked == false && rdbT30.Checked == false)
                MessageBox.Show("빵 길이를 선택해주세요.");
            else if (rdbTosting.Checked == false && rdbNottosting.Checked == false)
                MessageBox.Show("토스팅을 선택해주세요.");
            else if (rdbHoneyot.Checked == false && rdbHati.Checked == false && rdbWiti.Checked == false && rdbOrega.Checked == false
                     && rdbWhite.Checked == false && rdbPlat.Checked == false)
                MessageBox.Show("빵을 선택해주세요.");
            else if (rdbMocha.Checked == false && rdbShu.Checked == false && rdbAmerican.Checked == false)
                MessageBox.Show("치즈를 선택해주세요.");
            else if (ckbLettuce.Checked == false && ckbTomata.Checked == false && ckbOe.Checked == false && ckbPimang.Checked == false
                     && ckbOnion.Checked == false && ckbPikkle.Checked == false && ckbOlive.Checked == false)
                MessageBox.Show("야채를 선택해주세요.");
            else if (ckbRanch.Checked == false && ckbMayo.Checked == false && ckbHot.Checked == false && ckbmustta.Checked == false
                     && ckbSweetonion.Checked == false && ckbSweetchile.Checked == false && ckbSalt.Checked == false && ckbHucu.Checked == false)
                MessageBox.Show("소스를 선택해주세요.");
            else if (rdbSet.Checked == false && rdbOnly.Checked == false)
                MessageBox.Show("세트/단품을 선택해주세요.");
            else if (rdbChoco.Checked == false && rdbDoublecho.Checked == false && rdbOtmil.Checked == false && rdbrazebery.Checked == false
                     && rdbWhitechoco.Checked == false)
                MessageBox.Show("쿠키를 선택해주세요.");

            richTextBox1.Text = strOrder;
            textBox1.Text = Form1.totalPrice.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)//주문담기
        {
            string selectedMenuItem = "";
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    selectedMenuItem = checkBox.Text;
                    break;
                }
            }

            if (selectedMenuItem != "")
            {
                // foam2의 주문 목록을 foam1으로 이동
                MoveItemsFromFoam2ToFoam1(selectedMenuItem);

                // foam1의 총 금액 계산하여 업데이트
                Form1.totalPrice += CalculateTotalPrice(selectedMenuItem);
                // MoveTotalPriceToTextBox3();

                // 폼2 닫기
                this.Close();
            }
            else
            {
                MessageBox.Show("메뉴를 선택하세요.");
            }
        }

        private void MoveItemsFromFoam2ToFoam1(string selectedMenuItem)
        {
            // foam2의 주문 목록 가져오기
            string foam2Orders = richTextBox1.Text;

            // foam1의 주문 목록에 추가
            richTextBox10.AppendText(selectedMenuItem + "\n");
            richTextBox10.AppendText(foam2Orders);

            // foam2의 주문 목록 지우기
            richTextBox1.Clear();
        }

        // 주문목록에서 총 가격을 계산하는 함수
        private int CalculateTotalPrice(string orders)
        {
            int totalPrice = 0;
            // 주문목록을 라인으로 분할하여 각 항목을 확인합니다.
            string[] items = orders.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in items)
            {
                // 각 항목의 가격을 계산하여 totalPrice에 더합니다.
                totalPrice += GetPrice(item);
            }
            return totalPrice;
        }

        // 항목별 가격을 반환하는 함수 (임의로 가격을 설정합니다)
        private int GetPrice(string item)
        {
            switch (item)
            {
                case "F15": return 15;
                case "T30": return 30;
                // 필요한 경우 다른 항목의 가격을 추가합니다.
                default: return 0;
            }
        }

        public int totalPrice = 0;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 폼1으로 돌아가도록 수정
            //Form1 form1 = new Form1();
            //this.Visible = false;
            //form1.ShowDialog();


            // 모든 체크박스와 라디오 버튼 초기화
            ClearAllControls(this);
            textBox1.Text = "0"; // 총 금액 초기화

            richTextBox10.Clear();
            
            Form1 form1;
            form1 = new Form1();
            

            //foreach (Control control in form1.Controls)
            //{
            //    if (control is CheckBox checkBox)
            //    {
            //        checkBox.Checked = false;
            //    }
            //    else if (control is RadioButton radioButton)
            //    {
            //        radioButton.Checked = false;
            //    }
            //    else if (control.HasChildren)
            //    {
            //        ClearAllControls(control);
            //    }
            //}

            this.Close();
        }

        private void ClearAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
                else if (control.HasChildren)
                {
                    ClearAllControls(control);
                }
            }

            // 총 금액 초기화
            Form1.totalPrice = 0;
        }

        private void rdbT30_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(rdbT30, lbT30);
        }

        private void ckbEggmayo_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbEggmayo, lbEggmayo);
        }

        private void ckbPeperoni_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbPeperoni, lbPeperoni);
        }

        private void ckbBacon_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbBacon, lbBacon);
        }

        private void ckbAvocado_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbAvocado, lbAvocado);
        }

        private void ckbOmulet_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(ckbOmulet, lbOmulet);
        }

        private void rdbSet_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice(rdbSet, lbSet);
        }

        private void UpdatePrice(Control control, Label priceLabel)
        {
            int price = int.Parse(priceLabel.Text);

            if (control is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    Form1.totalPrice += price;
                }
                else
                {
                    Form1.totalPrice -= price;
                }
            }
            else if (control is RadioButton radioButton)
            {
                if (radioButton.Checked)
                {
                    Form1.totalPrice += price;
                }
                else
                {
                    Form1.totalPrice -= price;
                }
            }

            // Ensure totalPrice does not go negative
            if (Form1.totalPrice < 0)
            {
                Form1.totalPrice = 0;
            }

            textBox1.Text = Form1.totalPrice.ToString();
        }
    }
}

