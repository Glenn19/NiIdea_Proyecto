using NiIdeaService.Dominio;
using NiIdeaService.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NiIdeaService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RRHHServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RRHHServices.svc o RRHHServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RRHHServices : IRRHHServices
    {
        private ResponsableDAO responsableDAO = null;
        private ResponsableDAO ResponsableDAO
        {
            get
            {
                if (responsableDAO == null)
                    responsableDAO = new ResponsableDAO();
                return responsableDAO;
            }
        }

      
       


        public Responsable ObtenerResponsable(int codigo)
        {
            //throw new NotImplementedException();
            return ResponsableDAO.Obtener(codigo);
        }

       


        public Responsable CrearResponsable(long dni, string nombre, string ape_pat, string ape_mat, string correo, short edad, char sexo)
        {
            //throw new NotImplementedException();
            Responsable responsableACrear = new Responsable()
            {
                Dni = dni,
                Nombre = nombre,
                Ape_Pat = ape_pat,
                Ape_Mat = ape_mat,
                Correo = correo,
                Edad = edad,
                Sexo = sexo

            };
            return ResponsableDAO.Crear(responsableACrear);    
        }

        public Responsable ModificarResponsable(int codigo, long dni, string nombre, string ape_pat, string ape_mat, string correo, short edad, char sexo)
        {
            //throw new NotImplementedException();
            Responsable responsableAModificar = new Responsable()
            {
                Codigo = codigo,
                Dni = dni,
                Nombre = nombre,
                Ape_Pat = ape_pat,
                Ape_Mat = ape_mat,
                Correo = correo,
                Edad = edad,
                Sexo = sexo

            };
            return ResponsableDAO.Modificar(responsableAModificar);   
        }

        public void EliminarResponsable(int codigo)
        {
            //throw new NotImplementedException();
            Responsable responsableExistente = ResponsableDAO.Obtener(codigo);
            ResponsableDAO.Eliminar(responsableExistente);
        }

        public List<Responsable> ListarResponsables()
        {
            //throw new NotImplementedException();
            return ResponsableDAO.ListarTodos().ToList();
        }
    }
}
