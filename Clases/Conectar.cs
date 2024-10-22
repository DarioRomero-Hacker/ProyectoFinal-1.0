using System;
using Microsoft.Data.SqlClient; 
                                


public class Conectar
{
    public static SqlConnection crearConexion()
    {
        // Datos para la conexión
        string servidor = "NEBULAXTREME"; // Nombre del servidor
        string baseDeDatos = "barberia"; // Nombre de la base de datos
        string usuario = "sa"; // Usuario de SQL Server
        string contraseña = "1234567890"; // Contraseña de SQL Server

        string cadena = $"Server={servidor};Database={baseDeDatos};User Id={usuario};Password={contraseña};TrustServerCertificate=True;";


        try
        {
            // Creamos la conexión 
            SqlConnection conexion = new SqlConnection(cadena);
            return conexion;
        }
        catch (Exception ex)
        {
            // Cambiar MessageBox por un método adecuado según tu contexto (Console.WriteLine, etc.)
            Console.WriteLine("Error al realizar la conexión: " + ex.Message);
            return null; // Retornar null si hay un error
            // throw; // No es necesario lanzar la excepción aquí, ya se maneja arriba
        }
    }
}
