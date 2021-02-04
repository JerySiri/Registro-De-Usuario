using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_3_RegistroDeUsuario.BLL;
using Tarea_3_RegistroDeUsuario.DAL;
using Tarea_3_RegistroDeUsuario.Entidades;

namespace Tarea_3_RegistroDeUsuario
{
    public partial class RegistroUsuarioForm : Form
    {
        public RegistroUsuarioForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            UsuarioIdNumericUpDown.Value = 0;
            RolIdoComboBox.Text = string.Empty;
            AliasTextBox.Clear();
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmaClaveTextBox.Clear();
            ActivoCheckBox.Checked = false;
            EmailTextBox.Clear();
            FechaIngresoDateTimePicker.Value = DateTime.Now;
        }

        private void ConfirmarClave()
        {
            if (ClaveTextBox.Text != ConfirmaClaveTextBox.Text)
            {

                ClaveTextBox.Clear();
                ConfirmaClaveTextBox.Clear();

                throw new Exception("Clave incorrecta en uno de los dos parametros");
            }
        }
        private Usuarios LlenarClase()
        {
            
            Usuarios user = new Usuarios();


            try
            {
                ConfirmarClave();
            }
            catch (Exception)
            {
                throw;
            }

            user.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            user.RolId = Convert.ToInt32(RolIdoComboBox.Text);
            user.Alias = AliasTextBox.Text;
            user.Nombre = NombreTextBox.Text;
            user.Clave = ClaveTextBox.Text;
            user.Activo = ActivoCheckBox.Checked;
            user.Email = EmailTextBox.Text;
            user.FechaIngreso = FechaIngresoDateTimePicker.Value;


            return user;
        }
        private bool LlenarCampos(int id)
        {

            Usuarios user = UsuariosBLL.Buscar(Convert.ToInt32(UsuarioIdNumericUpDown.Value));

            if (user != null)
            {
                RolIdoComboBox.Text =Convert.ToString(user.RolId);
                AliasTextBox.Text = user.Alias;
                NombreTextBox.Text = user.Nombre;
                ClaveTextBox.Text = user.Clave;
                ConfirmaClaveTextBox.Text = user.Clave;
                ActivoCheckBox.Checked = user.Activo;
                EmailTextBox.Text = user.Email;
                FechaIngresoDateTimePicker.Value = user.FechaIngreso;
                return true;
            }
            else
                return false;
        }


        private bool EstaEnLaBD()
        {
            Usuarios user = UsuariosBLL.Buscar(Convert.ToInt32(UsuarioIdNumericUpDown.Value));
            return (user != null);
        }

        private void RegistroUsuarioForm_Load(object sender, EventArgs e)
        {
            RolIdoComboBox.DataSource = RolesBLL.GetRoles();
            RolIdoComboBox.DisplayMember = "descripcion";
            RolIdoComboBox.ValueMember = "rolesId";
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios user;
            bool paso = false;

            if (!Validar())
            {
                MessageBox.Show("Campos   Vacios", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            try
            {
                user = LlenarClase();
            }
            catch (Exception)
            {
                MessageBox.Show("Clave incorrecta no coinciden en alguno de los dos campos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            paso = UsuariosBLL.Guardar(user);

            if (paso)
            {
                
                MessageBox.Show("Transaccion exitosa!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Limpiar();
            }
            else
                MessageBox.Show("No fue posible guardar o modificar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private bool Validar()
        {
            bool paso = true;

            if ( NombreTextBox.Text == String.Empty)
            {
                NombreTextBox.Focus();
                paso = false;
            }

            if (AliasTextBox.Text == String.Empty)
            {
                AliasTextBox.Focus();
                paso = false;
            }

            if (ClaveTextBox.Text == String.Empty)
            {
                ClaveTextBox.Focus();
                paso = false;
            }

            if ( ConfirmaClaveTextBox.Text == String.Empty)
            {
                ConfirmaClaveTextBox.Focus();
                paso = false;
            }

            if (EmailTextBox.Text == String.Empty)
            {
                EmailTextBox.Focus();
                paso = false;
            }
            
            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            if (LlenarCampos(Convert.ToInt32(UsuarioIdNumericUpDown.Value)))
            {
                MessageBox.Show("Encontrado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.Eliminar(Convert.ToInt32(UsuarioIdNumericUpDown.Value)))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }
    }
}
