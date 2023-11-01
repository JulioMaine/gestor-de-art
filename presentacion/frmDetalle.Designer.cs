
namespace presentacion
{
    partial class frmDetalle
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.gbDetalleArticulo = new System.Windows.Forms.GroupBox();
            this.txtbPrecio = new System.Windows.Forms.TextBox();
            this.txtbCategoria = new System.Windows.Forms.TextBox();
            this.txtbMarca = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.rtbDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtbImagenUrl = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.gbDetalleArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(31, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(47, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseCompatibleTextRendering = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(27, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(8, 88);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(75, 15);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 6;
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagenUrl.ForeColor = System.Drawing.Color.White;
            this.lblImagenUrl.Location = new System.Drawing.Point(16, 190);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(68, 15);
            this.lblImagenUrl.TabIndex = 8;
            this.lblImagenUrl.Text = "ImagenUrl:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(34, 216);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 15);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(19, 242);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(63, 15);
            this.lblCategoria.TabIndex = 12;
            this.lblCategoria.Text = "Categoría:";
            // 
            // gbDetalleArticulo
            // 
            this.gbDetalleArticulo.Controls.Add(this.txtbPrecio);
            this.gbDetalleArticulo.Controls.Add(this.txtbCategoria);
            this.gbDetalleArticulo.Controls.Add(this.txtbMarca);
            this.gbDetalleArticulo.Controls.Add(this.lblPrecio);
            this.gbDetalleArticulo.Controls.Add(this.rtbDescripcion);
            this.gbDetalleArticulo.Controls.Add(this.txtbImagenUrl);
            this.gbDetalleArticulo.Controls.Add(this.txtbNombre);
            this.gbDetalleArticulo.Controls.Add(this.txtbCodigo);
            this.gbDetalleArticulo.Controls.Add(this.lblNombre);
            this.gbDetalleArticulo.Controls.Add(this.lblCodigo);
            this.gbDetalleArticulo.Controls.Add(this.lblDescripcion);
            this.gbDetalleArticulo.Controls.Add(this.lblCategoria);
            this.gbDetalleArticulo.Controls.Add(this.label7);
            this.gbDetalleArticulo.Controls.Add(this.lblMarca);
            this.gbDetalleArticulo.Controls.Add(this.lblImagenUrl);
            this.gbDetalleArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDetalleArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalleArticulo.ForeColor = System.Drawing.Color.White;
            this.gbDetalleArticulo.Location = new System.Drawing.Point(12, 12);
            this.gbDetalleArticulo.Name = "gbDetalleArticulo";
            this.gbDetalleArticulo.Size = new System.Drawing.Size(264, 323);
            this.gbDetalleArticulo.TabIndex = 0;
            this.gbDetalleArticulo.TabStop = false;
            this.gbDetalleArticulo.Text = "Detalles del Artículo";
            // 
            // txtbPrecio
            // 
            this.txtbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtbPrecio.ForeColor = System.Drawing.Color.White;
            this.txtbPrecio.Location = new System.Drawing.Point(89, 267);
            this.txtbPrecio.Name = "txtbPrecio";
            this.txtbPrecio.ReadOnly = true;
            this.txtbPrecio.Size = new System.Drawing.Size(147, 22);
            this.txtbPrecio.TabIndex = 6;
            // 
            // txtbCategoria
            // 
            this.txtbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtbCategoria.ForeColor = System.Drawing.Color.White;
            this.txtbCategoria.Location = new System.Drawing.Point(89, 241);
            this.txtbCategoria.Name = "txtbCategoria";
            this.txtbCategoria.ReadOnly = true;
            this.txtbCategoria.Size = new System.Drawing.Size(147, 22);
            this.txtbCategoria.TabIndex = 5;
            // 
            // txtbMarca
            // 
            this.txtbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtbMarca.ForeColor = System.Drawing.Color.White;
            this.txtbMarca.Location = new System.Drawing.Point(89, 215);
            this.txtbMarca.Name = "txtbMarca";
            this.txtbMarca.ReadOnly = true;
            this.txtbMarca.Size = new System.Drawing.Size(147, 22);
            this.txtbMarca.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(34, 268);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio:";
            // 
            // rtbDescripcion
            // 
            this.rtbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtbDescripcion.ForeColor = System.Drawing.Color.White;
            this.rtbDescripcion.Location = new System.Drawing.Point(89, 87);
            this.rtbDescripcion.Name = "rtbDescripcion";
            this.rtbDescripcion.ReadOnly = true;
            this.rtbDescripcion.Size = new System.Drawing.Size(147, 96);
            this.rtbDescripcion.TabIndex = 2;
            this.rtbDescripcion.Text = "";
            // 
            // txtbImagenUrl
            // 
            this.txtbImagenUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtbImagenUrl.ForeColor = System.Drawing.Color.White;
            this.txtbImagenUrl.Location = new System.Drawing.Point(89, 189);
            this.txtbImagenUrl.Name = "txtbImagenUrl";
            this.txtbImagenUrl.ReadOnly = true;
            this.txtbImagenUrl.Size = new System.Drawing.Size(147, 22);
            this.txtbImagenUrl.TabIndex = 3;
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtbNombre.ForeColor = System.Drawing.Color.White;
            this.txtbNombre.Location = new System.Drawing.Point(89, 61);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.ReadOnly = true;
            this.txtbNombre.Size = new System.Drawing.Size(147, 22);
            this.txtbNombre.TabIndex = 1;
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtbCodigo.ForeColor = System.Drawing.Color.White;
            this.txtbCodigo.Location = new System.Drawing.Point(89, 29);
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.ReadOnly = true;
            this.txtbCodigo.Size = new System.Drawing.Size(147, 22);
            this.txtbCodigo.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(218, 356);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(282, 12);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(236, 323);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArticulo.TabIndex = 16;
            this.pbArticulo.TabStop = false;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(526, 399);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbDetalleArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle artículo";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            this.gbDetalleArticulo.ResumeLayout(false);
            this.gbDetalleArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox gbDetalleArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtbPrecio;
        private System.Windows.Forms.TextBox txtbCategoria;
        private System.Windows.Forms.TextBox txtbMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.RichTextBox rtbDescripcion;
        private System.Windows.Forms.TextBox txtbImagenUrl;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pbArticulo;
    }
}