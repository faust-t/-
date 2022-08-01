using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义一个字符串
        string input = null;
        //结果
        double num = 0;
        
        /// <summary>
        /// 加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "+";
            input = input + "+" + " ";
        }

        /// <summary>
        /// 减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReduce_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "-";
            input = input + "-" + " ";
        }

        /// <summary>
        /// 乘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRide_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "*";
            input = input + "*" + " ";
        }

        /// <summary>
        /// 除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcept_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "/";
            input = input + "/" + " ";
        }

        /// <summary>
        /// 取模
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTakeMode_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "%";
            input = input + "%" + " ";
        }

        /// <summary>
        /// 小数点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spot_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + ".";
            input = input + "." + " ";
        }

        /// <summary>
        /// 数字0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZero_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "0";
            input = input + "0" + " ";
        }
        /// <summary>
        /// 数字1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOne_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "1";
            input = input + "1" + " ";
        }
        /// <summary>
        /// 数字2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "2";
            input = input + "2" + " ";
        }
        /// <summary>
        /// 数字3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThree_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "3";
            input = input + "3" + " ";
        }
        /// <summary>
        /// 数字4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFour_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "4";
            input = input + "4" + " ";
        }
        /// <summary>
        /// 数字5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFive_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "5";
            input = input + "5" + " ";
        }
        /// <summary>
        /// 数字6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSix_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "6";
            input = input + "6" + " ";
        }
        /// <summary>
        /// 数字7
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeven_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "7";
            input = input + "7" + " ";
        }
        /// <summary>
        /// 数字8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEight_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "8";
            input = input + "8" + " ";
        }
        /// <summary>
        /// 数字9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNine_Click(object sender, EventArgs e)
        {
            labInput.Text = labInput.Text + "9";
            input = input + "9" + " ";
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnEqual.Select();
        }

        /// <summary>
        /// 等于 
        /// 输出结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string str = null;

            //首先判断输入的字符长度
            if (input.Length > 0)
            {
                //判断输入的最后一个字符是不是运算符 若果是就直接删除掉
                input = JudgeSpace(input);
            }

            //以空格做分隔符 第一次处理输入的字符
            string[] firstString = input.Split(' ');
            //1.拼接输入的算式
            str = InputLine(firstString);
            //2.优先执行 乘 除 取模 运算
            string[] secondString = str.Split(' ');
            str = FirstOperation(secondString);
            //str = str.Substring(2, str.Length);
            //3.执行加减运算
            string[] finalString = str.Split(' ');
            num = SecondOperation(finalString);
            //输出结果
            labOutput.Text = Convert.ToString(num);

        }

        /// <summary>
        /// 判断输入的最后一个字符是不是运算符 若果是就直接删除掉
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string JudgeSpace(string input)
        {
            if (input[input.Length - 2] == '+' | input[input.Length - 2] == '-' | input[input.Length - 2] == '*' | input[input.Length - 2] == '/' | input[input.Length - 2] == '%')
            {
                input = input.Substring(0, input.Length - 2);
            }
            return input;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (labInput.Text.Length > 0)
            {
                labInput.Text = labInput.Text.Substring(0, labInput.Text.Length - 1);
                input = input.Substring(0, input.Length - 2);
            }
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        { 
            labInput.Text = "";
            labOutput.Text = "";
            input = "";
        }

        /// <summary>
        /// 3.执行加减
        /// </summary>
        /// <param name="finalString"></param>
        /// <returns></returns>
        public double SecondOperation(string[] finalString)
        {

            if (finalString.Length > 1)
            {
                for (int i = 1; i < finalString.Length; i++)
                {
                    if (finalString[i] == "+")
                    {
                        num = Convert.ToDouble(finalString[i - 1]) + Convert.ToDouble(finalString[i + 1]);
                        finalString[i + 1] = num.ToString();
                    }
                    else if (finalString[i] == "-")
                    {
                        num = Convert.ToDouble(finalString[i - 1]) - Convert.ToDouble(finalString[i + 1]);
                        finalString[i + 1] = num.ToString();
                    }

                }
            }
            else
            {
                num = Convert.ToDouble(finalString[0]);
            }
            return num;
        }

        /// <summary>
        /// 2.优先执行乘除取模
        /// </summary>
        /// <param name="secondString"></param>
        /// <returns></returns>
        public string FirstOperation(string[] secondString)
        {
            //声明一个动态数组
            ArrayList list = new ArrayList();
            //*/%算式
            string s = "";
            for (int i = 0; i < secondString.Length; i++)
            {
                if (secondString[i] == "*")
                {
                    num = Convert.ToDouble(secondString[i - 1]) * Convert.ToDouble(secondString[i + 1]);
                    secondString[i + 1] = num.ToString();
                    if (list.Count > 0)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                }
                else if (secondString[i] == "/")
                {
                    num = Convert.ToDouble(secondString[i - 1]) / Convert.ToDouble(secondString[i + 1]);
                    secondString[i + 1] = num.ToString();
                    if (list.Count > 0)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                }
                else if (secondString[i] == "%")
                {
                    num = Convert.ToDouble(secondString[i - 1]) % Convert.ToDouble(secondString[i + 1]);
                    secondString[i + 1] = num.ToString();
                    if (list.Count > 0)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                }
                else
                {
                    list.Add(secondString[i]);
                }
            }
            s = string.Join(" ", (string[])list.ToArray(typeof(string)));
            return s;
        }

        /// <summary>
        /// 1.拼接输入的算式
        /// </summary>
        /// <param name="firstString"></param>
        /// <returns></returns>
        public string InputLine(string[] firstString)
        {
            string str = null;
            for (int i = 0; i < firstString.Length; i++)
            {
                //当这个字符不是 +-*/% 时直接拼接
                if (firstString[i] != "+" && firstString[i] != "-" && firstString[i] != "*" && firstString[i] != "/" && firstString[i] != "%")
                {
                    str = str + firstString[i];
                }
                else
                {
                    str = str + " " + firstString[i] + " ";
                }
            }
            return str;
        }
    }
}
