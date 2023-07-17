using EmployeeManagement.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public class EmployeeRelationRepository
    {
        string connectionString;

        public EmployeeRelationRepository()
        {
            connectionString = "Data Source=KRUNAL;Initial Catalog='Employee Management';Integrated Security=True;encrypt =True;TrustServerCertificate=True";
        }

        //GetAllEmployeeRelation

        //public List<EmployeeRelation> GetAllEmployeeReation()
        //{
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    List<EmployeeRelation> empRelation = new List<EmployeeRelation>();

        //    try
        //    {
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "Select * From EmployeeRelation INNER JOIN EmployeeFamilyDetail ON EmployeeRelation.Id = EmployeeFamilyDetail.RelationId";

        //        cmd.Connection.Open();
        //        var dataReader = cmd.ExecuteReader();
        //        while (dataReader.Read())
        //        {
        //            EmployeeRelation employeeRelation = new EmployeeRelation();
        //            employeeRelation.Id = Guid.Parse(dataReader["Id"].ToString());
        //            employeeRelation.Relation = dataReader["Relation"].ToString();

        //            empRelation.Add(employeeRelation);

        //        }
        //        cmd.Connection.Close();
        //        return empRelation;



        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (conn.State != ConnectionState.Open)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        //AddEmployeeRelation

        //public Guid? AddEmployeeRelation(EmployeeRelation employeeRelation)
        //{
        //    SqlConnection conn = new SqlConnection(connectionString);

        //    try
        //    {
        //        var id = System.Guid.NewGuid();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "Insert Into [EmployeeRelation] (Id,Relation) values (@Id, @Relation)";

        //        cmd.Parameters.Add("Id", SqlDbType.UniqueIdentifier).Value = id;
        //        cmd.Parameters.Add("Relation", SqlDbType.VarChar).Value = employeeRelation.Relation;

        //        cmd.Connection.Open();
        //        var result = cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();

        //        if (result > 0)
        //            return id;
        //        else
        //            return null;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (conn.State != System.Data.ConnectionState.Closed) ;
        //        {
        //            conn.Close();
        //        }
        //    }

        //}

        //Get Employee Relation By Id
        //public EmployeeRelation? GetEmployeeRelationById(Guid Id)
        //{
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    string query = "Select * From EmployeeRelation";

        //    try
        //    {
        //        EmployeeRelation employeeRelation = new EmployeeRelation();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = Id;
        //        cmd.Connection = conn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = query;

        //        cmd.Connection.Open();
        //        var dataReader = cmd.ExecuteReader();

        //        while (dataReader.Read())
        //        {

        //            employeeRelation.Id = Guid.Parse(dataReader["Id"].ToString()); ;
        //            employeeRelation.Relation = dataReader["Relation"].ToString();
        //            break;
        //        }
        //        cmd.Connection.Close();


        //        return employeeRelation;

        //    }

        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (conn.State != System.Data.ConnectionState.Closed)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        //Update EmployeeRelation

        //public EmployeeRelation? UpdateEmployeeRelation(EmployeeRelation employeeRelation)
        //{
        //    SqlConnection conn = new SqlConnection(connectionString);

        //    try
        //    {
        //        string query = "Update [EmployeeRelation] SET Relation = @Relation Where Id = @Id  ";

        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = query
        //            ;
        //        cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = employeeRelation.Id;
        //        cmd.Parameters.Add("Relation", SqlDbType.VarChar).Value = employeeRelation.Relation;

        //        cmd.Connection.Open();
        //        var result = cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();

        //        return employeeRelation;

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (conn.State != System.Data.ConnectionState.Closed)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        //Delete EmployeeRelation

        //        public bool? DeleteEmployeeRelation(Guid Id)
        //        {
        //            int result = 0;
        //            SqlConnection conn = new SqlConnection(connectionString);

        //            try
        //            {
        //                //int rowaffected = 0;
        //                //string query = "Delete Employee Where Id=@Id";

        //                SqlCommand cmd = new SqlCommand();
        //                cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = Id;
        //                cmd.Connection = conn;
        //                cmd.CommandType = System.Data.CommandType.Text;
        //                cmd.CommandText = "Delete from EmployeeRelation Where employeeRelation.Id='" + Id + "'";

        //                cmd.Connection.Open();
        //                result = cmd.ExecuteNonQuery();
        //                cmd.Connection.Close();

        //                //return rowaffected > 0 ? true : false;

        //            }
        //            catch (Exception)
        //            {
        //                throw;
        //            }
        //            finally
        //            {
        //                if (conn.State != System.Data.ConnectionState.Closed)
        //                {
        //                    conn.Close();
        //                }
        //            }
        //            if (result > 0)
        //                return true;
        //            else
        //                return false;
        //        }


        //    }
        //}

        //Get All

        public List<EmployeeRelation> GetAllEmployeeRelation()
        {
            SqlConnection Conn = new SqlConnection(connectionString);

            try
            {
                List<EmployeeRelation> employeeRelationlist = new List<EmployeeRelation>();
                string query = "Select * from [EmployeeRelation] ";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;

                cmd.Connection.Open();
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    EmployeeRelation enployeeRelation = new EmployeeRelation();
                    enployeeRelation.Id = Guid.Parse(dataReader["id"].ToString());
                    enployeeRelation.Relation = (dataReader["Relation"].ToString());

                    employeeRelationlist.Add(enployeeRelation);
                }
                cmd.Connection.Close();

                return employeeRelationlist;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //Add Post
        public Guid? AddEmployeeRelation(EmployeeRelation employeeRelation)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                var id = System.Guid.NewGuid();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Insert Into [EmployeeRelation] (id, Relation) Values (@id, @Relation)";

                cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.Parameters.Add("Relation", SqlDbType.VarChar).Value = employeeRelation.Relation;

                cmd.Connection.Open();
                var result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                if (result > 0)
                    return id;
                else
                    return null;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        //Get

        public EmployeeRelation? Search(EmployeeRelation employeeRelation)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                EmployeeRelation? returnValue = null;
                List<SqlParameter> parameters = new List<SqlParameter>();
                string query = string.Empty;
                if (employeeRelation != null)
                {
                    if (employeeRelation.Id != null)
                    {
                        query = "Select * from [EmployeeRelation] Where Id =@id ";
                        parameters.Add(new SqlParameter()
                        {
                            ParameterName = "id",
                            Value = employeeRelation.Id
                        });
                    }
                    if (!string.IsNullOrEmpty(employeeRelation.Relation))
                    {
                        query = " Select * from [EmployeeRelation] where Relation = @Relation";
                        parameters.Add(new SqlParameter()
                        {
                            ParameterName = "relation",
                            Value = employeeRelation.Relation
                        });

                    }
                }

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;
                foreach (SqlParameter param in parameters)
                {
                    cmd.Parameters.Add(param);
                }

                cmd.Connection.Open();
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    returnValue = new EmployeeRelation();
                    returnValue.Id = Guid.Parse(dataReader["id"].ToString());
                    returnValue.Relation = (dataReader["Relation"].ToString());
                    break;
                }
                cmd.Connection.Close();

                return returnValue;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        //Update

        public EmployeeRelation? UpdateEmployeeRelation(EmployeeRelation employeeRelation)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                string query = "Update [EmployeeRelation] SET Relation =@Relation Where id =@id";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = employeeRelation.Id;
                cmd.Parameters.Add("Relation", SqlDbType.VarChar).Value = employeeRelation.Relation;

                cmd.Connection.Open();
                var result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return employeeRelation;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        //Delete

        public bool? DeleteEmployeeRelation(Guid id)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                int rowafferted = 0;
                string query = "Delete from [EmployeeRelation] where id =@id";

                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;

                cmd.Connection.Open();
                rowafferted = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return rowafferted > 0 ? true : false;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}

