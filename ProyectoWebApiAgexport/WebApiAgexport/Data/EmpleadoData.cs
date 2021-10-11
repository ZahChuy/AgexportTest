using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApiAgexport.Models;

namespace WebApiAgexport.Data
{
    public class EmpleadoData
    {
        public static bool Grabar(Empleado oEmpleado) {

            using (SqlConnection oConexion = new SqlConnection(Conexion.ConexionDB)) {

                SqlCommand cmd = new SqlCommand("emp_grabar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombres", oEmpleado.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", oEmpleado.Apellidos);
                cmd.Parameters.AddWithValue("@Genero", oEmpleado.Genero);
                cmd.Parameters.AddWithValue("@EstadoCivil", oEmpleado.EstadoCivil);
                cmd.Parameters.AddWithValue("@FechaNacimiento", oEmpleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Edad", oEmpleado.Edad);
                cmd.Parameters.AddWithValue("@DPI", oEmpleado.DPI);
                cmd.Parameters.AddWithValue("@NIT", oEmpleado.NIT);
                cmd.Parameters.AddWithValue("@AfiliacionIGGS", oEmpleado.AfiliacionIGGS);
                cmd.Parameters.AddWithValue("@AfilicacionIrtra", oEmpleado.AfilicacionIrtra);
                cmd.Parameters.AddWithValue("@NoPasaporte", oEmpleado.NoPasaporte);
                cmd.Parameters.AddWithValue("@PaisId", oEmpleado.PaisId);
                cmd.Parameters.AddWithValue("@Telefono", oEmpleado.Telefono);
                cmd.Parameters.AddWithValue("@DireccionResidencia", oEmpleado.DireccionResidencia);
                cmd.Parameters.AddWithValue("@Puesto", oEmpleado.Puesto);
                cmd.Parameters.AddWithValue("@Sueldo", oEmpleado.Sueldo);
                cmd.Parameters.AddWithValue("@Bonificacion", oEmpleado.Bonificacion);


                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception ex) {

                    return false;
                }
            }

        }
        public static bool Modificar(Empleado oEmpleado)
        {

            using (SqlConnection oConexion = new SqlConnection(Conexion.ConexionDB))
            {

                SqlCommand cmd = new SqlCommand("emp_modificar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoId", oEmpleado.EmpleadoId);
                cmd.Parameters.AddWithValue("@Nombres", oEmpleado.Nombres);
                cmd.Parameters.AddWithValue("@Apellidos", oEmpleado.Apellidos);
                cmd.Parameters.AddWithValue("@Genero", oEmpleado.Genero);
                cmd.Parameters.AddWithValue("@EstadoCivil", oEmpleado.EstadoCivil);
                cmd.Parameters.AddWithValue("@FechaNacimiento", oEmpleado.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Edad", oEmpleado.Edad);
                cmd.Parameters.AddWithValue("@DPI", oEmpleado.DPI);
                cmd.Parameters.AddWithValue("@NIT", oEmpleado.NIT);
                cmd.Parameters.AddWithValue("@AfiliacionIGGS", oEmpleado.AfiliacionIGGS);
                cmd.Parameters.AddWithValue("@AfilicacionIrtra", oEmpleado.AfilicacionIrtra);
                cmd.Parameters.AddWithValue("@NoPasaporte", oEmpleado.NoPasaporte);
                cmd.Parameters.AddWithValue("@PaisId", oEmpleado.PaisId);
                cmd.Parameters.AddWithValue("@Telefono", oEmpleado.Telefono);
                cmd.Parameters.AddWithValue("@DireccionResidencia", oEmpleado.DireccionResidencia);
                cmd.Parameters.AddWithValue("@Puesto", oEmpleado.Puesto);
                cmd.Parameters.AddWithValue("@Sueldo", oEmpleado.Sueldo);
                cmd.Parameters.AddWithValue("@Bonificacion", oEmpleado.Bonificacion);


                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }

        public static List<Empleado> Lista()
        {
            List<Empleado> oListaEmpleado = new List<Empleado>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.ConexionDB))
            {
                SqlCommand cmd = new SqlCommand("emp_listar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;


                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaEmpleado.Add(new Empleado()
                            {
                                EmpleadoId = Convert.ToInt32(dr["EmpleadoId"]),
                                Nombres = dr["Nombres"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Genero = dr["Genero"].ToString(),
                                EstadoCivil = dr["EstadoCivil"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                                Edad = Convert.ToInt32(dr["Edad"]),
                                DPI = Convert.ToInt32(dr["DPI"]),
                                NIT = dr["NIT"].ToString(),
                                AfiliacionIGGS = Convert.ToInt32(dr["AfiliacionIGGS"]),
                                AfilicacionIrtra = Convert.ToInt32(dr["AfilicacionIrtra"]),
                                NoPasaporte = Convert.ToInt32(dr["NoPasaporte"]),
                                PaisId = Convert.ToInt32(dr["PaisId"]),
                                Telefono = Convert.ToInt32(dr["Telefono"]),
                                DireccionResidencia = dr["DireccionResidencia"].ToString(),
                                Puesto = dr["Puesto"].ToString(),
                                Sueldo = Convert.ToDecimal(dr["Sueldo"]),
                                Bonificacion = Convert.ToDecimal(dr["Bonificacion"]),
                                EstadoId = Convert.ToInt32(dr["EstadoId"])

                            });
                        }
                    }
                    return oListaEmpleado;
                }
                catch
                {
                    return oListaEmpleado;
                }

            }
        }

            public static Empleado obtener(int empleadoId)
            {
                Empleado oEmpleado = new Empleado();
                using (SqlConnection oConexion = new SqlConnection(Conexion.ConexionDB))
                {
                    SqlCommand cmd = new SqlCommand("emp_obtener", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);

                    try
                    {
                        oConexion.Open();
                        cmd.ExecuteNonQuery();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                oEmpleado = new Empleado()
                                {
                                    EmpleadoId = Convert.ToInt32(dr["EmpleadoId"]),
                                    Nombres = dr["Nombres"].ToString(),
                                    Apellidos = dr["Apellidos"].ToString(),
                                    Genero = dr["Genero"].ToString(),
                                    EstadoCivil = dr["EstadoCivil"].ToString(),
                                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                                    Edad = Convert.ToInt32(dr["Edad"]),
                                    DPI = Convert.ToInt32(dr["DPI"]),
                                    NIT = dr["NIT"].ToString(),
                                    AfiliacionIGGS = Convert.ToInt32(dr["AfiliacionIGGS"]),
                                    AfilicacionIrtra = Convert.ToInt32(dr["AfilicacionIrtra"]),
                                    NoPasaporte = Convert.ToInt32(dr["NoPasaporte"]),
                                    PaisId = Convert.ToInt32(dr["PaisId"]),
                                    Telefono = Convert.ToInt32(dr["Telefono"]),
                                    DireccionResidencia = dr["DireccionResidencia"].ToString(),
                                    Puesto = dr["Puesto"].ToString(),
                                    Sueldo = Convert.ToDecimal(dr["Sueldo"]),
                                    Bonificacion = Convert.ToDecimal(dr["Bonificacion"]),
                                    EstadoId = Convert.ToInt32(dr["EstadoId"])

                                };
                            }
                        }
                        return oEmpleado;
                    }
                    catch
                    {
                        return oEmpleado;
                    }

                }
            }

        public static bool Eliminar(int empleadoId)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.ConexionDB))
            {
                SqlCommand cmd = new SqlCommand("emp_eliminar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoId", empleadoId);


                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
        }

    }
}