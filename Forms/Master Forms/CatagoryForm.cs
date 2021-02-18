using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QTS_SimpleBilling.CatRepo;
using QTS_SimpleBilling.Model;
;

namespace QTS_SimpleBilling.Forms.Master_Forms
{
    public partial class CatagoryForm : Form
    {


        readonly Catagory cat = new Catagory();
        readonly CatagoryRepo catRepo = new CatagoryRepo();


        private TableLayoutPanel tableLayoutPanel1;

        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel TLPCusCRUD;

        private Label label2;
        private Label label1;

        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnCreate;
        private Button BtnReset;
        private Button BtnDelete;
        private Button BtnSave;
        private TableLayoutPanel TBLFilter;
        private Label label3;
        private DataGridView DGVCatg;
        private TextBox TxtCatNam;
        private TextBox TxtCatCode;
        private TextBox TxtSearchCatg;



        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVCatg = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.TLPCusCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.TxtCatNam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCatCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TBLFilter = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSearchCatg = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatg)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.TLPCusCRUD.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.TBLFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Controls.Add(this.DGVCatg, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBLFilter, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.16981F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.018867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.11461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.297994F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 450);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // DGVCatg
            // 
            this.DGVCatg.AllowUserToAddRows = false;
            this.DGVCatg.AllowUserToDeleteRows = false;
            this.DGVCatg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCatg.BackgroundColor = System.Drawing.Color.White;
            this.DGVCatg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCatg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCatg.Location = new System.Drawing.Point(63, 252);
            this.DGVCatg.Name = "DGVCatg";
            this.DGVCatg.ReadOnly = true;
            this.DGVCatg.RowTemplate.Height = 25;
            this.DGVCatg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCatg.Size = new System.Drawing.Size(874, 175);
            this.DGVCatg.TabIndex = 0;
            this.DGVCatg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCatg_CellContentClick);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.54988F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.45012F));
            this.tableLayoutPanel4.Controls.Add(this.TLPCusCRUD, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(63, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(874, 207);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // TLPCusCRUD
            // 
            this.TLPCusCRUD.ColumnCount = 2;
            this.TLPCusCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.08805F));
            this.TLPCusCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.91195F));
            this.TLPCusCRUD.Controls.Add(this.TxtCatNam, 1, 1);
            this.TLPCusCRUD.Controls.Add(this.label2, 0, 1);
            this.TLPCusCRUD.Controls.Add(this.label1, 0, 0);
            this.TLPCusCRUD.Controls.Add(this.TxtCatCode, 1, 0);
            this.TLPCusCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPCusCRUD.Location = new System.Drawing.Point(3, 3);
            this.TLPCusCRUD.Name = "TLPCusCRUD";
            this.TLPCusCRUD.RowCount = 7;
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.39303F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.457711F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPCusCRUD.Size = new System.Drawing.Size(636, 201);
            this.TLPCusCRUD.TabIndex = 1;
            // 
            // TxtCatNam
            // 
            this.TxtCatNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCatNam.Location = new System.Drawing.Point(188, 33);
            this.TxtCatNam.Name = "TxtCatNam";
            this.TxtCatNam.Size = new System.Drawing.Size(445, 23);
            this.TxtCatNam.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Catagory Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catagory Code";
            // 
            // TxtCatCode
            // 
            this.TxtCatCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCatCode.Location = new System.Drawing.Point(188, 3);
            this.TxtCatCode.Name = "TxtCatCode";
            this.TxtCatCode.Size = new System.Drawing.Size(445, 23);
            this.TxtCatCode.TabIndex = 8;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.BtnCreate, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnReset, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.BtnDelete, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.BtnSave, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(645, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(226, 201);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCreate.Location = new System.Drawing.Point(3, 3);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(220, 44);
            this.BtnCreate.TabIndex = 14;
            this.BtnCreate.Text = "Add";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.Location = new System.Drawing.Point(3, 53);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(220, 44);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(3, 103);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(220, 44);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(3, 153);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(220, 45);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TBLFilter
            // 
            this.TBLFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBLFilter.ColumnCount = 2;
            this.TBLFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TBLFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TBLFilter.Controls.Add(this.label3, 0, 0);
            this.TBLFilter.Controls.Add(this.TxtSearchCatg, 1, 0);
            this.TBLFilter.Location = new System.Drawing.Point(63, 218);
            this.TBLFilter.Name = "TBLFilter";
            this.TBLFilter.RowCount = 1;
            this.TBLFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBLFilter.Size = new System.Drawing.Size(874, 28);
            this.TBLFilter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(202, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search";
            // 
            // TxtSearchCatg
            // 
            this.TxtSearchCatg.BackColor = System.Drawing.Color.White;
            this.TxtSearchCatg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSearchCatg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchCatg.Location = new System.Drawing.Point(265, 3);
            this.TxtSearchCatg.Name = "TxtSearchCatg";
            this.TxtSearchCatg.Size = new System.Drawing.Size(606, 25);
            this.TxtSearchCatg.TabIndex = 1;
            this.TxtSearchCatg.TextChanged += new System.EventHandler(this.TxtSearchCatg_TextChanged);
            // 
            // CatagoryForm
            // 
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CatagoryForm";
            this.Text = "Catagary Form";
            this.Load += new System.EventHandler(this.CatagoryForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatg)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.TLPCusCRUD.ResumeLayout(false);
            this.TLPCusCRUD.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.TBLFilter.ResumeLayout(false);
            this.TBLFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        private Catagory GetCat()
        {

            cat.CatagoryName = TxtCatNam.Text.Trim();


            return cat;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TLPCusCRUD.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                catRepo.Create(GetCat());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCusCRUD.Enabled = false;
                DGVCatg.DataSource = catRepo.View();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                catRepo.Delete(GetCat());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCusCRUD.Enabled = false;
                DGVCatg.DataSource = catRepo.View();
            }
        }

        private void TxtSearchCatg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = TxtSearchCatg.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    DGVCatg.DataSource = catRepo.Search(query);
                }
                else
                {
                    DGVCatg.DataSource = catRepo.View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CatagoryForm_Load(object sender, EventArgs e)
        {

            TLPCusCRUD.Enabled = false;
            DGVCatg.DataSource = catRepo.View();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtCatCode.Text = string.Empty;
            TxtCatNam.Text = string.Empty;
        }

        private void DGVCatg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TLPCusCRUD.Enabled = true;
            cat.CatagoryId = Convert.ToInt32(DGVCatg.SelectedRows[0].Cells[0].Value.ToString());
            cat.CatagoryName = DGVCatg.SelectedRows[0].Cells[1].Value.ToString();

            TxtCatNam.Text = cat.CatagoryName;
        }
    }
}
