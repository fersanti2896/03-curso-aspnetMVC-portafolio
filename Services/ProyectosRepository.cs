using Portafolio.Models;

namespace Portafolio.Services {
    public class ProyectosRepository {
        public List<ProyectModel> ObtenerProyectos() {
            return new List<ProyectModel>() {
                new ProyectModel {
                    Titulo = "Contadores Cabañas",
                    Descripcion = "Plataforma de presentación realizada en ASP.NET Core",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/amazon.png"
                },
                 new ProyectModel {
                    Titulo = "Legal Advise",
                    Descripcion = "Plataforma de presentación realizada en Angular",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/nyt.png"
                },
                new ProyectModel {
                    Titulo = "Mis contadores",
                    Descripcion = "Plataforma de presentación realizada en Angular",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/reddit.png"
                },
                new ProyectModel {
                    Titulo = "Sistema de Paga",
                    Descripcion = "Plataforma de backend realizado en Nodejs",
                    Link = "https://www.google.com",
                    ImgUrl = "/images/steam.png"
                }
            };
        }
    }
}
