﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;

namespace BSWebhookSender
{
    partial class BSForm1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSForm1));
            this.WebhookListbox = new System.Windows.Forms.ListBox();
            this.WebhookTB = new System.Windows.Forms.TextBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LOADWebhookBTN = new System.Windows.Forms.Button();
            this.PluusWebhookBTN = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.TimeListBox = new System.Windows.Forms.ListBox();
            this.tbxTime = new System.Windows.Forms.TextBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.lbNt = new System.Windows.Forms.Label();
            this.SenderTB = new System.Windows.Forms.TextBox();
            this.PromotionBTN = new System.Windows.Forms.Button();
            this.ContenTB = new System.Windows.Forms.TextBox();
            this.RemoveTimeBTN = new System.Windows.Forms.Button();
            this.ClearTimeBTN = new System.Windows.Forms.Button();
            this.DiscordBTN = new System.Windows.Forms.LinkLabel();
            this.YoutubeBTN = new System.Windows.Forms.LinkLabel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timePath = new System.Windows.Forms.TextBox();
            this.btntimePath = new System.Windows.Forms.Button();
            this.savetimeBTN = new System.Windows.Forms.Button();
            this.loadtimeBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WebhookListbox
            // 
            this.WebhookListbox.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WebhookListbox.ForeColor = System.Drawing.Color.Black;
            this.WebhookListbox.FormattingEnabled = true;
            this.WebhookListbox.ItemHeight = 16;
            this.WebhookListbox.Location = new System.Drawing.Point(15, 124);
            this.WebhookListbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WebhookListbox.Name = "WebhookListbox";
            this.WebhookListbox.Size = new System.Drawing.Size(318, 244);
            this.WebhookListbox.TabIndex = 1;
            // 
            // WebhookTB
            // 
            this.WebhookTB.BackColor = System.Drawing.SystemColors.Window;
            this.WebhookTB.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WebhookTB.ForeColor = System.Drawing.Color.DarkGray;
            this.WebhookTB.Location = new System.Drawing.Point(15, 375);
            this.WebhookTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WebhookTB.Multiline = true;
            this.WebhookTB.Name = "WebhookTB";
            this.WebhookTB.Size = new System.Drawing.Size(318, 21);
            this.WebhookTB.TabIndex = 2;
            this.WebhookTB.Text = "웹훅링크";
            this.WebhookTB.Enter += new System.EventHandler(this.WebhookTB_Enter);
            // 
            // SaveBTN
            // 
            this.SaveBTN.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SaveBTN.Location = new System.Drawing.Point(339, 124);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(76, 122);
            this.SaveBTN.TabIndex = 3;
            this.SaveBTN.Text = "저장";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "웹훅 리스트";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LOADWebhookBTN
            // 
            this.LOADWebhookBTN.Font = new System.Drawing.Font("휴먼모음T", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LOADWebhookBTN.Location = new System.Drawing.Point(339, 245);
            this.LOADWebhookBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LOADWebhookBTN.Name = "LOADWebhookBTN";
            this.LOADWebhookBTN.Size = new System.Drawing.Size(76, 122);
            this.LOADWebhookBTN.TabIndex = 7;
            this.LOADWebhookBTN.Text = "불러오기";
            this.LOADWebhookBTN.UseVisualStyleBackColor = true;
            this.LOADWebhookBTN.Click += new System.EventHandler(this.LOADWebhookBTN_Click);
            // 
            // PluusWebhookBTN
            // 
            this.PluusWebhookBTN.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PluusWebhookBTN.Location = new System.Drawing.Point(339, 375);
            this.PluusWebhookBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PluusWebhookBTN.Name = "PluusWebhookBTN";
            this.PluusWebhookBTN.Size = new System.Drawing.Size(76, 21);
            this.PluusWebhookBTN.TabIndex = 8;
            this.PluusWebhookBTN.Text = "추가";
            this.PluusWebhookBTN.UseVisualStyleBackColor = true;
            this.PluusWebhookBTN.Click += new System.EventHandler(this.PluusWebhookBTN_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // Delay
            // 
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // TimeListBox
            // 
            this.TimeListBox.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TimeListBox.ForeColor = System.Drawing.Color.Black;
            this.TimeListBox.FormattingEnabled = true;
            this.TimeListBox.ItemHeight = 16;
            this.TimeListBox.Location = new System.Drawing.Point(447, 124);
            this.TimeListBox.Name = "TimeListBox";
            this.TimeListBox.Size = new System.Drawing.Size(251, 244);
            this.TimeListBox.TabIndex = 9;
            // 
            // tbxTime
            // 
            this.tbxTime.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxTime.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxTime.Location = new System.Drawing.Point(447, 375);
            this.tbxTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxTime.Multiline = true;
            this.tbxTime.Name = "tbxTime";
            this.tbxTime.Size = new System.Drawing.Size(251, 21);
            this.tbxTime.TabIndex = 10;
            this.tbxTime.Text = "예) 오후 4:20:31";
            this.tbxTime.Enter += new System.EventHandler(this.tbxTime_Enter);
            // 
            // btnTime
            // 
            this.btnTime.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTime.Location = new System.Drawing.Point(704, 375);
            this.btnTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(74, 21);
            this.btnTime.TabIndex = 11;
            this.btnTime.Text = "추가";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // lbNt
            // 
            this.lbNt.AutoSize = true;
            this.lbNt.Font = new System.Drawing.Font("함초롬바탕 확장", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNt.Location = new System.Drawing.Point(444, 105);
            this.lbNt.Name = "lbNt";
            this.lbNt.Size = new System.Drawing.Size(40, 16);
            this.lbNt.TabIndex = 12;
            this.lbNt.Text = "Time";
            this.lbNt.UseMnemonic = false;
            // 
            // SenderTB
            // 
            this.SenderTB.BackColor = System.Drawing.SystemColors.Window;
            this.SenderTB.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SenderTB.ForeColor = System.Drawing.Color.DarkGray;
            this.SenderTB.Location = new System.Drawing.Point(14, 434);
            this.SenderTB.Name = "SenderTB";
            this.SenderTB.Size = new System.Drawing.Size(680, 23);
            this.SenderTB.TabIndex = 13;
            this.SenderTB.Text = "웹훅 이름";
            this.SenderTB.Enter += new System.EventHandler(this.SenderTB_Enter);
            // 
            // PromotionBTN
            // 
            this.PromotionBTN.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PromotionBTN.ForeColor = System.Drawing.Color.Black;
            this.PromotionBTN.Location = new System.Drawing.Point(700, 434);
            this.PromotionBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PromotionBTN.Name = "PromotionBTN";
            this.PromotionBTN.Size = new System.Drawing.Size(63, 261);
            this.PromotionBTN.TabIndex = 14;
            this.PromotionBTN.Text = "전송";
            this.PromotionBTN.UseVisualStyleBackColor = true;
            this.PromotionBTN.Click += new System.EventHandler(this.PromotionBTN_Click);
            // 
            // ContenTB
            // 
            this.ContenTB.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ContenTB.Location = new System.Drawing.Point(15, 463);
            this.ContenTB.Multiline = true;
            this.ContenTB.Name = "ContenTB";
            this.ContenTB.Size = new System.Drawing.Size(679, 232);
            this.ContenTB.TabIndex = 15;
            // 
            // RemoveTimeBTN
            // 
            this.RemoveTimeBTN.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RemoveTimeBTN.Location = new System.Drawing.Point(704, 289);
            this.RemoveTimeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveTimeBTN.Name = "RemoveTimeBTN";
            this.RemoveTimeBTN.Size = new System.Drawing.Size(74, 78);
            this.RemoveTimeBTN.TabIndex = 17;
            this.RemoveTimeBTN.Text = "선택\r\n삭제\r\n";
            this.RemoveTimeBTN.UseVisualStyleBackColor = true;
            this.RemoveTimeBTN.Click += new System.EventHandler(this.RemoveTimeBTN_Click);
            // 
            // ClearTimeBTN
            // 
            this.ClearTimeBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearTimeBTN.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClearTimeBTN.Location = new System.Drawing.Point(704, 234);
            this.ClearTimeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearTimeBTN.Name = "ClearTimeBTN";
            this.ClearTimeBTN.Size = new System.Drawing.Size(74, 47);
            this.ClearTimeBTN.TabIndex = 19;
            this.ClearTimeBTN.Text = "초기화";
            this.ClearTimeBTN.UseVisualStyleBackColor = true;
            this.ClearTimeBTN.Click += new System.EventHandler(this.ClearTimeBTN_Click);
            // 
            // DiscordBTN
            // 
            this.DiscordBTN.AutoSize = true;
            this.DiscordBTN.Font = new System.Drawing.Font("맑은 고딕 Semilight", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DiscordBTN.Location = new System.Drawing.Point(13, 699);
            this.DiscordBTN.Name = "DiscordBTN";
            this.DiscordBTN.Size = new System.Drawing.Size(53, 12);
            this.DiscordBTN.TabIndex = 20;
            this.DiscordBTN.TabStop = true;
            this.DiscordBTN.Text = "[ 디스코드 ]";
            this.DiscordBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DiscordBTN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DiscordBTN_LinkClicked);
            // 
            // YoutubeBTN
            // 
            this.YoutubeBTN.AutoSize = true;
            this.YoutubeBTN.Font = new System.Drawing.Font("맑은 고딕 Semilight", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.YoutubeBTN.Location = new System.Drawing.Point(72, 699);
            this.YoutubeBTN.Name = "YoutubeBTN";
            this.YoutubeBTN.Size = new System.Drawing.Size(44, 12);
            this.YoutubeBTN.TabIndex = 21;
            this.YoutubeBTN.TabStop = true;
            this.YoutubeBTN.Text = "[ 유튜브 ]";
            this.YoutubeBTN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.YoutubeBTN_LinkClicked);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPath.Location = new System.Drawing.Point(15, 78);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(318, 23);
            this.txtPath.TabIndex = 22;
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPath.Location = new System.Drawing.Point(339, 78);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(76, 23);
            this.btnPath.TabIndex = 23;
            this.btnPath.Text = "검색";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "웹훅 불러오기 경로지정";
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.White;
            this.info.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info.ForeColor = System.Drawing.SystemColors.ControlText;
            this.info.Location = new System.Drawing.Point(216, 16);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(199, 45);
            this.info.TabIndex = 26;
            this.info.Text = "* 저장 하실 때 .txt 꼭 붙혀주세요 !!\r\n* 웹훅 이름 꼭 지정해주세요 !!\r\n* https://discord.gg/sBUXRGc !!";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // timePath
            // 
            this.timePath.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timePath.Location = new System.Drawing.Point(447, 77);
            this.timePath.Name = "timePath";
            this.timePath.Size = new System.Drawing.Size(251, 23);
            this.timePath.TabIndex = 27;
            // 
            // btntimePath
            // 
            this.btntimePath.Font = new System.Drawing.Font("휴먼모음T", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btntimePath.Location = new System.Drawing.Point(704, 77);
            this.btntimePath.Name = "btntimePath";
            this.btntimePath.Size = new System.Drawing.Size(74, 23);
            this.btntimePath.TabIndex = 28;
            this.btntimePath.Text = "검색";
            this.btntimePath.UseVisualStyleBackColor = true;
            this.btntimePath.Click += new System.EventHandler(this.btntimePath_Click);
            // 
            // savetimeBTN
            // 
            this.savetimeBTN.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.savetimeBTN.Location = new System.Drawing.Point(704, 179);
            this.savetimeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savetimeBTN.Name = "savetimeBTN";
            this.savetimeBTN.Size = new System.Drawing.Size(74, 47);
            this.savetimeBTN.TabIndex = 29;
            this.savetimeBTN.Text = "저장";
            this.savetimeBTN.UseVisualStyleBackColor = true;
            this.savetimeBTN.Click += new System.EventHandler(this.savetimeBTN_Click);
            // 
            // loadtimeBTN
            // 
            this.loadtimeBTN.Font = new System.Drawing.Font("휴먼모음T", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loadtimeBTN.Location = new System.Drawing.Point(704, 124);
            this.loadtimeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadtimeBTN.Name = "loadtimeBTN";
            this.loadtimeBTN.Size = new System.Drawing.Size(74, 47);
            this.loadtimeBTN.TabIndex = 30;
            this.loadtimeBTN.Text = "불러오기";
            this.loadtimeBTN.UseVisualStyleBackColor = true;
            this.loadtimeBTN.Click += new System.EventHandler(this.loadtimeBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(444, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "시간 불러오기 경로지정";
            // 
            // BSForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 718);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loadtimeBTN);
            this.Controls.Add(this.savetimeBTN);
            this.Controls.Add(this.btntimePath);
            this.Controls.Add(this.timePath);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.YoutubeBTN);
            this.Controls.Add(this.DiscordBTN);
            this.Controls.Add(this.ClearTimeBTN);
            this.Controls.Add(this.RemoveTimeBTN);
            this.Controls.Add(this.ContenTB);
            this.Controls.Add(this.PromotionBTN);
            this.Controls.Add(this.SenderTB);
            this.Controls.Add(this.lbNt);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.tbxTime);
            this.Controls.Add(this.TimeListBox);
            this.Controls.Add(this.PluusWebhookBTN);
            this.Controls.Add(this.LOADWebhookBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.WebhookTB);
            this.Controls.Add(this.WebhookListbox);
            this.Font = new System.Drawing.Font("Tmon몬소리 Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BSForm1";
            this.Text = "봉순 웹훅 전송기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox WebhookListbox;
        private System.Windows.Forms.Button SaveBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button LOADWebhookBTN;
        private System.Windows.Forms.Button PluusWebhookBTN;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.ListBox TimeListBox;
        private System.Windows.Forms.TextBox tbxTime;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Label lbNt;
        private System.Windows.Forms.TextBox SenderTB;
        private System.Windows.Forms.Button PromotionBTN;
        private System.Windows.Forms.TextBox ContenTB;
        private bool oneSend = true;
        private List<string> Urls = new List<string>();
        private System.Windows.Forms.Button RemoveTimeBTN;
        private System.Windows.Forms.Button ClearTimeBTN;
        private System.Windows.Forms.LinkLabel DiscordBTN;
        private System.Windows.Forms.LinkLabel YoutubeBTN;
        private System.Windows.Forms.TextBox WebhookTB;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox timePath;
        private System.Windows.Forms.Button btntimePath;
        private System.Windows.Forms.Button savetimeBTN;
        private System.Windows.Forms.Button loadtimeBTN;
        private System.Windows.Forms.Label label3;
    }
}

