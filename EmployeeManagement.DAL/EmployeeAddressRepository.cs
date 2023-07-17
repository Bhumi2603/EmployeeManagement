//using  EmployeeManagement.Core;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EmployeeManagement.DAL
//{
//    public class EmployeeAddressRepository
//    {
//        string connectionString;

//        public EmployeeAddressRepository()
//        {
//            connectionString = "Data Source=KRUNAL;Initial Catalog='Employee Management';Integrated Security=True;encrypt =True;TrustServerCertificate=True";
//        }

//        //Get All EmployeeAddress

//        public List<EmployeeAddress> GetAllEmployeeAddresses()
//        {
//            SqlConnection conn = new SqlConnection(connectionString);
//            List<EmployeeAddress> employeeAddressList = new List<EmployeeAddress>();
//            string query = "Select [EmployeeAddress].id,[EmployeeAddress].Address,[EmployeeAddress].EmployeeId,[EmployeeAddress].City,[EmployeeAddress].State,[EmployeeAddress].Country,[EmployeeAddress].Pincode,[EmployeeAddress].AddressTypeId,[Employee].FirstName as EmployeeName,[AddressType].AddressTypes as TypeOfAddress " +
//                "from [EmployeeAddress]" +
//                " inner join [Employee] on [EmployeeAddress].EmployeeId = [Employee].id" +
//                " inner join [AddressType] on [EmployeeAddress].AddressTypeId = [AddressType].@id And [EmployeeAddress].id = @id";

//            try
//            {
//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = conn;
//                cmd.CommandType = System.Data.CommandType.Text;
//                cmd.CommandText = query;

//                cmd.Connection.Open();
//                var datareader = cmd.ExecuteReader();

//                while (datareader.Read())
//                {
//                    EmployeeAddress employeeAddress = new EmployeeAddress();
//                    employeeAddress.Id = Guid.Parse(datareader["Id"].ToString()); ;
//                    employeeAddress.Address = datareader["Address"].ToString();
//                    employeeAddress.EmployeeId = Guid.Parse(datareader["EmployeeId"].ToString());
//                    employeeAddress.City = datareader["City"].ToString();
//                    employeeAddress.State = datareader["State"].ToString();
//                    employeeAddress.Country = datareader["Country"].ToString();
//                    employeeAddress.Pincode = datareader["Pincode"].ToString();
//                    employeeAddress.AddressTypeId = Guid.Parse(datareader["AddressTypeId"].ToString());

//                    employeeAddressList.Add(employeeAddress);
//                }
//                cmd.Connection.Close();

//                return employeeAddressList;
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
//        }


//        //Add EmployeeAddress

//        public Guid? AddEmployeeAddress(EmployeeAddress employeeAddress)
//        {
//            SqlConnection conn = new SqlConnection(connectionString);

//            try
//            {
//                var Id = System.Guid.NewGuid();
//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = conn;
//                cmd.CommandType = System.Data.CommandType.Text;
//                cmd.CommandText = "Insert Into [EmployeeAddress] (id, Address, EmployeeId, City, State, Country, Pincode, AddressTypeId) Values (@id, @Address,@EmployeeId, @City, @State, @Country, @Pincode, @AddressTypeId)";

//                cmd.Parameters.Add("Id", SqlDbType.UniqueIdentifier).Value = Id;
//                cmd.Parameters.Add("Address", SqlDbType.VarChar).Value = employeeAddress.Address;
//                cmd.Parameters.Add("EmployeeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.EmployeeId;
//                cmd.Parameters.Add("City", SqlDbType.VarChar).Value = employeeAddress.City;
//                cmd.Parameters.Add("State", SqlDbType.VarChar).Value = employeeAddress.State;
//                cmd.Parameters.Add("Country", SqlDbType.VarChar).Value = employeeAddress.Country;
//                cmd.Parameters.Add("Pincode", SqlDbType.VarChar).Value = employeeAddress.Pincode;
//                cmd.Parameters.Add("AddressTypeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.AddressTypeId;

//                cmd.Connection.Open();
//                var result = cmd.ExecuteNonQuery();
//                cmd.Connection.Close();

//                if (result > 0)
//                    return Id;
//                else
//                    return null;
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
//        }


//        //Get EmployeeAddressById(get single Employee Address By Id)

//        public EmployeeAddress? GetEmployeeAddressById(Guid Id)
//        {
//            SqlConnection conn = new SqlConnection(connectionString);
//            string query = "Select [EmployeeAddress].id,[EmployeeAddress].Address,[EmployeeAddress].EmployeeId,[EmployeeAddress].City,[EmployeeAddress].State,[EmployeeAddress].Country,[EmployeeAddress].Pincode,[EmployeeAddress].AddressTypeId,[Employee].FirstName as EmployeeName,[AddressType].AddressTypes as TypeOfAddress " +
//                "from [EmployeeAddress]" +
//                " inner join [Employee] on [EmployeeAddress].EmployeeId = [Employee].id" +
//                " inner join [AddressType] on [EmployeeAddress].AddressTypeId = [AddressType].id And [EmployeeAddress].Id = @Id";
//            try
//            {

//                EmployeeAddress employeeAddress = new EmployeeAddress();
//                SqlCommand cmd = new SqlCommand();
//                cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = Id;
//                cmd.Connection = conn;
//                cmd.CommandType = System.Data.CommandType.Text;
//                cmd.CommandText = query;

//                cmd.Connection.Open();
//                var dataReader = cmd.ExecuteReader();

//                while (dataReader.Read())
//                {

//                    employeeAddress.Id = Guid.Parse(dataReader["Id"].ToString()); ;
//                    employeeAddress.Address = dataReader["Address"].ToString();
//                    employeeAddress.EmployeeId = Guid.Parse(dataReader["EmployeeId"].ToString());
//                    employeeAddress.City = dataReader["City"].ToString();
//                    employeeAddress.State = dataReader["State"].ToString();
//                    employeeAddress.Country = dataReader["Country"].ToString();
//                    employeeAddress.Pincode = dataReader["Pincode"].ToString();
//                    employeeAddress.AddressTypeId = Guid.Parse(dataReader["AddressTypeId"].ToString());
//                    break;
//                }
//                cmd.Connection.Close();


//                return employeeAddress;

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
//        }

//        //Get EmployeeAddressById

//        //public EmployeeAddress? Search(EmployeeAddress employeeAddress)
//        //{
//        //    SqlConnection conn = new SqlConnection(connectionString);
//        //    try
//        //    {
//        //        EmployeeAddress? returnValue = null;
//        //        List<SqlParameter> parameters = new List<SqlParameter>();
//        //        string query = "Select * From EmployeeAddress";
//        //        if (employeeAddress != null)
//        //        {
//        //            if (employeeAddress.Id != null)
//        //            {
//        //                query += " Where Id = @Id";
//        //                parameters.Add(new SqlParameter()
//        //                {
//        //                    ParameterName = "Id",
//        //                    Value = employeeAddress.Id
//        //                });
//        //            }
//        //            if (!string.IsNullOrEmpty(employeeAddress.Address))
//        //            {
//        //                query += " Where Address = @Address";
//        //                parameters.Add(new SqlParameter()
//        //                {
//        //                    ParameterName = "Address",
//        //                    Value = employeeAddress.Address
//        //                });
//        //            }
//        //        }

//        //        //ADO .NET
//        //        SqlCommand cmd = new SqlCommand();
//        //        cmd.Connection = conn;
//        //        cmd.CommandType = System.Data.CommandType.Text;
//        //        cmd.CommandText = query;
//        //        foreach (SqlParameter param in parameters)
//        //        {
//        //            cmd.Parameters.Add(param);
//        //        }

//        //        cmd.Connection.Open();
//        //        var dataReader = cmd.ExecuteReader();
//        //        while (dataReader.Read())
//        //        {
//        //            returnValue = new EmployeeAddress();
//        //            returnValue.Id = Guid.Parse(dataReader["Id"].ToString());
//        //            returnValue.Address = dataReader["Address"].ToString();
//        //            returnValue.EmployeeId = Guid.Parse(dataReader["EmployeeId"].ToString());
//        //            returnValue.City = dataReader["City"].ToString();
//        //            returnValue.State = dataReader["State"].ToString();
//        //            returnValue.Country = dataReader["Country"].ToString();
//        //            returnValue.Pincode = dataReader["Pincode"].ToString();
//        //            returnValue.AddressTypeId = Guid.Parse(dataReader["AddressTypeId"].ToString());

//        //            break;

//        //        }
//        //        cmd.Connection.Close();

//        //        return returnValue;
//        //    }
//        //    catch (Exception)
//        //    {
//        //        throw;
//        //    }
//        //    finally
//        //    {
//        //        if (conn.State != System.Data.ConnectionState.Closed)
//        //        {
//        //            conn.Close();
//        //        }
//        //    }
//        //}



//        //Update EmployeeAddress

//        public EmployeeAddress? UpdateEmployeeAddress(EmployeeAddress employeeAddress)
//        {
//            SqlConnection conn = new SqlConnection(connectionString);

//            try
//            {
//                string query = "Update [EmployeeAddress] SET Id=@Id,Address=@Address,EmployeeId=@EmployeeId,City=@City,State=@State,Country=@Country,Pincode=@Pincode,AddressTypeId=@AddressTypeId";

//                SqlCommand cmd = new SqlCommand();
//                cmd.Connection = conn;
//                cmd.CommandType = System.Data.CommandType.Text;
//                cmd.CommandText = query;

//                cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier).Value = employeeAddress.Id;
//                cmd.Parameters.Add("Address", SqlDbType.VarChar).Value = employeeAddress.Address;
//                cmd.Parameters.Add("EmployeeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.EmployeeId;
//                cmd.Parameters.Add("City", SqlDbType.VarChar).Value = employeeAddress.City;
//                cmd.Parameters.Add("State", SqlDbType.VarChar).Value = employeeAddress.State;
//                cmd.Parameters.Add("Country", SqlDbType.VarChar).Value = employeeAddress.Country;
//                cmd.Parameters.Add("Pincode", SqlDbType.VarChar).Value = employeeAddress.Pincode;
//                cmd.Parameters.Add("AddressTypeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.AddressTypeId;

//                cmd.Connection.Open();
//                var result = cmd.ExecuteNonQuery();
//                cmd.Connection.Close();

//                return employeeAddress;

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
//        }

//        //Delete EmployeeAddress

//        public bool? DeleteEmployeeAddress(Guid Id)
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
//                cmd.CommandText = "Delete from EmployeeAddress Where EmployeeAddress.Id='" + Id + "'";

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


using EmployeeManagement.Core;
using NSubstitute.Core;
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
    public class EmployeeAddressRepository
    {
        string connectionString;

        public EmployeeAddressRepository()
        {
             connectionString = "Data Source=KRUNAL;Initial Catalog='Employee Management';Integrated Security=True;encrypt =True;TrustServerCertificate=True";
        }
        public List<EmployeeAddress> GetAllEmployeeAddress()
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                List<EmployeeAddress> employeeAddresseslist = new List<EmployeeAddress>();
                string query = "Select [EmployeeAddress].Id,[EmployeeAddress].Address,[EmployeeAddress].EmployeeId,[EmployeeAddress].City,[EmployeeAddress].State,[EmployeeAddress].Country,[EmployeeAddress].Pincode,[EmployeeAddress].AddressTypeId,[Employee].FirstName as EmployeeName,[AddressType].AddressTypes as TypeOfAddress " +
                    "from [EmployeeAddress]" +
                    " inner join [Employee] on [EmployeeAddress].EmployeeId = [Employee].id" +
                    " inner join [AddressType] on [EmployeeAddress].AddressTypeId = [AddressType].id ";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;

                cmd.Connection.Open();
                var dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    EmployeeAddress employeeAddress = new EmployeeAddress();
                    //employeeAddress = new EmployeeAddress();
                    employeeAddress.Id = Guid.Parse(dataReader["id"].ToString());
                    employeeAddress.Address = dataReader["Address"].ToString();
                    employeeAddress.EmployeeId = Guid.Parse(dataReader["EmployeeId"].ToString());
                    employeeAddress.City = dataReader["City"].ToString();
                    employeeAddress.State = dataReader["State"].ToString();
                    employeeAddress.Country = dataReader["Country"].ToString();
                    employeeAddress.Pincode = dataReader["Pincode"].ToString();
                    employeeAddress.AddressTypeId = Guid.Parse(dataReader["AddressTypeId"].ToString());
                    employeeAddress.EmployeeName = dataReader["EmployeeName"].ToString();
                    employeeAddress.TypeOfAddress = dataReader["TypeOfAddress"].ToString();

                    employeeAddresseslist.Add(employeeAddress);

                }
                cmd.Connection.Close();

                return employeeAddresseslist;
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

        //Add Post
        public Guid? AddEmployeeAddress(EmployeeAddress employeeAddress)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                var id = System.Guid.NewGuid();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Insert Into [EmployeeAddress] (id, Address, EmployeeId, City, State, Country, Pincode, AddressTypeId) Values (@id, @Address,@EmployeeId, @City, @State, @Country, @Pincode, @AddressTypeId)";

                cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = id;
                cmd.Parameters.Add("Address", SqlDbType.VarChar).Value = employeeAddress.Address;
                cmd.Parameters.Add("EmployeeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.EmployeeId;
                cmd.Parameters.Add("City", SqlDbType.VarChar).Value = employeeAddress.City;
                cmd.Parameters.Add("State", SqlDbType.VarChar).Value = employeeAddress.State;
                cmd.Parameters.Add("Country", SqlDbType.VarChar).Value = employeeAddress.Country;
                cmd.Parameters.Add("Pincode", SqlDbType.VarChar).Value = employeeAddress.Pincode;
                cmd.Parameters.Add("AddressTypeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.AddressTypeId;

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

        public EmployeeAddress Search(EmployeeAddress employeeAddress)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                EmployeeAddress? returnValue = null;
                List<SqlParameter> parameters = new List<SqlParameter>();
                string query = "Select [EmployeeAddress].id,[EmployeeAddress].Address,[EmployeeAddress].EmployeeId,[EmployeeAddress].City,[EmployeeAddress].State,[EmployeeAddress].Country,[EmployeeAddress].Pincode,[EmployeeAddress].AddressTypeId,[Employee].FirstName as EmployeeName,[AddressType].AddressTypes as TypeOfAddress " +
                    " from [EmployeeAddress]" +
                    " inner join [Employee] on [EmployeeAddress].EmployeeId = [Employee].Id" +
                    " inner join [AddressType] on [EmployeeAddress].AddressTypeId = [AddressType].Id And [EmployeeAddress].Id = @Id";
                if (employeeAddress != null)
                {
                    if (employeeAddress.Id != null)
                    {
                        parameters.Add(new SqlParameter()
                        {
                            ParameterName = "id",
                            Value = employeeAddress.Id
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
                    returnValue = new EmployeeAddress();
                    returnValue.Id = Guid.Parse(dataReader["Id"].ToString());
                    returnValue.Address = dataReader["Address"].ToString();
                    returnValue.EmployeeId = Guid.Parse(dataReader["EmployeeId"].ToString());
                    returnValue.City = dataReader["City"].ToString();
                    returnValue.State = dataReader["State"].ToString();
                    returnValue.Country = dataReader["Country"].ToString();
                    returnValue.Pincode = dataReader["Pincode"].ToString();
                    returnValue.AddressTypeId = Guid.Parse(dataReader["AddressTypeId"].ToString());
                    returnValue.EmployeeName = dataReader["EmployeeName"].ToString();
                    returnValue.TypeOfAddress = dataReader["TypeOfAddress"].ToString();
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

        public EmployeeAddress? UpdateEmployeeAddress(Guid id,EmployeeAddress employeeAddress)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                string query = "Update [EmployeeAddress] SET  Address = @Address, State= @State, City =@City, Country =@Country, Pincode =@Pincode,AddressTypeId =@AddressTypeId Where id = @id ";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = query;

                cmd.Parameters.Add("id", SqlDbType.UniqueIdentifier).Value = employeeAddress.Id;
                cmd.Parameters.Add("Address", SqlDbType.VarChar).Value = employeeAddress.Address;
                cmd.Parameters.Add("EmployeeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.EmployeeId;
                cmd.Parameters.Add("City", SqlDbType.VarChar).Value = employeeAddress.City;
                cmd.Parameters.Add("State", SqlDbType.VarChar).Value = employeeAddress.State;
                cmd.Parameters.Add("Country", SqlDbType.VarChar).Value = employeeAddress.Country;
                cmd.Parameters.Add("Pincode", SqlDbType.VarChar).Value = employeeAddress.Pincode;
                cmd.Parameters.Add("AddressTypeId", SqlDbType.UniqueIdentifier).Value = employeeAddress.AddressTypeId;

                cmd.Connection.Open();
                var result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return employeeAddress;

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

        public bool? DeleteEmployeeAddress(Guid id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                int rowaffected = 0;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "Delete from EmployeeAddress WHERE id='" + id + "'";

                cmd.Connection.Open();

                rowaffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rowaffected > 0 ? true : false;


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