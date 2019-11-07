using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WPF_ZooManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["WPF_ZooManager.Properties.Settings.FabioCsharpDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowZoos();
            ShowAnimals();

        }

        private void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();

                    sqlDataAdapter.Fill(zooTable);

                    //Which Information of the Table in DataTable should be shown in our ListBox?
                    listZoos.DisplayMemberPath = "Location";
                    //Which Value should be delivered, when an Item from our ListBox is selected?
                    listZoos.SelectedValuePath = "Id";
                    //The Reference to the Data the Listbox, should populate
                    listZoos.ItemsSource = zooTable.DefaultView;
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ShowAnimals()
        {
            try
            {
                string query = "select * from Animal";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable animalTable = new DataTable();
                    sqlDataAdapter.Fill(animalTable);
                    listAnimals.DisplayMemberPath = "Name";
                    listAnimals.SelectedValuePath = "Id";
                    listAnimals.ItemsSource = animalTable.DefaultView;
                }
            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ShowAssociatedAnimals()
        {
            try
            {
                string query = "select * from Animal a inner join ZooAnimal " +
                    "za on a.Id = za.AnimalId where za.ZooId = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                // the SqlDataAdapter can be imagined like an Interface to make Tables usable by C#-Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {

                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);

                    DataTable animalTable = new DataTable();

                    sqlDataAdapter.Fill(animalTable);

                    //Which Information of the Table in DataTable should be shown in our ListBox?
                    listAssociatedAnimals.DisplayMemberPath = "Name";
                    //Which Value should be delivered, when an Item from our ListBox is selected?
                    listAssociatedAnimals.SelectedValuePath = "Id";
                    //The Reference to the Data the Listbox, should populate
                    listAssociatedAnimals.ItemsSource = animalTable.DefaultView;
                }
            } catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void listZoos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(listZoos.SelectedValue.ToString());
            if (listZoos.SelectedIndex != null)
            {
                ShowAssociatedAnimals();
                ShowSelectedZooInTextBox();
            }
        }

        private void listAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MessageBox.Show(listZoos.SelectedValue.ToString());
            if (listAnimals.SelectedIndex != null)
            {
                ShowSelectedAnimalInTextBox();
            }
        }

        private void updateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Animal set Name = @Name where Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Name", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ShowAnimals();
                sqlConnection.Close();
            }
        }

        private void updateZoo_Click(object sender, RoutedEventArgs e )
        {
            try
            {
                string query = "update Zoo Set Location = @Location where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                ShowZoos();
                sqlConnection.Close();
            }
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string query = "delete from Zoo where id = @ZooId";

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.ExecuteScalar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void deleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                sqlConnection.Close();
                ShowAnimals();
            }
        }
        private void removeAnimalFromZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete za from ZooAnimal za " +
                    " inner join Animal a on za.AnimalId = a.Id " +
                    " inner join Zoo z on z.Id = za.ZooId " +
                    " where za.AnimalId = @AnimalId and za.ZooId = @ZooId ";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAssociatedAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@ZooId", listAssociatedAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }
        }

        private void ShowSelectedAnimalInTextBox()
        {
            string query = "select name from Animal where Id = @AnimalId";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            // the SqlDataAdapter can be imagined like an interface to make tables usable by c#-Objects
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            try
            {
                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                    DataTable animalDataTable = new DataTable();
                    sqlDataAdapter.Fill(animalDataTable);
                    myTextBox.Text = animalDataTable.Rows[0]["Name"].ToString();
                }
            } catch (Exception e )
            {
                // MessageBox.Show(e.ToString());
            }
        }



        private void ShowSelectedZooInTextBox()
        {
            try
            {
                string query = "select location from Zoo where Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                // the SqlDataAdapter can be imagined like an interface to make tables usable by c#-Objects
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                    DataTable zooDataTable = new DataTable();
                    sqlDataAdapter.Fill(zooDataTable);
                    myTextBox.Text = zooDataTable.Rows[0]["Location"].ToString();
                }
            } catch ( Exception e )
            {
                // MessageBox.Show(e.ToString());
            }
        }


        private void addAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal values(@Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } finally
            {
                sqlConnection.Close();
                ShowAnimals();
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo values (@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", myTextBox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void addAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into ZooAnimal values (@ZooId, @AnimalId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoos.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedAnimals();
            }
        }

    }
}
