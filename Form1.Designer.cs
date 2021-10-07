
namespace Agenda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_name = new System.Windows.Forms.Label();
            this.Txb_name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txb_telefono = new System.Windows.Forms.TextBox();
            this.Txb_correo = new System.Windows.Forms.TextBox();
            this.B_Agregar = new System.Windows.Forms.Button();
            this.B_nuevo = new System.Windows.Forms.Button();
            this.B_eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txb_ID = new System.Windows.Forms.TextBox();
            this.B_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(280, 17);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(65, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Nombre";
            // 
            // Txb_name
            // 
            this.Txb_name.Location = new System.Drawing.Point(351, 19);
            this.Txb_name.Name = "Txb_name";
            this.Txb_name.Size = new System.Drawing.Size(160, 20);
            this.Txb_name.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(575, 206);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo";
            // 
            // Txb_telefono
            // 
            this.Txb_telefono.Location = new System.Drawing.Point(92, 56);
            this.Txb_telefono.Name = "Txb_telefono";
            this.Txb_telefono.Size = new System.Drawing.Size(160, 20);
            this.Txb_telefono.TabIndex = 5;
            // 
            // Txb_correo
            // 
            this.Txb_correo.Location = new System.Drawing.Point(351, 58);
            this.Txb_correo.Name = "Txb_correo";
            this.Txb_correo.Size = new System.Drawing.Size(160, 20);
            this.Txb_correo.TabIndex = 6;
            // 
            // B_Agregar
            // 
            this.B_Agregar.Location = new System.Drawing.Point(12, 415);
            this.B_Agregar.Name = "B_Agregar";
            this.B_Agregar.Size = new System.Drawing.Size(75, 23);
            this.B_Agregar.TabIndex = 7;
            this.B_Agregar.Text = "Agregar";
            this.B_Agregar.UseVisualStyleBackColor = true;
            this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
            // 
            // B_nuevo
            // 
            this.B_nuevo.Location = new System.Drawing.Point(197, 415);
            this.B_nuevo.Name = "B_nuevo";
            this.B_nuevo.Size = new System.Drawing.Size(75, 23);
            this.B_nuevo.TabIndex = 8;
            this.B_nuevo.Text = "Nuevo";
            this.B_nuevo.UseVisualStyleBackColor = true;
            this.B_nuevo.Click += new System.EventHandler(this.B_nuevo_Click);
            // 
            // B_eliminar
            // 
            this.B_eliminar.Location = new System.Drawing.Point(512, 415);
            this.B_eliminar.Name = "B_eliminar";
            this.B_eliminar.Size = new System.Drawing.Size(75, 23);
            this.B_eliminar.TabIndex = 9;
            this.B_eliminar.Text = "Eliminar";
            this.B_eliminar.UseVisualStyleBackColor = true;
            this.B_eliminar.Click += new System.EventHandler(this.B_eliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Agenda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txb_ID);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.Txb_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txb_telefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txb_correo);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // Txb_ID
            // 
            this.Txb_ID.Location = new System.Drawing.Point(92, 17);
            this.Txb_ID.Name = "Txb_ID";
            this.Txb_ID.ReadOnly = true;
            this.Txb_ID.Size = new System.Drawing.Size(75, 20);
            this.Txb_ID.TabIndex = 7;
            // 
            // B_Modificar
            // 
            this.B_Modificar.Location = new System.Drawing.Point(104, 415);
            this.B_Modificar.Name = "B_Modificar";
            this.B_Modificar.Size = new System.Drawing.Size(75, 23);
            this.B_Modificar.TabIndex = 10;
            this.B_Modificar.Text = "Modificar";
            this.B_Modificar.UseVisualStyleBackColor = true;
            this.B_Modificar.Click += new System.EventHandler(this.B_Modificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.B_Modificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.B_eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_nuevo);
            this.Controls.Add(this.B_Agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox Txb_name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txb_telefono;
        private System.Windows.Forms.TextBox Txb_correo;
        private System.Windows.Forms.Button B_Agregar;
        private System.Windows.Forms.Button B_nuevo;
        private System.Windows.Forms.Button B_eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_Modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txb_ID;
    }
}

