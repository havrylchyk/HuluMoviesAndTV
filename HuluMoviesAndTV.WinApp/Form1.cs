using HuluMoviesAndTV.Core.Context;
using HuluMoviesAndTV.Core.Entity;
using HuluMoviesAndTV.Repositories;

namespace HuluMoviesAndTV.WinApp
{
    public partial class Form1 : Form
    {
        private Repository<ProgramType, Guid> programTypeRepository;
        private Repository<Director, Guid> directorRepository;
        private Repository<Rating, Guid> ratingRepository;
        private Repository<ReleaseYear, Guid> releaseYearRepository;

        public Form1()
        {
            InitializeComponent();
            programTypeRepository = new Repository<ProgramType, Guid>(new MoviesAndShowsContext());
            directorRepository = new Repository<Director, Guid>(new MoviesAndShowsContext());
            ratingRepository = new Repository<Rating, Guid>(new MoviesAndShowsContext());
            releaseYearRepository = new Repository<ReleaseYear, Guid>(new MoviesAndShowsContext());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProgramTypes();
            LoadProgramDirectors();
            LoadRating();
            LoadReleaseYear();
        }
        //Заповнення даних//
        private void LoadProgramTypes()
        {
            var programTypes = programTypeRepository.GetAll();
            TypedataGridView.DataSource = programTypes;
            TypedataGridView.Columns["MovieAndShows"].Visible = false;
            TypedataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void LoadProgramDirectors()
        {
            var directors = directorRepository.GetAll();
            DirectordataGridView.DataSource = directors;
            DirectordataGridView.Columns["MovieAndShows"].Visible = false;

            DirectordataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DirectordataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            foreach (DataGridViewColumn column in DirectordataGridView.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            DirectordataGridView.ScrollBars = ScrollBars.Vertical;
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        //Додаванн, редагування та видалення Type//
        private void AddProgramType(ProgramType programType)
        {
            programTypeRepository.Create(programType);
            programTypeRepository.Save();
            LoadProgramTypes();
        }
        private void AddTypebutton_Click(object sender, EventArgs e)
        {
            ProgramType newProgramType = new ProgramType
            {
                Name = NameOfType.Text
            };

            AddProgramType(newProgramType);
        }

        private void DeleteType(Guid programTypeId)
        {
            ProgramType programType = programTypeRepository.Get(programTypeId);
            if (programType != null)
            {
                programTypeRepository.Delete(programType);
                programTypeRepository.Save();
                LoadProgramTypes();
            }
        }
        private void DeleteTypebutton_Click(object sender, EventArgs e)
        {
            if (TypedataGridView.SelectedRows.Count > 0)
            {
                Guid programTypeId = (Guid)TypedataGridView.SelectedRows[0].Cells["Id"].Value;
                DeleteType(programTypeId);
            }
        }

        private void UpdateType(Guid programTypeId, string newName)
        {
            ProgramType programType = programTypeRepository.Get(programTypeId);
            if (programType != null)
            {
                programType.Name = newName;
                programTypeRepository.Update(programType);
                programTypeRepository.Save();
                LoadProgramTypes();
            }
        }
        private void UpdateTypebutton_Click_1(object sender, EventArgs e)
        {
            if (TypedataGridView.SelectedRows.Count > 0)
            {
                Guid programTypeId = (Guid)TypedataGridView.SelectedRows[0].Cells["Id"].Value;
                string newName = NameOfType.Text;

                UpdateType(programTypeId, newName);
            }
        }
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~//
        //Додаванн, редагування та видалення Director//
        private void AddDirector(Director director)
        {
            directorRepository.Create(director);
            directorRepository.Save();
            LoadProgramDirectors();
        }
        private void AddDirectorbutton_Click(object sender, EventArgs e)
        {
            Director director = new Director
            {
                Name = DirectortextBox.Text
            };

            AddDirector(director);
        }

        private void UpdateDirector(Guid directorId, string newName)
        {
            Director director = directorRepository.Get(directorId);
            if (director != null)
            {
                director.Name = newName;
                directorRepository.Update(director);
                directorRepository.Save();
                LoadProgramDirectors();
            }
        }
        private void UpdateDirectorbutton_Click(object sender, EventArgs e)
        {
            if (DirectordataGridView.SelectedRows.Count > 0)
            {
                Guid directorId = (Guid)DirectordataGridView.SelectedRows[0].Cells["Id"].Value;
                string newName = DirectortextBox.Text;

                UpdateDirector(directorId, newName);
            }
        }

        private void DeleteDirector(Guid directorId)
        {
            Director director = directorRepository.Get(directorId);
            if (director != null)
            {
                directorRepository.Delete(director);
                directorRepository.Save();
                LoadProgramDirectors();
            }
        }
        private void DeleteDirectorbutton_Click(object sender, EventArgs e)
        {
            if (DirectordataGridView.SelectedRows.Count > 0)
            {
                Guid directorId = (Guid)DirectordataGridView.SelectedRows[0].Cells["Id"].Value;
                DeleteDirector(directorId);
            }
        }
    }
}