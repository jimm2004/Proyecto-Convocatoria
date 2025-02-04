namespace Proyecto_de_la_comvocatoria
{
    partial class frmCola
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this._producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rdaExterno = new System.Windows.Forms.RadioButton();
            this.rdaInterno = new System.Windows.Forms.RadioButton();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._producto,
            this._categoria,
            this._precio});
            this.dgvInventario.Location = new System.Drawing.Point(23, 189);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(571, 169);
            this.dgvInventario.TabIndex = 18;
            // 
            // _producto
            // 
            this._producto.HeaderText = "Producto";
            this._producto.Name = "_producto";
            // 
            // _categoria
            // 
            this._categoria.HeaderText = "Categoria";
            this._categoria.Name = "_categoria";
            // 
            // _precio
            // 
            this._precio.HeaderText = "Precio";
            this._precio.Name = "_precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(179, 136);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(111, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // rdaExterno
            // 
            this.rdaExterno.AutoSize = true;
            this.rdaExterno.Location = new System.Drawing.Point(125, 84);
            this.rdaExterno.Name = "rdaExterno";
            this.rdaExterno.Size = new System.Drawing.Size(61, 17);
            this.rdaExterno.TabIndex = 15;
            this.rdaExterno.Text = "Externo";
            this.rdaExterno.UseVisualStyleBackColor = true;
            this.rdaExterno.CheckedChanged += new System.EventHandler(this.rdaExterno_CheckedChanged);
            // 
            // rdaInterno
            // 
            this.rdaInterno.AutoSize = true;
            this.rdaInterno.Checked = true;
            this.rdaInterno.Location = new System.Drawing.Point(23, 84);
            this.rdaInterno.Name = "rdaInterno";
            this.rdaInterno.Size = new System.Drawing.Size(58, 17);
            this.rdaInterno.TabIndex = 16;
            this.rdaInterno.TabStop = true;
            this.rdaInterno.Text = "Interno";
            this.rdaInterno.UseVisualStyleBackColor = true;
            this.rdaInterno.CheckedChanged += new System.EventHandler(this.rdaInterno_CheckedChanged);
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(23, 135);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(123, 21);
            this.cmbProductos.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Producto:";
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(506, 108);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(75, 23);
            this.btnPeek.TabIndex = 8;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(425, 108);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(75, 23);
            this.btnPop.TabIndex = 9;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(344, 108);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(75, 23);
            this.btnPush.TabIndex = 10;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Motorepuesto Quintero";
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 368);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.rdaExterno);
            this.Controls.Add(this.rdaInterno);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.label1);
            this.Name = "frmCola";
            this.Text = "frmCola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn _producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn _categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn _precio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rdaExterno;
        private System.Windows.Forms.RadioButton rdaInterno;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Label label1;
    }
}