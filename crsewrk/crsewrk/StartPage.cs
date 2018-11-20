using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crsewrk
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void QuizPage_Click(object sender, EventArgs e)
        {
            QuizPage quizPage = new QuizPage();
            quizPage.ShowDialog(); 
        }
    }
}
