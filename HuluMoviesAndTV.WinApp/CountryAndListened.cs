using HuluMoviesAndTV.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Country country = new Country
            {
                Name = CountrytextBox.Text
            };

            AddCountry(country);
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
                Guid ratingId = (Guid)CountriesdataGridView.SelectedRows[0].Cells["Id"].Value;
                string newName = CountrytextBox.Text;

                UpdateCountry(ratingId, newName);
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
            Listened listened = new Listened
            {
                Name = ListenedtextBox.Text
            };

            AddListened(listened);
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

                UpdateListened(listenedId, newName);
            }
        }
    }
}
