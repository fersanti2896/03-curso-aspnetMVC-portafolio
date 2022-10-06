namespace Portafolio.Services {
    public class ServiciosRepository {

        public ServiciosRepository() {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }
    }

    public class ServiciosDelimitado {

        public ServiciosDelimitado() {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }
    }

    public class ServiciosTransitorio {

        public ServiciosTransitorio() {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; private set; }
    }
}
