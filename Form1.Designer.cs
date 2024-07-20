namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.bSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.lstIDCuentas = new System.Windows.Forms.ListBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnAtrasFinal = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAdelanteFinal = new System.Windows.Forms.Button();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Location = new System.Drawing.Point(12, 12);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.Size = new System.Drawing.Size(379, 271);
            this.dgvCuentas.TabIndex = 0;
            // 
            // lstIDCuentas
            // 
            this.lstIDCuentas.FormattingEnabled = true;
            this.lstIDCuentas.Location = new System.Drawing.Point(416, 12);
            this.lstIDCuentas.Name = "lstIDCuentas";
            this.lstIDCuentas.Size = new System.Drawing.Size(372, 277);
            this.lstIDCuentas.TabIndex = 1;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(210, 347);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(53, 13);
            this.lblTitular.TabIndex = 2;
            this.lblTitular.Text = "TITULAR";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(212, 300);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(51, 13);
            this.lblCuenta.TabIndex = 3;
            this.lblCuenta.Text = "CUENTA";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(212, 387);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(43, 13);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "SALDO";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(277, 299);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(124, 20);
            this.txtCuenta.TabIndex = 5;
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(277, 340);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(127, 20);
            this.txtTitular.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(277, 379);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(123, 20);
            this.txtSaldo.TabIndex = 7;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(339, 421);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(65, 17);
            this.chkActivo.TabIndex = 8;
            this.chkActivo.Text = "ACTIVO";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnAtrasFinal
            // 
            this.btnAtrasFinal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAtrasFinal.Location = new System.Drawing.Point(431, 325);
            this.btnAtrasFinal.Name = "btnAtrasFinal";
            this.btnAtrasFinal.Size = new System.Drawing.Size(58, 49);
            this.btnAtrasFinal.TabIndex = 9;
            this.btnAtrasFinal.Text = "<|";
            this.btnAtrasFinal.UseVisualStyleBackColor = true;
            this.btnAtrasFinal.Click += new System.EventHandler(this.btnAtrasFinal_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(498, 326);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(55, 47);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "<";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.Location = new System.Drawing.Point(603, 327);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(52, 46);
            this.btnAdelante.TabIndex = 11;
            this.btnAdelante.Text = ">";
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAdelanteFinal
            // 
            this.btnAdelanteFinal.Location = new System.Drawing.Point(671, 325);
            this.btnAdelanteFinal.Name = "btnAdelanteFinal";
            this.btnAdelanteFinal.Size = new System.Drawing.Size(51, 49);
            this.btnAdelanteFinal.TabIndex = 12;
            this.btnAdelanteFinal.Text = "|>";
            this.btnAdelanteFinal.UseVisualStyleBackColor = true;
            this.btnAdelanteFinal.Click += new System.EventHandler(this.btnAdelanteFinal_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(562, 343);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(16, 13);
            this.lblPosicion.TabIndex = 13;
            this.lblPosicion.Text = "---";
            // 
            // btnConfirma
            // 
            this.btnConfirma.Location = new System.Drawing.Point(433, 382);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(119, 39);
            this.btnConfirma.TabIndex = 14;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseVisualStyleBackColor = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(603, 380);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(116, 41);
            this.btnCancela.TabIndex = 15;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 311);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 85);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(107, 311);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(79, 90);
            this.btnElimina.TabIndex = 17;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.btnAdelanteFinal);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAtrasFinal);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.lblTitular);
            this.Controls.Add(this.lstIDCuentas);
            this.Controls.Add(this.dgvCuentas);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bSource;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.ListBox lstIDCuentas;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnAtrasFinal;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnAdelanteFinal;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnElimina;
    }
}

