using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace PresentacionWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarDataGrid();
            CargarDataGrid();
        }

        private void ConfigurarDataGrid()
        {
            dataGridAlumnos.Rows.Clear();
            dataGridAlumnos.ColumnCount = 7;
            dataGridAlumnos.Columns[0].Name = "Id";
            dataGridAlumnos.Columns[0].ReadOnly = true;
            dataGridAlumnos.Columns[1].Name = "Legajo";
            dataGridAlumnos.Columns[1].ReadOnly = true;
            dataGridAlumnos.Columns[2].Name = "Id-Persona";
            dataGridAlumnos.Columns[2].ReadOnly = true;
        }

        public void CargarDataGrid()
        {
            int renglon = 0;
            dataGridAlumnos.Rows.Clear();
            foreach (tb_Alumno alu in AlumnoCN.obtenerAlumnos())
            {
                renglon = dataGridAlumnos.Rows.Add();
                dataGridAlumnos.Rows[renglon].Cells["Id"].Value = alu.idAlumno;
                dataGridAlumnos.Rows[renglon].Cells["Legajo"].Value = alu.legajo;
                dataGridAlumnos.Rows[renglon].Cells["Id-Persona"].Value = alu.Persona_IdPersona;
            }
        }
    }
}
