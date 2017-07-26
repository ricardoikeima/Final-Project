using FinalProject.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class AddTeam : Form
    {
        public AddTeam()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String division = txtDivision.Text;
            SoccerTeam team = new SoccerTeam(name, division);

            try
            {
                SoccerTeamDB db = new SoccerTeamDB();

                int result = db.addTeam(team);

                if (result > 0)
                {
                    MessageBox.Show(name + " added successfully. Add Another Team?", "Add Team", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    txtName.Text = "";
                    txtDivision.Text = "";
                }
                else
                {
                    MessageBox.Show("Team cannot be added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private bool findTeam()
        {
            bool result = false;

            SoccerTeamDB db = new SoccerTeamDB();

            return result;
        }
    }
}
