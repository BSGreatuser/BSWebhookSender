using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Text;

//Fonts = Tmon몬소리, 나눔바른고딕
namespace BSWebhookSender
{
    public partial class BSForm1 : Form
    {
        public BSForm1()
        {
            InitializeComponent();
            tmr.Start();
        }

        //웹훅 추가 버튼
        private void PluusWebhookBTN_Click(object sender, EventArgs e)
        { 
            if (this.WebhookTB.Text == null)
            {
                MessageBox.Show("웹훅을 입력해주세요!");
                return;
            }
            this.Urls.Add(this.WebhookTB.Text);
            this.WebhookListbox.Items.Clear();
            foreach (string item in this.Urls)
            {
                this.WebhookListbox.Items.Add(item);
            }
            this.WebhookTB.Clear();
        }

        //웹훅 불러오기 버튼
        private void ComeonWebhookBTN_Click(object sender, EventArgs e) // 불러오기
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = this.openFileDialog1.FileName;
                if (File.Exists(fileName))
                {
                    this.Urls.Clear();
                    this.WebhookListbox.Items.Clear();
                    foreach (string text in Functions.ReadFile(fileName))
                    {
                        this.Urls.Add(text.Trim());
                    }
                    foreach (string item in this.Urls)
                    {
                        this.WebhookListbox.Items.Add(item);
                    }
                }
            }
        }

        //웹훅 저장 버튼
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.Urls.Count == 0)
                {
                    MessageBox.Show("웹훅을 입력해주세요!");
                    return;
                }
                string fileName = this.saveFileDialog1.FileName;
                if (File.Exists(fileName))
                {
                    Functions.SaveFile(fileName, this.Urls);
                }
            }

        }

        //시간표시
        private void tmr_Tick(object sender, EventArgs e)
        {
            string text = DateTime.Now.ToString().Split(new char[]
            {
                ' '
            })[1] + " " + DateTime.Now.ToString().Split(new char[]
            {
                ' '
            })[2];
            this.lbNt.Text = text;
            for (int i = 0; i < this.TimeListBox.Items.Count; i++)
            {
                if (this.TimeListBox.Items[i].ToString() == text)
                {
                    this.PromotionBTN_Click(sender, e);
                    this.tmr.Enabled = false;
                    return;
                }
            }
        }

        //시간 추가 버튼
        private void btnTime_Click(object sender, EventArgs e)
        {
            if (this.tbxTime.Text.Length != 0)
            {
                this.TimeListBox.Items.Add(this.tbxTime.Text);
            }
            this.tbxTime.Clear();
        }

        //딜레이
        private void Delay_Tick(object sender, EventArgs e)
        {
            this.oneSend = true;
            this.tmr.Enabled = true;
            this.Delay.Enabled = false;
        }

        //전송 버튼
        private void PromotionBTN_Click(object sender, EventArgs e)
        {
            if (this.oneSend)
            {
                Functions.Promotion(this.Urls, this.ContenTB.Text, this.SenderTB.Text);
                this.oneSend = false;
                this.Delay.Enabled = true;
            }
        }

        //웹훅 작성란 기존 회색 텍스트 사라지기
        private void WebhookTB_Enter(object sender, EventArgs e)
        {
            if (WebhookTB.Text == "웹훅링크")
                WebhookTB.Text = null;
            WebhookTB.ForeColor = Color.Black;
        }

        //시간 작성란 기존 회색 텍스트 사라지기
        private void tbxTime_Enter(object sender, EventArgs e)
        {
            if (tbxTime.Text == "예) 오후 4:20:31")
                tbxTime.Text = null;
            tbxTime.ForeColor = Color.Black;
        }

        //웹훅이름 작성란 기존 회색 텍스트 사라지기
        private void SenderTB_Enter(object sender, EventArgs e)
        {
            if (SenderTB.Text == "웹훅 이름")
                SenderTB.Text = null;
            SenderTB.ForeColor = Color.Black;
         }

        private readonly object 봉순4888;

        //웹훅 리스트 선택 삭제
        private void RemoveItemBTN_Click(object sender, EventArgs e)
        {
            WebhookListbox.Items.Remove(WebhookListbox.SelectedItem);
        }

        //시간 리스트 선택 삭제
        private void RemoveTimeBTN_Click(object sender, EventArgs e)
        {
            TimeListBox.Items.Remove(TimeListBox.SelectedItem);
        }

        //웹훅 리스트 초기화
        private void ClearWebhookBTN_Click(object sender, EventArgs e)
        {
            this.WebhookListbox.Items.Clear();
        }

        //시간 리스트 초기화
        private void ClearTimeBTN_Click(object sender, EventArgs e)
        {
            this.TimeListBox.Items.Clear();
        }

        //=================================수정금지=================================//
        private void DiscordBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/sBUXRGc");
        }

        private void YoutubeBTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://youtube.com/c/봉순bs");
        }
    }
}

