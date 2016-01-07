using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CRUD.Objetos
{
    public class Predio
    {
        List<Apartamento> apartamentos;        
     
        public List<Apartamento> Apartamentos
        {
            get { return apartamentos; }
            set { apartamentos = value; }
        }

        public Predio()
        {
            apartamentos =  new List<Apartamento>();
        }

        public Apartamento ConsultarApartamento(string numero)
        {
            Apartamento apartamento = null;
            foreach(Apartamento ap in Apartamentos)
            {
                if (ap.Numero == numero)
                {
                    apartamento = ap;
                    break;
                }
            }
            return apartamento;
        }

        public void AdicionarApartamento(Apartamento apartamento)
        {
            if (ConsultarApartamento(apartamento.Numero) == null)
            {
                Apartamentos.Add(apartamento);
            }
        }

        public void ExcluirApartamento(string numero)
        {
            Apartamento apartamento = ConsultarApartamento(numero);
            if (apartamento != null)
            {
                Apartamentos.Remove(apartamento);
            }
        }

        public void SalvarApartamentos(string diretorio)
        {
            StreamWriter arquivo = new StreamWriter(diretorio + "Apartamentos.txt");
            string linha = "";
            foreach(Apartamento ap in apartamentos)
            {
                linha = string.Format("{0};{1};{2};{3};{4}",
                    ap.Numero,
                    ap.Andar,
                    ap.Dono,
                    ap.Area,
                    ap.VagasGaragem);
            }
            arquivo.Flush();
            arquivo.Close();
        }

        public void RecuperarApartamento(string diretorio)
        {
            if(File.Exists(diretorio + "Apartamentos.txt"))
            {
                StreamReader arquivo = new StreamReader(diretorio + "Apartamentos.txt");
                string[] campos;
                Apartamento ap;
                while (!arquivo.EndOfStream)
                {
                    campos = arquivo.ReadLine().Split(';');
                    ap = new Apartamento();
                    ap.Numero = campos[0];
                    ap.Andar = Convert.ToInt32(campos[1]);
                    ap.Dono = campos[2];
                    ap.Area = Convert.ToInt32(campos[3]);
                    ap.VagasGaragem = Convert.ToInt32(campos[4]);
                    Apartamentos.Add(ap);
                }
                arquivo.Close();
            }
        }
    }
}
