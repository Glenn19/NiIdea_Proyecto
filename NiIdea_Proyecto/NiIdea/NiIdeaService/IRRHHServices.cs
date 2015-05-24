using NiIdeaService.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NiIdeaService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRRHHServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRRHHServices
    {
        [OperationContract]
        Responsable CrearResponsable(long dni, string nombre, string ape_pat, string ape_mat, string correo, short edad, char sexo);

        [OperationContract]
        Responsable ModificarResponsable(int codigo, long dni, string nombre, string ape_pat, string ape_mat, string correo, short edad, char sexo);

        [OperationContract]
        Responsable ObtenerResponsable(int codigo);

        [OperationContract]
        void EliminarResponsable(int codigo);

        [OperationContract]
        List<Responsable> ListarResponsables();
    }
}
