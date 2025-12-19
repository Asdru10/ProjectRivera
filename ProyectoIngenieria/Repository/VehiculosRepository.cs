using ProyectoIngenieria.Models;
using ProyectoIngenieria.Repository.Interfaces;

namespace ProyectoIngenieria.Repository
{
    public class VehiculosRepository : Repository<Vehiculo>, IVehiculosRepository
    {
        private readonly ProyectoIngenieriaContext _db;

        public VehiculosRepository(ProyectoIngenieriaContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Vehiculo vehiculo)
        {
           _db.Vehiculos.Update(vehiculo);
        }
    }
}
