using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlWithCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"YoureConnectionString");
            void Listele()
            {
                connection.Open();
                SqlCommand command1 = new SqlCommand("Select * From Customer", connection); //Sorgu Yazmak için gerekli olan komut
                SqlDataReader reader = command1.ExecuteReader(); // Reader ile okunan değerleri hafızaya al
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }

                connection.Close();
            }
            void Ekle()
            {
                connection.Open();
                SqlCommand command2 = new SqlCommand("Insert into Customer (Name, City, Country) values (@n, @cty, @cntry)", connection);
                command2.Parameters.AddWithValue("@n", "Saliha Güven");
                command2.Parameters.AddWithValue("@cty", "Tokyo");
                command2.Parameters.AddWithValue("@cntry", "Jponya");
                command2.ExecuteNonQuery();
                connection.Close();
            }
            void Sil()
            {
                connection.Open();
                SqlCommand command3 = new SqlCommand("Delete From Customer Where CustomerId=@p", connection);
                command3.Parameters.AddWithValue("@p", 7);
                command3.ExecuteNonQuery();
                connection.Close();
            }
            void Guncelle()
            {
                connection.Open();
                SqlCommand command4 = new SqlCommand("Update Customer Set Name=@p1, City=@p2, Country=@p3 where CustomerId=@p4",connection);
                command4.Parameters.AddWithValue("@p1","Ecrin Mina Er");
                command4.Parameters.AddWithValue("@p2", "Varşova");
                command4.Parameters.AddWithValue("@p3", "Rusya");
                command4.Parameters.AddWithValue("@p4", 3);
                command4.ExecuteNonQuery();
                connection.Close();
            }
            void KlavyedenEkle()
            {
                string name, city, country;
                Console.Write("Kişi Ad Soyad:");
                name = Console.ReadLine();
                Console.Write("Şehir:");
                city = Console.ReadLine();
                Console.Write("Ülke:");
                country = Console.ReadLine();

                connection.Open();
                SqlCommand command5 = new SqlCommand("Insert into Customer(Name,City,Country) values(@p1,@p2,@p3)", connection);
                command5.Parameters.AddWithValue("@p1", name);
                command5.Parameters.AddWithValue("@p2", city);
                command5.Parameters.AddWithValue("@p3", country);
                command5.ExecuteNonQuery();
                connection.Close();
            }
            void Arama()
            {
                connection.Open();
                SqlCommand command6 = new SqlCommand("Select * From Customer Where City=@p1",connection);
                Console.Write("Aranacak Şehir: ");
                string city= Console.ReadLine();
                command6.Parameters.AddWithValue("@p1",city);
                SqlDataReader column = command6.ExecuteReader();
                while (column.Read()) 
                {
                    Console.WriteLine(column[0] + " " + column[1]+" "+ column[2]+" " + column[3]);
                }

                connection.Close();
            }
            void CustomerCount()
            {
                connection.Open();
                SqlCommand command7 = new SqlCommand("Select Count(*) From Customer", connection);
                SqlDataReader reader3=command7.ExecuteReader();
                while (reader3.Read())
                    Console.WriteLine("Toplam Müşteri Sayısı: " + reader3[0]);
                {
                }
                connection.Close();
            }
            void OrtalamaOrder()
            {
                connection.Open();
                SqlCommand command8 = new SqlCommand("Select Avg(UnitPrice) From [Order]", connection);
                SqlDataReader reader4=command8.ExecuteReader();
                while(reader4.Read())
                {
                    Console.WriteLine("Ortalama Sipariş Tutarı: "+reader4[0]);
                }
                connection.Close();
            }
            void GroupBy()
            {
                connection.Open();
                SqlCommand command6 = new SqlCommand("Select City,Count(*) From Customer group by City order by Count(*)",connection);
                SqlDataReader reader5 =command6.ExecuteReader();
                while (reader5.Read())
                {
                    Console.WriteLine(reader5[0]+ " |  "+ reader5[1]);
                }
                connection.Close();
            }
            void JoinSorgu()
            {
                connection.Open();
                SqlCommand command10 = new SqlCommand("Select ProductId as 'Ürün Id',CategoryName as 'Kategori Adı' From Product \r\ninner Join Category On Product.CategoryId=Category.CategoryId", connection);
                SqlDataReader reader7=command10.ExecuteReader();
                while( reader7.Read())
                {
                    Console.WriteLine(reader7[0]+" "+ reader7[1]);
                }
                connection.Close();
            }
            
            JoinSorgu();
            Console.WriteLine("************");
            Listele();
            Console.ReadLine();

        }
    }
}
// Data Source=BPODSHGM74\MSSQLSERVER2025;Initial Catalog=DbVisit;Integrated Security=True;Trust Server Certificate=True