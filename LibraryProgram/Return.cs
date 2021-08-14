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
    public partial class Return : Form
    {
        string _server = BorrowAndReturn._server;
        int _port = BorrowAndReturn._port;
        string _database = BorrowAndReturn._database;
        string _id = BorrowAndReturn._id;
        string _pw = BorrowAndReturn._pw;
        string _connectionAddress = "";
        string connect_user = BorrowAndReturn.connect_user;
        DateTime date_borrow, date_return;
        public ListView return_list;
        public Return()
        {
            InitializeComponent();

            _connectionAddress = string.Format("Server={0}; Port={1}; Database={2};" +
                "Uid={3}; Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void Return_Load(object sender, EventArgs e)
        {
            listViewBook.View = View.Details;

            //listViewBook.GridLines = true;
            listViewBook.FullRowSelect = true;

            listViewBook.Columns.Add("책 제목", 100);
            listViewBook.Columns.Add("작가", 80);
            listViewBook.Columns.Add("출판사", 100);
            listViewBook.Columns.Add("대출일", 120);
            listViewBook.Columns.Add("반납일", 120);

            loading_list();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loading_list();
        }

        private void loading_list()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    //accounts_table의 전체 데이터를 조회합니다.            
                    string selectQuery = string.Format("SELECT title, writer, publisher, borrow_user " +
                        "FROM book WHERE borrow_user LIKE '%" + connect_user + "%'");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listViewBook.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["title"].ToString();
                        item.SubItems.Add(table["writer"].ToString());
                        item.SubItems.Add(table["publisher"].ToString());
                        int index = table["borrow_user"].ToString().IndexOf(connect_user);
                        string strDate = table["borrow_user"].ToString().Substring(index + 8, 8).ToString();
                        date_borrow = DateTime.ParseExact(strDate, "yyyyMMdd", null);
                        date_return = date_borrow.AddDays(15);

                        item.SubItems.Add(date_borrow.ToString("yyyy년MM월dd일"));
                        item.SubItems.Add(date_return.ToString("yyyy년MM월dd일"));

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

        private void returning(string selectItem)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string updateQuery = "";

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
