﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using DAL.BD;

namespace BLL.BD
{
    public class Cls_BD_BLL
    {
        public void Traer_Cnx(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                obj_BD_DAL.sCadena = ConfigurationManager.ConnectionStrings["CalculadoraConnectionString"].ToString();

                obj_BD_DAL.SQL_CNX = new SqlConnection(obj_BD_DAL.sCadena);

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (Exception e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
        }


        public void Abrir_Cnx(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Closed)
                {
                    obj_BD_DAL.SQL_CNX.Open();
                }

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
        }


        public void Exec_DataAdapter(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                Traer_Cnx(ref obj_BD_DAL);

                if ((obj_BD_DAL.sMsjError == string.Empty) && (obj_BD_DAL.bBandError == false))
                {
                    Abrir_Cnx(ref obj_BD_DAL);


                    obj_BD_DAL.SQL_DA = new SqlDataAdapter(obj_BD_DAL.sSentencia, obj_BD_DAL.SQL_CNX);

                    #region Valido si hay o no parametros, para agregarlos

                    obj_BD_DAL.SQL_DA.SelectCommand.CommandType = CommandType.StoredProcedure;

                    if (obj_BD_DAL.Dt_Parametros.Rows.Count > 0)
                    {

                        foreach (DataRow dr in obj_BD_DAL.Dt_Parametros.Rows)
                        {
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr[0].ToString(),
                                                                                       SqlDbType.Int).Value = dr[2].ToString();
                                        break;
                                    }
                                case "2":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr[0].ToString(),
                                                                                       SqlDbType.NVarChar).Value = dr[2].ToString();
                                        break;
                                    }
                                case "3":
                                    {
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr[0].ToString(),
                                                                                       SqlDbType.Char).Value = dr[2].ToString();
                                        break;
                                    }
                                case "4":
                                    {
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr[0].ToString(), SqlDbType.VarChar).Value = dr[2].ToString();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }
                    }

                    #endregion

                    obj_BD_DAL.DS = new System.Data.DataSet();
                    obj_BD_DAL.SQL_DA.Fill(obj_BD_DAL.DS, obj_BD_DAL.sNomTabla);
                }

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
            finally
            {
                if (obj_BD_DAL != null)
                {
                    if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        obj_BD_DAL.SQL_CNX.Close();
                    }
                    //destruyo el objeto
                    obj_BD_DAL.SQL_CNX.Dispose();
                }
            }
        }


        public void Exec_NonQuery(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                Traer_Cnx(ref obj_BD_DAL);

                if ((obj_BD_DAL.sMsjError == string.Empty) && (obj_BD_DAL.bBandError == false))
                {
                    Abrir_Cnx(ref obj_BD_DAL);

                    obj_BD_DAL.SQL_CMD = new SqlCommand(obj_BD_DAL.sSentencia, obj_BD_DAL.SQL_CNX);

                    #region Valido si hay o no parametros, para agregarlos

                    obj_BD_DAL.SQL_CMD.CommandType = CommandType.StoredProcedure;

                    if (obj_BD_DAL.Dt_Parametros.Rows.Count > 0)
                    {

                        foreach (DataRow dr in obj_BD_DAL.Dt_Parametros.Rows)
                        {
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr[0].ToString(),
                                                                                       SqlDbType.Int).Value = dr[2].ToString();
                                        break;
                                    }
                                case "2":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr[0].ToString(),
                                                                                       SqlDbType.NVarChar).Value = dr[2].ToString();
                                        break;
                                    }
                                case "3":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr[0].ToString(),
                                                                                       SqlDbType.Bit).Value = dr[2].ToString();
                                        break;
                                    }
                                case "4":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr[0].ToString(), SqlDbType.VarChar).Value = dr[2].ToString();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }
                    }

                    #endregion

                    obj_BD_DAL.SQL_CMD.ExecuteNonQuery();
                }

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
            finally
            {
                if (obj_BD_DAL != null)
                {
                    if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        obj_BD_DAL.SQL_CNX.Close();
                    }
                    //destruyo el objeto
                    obj_BD_DAL.SQL_CNX.Dispose();
                }
            }
        }


        public void Exec_Scalar(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                Traer_Cnx(ref obj_BD_DAL);

                if ((obj_BD_DAL.sMsjError == string.Empty) && (obj_BD_DAL.bBandError == false))
                {
                    Abrir_Cnx(ref obj_BD_DAL);

                    obj_BD_DAL.SQL_CMD = new SqlCommand(obj_BD_DAL.sSentencia, obj_BD_DAL.SQL_CNX);

                    #region Valido si hay o no parametros, para agregarlos

                    obj_BD_DAL.SQL_CMD.CommandType = CommandType.StoredProcedure;

                    if (obj_BD_DAL.Dt_Parametros.Rows.Count > 0)
                    {

                        foreach (DataRow dr in obj_BD_DAL.Dt_Parametros.Rows)
                        {
                            switch (dr["TIPO_DATO"].ToString())
                            {
                                case "1":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NOMBRE_CAMPO"].ToString(),
                                                                                       SqlDbType.Int).Value = dr["VALOR"].ToString();
                                        break;
                                    }
                                case "2":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NOMBRE_CAMPO"].ToString(),
                                                                                       SqlDbType.NVarChar).Value = dr["VALOR"].ToString();
                                        break;
                                    }
                                case "3":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NOMBRE_CAMPO"].ToString(),
                                                                                       SqlDbType.Char).Value = dr["VALOR"].ToString();
                                        break;
                                    }
                                case "4":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NOMBRE_CAMPO"].ToString(), SqlDbType.VarChar).Value = dr["VALOR"].ToString();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }
                    }

                    #endregion

                    obj_BD_DAL.sValorScalar = obj_BD_DAL.SQL_CMD.ExecuteScalar().ToString();
                }

                obj_BD_DAL.sMsjError = string.Empty;

                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sValorScalar = "";
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
            finally
            {
                if (obj_BD_DAL != null)
                {
                    if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        obj_BD_DAL.SQL_CNX.Close();
                    }
                    //destruyo el objeto
                    obj_BD_DAL.SQL_CNX.Dispose();
                }
            }
        }

        public void Crear_DT_Parametros(ref Cls_BD_DAL Obj_Conexion)
        {
            Obj_Conexion.Dt_Parametros.Columns.Add("NombreParam");
            Obj_Conexion.Dt_Parametros.Columns.Add("TipoDatoParam");
            Obj_Conexion.Dt_Parametros.Columns.Add("ValorParam");
        }

    }
}
