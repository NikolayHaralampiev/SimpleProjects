using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class NoteTaker : Form
    {
        DataTable notes = new DataTable();
        bool change = false;
        public NoteTaker()
        {
            InitializeComponent();
        }

        private void NoteTaker_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Tittle");
            notes.Columns.Add("Note");
            
            lastNotes.DataSource = notes;
        }

        private void newNoteButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            noteBox.Text = "";
            change = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (change)
            {
                notes.Rows[lastNotes.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                notes.Rows[lastNotes.CurrentCell.RowIndex]["Note"] = titleBox.Text;
            }
            else
            {
               notes.Rows.Add(titleBox.Text, noteBox.Text);
            }
            titleBox.Text = "";
            noteBox.Text = "";
            change = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[lastNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception) { Console.WriteLine("Invalid Note!!!"); }
        }

        private void lastNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleBox.Text = notes.Rows[lastNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            noteBox.Text = notes.Rows[lastNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            change = true;
        }
    }
}
