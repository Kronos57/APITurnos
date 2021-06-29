using System;

namespace Transversal.Entities
{
    public class Commerce
    {
        public int Id { get; set; }

        public string NombreComercio { get; set; }

        public Int16 AforoMaximo { get; set; }

        public Commerce()
        {

        }

        public Commerce(int id, string nombreComercio, Int16 aforoMaximo)
        {
            this.Id = id;
            this.NombreComercio = nombreComercio;
            this.AforoMaximo = aforoMaximo;
        }
    }
}
