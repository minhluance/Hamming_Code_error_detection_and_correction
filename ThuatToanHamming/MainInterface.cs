// <summary>
// BÀI TẬP LẬP TRÌNH MÔN LÍ THUYẾT THÔNG TIN
// Ngôn ngữ: C#
// Người viết: Nguyễn Minh Luân - 14520492
// Lớp: NT104.H22 (UIT)
// Email: minhluan.ce@gmail.com 
// Đề số 12
// Đã thực hiện: Mã hoá mã tuyến tính Hamming
            // Xuất ra phương trình biểu diễn công thức phụ thuộc của các bit kiểm tra dựa vào các bit thông báo
            // Thực hiện quá trình phát hiện sai và sửa sai cho từ mã nhận được
// Chưa thực hiện được: Cho phép nhập vào tuỳ ý vị trí các bit kiểm tra và bit thông tháo
// Hạn chế: Phần mềm được thiết lập cố định các vị trí bit thông báo và bit kiểm tra theo qui tắc như sau
// Bit kiểm tra (priority bits): nằm ở các vị trí 1, 2, 4, 8, 16, 32, 64,...
// Bit thông tin (data bits): nằm ở các vị trí còn lại, từ trái sang
// Vị trí bit được đánh số từ 1 đến n cho từ mã có độ dài n bits.
// <summary>
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ThuatToanHamming
{
    public partial class form_ThuatToanHamming : Form
    {
        // Khai báo P1,P2, P3, P4, P5 như là equation là biến toàn cục
        // Sử dụng các chuỗi này để hiển thị công thức cho các bit kiểm tra
        public static string P1;
        public static string P2;
        public static string P3;
        public static string P4;
        public static string P5;
        public static string P6;
        public static string P7;

        public form_ThuatToanHamming()
        {
            InitializeComponent();
        }
        static Random random = new Random();

        // Hàm clear các giá trị trong các textbox
        private void clear_textBox()
        {
            textBox_ReceivedString.Clear();
            textBox_ReceivedVerification.Clear();
            textBox_SValue.Clear();
            textBox_CorrectedFrame.Clear();
            textBox_FaultBitPosition.Clear();
            textBox_CheckReceiveString.Clear();
            textBox_Verification.Clear();
            textBox_FrameOutput.Clear();
            textBox_BinaryInput.Clear();
            richTextBox1_EquationDescription.Clear();
            richTextBox2_EquationDescription.Clear();
        }

        // Các hàm xử lí khi button Nhập được nhấn (Xử lí toàn bộ quá trình tính toán)
        private void button_Input_Click(object sender, EventArgs e)
        {
            // Gọi hàm clear textBox
            clear_textBox();

            // Khởi tạo equation cho việc hiển thị công thức bit kiểm tra
            P1 = "";
            P2 = "";
            P3 = "";
            P4 = "";
            P5 = "";
            P6 = "";
            P7 = "";

            // Lấy giá trị từ ô textBox lưu trữ sang dạng string
            string code_input = textBox_inputContent.Text;

            // Khai báo biến kiểu Binary (định nghĩa tại Binary.cs) để lưu giá trị Bin được
            // chuyển đổi từ string code_input
            Binary binary_input_analyze;
            binary_input_analyze = new Binary(code_input.Select(c => c == '1' ? true : false));
            if (binary_input_analyze.Count() != 0)
            {
                int encode_binary_input;
                if (binary_input_analyze.Count() > Math.Pow(2, 5) - 6) encode_binary_input = 6;
                else if (binary_input_analyze.Count() > Math.Pow(2, 4) - 5) encode_binary_input = 5;
                else if (binary_input_analyze.Count() > Math.Pow(2, 3) - 4) encode_binary_input = 4;
                else encode_binary_input = 3;
                // Tính toán độ dài chuỗi mã Hamming sau khi gắn thêm Priority (các bit thông báo)
                int length_hamming_code = binary_input_analyze.Length + encode_binary_input;
                Binary hamming_code = new Binary(new bool[length_hamming_code]);
                int cnt = 0;
                for (int i = 0; i < length_hamming_code; i++)
                {
                    if (Math.Log(i + 1, 2) - (int)Math.Log(i + 1, 2) == 0)
                    {
                        hamming_code[i] = false;
                    }
                    else
                    {
                        hamming_code[i] = binary_input_analyze[cnt];
                        cnt++;
                    }
                }

                // Tính toán số cột và số hàng cho ma trận Hamming
                int columnsAmount = binary_input_analyze.Count();
                int rowsAmount = (int)Math.Ceiling(Math.Log(columnsAmount, 2) + 1);

                // Tính toán chuỗi bit kiểm tra (Priority Bit) và Chuỗi mã hoá (chuỗi đã chèn các bit thông báo)
                Binary verification = GeneratePriorityBits(encode_binary_input, hamming_code, 1);

                Binary frame = Binary.Concatenate(binary_input_analyze, verification);

                // Hiển thị thông tin tính toán ra màn hình ở các ô textBox
                textBox_BinaryInput.AppendText(binary_input_analyze + "");
                textBox_Verification.AppendText(verification + "\n");
                textBox_FrameOutput.AppendText(frame + "\n");

                // Random việc data gửi đi bị lỗi
                Random ran = new Random();
                int random_data = ran.Next(0, 2);
                bool corrupt_data = (random_data == 1) ? true : false;

                // Tạo chuỗi nhận
                Binary receivedFrame = new Binary(frame.ToArray());
                if (corrupt_data) // Chuỗi nhận được khi gặp lỗi ở vị trí bất kì
                {
                    textBox_CheckReceiveString.AppendText("CHUỖI NHẬN ĐƯỢC BỊ LỖI");
                    int badBit = random.Next(0, receivedFrame.Length - 1);
                    receivedFrame[badBit] = !receivedFrame[badBit];
                }
                // Ngược lại, nếu không gặp lỗi thì xuất ra màn hình
                else textBox_CheckReceiveString.AppendText("CHUỖI NHẬN ĐƯỢC KHÔNG BỊ LỖI");
                // Lọc lấy Priority theo chuỗi nhận (Xét các giá trị bit tại bị trí bit kiểm tra)
                Binary receivedPriority = new Binary(0, encode_binary_input);
                for (int i = 0; i < encode_binary_input; i++)
                {
                    receivedPriority[i] = receivedFrame[(int)Math.Pow(2, i) - 1];
                }

                // Tính toán Priority theo chuỗi nhận (Kiểm tra priority trong toàn chuỗi)
                Binary receivedMessageVerification = GeneratePriorityBits(encode_binary_input, receivedFrame, 0);

                // Xem xét sự khác nhau giữa các bit priority lấy được từ chuỗi nhận 
                // và các bit priority tính toán được từ chuỗi nhận (gọi là corrupt data)
                // Nếu có sự khác nhau, chứng tỏ chuỗi truyền đi gặp lỗi
                Binary s = receivedPriority ^ receivedMessageVerification;

                // Hiển thị thông số ra màn hình qua textBox
                textBox_ReceivedString.AppendText(receivedFrame + "");
                textBox_ReceivedVerification.AppendText(receivedMessageVerification + "");
                textBox_SValue.AppendText(s + "");

                // Hiển thị phương trình biểu diễn bit kiểm tra dựa trên bit thông báo
                // Do sử dụng mặc định vị trí các bit kiểm tra nên phương trình phụ thuộc cũng là cố định
                richTextBox1_EquationDescription.AppendText("Vị trí bit kiểm tra: P1, P2, P4, P8, P16, P32 ,...\n");
                richTextBox1_EquationDescription.AppendText("Bit thông tin ở các vị trí còn lại");
                richTextBox2_EquationDescription.AppendText("P1 = " + P1 + "\n");
                richTextBox2_EquationDescription.AppendText("P2 = " + P2 + "\n");
                richTextBox2_EquationDescription.AppendText("P3 = " + P3 + "\n");
                if (verification.Count() >= 4) richTextBox2_EquationDescription.AppendText("P4 = " + P4 + "\n");
                if (verification.Count() >= 5) richTextBox2_EquationDescription.AppendText("P5 = " + P5 + "\n");
                if (verification.Count() >= 6) richTextBox2_EquationDescription.AppendText("P6 = " + P6 + "\n");
                if (verification.Count() >= 7) richTextBox2_EquationDescription.AppendText("P7 = " + P7 + "\n");
                // NOTE: Hiện tại chương trình hiển thị được với số lượng bit kiểm tra không vượt quá 6.

                // Quá trình sửa lỗi nếu lỗi xảy xa
                if (s.CountOnes() > 0) // Kiểm tra điều kiện đếu có corrupt data
                {
                    try // bắt đầu quá trình sửa lỗi
                    {
                        // Tìm vị trí bit lỗi dựa vào sự khác nhau giữa 2 dãy bit thông báo
                        int faultyBitPosition = FindFaultyBit(encode_binary_input, s);

                        // Tạo chuỗi mới
                        Binary correctedFrame = new Binary(receivedFrame.ToArray());

                        // Sửa giá trị lỗi trong chuỗi để có được chuỗi đúng
                        correctedFrame[faultyBitPosition] = !correctedFrame[faultyBitPosition];

                        // Hiển thị vị trí lỗi và kết quả chuỗi sau khi sửa lỗi
                        textBox_FaultBitPosition.AppendText(faultyBitPosition + 1 + "");
                        textBox_CorrectedFrame.AppendText(correctedFrame + "");
                    }
                    catch (WarningException) // Thông báo ngoại lệ nếu gặp lỗi ngoài hệ thống
                    {
                        MessageBox.Show("WARING_EXCEPTION");
                    }
                }
            }
            else MessageBox.Show("Nhập vào một giá trị vào ô input!!");
        }

        // Hàm tính toán bit kiểm tra dựa trên chuỗi giá trị
        static Binary GeneratePriorityBits(int rowsAmount, Binary message, int enable)
        {

            Binary verification = new Binary(new bool[rowsAmount]);
            int[] priority_array = new int[9] { 0, 1, 3, 7, 15, 31, 63, 127, 255}; // List vị trí bit kiểm tra
            for (int i = 0; i < rowsAmount; i++)
            {
                int position=(int)Math.Pow(2,i)-1;
                int repeat_i = position;
                bool verificationBit = false;
                // Thuật toán đọc và skip các trị theo thuật toán Hamming
                for (int j = 0; j < message.Length; j++)
                {
                    if (position >= message.Length) break;
                    // Kiểm tra nếu vị trí trùng với các bit kiểm tra thì bỏ qua
                    if (!(position == priority_array[0] || position == priority_array[1] || position == priority_array[2] || position == priority_array[3] || position == priority_array[4] || position == priority_array[5] || position == priority_array[6] || position == priority_array[7] || position == priority_array[8]))
                    {
                        if (enable == 1)
                        {
                            switch (i)
                            {
                                case 0:
                                    P1 = string.Concat(P1, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 1:
                                    P2 = string.Concat(P2, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 2:
                                    P3 = string.Concat(P3, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 3:
                                    P4 = string.Concat(P4, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 4:
                                    P5 = string.Concat(P5, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 5:
                                    P6 = string.Concat(P6, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 6:
                                    P7 = string.Concat(P7, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                default: break;
                            } 
                        }
                        verificationBit = (verificationBit != message[position]);
                    }
                    while (repeat_i!=0)
                    {
                        position ++;
                        if (position >= message.Length) break;
                        if (enable == 1)
                        {
                            switch (i)
                            {
                                case 0:
                                    P1 = string.Concat(P1, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 1:
                                    P2 = string.Concat(P2, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 2:
                                    P3 = string.Concat(P3, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 3:
                                    P4 = string.Concat(P4, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 4:
                                    P5 = string.Concat(P5, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 5:
                                    P6 = string.Concat(P6, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                case 6:
                                    P7 = string.Concat(P7, "P", (position + 1).ToString(), " ^ ");
                                    break;
                                default: break;
                            }
                        }
                        verificationBit = verificationBit ^ message[position];
                        repeat_i--;
                    }
                    for (int k = 0; k < (int)Math.Pow(2, i); k++) {
                        position ++;
                    }
                    position++;
                    repeat_i = (int)Math.Pow(2, i) - 1;
                }
                verification[i] = verificationBit;
            }
            return verification;
        }

       // Hàm xác định vị trí bit lỗi
        private static int FindFaultyBit(int rowsAmount, Binary s)
        {
            // Vị trí bit lỗi được tính bằng tổng pow(2,position) các vị trí bit 1 trong chuỗi lỗi s.
            int position=0;
            for (int i = 0; i < rowsAmount; i++)
            {
                bool value = s[i];
                if (value) position += (int)Math.Pow(2, i);
            }
            return position-1;

            throw new WarningException("Faulty bit not found!");
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            Introduction intro_form = new Introduction();
            intro_form.Show();
        }
        private void button_Equation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Từ mã bao gồm data bits và priority bits độ dài n được kí hiệu từ D[0] đến D[n-1]\n\nTheo đó, ta có:\nD[0] được tính bằng cách đọc 1 bit, bỏ 1 bit\nD[0] = D[2] + D[4] + D[6] + D[8]..\n\nD[1] được tính bằng cách đọc 2 bit, bỏ 2 bit\nD[1] = D[2] + D[5] + D[6] + D[9] + D[10] + ..\n\nD[3] được tính bằng cách đọc 4 bit, bỏ 4 bit\nD[3] = D[4] + D[5] + D[6] + D[11] + D[12] + D[13] + D[14]+...\n\nTương tự cho các giá trị kiểm tra tiếp theo");
        }

        private void label_EquationDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
