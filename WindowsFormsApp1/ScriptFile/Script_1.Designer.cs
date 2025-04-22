namespace WindowsFormsApp1
{
    partial class Script_1
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbHotkey = new System.Windows.Forms.ComboBox();
            this.rdbPress = new System.Windows.Forms.RadioButton();
            this.rdbHold = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbHotkey
            // 
            this.cmbHotkey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHotkey.FormattingEnabled = true;
            this.cmbHotkey.Location = new System.Drawing.Point(27, 24);
            this.cmbHotkey.Name = "cmbHotkey";
            this.cmbHotkey.Size = new System.Drawing.Size(217, 29);
            this.cmbHotkey.TabIndex = 0;
            this.cmbHotkey.SelectedIndexChanged += new System.EventHandler(this.cmbHotkey_SelectedIndexChanged);
            // 
            // rdbPress
            // 
            this.rdbPress.AutoSize = true;
            this.rdbPress.Checked = true;
            this.rdbPress.Location = new System.Drawing.Point(290, 24);
            this.rdbPress.Name = "rdbPress";
            this.rdbPress.Size = new System.Drawing.Size(70, 25);
            this.rdbPress.TabIndex = 1;
            this.rdbPress.TabStop = true;
            this.rdbPress.Text = "press";
            this.rdbPress.UseVisualStyleBackColor = true;
            this.rdbPress.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdbHold
            // 
            this.rdbHold.AutoSize = true;
            this.rdbHold.Location = new System.Drawing.Point(290, 55);
            this.rdbHold.Name = "rdbHold";
            this.rdbHold.Size = new System.Drawing.Size(63, 25);
            this.rdbHold.TabIndex = 1;
            this.rdbHold.Text = "hold";
            this.rdbHold.UseVisualStyleBackColor = true;
            this.rdbHold.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // Script_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdbHold);
            this.Controls.Add(this.rdbPress);
            this.Controls.Add(this.cmbHotkey);
            this.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Script_1";
            this.Size = new System.Drawing.Size(381, 109);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHotkey;
        private System.Windows.Forms.RadioButton rdbPress;
        private System.Windows.Forms.RadioButton rdbHold;
    }
}
