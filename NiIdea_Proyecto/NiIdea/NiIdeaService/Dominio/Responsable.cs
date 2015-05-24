using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NiIdeaService.Dominio
{
    [DataContract]
    public class Responsable
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public long Dni { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Ape_Pat { get; set; }
        [DataMember]
        public string Ape_Mat { get; set; }
        [DataMember]
        public string Correo { get; set; }
        [DataMember]
        public short Edad { get; set; }
        [DataMember]
        public char Sexo { get; set; }

    }
}