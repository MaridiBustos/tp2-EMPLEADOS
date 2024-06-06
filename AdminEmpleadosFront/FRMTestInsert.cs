using AdminEmpleadosEntidades;
using AdminEmpleadosNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminEmpleadosFront
{
    public partial class FRMTestInsert : Form
    {
        public FRMTestInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs ev)
        {
            //creo el empleado
            Empleado e = new Empleado();
            e.Nombre = "nombre1";
            e.Salario = 100;
            e.Dni = "132";
            e.Direccion = "aaa";
            // e.dpto_id = ???; esto no hace falta, ademas no conoces el ID porque no se generó aun


            //creo el departamento
            Departamento d = new Departamento();    
            d.Nombre = "Dpto 1";
            d.dpto_nro = 100;
            e.Departamento = d;


            //asigno el dpto al empleado            
            e.Departamento = d;

            //entity framework se encarga de insertar primero el dpto y despues el empleado y luego 
            //asignar en la tabla empleado el campo dpto_id correspondiente...asi de facil

            EmpleadosNegocio.Insert(e);



        }
    }
}
