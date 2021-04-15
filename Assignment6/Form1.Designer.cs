
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
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Gadugi", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(31, 53);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(695, 56);
            this.title.TabIndex = 0;
            this.title.Text = "WOW, THIS DATA IS USELESS!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are you in the market for data that has no practical purpose in your day-to-day l" +
    "ife?\r\n\r\n                                   Then we\'ve got a program for you!";
            // 
            // graphSelect_cbx
            // 
            this.graphSelect_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.graphSelect_cbx.FormattingEnabled = true;
            this.graphSelect_cbx.Items.AddRange(new object[] {
            "What are those layers up to?",
            "Who really controls the weather?"});
            this.graphSelect_cbx.Location = new System.Drawing.Point(220, 263);
            this.graphSelect_cbx.Name = "graphSelect_cbx";
            this.graphSelect_cbx.Size = new System.Drawing.Size(275, 21);
            this.graphSelect_cbx.TabIndex = 2;
            this.graphSelect_cbx.SelectedIndexChanged += new System.EventHandler(this.graphSelect_cbx_SelectedIndexChanged);
            // 
            // select_btn
            // 
            this.select_btn.Enabled = false;
            this.select_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_btn.Location = new System.Drawing.Point(267, 309);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(167, 28);
            this.select_btn.TabIndex = 3;
            this.select_btn.Text = "Show me the graph!";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select any one of our four useless topics and we\'ll give you an equally useless g" +
    "raph:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(18, 47);
            this.linkLabel1.Location = new System.Drawing.Point(422, 352);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(333, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Data courtessy of http://www.tylervigen.com/spurious-correlations";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 365);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

