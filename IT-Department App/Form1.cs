using Microsoft.VisualBasic.Logging;
using System.Data;

namespace IT_Department_App
{
    public partial class authWindows : Form
    {
        
        public authWindows()
        {
            InitializeComponent();      
        }


        private void enterButon_Click(object sender, EventArgs e)
        {
            AuthWithDB authWithDB = new AuthWithDB();
            authWithDB.authWithDb();
            
        }
    }

}