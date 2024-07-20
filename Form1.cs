using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp2
{
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataSource ds = new DataSource("Data/datos.json");  // Instanciacion del objeto DataSource
            BindingList<Cuenta> cuentas = ds.Load();            // Carga de datos. 
            bSource.DataSource = cuentas;                       // Asignacion al BindingSource. 
            dgvCuentas.AutoGenerateColumns = true;             // Deshabilitado autogeneracion de columnas. 
            dgvCuentas.DataSource = bSource;            // Asignacion del BindingSource al DataGridView



            // Comprobar si hay una fila seleccionada
            //if (dgvCuentas.SelectedRows.Count > 0)
            //{
                // Obtencion del objeto Cuenta vinculado. 
            //    Cuenta c = dgvCuentas.SelectedRows[0].DataBoundItem as Cuenta;
            //    System.Diagnostics.Debug.WriteLine(c.ToString());
            //}
            //else
            //    MessageBox.Show("No hay ningún elemento seleccionado.");

            // ListBox ( lstIDCuentas ) 
            lstIDCuentas.DataSource = bSource;                  // Asignacion al BindingSource.
            lstIDCuentas.DisplayMember = "Titular";             // Propiedad mostrada.
            lstIDCuentas.ValueMember = "Titular";                    // Valor mostrado.

            // TextBox ( txtCuenta, txtTitular, txtSaldo ) & CheckBox ( chkActivo ) 
            txtCuenta.DataBindings.Add(new Binding("Text", bSource, "ID"));
            txtTitular.DataBindings.Add(new Binding("Text", bSource, "Titular"));
            txtSaldo.DataBindings.Add(new Binding("Text", bSource, "Saldo"));
            chkActivo.DataBindings.Add(new Binding("Checked", bSource, "Activa"));

        }

        private void btnAtrasFinal_Click(object sender, EventArgs e)
        {
            {
                bSource.MoveFirst();                                            // Ve al primer objeto
                lblPosicion.Text = $"{bSource.Position+1}/{bSource.Count}";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            {
                bSource.MovePrevious();                                         // Ve al anterior objeto
                lblPosicion.Text = $"{bSource.Position+1}/{bSource.Count}";
            }

        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            {
                bSource.MoveNext();                                             // Ve al siguiente objeto
                lblPosicion.Text = $"{bSource.Position+1}/{bSource.Count}";
            }
        }

        private void btnAdelanteFinal_Click(object sender, EventArgs e)
        {
            {
                bSource.MoveLast();                                             // Ve al último objeto
                lblPosicion.Text = $"{bSource.Position+1}/{bSource.Count}";
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            bSource.EndEdit();
            
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            bSource.CancelEdit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bSource.AddNew();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            bSource.RemoveCurrent();
        }
        private void bSource_CurrentItemChanged(object sender, EventArgs e)
        {
            // Recuperamos el objeto activo actual.
            Cuenta cuenta = bSource.Current as Cuenta;
            if (cuenta.Saldo < 0)                                       // Comprobacion valor del campo saldo actual.         
            {
                MessageBox.Show("No se permiten saldos negativos.");    // ERROR. Mensaje informativo 
                bSource.CancelEdit();                                   // Cancelación del cambio.
            }
        }
        
    }

    class Cuenta : IEditableObject, INotifyPropertyChanged
    {
        // Propiedades de respaldo para guardar los valores originales
        // para permitir su recuperación si se descartan los cambios. 
        private String copyID;
        private String copyTitular;
        private float copySaldo;
        private DateTime copyApertura;
        private bool copyActiva;

        private bool updating = false;      // Indica si el objeto ha sido modificado. 

        public String ID { get; set; }
        public String Titular { get; set; }
        public float Saldo { get; set; }
        public DateTime Apertura { get; set; }
        public bool Activa { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        /// <summary>
        /// Método que se activa cuando el objeto es editado. 
        /// </summary>
        public void BeginEdit()
        {
            if (!updating)
            {
                copyID = ID;
                copyTitular = Titular;
                copySaldo = Saldo;
                copyApertura = Apertura;
                copyActiva = Activa;
                updating = true;
            }
        }
        /// <summary>
        /// Método que descarta los cambios y recupera los valores originales. 
        /// </summary>
        public void CancelEdit()
        {
            if (updating)
            {
                ID = copyID;
                Titular = copyTitular;
                Saldo = copySaldo;
                Apertura = copyApertura;
                Activa = copyActiva;
                updating = false;
            }
        }
        /// <summary>
        /// Método que confirma los valores actuales modificados
        /// </summary>
        public void EndEdit()
        {
            updating = false;
        }


    }

    class DataSource
    {

        /// Ruta del fichero JSON

        private String ruta;

        public DataSource(String ruta) => this.ruta = ruta;


        /// Carga datos desde fichero

        /// <returns>Lista Vinculable con datos deserializados</returns>
        public BindingList<Cuenta> Load()
        {
            String json = File.ReadAllText(ruta);
            BindingList<Cuenta> datos = JsonSerializer.Deserialize<BindingList<Cuenta>>(json);
            return datos;
        }


        /// Guarda datos a fichero

        /// <param name="cuentas">Lista vinculable con datos a serializar</param>
        public void Save(BindingList<Cuenta> cuentas)
        {
            String json = JsonSerializer.Serialize(cuentas);
            File.WriteAllText(ruta, json);
        }
    }
}
