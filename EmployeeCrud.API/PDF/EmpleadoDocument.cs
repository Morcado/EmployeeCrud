using EmployeeCRUD.Data.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace EmployeeCrud.API.PDF
{
    public class EmpleadoDocument : IDocument
    {
        public EmpleadoDto empleado { get; }
        public EmpleadoDocument(EmpleadoDto empleado)
        {
            this.empleado = empleado;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;


        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50);

                    page.Header().Height(100).Background(Colors.Grey.Lighten1);
                    page.Content().Element(ComposeContent);
                    page.Footer().Height(50).Background(Colors.Grey.Lighten1);
                });
        }


        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Item().Row(row =>
                {
                    row.Spacing(5);
                    row.AutoItem().Text($"Nombre: {empleado.Nombre} {empleado.ApellidoPaterno} {empleado.ApellidoMaterno}.");
                });
                column.Item().Row(row =>
                {
                    row.Spacing(5);
                    row.AutoItem().Text($"Edad: {empleado.Edad} años.");
                });              
                column.Item().Row(row =>
                {
                    row.Spacing(5);
                    row.AutoItem().Text($"Genero: {empleado.Nombre}.");
                });
                column.Item().Row(row =>
                {
                    row.Spacing(5);
                    row.AutoItem().Text($"Grado de estudio: {empleado.GradoEstudio?.Nombre}.");
                });
                column.Item().Row(row =>
                {
                    row.Spacing(5);
                    row.AutoItem().Text($"Tipo de empleado: {empleado.TipoEmpleado?.Nombre}.");
                });
                column.Item().Row(row =>
                {
                    row.Spacing(10);
                    row.AutoItem().Text($"Direccion: {empleado.Direccion?.Calle} {empleado.Direccion?.Numero}{ empleado.Direccion?.CP}, {empleado.Direccion?.Estado?.Nombre}.");
                });
                column.Item().Row(row =>
                {
                    row.Spacing(10);
                    row.AutoItem().Text($"Telefono: +{empleado.Telefonos?.FirstOrDefault()?.Extension} {empleado.Telefonos?.FirstOrDefault()?.Numero} .");
                });
          

           
            });
        }
    }
}
