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
            RolIdNumericUpDown.Value = 0;
            AliasTextBox.Text = string.Empty;
            NombreTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            ConfirmaClaveTextBox.Text = string.Empty;
            ActivoCheckBox.Checked = false;
            EmailTextBox.Text = string.Empty;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
        }

        private void ConfirmarClave()
        {
            if (ClaveTextBox.Text != ConfirmaClaveTextBox.Text)
            {

                ClaveTextBox.Text = string.Empty;
                ConfirmaClaveTextBox.Text = string.Empty;

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
            user.RolId = Convert.ToInt32(RolIdNumericUpDown.Value);
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
                RolIdNumericUpDown.Value = user.RolId;
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
                MessageBox.Show("Campos importantes Vacios", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            try
            {
                user = LlenarClase();
            }
            catch (Exception)
            {
                MessageBox.Show("CLave No coiciden, Vuelva a Ingresarlas ", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }


            if (!EstaEnLaBD())
                paso = UsuariosBLL.Guardar(user);

            else
            {

                MessageBox.Show("No se puede guardar el usuario ya que este existe. Verifique el Id del usuario", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Usuarios user;
            bool paso = false;

            try
            {
                user = LlenarClase();
            }
            catch (Exception)
            {
                MessageBox.Show("Dato invalido en ID", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validar())
            {
                MessageBox.Show("Campos importantes Vacios", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EstaEnLaBD() )
            {
                paso = UsuariosBLL.Modificar(user);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el rol ya que este no existe!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible modificar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
