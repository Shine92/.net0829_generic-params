using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0829_RefOut {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //傳入兩個參數 不限定型別 都用最大的型別計算 double 8 byte
        T Add<T>(T x, T y) {
            double Result = Convert.ToDouble(x) + Convert.ToDouble(y);  
            return (T) Convert.ChangeType(Result,typeof(T));
        }
        //傳入多個參數
        double Total(params double[] Souce) {
            double Result = 0;
            foreach (double Data in Souce) {
                Result += Data;
            }
            return Result;
        }

        T AddTwo <T , U>(T x, U y) {
            double Result = 0;
            Result = Convert.ToDouble(x) + Convert.ToDouble(y);
            return (T) Convert.ChangeType(Result,typeof(U));
        }

        private void Btn1_Click(object sender, EventArgs e) {
            ValTextBox.Text = Add(10, 20.555).ToString();
        }

        private void Btn2_Click(object sender, EventArgs e) {

            double x = Convert.ToDouble(ParamsTextBox1.Text);
            double y = Convert.ToDouble(ParamsTextBox2.Text);
            double z = Convert.ToDouble(ParamsTextBox3.Text);

            ParamsValTextBox.Text = Total(x,y,z).ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {
            ParamsTextBox1.Text = "10.11";
            ParamsTextBox2.Text = "20.222";
            ParamsTextBox3.Text = "30.3333";
        }

        private void Btn3_Click(object sender, EventArgs e) {
            ValTextBox2.Text = AddTwo(10,10.555).ToString();
        }
    }
}
