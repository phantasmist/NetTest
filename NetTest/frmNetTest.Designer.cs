
namespace NetTest
{
    partial class frmNetTest
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.tbClientPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbClient.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbClient);
            this.splitContainer1.Panel2.Controls.Add(this.gbServer);
            this.splitContainer1.Size = new System.Drawing.Size(881, 466);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbServer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbClient);
            this.splitContainer2.Size = new System.Drawing.Size(600, 466);
            this.splitContainer2.SplitterDistance = 252;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbServer
            // 
            this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServer.Location = new System.Drawing.Point(3, 3);
            this.tbServer.Multiline = true;
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(594, 246);
            this.tbServer.TabIndex = 0;
            // 
            // tbClient
            // 
            this.tbClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClient.Location = new System.Drawing.Point(4, 3);
            this.tbClient.Multiline = true;
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(593, 202);
            this.tbClient.TabIndex = 1;
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.tbClientPort);
            this.gbClient.Controls.Add(this.btnConnect);
            this.gbClient.Controls.Add(this.tbServerIP);
            this.gbClient.Controls.Add(this.label3);
            this.gbClient.Controls.Add(this.label2);
            this.gbClient.Location = new System.Drawing.Point(23, 260);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(229, 194);
            this.gbClient.TabIndex = 3;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Client";
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
            this.btnConnect.Location = new System.Drawing.Point(22, 132);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 25);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(103, 80);
            this.tbServerIP.Margin = new System.Windows.Forms.Padding(2);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(107, 25);
            this.tbServerIP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "port";
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.tbServerPort);
            this.gbServer.Controls.Add(this.btnServerStart);
            this.gbServer.Controls.Add(this.label1);
            this.gbServer.Location = new System.Drawing.Point(23, 29);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(229, 141);
            this.gbServer.TabIndex = 0;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Server";
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(103, 39);
            this.tbServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(107, 25);
            this.tbServerPort.TabIndex = 6;
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(22, 96);
            this.btnServerStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(150, 25);
            this.btnServerStart.TabIndex = 2;
            this.btnServerStart.Text = "start";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "port";
            // 
            // frmNetTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 466);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmNetTest";
            this.Text = "NetTest";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TextBox tbClientPort;
        private System.Windows.Forms.TextBox tbServerPort;
    }
}

