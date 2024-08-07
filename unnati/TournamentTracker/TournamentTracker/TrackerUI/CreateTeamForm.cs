using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.getPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            //createSampleData();

            WireUpLists();
        }



        private void createSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Rohan", LastName = "More" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Vishu", LastName = "Dabhole" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Rugved", LastName = "Parit" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Disha", LastName = "Parit" });
        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;
            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel(
                    firstNameLabelValue.Text,
                    lastNameLabelValue.Text,
                    emailLabelValue.Text,
                    cellphoneLabelValue.Text);

                p = GlobalConfig.Connection.createPerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                firstNameLabelValue.Text = "";
                lastNameLabelValue.Text = "";
                emailLabelValue.Text = "";
                cellphoneLabelValue.Text = "";


            }
            else
            {
                MessageBox.Show("Fill all details correctly");
            }
        }

        private bool ValidateForm()
        {
            if (firstNameLabelValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameLabelValue.Text.Length == 0)
            {
                return false;
            }
            if (emailLabelValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneLabelValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem!;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem!;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.createTeam(t);

            callingForm.TeamComplete(t);

            this.Close();

        }
    }
}
