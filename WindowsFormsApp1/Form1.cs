using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin.SkinControl;
using CCWin;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : CCSkinMain
    {
        public Form1()
        {
            InitializeComponent();
            //设置标题栏无按钮
            //this.ControlBox = false;
            //

            //多行文本框
            cxFlatTextBox2.Text =
                "A" + Environment.NewLine
                + "B" + Environment.NewLine
                + "C" + Environment.NewLine
                + "D" + Environment.NewLine
                + "E" + Environment.NewLine
                + "F" + Environment.NewLine
                + "G" + Environment.NewLine
                + "H" + Environment.NewLine
                + "I" + Environment.NewLine
                + "J" + Environment.NewLine
                + "K" + Environment.NewLine;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cxFlatRoundProgressBar1.ValueNumber += 10;
            if (timer1.Enabled)
                timer1.Stop();
            else
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void cxFlatContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            cxFlatButton2.Text = e.ClickedItem.Text;
        }

        private void cxFlatDatePicker1_onDateChanged(DateTime newDateTime)
        {
            label1.Text = cxFlatDatePicker1.Date.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“setDataSet.kpi_info”中。您可以根据需要移动或删除它。
            this.kpi_infoTableAdapter.Fill(this.setDataSet.kpi_info);
            // TODO: 这行代码将数据加载到表“setDataSet.kpi”中。您可以根据需要移动或删除它。
            this.kpiTableAdapter.Fill(this.setDataSet.kpi);

        }

        private void CxFlatRoundButton1_Click(object sender, EventArgs e)
        {
            /*数据库连接
            //1.创建数据连接,这里注意你登录数据库的数据库名称，用户名和密码
            string strcon = "server=localhost;database=set;uid=root;pwd=sas124578;";
            MySqlConnection con = new MySqlConnection(strcon);

            //2. 打开数据库
            con.Open();
            //3. sql语句
            string sqlSel = "server=localhost;database=set;uid=root;pwd=sas124578;";
            MySqlCommand com = new MySqlCommand(sqlSel, con);
            //MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand("Your sql query");
            MySqlDataReader dr = cmd.ExecuteReader();

            dataGridView1.DataSource = dr;
            //dataGridView1.DataBindings control ;
            */
            string str = "server=localhost;database=set;uid=root;pwd=sas124578;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            string strcmd = "select * from kpi";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);//查询结果填充数据集
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();//关闭连接


        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kpi_infoTableAdapter.Fill(this.setDataSet.kpi_info);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void SkinButton11_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;database=set;uid=root;pwd=sas124578;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            string strcmd = "select * from kpi";
            MySqlCommand cmd = new MySqlCommand(strcmd, con);
            MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ada.Fill(ds);//查询结果填充数据集
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();//关闭连接
        }
    }
    
}
