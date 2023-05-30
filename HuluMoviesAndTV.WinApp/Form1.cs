using HuluMoviesAndTV.Core.Context;
using HuluMoviesAndTV.Core.Entity;
using HuluMoviesAndTV.Repositories;

namespace HuluMoviesAndTV.WinApp
{
    public partial class Form1 : Form
    {
        private Repository<ProgramType, Guid> programTypeRepository;
        private Repository<Director, Guid> directorRepository;

        public Form1()
        {
            InitializeComponent();
            programTypeRepository = new Repository<ProgramType, Guid>(new MoviesAndShowsContext());
            directorRepository = new Repository<Director, Guid>(new MoviesAndShowsContext());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProgramTypes();
            LoadProgramDirectors();
        }

        private void LoadProgramTypes()
        {
            var programTypes = programTypeRepository.GetAll();
            TypedataGridView.DataSource = programTypes;
            TypedataGridView.Columns["MovieAndShows"].Visible = false;
        }
        private void LoadProgramDirectors()
        {
            var directors = directorRepository.GetAll();
            DirectordataGridView.DataSource = directors;
            DirectordataGridView.Columns["MovieAndShows"].Visible = false;
        }
    }
}
