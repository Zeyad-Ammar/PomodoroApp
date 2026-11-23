using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApp
{
    public partial class frmMessages : Form
    {
        private List<EncouragementMessage> messages;
        public frmMessages()
        {
            InitializeComponent();

        }

        
        private void Messages_Load(object sender, EventArgs e)
        {
            FillGrid();
        }


        private void DesignGrid()
        {
            // General appearance
            dgvMessages.BorderStyle = BorderStyle.None;
            dgvMessages.BackgroundColor = Color.FromArgb(248, 250, 252);
            dgvMessages.GridColor = Color.FromArgb(225, 232, 238);

            // Headers
            dgvMessages.EnableHeadersVisualStyles = false;
            dgvMessages.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMessages.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(40, 106, 142);
            dgvMessages.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMessages.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);
            dgvMessages.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvMessages.ColumnHeadersHeight = 48;
            dgvMessages.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Rows
            dgvMessages.DefaultCellStyle.BackColor = Color.White;
            dgvMessages.DefaultCellStyle.ForeColor =
                Color.FromArgb(45, 55, 65);
            dgvMessages.DefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);

            dgvMessages.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(201, 229, 245);
            dgvMessages.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(30, 60, 80);

            // Alternating rows
            dgvMessages.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(237, 245, 250);

            // Row settings
            dgvMessages.RowTemplate.Height = 48;
            dgvMessages.RowHeadersVisible = false;
            dgvMessages.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgvMessages.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMessages.MultiSelect = false;

            dgvMessages.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvMessages.AllowUserToResizeRows = false;
            dgvMessages.AllowUserToAddRows = false;
            dgvMessages.AllowUserToDeleteRows = false;

            // Column sizing
            dgvMessages.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvMessages.DefaultCellStyle.Padding =
                new Padding(8, 4, 8, 4);

            // Message wrapping
            dgvMessages.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;

            dgvMessages.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.AllCells;
        }


        private void FillGrid()
        {

            messages = EncouragementMessage.GetAllMessages();

            dgvMessages.DataSource = messages;

            DesignGrid();

            dgvMessages.Columns[0].Visible = false;

            dgvMessages.Columns[1].HeaderText = "Encouragement Message";
            dgvMessages.Columns[1].FillWeight = 80;

            dgvMessages.Columns[2].HeaderText = "Add Date";
            dgvMessages.Columns[2].FillWeight = 10;
            dgvMessages.Columns[2].DefaultCellStyle.Format = "dd MMM yyyy";

            dgvMessages.Columns[3].HeaderText = "Edit Date";
            dgvMessages.Columns[3].FillWeight = 10;
            dgvMessages.Columns[3].DefaultCellStyle.Format = "dd MMM yyyy";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {

            frmAddEditMessage frmAddEditMessage = new frmAddEditMessage();
            frmAddEditMessage.ShowDialog();

            FillGrid();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int messageID = (int)dgvMessages.SelectedRows[0].Cells[0].Value;
            frmAddEditMessage frmAddEditMessage =new frmAddEditMessage(messageID);
            frmAddEditMessage.ShowDialog();

            FillGrid();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int messageID = (int)dgvMessages.SelectedRows[0].Cells[0].Value;

            if (MessageBox.Show("Are you sure to delete this message?", "Warning", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                EncouragementMessage.DeleteMessage(messageID);
            }

            FillGrid();
        }
    }
}
