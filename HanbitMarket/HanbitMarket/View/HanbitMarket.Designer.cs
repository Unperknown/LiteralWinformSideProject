namespace HanbitMarket.View
{
    partial class HanbitMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HanbitMarket));
            this.DatabaseViewSection = new System.Windows.Forms.DataGridView();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RewriteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseViewSection)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseViewSection
            // 
            this.DatabaseViewSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatabaseViewSection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DatabaseViewSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseViewSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseViewSection.Location = new System.Drawing.Point(0, 80);
            this.DatabaseViewSection.Margin = new System.Windows.Forms.Padding(0);
            this.DatabaseViewSection.Name = "DatabaseViewSection";
            this.DatabaseViewSection.RowHeadersWidth = 40;
            this.DatabaseViewSection.RowTemplate.Height = 37;
            this.DatabaseViewSection.Size = new System.Drawing.Size(790, 500);
            this.DatabaseViewSection.TabIndex = 0;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.DimGray;
            this.InsertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InsertButton.ForeColor = System.Drawing.Color.White;
            this.InsertButton.Location = new System.Drawing.Point(8, 8);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(0);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(190, 60);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "삽입";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.Color.DimGray;
            this.ModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyButton.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ModifyButton.ForeColor = System.Drawing.Color.White;
            this.ModifyButton.Location = new System.Drawing.Point(205, 8);
            this.ModifyButton.Margin = new System.Windows.Forms.Padding(0);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(185, 60);
            this.ModifyButton.TabIndex = 2;
            this.ModifyButton.Text = "수정";
            this.ModifyButton.UseVisualStyleBackColor = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DimGray;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(395, 8);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(185, 60);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "삭제";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RewriteButton
            // 
            this.RewriteButton.BackColor = System.Drawing.Color.DimGray;
            this.RewriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RewriteButton.Font = new System.Drawing.Font("돋움체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RewriteButton.ForeColor = System.Drawing.Color.White;
            this.RewriteButton.Location = new System.Drawing.Point(585, 8);
            this.RewriteButton.Margin = new System.Windows.Forms.Padding(0);
            this.RewriteButton.Name = "RewriteButton";
            this.RewriteButton.Size = new System.Drawing.Size(180, 60);
            this.RewriteButton.TabIndex = 4;
            this.RewriteButton.Text = "다시 쓰기";
            this.RewriteButton.UseVisualStyleBackColor = false;
            this.RewriteButton.Click += new System.EventHandler(this.RewriteButton_Click);
            // 
            // HanbitMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.RewriteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.DatabaseViewSection);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "HanbitMarket";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "한빛마트 관리";
            this.Load += new System.EventHandler(this.HanbitMarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseViewSection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatabaseViewSection;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RewriteButton;
    }
}

