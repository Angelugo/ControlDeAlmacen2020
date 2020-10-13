using Almacen.COMMON.Entidades;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Repositorio<T> where T : BaseDTO
    {
        
        MongoClient client;
        IMongoDatabase db;
        bool resultado;
        public string Error { get; private set; }
        public Repositorio()
        {
            try
            {
                client = new MongoClient(@"mongodb://localhost:27017");
                db = client.GetDatabase("Almacen");
            }

            catch
            {
                MessageBox.Show("Error en la conexión");
                return;
            }
        }
        private IMongoCollection<T> Collection() => db.GetCollection<T>(typeof(T).Name);
        public T Create(T entidad)
        {
            entidad.Id = ObjectId.GenerateNewId().ToString();
            try
            {
                Collection().InsertOne(entidad);
                Error = "";
                resultado = true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                resultado = false;
            }
            return resultado ? entidad : null;
        }

        public IEnumerable<T> Read
        {
            get
            {
                try
                {
                    Error = "";
                    return Collection().AsQueryable();
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return null;
                }

            }
        }

        public T Update(T entidad)
        {
            try
            {
                int r = (int)Collection().ReplaceOne(e => e.Id == entidad.Id, entidad).ModifiedCount;
                Error = r == 1 ? "Elemento Modificado" : "No se modificó el elemento";
                resultado = r == 1;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                resultado = false;
            }
            return resultado ? entidad : null;
        }

        public bool Borrar(string id)
        {
            try
            {
                int r = (int)Collection().DeleteOne(e => e.Id == id).DeletedCount;
                resultado = r == 1;
                Error = resultado ? "Elemento eliminado" : "No se pudo eliminar";
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                resultado = false;
            }
            return resultado;
        }

        public T SearchByName(string nombre)
        {

            return Collection().Find(nombre).SingleOrDefault();

        }

        public IEnumerable<T> Query(Expression<Func<T, bool>> predicado)
        {
            return Read.Where(predicado.Compile());
        }

    }
}
