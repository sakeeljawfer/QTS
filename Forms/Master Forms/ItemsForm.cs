using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QTS_SimpleBilling.ItmRepo;
using QTS_SimpleBilling.Model;

namespace QTS_SimpleBilling.Forms.Master_Forms
{
    public partial class ItemsForm : Form
    {

        public ItemsForm()
        {
            InitializeComponent();
        }

        readonly Items itm = new Items();
        private DataGridView DGVItems;
        private TableLayoutPanel TLPCusCRUD;
        private TextBox TxtUnit;
        private TextBox TxtCatagory;
        private TextBox TxtItmNam;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox TxtItmCode;
        private TableLayoutPanel tableLayoutPanel5;
        private Button BtnCreate;
        private Button BtnReset;
        private Button BtnDelete;
        private Button BtnSave;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private TableLayoutPanel TBLFilter;
        private TextBox TxtSearchItems;
        private TextBox TxtBarCod;
        private Label label7;
        private TextBox TxtShelf;
        private Label label6;
        readonly ItemsRepo itmRepo = new ItemsRepo();

        private void InitializeComponent()
        {
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.TLPCusCRUD = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBarCod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtShelf = new System.Windows.Forms.TextBox();
            this.TxtUnit = new System.Windows.Forms.TextBox();
            this.TxtCatagory = new System.Windows.Forms.TextBox();
            this.TxtItmNam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtItmCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TBLFilter = new System.Windows.Forms.TableLayoutPanel();
            this.TxtSearchItems = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            this.TLPCusCRUD.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.TBLFilter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVItems
            // 
            this.DGVItems.AllowUserToAddRows = false;
            this.DGVItems.AllowUserToDeleteRows = false;
            this.DGVItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVItems.BackgroundColor = System.Drawing.Color.White;
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVItems.Location = new System.Drawing.Point(62, 237);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.ReadOnly = true;
            this.DGVItems.RowTemplate.Height = 25;
            this.DGVItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVItems.Size = new System.Drawing.Size(862, 164);
            this.DGVItems.TabIndex = 0;
            this.DGVItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellContentClick);
            // 
            // TLPCusCRUD
            // 
            this.TLPCusCRUD.ColumnCount = 2;
            this.TLPCusCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.69502F));
            this.TLPCusCRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.30498F));
            this.TLPCusCRUD.Controls.Add(this.TxtBarCod, 1, 5);
            this.TLPCusCRUD.Controls.Add(this.label7, 0, 5);
            this.TLPCusCRUD.Controls.Add(this.TxtShelf, 1, 4);
            this.TLPCusCRUD.Controls.Add(this.TxtUnit, 1, 3);
            this.TLPCusCRUD.Controls.Add(this.TxtCatagory, 1, 2);
            this.TLPCusCRUD.Controls.Add(this.TxtItmNam, 1, 1);
            this.TLPCusCRUD.Controls.Add(this.label5, 0, 2);
            this.TLPCusCRUD.Controls.Add(this.label2, 0, 1);
            this.TLPCusCRUD.Controls.Add(this.label1, 0, 0);
            this.TLPCusCRUD.Controls.Add(this.label4, 0, 3);
            this.TLPCusCRUD.Controls.Add(this.TxtItmCode, 1, 0);
            this.TLPCusCRUD.Controls.Add(this.label6, 0, 4);
            this.TLPCusCRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPCusCRUD.Location = new System.Drawing.Point(3, 3);
            this.TLPCusCRUD.Name = "TLPCusCRUD";
            this.TLPCusCRUD.RowCount = 7;
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TLPCusCRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPCusCRUD.Size = new System.Drawing.Size(627, 188);
            this.TLPCusCRUD.TabIndex = 1;
            // 
            // TxtBarCod
            // 
            this.TxtBarCod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBarCod.Location = new System.Drawing.Point(189, 143);
            this.TxtBarCod.Name = "TxtBarCod";
            this.TxtBarCod.Size = new System.Drawing.Size(435, 23);
            this.TxtBarCod.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Barcode";
            // 
            // TxtShelf
            // 
            this.TxtShelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtShelf.Location = new System.Drawing.Point(189, 115);
            this.TxtShelf.Name = "TxtShelf";
            this.TxtShelf.Size = new System.Drawing.Size(435, 23);
            this.TxtShelf.TabIndex = 13;
            // 
            // TxtUnit
            // 
            this.TxtUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUnit.Location = new System.Drawing.Point(189, 87);
            this.TxtUnit.Name = "TxtUnit";
            this.TxtUnit.Size = new System.Drawing.Size(435, 23);
            this.TxtUnit.TabIndex = 11;
            // 
            // TxtCatagory
            // 
            this.TxtCatagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCatagory.Location = new System.Drawing.Point(189, 59);
            this.TxtCatagory.Name = "TxtCatagory";
            this.TxtCatagory.Size = new System.Drawing.Size(435, 23);
            this.TxtCatagory.TabIndex = 10;
            // 
            // TxtItmNam
            // 
            this.TxtItmNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItmNam.Location = new System.Drawing.Point(189, 31);
            this.TxtItmNam.Name = "TxtItmNam";
            this.TxtItmNam.Size = new System.Drawing.Size(435, 23);
            this.TxtItmNam.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Catagory";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
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
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Code";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit";
            // 
            // TxtItmCode
            // 
            this.TxtItmCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtItmCode.Location = new System.Drawing.Point(189, 3);
            this.TxtItmCode.Name = "TxtItmCode";
            this.TxtItmCode.Size = new System.Drawing.Size(435, 23);
            this.TxtItmCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Shelf";
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
            this.tableLayoutPanel5.Location = new System.Drawing.Point(636, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(223, 188);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCreate.Location = new System.Drawing.Point(3, 3);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(217, 41);
            this.BtnCreate.TabIndex = 14;
            this.BtnCreate.Text = "Add";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnReset.Location = new System.Drawing.Point(3, 50);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(217, 41);
            this.BtnReset.TabIndex = 15;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(3, 97);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(217, 41);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Location = new System.Drawing.Point(3, 144);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(217, 41);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.54988F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.45012F));
            this.tableLayoutPanel4.Controls.Add(this.TLPCusCRUD, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(62, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(862, 194);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(198, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search";
            // 
            // TBLFilter
            // 
            this.TBLFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBLFilter.ColumnCount = 2;
            this.TBLFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TBLFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TBLFilter.Controls.Add(this.label3, 0, 0);
            this.TBLFilter.Controls.Add(this.TxtSearchItems, 1, 0);
            this.TBLFilter.Location = new System.Drawing.Point(62, 203);
            this.TBLFilter.Name = "TBLFilter";
            this.TBLFilter.RowCount = 1;
            this.TBLFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBLFilter.Size = new System.Drawing.Size(862, 28);
            this.TBLFilter.TabIndex = 3;
            // 
            // TxtSearchItems
            // 
            this.TxtSearchItems.BackColor = System.Drawing.Color.White;
            this.TxtSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSearchItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchItems.Location = new System.Drawing.Point(261, 3);
            this.TxtSearchItems.Name = "TxtSearchItems";
            this.TxtSearchItems.Size = new System.Drawing.Size(598, 25);
            this.TxtSearchItems.TabIndex = 1;
            this.TxtSearchItems.TextChanged += new System.EventHandler(this.TxtSearchItems_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Controls.Add(this.DGVItems, 1, 2);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(987, 424);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // ItemsForm
            // 
            this.ClientSize = new System.Drawing.Size(987, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemsForm";
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            this.TLPCusCRUD.ResumeLayout(false);
            this.TLPCusCRUD.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.TBLFilter.ResumeLayout(false);
            this.TBLFilter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private TableLayoutPanel tableLayoutPanel1;

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            TLPCusCRUD.Enabled = true;
        }

        private Items GetCus()
        {
         
            itm.ItemsName = TxtItmNam.Text.Trim();
            itm.ItemsCatagory = TxtCatagory.Text.Trim();
            itm.ItemsUnit = TxtUnit.Text.Trim();
            itm.ItemsBarcode = TxtBarCod.Text.Trim();
            itm.Shelf = TxtShelf.Text.Trim();

            return itm;
        }

        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TLPCusCRUD.Enabled = true;
            itm.ItemsId = Convert.ToInt32(DGVItems.SelectedRows[0].Cells[0].Value.ToString());
            itm.ItemsName = DGVItems.SelectedRows[0].Cells[1].Value.ToString();
            itm.ItemsCatagory = DGVItems.SelectedRows[0].Cells[2].Value.ToString();
            itm.ItemsUnit = DGVItems.SelectedRows[0].Cells[3].Value.ToString();
            itm.ItemsBarcode = DGVItems.SelectedRows[0].Cells[4].Value.ToString();
            itm.Shelf = DGVItems.SelectedRows[0].Cells[4].Value.ToString();


            
            TxtItmNam.Text = itm.ItemsName;
            TxtCatagory.Text = itm.ItemsCatagory;
            TxtUnit.Text = itm.ItemsUnit;
            TxtBarCod.Text = itm.ItemsBarcode;
            TxtShelf.Text = itm.Shelf;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                itmRepo.Create(GetCus());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCusCRUD.Enabled = false;
                DGVItems.DataSource = itmRepo.View();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                itmRepo.Delete(GetCus());
            }
            catch (Exception ex)
            {
                BAL.Exc.ErMessage(ex);
            }
            finally
            {
                TLPCusCRUD.Enabled = false;
                DGVItems.DataSource = itmRepo.View();
            }
        }

        private void TxtSearchItems_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = TxtSearchItems.Text.Trim();
                if (!string.IsNullOrEmpty(query))
                {
                    DGVItems.DataSource = itmRepo.Search(query);
                }
                else
                {
                    DGVItems.DataSource = itmRepo.View();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            TLPCusCRUD.Enabled = false;
            DGVItems.DataSource = itmRepo.View();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtItmCode.Text = string.Empty;
            TxtItmNam.Text = string.Empty;
            TxtCatagory.Text = string.Empty;
            TxtBarCod.Text = string.Empty;
            TxtUnit.Text = string.Empty;
            TxtShelf.Text = string.Empty;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
