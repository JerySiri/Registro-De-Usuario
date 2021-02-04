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
            RolIdComboBox.Text = string.Empty;
            AliasTextBox.Clear();
            NombreTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmaClaveTextBox.Clear();
            ActivoCheckBox.Checked = false;
            EmailTextBox.Clear();
            FechaIngresoDateTimePicker.Value = DateTime.Now;
        }

        private Usuarios LlenarClase()
        {
            
            Usuarios user = new Usuarios();

            user.UsuarioId = (int)UsuarioIdNumericUpDown.Value ;
            user.RolId = Convert.ToInt32(RolIdComboBox.Text);
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

            Usuarios user = UsuariosBLL.Buscar( (int)UsuarioIdNumericUpDown.Value) ;

            if (user != null)
            {
                RolIdComboBox.Text =Convert.ToString(user.RolId);
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


        private bool EstaEnLaBaseDeDatos()
        {
            Usuarios user = UsuariosBLL.Buscar( (int)UsuarioIdNumericUpDown.Value );
            return (user != null);
        }

        private void RegistroUsuarioForm_Load(object sender, EventArgs e)
        {
            RolIdComboBox.DataSource = RolesBLL.GetRoles();
            RolIdComboBox.DisplayMember = "descripcion";
            RolIdComboBox.ValueMember = "rolesId";
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
                return;
            
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

            if (ClaveTextBox.Text != ConfirmaClaveTextBox.Text)
            {
                MyErrorProvider.SetError(NombreTextBox, "Los campos Clave y confrimar Clave no pueden ser diferentes");
                NombreTextBox.Focus();
                paso = false;
            }

            if ( NombreTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(NombreTextBox, "El Campo nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            if (AliasTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(AliasTextBox, "El Campo alias no puede estar vacio");
                AliasTextBox.Focus();
                paso = false;
            }

            if (ClaveTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(ClaveTextBox, "El Campo Clave no puede estar vacio");
                ClaveTextBox.Focus();
                paso = false;
            }

            if ( ConfirmaClaveTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(ConfirmaClaveTextBox, "El Campo Confirmar Clave no puede estar vacio");
                ConfirmaClaveTextBox.Focus();
                paso = false;
            }

            if (EmailTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(EmailTextBox, "El Campo E-mail Clave no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }
            

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            if (LlenarCampos( (int)UsuarioIdNumericUpDown.Value) )
            {
                MessageBox.Show("Encontrado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (UsuariosBLL.Eliminar((int)UsuarioIdNumericUpDown.Value))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }
    }
}
