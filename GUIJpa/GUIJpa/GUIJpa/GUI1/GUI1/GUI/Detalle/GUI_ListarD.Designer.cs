
namespace GUI1.GUI.Detalle
{
    partial class GUI_ListarD
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxIDPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridListar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxIDPro
            // 
            this.textBoxIDPro.Location = new System.Drawing.Point(263, 317);
            this.textBoxIDPro.Name = "textBoxIDPro";
            this.textBoxIDPro.Size = new System.Drawing.Size(159, 20);
            this.textBoxIDPro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridListar
            // 
            this.dataGridListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListar.Location = new System.Drawing.Point(12, 12);
            this.dataGridListar.Name = "dataGridListar";
            this.dataGridListar.Size = new System.Drawing.Size(690, 286);
            this.dataGridListar.TabIndex = 5;
            // 
            // GUI_ListarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 360);
            this.Controls.Add(this.dataGridListar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDPro);
            this.Controls.Add(this.button1);
            this.Name = "GUI_ListarD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Detalle ";
            this.Load += new System.EventHandler(this.GUI_ListarD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxIDPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridListar;
    }
}