using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Clinic
{
    class Controller
    {
        SqlConnection sqlconnection;
        public Controller(SqlConnection SQL)
        {
            sqlconnection = SQL;
        }
        public void DeleteClient(int ValueOfCode)
        {
            SqlCommand command = sqlconnection.CreateCommand();
            DataTable pets = FindPet(ValueOfCode);
            for (int i=0; i<pets.Rows.Count; i++)
            {
                DeletePet(Int32.Parse(pets.Rows[i]["CodeOfContract"].ToString()));
            }
            command.CommandText = "DELETE FROM Owner WHERE (CodeOfClient="+ValueOfCode+")";
            sqlconnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при соединении с базой данных!");
            }
            finally
            {
                sqlconnection.Close();
            }
        }

        public DataTable GetBreeds(int code)
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT * FROM Breeds WHERE (Breeds.Type="+code+")";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            return dt;
        }
        public void DeletePet(int ValueOfCode)
        {
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "DELETE FROM Pet Where  (CodeOfContract="+ValueOfCode+")";
            sqlconnection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка при соединении с базой данных!");
            }
            finally
            {
                sqlconnection.Close();
            }
        }
        public DataTable GetKinds()
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT Kinds.Kind FROM Kinds";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            return dt;
        }
        public int GetCodeOwner()
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT Owner.CodeOfClient FROM Owner";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            int result = Int32.Parse(dt.Rows[dt.Rows.Count - 1]["CodeOfClient"].ToString());
            return result;
        }
        public int GetCodePet()
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT Pet.CodeOfContract FROM Pet";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            int result=Int32.Parse(dt.Rows[dt.Rows.Count - 1]["CodeOfContract"].ToString());
            return result + 1;
        }
        public DataTable SearchOwner(string phone, string Surname)
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            if (phone!="")
            {
                if (Surname!="")
                {
                    command.CommandText = "SELECT * FROM Owner WHERE (Surname='" + Surname + "') AND (Phone='" + phone + "')";
                }else
                {
                    command.CommandText = "SELECT * FROM Owner WHERE (Phone=" + phone + ")";
                }
            }else
            {
                if (Surname != "")
                {
                    command.CommandText = "SELECT * FROM Owner WHERE (Surname='" + Surname + "')";
                }
            }
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            dt.Columns.Add("Питомцы");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable pdt = FindPet(Int32.Parse(dt.Rows[i][0].ToString()));
                string pets = "";
                if (pdt.Rows.Count > 0)
                {
                    for (int y = 0; y < pdt.Rows.Count; y++)
                    {
                        pets += pdt.Rows[y][2].ToString() + " ";
                    }
                    dt.Rows[i]["Питомцы"] = pets;
                }

            }
            return dt;
        }
        public DataTable ShowPetsTable ()
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT Pet.CodeOfContract, Pet.Name, Kinds.Kind, Owner.Surname, Owner.Name, Owner.Lastname, Owner.CodeOfClient FROM Pet, Owner, Kinds WHERE (Pet.Owner=Owner.CodeOfClient) AND (Pet.Status is null) AND (Kinds.CodeOfKind=Pet.Kind)";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            dt.Columns.Add("Владелец");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name = dt.Rows[i]["Name1"].ToString();
                dt.Rows[i]["Владелец"] = dt.Rows[i]["Surname"].ToString() + " " + name.Remove(1, name.Length - 1) + ". ";
                if (dt.Rows[i]["Lastname"].ToString()!="")
                {
                    string lastname = dt.Rows[i]["Lastname"].ToString();
                    dt.Rows[i]["Владелец"] += lastname.Remove(1, lastname.Length - 1);
                }
                
            }
            return dt;
        }
        public DataTable ShowClientTable()
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT * FROM Owner";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            dt.Columns.Add("Питомцы");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable pdt = FindPet(Int32.Parse(dt.Rows[i][0].ToString()));
                string pets = "";
                if (pdt.Rows.Count > 0)
                {
                    for (int y = 0; y < pdt.Rows.Count; y++)
                    {
                        pets += pdt.Rows[y][2].ToString()+" ";
                    }
                    dt.Rows[i]["Питомцы"] = pets;
                }

            }
            return dt;
        }
        public DataTable FindPet(int code)
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT * FROM Pet WHERE (Pet.Owner="+code+") AND (Pet.Status is null)";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            return dt;
        }
        public void AddPet(PetClass pet)
        {
            SqlCommand command = sqlconnection.CreateCommand();
            DataTable dt = GetCodeVocabulary("Kinds", "Kinds.CodeOfKind", pet.kind, "Kinds.Kind");
            int kind = Int32.Parse(dt.Rows[0]["CodeOfKind"].ToString());
            if ((pet.breed != "") && (pet.breed != null))
            {
                dt = GetCodeVocabulary("Breeds", "CodeOfBreed", pet.breed, "Name");
                int breed = Int32.Parse(dt.Rows[0]["CodeOfBreed"].ToString());
                command.CommandText = "INSERT INTO Pet (Date, Name, DateOfBirth, Gender, Kind, Breed, Castrade, Owner) VALUES (@date, @name, @dateOfBirth, @gender, @kind, @breed, @castrade, @owner)";
                command.Parameters.Add("Breed", SqlDbType.Int).Value = breed;
            }else
            {
                command.CommandText = "INSERT INTO Pet (Date, Name, DateOfBirth, Gender, Kind, Castrade, Owner) VALUES (@date, @name, @dateOfBirth, @gender, @kind, @castrade, @owner)";
            }
            command.Parameters.Add("Date", SqlDbType.Date).Value = DateTime.Now.Date;
            command.Parameters.Add("Name", SqlDbType.NVarChar).Value = pet.name;
            command.Parameters.Add("DateOfBirth", SqlDbType.Date).Value = pet.dateofbirth.Date;
            command.Parameters.Add("Gender", SqlDbType.Int).Value = pet.gender;
            command.Parameters.Add("Kind", SqlDbType.Int).Value = kind;
            command.Parameters.Add("Castrade", SqlDbType.Int).Value = pet.castrade;
            command.Parameters.Add("Owner", SqlDbType.Int).Value = pet.owner;
            sqlconnection.Open();
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запись была сохранена");
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к БД");
            }

            sqlconnection.Close();

        }

        public DataTable GetCodeVocabulary(string tablename, string name, string value, string columnname)
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT "+name+ " FROM "+tablename+" WHERE ("+columnname+" = '"+value+"')";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            return dt;
        }
        public ClientClass FindClient(int code)
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT * FROM Owner WHERE ( CodeOfClient= " + code + ")";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            ClientClass owner = new ClientClass(dt.Rows[0]["Name"].ToString(), dt.Rows[0]["Surname"].ToString(), dt.Rows[0]["Lastname"].ToString(), dt.Rows[0]["Address"].ToString(), dt.Rows[0]["Email"].ToString(), dt.Rows[0]["Phone"].ToString());
            return owner;
        }
        public void UpdateClient(int code, ClientClass owner)
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            if (owner.Lastname != null)
            {
                if (owner.Address != null)
                {
                    if (owner.Email != null)
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', LastName='" + owner.Lastname + "', Address='" + owner.Address + "', Email='" + owner.Email + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                    else
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', LastName='" + owner.Lastname + "', Address='" + owner.Address + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                }
                else
                {
                    if (owner.Email != null)
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', LastName='" + owner.Lastname + "', Email='" + owner.Email + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                    else
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', LastName='" + owner.Lastname + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                }
            }
            else
            {
                if (owner.Address != null)
                {
                    if (owner.Email != null)
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', Address='" + owner.Address + "', Email='" + owner.Email + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                    else
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', Address='" + owner.Address + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                }
                else
                {
                    if (owner.Email != null)
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', Email='" + owner.Email + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                    else
                    {
                        command.CommandText = "UPDATE Owner SET Surname='" + owner.Surname + "', Name='" + owner.Name + "', Phone='" + owner.Phone + "'  WHERE CodeOfClient=" + code;
                    }
                  
                }

            }
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Запись была обновлена");
            }
            catch
            {
                MessageBox.Show("Ошибка при подключении к БД");
            }
            finally
            {
                sqlconnection.Close();
            }
        }
        public string GetNameOfVocabularity(int code, string tablename, string column, string column2)
        {
            sqlconnection.Open();
            SqlCommand command = sqlconnection.CreateCommand();
            command.CommandText = "SELECT "+column+" FROM "+tablename+" Where ("+column2+"= " + code + ")"; 
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            try
            {
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при подключении к БД");
            }
            sqlconnection.Close();
            string result = dt.Rows[0][column].ToString();
            return result;
        }
        public void AddOwner(ClientClass client)
        {
            SqlCommand command = sqlconnection.CreateCommand();
            if (client.Lastname != null)
            {
                if (client.Address != null)
                {
                    if (client.Email != null)
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Lastname, Address, Email, Phone) VALUES (@name, @surname, @lastname,  @address, @email, @phone)";
                        command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = client.Lastname;
                        command.Parameters.Add("Address", SqlDbType.NVarChar).Value = client.Address;
                        command.Parameters.Add("Email", SqlDbType.NVarChar).Value = client.Email;
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Lastname, Address, Phone) VALUES (@name, @surname, @lastname,  @address, @phone)";
                        command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = client.Lastname;
                        command.Parameters.Add("Address", SqlDbType.NVarChar).Value = client.Address;
                    }
                }
                else
                {
                    if (client.Email != null)
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Lastname, Email, Phone) VALUES (@name, @surname, @lastname, @email, @phone)";
                        command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = client.Lastname;
                        command.Parameters.Add("Email", SqlDbType.NVarChar).Value = client.Email;
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Lastname, Phone) VALUES (@name, @surname, @lastname, @phone)";
                        command.Parameters.Add("LastName", SqlDbType.NVarChar).Value = client.Lastname;
                    }
                }
            }
            else
            {
                if (client.Address != null)
                {
                    if (client.Email != null)
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Address, Email, Phone) VALUES (@name, @surname, @address, @email, @phone)";
                        command.Parameters.Add("Address", SqlDbType.NVarChar).Value = client.Address;
                        command.Parameters.Add("Email", SqlDbType.NVarChar).Value = client.Email;
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Address, Phone) VALUES (@name, @surname,  @address, @phone)";
                        command.Parameters.Add("Address", SqlDbType.NVarChar).Value = client.Address;
                    }
                }
                else
                {
                    if (client.Email != null)
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Email, Phone) VALUES (@name, @surname, @email, @phone)";
                        command.Parameters.Add("Email", SqlDbType.NVarChar).Value = client.Email;
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Owner (Name, Surname, Phone) VALUES (@name, @surname, @phone)";
                    }
                }
            }
                command.Parameters.Add("Name", SqlDbType.NVarChar).Value = client.Name;
                command.Parameters.Add("Surname", SqlDbType.NVarChar).Value = client.Surname;
                command.Parameters.Add("Phone", SqlDbType.NVarChar).Value = client.Phone;
                sqlconnection.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись была сохранена");
                }
                catch
                {
                    MessageBox.Show("Ошибка при подключении к БД");
                }

                sqlconnection.Close();
            }
        }
    }

