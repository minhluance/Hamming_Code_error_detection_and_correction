using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ThuatToanHamming
{
    public partial class form_ThuatToanHamming : Form
    {
        public form_ThuatToanHamming()
        {
            InitializeComponent();
        }
        static Random random = new Random();
        private void clear_textBox()
        {
            textBox_MatrixHOutput.Clear();
            textBox_ReceivedString.Clear();
            textBox_ReceivedVerification.Clear();
            textBox_MatrixHValue.Clear();
            textBox_SValue.Clear();
            textBox_CorrectedFrame.Clear();
            textBox_FaultBitPosition.Clear();
            textBox_CheckReceiveString.Clear();
        }
        private void button_Input_Click(object sender, EventArgs e)
        {
            // Xoa bo cac du lieu cua lan nhap truoc do
            clear_textBox();
            // Khai bao bien co kieu la Binary, duoc dinh nghia trong Binary.cs
            Binary binary_input_analyze;

            // Lay gia tri Input tu textbox khi button Nhap duoc nhan
            string code_input = textBox_inputContent.Text;

            // Chuyen doi gia tri nhap tu textbox sang dang nhi phan va luu vao bien binary_input_analyze
            binary_input_analyze = new Binary(code_input.Select(c => c == '1' ? true : false));

            int columnsAmount = binary_input_analyze.Count();
            int rowsAmount = (int)Math.Ceiling(Math.Log(columnsAmount, 2) + 1);

            // Tinh toan ma tran H, chuoi kiem tra va frame output
            BinaryMatrix H = GenerateHMatrix(rowsAmount, columnsAmount);
            Binary verification = GenerateVerificationBits(H, binary_input_analyze);
            Binary frame = Binary.Concatenate(binary_input_analyze, verification);

            // Xuat thong tin tinh toan ra man hinh
            textBox_BinaryInput.Text = code_input;
            int length_code_input = code_input.Count();
            int rows_of_H = (int)(Math.Log(length_code_input) / Math.Log(2));
            if ((Math.Log(length_code_input) / Math.Log(2) - rows_of_H) != 0) rows_of_H += 1;
            for (int cnt = 0; cnt<= rows_of_H; cnt++) {
                Binary rowH = H.GetRow(cnt);
                textBox_MatrixHValue.AppendText(rowH + "\n");
            }
            textBox_Verification.AppendText(verification + "\n");
            textBox_FrameOutput.AppendText(frame + "\n");

            // Gia thiet chuoi nhan co loi hay khong de sua loi.
            Random ran = new Random();
            int random_data = ran.Next(0, 2);
            bool corrupt_data = (random_data==1)?true:false;


            Binary receivedFrame = new Binary(frame.ToArray());
            if (corrupt_data)
            {
                textBox_CheckReceiveString.AppendText("CHUỖI NHẬN ĐƯỢC BỊ LỖI");
                int badBit = random.Next(0, receivedFrame.Length - 1);
                receivedFrame[badBit] = !receivedFrame[badBit];
            }
            else textBox_CheckReceiveString.AppendText("CHUỖI NHẬN ĐƯỢC KHÔNG BỊ LỖI");
            Binary receivedMessage = new Binary(receivedFrame.Take(columnsAmount));
            Binary receivedVerification = new Binary(receivedFrame.Skip(columnsAmount));

            H = GenerateHMatrix(rowsAmount, columnsAmount);
            Binary receivedMessageVerification = GenerateVerificationBits(H, receivedMessage);
            Binary s = receivedVerification ^ receivedMessageVerification;

            // Tinh toan va xuat ra ket qua
            textBox_ReceivedString.AppendText(receivedFrame + "");
            textBox_ReceivedVerification.AppendText(receivedMessageVerification + "");
            textBox_SValue.AppendText(s+"");

            if (s.CountOnes() > 0)
            {
                try
                {
                    BinaryMatrix HWithIdentity = GenerateHWithIdentity(H);
                    int faultyBitPosition = FindFaultyBit(HWithIdentity, s);

                    Binary correctedFrame = new Binary(receivedFrame.ToArray());
                    correctedFrame[faultyBitPosition] = !correctedFrame[faultyBitPosition];
                    for (int cnt = 0; cnt <= rows_of_H; cnt++)
                    {
                        Binary rowH_out = HWithIdentity.GetRow(cnt);
                        textBox_MatrixHOutput.AppendText(rowH_out + "\n");
                    }
                    textBox_FaultBitPosition.AppendText(faultyBitPosition + "");

                    Binary correctedFrameGeneratedVerify = GenerateVerificationBits(H, new Binary(correctedFrame.Take(columnsAmount)));
                    Binary correctedFrameVerify = new Binary(correctedFrame.Skip(columnsAmount));
                    Binary correctionVerify = correctedFrameVerify ^ correctedFrameGeneratedVerify;
                    if (correctionVerify.CountOnes() == 0)
                        textBox_CorrectedFrame.AppendText(correctedFrame + "");
                    else
                        textBox_CorrectedFrame.Text = "Khong the sua loi chuoi nay!!!";
                }
                catch (WarningException)
                {
                    MessageBox.Show("Khong the sua loi chuoi nay!!!"); 
                }
            }
            //else
            //{
            //    MessageBox.Show("Chuoi nhan dung voi chuoi ban dau");
            //}
        }
        static Binary GenerateVerificationBits(BinaryMatrix H, Binary message)
        {
            Binary verification = new Binary(new bool[H.RowAmount]);
            for (int i = 0; i < H.RowAmount; i++)
            {
                Binary row = H.GetRow(i);
                Binary addiction = row & message;
                bool verificationBit = addiction.CountOnes() % 2 == 1 ? true : false;
                verification[i] = verificationBit;
            }
            return verification;
        }
        static BinaryMatrix GenerateHMatrix(int rowsAmount, int columnsAmount)
        {
            BinaryMatrix H = new BinaryMatrix(rowsAmount, columnsAmount);
            int n = 0;
            for (int i = 1; i <= Math.Pow(2, rowsAmount); i++)
            {
                Binary binary = new Binary(i, H.RowAmount);
                binary.CountOnes();
                if (binary.CountOnes() >= 2)
                {
                    for (int y = 0; y < rowsAmount; y++)
                    {
                        H.Set(y, n, binary[y]);
                    }
                    n++;
                }
                if (n >= H.ColumnAmount)
                    break;
            }
            return H;
        }

        private void form_ThuatToanHamming_Load(object sender, EventArgs e)
        {

        }

        private void label_Infor_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private static int FindFaultyBit(BinaryMatrix H, Binary s)
        {
            for (int i = 0; i < H.ColumnAmount; i++)
            {
                Binary column = H.GetColumn(i);
                Binary check = s ^ column;
                if (check.Any(b => b))
                    continue;
                return i;
            }

            throw new WarningException("Faulty bit not found!");
        }
        static BinaryMatrix GenerateHWithIdentity(BinaryMatrix H)
        {
            BinaryMatrix HWithIdentity = new BinaryMatrix(H.RowAmount, H.ColumnAmount + H.RowAmount);
            for (int y = 0; y < H.RowAmount; y++)
            {
                for (int x = 0; x < H.ColumnAmount; x++)
                {
                    HWithIdentity.Set(y, x, H.Get(y, x));
                }
            }

            for (int y = 0; y < H.RowAmount; y++)
            {
                int n = 0;
                for (int x = H.ColumnAmount; x < H.ColumnAmount + H.RowAmount; x++)
                {
                    HWithIdentity.Set(y, x, y == n);

                    n++;
                }
            }
            return HWithIdentity;
        }

        private void label_Infor_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox_CorruptData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_MatrixHOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CorrectedFrame_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CheckReceiveString_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
