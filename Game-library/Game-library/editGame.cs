﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Collections;

namespace Game_library
{
    public partial class editGame : UserControl
    {
        public object ListItems { get; private set; }

        public editGame()
        {
            InitializeComponent();
            
        }

        public void GetGameToEdit(string GameToEdit)
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();

            DataTable table = new DataTable();
            string query = "SELECT * FROM Games WHERE GAME_TITLE = '" + GameToEdit + "'";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);


            connection.Close();


            foreach (DataRow item in table.Rows)
            {
                text_title_edit.Text = item["GAME_TITLE"].ToString();
                text_genre_edit.Text = item["GAME_GENRE"].ToString();
                text_imgFile_edit.Text = item["GAME_IMG_FILE"].ToString();
                text_gameFile_edit.Text = item["GAME_PATH"].ToString();
                text_description_edit.Text = item["GAME_DESCRIPTION"].ToString();
                previewBoxImg.BackgroundImage = Image.FromFile(text_imgFile_edit.Text);
            }
             

            
        }

        private void editGame_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            
        }


        public void LoadCombo()
        {
            SqlCeConnection connection = new SqlCeConnection("Data Source =" + CreateDataBase.conString);
            connection.Open();

            DataTable table = new DataTable();
            string query = "SELECT COD_GAME, GAME_TITLE FROM Games";

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, connection);
            adapter.Fill(table);


            connection.Close();

            comboBox1.ValueMember = "COD_GAME";
            comboBox1.DisplayMember = "GAME_TITLE";
            comboBox1.DataSource = table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGameToEdit(comboBox1.Text);
        }
    }
}
