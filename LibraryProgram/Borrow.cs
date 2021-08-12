using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LibraryProgram
{
    public partial class Borrow : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "csproject";
        string _id = "mirim";
        string _pw = "mirim321!";
        string _connectionAddress = "";


        public Borrow()
        {
            InitializeComponent();
            
            _connectionAddress = string.Format("Server={0}; Port={1}; Database={2};" +
                "Uid={3}; Pwd={4}", _server, _port, _database, _id, _pw);
        }
        private void selcetTable()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT title, writer FROM book WHERE title LIKE '%" + searchTB.Text +"%' OR writer LIKE '%" + searchTB.Text + "%'");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewBook.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["title"].ToString();
                        item.SubItems.Add(table["writer"].ToString());

                        listViewBook.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Borrow_Load(object sender, EventArgs e)
        {
            listViewBook.View = View.Details;

            //listViewBook.GridLines = true;
            listViewBook.FullRowSelect = true;

            listViewBook.Columns.Add("책 제목", 100);
            listViewBook.Columns.Add("작가");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (searchTB.Text == "" || searchTB.Text == null)
            {

            }
            else
            {
                selcetTable();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewBook_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listViewBook.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = listViewBook.SelectedItems;
                ListViewItem lvitem = items[0];
                string one = lvitem.SubItems[0].Text;
                string two = lvitem.SubItems[1].Text;
                MessageBox.Show(one + ", " + two);
            }
        }
    }
}
