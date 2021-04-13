
namespace Assignment6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.graphSelect_cbx = new System.Windows.Forms.ComboBox();
            this.select_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Gadugi", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(72, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(613, 80);
            this.title.TabIndex = 0;
            this.title.Text = "WAKE UP PEOPLE!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "People often say that correlation does not equal causation,\r\nbut we know that\'s j" +
    "ust another one of the government\'s lies.\r\n\r\nFeast your eyes and know the truth:" +
    "";
            // 
            // graphSelect_cbx
            // 
            this.graphSelect_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphSelect_cbx.FormattingEnabled = true;
            this.graphSelect_cbx.Items.AddRange(new object[] {
            "What are those layers up to?",
            "Who really controls the weather?"});
            this.graphSelect_cbx.Location = new System.Drawing.Point(219, 244);
            this.graphSelect_cbx.Name = "graphSelect_cbx";
            this.graphSelect_cbx.Size = new System.Drawing.Size(275, 21);
            this.graphSelect_cbx.TabIndex = 2;
            // 
            // select_btn
            // 
            this.select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_btn.Location = new System.Drawing.Point(265, 306);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(167, 28);
            this.select_btn.TabIndex = 3;
            this.select_btn.Text = "Find out for yourself!";
            this.select_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 365);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.graphSelect_cbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox graphSelect_cbx;
        private System.Windows.Forms.Button select_btn;
    }
}

