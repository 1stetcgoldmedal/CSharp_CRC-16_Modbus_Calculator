namespace CRC_Calculator
{
    partial class Main
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
            this.IASCIIradioButton = new System.Windows.Forms.RadioButton();
            this.IHexradioButton = new System.Windows.Forms.RadioButton();
            this.InputtextBox = new System.Windows.Forms.TextBox();
            this.Outputpanel = new System.Windows.Forms.Panel();
            this.OASCIIradioButton = new System.Windows.Forms.RadioButton();
            this.OHexradioButton = new System.Windows.Forms.RadioButton();
            this.OutputtextBox = new System.Windows.Forms.TextBox();
            this.Inputpanel = new System.Windows.Forms.Panel();
            this.OHyphenheckBox = new System.Windows.Forms.CheckBox();
            this.BlankcheckBox = new System.Windows.Forms.CheckBox();
            this.ZeroXCheckBox = new System.Windows.Forms.CheckBox();
            this.Outputpanel.SuspendLayout();
            this.Inputpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IASCIIradioButton
            // 
            this.IASCIIradioButton.AutoSize = true;
            this.IASCIIradioButton.Location = new System.Drawing.Point(3, 30);
            this.IASCIIradioButton.Name = "IASCIIradioButton";
            this.IASCIIradioButton.Size = new System.Drawing.Size(54, 16);
            this.IASCIIradioButton.TabIndex = 2;
            this.IASCIIradioButton.Text = "ASCII";
            this.IASCIIradioButton.UseVisualStyleBackColor = true;
            // 
            // IHexradioButton
            // 
            this.IHexradioButton.AutoSize = true;
            this.IHexradioButton.Checked = true;
            this.IHexradioButton.Location = new System.Drawing.Point(63, 30);
            this.IHexradioButton.Name = "IHexradioButton";
            this.IHexradioButton.Size = new System.Drawing.Size(45, 16);
            this.IHexradioButton.TabIndex = 3;
            this.IHexradioButton.TabStop = true;
            this.IHexradioButton.Text = "Hex";
            this.IHexradioButton.UseVisualStyleBackColor = true;
            // 
            // InputtextBox
            // 
            this.InputtextBox.Location = new System.Drawing.Point(3, 3);
            this.InputtextBox.Name = "InputtextBox";
            this.InputtextBox.Size = new System.Drawing.Size(375, 21);
            this.InputtextBox.TabIndex = 0;
            this.InputtextBox.TextChanged += new System.EventHandler(this.InputtextBox_TextChanged);
            // 
            // Outputpanel
            // 
            this.Outputpanel.Controls.Add(this.ZeroXCheckBox);
            this.Outputpanel.Controls.Add(this.BlankcheckBox);
            this.Outputpanel.Controls.Add(this.OHyphenheckBox);
            this.Outputpanel.Controls.Add(this.OASCIIradioButton);
            this.Outputpanel.Controls.Add(this.OHexradioButton);
            this.Outputpanel.Controls.Add(this.OutputtextBox);
            this.Outputpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Outputpanel.Location = new System.Drawing.Point(0, 56);
            this.Outputpanel.Name = "Outputpanel";
            this.Outputpanel.Size = new System.Drawing.Size(382, 56);
            this.Outputpanel.TabIndex = 7;
            // 
            // OASCIIradioButton
            // 
            this.OASCIIradioButton.AutoSize = true;
            this.OASCIIradioButton.Location = new System.Drawing.Point(3, 30);
            this.OASCIIradioButton.Name = "OASCIIradioButton";
            this.OASCIIradioButton.Size = new System.Drawing.Size(52, 16);
            this.OASCIIradioButton.TabIndex = 2;
            this.OASCIIradioButton.Text = "UTF7";
            this.OASCIIradioButton.UseVisualStyleBackColor = true;
            this.OASCIIradioButton.CheckedChanged += new System.EventHandler(this.OASCIIradioButton_CheckedChanged);
            // 
            // OHexradioButton
            // 
            this.OHexradioButton.AutoSize = true;
            this.OHexradioButton.Checked = true;
            this.OHexradioButton.Location = new System.Drawing.Point(63, 30);
            this.OHexradioButton.Name = "OHexradioButton";
            this.OHexradioButton.Size = new System.Drawing.Size(45, 16);
            this.OHexradioButton.TabIndex = 3;
            this.OHexradioButton.TabStop = true;
            this.OHexradioButton.Text = "Hex";
            this.OHexradioButton.UseVisualStyleBackColor = true;
            this.OHexradioButton.CheckedChanged += new System.EventHandler(this.OHexradioButton_CheckedChanged);
            // 
            // OutputtextBox
            // 
            this.OutputtextBox.Location = new System.Drawing.Point(3, 3);
            this.OutputtextBox.Name = "OutputtextBox";
            this.OutputtextBox.Size = new System.Drawing.Size(375, 21);
            this.OutputtextBox.TabIndex = 0;
            // 
            // Inputpanel
            // 
            this.Inputpanel.Controls.Add(this.IASCIIradioButton);
            this.Inputpanel.Controls.Add(this.IHexradioButton);
            this.Inputpanel.Controls.Add(this.InputtextBox);
            this.Inputpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Inputpanel.Location = new System.Drawing.Point(0, 0);
            this.Inputpanel.Name = "Inputpanel";
            this.Inputpanel.Size = new System.Drawing.Size(382, 56);
            this.Inputpanel.TabIndex = 6;
            // 
            // OHyphenheckBox
            // 
            this.OHyphenheckBox.AutoSize = true;
            this.OHyphenheckBox.Location = new System.Drawing.Point(114, 30);
            this.OHyphenheckBox.Name = "OHyphenheckBox";
            this.OHyphenheckBox.Size = new System.Drawing.Size(67, 16);
            this.OHyphenheckBox.TabIndex = 4;
            this.OHyphenheckBox.Text = "Hyphen";
            this.OHyphenheckBox.UseVisualStyleBackColor = true;
            this.OHyphenheckBox.CheckedChanged += new System.EventHandler(this.OHyphenheckBox_CheckedChanged);
            // 
            // BlankcheckBox
            // 
            this.BlankcheckBox.AutoSize = true;
            this.BlankcheckBox.Location = new System.Drawing.Point(187, 31);
            this.BlankcheckBox.Name = "BlankcheckBox";
            this.BlankcheckBox.Size = new System.Drawing.Size(55, 16);
            this.BlankcheckBox.TabIndex = 5;
            this.BlankcheckBox.Text = "Blank";
            this.BlankcheckBox.UseVisualStyleBackColor = true;
            this.BlankcheckBox.CheckedChanged += new System.EventHandler(this.BlankcheckBox_CheckedChanged);
            // 
            // ZeroXCheckBox
            // 
            this.ZeroXCheckBox.AutoSize = true;
            this.ZeroXCheckBox.Location = new System.Drawing.Point(248, 31);
            this.ZeroXCheckBox.Name = "ZeroXCheckBox";
            this.ZeroXCheckBox.Size = new System.Drawing.Size(37, 16);
            this.ZeroXCheckBox.TabIndex = 6;
            this.ZeroXCheckBox.Text = "0x";
            this.ZeroXCheckBox.UseVisualStyleBackColor = true;
            this.ZeroXCheckBox.CheckedChanged += new System.EventHandler(this.ZeroXCheckBox_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 112);
            this.Controls.Add(this.Outputpanel);
            this.Controls.Add(this.Inputpanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(398, 151);
            this.MinimumSize = new System.Drawing.Size(398, 151);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRC_Calculator";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Outputpanel.ResumeLayout(false);
            this.Outputpanel.PerformLayout();
            this.Inputpanel.ResumeLayout(false);
            this.Inputpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton IASCIIradioButton;
        private System.Windows.Forms.RadioButton IHexradioButton;
        private System.Windows.Forms.TextBox InputtextBox;
        private System.Windows.Forms.Panel Outputpanel;
        private System.Windows.Forms.RadioButton OASCIIradioButton;
        private System.Windows.Forms.RadioButton OHexradioButton;
        private System.Windows.Forms.TextBox OutputtextBox;
        private System.Windows.Forms.Panel Inputpanel;
        private System.Windows.Forms.CheckBox ZeroXCheckBox;
        private System.Windows.Forms.CheckBox BlankcheckBox;
        private System.Windows.Forms.CheckBox OHyphenheckBox;
    }
}

