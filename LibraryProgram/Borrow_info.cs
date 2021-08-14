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
    public partial class Borrow_info : Form
    {
        string _server = BorrowAndReturn._server;
        int _port = BorrowAndReturn._port;
        string _database = BorrowAndReturn._database;
        string _id = BorrowAndReturn._id;
        string _pw = BorrowAndReturn._pw;
        string _connectionAddress = "";
        string bookTitle = "";
        string writer_publisher = "";
        string bookStock = "";
        string connect_user = BorrowAndReturn.connect_user;
        public Borrow_info()
        {
            InitializeComponent();

            _connectionAddress = string.Format("Server={0}; Port={1}; Database={2};" +
                "Uid={3}; Pwd={4}", _server, _port, _database, _id, _pw);

            info_loading();

            this.book_title.Text = bookTitle;
            this.writerNpublisher.Text = writer_publisher;
            this.stock.Text = "대출 가능 권수 : " + bookStock + "권";
        }
        public void info_loading()
        {
            try
            {
                using(MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = "SELECT * FROM book WHERE book_id='" + Borrow.select_book_id +"'";

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    while (table.Read())
                    {
                        bookTitle = table["title"].ToString();
                        writer_publisher = table["writer"].ToString() + " · " + table["publisher"].ToString();
                        bookStock = table["stock"].ToString();
                    }

                    mysql.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void Borrow_info_Load(object sender, EventArgs e)
        {

        }

        private void btn_borrow_click(object sender, EventArgs e)
        {
            user_borrow();
        }
        private void user_borrow()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();

                    string date = DateTime.Now.ToString("yyyyMMdd");

                    string updateQuery = "UPDATE book " +
                        "SET borrow_user=concat('" + connect_user + "(" + date + ")/', borrow_user), stock=stock-1 " +
                        "WHERE book_id='" + Borrow.select_book_id + "'";

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);

                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed");
                    else
                    {
                        MessageBox.Show("대출하였습니다");
                        Dispose();
                    }

                    mysql.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
