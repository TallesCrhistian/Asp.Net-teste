using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace GpsSkateShop
{
    public class Relatorio
    {
        private readonly Catagolo catagolo;

        public Relatorio(Catagolo catagolo)
        {
            this.catagolo = catagolo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var shape in catagolo.GetShapes())
            {
                await context.Response.WriteAsync($"{shape.Codigo,-10}{shape.Nome,-40}{shape.Preco.ToString("C"),10}\r\n");
            }
        }
    }
}
