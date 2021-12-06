namespace FordProgBeadando
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       

      
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tBInput = new System.Windows.Forms.TextBox();
            this.rTB = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTablazatBetolt = new System.Windows.Forms.Button();
            this.BTNTablaTorol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofp = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 11);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(732, 335);
            this.dataGridView.TabIndex = 0;
            // 
            // tBInput
            // 
            this.tBInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tBInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBInput.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBInput.ForeColor = System.Drawing.Color.Black;
            this.tBInput.Location = new System.Drawing.Point(774, 44);
            this.tBInput.Margin = new System.Windows.Forms.Padding(2);
            this.tBInput.Name = "tBInput";
            this.tBInput.Size = new System.Drawing.Size(214, 29);
            this.tBInput.TabIndex = 1;
            this.tBInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rTB
            // 
            this.rTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTB.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTB.ForeColor = System.Drawing.Color.Black;
            this.rTB.Location = new System.Drawing.Point(16, 384);
            this.rTB.Margin = new System.Windows.Forms.Padding(2);
            this.rTB.Name = "rTB";
            this.rTB.Size = new System.Drawing.Size(972, 187);
            this.rTB.TabIndex = 2;
            this.rTB.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(774, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Számolás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnTablazatBetolt
            // 
            this.btnTablazatBetolt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTablazatBetolt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablazatBetolt.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablazatBetolt.ForeColor = System.Drawing.Color.White;
            this.btnTablazatBetolt.Location = new System.Drawing.Point(774, 200);
            this.btnTablazatBetolt.Margin = new System.Windows.Forms.Padding(2);
            this.btnTablazatBetolt.Name = "btnTablazatBetolt";
            this.btnTablazatBetolt.Size = new System.Drawing.Size(214, 40);
            this.btnTablazatBetolt.TabIndex = 4;
            this.btnTablazatBetolt.Text = "Tábla betöltése";
            this.btnTablazatBetolt.UseVisualStyleBackColor = false;
            this.btnTablazatBetolt.Click += new System.EventHandler(this.BtnTablazatBetolt_Click);
            // 
            // BTNTablaTorol
            // 
            this.BTNTablaTorol.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNTablaTorol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNTablaTorol.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTablaTorol.ForeColor = System.Drawing.Color.White;
            this.BTNTablaTorol.Location = new System.Drawing.Point(774, 306);
            this.BTNTablaTorol.Margin = new System.Windows.Forms.Padding(2);
            this.BTNTablaTorol.Name = "BTNTablaTorol";
            this.BTNTablaTorol.Size = new System.Drawing.Size(214, 40);
            this.BTNTablaTorol.TabIndex = 5;
            this.BTNTablaTorol.Text = "Betöltött tábla törlése";
            this.BTNTablaTorol.UseVisualStyleBackColor = false;
            this.BTNTablaTorol.Click += new System.EventHandler(this.BTNTablaTorol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kimenet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(769, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input";
            // 
            // ofp
            // 
            this.ofp.FileName = "openFileDialog1";
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOutput.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOutput.ForeColor = System.Drawing.Color.White;
            this.btnSaveOutput.Location = new System.Drawing.Point(774, 148);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(214, 40);
            this.btnSaveOutput.TabIndex = 9;
            this.btnSaveOutput.Text = "Kimenet Mentése";
            this.btnSaveOutput.UseVisualStyleBackColor = false;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // btnSaveTable
            // 
            this.btnSaveTable.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTable.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTable.ForeColor = System.Drawing.Color.White;
            this.btnSaveTable.Location = new System.Drawing.Point(774, 254);
            this.btnSaveTable.Name = "btnSaveTable";
            this.btnSaveTable.Size = new System.Drawing.Size(214, 40);
            this.btnSaveTable.TabIndex = 10;
            this.btnSaveTable.Text = "Tábla mentése";
            this.btnSaveTable.UseVisualStyleBackColor = false;
            this.btnSaveTable.Click += new System.EventHandler(this.btnSaveTable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1014, 582);
            this.Controls.Add(this.btnSaveTable);
            this.Controls.Add(this.btnSaveOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNTablaTorol);
            this.Controls.Add(this.btnTablazatBetolt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rTB);
            this.Controls.Add(this.tBInput);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tBInput;
        private System.Windows.Forms.RichTextBox rTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTablazatBetolt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofp;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button btnSaveTable;
        private System.Windows.Forms.Button BTNTablaTorol;
    }
}

