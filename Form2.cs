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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            progressBar1.Value = 500000;
            lb_SlowText.Hide();
            lb_CriText.Hide();
        }
        public void SetCost(int a, int b, int c, int d, int e)
        {
            lb_Re.Text = Convert.ToString(a);
            lb_Cr.Text = Convert.ToString(b);
            lb_Sh.Text = Convert.ToString(c);
            lb_He.Text = Convert.ToString(d);
            lb_At.Text = Convert.ToString(e);

        }
        public void SetCost1(int a, int b, int c, int d, int e)
        {
            lb_Ar.Text = Convert.ToString(a);
            lb_Cr.Text = Convert.ToString(b);
            lb_Sh.Text = Convert.ToString(c);
            lb_He.Text = Convert.ToString(d);
            lb_At.Text = Convert.ToString(e);

        }

        int AttackCount = 0;
        int KillCount = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            
            Random ran = new Random();
            
            int Damage;
            int BaAt = int.Parse(lb_BaAt.Text);
            
            lb_SlowText.Hide();
            if(int.Parse(lb_Ar.Text)>0)
            { 
                #region 명중이 붙은 각인석 사용시 계산
            lb_Reduce.Text = lb_Sh.Text;
            if(int.Parse(lb_Sh.Text)>0)
            { 
                if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text)-int.Parse(lb_Sh.Text))
                {
                    lb_SlowText.Show();
                    AttackCount++;
                    lb_AttackCount.Text = AttackCount.ToString();
                }else
                { 
                Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EArmor.Text) - int.Parse(lb_Ar.Text)));
                lb_AllAttack.Text = Damage.ToString();
                        if ((progressBar1.Value - Damage) <= 0)
                        {
                            progressBar1.Value = 500000;
                            KillCount++;
                            lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                        else
                        {
                            progressBar1.Value -= Damage;
                            AttackCount++;
                            lb_AttackCount.Text = AttackCount.ToString();
                        }
             
                }
            }
            #endregion
                #region 공격력이 붙은 각인석 사용시 계산
            else if (int.Parse(lb_At.Text)>0)
            { 
                if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text))
                {
                    lb_SlowText.Show();
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                    }
                else
                {
                    Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EArmor.Text) - int.Parse(lb_Ar.Text)));
                    lb_AllAttack.Text = Damage.ToString();
                    if ((progressBar1.Value - Damage) <= 0)
                    {
                        progressBar1.Value = 500000;
                        KillCount++;
                        lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                    else
                        { 
                        progressBar1.Value -= Damage;
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                        }
                }
            }
                #endregion
                #region 크리티컬이 있는 각인석 사용시 계산

                else if (int.Parse(lb_Cr.Text) > 0)
            {
                if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text))
                {
                    lb_SlowText.Show();
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                    }
                else
                {
                    if (ran.Next(1, 101) <= 11)
                    {
                        Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EArmor.Text) - int.Parse(lb_Ar.Text))) * 2;
                        lb_AllAttack.Text = Damage.ToString();
                        lb_CriText.Show();
                    }
                    else
                    {
                        Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EArmor.Text) - int.Parse(lb_Ar.Text)));
                        lb_AllAttack.Text = Damage.ToString();
                        lb_CriText.Hide();
                    }

                    if ((progressBar1.Value - Damage) <= 0)
                    {
                        progressBar1.Value = 500000;
                        KillCount++;
                        lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                    else
                        {
                            progressBar1.Value -= Damage;
                            AttackCount++;
                            lb_AttackCount.Text = AttackCount.ToString();
                        }
                   
                }
            }
            #endregion
                #region 방어관통력만 존재하는 각인석 착용시 
            else
            {
                if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text))
                {
                    lb_SlowText.Show();
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                    }
                else
                {
                    Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EArmor.Text) - int.Parse(lb_Ar.Text)));
                    lb_AllAttack.Text = Damage.ToString();
                    if ((progressBar1.Value - Damage) <= 0)
                    {
                        progressBar1.Value = 500000;
                        KillCount++;
                        lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                    else
                        {
                            progressBar1.Value -= Damage;
                            AttackCount++;
                            lb_AttackCount.Text = AttackCount.ToString();
                        }
                        
                }
            }
                #endregion
            }else if(int.Parse(lb_Re.Text) > 0)
            {
                #region 명중이 붙은 각인석 사용시 계산
                lb_Reduce.Text = lb_Sh.Text;
                if (int.Parse(lb_Sh.Text) > 0)
                {
                    if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text) - int.Parse(lb_Sh.Text))
                    {
                        lb_SlowText.Show();
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                    }
                    else
                    {
                        Damage = ((BaAt +int.Parse(lb_At.Text)) - (int.Parse(lb_EResist.Text) - int.Parse(lb_Re.Text)));
                        lb_AllAttack.Text = Damage.ToString();
                        if ((progressBar1.Value - Damage) <= 0)
                        {
                            progressBar1.Value = 500000;
                            KillCount++;
                            lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                        else
                        { progressBar1.Value -= Damage;
                            AttackCount++;
                            lb_AttackCount.Text = AttackCount.ToString();
                        }
                    }
                }
                #endregion
                #region 공격력이 붙은 각인석 사용시 계산
                else if (int.Parse(lb_At.Text) > 0)
                {
                    if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text))
                    {
                        lb_SlowText.Show();
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                    }
                    else
                    {
                        Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EResist.Text) - int.Parse(lb_Re.Text)));
                        lb_AllAttack.Text = Damage.ToString();
                        if ((progressBar1.Value - Damage) <= 0)
                        {
                            progressBar1.Value = 500000;
                            KillCount++;
                            lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                        else
                        { progressBar1.Value -= Damage;
                            AttackCount++;
                            lb_AttackCount.Text = AttackCount.ToString();
                        }
                    }
                }
                #endregion
                #region 크리티컬이 있는 각인석 사용시 계산

                else if (int.Parse(lb_Cr.Text) > 0)
                {
                    if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text))
                    {
                        lb_SlowText.Show();
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                    }
                    else
                    {
                        if (ran.Next(1, 101) <= 11)
                        {
                            Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EResist.Text) - int.Parse(lb_Re.Text))) * 2;
                            lb_AllAttack.Text = Damage.ToString();
                            lb_CriText.Show();
                        }
                        else
                        {
                            Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EResist.Text) - int.Parse(lb_Re.Text)));
                            lb_AllAttack.Text = Damage.ToString();
                            lb_CriText.Hide();
                        }

                        if ((progressBar1.Value - Damage) <= 0)
                        {
                            progressBar1.Value = 500000;
                            KillCount++;
                            lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                        else
                        { progressBar1.Value -= Damage;
                            AttackCount++;
                            lb_AttackCount.Text = AttackCount.ToString();
                        }
                    }
                }
                #endregion
                #region 저항관통력만 존재하는 각인석 착용시 
                else
                {
                    if (ran.Next(1, 101) <= int.Parse(lb_Slow.Text))
                    {
                        lb_SlowText.Show();
                        AttackCount++;
                        lb_AttackCount.Text = AttackCount.ToString();
                    }
                    else
                    {
                        Damage = ((BaAt + int.Parse(lb_At.Text)) - (int.Parse(lb_EResist.Text) - int.Parse(lb_Re.Text)));
                        lb_AllAttack.Text = Damage.ToString();
                        if ((progressBar1.Value - Damage) <= 0)
                        {
                            progressBar1.Value = 500000;
                            KillCount++;
                            lb_KillCount.Text = KillCount.ToString();
                            lb_AtAllCount.Text = lb_AttackCount.Text;
                            AttackCount = 0;
                            lb_AttackCount.Text = "0";
                        }
                        else
                        { progressBar1.Value -= Damage;
                            AttackCount++;
                            lb_AttackCount.Text = AttackCount.ToString();
                        }
                    }
                }
                #endregion
            }
        }
    }
}
