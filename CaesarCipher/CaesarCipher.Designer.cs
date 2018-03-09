namespace CaesarCipher
{
    partial class CaesarCipher
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClearControls = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtKeyToEncrypt = new System.Windows.Forms.TextBox();
            this.lblKey = new MaterialSkin.Controls.MaterialLabel();
            this.btnCipher = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.lblInitialText = new MaterialSkin.Controls.MaterialLabel();
            this.lblOutputText = new MaterialSkin.Controls.MaterialLabel();
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnClearControlsDecrypt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtKeyToDecrypt = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDecipher = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.lblDecrypt = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTextToDecrypt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 528);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClearControls);
            this.tabPage3.Controls.Add(this.txtKeyToEncrypt);
            this.tabPage3.Controls.Add(this.lblKey);
            this.tabPage3.Controls.Add(this.btnCipher);
            this.tabPage3.Controls.Add(this.txtEncryptedText);
            this.tabPage3.Controls.Add(this.lblInitialText);
            this.tabPage3.Controls.Add(this.lblOutputText);
            this.tabPage3.Controls.Add(this.txtToEncrypt);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(421, 502);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Encrypt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClearControls
            // 
            this.btnClearControls.Depth = 0;
            this.btnClearControls.Location = new System.Drawing.Point(3, 421);
            this.btnClearControls.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.Primary = true;
            this.btnClearControls.Size = new System.Drawing.Size(182, 71);
            this.btnClearControls.TabIndex = 4;
            this.btnClearControls.Text = "Clear Controls";
            this.btnClearControls.UseVisualStyleBackColor = true;
            this.btnClearControls.Click += new System.EventHandler(this.btnClearControls_Click);
            // 
            // txtKeyToEncrypt
            // 
            this.txtKeyToEncrypt.Location = new System.Drawing.Point(60, 6);
            this.txtKeyToEncrypt.Name = "txtKeyToEncrypt";
            this.txtKeyToEncrypt.Size = new System.Drawing.Size(337, 20);
            this.txtKeyToEncrypt.TabIndex = 3;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.BackColor = System.Drawing.SystemColors.Window;
            this.lblKey.Depth = 0;
            this.lblKey.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKey.Location = new System.Drawing.Point(8, 7);
            this.lblKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(41, 19);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key :";
            // 
            // btnCipher
            // 
            this.btnCipher.Depth = 0;
            this.btnCipher.Location = new System.Drawing.Point(212, 421);
            this.btnCipher.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Primary = true;
            this.btnCipher.Size = new System.Drawing.Size(185, 71);
            this.btnCipher.TabIndex = 4;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(12, 238);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(385, 164);
            this.txtEncryptedText.TabIndex = 3;
            // 
            // lblInitialText
            // 
            this.lblInitialText.AutoSize = true;
            this.lblInitialText.BackColor = System.Drawing.SystemColors.Window;
            this.lblInitialText.Depth = 0;
            this.lblInitialText.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInitialText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInitialText.Location = new System.Drawing.Point(8, 37);
            this.lblInitialText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInitialText.Name = "lblInitialText";
            this.lblInitialText.Size = new System.Drawing.Size(118, 19);
            this.lblInitialText.TabIndex = 0;
            this.lblInitialText.Text = "Text to Encrypt :";
            // 
            // lblOutputText
            // 
            this.lblOutputText.AutoSize = true;
            this.lblOutputText.BackColor = System.Drawing.SystemColors.Window;
            this.lblOutputText.Depth = 0;
            this.lblOutputText.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblOutputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOutputText.Location = new System.Drawing.Point(8, 216);
            this.lblOutputText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOutputText.Name = "lblOutputText";
            this.lblOutputText.Size = new System.Drawing.Size(116, 19);
            this.lblOutputText.TabIndex = 0;
            this.lblOutputText.Text = "Encrypted Text :";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.Location = new System.Drawing.Point(12, 59);
            this.txtToEncrypt.Multiline = true;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(385, 154);
            this.txtToEncrypt.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnClearControlsDecrypt);
            this.tabPage4.Controls.Add(this.txtKeyToDecrypt);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Controls.Add(this.btnDecipher);
            this.tabPage4.Controls.Add(this.txtDecryptedText);
            this.tabPage4.Controls.Add(this.lblDecrypt);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.txtTextToDecrypt);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(421, 502);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Decrypt";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnClearControlsDecrypt
            // 
            this.btnClearControlsDecrypt.Depth = 0;
            this.btnClearControlsDecrypt.Location = new System.Drawing.Point(3, 421);
            this.btnClearControlsDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearControlsDecrypt.Name = "btnClearControlsDecrypt";
            this.btnClearControlsDecrypt.Primary = true;
            this.btnClearControlsDecrypt.Size = new System.Drawing.Size(182, 71);
            this.btnClearControlsDecrypt.TabIndex = 11;
            this.btnClearControlsDecrypt.Text = "Clear Controls";
            this.btnClearControlsDecrypt.UseVisualStyleBackColor = true;
            this.btnClearControlsDecrypt.Click += new System.EventHandler(this.btnClearControlsDecrypt_Click);
            // 
            // txtKeyToDecrypt
            // 
            this.txtKeyToDecrypt.Location = new System.Drawing.Point(60, 6);
            this.txtKeyToDecrypt.Name = "txtKeyToDecrypt";
            this.txtKeyToDecrypt.Size = new System.Drawing.Size(337, 20);
            this.txtKeyToDecrypt.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Key :";
            // 
            // btnDecipher
            // 
            this.btnDecipher.Depth = 0;
            this.btnDecipher.Location = new System.Drawing.Point(212, 421);
            this.btnDecipher.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Primary = true;
            this.btnDecipher.Size = new System.Drawing.Size(185, 71);
            this.btnDecipher.TabIndex = 12;
            this.btnDecipher.Text = "Decipher";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(8, 238);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(389, 154);
            this.txtDecryptedText.TabIndex = 9;
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.BackColor = System.Drawing.SystemColors.Window;
            this.lblDecrypt.Depth = 0;
            this.lblDecrypt.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDecrypt.Location = new System.Drawing.Point(8, 37);
            this.lblDecrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(119, 19);
            this.lblDecrypt.TabIndex = 6;
            this.lblDecrypt.Text = "Text to Decrypt :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 216);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Decrypted Text :";
            // 
            // txtTextToDecrypt
            // 
            this.txtTextToDecrypt.Location = new System.Drawing.Point(8, 59);
            this.txtTextToDecrypt.Multiline = true;
            this.txtTextToDecrypt.Name = "txtTextToDecrypt";
            this.txtTextToDecrypt.Size = new System.Drawing.Size(389, 154);
            this.txtTextToDecrypt.TabIndex = 10;
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(429, 595);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "CaesarCipher";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Cipher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialRaisedButton btnClearControls;
        private System.Windows.Forms.TextBox txtKeyToEncrypt;
        private MaterialSkin.Controls.MaterialLabel lblKey;
        private MaterialSkin.Controls.MaterialRaisedButton btnCipher;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private MaterialSkin.Controls.MaterialLabel lblInitialText;
        private MaterialSkin.Controls.MaterialLabel lblOutputText;
        private System.Windows.Forms.TextBox txtToEncrypt;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialRaisedButton btnClearControlsDecrypt;
        private System.Windows.Forms.TextBox txtKeyToDecrypt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnDecipher;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private MaterialSkin.Controls.MaterialLabel lblDecrypt;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TextBox txtTextToDecrypt;
    }
}

