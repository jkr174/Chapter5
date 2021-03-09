/* Name:    Jovany Romo
 * Date:    1/14/2021
 * Summray: Connects to a database that also has error handling.
 */

using System;
using System.IO;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5_2_AuthorsTableInputForm
{
    public partial class frmTitles : Form
    {
        SqlCommand publishersCommand;
        SqlDataAdapter publishersAdapter;
        DataTable publishersTable;
        SqlConnection booksConnection;
        SqlCommand titlesCommand;
        SqlDataAdapter titlesAdapter;
        
        DataTable titlesTable;
        CurrencyManager titlesManager;
        string myState;
        int myBookmark;
        public frmTitles()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            SetState("Connect");
            
        }

        private void frmAuthors_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myState.Equals("Edit") || myState.Equals("Add"))
            {
                MessageBox.Show("You must finish the current edit before stopping the application,",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    SqlCommandBuilder publishersAdapterCommands = new SqlCommandBuilder(titlesAdapter);
                    titlesAdapter.Update(titlesTable);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving database to file: \r\n"
                        + ex.Message,
                        "Save Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                booksConnection.Close();

                booksConnection.Dispose();
                titlesCommand.Dispose();
                titlesAdapter.Dispose();
                titlesTable.Dispose();
                publishersCommand.Dispose();
                publishersAdapter.Dispose();
                publishersTable.Dispose();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == 0)
            {
                Console.Beep();
            }
            titlesManager.Position--;
            SetText();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (titlesManager.Position == titlesManager.Count - 1)
            {
                Console.Beep();
            }
            titlesManager.Position++;
            SetText();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
            {
                return;
            }
            string savedName = txtYear.Text;
            int savedRow;
            try
            {
                titlesManager.EndCurrentEdit();
                titlesTable.DefaultView.Sort = "Name";
                savedRow = titlesTable.DefaultView.Find(savedName);
                titlesManager.Position = savedRow;
                string Message = "Record saved.",
                Title = "Save";

            MessageBox.Show(Message,
                Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                SetState("View");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Message = "Are you sure you want to delete this record?",
                Title = "Delete";

            DialogResult response;
            response = MessageBox.Show(Message,
                Title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (response == DialogResult.No)
            {
                return;
            }
            try
            {
                titlesManager.RemoveAt(titlesManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "Connect":
                    txtTitle.ReadOnly = true;
                    txtYear.ReadOnly = true;
                    txtISBN.ReadOnly = true;
                    txtTitle.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    txtNotes.ReadOnly = true;
                    txtSubject.ReadOnly = true;
                    txtComments.ReadOnly = true;
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    grpFindTitle.Enabled = false;
                    cboPublisher.Enabled = false;
                    btnPublishers.Enabled = false;
                    btnDisconnect.Enabled = false;
                    btnConnect.Enabled = true;
                    btnConnect.Focus();
                    break;
                // Note to Self, make connect state
                case "Disconnect":
                    txtTitle.ReadOnly = true;
                    txtYear.ReadOnly = true;
                    txtISBN.ReadOnly = true;
                    txtTitle.ReadOnly = true;
                    txtDescription.ReadOnly = true;
                    txtNotes.ReadOnly = true;
                    txtSubject.ReadOnly = true;
                    txtComments.ReadOnly = true;
                    btnFirst.Enabled = false;
                    btnPrevious.Enabled = false;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDone.Enabled = false;
                    grpFindTitle.Enabled = false;
                    cboPublisher.Enabled = false;
                    btnPublishers.Enabled = true;
                    btnDisconnect.Enabled = true;
                    btnConnect.Enabled = false;
                    btnDisconnect.Focus();
                    break;
                case "View":
                    txtTitle.ReadOnly = true; 
                    txtYear.ReadOnly = true; 
                    txtISBN.ReadOnly = true; 
                    txtISBN.BackColor = Color.White; 
                    txtISBN.ForeColor = Color.Black; 
                    txtDescription.ReadOnly = true; 
                    txtNotes.ReadOnly = true; 
                    txtSubject.ReadOnly = true; 
                    txtComments.ReadOnly = true; 
                    btnFirst.Enabled = true; 
                    btnPrevious.Enabled = true; 
                    btnNext.Enabled = true; 
                    btnLast.Enabled = true; 
                    btnAddNew.Enabled = true; 
                    btnSave.Enabled = false; 
                    btnCancel.Enabled = false; 
                    btnEdit.Enabled = true; 
                    btnDelete.Enabled = true; 
                    btnDone.Enabled = true;
                    grpFindTitle.Enabled = true;
                    btnPublishers.Enabled = true;
                    cboPublisher.Enabled = false;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    txtTitle.Focus();
                    break;
                //Add or Edit State
                default:
                    txtTitle.ReadOnly = false; 
                    txtYear.ReadOnly = false; 
                    txtISBN.ReadOnly = false; 
                    if (myState.Equals("Edit")) 
                    { 
                        txtISBN.BackColor = Color.Red; 
                        txtISBN.ForeColor = Color.White; 
                        txtISBN.ReadOnly = true; 
                        txtISBN.TabStop = false; 
                    } 
                    else 
                    { 
                        txtISBN.TabStop = true; 
                    }
                    txtDescription.ReadOnly = false; 
                    txtNotes.ReadOnly = false; 
                    txtSubject.ReadOnly = false;
                    txtComments.ReadOnly = false; 
                    btnFirst.Enabled = false; 
                    btnPrevious.Enabled = false; 
                    btnNext.Enabled = false; 
                    btnLast.Enabled = false; 
                    btnAddNew.Enabled = false; 
                    btnSave.Enabled = true; 
                    btnCancel.Enabled = true; 
                    btnEdit.Enabled = false; 
                    btnDelete.Enabled = false; 
                    btnDone.Enabled = false;
                    grpFindTitle.Enabled = false;
                    cboPublisher.Enabled = true;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = false;
                    txtTitle.Focus();
                    break;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                myBookmark = titlesManager.Position;
                titlesManager.AddNew();
                SetState("Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            titlesManager.CancelCurrentEdit();
            if (myState.Equals("Add"))
                titlesManager.Position = myBookmark;
            SetState("View");
        }

        private void txtYearBorn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9' || (int)e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else if((int)e.KeyChar == 13)
            {
                txtYear.Focus();
            }
            else
            {
                e.Handled = true;
                Console.Beep();
            }
        }
        private bool ValidateData()
        {
            string message = "";
            bool allOK = true;
            return (allOK);
        }

        private void txtAuthorName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmAuthors_HelpButtonClicked(object sender, CancelEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpPublishers.HelpNamespace);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            titlesManager.Position = 0;
            SetText();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            titlesManager.Position = titlesManager.Count - 1;
            SetText();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtFind.Text.Equals(""))
            {
                return;
            }
            int savedRow = titlesManager.Position;
            DataRow[] foundRows;
            titlesTable.DefaultView.Sort = "Title";
            foundRows = titlesTable.Select("Title LIKE'" +
                txtFind.Text + "*'");
            if (foundRows.Length == 0)
            {
                titlesManager.Position = savedRow;
            }
            else
            {
                titlesManager.Position = titlesTable.DefaultView.Find(foundRows[0]["Title"]);
            }
            SetText();
        }
        private void SetText()
        {
            this.Text = "Titles - Record " + (titlesManager.Position
                + 1).ToString() + " of " + titlesManager.Count.ToString()
                + " Records";
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            try
            {
                frmPublishers pubForm = new frmPublishers();
                string pubSave = cboPublisher.Text;
                pubForm.ShowDialog();
                pubForm.Dispose();
                // need to regenerate publishers data
                booksConnection.Close();
                booksConnection = new
                SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; " +
                "AttachDbFilename=|DataDirectory|\\SQLBooksDB.mdf;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "User Instance=False");
                booksConnection.Open();
                publishersAdapter.SelectCommand = publishersCommand;
                publishersTable = new DataTable();
                publishersAdapter.Fill(publishersTable);
                cboPublisher.DataSource = publishersTable;
                cboPublisher.Text = pubSave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                hlpPublishers.HelpNamespace = Application.StartupPath + "\\Publishers.chm";

                booksConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|\\SQLBooksDB.mdf;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "User Instance=False");
                booksConnection.Open();


                titlesCommand = new SqlCommand(
                    "SELECT * " +
                    "FROM Titles " +
                    "ORDER BY Title", booksConnection);

                titlesAdapter = new SqlDataAdapter();
                titlesAdapter.SelectCommand = titlesCommand;
                titlesTable = new DataTable();
                titlesAdapter.Fill(titlesTable);

                txtTitle.DataBindings.Add("Text", titlesTable, "Title");
                txtYear.DataBindings.Add("Text", titlesTable, "Year_Published");
                txtISBN.DataBindings.Add("Text", titlesTable, "ISBN");
                txtDescription.DataBindings.Add("Text", titlesTable, "Description");
                txtNotes.DataBindings.Add("Text", titlesTable, "Notes");
                txtSubject.DataBindings.Add("Text", titlesTable, "Subject");
                txtComments.DataBindings.Add("Text", titlesTable, "Comments");

                titlesManager = (CurrencyManager)
                    this.BindingContext[titlesTable];

                publishersCommand = new SqlCommand("SELECT *" +
                    "FROM Publishers " +
                    "ORDER BY Name",
                    booksConnection);
                publishersAdapter = new SqlDataAdapter();
                publishersAdapter.SelectCommand = publishersCommand;
                publishersTable = new DataTable();
                publishersAdapter.Fill(publishersTable);
                cboPublisher.DataSource = publishersTable;
                cboPublisher.DisplayMember = "Name";
                cboPublisher.ValueMember = "PubID";
                cboPublisher.DataBindings.Add("SelectedValue", titlesTable, "PubID");
                SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
                var database = connectionString.InitialCatalog;
                MessageBox.Show(database, "Database Name", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error establishing Publishers table.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            this.Show();
            SetState("View");
            SetText();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            SetState("Disconnect");
            booksConnection.Close();

            booksConnection.Dispose();
            titlesCommand.Dispose();
            titlesAdapter.Dispose();
            titlesTable.Dispose();
            publishersCommand.Dispose();
            publishersAdapter.Dispose();
            publishersTable.Dispose();
        }
    }
}
