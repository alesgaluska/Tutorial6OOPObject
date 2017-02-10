using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial6OOPObject
{
    public partial class Form1 : Form
    {
        int cislo;
        Student student1;
        List<Student> students;
        public Form1()
        {
            InitializeComponent();

           students = StudentsGen.GetStudents(100);
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            txtStudents.Clear();  //Smazu text v textboxu, aby jsem do nej mohl nahrat novy text

            int vekOmezeni;     //Definuji promennou ktera rika jak maximalne stare studenty zobrazim
            if (int.TryParse(txtAgeFilter.Text, out vekOmezeni) == true)  //Tahle podminka overi jestli v textBoxu je cislo a pokud ne vubec nezobrazim zadne studenty
            {
                foreach (Student student in students)       //Projdu všechny studenty
                {
                    if (student.vek <= vekOmezeni) // Pokud vek studenta je mensi nez to co bylo napsane v textboxu zobrazim jmeno
                        txtStudents.Text = txtStudents.Text + Environment.NewLine + "Vek: " + student.vek + " " + student.jmeno + " " + student.prijmeni;
                }
            }
            else
            {
                MessageBox.Show("Omezení nelze převést na int(číslo)");
            }
        }
    }
}
