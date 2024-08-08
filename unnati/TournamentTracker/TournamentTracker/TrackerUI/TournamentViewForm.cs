using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewForm : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedMatchups = new List<MatchupModel>();

        public TournamentViewForm(TournamentModel tournamentModel)
        {
            InitializeComponent();

            tournament = tournamentModel;

            LoadFormData();

            LoadRounds();
        }

        private void LoadFormData()
        {
            TournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            roundDropDown.DataSource = null;
            roundDropDown.DataSource = rounds;

            MatchupListBox.DataSource = null;
            MatchupListBox.DataSource = selectedMatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }

        private void LoadRounds()
        {
            rounds = new List<int>();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            WireUpLists();
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
