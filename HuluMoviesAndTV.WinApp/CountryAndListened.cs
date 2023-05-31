using HuluMoviesAndTV.Core.Entity;
using System.Text.RegularExpressions;

namespace HuluMoviesAndTV.WinApp
{
    public partial class Form1 : Form
    {
        private void LoadCountry()
        {
            var country = countryRepository.GetAll();
            CountriesdataGridView.DataSource = country;
            CountriesdataGridView.Columns["MovieAndShows"].Visible = false;
            CountriesdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void LoadListened()
        {
            var listened = listenedRepository.GetAll();
            ListeneddataGridView.DataSource = listened;
            ListeneddataGridView.Columns["MovieAndShows"].Visible = false;
            ListeneddataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void AddCountry(Country country)
        {
            countryRepository.Create(country);
            countryRepository.Save();
            LoadCountry();
        }
        private void AddCountrybutton_Click(object sender, EventArgs e)
        {
            string countryName = CountrytextBox.Text;

            if (IsValidText(countryName))
            {
                Country country = new Country
                {
                    Name = countryName
                };

                AddCountry(country);
                LoadCountryComboBox();
            }
            else
            {
                MessageBox.Show("Country name should only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DeleteCountry(Guid countryId)
        {
            Country country = countryRepository.Get(countryId);
            if (country != null)
            {
                countryRepository.Delete(country);
                countryRepository.Save();
                LoadCountry(); 
            }
        }
        private void DeleteCountrybutton_Click(object sender, EventArgs e)
        {
            if (CountriesdataGridView.SelectedRows.Count > 0)
            {
                Guid countryId = (Guid)CountriesdataGridView.SelectedRows[0].Cells["Id"].Value;
                DeleteCountry(countryId);
                LoadCountryComboBox();
            }
        }

        private void UpdateCountry(Guid countryId, string newName)
        {
            Country country = countryRepository.Get(countryId);
            if (country != null)
            {
                country.Name = newName;
                countryRepository.Update(country);
                countryRepository.Save();
                LoadCountry();
            }
        }
        private void UpdateCountrybutton_Click(object sender, EventArgs e)
        {
            if (CountriesdataGridView.SelectedRows.Count > 0)
            {
                Guid countryId = (Guid)CountriesdataGridView.SelectedRows[0].Cells["Id"].Value;
                string newName = CountrytextBox.Text;

                if (IsValidText(newName))
                {
                    UpdateCountry(countryId, newName);
                    LoadCountryComboBox();
                }
                else
                {
                    MessageBox.Show("Country name should only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AddListened(Listened listened)
        {
            listenedRepository.Create(listened);
            listenedRepository.Save();
            LoadListened();
        }
        private void AddListenedbutton_Click(object sender, EventArgs e)
        {
            string listenedName = ListenedtextBox.Text;

            if (IsValidText(listenedName))
            {
                Listened listened = new Listened
                {
                    Name = listenedName
                };

                AddListened(listened);
                LoadListenedComboBox();
            }
            else
            {
                MessageBox.Show("Listened name should only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteListened(Guid listenedId)
        {
            Listened listened = listenedRepository.Get(listenedId);
            if (listened != null)
            {
                listenedRepository.Delete(listened);
                listenedRepository.Save();
                LoadListened();
            }
        }
        private void DeleteListenedbutton_Click(object sender, EventArgs e)
        {
            if (ListeneddataGridView.SelectedRows.Count > 0)
            {
                Guid listenedId = (Guid)ListeneddataGridView.SelectedRows[0].Cells["Id"].Value;
                DeleteListened(listenedId);
                LoadListenedComboBox();
            }
        }

        private void UpdateListened(Guid listenedId, string newName)
        {
            Listened listened = listenedRepository.Get(listenedId);
            if (listened != null)
            {
                listened.Name = newName;
                listenedRepository.Update(listened);
                listenedRepository.Save();
                LoadListened(); 
            }
        }
        private void UpdateListenedbutton_Click(object sender, EventArgs e)
        {
            if (ListeneddataGridView.SelectedRows.Count > 0)
            {
                Guid listenedId = (Guid)ListeneddataGridView.SelectedRows[0].Cells["Id"].Value;
                string newName = ListenedtextBox.Text;

                if (IsValidText(newName))
                {
                    UpdateListened(listenedId, newName);
                    LoadListenedComboBox();
                }
                else
                {
                    MessageBox.Show("Listened name should only contain letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsValidText(string text)
        {
            return !string.IsNullOrWhiteSpace(text) && Regex.IsMatch(text, @"^[A-Za-z]+$");
        }
    }
}
