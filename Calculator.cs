using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Calculator : Form
    {
        private Form2 f2;

        public Calculator()
        {
            InitializeComponent();
            MessageBox.Show("합계 2가지 각인석을 골라주세요.");
        }

        private void bt_Armor_Click(object sender, EventArgs e)
        {
            int Armorbreak=0;
            int Attack=0;
            int Critical = 0;
            int Shot = 0;
            int Health = 0;
            if((rb_1.Checked || rb_2.Checked||rb_3.Checked||rb_4.Checked==true)&&(rb_5.Checked||rb_6.Checked==true)==true)
            {
                #region 체크박스 확인 
            if (rb_1.Checked)
            {
                Armorbreak +=  1150;
                Attack += 1000;
            }else if(rb_2.Checked)
            {
                Armorbreak += 1650;
                Critical += 11;
            }else if(rb_3.Checked)
            {
                Armorbreak += 1900;
            }else if(rb_4.Checked)
            {
                Armorbreak += 1300;
                Shot += 16;
            }
            if(rb_6.Checked)
            {
                Armorbreak += 1150;
                Health += 65000;
            }
            else if(rb_5.Checked)
            {
                Armorbreak += 2500;
            }

            if (rb_1.Checked && rb_6.Checked )
            {
                MessageBox.Show($"방어관통력 : {Armorbreak} , 공격력 : {Attack} , 체력 : {Health}");
            }
            if (rb_2.Checked && rb_6.Checked)
            {
                MessageBox.Show($"방어관통력 : {Armorbreak} , 치명타 확률 : {Critical} , 체력 : {Health}");
            }
            if (rb_3.Checked && rb_6.Checked)
            {
                MessageBox.Show($"방어관통력 : {Armorbreak} , 체력 : {Health}");
            }
            if (rb_4.Checked && rb_6.Checked)
            {
                MessageBox.Show($"방어관통력 : {Armorbreak} , 명중 : {Shot} , 체력 : {Health}");
            }
            if (rb_1.Checked && rb_5.Checked)
                {
                MessageBox.Show($"방어관통력 : {Armorbreak} , 공격력 : {Attack}");
            }
            if (rb_2.Checked && rb_5.Checked)
                {
                MessageBox.Show($"방어관통력 : {Armorbreak} , 치명타 확률 : {Critical}");
            }
            if (rb_3.Checked && rb_5.Checked)
                {
                MessageBox.Show($"방어관통력 : {Armorbreak}");
            }
            if (rb_4.Checked && rb_5.Checked)
                {
                MessageBox.Show($"방어관통력 : {Armorbreak} , 명중 : {Shot}");
                }
                #endregion
                f2 = new Form2();
                f2.Show();
                f2.SetCost1(Armorbreak, Critical, Shot, Health, Attack);
            }
            else
            {
                MessageBox.Show("첫번째 와 두번째 체크박스 모두 체크하시오");
            }


        }

        private void bt_resist_Click(object sender, EventArgs e)
        {
            int resistbreak = 0;
            int Attack = 0;
            int Critical = 0;
            int Shot = 0;
            int Health = 0;
            if ((rb_7.Checked || rb_8.Checked || rb_9.Checked || rb_10.Checked == true) && (rb_11.Checked || rb_12.Checked == true) == true)
            {
                #region 체크박스 확인 
                if (rb_7.Checked)
                {
                    resistbreak += 1150;
                    Attack += 1000;
                }
                else if (rb_8.Checked)
                {
                    resistbreak += 1650;
                    Critical += 11;
                }
                else if (rb_9.Checked)
                {
                    resistbreak += 1900;
                }
                else if (rb_10.Checked)
                {
                    resistbreak += 1300;
                    Shot += 16;
                }
                if (rb_12.Checked)
                {
                    resistbreak += 1150;
                    Health += 65000;
                }
                else if (rb_11.Checked)
                {
                    resistbreak += 2500;
                }

                if (rb_7.Checked && rb_12.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak} , 공격력 : {Attack} , 체력 : {Health}");
                }
                if (rb_8.Checked && rb_12.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak} , 치명타 확률 : {Critical} , 체력 : {Health}");
                }
                if (rb_9.Checked && rb_12.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak} , 체력 : {Health}");
                }
                if (rb_10.Checked && rb_12.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak} , 명중 : {Shot} , 체력 : {Health}");
                }
                if (rb_7.Checked && rb_11.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak} , 공격력 : {Attack}");
                }
                if (rb_8.Checked && rb_11.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak} , 치명타 확률 : {Critical}");
                }
                if (rb_9.Checked && rb_11.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak}");
                }
                if (rb_10.Checked && rb_11.Checked)
                {
                    MessageBox.Show($"저항관통력 : {resistbreak} , 명중 : {Shot}");
                }
                #endregion
                f2 = new Form2();
                f2.Show();
                f2.SetCost(resistbreak, Critical, Shot, Health, Attack);
            }
            else
            {
                MessageBox.Show("첫번째 와 두번째 체크박스 모두 체크하시오");
            }

        }
    }
}
