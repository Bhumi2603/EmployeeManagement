using EmployeeManagement.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DAL
{
    public class EmployeeFamilyDetailRepository
    {
        string connectionString;

        public EmployeeFamilyDetailRepository()
        {
            connectionString = "Data Source=KRUNAL;Initial Catalog='Employee Management';Integrated Security=True;encrypt =True;TrustServerCertificate=True";
        }

        //GET All EmployeeFamilyDetail

        public List<EmployeeFamilyDetail> GetAllEmployeeFamilyDetail()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

            List<EmployeeFamilyDetail> employeeFamilyDetailList = new List<EmployeeFamilyDetail>();
            string query = "Select [EmployeeFamilyDetail].Id,[EmployeeFamilyDetail].EmployeeId,[EmployeeFamilyDetail].FirstName,[EmployeeFamilyDetail].LastName,[EmployeeFamilyDetail].MiddleName,[EmployeeFamilyDetail].DOB,[EmployeeFamilyDetail].RelationId,[Employee].FirstName as EmployeeName,[EmployeeRelation].Relation as RelationName" +
                                " from [EmployeeFamilyDetail]" +
                                " inner join [Employee] on [EmployeeFamilyDetail].EmployeeId = [Employee].Id" +
                                " inner join [EmployeeRelation] on [EmployeeFamilyDetail].RelationId = [EmployeeRelation].Id";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;

                cmd.Connection.Open();
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    EmployeeFamilyDetail employeeFamilyDetail = new EmployeeFamilyDetail();
                    employeeFamilyDetail.Id = Guid.Parse(dataReader["Id"].ToString());
                    employeeFamilyDetail.EmployeeId = Guid.Parse(dataReader["EmployeeId"].ToString());
                    employeeFamilyDetail.FirstName = dataReader["FirstName"].ToString();
                    employeeFamilyDetail.MiddleName = dataReader["MiddleName"].ToString();
                    employeeFamilyDetail.LastName = dataReader["LastName"].ToString();
                    employeeFamilyDetail.DOB = Convert.ToDateTime(dataReader["DOB"]);
                    employeeFamilyDetail.RelationId = Guid.Parse(dataReader["RelationId"].ToString());
                    employeeFamilyDetail.EmployeeName = dataReader["EmployeeName"].ToString();
                    employeeFamilyDetail.RelationName = dataReader["RelationName"].ToString();

                    employeeFamilyDetailList.Add(employeeFamilyDetail);

                }
                cmd.Connection.Close();

                return employeeFamilyDetailList;

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

        //ADD EmployeeFamilyDetail
        public Guid? AddEmployeeFamilyDetail(EmployeeFamilyDetail employeeFamilyDetail)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                var id = System.Guid.NewGuid();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Insert Into [EmployeeFamilyDetail] (Id,EmployeeId,FirstName,MiddleName,LastName,DOB,RelationId) values (@id, @EmployeeId,@FirstName,@MiddleName,@LastName,@DOB,@RelationId)";

                cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.Parameters.Add("EmployeeId", SqlDbType.UniqueIdentifier).Value = employeeFamilyDetail.EmployeeId;
                cmd.Parameters.Add("FirstName", SqlDbType.VarChar).Value = employeeFamilyDetail.FirstName;
                cmd.Parameters.Add("MiddleName", SqlDbType.VarChar).Value = employeeFamilyDetail.MiddleName;
                cmd.Parameters.Add("LastName", SqlDbType.VarChar).Value = employeeFamilyDetail.LastName;
                cmd.Parameters.Add("DOB", SqlDbType.DateTime).Value = employeeFamilyDetail.DOB;
                cmd.Parameters.Add("RelationId", SqlDbType.UniqueIdentifier).Value = employeeFamilyDetail.RelationId;

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
                if (conn.State != System.Data.ConnectionState.Closed) ;
                {
                    conn.Close();
                }
            }
        }
            //Get EmployeeFamilyDetail By Id

            public EmployeeFamilyDetail? Search(EmployeeFamilyDetail employeeFamilyDetail)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    EmployeeFamilyDetail? returnValue = null;
                    List<SqlParameter> parameters = new List<SqlParameter>();
                string query = "Select [EmployeeFamilyDetail].Id,[EmployeeFamilyDetail].EmployeeId,[EmployeeFamilyDetail].FirstName,[EmployeeFamilyDetail].LastName,[EmployeeFamilyDetail].MiddleName,[EmployeeFamilyDetail].DOB,[EmployeeFamilyDetail].RelationId,[Employee].FirstName as EmployeeName,[EmployeeRelation].Relation as RelationName" +
                               " from [EmployeeFamilyDetail]" +
                               " inner join [Employee] on [EmployeeFamilyDetail].EmployeeId = [Employee].Id" +
                               " inner join [EmployeeRelation] on [EmployeeFamilyDetail].RelationId = [EmployeeRelation].Id";

                if (employeeFamilyDetail != null)
                    {
                        if (employeeFamilyDetail.Id != null)
                        {
                        query += " And [EmployeeFamilyDetail].id = @id ";
                        parameters.Add(new SqlParameter()
                            {
                                ParameterName = "Id",
                                Value = employeeFamilyDetail.Id
                            });
                        }
                    if (!string.IsNullOrEmpty(employeeFamilyDetail.FirstName))
                    {
                        query += " Where FirstName = @FirstName";
                        parameters.Add(new SqlParameter()
                        {
                            ParameterName = "FirstName",
                            Value = employeeFamilyDetail.FirstName
                        });
                    }
                }

                    //ADO.Net

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
                        returnValue = new EmployeeFamilyDetail();
                        returnValue.Id = Guid.Parse(dataReader["Id"].ToString());
                        returnValue.EmployeeId = Guid.Parse(dataReader["EmployeeId"].ToString());
                        returnValue.FirstName = dataReader["FirstName"].ToString();
                        returnValue.MiddleName = dataReader["MiddleName"].ToString();
                        returnValue.LastName = dataReader["LastName"].ToString();
                        returnValue.DOB = Convert.ToDateTime(dataReader["DOB"].ToString());
                        returnValue.RelationId = Guid.Parse(dataReader["RelationId"].ToString());
                        returnValue.EmployeeName = dataReader["EmployeeName"].ToString();
                        returnValue.RelationName = dataReader["RelationName"].ToString();
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

        //Update Family Detail

        public EmployeeFamilyDetail? UpdateEmployeeFamilyDetail(Guid Id,EmployeeFamilyDetail employeeFamilyDetail)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                string query = "Update [EmployeeFamilyDetail] SET EmployeeId = @EmployeeId, FirstName = @FirstName, MiddleName=@MiddleName , LastName=@LastName,DOB = @DOB , RelationId = @RelationId  Where Id = @Id  ";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query
                    ;
                cmd.Parameters.Add("Id", SqlDbType.UniqueIdentifier).Value = employeeFamilyDetail.Id;
                cmd.Parameters.Add("EmployeeId", SqlDbType.UniqueIdentifier).Value = employeeFamilyDetail.EmployeeId;
                cmd.Parameters.Add("FirstName", SqlDbType.VarChar).Value = employeeFamilyDetail.FirstName;
                cmd.Parameters.Add("MiddleName", SqlDbType.VarChar).Value = employeeFamilyDetail.MiddleName;
                cmd.Parameters.Add("LastName", SqlDbType.VarChar).Value = employeeFamilyDetail.LastName;
                cmd.Parameters.Add("DOB", SqlDbType.DateTime).Value = employeeFamilyDetail.DOB;
                cmd.Parameters.Add("RelationId", SqlDbType.UniqueIdentifier).Value = employeeFamilyDetail.RelationId;
                cmd.Connection.Open();
                var result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return employeeFamilyDetail;

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

        //Delete Employee Family Detail

        public bool? DelateEmployeeFamilyDetail(Guid id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                int roweffcted = 0;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Delete from EmployeeFamilyDetail WHERE id='" + id + "' ";

                cmd.Connection.Open();
                roweffcted = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return roweffcted > 0 ? true : false;



            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }


    }
}