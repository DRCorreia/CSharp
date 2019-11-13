using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class AdvogadoDAO
    {
        public List<Advogado> BuscarAdvogadoPorID(Int32 _idAdvogado)
        {
            List<Advogado> listaAdvogados = new List<Advogado>();
            try
            {
                String SQL = String.Format("SELECT * FROM advogado WHERE id = {0};", _idAdvogado);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Advogado a = new Advogado();

                    a.Id_adv = data.GetInt32(0);
                    a.Nome_adv = data.GetString(1);
                    a.Email_adv = data.GetString(2);
                    a.Tel_adv = data.GetString(3);

                    listaAdvogados.Add(c);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaAdvogados;
        }

    }
}
