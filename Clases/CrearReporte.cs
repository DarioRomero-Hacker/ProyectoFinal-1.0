using ClosedXML.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_1._0.Clases
{
    internal class CrearReporte
    {
        // Para almacenar
        private DataGridView dataGridView;

        // Recibe como argumento un DataGridView
        public CrearReporte(DataGridView dgv)
        {
            // Obtener el DataGridView donde estan los datos
            this.dataGridView = dgv;
        }

        // Crear los reportes
        public void ObtenerReporte(string rutaPDF, string rutaExcel)
        {
            GenerarPDF(rutaPDF);
            GenerarExcel(rutaExcel);
        }

        private void GenerarPDF(string rutaPDF)
        {
            // Crear el documento PDF
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(rutaPDF, FileMode.Create));
            document.Open();

            // Crear una tabla
            PdfPTable table = new PdfPTable(dataGridView.Columns.Count);

            // Añadir encabezados
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                table.AddCell(cell);
            }

            // Añadir filas
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? string.Empty);
                    }
                }
            }

            // Añadir la tabla al documento
            document.Add(table);

            // Cerrar el documento
            document.Close();
        }

        // Generar reporte Exel
        private void GenerarExcel(string rutaExcel)
        {
            var workbook = new XLWorkbook();

            var worksheet = workbook.Worksheets.Add("Reporte");

            // Añadir encabezados
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cell(1, i + 1).Value = dataGridView.Columns[i].HeaderText;
            }

            // Añadir filas
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (!dataGridView.Rows[i].IsNewRow)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;
                    }
                }
            }

            workbook.SaveAs(rutaExcel);
        }
    }
}
