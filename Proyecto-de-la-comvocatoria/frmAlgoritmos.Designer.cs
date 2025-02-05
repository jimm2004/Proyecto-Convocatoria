namespace Proyecto_de_la_comvocatoria
{
    partial class frmAlgoritmos
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
            this.label1 = new System.Windows.Forms.Label();
            this.listaDelinventario = new System.Windows.Forms.ListBox();
            this.btnbubleSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnHeapSort = new System.Windows.Forms.Button();
            this.btnShellSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnDesordenar = new System.Windows.Forms.Button();
            this.btnShackerSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Motorepuesto Quintero Inventario";
            // 
            // listaDelinventario
            // 
            this.listaDelinventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaDelinventario.FormattingEnabled = true;
            this.listaDelinventario.ItemHeight = 15;
            this.listaDelinventario.Location = new System.Drawing.Point(12, 60);
            this.listaDelinventario.Name = "listaDelinventario";
            this.listaDelinventario.Size = new System.Drawing.Size(688, 274);
            this.listaDelinventario.TabIndex = 47;
            // 
            // btnbubleSort
            // 
            this.btnbubleSort.Location = new System.Drawing.Point(63, 344);
            this.btnbubleSort.Name = "btnbubleSort";
            this.btnbubleSort.Size = new System.Drawing.Size(92, 32);
            this.btnbubleSort.TabIndex = 48;
            this.btnbubleSort.Text = "BubleSort";
            this.btnbubleSort.UseVisualStyleBackColor = true;
            this.btnbubleSort.Click += new System.EventHandler(this.btnbubleSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(159, 344);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(92, 32);
            this.btnQuickSort.TabIndex = 48;
            this.btnQuickSort.Text = "QuickSort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnHeapSort
            // 
            this.btnHeapSort.Location = new System.Drawing.Point(255, 344);
            this.btnHeapSort.Name = "btnHeapSort";
            this.btnHeapSort.Size = new System.Drawing.Size(92, 32);
            this.btnHeapSort.TabIndex = 48;
            this.btnHeapSort.Text = "HeapSort";
            this.btnHeapSort.UseVisualStyleBackColor = true;
            this.btnHeapSort.Click += new System.EventHandler(this.btnHeapSort_Click);
            // 
            // btnShellSort
            // 
            this.btnShellSort.Location = new System.Drawing.Point(351, 344);
            this.btnShellSort.Name = "btnShellSort";
            this.btnShellSort.Size = new System.Drawing.Size(92, 32);
            this.btnShellSort.TabIndex = 48;
            this.btnShellSort.Text = "ShellSort";
            this.btnShellSort.UseVisualStyleBackColor = true;
            this.btnShellSort.Click += new System.EventHandler(this.btnShellSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(543, 344);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(92, 32);
            this.btnSelectionSort.TabIndex = 48;
            this.btnSelectionSort.Text = "SelectionSort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnDesordenar
            // 
            this.btnDesordenar.Location = new System.Drawing.Point(312, 382);
            this.btnDesordenar.Name = "btnDesordenar";
            this.btnDesordenar.Size = new System.Drawing.Size(75, 32);
            this.btnDesordenar.TabIndex = 48;
            this.btnDesordenar.Text = "Desordenar";
            this.btnDesordenar.UseVisualStyleBackColor = true;
            this.btnDesordenar.Click += new System.EventHandler(this.btnDesordenar_Click);
            // 
            // btnShackerSort
            // 
            this.btnShackerSort.Location = new System.Drawing.Point(447, 344);
            this.btnShackerSort.Name = "btnShackerSort";
            this.btnShackerSort.Size = new System.Drawing.Size(92, 32);
            this.btnShackerSort.TabIndex = 48;
            this.btnShackerSort.Text = "ShackerSort";
            this.btnShackerSort.UseVisualStyleBackColor = true;
            this.btnShackerSort.Click += new System.EventHandler(this.btnShackerSort_Click);
            // 
            // frmAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 426);
            this.Controls.Add(this.btnShellSort);
            this.Controls.Add(this.btnShackerSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnDesordenar);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnHeapSort);
            this.Controls.Add(this.btnbubleSort);
            this.Controls.Add(this.listaDelinventario);
            this.Controls.Add(this.label1);
            this.Name = "frmAlgoritmos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlgoritmos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaDelinventario;
        private System.Windows.Forms.Button btnbubleSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnHeapSort;
        private System.Windows.Forms.Button btnShellSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnDesordenar;
        private System.Windows.Forms.Button btnShackerSort;
    }
}