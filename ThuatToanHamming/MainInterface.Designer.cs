namespace ThuatToanHamming
{
    partial class form_ThuatToanHamming
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
            this.label_InputContent = new System.Windows.Forms.Label();
            this.textBox_inputContent = new System.Windows.Forms.TextBox();
            this.button_InputContent = new System.Windows.Forms.Button();
            this.label_Infor = new System.Windows.Forms.Label();
            this.label_BinaryInput = new System.Windows.Forms.Label();
            this.label_Verification = new System.Windows.Forms.Label();
            this.textBox_Verification = new System.Windows.Forms.TextBox();
            this.label_FrameOutput = new System.Windows.Forms.Label();
            this.textBox_FrameOutput = new System.Windows.Forms.TextBox();
            this.textBox_BinaryInput = new System.Windows.Forms.TextBox();
            this.label_ReceivedString = new System.Windows.Forms.Label();
            this.textBox_ReceivedString = new System.Windows.Forms.TextBox();
            this.label_ReceivedVerification = new System.Windows.Forms.Label();
            this.textBox_ReceivedVerification = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SValue = new System.Windows.Forms.TextBox();
            this.label_FaultBitPosition = new System.Windows.Forms.Label();
            this.textBox_FaultBitPosition = new System.Windows.Forms.TextBox();
            this.label_correctedFrame = new System.Windows.Forms.Label();
            this.textBox_CorrectedFrame = new System.Windows.Forms.TextBox();
            this.textBox_CheckReceiveString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Receive = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_equation = new System.Windows.Forms.Button();
            this.label_EquationDescription = new System.Windows.Forms.Label();
            this.richTextBox1_EquationDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox2_EquationDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_InputContent
            // 
            this.label_InputContent.AutoSize = true;
            this.label_InputContent.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InputContent.Location = new System.Drawing.Point(45, 64);
            this.label_InputContent.Name = "label_InputContent";
            this.label_InputContent.Size = new System.Drawing.Size(109, 18);
            this.label_InputContent.TabIndex = 0;
            this.label_InputContent.Text = "Nhập vào chuỗi:";
            // 
            // textBox_inputContent
            // 
            this.textBox_inputContent.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_inputContent.Location = new System.Drawing.Point(131, 16);
            this.textBox_inputContent.Name = "textBox_inputContent";
            this.textBox_inputContent.Size = new System.Drawing.Size(217, 25);
            this.textBox_inputContent.TabIndex = 1;
            // 
            // button_InputContent
            // 
            this.button_InputContent.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InputContent.Location = new System.Drawing.Point(386, 14);
            this.button_InputContent.Name = "button_InputContent";
            this.button_InputContent.Size = new System.Drawing.Size(85, 27);
            this.button_InputContent.TabIndex = 2;
            this.button_InputContent.Text = "Nhập";
            this.button_InputContent.UseVisualStyleBackColor = true;
            this.button_InputContent.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // label_Infor
            // 
            this.label_Infor.AutoSize = true;
            this.label_Infor.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Infor.Location = new System.Drawing.Point(92, 21);
            this.label_Infor.Name = "label_Infor";
            this.label_Infor.Size = new System.Drawing.Size(102, 20);
            this.label_Infor.TabIndex = 5;
            this.label_Infor.Text = "BÊN TRUYỀN";
            // 
            // label_BinaryInput
            // 
            this.label_BinaryInput.AutoSize = true;
            this.label_BinaryInput.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BinaryInput.Location = new System.Drawing.Point(40, 155);
            this.label_BinaryInput.Name = "label_BinaryInput";
            this.label_BinaryInput.Size = new System.Drawing.Size(102, 18);
            this.label_BinaryInput.TabIndex = 5;
            this.label_BinaryInput.Text = "Chuỗi đã nhập:";
            // 
            // label_Verification
            // 
            this.label_Verification.AutoSize = true;
            this.label_Verification.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Verification.Location = new System.Drawing.Point(16, 84);
            this.label_Verification.Name = "label_Verification";
            this.label_Verification.Size = new System.Drawing.Size(60, 18);
            this.label_Verification.TabIndex = 5;
            this.label_Verification.Text = "Priority:";
            // 
            // textBox_Verification
            // 
            this.textBox_Verification.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Verification.Location = new System.Drawing.Point(130, 81);
            this.textBox_Verification.Name = "textBox_Verification";
            this.textBox_Verification.ReadOnly = true;
            this.textBox_Verification.Size = new System.Drawing.Size(132, 25);
            this.textBox_Verification.TabIndex = 4;
            // 
            // label_FrameOutput
            // 
            this.label_FrameOutput.AutoSize = true;
            this.label_FrameOutput.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FrameOutput.Location = new System.Drawing.Point(15, 115);
            this.label_FrameOutput.Name = "label_FrameOutput";
            this.label_FrameOutput.Size = new System.Drawing.Size(86, 18);
            this.label_FrameOutput.TabIndex = 5;
            this.label_FrameOutput.Text = "Chuỗi gửi đi:";
            // 
            // textBox_FrameOutput
            // 
            this.textBox_FrameOutput.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FrameOutput.Location = new System.Drawing.Point(130, 112);
            this.textBox_FrameOutput.Name = "textBox_FrameOutput";
            this.textBox_FrameOutput.ReadOnly = true;
            this.textBox_FrameOutput.Size = new System.Drawing.Size(132, 25);
            this.textBox_FrameOutput.TabIndex = 5;
            // 
            // textBox_BinaryInput
            // 
            this.textBox_BinaryInput.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BinaryInput.Location = new System.Drawing.Point(130, 46);
            this.textBox_BinaryInput.Name = "textBox_BinaryInput";
            this.textBox_BinaryInput.ReadOnly = true;
            this.textBox_BinaryInput.Size = new System.Drawing.Size(132, 25);
            this.textBox_BinaryInput.TabIndex = 3;
            // 
            // label_ReceivedString
            // 
            this.label_ReceivedString.AutoSize = true;
            this.label_ReceivedString.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ReceivedString.Location = new System.Drawing.Point(15, 50);
            this.label_ReceivedString.Name = "label_ReceivedString";
            this.label_ReceivedString.Size = new System.Drawing.Size(117, 18);
            this.label_ReceivedString.TabIndex = 5;
            this.label_ReceivedString.Text = "Chuỗi nhận được:";
            // 
            // textBox_ReceivedString
            // 
            this.textBox_ReceivedString.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReceivedString.Location = new System.Drawing.Point(142, 52);
            this.textBox_ReceivedString.Name = "textBox_ReceivedString";
            this.textBox_ReceivedString.ReadOnly = true;
            this.textBox_ReceivedString.Size = new System.Drawing.Size(132, 25);
            this.textBox_ReceivedString.TabIndex = 6;
            // 
            // label_ReceivedVerification
            // 
            this.label_ReceivedVerification.AutoSize = true;
            this.label_ReceivedVerification.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ReceivedVerification.Location = new System.Drawing.Point(16, 84);
            this.label_ReceivedVerification.Name = "label_ReceivedVerification";
            this.label_ReceivedVerification.Size = new System.Drawing.Size(60, 18);
            this.label_ReceivedVerification.TabIndex = 5;
            this.label_ReceivedVerification.Text = "Priority:";
            // 
            // textBox_ReceivedVerification
            // 
            this.textBox_ReceivedVerification.Font = new System.Drawing.Font("UVN Hong Ha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ReceivedVerification.Location = new System.Drawing.Point(142, 81);
            this.textBox_ReceivedVerification.Name = "textBox_ReceivedVerification";
            this.textBox_ReceivedVerification.ReadOnly = true;
            this.textBox_ReceivedVerification.Size = new System.Drawing.Size(132, 25);
            this.textBox_ReceivedVerification.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sai lệch Priority:";
            // 
            // textBox_SValue
            // 
            this.textBox_SValue.Font = new System.Drawing.Font("UVN Hong Ha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SValue.Location = new System.Drawing.Point(142, 112);
            this.textBox_SValue.Name = "textBox_SValue";
            this.textBox_SValue.ReadOnly = true;
            this.textBox_SValue.Size = new System.Drawing.Size(132, 25);
            this.textBox_SValue.TabIndex = 8;
            // 
            // label_FaultBitPosition
            // 
            this.label_FaultBitPosition.AutoSize = true;
            this.label_FaultBitPosition.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FaultBitPosition.Location = new System.Drawing.Point(11, 60);
            this.label_FaultBitPosition.Name = "label_FaultBitPosition";
            this.label_FaultBitPosition.Size = new System.Drawing.Size(81, 18);
            this.label_FaultBitPosition.TabIndex = 5;
            this.label_FaultBitPosition.Text = "Vị trí bit lỗi:";
            // 
            // textBox_FaultBitPosition
            // 
            this.textBox_FaultBitPosition.Font = new System.Drawing.Font("UVN Hong Ha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FaultBitPosition.Location = new System.Drawing.Point(130, 57);
            this.textBox_FaultBitPosition.Name = "textBox_FaultBitPosition";
            this.textBox_FaultBitPosition.ReadOnly = true;
            this.textBox_FaultBitPosition.Size = new System.Drawing.Size(132, 25);
            this.textBox_FaultBitPosition.TabIndex = 10;
            // 
            // label_correctedFrame
            // 
            this.label_correctedFrame.AutoSize = true;
            this.label_correctedFrame.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correctedFrame.Location = new System.Drawing.Point(308, 60);
            this.label_correctedFrame.Name = "label_correctedFrame";
            this.label_correctedFrame.Size = new System.Drawing.Size(112, 18);
            this.label_correctedFrame.TabIndex = 5;
            this.label_correctedFrame.Text = "Chuỗi đã sửa lỗi:";
            // 
            // textBox_CorrectedFrame
            // 
            this.textBox_CorrectedFrame.Font = new System.Drawing.Font("UVN Hong Ha", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CorrectedFrame.Location = new System.Drawing.Point(427, 57);
            this.textBox_CorrectedFrame.Name = "textBox_CorrectedFrame";
            this.textBox_CorrectedFrame.ReadOnly = true;
            this.textBox_CorrectedFrame.Size = new System.Drawing.Size(132, 25);
            this.textBox_CorrectedFrame.TabIndex = 11;
            // 
            // textBox_CheckReceiveString
            // 
            this.textBox_CheckReceiveString.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CheckReceiveString.Location = new System.Drawing.Point(130, 12);
            this.textBox_CheckReceiveString.Name = "textBox_CheckReceiveString";
            this.textBox_CheckReceiveString.ReadOnly = true;
            this.textBox_CheckReceiveString.Size = new System.Drawing.Size(344, 29);
            this.textBox_CheckReceiveString.TabIndex = 9;
            this.textBox_CheckReceiveString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_InputContent);
            this.groupBox1.Controls.Add(this.textBox_inputContent);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 51);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Infor);
            this.groupBox2.Controls.Add(this.textBox_Verification);
            this.groupBox2.Controls.Add(this.label_Verification);
            this.groupBox2.Controls.Add(this.label_FrameOutput);
            this.groupBox2.Controls.Add(this.textBox_FrameOutput);
            this.groupBox2.Controls.Add(this.textBox_BinaryInput);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 150);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Receive);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox_ReceivedVerification);
            this.groupBox3.Controls.Add(this.label_ReceivedVerification);
            this.groupBox3.Controls.Add(this.textBox_ReceivedString);
            this.groupBox3.Controls.Add(this.textBox_SValue);
            this.groupBox3.Controls.Add(this.label_ReceivedString);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(317, 108);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 150);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // label_Receive
            // 
            this.label_Receive.AutoSize = true;
            this.label_Receive.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Receive.Location = new System.Drawing.Point(94, 21);
            this.label_Receive.Name = "label_Receive";
            this.label_Receive.Size = new System.Drawing.Size(88, 20);
            this.label_Receive.TabIndex = 5;
            this.label_Receive.Text = "BÊN NHẬN";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_CheckReceiveString);
            this.groupBox4.Controls.Add(this.label_FaultBitPosition);
            this.groupBox4.Controls.Add(this.label_correctedFrame);
            this.groupBox4.Controls.Add(this.textBox_FaultBitPosition);
            this.groupBox4.Controls.Add(this.textBox_CorrectedFrame);
            this.groupBox4.Location = new System.Drawing.Point(25, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(579, 101);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // button_Help
            // 
            this.button_Help.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help.Location = new System.Drawing.Point(26, 12);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(75, 27);
            this.button_Help.TabIndex = 14;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // button_equation
            // 
            this.button_equation.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equation.Location = new System.Drawing.Point(121, 12);
            this.button_equation.Name = "button_equation";
            this.button_equation.Size = new System.Drawing.Size(80, 27);
            this.button_equation.TabIndex = 15;
            this.button_equation.Text = "Equation";
            this.button_equation.UseVisualStyleBackColor = true;
            this.button_equation.Click += new System.EventHandler(this.button_Equation_Click);
            // 
            // label_EquationDescription
            // 
            this.label_EquationDescription.AutoSize = true;
            this.label_EquationDescription.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EquationDescription.Location = new System.Drawing.Point(119, 16);
            this.label_EquationDescription.Name = "label_EquationDescription";
            this.label_EquationDescription.Size = new System.Drawing.Size(81, 22);
            this.label_EquationDescription.TabIndex = 16;
            this.label_EquationDescription.Text = "QUI ƯỚC";
            this.label_EquationDescription.Click += new System.EventHandler(this.label_EquationDescription_Click);
            // 
            // richTextBox1_EquationDescription
            // 
            this.richTextBox1_EquationDescription.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1_EquationDescription.Location = new System.Drawing.Point(16, 80);
            this.richTextBox1_EquationDescription.Name = "richTextBox1_EquationDescription";
            this.richTextBox1_EquationDescription.ReadOnly = true;
            this.richTextBox1_EquationDescription.Size = new System.Drawing.Size(271, 48);
            this.richTextBox1_EquationDescription.TabIndex = 12;
            this.richTextBox1_EquationDescription.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label_EquationDescription);
            this.groupBox5.Controls.Add(this.richTextBox2_EquationDescription);
            this.groupBox5.Controls.Add(this.richTextBox1_EquationDescription);
            this.groupBox5.Location = new System.Drawing.Point(610, 48);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 317);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // richTextBox2_EquationDescription
            // 
            this.richTextBox2_EquationDescription.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2_EquationDescription.Location = new System.Drawing.Point(16, 144);
            this.richTextBox2_EquationDescription.Name = "richTextBox2_EquationDescription";
            this.richTextBox2_EquationDescription.ReadOnly = true;
            this.richTextBox2_EquationDescription.Size = new System.Drawing.Size(271, 158);
            this.richTextBox2_EquationDescription.TabIndex = 13;
            this.richTextBox2_EquationDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Biểu diễn PRIORITY BITS dựa trên DATA BITS";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("UTM Nokia Standard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_Title.Location = new System.Drawing.Point(328, 2);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(308, 36);
            this.label_Title.TabIndex = 16;
            this.label_Title.Text = "HAMMING ALGORITHM";
            this.label_Title.Click += new System.EventHandler(this.label_EquationDescription_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nguyen Minh Luan - 14520492 - UITCE";
            // 
            // form_ThuatToanHamming
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(925, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_equation);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.label_BinaryInput);
            this.Controls.Add(this.label_InputContent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "form_ThuatToanHamming";
            this.Text = "Thuật toán Hamming (14520492 - UIT)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_InputContent;
        private System.Windows.Forms.TextBox textBox_inputContent;
        private System.Windows.Forms.Button button_InputContent;
        private System.Windows.Forms.Label label_Infor;
        private System.Windows.Forms.Label label_BinaryInput;
        private System.Windows.Forms.Label label_Verification;
        private System.Windows.Forms.TextBox textBox_Verification;
        private System.Windows.Forms.Label label_FrameOutput;
        private System.Windows.Forms.TextBox textBox_FrameOutput;
        private System.Windows.Forms.TextBox textBox_BinaryInput;
        private System.Windows.Forms.Label label_ReceivedString;
        private System.Windows.Forms.TextBox textBox_ReceivedString;
        private System.Windows.Forms.Label label_ReceivedVerification;
        private System.Windows.Forms.TextBox textBox_ReceivedVerification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SValue;
        private System.Windows.Forms.Label label_FaultBitPosition;
        private System.Windows.Forms.TextBox textBox_FaultBitPosition;
        private System.Windows.Forms.Label label_correctedFrame;
        private System.Windows.Forms.TextBox textBox_CorrectedFrame;
        private System.Windows.Forms.TextBox textBox_CheckReceiveString;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_Receive;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_equation;
        private System.Windows.Forms.Label label_EquationDescription;
        private System.Windows.Forms.RichTextBox richTextBox1_EquationDescription;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox2_EquationDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label3;
    }
}

