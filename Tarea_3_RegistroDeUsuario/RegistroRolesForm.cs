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
    public partial class RegistroRolesForm : Form
    {
        public RegistroRolesForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            RolIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            FechaCreacionDateTimePicker.Value = DateTime.Now;
        }

        private bool LlenarCampos(int id)
        {

            Usuarios user = UsuariosBLL.Buscar(id);

            if (user != null)
            {
                RolIdNumericUpDown.Value = user.RolId;
                DescripcionTextBox.Text = user.Alias;
                FechaCreacionDateTimePicker.Value = user.FechaIngreso;
                return true;
            }
            else
                return false;
        }

        private Roles LlenarClase()
        {
            Roles rol = new Roles();
            try
            {
                rol.rolesId = (int)RolIdNumericUpDown.Value;
            }
            catch (Exception)
            {
                throw;
            }

            rol.descripcion = DescripcionTextBox.Text;
            rol.fechaCreacion = FechaCreacionDateTimePicker.Value;

            return rol;
        }
        private bool EstaEnLaBD()
        {
            Roles rol = RolesBLL.Buscar(Convert.ToInt32((int)RolIdNumericUpDown.Value));
            return (rol != null);
        }

        private void RegistroRolesForm_Load(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles rol;
            bool paso = false;

            if (!Validar())
            {
                MessageBox.Show("Campo Descripcion vacio", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                rol = LlenarClase();
            }
            catch (Exception)
            {
                MessageBox.Show("Dato invalido en ID", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!RolesBLL.ExisteDescripcion(DescripcionTextBox.Text))
                paso = RolesBLL.Guardar(rol);

            else
            {

                MessageBox.Show("No se puede guardar el rol ya que este existe. Verifique la Descripcion", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {

                DescripcionTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Limpiar();

            if (RolesBLL.Eliminar((int)RolIdNumericUpDown.Value))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (LlenarCampos(Convert.ToInt32(RolIdNumericUpDown.Value)))
            {
                MessageBox.Show("Encontrado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Usuario No existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
