using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using ClassUserControl;

namespace TEST
{
    public partial class Form1 : Form
    {
        private static string strConn = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=ThongKe;Integrated Security=True";
        private static string ConnHHNI = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=HHNI;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCbb()
        {
            DataTable dt = SqlHelper.ExecuteDataset(strConn, CommandType.Text, "select id, solo from tbl_DanhSachSoLieu").Tables[0];
            List<tstt> items = new List<tstt>();

            DataRow[] rows = dt.Select("Id >= 730 ");

            foreach (DataRow row in rows)
            {
                //CCBoxItem item = new CCBoxItem(row["SoLo"].ToString(), Convert.ToInt32(row["Id"].ToString()));
                //cbbTest.Items.Add(item);
                //comboBox1.Items.Add(new CCBoxItem(row["SoLo"].ToString(), Convert.ToInt32(row["Id"].ToString())));
                items.Add(new tstt() { Name = row["SoLo"].ToString(), Id = Convert.ToInt32(row["Id"].ToString()) });

            }
            var sax = items.Where(s => s.Id >= 730);
            comboBox1.DataSource = sax.ToList();
            //comboBox1.ValueMember = "Id";
            //comboBox1.DisplayMember = "Name";

        }
        static BindingSource bindingS = new BindingSource();
        void FillCombo()
        {
            comboBox1.Items.Clear();
            DataSet ds = SqlHelper.ExecuteDataset(strConn, CommandType.Text, "select top 10 id, solo from tbl_DanhSachSoLieu");
            object[] obj = jDataBind(ds, "tbl_DanhSachSoLieu", "SoLo", true);
            comboBox1.Items.AddRange(obj);
        }

        static object[] jDataBind(DataSet dataset, string tableName, string columName, bool unique)
        {
            bindingS.DataSource = dataset;
            bindingS.DataMember = tableName;
            List<string> itemTypes = new List<string>();
            foreach (DataRow r in dataset.Tables[tableName].Rows)
            {
                try
                {
                    object typ = r[columName];
                    if ((typ != null) && (typ != DBNull.Value))
                    {
                        string strTyp = typ.ToString().Trim();
                        if (!string.IsNullOrEmpty(strTyp))
                        {
                            if (unique)
                            {
                                if (!itemTypes.Contains(strTyp))
                                {
                                    itemTypes.Add(strTyp);
                                }
                            }
                            else
                            {
                                itemTypes.Add(strTyp);
                            }
                        }

                    }
                }
                catch (Exception err)
                {
                    Console.Write("databind", err);
                }
            }
            return itemTypes.ToArray();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            LoadPhong();


        }


        private void cbbTest_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public class tstt
        {
            private string _name;

            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            private int id;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public tstt()
            {

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        DataTable dts = SqlHelper.ExecuteDataset(strConn, CommandType.Text, "select Id, SoLo from tbl_DanhSachSoLieu").Tables[0];
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {


            var sourceBase = comboBox1.DataSource;

            List<tstt> suo = ((List<tstt>)comboBox1.DataSource).Where(s => s.Name.Contains(textBox1.Text)).ToList();
            foreach (tstt item in suo)
            {
                cbbTest.Items.Add(new CCBoxItem(item.Name, item.Id));
            }
            //cbbTest.DataSource = ((List<tstt>)comboBox1.DataSource).Where(s => s.Name.Contains(textBox1.Text)).ToList();
            //cbbTest.DisplayMember = "Name";
            //cbbTest.ValueMember = "Id";
            //List<tstt> items = new List<tstt>();

            //DataRow[] rows = dts.Select();
            //string tx = textBox1.Text;
            //var data = rows.Where(s => s.Field<string>("SoLo").Contains(this.textBox1.Text));
            //if (data.Any())
            //{
            //    listBox1.DataSource = data.CopyToDataTable(); 

            //}
            //else
            //{
            //    listBox1.DataSource = rows.CopyToDataTable();
            //}
            //listBox1.DisplayMember = "SoLo";
            //listBox1.ValueMember = "Id";
        }

        #region[test]
        

        List<ComboBox> _cbb;
        private void CapNhat()
        {
            _cbb = new List<ComboBox>();
            foreach (Control cbb in this.Controls)
            {
                if (cbb is ComboBox && cbb.Tag is int)
                {
                    _cbb.Add((ComboBox)cbb);
                }
            }
        }
        private class ItemCBB
        {
            private string _Value;
            private string _IdCha;

            public string IdCha
            {
                get { return _IdCha; }
                set
                {
                    if (value == null)
                        _IdCha = null;
                    else
                        _IdCha = value;
                }
            }
            public string Value
            {
                get { return _Value; }
                set { _Value = value; }
            }
            private string _Name;
            private int _Lever;

            public int Lever
            {
                get { return _Lever; }
                set { _Lever = value; }
            }
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public ItemCBB(string Value, string Name, string IdCha)
            {
                _Value = Value;
                _Name = Name;
                _IdCha = IdCha;
            }
            public ItemCBB(string Value, string Name, string IdCha, int lever)
            {
                _Value = Value;
                _Name = Name;
                _IdCha = IdCha;
                _Lever = lever; 
            }
            public override string ToString()
            {
                return _Name;
            }
        }
        private void LoadPhong()
        {
            DataTable dt = SqlHelper.ExecuteDataset(ConnHHNI, CommandType.Text, "select * from tblTest").Tables[0];
            int soCBB = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnHHNI, CommandType.Text, "select max(lever) from tblTest").ToString());
            int lcbb = 10, tcbb = 10;



            CheckedComboBox cbb = new CheckedComboBox();
            //cbb.Name = "cbb_" + i.ToString();
            cbb.Size = new Size(200, 30);
            cbb.Location = new Point(lcbb, cbb.Location.Y + cbb.Height + tcbb);
            this.Controls.Add(cbb);
            DataRow[] dr = dt.Select("idcha =0");
            foreach (DataRow r in dr)
            {
                cbbPhong.Items.Add(new ItemCBB(r["Id"].ToString(), r["Ten"].ToString(), "0", Convert.ToInt32(r["Lever"].ToString())));
                cbb.Items.Add(new ItemCBB(r["Id"].ToString(), r["Ten"].ToString(), "0"));
            }
            cbbPhong.SelectedIndex = 0;
            
            
        }
        int intTag = 0;
        private void CCB_SelectedIndexChange(object sender, EventArgs e)
        {
            DataTable dt = SqlHelper.ExecuteDataset(ConnHHNI, CommandType.Text, "select * from tblTest").Tables[0];
            ItemCBB item = (sender as ComboBox).SelectedItem as ItemCBB;
            int soCBB = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnHHNI, CommandType.Text, "select max(lever) from tblTest").ToString());
            List<ItemCBB> lst = new List<ItemCBB>();
            DataRow[] dr = dt.Select("IdCha = " + ((sender as ComboBox).SelectedItem as ItemCBB).Value);

            if (dr.Any())
            {
                intTag++;
                ComboBox cbb = new ComboBox();
                cbb.Size = new Size(120, 30);
                cbb.Tag = item.Lever;
                cbb.Location = new Point((sender as ComboBox).Location.X + 30, (sender as ComboBox).Location.Y + (sender as ComboBox).Height + 30);
                foreach (DataRow r in dr)
                {
                    cbb.Items.Add(new ItemCBB(r["Id"].ToString(), r["Ten"].ToString(), r["IdCha"].ToString(), Convert.ToInt32(r["Lever"].ToString())));
                }
                cbb.SelectedIndexChanged += CCB_SelectedIndexChange;
                cbb.SelectedIndex = -1;
                this.Controls.Add(cbb);
                cbb.SelectedIndex = 0;
                CapNhat();
            }
            else
            {

                for (int i = Convert.ToInt32((sender as ComboBox).Tag) + 1; i < soCBB; i++)
                {
                    foreach (ComboBox bo in _cbb)
                    {
                        if (bo.Tag.ToString() == i.ToString())
                        {
                            bo.Dispose();
                        }
                    }
                }
            }

        }
        
        

        #endregion

        







    }

        
}
