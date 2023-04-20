using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 16비트 CRC 레지스터 최초로 한번만 선언
        /// 선언한 CRC레지스터와 CRC를 만들 데이터 바이트를 XOR 연산.
        /// 만약 LSB의 첫 번째 비트가 1이라면 미리 설정된 고정 값(0xA001)과 XOR연산 진행
        /// 연산 후 LSB 방향, 즉 오른쪽으로 비트시프트 연산을 1회 진행.
        /// 위 과정을 CRC를 만들 데이터 바이트 길이만큼 진행.
        /// CRC 레지스터값이 메시지에 대한 CRC 값이 됨.
        /// </summary>
        /// <param name="data">CRC를 구할 데이터 값 </param>
        /// <returns></returns>
        public byte[] CalculateCrc(byte[] data)
        {
            ushort crc = 0xFFFF;

            foreach (byte b in data)
            {
                crc ^= b;//XOR 연산

                for (int i = 0; i < 8; i++)//표준에 맞게 8번 반복
                {
                    bool lsb = (crc & 0x0001) == 0x0001;
                    crc >>= 1;//오른쪽으로 시프트 1번

                    if (lsb)//lsb가 참이면(0x01) 값을 뽑아오기 위해 비트연산 진행
                    {
                        crc ^= 0xA001;//지정된 값으로 비트연산
                    }
                }
            }
            return BitConverter.GetBytes((ushort)((crc >> 8) | (crc << 8)));
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private byte[] string_to_byte(string tmp)
        {
            if (tmp.Length % 2 == 1)
            {
                return null;
            }
            byte[] bytes = new byte[tmp.Length / 2];
            for (int i = 0; i < tmp.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(tmp[i].ToString() + tmp[i + 1].ToString(), 16);
            }
            return bytes;
        }

        private void InputtextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (InputtextBox.Text == "")
                {
                    return;
                }
                byte[] rbyte = new byte[2];
                if (IASCIIradioButton.Checked)
                {
                    string tmp = InputtextBox.Text.Replace("\r", "").Replace("\n", "").Replace(":", "");
                    rbyte = CalculateCrc(string_to_byte(tmp));
                }
                else if (IHexradioButton.Checked)
                {
                    string tmp = InputtextBox.Text.Replace("0x", "").Replace(" ", "");
                    rbyte = CalculateCrc(string_to_byte(tmp));
                }


                if (OASCIIradioButton.Checked)
                {
                    int i = 0;
                    List<int> ints = new List<int>();
                    foreach(byte b in rbyte)
                    {
                        if (b == 0x00)
                        {
                            rbyte[i] = 0xFF;
                            ints.Add(i);
                        }
                        i++;
                    }

                    StringBuilder sb = new StringBuilder(Encoding.UTF7.GetString(rbyte));
                    foreach (int x in ints)
                    {
                        sb[x] = '\0';
                    }
                    OutputtextBox.Text = sb.ToString();

                }
                else if (OHexradioButton.Checked)
                {
                    string tmp = "";
                    if (ZeroXCheckBox.Checked)
                    {
                        tmp = string.Join("", rbyte.Select(b => $"0x{b:X2}"));

                        if (BlankcheckBox.Checked)
                        {
                            tmp = string.Join(" ", rbyte.Select(b => $"0x{b:X2}"));
                        }
                        if (OHyphenheckBox.Checked)
                        {
                            tmp = string.Join("-", rbyte.Select(b => $"0x{b:X2}"));
                        }
                    }
                    else
                    {
                        tmp = BitConverter.ToString(rbyte);
                        if (BlankcheckBox.Checked)
                        {
                            tmp = tmp.Replace("-", " ");
                        }
                        if (OHyphenheckBox.Checked == false)
                        {
                            tmp = tmp.Replace("-", "");
                        }

                    }
                    OutputtextBox.Text = tmp;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void OASCIIradioButton_CheckedChanged(object sender, EventArgs e)
        {
            string tmp = InputtextBox.Text;
            InputtextBox.Text = "";
            InputtextBox.Text = tmp;
        }

        private void OHexradioButton_CheckedChanged(object sender, EventArgs e)
        {
            string tmp = InputtextBox.Text;
            InputtextBox.Text = "";
            InputtextBox.Text = tmp;
        }

        private void OHyphenheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(OHyphenheckBox.Checked)
            {
                BlankcheckBox.Checked = false;
            }
            string tmp = InputtextBox.Text;
            InputtextBox.Text = "";
            InputtextBox.Text = tmp;
        }

        private void BlankcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(BlankcheckBox.Checked)
            {
                OHyphenheckBox.Checked = false;
            }
            string tmp = InputtextBox.Text;
            InputtextBox.Text = "";
            InputtextBox.Text = tmp;
        }

        private void ZeroXCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            string tmp = InputtextBox.Text;
            InputtextBox.Text = "";
            InputtextBox.Text = tmp;
        }
    }
}
