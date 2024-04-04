using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNACH.Portafolio.Datos;

namespace UNACH.Portafolio.Logica
{
    public class AreasMetodos
    {
        PortafolioEntities
            conexion = new PortafolioEntities();
        /// <summary>
        /// Metodo que obtine lista
        /// </summary>
        /// <returns></returns>
        public List<Area> ObtenerAreas()
        {
            var consulta = (from a in conexion.Areas
                            select a).ToList();
            return consulta;
        }
        public bool InsertarArea(Area entidad)
        {
            using (var con=new PortafolioEntities())
            {
                try
                {
                    con.Areas.Add(entidad);
                    con.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
        }
        public bool ModificarArea(Area entidad)
        {
            using(var conexion=new PortafolioEntities())
            {
                try
                {
                    var consulta = (from a in conexion.Areas
                                    where a.Id == entidad.Id
                                    select a).FirstOrDefault();
                    if (consulta != null)
                    {
                        consulta.Nombre = entidad.Nombre;
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }             
            }
        }
        public bool EliminarArea(int id)
        {
            try
            {
                using(var conexion=new PortafolioEntities())
                {
                    var consulta = (from a in conexion.Areas
                                    where a.Id == id
                                    select a).FirstOrDefault();
                    if (consulta != null)
                    {
                        conexion.Areas.Remove(consulta);
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    
    }

}
