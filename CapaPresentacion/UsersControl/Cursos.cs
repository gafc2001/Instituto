using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
namespace CapaPresentacion.UsersControl
{
    public partial class Cursos : UserControl
    {
        private int _id;
        private string _imageFile;
        private string _curso;
        private string _profesor;
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string ImageFile
        {
            get { return this._imageFile; }
            set { this._imageFile = value; }
        }
        public string Curso
        {
            get { return this._curso; }
            set { this._curso = value; }
        }
        public string Profesor
        {
            get { return this._profesor; }
            set { this._profesor = value; }
        }
        public Cursos(int id,string curso, string profesor, string imageFile)
        {
            InitializeComponent();
            this._id = id;
            this._imageFile = imageFile;
            this._curso = curso;
            this._profesor = profesor;
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            var image = (Bitmap)Properties.Resources.ResourceManager.GetObject(_imageFile);
            imgcurso.Image = image;
            lblcurso.Text = this._curso;
            lblprofesor.Text = this._profesor;
        }
    }
}
