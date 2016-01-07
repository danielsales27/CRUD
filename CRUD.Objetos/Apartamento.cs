using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Objetos
{
    public class Apartamento
    {
        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private int andar;

        public int Andar
        {
            get { return andar; }
            set { andar = value; }
        }

        private string dono;

        public string Dono
        {
            get { return dono; }
            set { dono = value; }
        }

        private double area;

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        private int vagasGaragem;

        public int VagasGaragem
        {
            get { return vagasGaragem; }
            set { vagasGaragem = value; }
        }
    }
}
