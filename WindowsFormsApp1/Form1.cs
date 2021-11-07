using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //計算するボタンをクリックされた時に来る
        private void button1_Click(object sender, EventArgs e)
        {
            calc(true);
        }
        private void calc(bool autoFlg) 
        { 
            if (autoFlg == false)
            {
                //チェックされていない　＝　手動
                return;
            }
            int value1 = 0;
            int value2 = 0;

            if (String.IsNullOrEmpty(txtValue1.Text))
            {
                MessageBox.Show("入力欄１が空です");
                return;
            }
            /* Javaにありがちな記述
            String a;
            //if (a.Equals(""))
            if ("".Equals(a))
            {

            }
            */

            /*
            if (txtValue1.Text.Equals(""))
            {
                MessageBox.Show("入力欄１が空です");
                return;
            }
            */

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("演算子を選択してください");
                return;
            }

            if (txtValue2.Text.Equals(""))
            {
                MessageBox.Show("入力欄２が空です");
                return;
            }

            try
            {
                value1 = int.Parse(txtValue1.Text);
                value2 = int.Parse(txtValue2.Text);
            } catch (Exception ex)
            {
                //エラー処理
                MessageBox.Show("エラーだよ");
                return;
            }
            //文字列→数値変換 txtValue1はString型
            //int value1 = int.Parse(txtValue1.Text);
            //int value2 = int.Parse(txtValue2.Text);

            //int answer = value1 + value2;

            //listBox1.SelectedIndex;
            //MessageBox.Show(listBox1.SelectedIndex.ToString());
            //MessageBox.Show(listBox1.SelectedItem.ToString());

            int answer = 0;
            if (listBox1.SelectedIndex == 0)
            { //+の場合
                answer = value1 + value2;
            }
            if (listBox1.SelectedIndex == 1)
            {
                answer = value1 - value2;
            }
            if (listBox1.SelectedIndex == 2)
            {
                answer = value1 * value2;
            }
            if (listBox1.SelectedIndex == 3)
            {
                answer = value1 / value2;
            }

            /* SelectedItemの場合
            int answer = 0; //if文の内部だとカッコから出た瞬間に使えなくなってしまう
    
            if (listBox1.SelectedItem.Equals("+")) //Equals→文字列が一致してるか比較
            {
                answer = value1 + value2;
            }
            if (listBox1.SelectedItem.Equals("-"))
            {
                answer = value1 - value2;
            }
            if (listBox1.SelectedItem.Equals("*"))
            {
                answer = value1 * value2;
            }
            if (listBox1.SelectedItem.Equals("/"))
            {
                answer = value1 / value2;
            }
            */

            //txtAnswer.TextはString型　→　answerをintからstringに変換
            txtAnswer.Text = answer.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {
            calc(checkBox1.Checked);
        }

        private void txtValue2_TextChanged(object sender, EventArgs e)
        {
            calc(checkBox1.Checked);
        }
    }
}
