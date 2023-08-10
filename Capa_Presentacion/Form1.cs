using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_entidad;
using Capa_negocios;
using Capa_datos;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {

        private String idAgenda;
        private bool editar = false;

        E_Agenda objEntidad = new E_Agenda();
        N_Agenda objNegocio = new N_Agenda();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MostrarTabla(TxtBuscar.Text);
        }

        private void PicBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MostrarTabla(String buscar) {
        
            N_Agenda objNegocio = new N_Agenda();
            DGV.DataSource = objNegocio.ListarAgenda(buscar);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            MostrarTabla("");
        }

        public void Limpiar() {

            editar = false;
            TxtNombre.Text = "Nombre";
            TxtApellido.Text = "Apellido";
            TxtFecha.Text = "Fecha de Nacimiento";
            TxtDireccion.Text = "Direccion";
            TxtGenero.Text = "Genero";
            TxtEstado_civil.Text = "Estado Civil";
            TxtMovil.Text = "Movil";
            TxtTelefono.Text = "Telefono";
            TxtCorreo.Text = "Correo-Electronico";

            TxtBuscar.Text = "Buscar";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (editar == false)
            {
                try
                {
                    objEntidad.Nombre_agenda = TxtNombre.Text;
                    objEntidad.Apellido_agenda = TxtApellido.Text;
                    objEntidad.Fecha_agenda = TxtFecha.Text;
                    objEntidad.Direccion_agenda = TxtDireccion.Text;
                    objEntidad.Genero_agenda = TxtGenero.Text;
                    objEntidad.EstadoCivil_agenda = TxtEstado_civil.Text;
                    objEntidad.Movil_agenda = TxtMovil.Text;
                    objEntidad.Telefono_agenda = TxtTelefono.Text;
                    objEntidad.Correo_agenda = TxtCorreo.Text;

                    objNegocio.Insertar(objEntidad);

                    MessageBox.Show("Se guardo el registro");
                    MostrarTabla("");
                    Limpiar();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo guardar");
                }
            }


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (editar == true)
            {
                try
                {
                    objEntidad.Id_agenda = Convert.ToInt32(idAgenda);
                    objEntidad.Nombre_agenda = TxtNombre.Text;
                    objEntidad.Apellido_agenda = TxtApellido.Text;
                    objEntidad.Fecha_agenda = TxtFecha.Text;
                    objEntidad.Direccion_agenda = TxtDireccion.Text;
                    objEntidad.Genero_agenda = TxtGenero.Text;
                    objEntidad.EstadoCivil_agenda = TxtEstado_civil.Text;
                    objEntidad.Movil_agenda = TxtMovil.Text;
                    objEntidad.Telefono_agenda = TxtTelefono.Text;
                    objEntidad.Correo_agenda = TxtCorreo.Text;

                    objNegocio.Editar(objEntidad);

                    MessageBox.Show("Se edito el registro");
                    MostrarTabla("");
                    Limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo editar");
                }
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            editar = true;
            if (DGV.SelectedRows.Count > 0)
            {
                idAgenda = DGV.CurrentRow.Cells[0].Value.ToString();
                TxtNombre.Text = DGV.CurrentRow.Cells[1].Value.ToString();
                TxtApellido.Text = DGV.CurrentRow.Cells[2].Value.ToString();
                TxtFecha.Text = DGV.CurrentRow.Cells[3].Value.ToString();
                TxtDireccion.Text = DGV.CurrentRow.Cells[4].Value.ToString();
                TxtGenero.Text = DGV.CurrentRow.Cells[5].Value.ToString();
                TxtEstado_civil.Text = DGV.CurrentRow.Cells[6].Value.ToString();
                TxtMovil.Text = DGV.CurrentRow.Cells[7].Value.ToString();
                TxtTelefono.Text = DGV.CurrentRow.Cells[8].Value.ToString();
                TxtCorreo.Text = DGV.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                MessageBox.Show("Selecione una fila si desea editarla");
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                objEntidad.Id_agenda = Convert.ToInt32(DGV.CurrentRow.Cells[0].Value.ToString());
                objNegocio.Eliminar(objEntidad);

                MessageBox.Show("Se elimino correctamente");
                MostrarTabla("");
            }
            else
            {
                MessageBox.Show("seleccione la fila que desea eliminar");
            }
        }
    }
}
