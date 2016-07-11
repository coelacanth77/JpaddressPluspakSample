namespace JpaddressPluspakSample
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gcPostalBarCode1 = new GrapeCity.Win.BarCode.GcPostalBarCode();
            this.gcJPAddress1 = new GrapeCity.Win.JPAddress.GcJPAddress();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gcPostalBarCode1
            // 
            this.gcPostalBarCode1.BarSize = ((GrapeCity.Win.BarCode.ValueType.BarSize)(resources.GetObject("gcPostalBarCode1.BarSize")));
            this.gcPostalBarCode1.Location = new System.Drawing.Point(13, 76);
            this.gcPostalBarCode1.Name = "gcPostalBarCode1";
            this.gcPostalBarCode1.Size = new System.Drawing.Size(243, 11);
            this.gcPostalBarCode1.ZipCodeInputControl = this.textBox1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gcPostalBarCode1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GrapeCity.Win.BarCode.GcPostalBarCode gcPostalBarCode1;
        private GrapeCity.Win.JPAddress.GcJPAddress gcJPAddress1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

