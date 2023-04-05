namespace GetSha256
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtHashed = new System.Windows.Forms.TextBox();
            this.btnMakeHash = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIn
            // 
            this.txtIn.Location = new System.Drawing.Point(109, 51);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(157, 22);
            this.txtIn.TabIndex = 0;
            // 
            // txtHashed
            // 
            this.txtHashed.Location = new System.Drawing.Point(109, 162);
            this.txtHashed.Name = "txtHashed";
            this.txtHashed.Size = new System.Drawing.Size(570, 22);
            this.txtHashed.TabIndex = 1;
            // 
            // btnMakeHash
            // 
            this.btnMakeHash.Location = new System.Drawing.Point(112, 99);
            this.btnMakeHash.Name = "btnMakeHash";
            this.btnMakeHash.Size = new System.Drawing.Size(154, 23);
            this.btnMakeHash.TabIndex = 2;
            this.btnMakeHash.Text = "MakeHash ↓";
            this.btnMakeHash.UseVisualStyleBackColor = true;
            this.btnMakeHash.Click += new System.EventHandler(this.btnMakeHash_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(685, 162);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 208);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMakeHash);
            this.Controls.Add(this.txtHashed);
            this.Controls.Add(this.txtIn);
            this.Name = "Form1";
            this.Text = "ハッシュ値計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtHashed;
        private System.Windows.Forms.Button btnMakeHash;
        private System.Windows.Forms.Button btnCopy;
    }
}

