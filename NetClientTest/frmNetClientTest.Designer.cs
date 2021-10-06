
namespace NetClientTest
{
    partial class frmNetClientTest
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
            this.tbClient = new System.Windows.Forms.TextBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.tbClientPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbConnectIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PopUp1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pmnSendText = new System.Windows.Forms.ToolStripMenuItem();
            this.gbClient.SuspendLayout();
            this.PopUp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(12, 15);
            this.tbClient.Multiline = true;
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(265, 288);
            this.tbClient.TabIndex = 0;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.btnDisconnect);
            this.gbClient.Controls.Add(this.tbClientPort);
            this.gbClient.Controls.Add(this.btnConnect);
            this.gbClient.Controls.Add(this.tbConnectIP);
            this.gbClient.Controls.Add(this.label3);
            this.gbClient.Controls.Add(this.label2);
            this.gbClient.Location = new System.Drawing.Point(298, 61);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(216, 208);
            this.gbClient.TabIndex = 4;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(22, 164);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(150, 25);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // tbClientPort
            // 
            this.tbClientPort.Location = new System.Drawing.Point(103, 39);
            this.tbClientPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbClientPort.Name = "tbClientPort";
            this.tbClientPort.Size = new System.Drawing.Size(107, 25);
            this.tbClientPort.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(22, 124);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 25);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbConnectIP
            // 
            this.tbConnectIP.Location = new System.Drawing.Point(103, 80);
            this.tbConnectIP.Margin = new System.Windows.Forms.Padding(2);
            this.tbConnectIP.Name = "tbConnectIP";
            this.tbConnectIP.Size = new System.Drawing.Size(107, 25);
            this.tbConnectIP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "connect IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "port";
            // 
            // PopUp1
            // 
            this.PopUp1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.PopUp1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pmnSendText});
            this.PopUp1.Name = "PopUp1";
            this.PopUp1.Size = new System.Drawing.Size(211, 56);
            // 
            // pmnSendText
            // 
            this.pmnSendText.Name = "pmnSendText";
            this.pmnSendText.Size = new System.Drawing.Size(210, 24);
            this.pmnSendText.Text = "Send Text";
            this.pmnSendText.Click += new System.EventHandler(this.pmnSendText_Click);
            // 
            // frmNetClientTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 319);
            this.Controls.Add(this.gbClient);
            this.Controls.Add(this.tbClient);
            this.Name = "frmNetClientTest";
            this.Text = "NetClientTest";
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.PopUp1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.TextBox tbClientPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbConnectIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.ContextMenuStrip PopUp1;
        private System.Windows.Forms.ToolStripMenuItem pmnSendText;
    }
}

