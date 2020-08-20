namespace NginxAccessLogAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bFile = new System.Windows.Forms.Button();
            this.lFileName = new System.Windows.Forms.Label();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoteAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyBytesSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HttpReferer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HttpUserAgent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoteUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HttpXForwardedFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.lKeyword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.SuspendLayout();
            // 
            // bFile
            // 
            this.bFile.Location = new System.Drawing.Point(12, 15);
            this.bFile.Name = "bFile";
            this.bFile.Size = new System.Drawing.Size(91, 23);
            this.bFile.TabIndex = 0;
            this.bFile.Text = "选择日志文件";
            this.bFile.UseVisualStyleBackColor = true;
            this.bFile.Click += new System.EventHandler(this.bFile_Click);
            // 
            // lFileName
            // 
            this.lFileName.AutoSize = true;
            this.lFileName.Location = new System.Drawing.Point(109, 17);
            this.lFileName.Name = "lFileName";
            this.lFileName.Size = new System.Drawing.Size(0, 12);
            this.lFileName.TabIndex = 1;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.RemoteAddr,
            this.VisitTime,
            this.Action,
            this.Uri,
            this.Status,
            this.BodyBytesSent,
            this.HttpReferer,
            this.HttpUserAgent,
            this.Request,
            this.RemoteUser,
            this.TimeLocal,
            this.TimeZone,
            this.HttpXForwardedFor,
            this.log});
            this.dgvLog.Location = new System.Drawing.Point(12, 90);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowTemplate.Height = 23;
            this.dgvLog.Size = new System.Drawing.Size(985, 559);
            this.dgvLog.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 20F;
            this.id.HeaderText = "序号";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 54;
            // 
            // RemoteAddr
            // 
            this.RemoteAddr.DataPropertyName = "RemoteAddr";
            this.RemoteAddr.FillWeight = 60F;
            this.RemoteAddr.HeaderText = "IP";
            this.RemoteAddr.Name = "RemoteAddr";
            this.RemoteAddr.ReadOnly = true;
            // 
            // VisitTime
            // 
            this.VisitTime.DataPropertyName = "VisitTime";
            this.VisitTime.FillWeight = 50F;
            this.VisitTime.HeaderText = "时间";
            this.VisitTime.Name = "VisitTime";
            this.VisitTime.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Action.DataPropertyName = "Action";
            this.Action.FillWeight = 30F;
            this.Action.HeaderText = "方式";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 54;
            // 
            // Uri
            // 
            this.Uri.DataPropertyName = "Uri";
            this.Uri.HeaderText = "地址";
            this.Uri.Name = "Uri";
            this.Uri.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 30F;
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 54;
            // 
            // BodyBytesSent
            // 
            this.BodyBytesSent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BodyBytesSent.DataPropertyName = "BodyBytesSent";
            this.BodyBytesSent.FillWeight = 30F;
            this.BodyBytesSent.HeaderText = "大小";
            this.BodyBytesSent.Name = "BodyBytesSent";
            this.BodyBytesSent.ReadOnly = true;
            this.BodyBytesSent.Width = 54;
            // 
            // HttpReferer
            // 
            this.HttpReferer.DataPropertyName = "HttpReferer";
            this.HttpReferer.FillWeight = 50F;
            this.HttpReferer.HeaderText = "来源";
            this.HttpReferer.Name = "HttpReferer";
            this.HttpReferer.ReadOnly = true;
            // 
            // HttpUserAgent
            // 
            this.HttpUserAgent.DataPropertyName = "HttpUserAgent";
            this.HttpUserAgent.FillWeight = 120F;
            this.HttpUserAgent.HeaderText = "信息";
            this.HttpUserAgent.Name = "HttpUserAgent";
            this.HttpUserAgent.ReadOnly = true;
            // 
            // Request
            // 
            this.Request.DataPropertyName = "Request";
            this.Request.HeaderText = "Request";
            this.Request.Name = "Request";
            this.Request.ReadOnly = true;
            this.Request.Visible = false;
            // 
            // RemoteUser
            // 
            this.RemoteUser.DataPropertyName = "RemoteUser";
            this.RemoteUser.HeaderText = "RemoteUser";
            this.RemoteUser.Name = "RemoteUser";
            this.RemoteUser.ReadOnly = true;
            this.RemoteUser.Visible = false;
            // 
            // TimeLocal
            // 
            this.TimeLocal.DataPropertyName = "TimeLocal";
            this.TimeLocal.HeaderText = "TimeLocal";
            this.TimeLocal.Name = "TimeLocal";
            this.TimeLocal.ReadOnly = true;
            this.TimeLocal.Visible = false;
            // 
            // TimeZone
            // 
            this.TimeZone.DataPropertyName = "TimeZone";
            this.TimeZone.HeaderText = "TimeZone";
            this.TimeZone.Name = "TimeZone";
            this.TimeZone.ReadOnly = true;
            this.TimeZone.Visible = false;
            // 
            // HttpXForwardedFor
            // 
            this.HttpXForwardedFor.DataPropertyName = "HttpXForwardedFor";
            this.HttpXForwardedFor.HeaderText = "HttpXForwardedFor";
            this.HttpXForwardedFor.Name = "HttpXForwardedFor";
            this.HttpXForwardedFor.ReadOnly = true;
            this.HttpXForwardedFor.Visible = false;
            // 
            // log
            // 
            this.log.DataPropertyName = "log";
            this.log.HeaderText = "Log";
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Visible = false;
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(406, 51);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "搜索";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(59, 53);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(341, 21);
            this.tbKeyword.TabIndex = 5;
            // 
            // lKeyword
            // 
            this.lKeyword.AutoSize = true;
            this.lKeyword.Location = new System.Drawing.Point(12, 58);
            this.lKeyword.Name = "lKeyword";
            this.lKeyword.Size = new System.Drawing.Size(41, 12);
            this.lKeyword.TabIndex = 6;
            this.lKeyword.Text = "关键词";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 661);
            this.Controls.Add(this.lKeyword);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.dgvLog);
            this.Controls.Add(this.lFileName);
            this.Controls.Add(this.bFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nginx访问日志分析 - 彦桢 https://gitee.com/yanzhenbest/NginxAccessLogAnalysis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFile;
        private System.Windows.Forms.Label lFileName;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label lKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemoteAddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn VisitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodyBytesSent;
        private System.Windows.Forms.DataGridViewTextBoxColumn HttpReferer;
        private System.Windows.Forms.DataGridViewTextBoxColumn HttpUserAgent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemoteUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeZone;
        private System.Windows.Forms.DataGridViewTextBoxColumn HttpXForwardedFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn log;
    }
}

