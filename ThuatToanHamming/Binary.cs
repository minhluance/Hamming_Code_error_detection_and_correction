using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ThuatToanHamming
{
    [DebuggerDisplay("{binary}")]
    class Binary : IEnumerable<bool>
    {
        List<bool> binary;

        public int Length { get { return binary.Count; } }

        #region Constructors
        public Binary(List<bool> binary)
        {
            this.binary = binary;
        }

        public Binary(IEnumerable<bool> binary)
        {
            this.binary = new List<bool>(binary);
        }

        public Binary (int value)
        {
            
            binary = new List<bool>(ConvertToBinary(value));
        }
        
        public Binary(int value, int minSize)
        {
            binary = new List<bool>(ConvertToBinary(value, minSize));
        }
        #endregion

        public bool this[int index]
        {
            get { return binary[index]; }
            set { binary[index] = value; }
        }

        public static IEnumerable<bool> ConvertToBinary(int value)
        {
            string binaryString = Convert.ToString(value, 2);
            return binaryString.Select(c => c == '1');
        }

        public static IEnumerable<bool> ConvertToBinary(int value, int minSize)
        {
            List<bool> toBinary = new List<bool>(ConvertToBinary(value));
            while (toBinary.Count != minSize)
            {
                toBinary.Insert(0,false);
            }
            return toBinary;
        }

        public int CountOnes ()
        {
            return binary.Count(bit => bit);
        }

        public int CountZeroes()
        {
            return binary.Count(bit => !bit);
        }


        public static Binary Concatenate ( Binary a, Binary b)
        {
            Binary result = new Binary(new bool[a.Length+b.Length]);
            int length_concatenante = a.Length + b.Length;
            int a_cnt = 0, b_cnt = 0;
            for (int i = 0; i < length_concatenante; i++)
            {
                if (Math.Log(i + 1, 2) - (int)Math.Log(i + 1, 2) == 0)
                {
                    result[i] = b[b_cnt];
                    b_cnt++;
                }
                else
                {
                    result[i] = a[a_cnt];
                    a_cnt++;
                }
            }
            return result;
        }

        public static Binary operator &(Binary a, Binary b)
        {
            if (a.Length != b.Length)
                throw new ArgumentException("Binaries must have same length");

            bool[] result = new bool[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] & b[i];
            }

            return new Binary(result);
        }

        public static Binary operator ^(Binary a, Binary b)
        {
            if (a.Length != b.Length)
                throw new ArgumentException("Binaries must have same length");

            bool[] result = new bool[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] ^ b[i];
            }

            return new Binary(result);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder(binary.Count);
            foreach (bool bit in binary)
            {
                stringBuilder.Append(bit?'1':'0');
            }
            return stringBuilder.ToString();
        }

        #region IEnumerable
        public IEnumerator<bool> GetEnumerator()
        {
            return binary.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return binary.GetEnumerator();
        }
        #endregion
    }
}
