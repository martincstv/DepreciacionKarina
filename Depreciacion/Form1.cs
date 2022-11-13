using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depreciacion
{
    public partial class Form1 : Form
    {
        Activos activo = new Activos();
        List<Depreciacion> fila = new List<Depreciacion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarValoresIniciales();
        }

        private void CargarValoresIniciales()
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            var elementos = Enum.GetNames(typeof(Activos.TipoActivo));
            foreach (var item in elementos)
            {
                comboBox_Activo.Items.Add(item);
            }
            comboBox_Activo.SelectedIndex = Convert.ToInt32(Activos.TipoActivo.Seleccione);
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            Depreciacion();
            CargarDataGrid();
        }

        private void CargarDataGrid()
        {
            dataGridView_Datos.DataSource = null;
            dataGridView_Datos.DataSource = fila;
        }

        public void Depreciacion()
        {
            int anio = dateTimePicker_Adquisicion.Value.Year;
            int mes = dateTimePicker_Adquisicion.Value.Month;
            int mesf = dateTimePicker_Depreciacion.Value.Month;
            int m_Inicial = 13 - mes;//2
            int mesCalculado = mesf;//10
            float valorCompra = Convert.ToSingle(numericUpDown_Valor.Value);
            textBox_ValorResidual.Text = Residual(valorCompra).ToString();
            float valorActualInicial = 0;
            for (int i = 0; i <= activo.VidaUtilAnual; i++)
            {
                if (i == 0)
                {
                    fila.Add(new Depreciacion(i + 1,
                        (anio + i),
                        m_Inicial,
                        valorDepreciacion(valorCompra, Residual(valorCompra)) * m_Inicial,
                        valorActualInicial = (valorCompra - (valorDepreciacion(valorCompra, Residual(valorCompra)) * m_Inicial))));
                }
                if (i > 0 && i < activo.VidaUtilAnual)
                {
                    float valor_Depreciacion;
                    fila.Add(new Depreciacion(i + 1,
                        (anio + i),
                        12,
                        valor_Depreciacion = valorDepreciacion(valorCompra, Residual(valorCompra)) * 12,
                        (valorActualInicial -= valor_Depreciacion) <= Residual(valorCompra) ? Residual(valorCompra) : valorActualInicial));
                }
                if (i == activo.VidaUtilAnual)
                {
                    float valor_Depreciacion;
                    fila.Add(new Depreciacion(i + 1,
                        (anio + i),
                        mesCalculado,
                        valor_Depreciacion = valorDepreciacion(valorCompra, Residual(valorCompra)) * mesCalculado,
                        ((valorActualInicial -= valor_Depreciacion) <= Residual(valorCompra)) ? Residual(valorCompra) : valorActualInicial));
                }

            }
        }

        private void button_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            throw new NotImplementedException();

        }

        private void comboBox_Activo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox_Activo.Text;
            int nAnio = dateTimePicker_Depreciacion.Value.Year - dateTimePicker_Adquisicion.Value.Year;
            switch (item)
            {
                case "Inmueble":
                    // activo.PorcentajeAnual = 10;
                    activo.VidaUtilAnual = nAnio;
                    //activo.NumeroMeses = 240;
                    break;
                case "Vehiculo":

                    // activo.PorcentajeAnual = 5;
                    activo.VidaUtilAnual = nAnio;
                    // activo.NumeroMeses = 60;
                    break;
            }
        }

        private float Residual(float valor)
        {
            float res = 0;
            var item = comboBox_Activo.Text;
            switch (item)
            {
                case "Inmueble":
                    res = valor / 20;

                    break;
                case "Vehiculo":

                    res = valor / 5;

                    break;
            }
            return res;

        }
        private float valorDepreciacion(float compra, float res)
        {
            float dec = 0;
            var item = comboBox_Activo.Text;
            compra = Convert.ToInt32(numericUpDown_Valor.Value);
            res = Residual(compra);
            switch (item)
            {
                case "Inmueble":
                    dec = (compra - res) / 20;
                    break;
                case "Vehiculo":

                    dec = (compra - res) / 5;
                    break;
            }
            return dec / 12;

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
