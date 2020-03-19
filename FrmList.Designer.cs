namespace cSharp___Listbox
{
    partial class FrmList
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
            this.BtnAddItem = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LbxTest = new System.Windows.Forms.ListBox();
            this.TxtItem = new System.Windows.Forms.TextBox();
            this.BtnDog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.Location = new System.Drawing.Point(421, 73);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(140, 54);
            this.BtnAddItem.TabIndex = 1;
            this.BtnAddItem.Text = "Add Item";
            this.BtnAddItem.UseVisualStyleBackColor = true;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(421, 172);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(140, 54);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear Listbox";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LbxTest
            // 
            this.LbxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxTest.FormattingEnabled = true;
            this.LbxTest.ItemHeight = 24;
            this.LbxTest.Location = new System.Drawing.Point(81, 71);
            this.LbxTest.Name = "LbxTest";
            this.LbxTest.Size = new System.Drawing.Size(231, 220);
            this.LbxTest.TabIndex = 2;
            // 
            // TxtItem
            // 
            this.TxtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtItem.Location = new System.Drawing.Point(591, 85);
            this.TxtItem.Name = "TxtItem";
            this.TxtItem.Size = new System.Drawing.Size(171, 29);
            this.TxtItem.TabIndex = 3;
            // 
            // BtnDog
            // 
            this.BtnDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDog.Location = new System.Drawing.Point(421, 269);
            this.BtnDog.Name = "BtnDog";
            this.BtnDog.Size = new System.Drawing.Size(140, 54);
            this.BtnDog.TabIndex = 1;
            this.BtnDog.Text = "Add Dogs";
            this.BtnDog.UseVisualStyleBackColor = true;
            this.BtnDog.Click += new System.EventHandler(this.BtnDog_Click);
            // 
            // FrmList
            // 
            this.AcceptButton = this.BtnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtItem);
            this.Controls.Add(this.LbxTest);
            this.Controls.Add(this.BtnDog);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnAddItem);
            this.Name = "FrmList";
            this.Text = "Listbox";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAddItem;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.ListBox LbxTest;
        private System.Windows.Forms.TextBox TxtItem;
        private System.Windows.Forms.Button BtnDog;
    }
}

