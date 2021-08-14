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
        string _server = BorrowAndReturn._server;
        int _port = BorrowAndReturn._port;
        string _database = BorrowAndReturn._database;
        string _id = BorrowAndReturn._id;
        string _pw = BorrowAndReturn._pw;
        string _connectionAddress = "";
        public static string select_book_id = "";

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
                    string selectQuery = string.Format("SELECT title, writer, publisher, book_id FROM book WHERE title LIKE '%" + searchTB.Text +"%' OR writer LIKE '%" + searchTB.Text + "%'");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewBook.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["title"].ToString();
                        item.SubItems.Add(table["writer"].ToString());
                        item.SubItems.Add(table["publisher"].ToString());
                        item.SubItems.Add(table["book_id"].ToString());

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
            listViewBook.Columns.Add("출판사");
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
                select_book_id = lvitem.SubItems[3].Text;
                Borrow_info borrow_Info = new Borrow_info();
                borrow_Info.ShowDialog();
            }
        }
    }
}
