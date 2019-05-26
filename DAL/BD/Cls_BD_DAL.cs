using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.BD
{
    public class Cls_BD_DAL
    {
        #region OBJETOS

        public DataTable _dt_Parametros = new DataTable("PARAMETROS");
        public SqlDataAdapter SQL_DA;
        public SqlCommand SQL_CMD;
        public SqlConnection SQL_CNX;
        public DataSet DS;

        public DataTable Dt_Parametros
        {
            get
            {
                return _dt_Parametros;
            }
            set
            {
                _dt_Parametros = value;
            }
        }

        #endregion

        #region VARIABLES PRIVADAS

        private string _sMsjError, _sCadena, _sSentencia, _sNomTabla, _sValorScalar;
        private bool _bBandError;

        #endregion

        #region VARIABLES PÚBLICAS

        public string sValorScalar
        {
            get
            {
                return _sValorScalar;
            }

            set
            {
                _sValorScalar = value;
            }
        }

        public string sMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }

        public string sCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string sSentencia
        {
            get
            {
                return _sSentencia;
            }

            set
            {
                _sSentencia = value;
            }
        }

        public string sNomTabla
        {
            get
            {
                return _sNomTabla;
            }

            set
            {
                _sNomTabla = value;
            }
        }

        public bool bBandError
        {
            get
            {
                return _bBandError;
            }

            set
            {
                _bBandError = value;
            }
        }

        #endregion
    }
}
