namespace Enigma
{
    partial class Enigma
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            firstRotorBox = new System.Windows.Forms.ComboBox();
            secondRotorBox = new System.Windows.Forms.ComboBox();
            thirdRotorBox = new System.Windows.Forms.ComboBox();
            firstRingBox = new System.Windows.Forms.ComboBox();
            secondRingBox = new System.Windows.Forms.ComboBox();
            thirdRingBox = new System.Windows.Forms.ComboBox();
            firstRotorChooseBox = new System.Windows.Forms.ComboBox();
            secondRotorChooseBox = new System.Windows.Forms.ComboBox();
            thirdRotorChooseBox = new System.Windows.Forms.ComboBox();
            reflectorBox = new System.Windows.Forms.ComboBox();
            plugboardBox = new System.Windows.Forms.TextBox();
            originalMessageBox = new System.Windows.Forms.TextBox();
            newMessageBox = new System.Windows.Forms.TextBox();
            loadButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            cryptoButton = new System.Windows.Forms.Button();
            lblTitle1 = new System.Windows.Forms.Label();
            lblTitle2 = new System.Windows.Forms.Label();
            lblRotors = new System.Windows.Forms.Label();
            lblRings = new System.Windows.Forms.Label();
            lblRotorChoose = new System.Windows.Forms.Label();
            lblReflector = new System.Windows.Forms.Label();
            lblPlugboard = new System.Windows.Forms.Label();
            lblNewMessage = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // firstRotorBox
            // 
            firstRotorBox.FormattingEnabled = true;
            firstRotorBox.Location = new System.Drawing.Point(90, 85);
            firstRotorBox.Name = "firstRotorBox";
            firstRotorBox.Size = new System.Drawing.Size(40, 26);
            firstRotorBox.TabIndex = 8;
            // 
            // secondRotorBox
            // 
            secondRotorBox.FormattingEnabled = true;
            secondRotorBox.Location = new System.Drawing.Point(140, 85);
            secondRotorBox.Name = "secondRotorBox";
            secondRotorBox.Size = new System.Drawing.Size(40, 26);
            secondRotorBox.TabIndex = 9;
            // 
            // thirdRotorBox
            // 
            thirdRotorBox.FormattingEnabled = true;
            thirdRotorBox.Location = new System.Drawing.Point(190, 85);
            thirdRotorBox.Name = "thirdRotorBox";
            thirdRotorBox.Size = new System.Drawing.Size(40, 26);
            thirdRotorBox.TabIndex = 10;
            // 
            // firstRingBox
            // 
            firstRingBox.FormattingEnabled = true;
            firstRingBox.Location = new System.Drawing.Point(90, 135);
            firstRingBox.Name = "firstRingBox";
            firstRingBox.Size = new System.Drawing.Size(40, 26);
            firstRingBox.TabIndex = 11;
            // 
            // secondRingBox
            // 
            secondRingBox.FormattingEnabled = true;
            secondRingBox.Location = new System.Drawing.Point(140, 135);
            secondRingBox.Name = "secondRingBox";
            secondRingBox.Size = new System.Drawing.Size(40, 26);
            secondRingBox.TabIndex = 12;
            // 
            // thirdRingBox
            // 
            thirdRingBox.FormattingEnabled = true;
            thirdRingBox.Location = new System.Drawing.Point(190, 135);
            thirdRingBox.Name = "thirdRingBox";
            thirdRingBox.Size = new System.Drawing.Size(40, 26);
            thirdRingBox.TabIndex = 13;
            // 
            // firstRotorChooseBox
            // 
            firstRotorChooseBox.FormattingEnabled = true;
            firstRotorChooseBox.Location = new System.Drawing.Point(270, 135);
            firstRotorChooseBox.Name = "firstRotorChooseBox";
            firstRotorChooseBox.Size = new System.Drawing.Size(40, 26);
            firstRotorChooseBox.TabIndex = 14;
            // 
            // secondRotorChooseBox
            // 
            secondRotorChooseBox.FormattingEnabled = true;
            secondRotorChooseBox.Location = new System.Drawing.Point(320, 135);
            secondRotorChooseBox.Name = "secondRotorChooseBox";
            secondRotorChooseBox.Size = new System.Drawing.Size(40, 26);
            secondRotorChooseBox.TabIndex = 15;
            // 
            // thirdRotorChooseBox
            // 
            thirdRotorChooseBox.FormattingEnabled = true;
            thirdRotorChooseBox.Location = new System.Drawing.Point(370, 135);
            thirdRotorChooseBox.Name = "thirdRotorChooseBox";
            thirdRotorChooseBox.Size = new System.Drawing.Size(40, 26);
            thirdRotorChooseBox.TabIndex = 16;
            // 
            // reflectorBox
            // 
            reflectorBox.FormattingEnabled = true;
            reflectorBox.Location = new System.Drawing.Point(230, 240);
            reflectorBox.Name = "reflectorBox";
            reflectorBox.Size = new System.Drawing.Size(180, 26);
            reflectorBox.TabIndex = 17;
            // 
            // plugboardBox
            // 
            plugboardBox.Location = new System.Drawing.Point(20, 220);
            plugboardBox.Multiline = true;
            plugboardBox.Name = "plugboardBox";
            plugboardBox.Size = new System.Drawing.Size(180, 80);
            plugboardBox.TabIndex = 18;
            // 
            // originalMessageBox
            // 
            originalMessageBox.Location = new System.Drawing.Point(463, 70);
            originalMessageBox.Multiline = true;
            originalMessageBox.Name = "originalMessageBox";
            originalMessageBox.Size = new System.Drawing.Size(337, 60);
            originalMessageBox.TabIndex = 19;
            // 
            // newMessageBox
            // 
            newMessageBox.Location = new System.Drawing.Point(450, 230);
            newMessageBox.Multiline = true;
            newMessageBox.Name = "newMessageBox";
            newMessageBox.Size = new System.Drawing.Size(350, 70);
            newMessageBox.TabIndex = 20;
            // 
            // loadButton
            // 
            loadButton.Location = new System.Drawing.Point(450, 140);
            loadButton.Name = "loadButton";
            loadButton.Size = new System.Drawing.Size(80, 30);
            loadButton.TabIndex = 21;
            loadButton.Text = "Load File";
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(540, 140);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(80, 30);
            saveButton.TabIndex = 22;
            saveButton.Text = "Save File";
            saveButton.Click += saveButton_Click;
            // 
            // cryptoButton
            // 
            cryptoButton.Location = new System.Drawing.Point(630, 140);
            cryptoButton.Name = "cryptoButton";
            cryptoButton.Size = new System.Drawing.Size(142, 30);
            cryptoButton.TabIndex = 23;
            cryptoButton.Text = "Encrypt/Decrypt";
            cryptoButton.Click += cryptoButton_Click;
            // 
            // lblTitle1
            // 
            lblTitle1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle1.Location = new System.Drawing.Point(20, 20);
            lblTitle1.Name = "lblTitle1";
            lblTitle1.Size = new System.Drawing.Size(378, 40);
            lblTitle1.TabIndex = 0;
            lblTitle1.Text = "ENIGMA SETTINGS";
            // 
            // lblTitle2
            // 
            lblTitle2.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle2.Location = new System.Drawing.Point(450, 20);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new System.Drawing.Size(350, 40);
            lblTitle2.TabIndex = 1;
            lblTitle2.Text = "YOUR MESSAGE";
            // 
            // lblRotors
            // 
            lblRotors.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRotors.Location = new System.Drawing.Point(2, 85);
            lblRotors.Name = "lblRotors";
            lblRotors.Size = new System.Drawing.Size(88, 30);
            lblRotors.TabIndex = 2;
            lblRotors.Text = "Rotors:";
            // 
            // lblRings
            // 
            lblRings.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRings.Location = new System.Drawing.Point(12, 135);
            lblRings.Name = "lblRings";
            lblRings.Size = new System.Drawing.Size(70, 30);
            lblRings.TabIndex = 3;
            lblRings.Text = "Rings:";
            // 
            // lblRotorChoose
            // 
            lblRotorChoose.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRotorChoose.Location = new System.Drawing.Point(230, 70);
            lblRotorChoose.Name = "lblRotorChoose";
            lblRotorChoose.Size = new System.Drawing.Size(227, 30);
            lblRotorChoose.TabIndex = 4;
            lblRotorChoose.Text = "ROTOR CHOOSE";
            // 
            // lblReflector
            // 
            lblReflector.Font = new System.Drawing.Font("Stencil", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblReflector.Location = new System.Drawing.Point(230, 180);
            lblReflector.Name = "lblReflector";
            lblReflector.Size = new System.Drawing.Size(214, 40);
            lblReflector.TabIndex = 6;
            lblReflector.Text = "REFLECTOR";
            lblReflector.Click += lblReflector_Click;
            // 
            // lblPlugboard
            // 
            lblPlugboard.Font = new System.Drawing.Font("Stencil", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPlugboard.Location = new System.Drawing.Point(0, 180);
            lblPlugboard.Name = "lblPlugboard";
            lblPlugboard.Size = new System.Drawing.Size(224, 40);
            lblPlugboard.TabIndex = 5;
            lblPlugboard.Text = "PLUGBOARD";
            // 
            // lblNewMessage
            // 
            lblNewMessage.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNewMessage.Location = new System.Drawing.Point(450, 180);
            lblNewMessage.Name = "lblNewMessage";
            lblNewMessage.Size = new System.Drawing.Size(300, 40);
            lblNewMessage.TabIndex = 7;
            lblNewMessage.Text = "NEW MESSAGE";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(103, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 23);
            label1.TabIndex = 24;
            label1.Text = "I       II       III";
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(275, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(135, 23);
            label2.TabIndex = 25;
            label2.Text = "I       II       III";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(95, 109);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 23);
            label3.TabIndex = 26;
            label3.Text = "I       II       III";
            // 
            // Enigma
            // 
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(850, 350);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle1);
            Controls.Add(lblTitle2);
            Controls.Add(lblRotors);
            Controls.Add(lblRings);
            Controls.Add(lblRotorChoose);
            Controls.Add(lblPlugboard);
            Controls.Add(lblReflector);
            Controls.Add(lblNewMessage);
            Controls.Add(firstRotorBox);
            Controls.Add(secondRotorBox);
            Controls.Add(thirdRotorBox);
            Controls.Add(firstRingBox);
            Controls.Add(secondRingBox);
            Controls.Add(thirdRingBox);
            Controls.Add(firstRotorChooseBox);
            Controls.Add(secondRotorChooseBox);
            Controls.Add(thirdRotorChooseBox);
            Controls.Add(reflectorBox);
            Controls.Add(plugboardBox);
            Controls.Add(originalMessageBox);
            Controls.Add(newMessageBox);
            Controls.Add(loadButton);
            Controls.Add(saveButton);
            Controls.Add(cryptoButton);
            Name = "Enigma";
            Text = "Enigma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Variable declarations linking to your Form.cs
        private System.Windows.Forms.ComboBox firstRotorBox;
        private System.Windows.Forms.ComboBox secondRotorBox;
        private System.Windows.Forms.ComboBox thirdRotorBox;
        private System.Windows.Forms.ComboBox firstRingBox;
        private System.Windows.Forms.ComboBox secondRingBox;
        private System.Windows.Forms.ComboBox thirdRingBox;
        private System.Windows.Forms.ComboBox firstRotorChooseBox;
        private System.Windows.Forms.ComboBox secondRotorChooseBox;
        private System.Windows.Forms.ComboBox thirdRotorChooseBox;
        private System.Windows.Forms.ComboBox reflectorBox;
        private System.Windows.Forms.TextBox plugboardBox;
        private System.Windows.Forms.TextBox originalMessageBox;
        private System.Windows.Forms.TextBox newMessageBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cryptoButton;
        private System.Windows.Forms.Label lblTitle1;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblRotors;
        private System.Windows.Forms.Label lblRings;
        private System.Windows.Forms.Label lblRotorChoose;
        private System.Windows.Forms.Label lblReflector;
        private System.Windows.Forms.Label lblPlugboard;
        private System.Windows.Forms.Label lblNewMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}