
namespace Examen
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
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TbElimID = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVPersona = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TBEdad = new System.Windows.Forms.TextBox();
            this.BTNMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(189, 162);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(170, 22);
            this.DTPFecha.TabIndex = 34;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(439, 225);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(119, 30);
            this.BtnLimpiar.TabIndex = 33;
            this.BtnLimpiar.Text = "Limpiar Campos";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "ID";
            // 
            // TbElimID
            // 
            this.TbElimID.Location = new System.Drawing.Point(563, 137);
            this.TbElimID.Name = "TbElimID";
            this.TbElimID.Size = new System.Drawing.Size(170, 22);
            this.TbElimID.TabIndex = 31;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(439, 129);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(78, 30);
            this.BtnEliminar.TabIndex = 30;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(439, 79);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(78, 30);
            this.BtnActualizar.TabIndex = 29;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(439, 29);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(78, 30);
            this.BtnAgregar.TabIndex = 28;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(189, 203);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(170, 22);
            this.TBCorreo.TabIndex = 27;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(189, 79);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(170, 22);
            this.TBNombre.TabIndex = 26;
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(189, 29);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(170, 22);
            this.TBId.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // DGVPersona
            // 
            this.DGVPersona.AllowUserToAddRows = false;
            this.DGVPersona.AllowUserToDeleteRows = false;
            this.DGVPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersona.Location = new System.Drawing.Point(22, 270);
            this.DGVPersona.Name = "DGVPersona";
            this.DGVPersona.ReadOnly = true;
            this.DGVPersona.RowHeadersWidth = 51;
            this.DGVPersona.RowTemplate.Height = 24;
            this.DGVPersona.Size = new System.Drawing.Size(731, 347);
            this.DGVPersona.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Edad";
            // 
            // TBEdad
            // 
            this.TBEdad.Location = new System.Drawing.Point(189, 120);
            this.TBEdad.Name = "TBEdad";
            this.TBEdad.Size = new System.Drawing.Size(170, 22);
            this.TBEdad.TabIndex = 36;
            // 
            // BTNMostrar
            // 
            this.BTNMostrar.Location = new System.Drawing.Point(439, 180);
            this.BTNMostrar.Name = "BTNMostrar";
            this.BTNMostrar.Size = new System.Drawing.Size(78, 30);
            this.BTNMostrar.TabIndex = 37;
            this.BTNMostrar.Text = "Mostrar";
            this.BTNMostrar.UseVisualStyleBackColor = true;
            this.BTNMostrar.Click += new System.EventHandler(this.BTNMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(770, 637);
            this.Controls.Add(this.BTNMostrar);
            this.Controls.Add(this.TBEdad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbElimID);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TBCorreo);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbElimID;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBEdad;
        private System.Windows.Forms.Button BTNMostrar;
    }
}

