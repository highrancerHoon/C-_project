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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<string> list = new List<string>() { "여우동", "도로시", "스타냐", "보르고스", "히카리", "No.9","몽테" ,"롤랑","데모나","실트","최덕팔"
            ,"슈타인"};
            foreach (var item in list)
                cb_name.Items.Add(item);
            WarriorList();
            PaladinList();
            ArcherList();
            HunterList();
            WizardList();
            HealerList();
            label6.ForeColor = Color.Orange;
        }
        #region TabControl의 리스트 추가 
        #region 전사
        public void WarriorList()
        {
            listView1.Items.Add(new ListViewItem(new String[]{"보르고스", "B", "F", "F", "B" }));
            listView1.Items.Add(new ListViewItem(new String[] { "몽테", "F", "S", "OP", "F" }));
            listView1.Items.Add(new ListViewItem(new String[] { "변검수", "A", "A", "A", "A" }));
            listView1.Items.Add(new ListViewItem(new String[] { "샬롯", "A", "A", "B", "A" }));
            listView1.Items.Add(new ListViewItem(new String[] { "잭", "A", "B", "B", "A" }));

        }
        #endregion
        #region 팔라딘
        public void PaladinList()
        {
            listView2.Items.Add(new ListViewItem(new String[] { "스타냐", "F", "B", "A", "A" }));
            listView2.Items.Add(new ListViewItem(new String[] { "롤랑", "B", "S", "S", "A" }));
        }
        #endregion
        #region 궁수
        public void ArcherList()
        {
            listView3.Items.Add(new ListViewItem(new String[] { "히카리", "B", "S", "S", "F" }));
            listView3.Items.Add(new ListViewItem(new String[] { "데모나", "A", "F", "F", "B" }));
        }
        #endregion
        #region 헌터
        public void HunterList()
        {
            listView4.Items.Add(new ListViewItem(new String[] { "No.9", "B", "B", "B", "F" }));
            listView4.Items.Add(new ListViewItem(new String[] { "실트", "B", "B", "B", "F" }));
        }
        #endregion
        #region 위자드
        public void WizardList()
        {
            listView5.Items.Add(new ListViewItem(new String[] { "도로시", "F", "A", "S", "F" }));
            listView5.Items.Add(new ListViewItem(new String[] { "최덕팔", "A", "OP", "OP", "F" }));
        }
        #endregion
        #region 프리스트
        public void HealerList()
        {
            listView6.Items.Add(new ListViewItem(new String[] { "여우동", "S", "B", "A", "S" }));
            listView6.Items.Add(new ListViewItem(new String[] { "슈타인", "F", "F", "F", "B" }));
        }
        #endregion
        #endregion

        #region Tabcontrol에서 메인으로 이름 보냄
        public void SelectHero()
        {
            try
            {
                cb_name.Text = listView1.FocusedItem.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show("예외가 발생하였습니다.");
            }
        }
        public void SelectHero1()
        {
            try
            {
                cb_name.Text = listView2.FocusedItem.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외가 발생하였습니다.");
            }
        }
        public void SelectHero2()
        {
            try
            {
                cb_name.Text = listView3.FocusedItem.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외가 발생하였습니다.");
            }
        }
        public void SelectHero3()
        {
            try
            {
                cb_name.Text = listView4.FocusedItem.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외가 발생하였습니다.");
            }
        }
        public void SelectHero4()
        {
            try
            {
                cb_name.Text = listView5.FocusedItem.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외가 발생하였습니다.");
            }
        }
        public void SelectHero5()
        {
            try
            {
                cb_name.Text = listView6.FocusedItem.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("예외가 발생하였습니다.");
            }
        }
        #endregion

        #region RankChange_Setup

        public void Rank(string a ,string b , string c ,string d)
        {
            
            if(a=="OP")
            {
                RankChallenge.ForeColor = Color.Green;
                RankChallenge.Text = "OP";
            }    
            else if (a == "S")
            {
                RankChallenge.ForeColor = Color.Red;
                RankChallenge.Text = "S";
            }
            else if (a == "A")
            {
                RankChallenge.ForeColor = Color.Blue;
                RankChallenge.Text = "A";
            }
            else 
            {
                RankChallenge.ForeColor = default;
                RankChallenge.Text = a;
            }
            if (b == "OP")
            {
                RankFight.ForeColor = Color.Green;
                RankFight.Text = "OP";
            }
            else if (b == "S")
            {
                RankFight.ForeColor = Color.Red;
                RankFight.Text = "S";
            }
            else if (b== "A")
            {
                RankFight.ForeColor = Color.Blue;
                RankFight.Text = "A";
            }
            else 
            {
                RankFight.ForeColor = default;
                RankFight.Text = b;
            }
            if (c == "OP")
            {
                RankFight1.ForeColor = Color.Green;
                RankFight1.Text = "OP";
            }
            else if (c== "S")
            {
                RankFight1.ForeColor = Color.Red;
                RankFight1.Text = "S";
            }
            else if (c == "A")
            {
                RankFight1.ForeColor = Color.Blue;
                RankFight1.Text = "A";
            }
            else
            {
                RankFight1.ForeColor = default;
                RankFight1.Text = c;
            }
            if (d == "OP")
            {
                RankAll.ForeColor = Color.Green;
                RankAll.Text = "OP";
            }
            else if (d == "S")
            {
                RankAll.ForeColor = Color.Red;
                RankAll.Text = "S";
            }
            else if (d == "A")
            {
                RankAll.ForeColor = Color.Blue;
                RankAll.Text = "A";
            }
            else
            {
                RankAll.ForeColor = default;
                RankAll.Text = d;
            }
        }
        #endregion

        #region 계약,일반과 전설 구분
        public void bt_set()
        {
            bt_1star.Enabled = false;
            bt_2star.Enabled = false;
            bt_3star.Enabled = false;
            MessageBox.Show("본 캐릭터는 4성부터 존재하는 캐릭터입니다.");
        }
        public void bt_legend_set()
        {
            bt_1star.Enabled = true;
            bt_2star.Enabled = true;
            bt_3star.Enabled = true;
            MessageBox.Show("본 캐릭터는 전설 캐릭터로 1성부터 존재하는 캐릭터입니다.");
        }
        #endregion

        #region 스킬 관련 
        public void Best_Skill(string a , string b)
        {
            #region 추천스킬이 없을 때
            if (a == "")
            {
                Pb_Skill1.Image = null;
                textBoxskill1.Text = "추천스킬이 없습니다.";
            }
            if (b == "")
            {
                Pb_Skill2.Image = null;
                textBoxskill2.Text = "추천스킬이 없습니다.";
            }
            #endregion

            #region 추천스킬 1
            if (a == "징벌의 혼")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("WarriorHorn.png")];
                textBoxskill1.Text = "10초간 징벌의 혼을 일깨웁니다. 공격력이 150%만큼 증가하고, 혼의 오라에 영향을 받는 적에게 1초당 방어력의 100%만큼 마법 피해를 줍니다. '징벌의 혼' 상태에는 30%의 밀림 저항을 얻습니다. 지속시간 도중 재발동 시, 분노를 폭발시켜 공격력의 200%만큼 무속성 피해를 줍니다.";
            }else if (a == "넘치는 투지")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Tuji.png")];
                textBoxskill1.Text = "즉시 10초간 자신의 공격력을 55%만큼, 방어력을 50%만큼 각각 증가시킵니다.";
            }else if(a == "무적의 방패")
            {
                
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Shield.png")];
                textBoxskill1.Text = "4초간 아군 전체에게 물리 피해 20%, 마법 피해 100% 방어하는 보호막을 생성하고 모든 해로운 효과에 면역이 됩니다.";
            }
            else if (a == "수호의 혼")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("PladinHorn.png")];
                textBoxskill1.Text = "10초 간 수호의 혼을 일께웁니다..방어력과 저항력이 200 % 증가하고 아군의 피해를 대신 받습니다. 효과 도중 다시 발동하면, 저항력의 100 % 만큼 무속성 피해를 주고 맞은 상대를 1.5초간 기절시킵니다.";
            }
            else if (a == "은혜의 빛")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("HolyHeal.png")];
                textBoxskill1.Text = "남은 체력이 가장 적은 용사와 리더의 체력을 공격력의 450%만큼 즉시 회복시키고 7초간 받는 피해를 50% 감소시킵니다.";
            }
            else if (a == "속사의 혼")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("ArcherHorn.png")];
                textBoxskill1.Text = "10초간 '속사의 혼'을 일깨웁니다. 공격력이 125%만큼 증가하고, 치명타 확률이 40%만큼 증가합니다. 지속시간 중 재발동 시, 10초간 모션속도가 10%만큼 증가하고, 회피율이 30%만큼 증가합니다.";
            }
            else if (a == "나비처럼 날아서 벌처럼 쏴라!")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Butterfly.png")];
                textBoxskill1.Text = "즉시 7초간 자신의 공격력을 55%, 치명타 확률을 30%만큼 증가시킵니다.";
            }
            else if (a == "필살의 혼")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("HunterHorn.png")];
                textBoxskill1.Text = "10초간 '필살의 혼'을 일깨웁니다. 공격력이 100%만큼 증가하고, 치명타 피해량이 150%만큼 증가합니다. 지속시간 중 재발동 시, 10초간 적을 공격할 때마다 폭발하여 공격력의 300%만큼 무속성 피해를 줍니다.(재사용 대기시간 : 0.5초)";
            }
            else if (a == "융단 폭격")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Boom.png")];
                textBoxskill1.Text = "공격력의 175 % 만큼 10회 물리피해를 주는 폭탄을 떨어트립니다.추가로 폭탄에 피격된 적은, 8초간 방어력과 저항력이 30 % 만큼 감소합니다.";
            }
            else if (a == "마나 재활용")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Manarestore.png")];
                textBoxskill1.Text = "즉시 자신의 블록을 두 개 생성하고, 다음 사용하는 스킬은 2회에 한해 70%만큼 공격력이 증폭되어 적용되고, 3초 동안 맞은 적의 방어력/저항력을 20% 만큼 감소시킵니다.";
            }
            else if (a == "그림자 마법사")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("WizardHorn.png")];
                textBoxskill1.Text = "즉시 15초간 따라다니며 소환자의 마법을 따라하는 그림자를 부릅니다. 그림자는 소환자의 모든 능력치를 125%만큼 부여받습니다. (그림자는 최대 2개까지 소환 가능합니다.)";
            }
            else if (a == "여신의 미소")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("GodnessSmile.png")];
                textBoxskill1.Text = "아군 전체의 체력을 공격력의 450%만큼 회복시키고, 5초간 받는 피해량이 50% 감소합니다. 이 효과는 해제되지 않습니다.";
            }
            else if (a == "여신의 활력")
            {
                Pb_Skill1.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("GodnessHealth.png")];
                textBoxskill1.Text = "즉시 리더의 블록 한 개, 자신의 블록을 한 개 생성하고, 아군 전체 체력을 3000 회복시킵니다.";
            }
            #endregion

            #region 스킬 추천 2
            if (b == "징벌의 혼")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("WarriorHorn.png")];
                textBoxskill2.Text = "10초간 징벌의 혼을 일깨웁니다. 공격력이 150%만큼 증가하고, 혼의 오라에 영향을 받는 적에게 1초당 방어력의 100%만큼 마법 피해를 줍니다. '징벌의 혼' 상태에는 30%의 밀림 저항을 얻습니다. 지속시간 도중 재발동 시, 분노를 폭발시켜 공격력의 200%만큼 무속성 피해를 줍니다.";
            }
            else if (b == "넘치는 투지")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Tuji.png")];
                textBoxskill2.Text = "즉시 10초간 자신의 공격력을 55%만큼, 방어력을 50%만큼 각각 증가시킵니다.";
            }
            else if (b == "무적의 방패")
            {

                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Shield.png")];
                textBoxskill2.Text = "4초간 아군 전체에게 물리 피해 20%, 마법 피해 100% 방어하는 보호막을 생성하고 모든 해로운 효과에 면역이 됩니다.";
            }
            else if (b == "수호의 혼")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("PaladinHorn.png")];
                textBoxskill2.Text = "10초 간 수호의 혼을 일께웁니다..방어력과 저항력이 200 % 증가하고 아군의 피해를 대신 받습니다. 효과 도중 다시 발동하면, 저항력의 100 % 만큼 무속성 피해를 주고 맞은 상대를 1.5초간 기절시킵니다.";
            }
            else if (b == "은혜의 빛")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("HolyHeal.png")];
                textBoxskill2.Text = "남은 체력이 가장 적은 용사와 리더의 체력을 공격력의 450%만큼 즉시 회복시키고 7초간 받는 피해를 50% 감소시킵니다.";
            }
            else if (b == "속사의 혼")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("ArcherHorn.png")];
                textBoxskill2.Text = "10초간 '속사의 혼'을 일깨웁니다. 공격력이 125%만큼 증가하고, 치명타 확률이 40%만큼 증가합니다. 지속시간 중 재발동 시, 10초간 모션속도가 10%만큼 증가하고, 회피율이 30%만큼 증가합니다.";
            }
            else if (b == "나비처럼 날아서 벌처럼 쏴라!")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Butterfly.png")];
                textBoxskill2.Text = "즉시 7초간 자신의 공격력을 55%, 치명타 확률을 30%만큼 증가시킵니다.";
            }
            else if (b == "필살의 혼")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("HunterHorn.png")];
                textBoxskill2.Text = "10초간 '필살의 혼'을 일깨웁니다. 공격력이 100%만큼 증가하고, 치명타 피해량이 150%만큼 증가합니다. 지속시간 중 재발동 시, 10초간 적을 공격할 때마다 폭발하여 공격력의 300%만큼 무속성 피해를 줍니다.(재사용 대기시간 : 0.5초)";
            }
            else if (b == "융단 폭격")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Boom.png")];
                textBoxskill2.Text = "공격력의 175 % 만큼 10회 물리피해를 주는 폭탄을 떨어트립니다.추가로 폭탄에 피격된 적은, 8초간 방어력과 저항력이 30 % 만큼 감소합니다.";
            }
            else if (b == "마나 재활용")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("Manarestore.png")];
                textBoxskill2.Text = "즉시 자신의 블록을 두 개 생성하고, 다음 사용하는 스킬은 2회에 한해 70%만큼 공격력이 증폭되어 적용되고, 3초 동안 맞은 적의 방어력/저항력을 20% 만큼 감소시킵니다.";
            }
            else if (b == "그림자 마법사")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("WizardHorn.png")];
                textBoxskill2.Text = "즉시 15초간 따라다니며 소환자의 마법을 따라하는 그림자를 부릅니다. 그림자는 소환자의 모든 능력치를 125%만큼 부여받습니다. (그림자는 최대 2개까지 소환 가능합니다.)";
            }
            else if (b == "여신의 미소")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("GodnessSmile.png")];
                textBoxskill2.Text = "아군 전체의 체력을 공격력의 450%만큼 회복시키고, 5초간 받는 피해량이 50% 감소합니다. 이 효과는 해제되지 않습니다.";
            }
            else if (b == "여신의 활력")
            {
                Pb_Skill2.Image = Skill_image.Images[Skill_image.Images.IndexOfKey("GodnessHealth.png")];
                textBoxskill2.Text = "즉시 리더의 블록 한 개, 자신의 블록을 한 개 생성하고, 아군 전체 체력을 3000 회복시킵니다.";
            }
            #endregion
        }
        #endregion 

        #region Charactor_setup
        private void cb_name_SelectedValueChanged(object sender, EventArgs e)
        {
            label6.Hide();
            #region 전사
            if (cb_name.Text == "보르고스")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Borgos.png")];                
                label1.Text = "보르고스의 등급별 스토리";
                bt_set();
                Best_Skill("징벌의 혼", "넘치는 투지");
                textBoxStat.Text = "#트루 3체인#자신 치명타 피해 증가#확정 치명타";
                Rank("B", "F", "F", "B");
            }
            if (cb_name.Text == "몽테")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Mongte.png")];               
                label1.Text = "몽테의 등급별 스토리";
                bt_set();
                Best_Skill("징벌의 혼", "넘치는 투지");
                textBoxStat.Text = "#자신 공격력 증가#자신 방어관통력 증가#자신 치명타 확률 증가#적 Sp 감소#자석 무시#아군 블록 생성";
                Rank("F", "S", "OP", "F");
            }
            #endregion
            #region 팔라딘
            if (cb_name.Text == "스타냐")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("stanya.png")];                
                label1.Text = "스타냐의 등급별 스토리";
                bt_set();
                Best_Skill("수호의 혼", "무적의 방패");
                textBoxStat.Text = "#트루 3체인#해로운 효과 면역#이로운 효과 해제#피격 반응#기절#자석#자신 블록 생성#무속성 피해#피해 면역#적 넉백#적 공중에 띄움";
                Rank("F", "B", "A", "A");
            }
            if (cb_name.Text == "롤랑")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Lolang.png")];
                label1.Text = "롤랑의 등급별 스토리";
                bt_legend_set();
                Best_Skill("수호의 혼", "은혜의 빛");
                textBoxStat.Text = "#적 회피 감소#피격 반응#저항력 비례 피해#기절#자석#자신 블록 생성";
                Rank("B", "S", "S", "A");
            }
            #endregion
            #region 궁수
            if (cb_name.Text == "히카리")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Hikari.png")];
                label1.Text = "히카리의 등급별 스토리";
                bt_set();
                Best_Skill("속사의 혼", "나비처럼 날아서 벌처럼 쏴라!");
                textBoxStat.Text = "#체인 무관#자동 공격#적 저항력 감소#적 공중에 띄움#적 넉백";
                Rank("B", "S", "S", "F");
            }
            if (cb_name.Text == "데모나")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Demona.png")];
                label1.Text = "데모나의 등급별 스토리";
                bt_legend_set();
                Best_Skill("속사의 혼", "나비처럼 날아서 벌처럼 쏴라!");
                textBoxStat.Text = "#무속성 피해#자신 공격력 증가#자신 저항관통력 증가#기절 면역";
                Rank("A", "F", "F", "B");
            }
            #endregion
            #region 헌터
            if (cb_name.Text == "No.9")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("No.9.png")];
                label1.Text = "No.9의 등급별 스토리";
                bt_set();
                Best_Skill("필살의 혼", "");
                textBoxStat.Text = "#체인 무관#자신 방어관통력 증가#자신 치명타 확률 증가#자신 치명타 피해 증가#회피 무시#기절#자석 무시#확정 치명타";
                Rank("B", "B", "B", "F");
            }
            if (cb_name.Text == "실트")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Slit.png")];
                label1.Text = "실트의 등급별 스토리";
                bt_set();
                Best_Skill("필살의 혼", "융단 폭격");
                textBoxStat.Text = "#적 치명타 저항 감소#적 넉백#적 공중에 띄움#무속성 피해#적 받는 피해 증가";
                Rank("S", "B", "B", "S");
            }
            #endregion
            #region 위자드
            if (cb_name.Text == "도로시")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Doroshi.png")];
                label1.Text = "도로시의 등급별 스토리";
                bt_legend_set();
                Best_Skill("마나 재활용", "그림자 마법사");
                textBoxStat.Text = "#트루 3체인#자동 공격#적 이로운 효과 제거#자신 저항관통력 증가#자신 블록 생성#자석(피해를 대신 받는 효과)무시";
                Rank("F", "A", "S", "F");
            }
            if (cb_name.Text == "최덕팔")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Chei.png")];
                label1.Text = "최덕팔의 등급별 스토리";
                bt_set();
                Best_Skill( "그림자 마법사","마나 재활용");
                textBoxStat.Text = "#적 속박#적 마법저항력 감소#이로운 효과 해제#자석(피해를 대신 받는 효과)무시#전체 소생 불가";
                Rank("A", "OP", "OP", "F");
            }
            #endregion
            #region 프리스트(힐러)
            if (cb_name.Text == "여우동")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("FoxDong.png")];
                label1.Text = "여우동의 등급별 스토리";
                bt_set();
                Best_Skill("여신의 활력", "여신의 미소");
                textBoxStat.Text = "#트루 3체인#아군 블록 생성#회복량 증가#아군 치명타 확률 증가#아군 회피율 증가";
                Rank("S", "B", "A", "S");
            }
            if (cb_name.Text == "슈타인")
            {
                tb_Info.Text = "";
                pictureBox1.Image = Charactor_image.Images[Charactor_image.Images.IndexOfKey("Sutain.png")];
                label1.Text = "슈타인의 등급별 스토리";
                bt_set();
                Best_Skill("여신의 활력", "여신의 미소");
                textBoxStat.Text = "#아군 공격력 증가#아군 저항력 증가#아군 방어력 증가#소환";
                Rank("F", "F", "F", "B");
            }
            #endregion           
        }
        #endregion

        #region 캐릭터 스토리 정리

        private void bt_1star_Click(object sender, EventArgs e)
        {
            #region 1성 스토리
            #region 전사
            #endregion
            #region 팔라딘
            if (cb_name.Text == "롤랑")
            {
                tb_Info.Text = ("여신교 수도회 소속의 견습 수도사. 소년 시절 여신교와 마족의 전투 여파에 휘말려 가족과 집을 잃고 고아가 되었다. 그 뒤 여신교에 받아들여져 견습 수도사로 자랐다고 한다.");
            }
            #endregion
            #region 궁수
            if (cb_name.Text == "데모나")
            {
                tb_Info.Text = ("100년전, 사도가 하슬라를 파괴하기 위해 다른 차원에서 데려온 악마들은 인간을 숙주 삼아 세상에 혼란을 가져왔다. 많은 인간이 악마의 하수인이 되어 고통받았고, 어린 데모나 또한 그 중 한명이었다.");
            }
            #endregion
            #region 헌터
            #endregion
            #region 위자드
            if (cb_name.Text == "도로시")
            {
                tb_Info.Text = ("마나란, 마법을 쓰기 위해 필요한 신비한 에너지다. 드물게 마나와의 친화력이 높은 사람이 태어나곤 하는데 친화력이 높을 수록 마법의 재능이 뛰어나다고 할 수 있다. 도로시는 이런 재능을 타고난 소녀였다.");
            }
            #endregion
            #region 프리스트
            #endregion

            #endregion
        }

        private void bt_2star_Click(object sender, EventArgs e)
        {
            #region 2성 스토리
            #region 전사
            #endregion
            #region 팔라딘
            if (cb_name.Text == "롤랑")
            {
                tb_Info.Text = ("힘세고 강한 롤랑은 기도와 수행보다 운동과 무력 행사에 더 뛰어난 소질을 가지고 있었다. 처음에는 그저 골칫덩어리였지만, 가끔 수도회에 시비를 걸어오는 불량배들을 혼내주고 나서는 신뢰를 얻고 있다.");
            }
            #endregion
            #region 궁수
            if (cb_name.Text == "데모나")
            {
                tb_Info.Text = ("몸 속의 악마와 힘겨운 싸움을 벌이고 있던 데모나, 그때 한 성녀가 나타나 데모나에게 축복을 전했고, 그 순간 악마의 영혼이 데모나의 몸 속에서 소멸되고 오직 악마의 힘만이 남았다. 악마를 이겨낸 존재 마족의 탄생이었다.");
            }
            #endregion
            #region 헌터
            #endregion
            #region 위자드
            if (cb_name.Text == "도로시")
            {
                tb_Info.Text = ("친화력이 높다고해서 누구나 마법을 쉽게 배울 수 있는 것은 아니다. 마법 또한 엄연한 학문이고 많은 공부와 연습이 필요했다. 하지만 도로시는 친화력 뿐만이 아니라 마법적 지식에도 높은 이해도를 보였다. 그야말로 천재였다.");
            }
            #endregion
            #region 프리스트
            #endregion
            #endregion
        }

        private void bt_3star_Click(object sender, EventArgs e)
        {
            #region 3성 스토리
            #region 전사
            #endregion
            #region 팔라딘
            if (cb_name.Text == "롤랑")
            {
                tb_Info.Text = ("자신의 장래에 대해 고민하기 시작한 롤랑. 방황을 일삼던 도중 우연히 마리아를 만나게 되고 그녀의 성품에 감화된다. 그 뒤 롤랑은 마리아와 함께 하기 위해 수도자로서 수련을 시작한다.");
            }
            #endregion
            #region 궁수
            if (cb_name.Text == "데모나")
            {
                tb_Info.Text = ("사람들은 이해할 수 없는 존재인 마족을 악마와 동일시하며 배척했고, 데모나는 홀로 고독한 싸움을 해야했다. 그 이후 세계 각지에서 마족들이 점차 생겨났고, 데모나는 그들을 모아 세력을 키우고 최초의 마왕이 되었다.");
            }
            #endregion
            #region 헌터
            #endregion
            #region 위자드
            if (cb_name.Text == "도로시")
            {
                tb_Info.Text = ("마법을 배우기 시작한지 얼마되지 않아 마법의 4대 속성인 불, 물, 바람, 대지의 힘을 모두 다를 수 있게 된 도로시. 그녀의 마법에 대한 갈망은 멈추지 않았다.");
            }
            #endregion
            #region 프리스트
            #endregion

            #endregion
        }

        private void bt_4star_Click(object sender, EventArgs e)
        {
            #region 4성 스토리
            #region 전사
            if (cb_name.Text == "보르고스")
            {
                tb_Info.Text = ("악당의 외모를 지녔지만 마음은 누구보다 천사 같은 아이였던 보르고스. 친구들과 놀고 싶은 마음에 언제나 악당 역을 자처했으나, 마음 한구석에는 친구들이 자신을 돌아봐주길 언제나 기대하고 있었다.");
            }
            if (cb_name.Text == "몽테")
            {
                tb_Info.Text = ("네스 제국에는 수많은 과학 집단이 있다.그 중 가장 우수한 두뇌들을 보유한 랩쳐사이언스는 어느 날 자신들의 연구 데이터를 훔쳐,R 시리즈를 만들어낸 로드인더스트리가 신흥 강자로 떠오르는 것을 보고 대항마로 몽테 프로젝트를 개시한다.몽테 프로토는 그 시작품으로 데이터를 얻어내기 위해 R-0을 전투 타깃으로 설정한다.");
            }
            #endregion
            #region 팔라딘
            if (cb_name.Text == "스타냐")
            {
                tb_Info.Text = ("기계도시 메카트로닉스의 젊은 공학도, 독학으로 기계를 만들다가 슈타인의 눈에 띄어 로봇공학에 입문한다. 그녀는 이후 센티널이라고 하는 로봇을 만들어 인류발전에 이바지하고자 한다.");
            }
            if (cb_name.Text == "롤랑")
            {
                tb_Info.Text = ("건실하게 노력한 끝에 인정받는 수도자가 된 롤랑. 여전히 불의를 보면 참지 못해 사고를 치지만, 이번에는 그런 능력을 높이 평가받아 여신교의 수호기사 후보에 오른다.");
            }
            #endregion
            #region 궁수
            if (cb_name.Text == "히카리")
            {
                tb_Info.Text = ("동부 왕국에서 온 유학생. 카오리라고 하는 언니가 있다. 히카리는 유학생활에 적응하지 못하고 있는 자신과 달리 혼자서 역경을 헤쳐 나가는 언니를 동경하고 있다.");
            }
            if (cb_name.Text == "데모나")
            {
                tb_Info.Text = ("사도 전쟁이 끝나고, 여신교는 일부 마족들에 의한 범죄를 들먹이며 그들을 탄압한다. 데모나는 더는 당하고만 살 수는 없다며 마족들을 일깨우고 여신교에 맞서 싸운다.");
            }
            #endregion
            #region 헌터
            if (cb_name.Text == "No.9")
            {
                tb_Info.Text = ("팔콘 부대 9번대 대장. 네스 제국군과의 전투로 부하를 모두 잃고 복수를 위해 악마와 계약한다. 악마는 반드시 명중하는 흉탄을 주며 그 대가로 탄환에 맞은 자의 영혼을 요구했다.");
            }
            if (cb_name.Text == "실트")
            {
                tb_Info.Text = ("바람조차 얼어붙어 누구도 찾지 않는 서리늑대의 관문 너머, 그곳에는 하슬라에 사는 이라면 누구라도 알고 있지만, 직접 본 사람은 손에 꼽는 '넘을수 없는 산맥'이 존재한다. 어느 날 , 그 산맥의 심장부, 한번도 햇빛이 비친 적 없는 거대한 공동에서 오래된 존재들이 눈을 떳다. 그중 하나의 이름은 실트, 바위가 깎여 모래알이 될 만큼의 세월동안 잠들어 있던 그녀에게 남은건 자신의 이름과 불완전한 '눈' 뿐이었다.");
            }
            #endregion
            #region 위자드
            if (cb_name.Text == "도로시")
            {
                tb_Info.Text = ("도로시의 탐구욕은 계속되었고 마침내 4대 마녀들의 제자가 되어 아무도 배우지 못한 금기의 마법인 어둠의 마법을 배워보겠다는 다짐에 이른다.");
            }
            if (cb_name.Text == "최덕팔")
            {
                tb_Info.Text = ("최덕팔은 원래 동부 왕국 한에서 갓을 만들어 파는 '입자장'으로 매우 엄격하고 주관적인 윤리관을 지닌 사람이었다. 그가 만드는 갓은 왕궁에 진상할 정도로 품질이 좋았으나 갓을 사려 들르는 사람들에게 온갖 잔소리를 퍼붓는 탓에 찾아오는 손님이 적어 가난한 생활을 유지했다고 한다. 그러던 어느 날 최덕팔은 갓을 납품하려 관청에 들렸다가 대낮부터 사또가 부녀자를 희롱하는 행패를 보게 되었다. 주변 사람들이 제발 성질 죽이고 못 본 척하라고 말렸지만, 최덕팔은 분노를 참지 못하고 기어이 탐관오리라고 한마디 했다가 처형당하고 말았다.");
            }
            #endregion
            #region 프리스트
            if (cb_name.Text == "여우동")
            {
                tb_Info.Text = ("동쪽 나라의 유명한 기녀, 그 실체는 사실 구미호로, 오랫동안 사람이 되기 위해 노력해오고 있었다.");
            }
            if (cb_name.Text == "슈타인")
            {
                tb_Info.Text = ("기계로 마법을 사용하는 마도공학분야의 박사. 자신의 연구를 아무도 알아주지 않아 회의감에 젖어있던 도중 네메시스라는 남자가 능력을 인정해주며 기계 병사를 만들어 줄 것을 요구한다.");
            }
            #endregion
            #endregion
        }

        private void bt_5star_Click(object sender, EventArgs e)
        {
            #region 5성 스토리
            #region 전사
            if (cb_name.Text == "보르고스")
            {
                tb_Info.Text = ("악당 역을 하고 있을 때는 주변 사람들이 자신을 주목해 준다는 것을 깨달은 보르고스. 사람들이 봐주길 원해 악의 조직에 가입하여 노력하던 와중 얼굴만 보고 사람들은 공포에 떨었고 정신을 차려보니 어느새 암흑 간부가 되어있었다!");
            }
            if (cb_name.Text == "몽테")
            {
                tb_Info.Text = ("몽테 프로토가 R-0 에게 파괴당한 후 가까스로 회수한 데이터 칩을 바탕으로 새로 제작한 몽테. 더 많은 데이터를 얻기위해 양산형으로 제작되었고 모든 몽테 양산형은 R-0 를 전투 타깃으로 삼는다.");
            }
            #endregion
            #region 팔라딘
            if (cb_name.Text == "스타냐")
            {
                tb_Info.Text = ("스승 슈타인이 스타냐의 기술을 빼앗아 기계군단을 만들자 그녀는 죄책감에 시달린다. 스타냐는 자신의 업보를 받아들이고자 스승이 만들어낸 기계를 모두 파괴하기로 한다.");
            }
            if (cb_name.Text == "롤랑")
            {
                tb_Info.Text = ("마침내 수호기사가 된 롤랑. 기사로서 수호해야 할 교단을 정할 때가 되었고 롤랑은 망설임 없이 마리아가 속한 빛의 성녀단을 선택한다. 그렇게 롤랑은 정의로운 마음씨와 실력으로 무장한 빛의 수호기사가 된다.");
            }
            #endregion
            #region 궁수
            if (cb_name.Text == "히카리")
            {
                tb_Info.Text = ("어렸을 적 부터 강하고. 거침없는 언니의 등만 보고 자랐던 히카리는 항상 자신을 언니와 비교했다. 때문에 히카리는 뛰어난 활 솜씨를 가지고 있음에도 열등감에 사로잡혀 제 실력을 모르고 있었다.");
            }
            if (cb_name.Text == "데모나")
            {
                tb_Info.Text = ("여신교와 마족의 오랜 대치가 이어지고 끊임없는 싸움에 지친 데모나는 마족들과 함께 살 곳을 찾아 새로운 삶을 시작한다. 그 땅에 발을 디딘 날. 마족들에게 새로운 새벽이 열렸다하여 데모나는 개벽의 왕이라 불리었다.");
            }
            #endregion
            #region 헌터
            if (cb_name.Text == "No.9")
            {
                tb_Info.Text = ("No.9는 악마에게 받은 흉탄으로 네스 제국부대를 하나 둘 추적해 섬멸한다. 총성이 울릴 때 마다 적이 쓰러졌고, 그들의 영혼은 고통스런 비명을 지르며 악마의 손아귀에 넘어갔다.");
            }
            if (cb_name.Text == "실트")
            {
                tb_Info.Text = "실트는 영문도 모른 채 어둠을 방황하다가, 같은 상황에 처해있던 '비오'와 부딪힌다. 실트는 비오와 함께 자신들이 처한 상황에 대해 이야기를 나누어 보았지만, 서로가 아주 오래전부터 아는 사이였다는 사실 외에는 마땅히 알 수 있는 것이 없었다. 달리 할 수 있는 일도 없었기에, 그들은 동굴 벽을 짚고 하염없이 걸어갔다. 얼마나 시간이 흘렀을까? 그들은 산맥너머, 세상의 끝에 다다랐다. 그순간, 어디선가 빛이 뿜어져나와 그들을 덮쳤다. 갑작스럽게 쏟아지는 빛줄기에 고통스러워하던 도중, 실트는 자신과 비오를 제외한 다른 6인의 그림자를 확인한다. 다음 순간, 세상의 끝에 다다른 이들은 정체불명의 힘에 의해 하슬라 각지로 날려간다.";
            }
            #endregion
            #region 위자드
            if (cb_name.Text == "도로시")
            {
                tb_Info.Text = ("4대 마녀의 제자가 된 도로시, 그녀는 동서남북을 돌아다니며 4대 마녀들의 제자가 되어 수련에 증진한다.");
            }
            if (cb_name.Text == "최덕팔")
            {
                tb_Info.Text = ("억울하게 죽음을 맞이한 최덕팔의 영혼은 자신을 인도하려 찾아온 사신을 앉혀놓고 사흘 밤낮동안 읍소했다. 그의 진심이 통한 것인지 우는 소리에 질린 것인지 사신은 진절머리를 내며 사라졌고, 최덕팔은 요괴 어둑시니가 되어 무덤에서 일어났다. 그는 밤의 어둠에 스며들어 자신을 처형한 사또를 찾아간뒤, 생전에 못다 한 잔소리를 퍼붓기 시작했다. 며칠동안 이어진 잔소리에 공포와 수치심을 이기지 못한 사또는 수척해진 끝에 돌연사하고 말았지만, 최덕팔은 그의 영혼을 무덤에서 일으켜 세워서까지 잔소리를 이어갔다. 결국 사또의 이성은 탈곡되어, 최덕팔의 뜻대로 움직이는 악령이 되고 말았다.");
            }
            #endregion
            #region 프리스트
            if (cb_name.Text == "여우동")
            {
                tb_Info.Text = ("끊임없는 노력으로 자신을 갈고 닦은 여우동. 어느새 사람들은 여우동의 지식과 미모에 찬사를 보내고 있었다. 그 중에서는 여우동이 사랑하게 된 사람도 있었다.");
            }
            if (cb_name.Text == "슈타인")
            {
                tb_Info.Text = ("슈타인은 자신의 능력을 증명하기 위해 제자의 로봇 설계도를 빼앗아 마도공학의 정수가 담긴 기계병기를 만든다. 이렇게 해서 기계군단 스티머가 탄생하지만 슈타인의 야욕은 멈추지 않았다.");
            }
            #endregion
            #endregion
        }

        private void bt_6star_Click(object sender, EventArgs e)
        {
            #region 6성 스토리
            #region 전사
            if (cb_name.Text == "보르고스")
            {
                tb_Info.Text = ("암흑 제왕이 된 보르고스. 기대한 대로 그를 적대시하는 가챠레인저가 등장했다! 언제나 패배하지만 포기 않고 자신을 찾아오는 레인저들을 보고 감동받은 그는 매번 복장과 메이크업을 달리하며 가챠레인저를 실망시키지 않기 위해 노력한다.");
            }
            if (cb_name.Text == "몽테")
            {
                tb_Info.Text = ("수 천기의 몽테가 희생되면서 만들어낸 데이터의 정수가 집약된 완전체. 랩처사이언스는 복수를 위해 몽테 크리스토에게 임무를 내린다. 임무 내용은 R-0의 완전파괴.");
            }
            #endregion
            #region 팔라딘
            if (cb_name.Text == "스타냐")
            {
                tb_Info.Text = ("그녀는 센티널을 파괴하기 위해 하슬라의 미래세계까지 슈타인을 쫓아간다. 그 곳에서 완성된 센티널과 조우, 파괴하지만 테이터 수집을 위한 복제품인 것을 알 게 되고, 진짜 센티널을 찾아 나선다.");
            }
            if (cb_name.Text == "롤랑")
            {
                tb_Info.Text = ("롤랑은 마리아와 뜻을 같이하며 그녀를 제 몸처럼 보살피면서, 빛의 성녀단 수호기사단장으로 거듭난다. 롤랑의 능력은 몹시 뛰어나 여신교에서 마리아 호위 일에 다른 일을 부탁할 정도이다. 최근에는 탈주자를 처치하라는 임무를 받았다.");
            }
            #endregion
            #region 궁수
            if (cb_name.Text == "히카리")
            {
                tb_Info.Text = ("어느 날, 히카리는 한 통의 편지를 받는다. 편지에는 '자신의 길을 걸어라'는 글이 담겨 있었다. 언니의 필체였다. 그 후, 히카리는 더 이상 언니의 등을 쫓지 않았다. 어려울 때면 자신을 믿고 시위를 당겼다. 그렇게 쏘아보낸 화살은 결코 빗나가는 법이 없었다.");
            }
            if (cb_name.Text == "데모나")
            {
                tb_Info.Text = ("데모나는 여신교의 세력이 강대해져 하슬라의 마족들이 다시 탄압받고 있다는 소식을 듣고, 다시 하슬라에서 싸우기로 결심했다. 데모나는 자신이 가진 악마의 힘을 더 강하게 키우기 위해 태초의 화산에서 홍련의 힘을 각성한다.");
            }
            #endregion
            #region 헌터
            if (cb_name.Text == "No.9")
            {
                tb_Info.Text = ("복수는 완성되었지만 밤마다 마탄에 죽어간 자들의 원혼이 No.9를 괴롭혔고 그 환각은 새로운 적의 목숨을 앗아갈 때야 사라졌다. 그녀는 자신이 악마를 대신해 영혼을 거두는 자이며, 전쟁터를 벗어날 수 없는 몸이 되었다는 것을 깨닫게 된다. '마탄의 사수'가 된 것이다.");
            }
            if (cb_name.Text == "실트")
            {
                tb_Info.Text = ("눈을 뜬 실트는 자신이 조그만 요정들에게 둘러싸여 있는 것을 알게 된다. 실트가 몸을 일으키자 그들은 혼비백산하여 몸을 숨기지만, 실트는 불완전한 '눈'으로도 그들 하나하나를 모두 볼 수 있었다. 그녀는 제일 화려한 날개를 지닌 요정을 붙잡아 정체를 물었고, 그 요정은 자신이 요정 촌장'오베론'이며 당장 놓아주지 않으면 그의 딸이 돌아와 실트를 용서하지 않을 거라며 울먹거린다. 실트는 울먹이는 오베론을 바라보다 가학심이 끓어오르는 것을 느끼고 스스로 놀라지만, 곧 씨익 웃으며 그를 마을 회관으로 끌고 간다. 실트는 마을 회관에 자리잡은 뒤, 요정들의 신목을 이용해 손이 가는 대로 장비를 만들고 오베론의 딸을 기다리기로 한다. 자신의 본성이 어떤 것인지 알게 될 날을 기다리며.");
            }
            #endregion
            #region 위자드
            if (cb_name.Text == "도로시")
            {
                tb_Info.Text = ("4대 비기를 습득하고 금기의 마법인 어둠마법을 터득한 도로시, 마녀들에게는 어둠마법은 금기이기 때문에 도로시는 마녀들에게 퇴출당하고 검은마녀라 불리게 되었다. 하지만 그녀는 어디까지나 순수하게 마법에 대해 더 알고 싶은 것 뿐이었고, 여신은 그녀에게 힘을 올바르게 쓸 수 있도록 사명을 내린다.");
            }
            if (cb_name.Text == "최덕팔")
            {
                tb_Info.Text = ("최덕팔은 아니꼬운 자신의 기준에 못되고 죄지은 자들을 찾아가 잔소리를 퍼부어 악령으로 만들어버리는 행위를 반복했다. 눈을 감아도 보이는 최덕팔의 아니꼬운 얼굴과 귀를 막아도 들려오는 잔소리가 한의 주민들을 공포에 떨게 하였고, 소문이 퍼지자 당시 신령의 우두머리였던 산군 태백이 최덕팔을 찾아가 크게 꾸짖었다. 그 포효를 들은 최덕팔은 겁에 질려 땅끝까지 도망쳤고, 훗날 마계를 평정하던 고르디안에게 발견되기 전까지 동굴에 숨어 벌벌 떨고 있었다고 한다. 둘 사이에 무슨 이야기가 오갔는지는 모르지만, 최덕팔은 고르디안의 인품에 크게 탄복하여 사천왕의 일원이 되기를 자처했고, 사석에서는 호형호제하는 사이가 되었다고 한다.");
            }
            #endregion
            #region 프리스트
            if (cb_name.Text == "여우동")
            {
                tb_Info.Text = ("사랑하는 사람을 지키기 위해 인간이 되는 것을 포기한 여우동. 하지만 그 사람은 여우동의 정체를 알고서도 그녀를 버리지 않았다. 비록 인간이 될 수는 없었지만, 그녀는 사랑을 얻게 되었다.");
            }
            if (cb_name.Text == "슈타인")
            {
                tb_Info.Text = ("자신의 연구를 완성시키기 위해 지식을 갈구하던 슈타인은 하슬라에서 데이터를 수집하던 중 미래로 통하는 차원문을 발견한다. 슈타인은 그 너머 세계에서 네스 제국에 도착한다.");
            }
            #endregion
            #endregion
        }

        #endregion

        #region 버튼 클릭시 각인석 폼으로 이동 (modaless Dialog)
        private void bt_Calcul_Click(object sender, EventArgs e)
        {
            Calculator modaless = null;
            if(modaless == null)
            {
                modaless = new Calculator();
                modaless.Show();
            }
            
        }
        #endregion

        #region 메인으로 전송하는 버튼
        private void bt_Hero_Click(object sender, EventArgs e)
        {
            SelectHero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectHero1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectHero5();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectHero4();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectHero3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectHero2();
        }
        #endregion


    }

}
