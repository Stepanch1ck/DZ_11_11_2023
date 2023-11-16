

namespace BIGRACES
{
    internal class Team
    {
        private readonly string name;
        private readonly int membersCount;
        private int score = 0;

        public Team(string name, int membersCount)
        {
            this.name = name;
            this.membersCount = membersCount;
        }
        public string Name
        {
            get { return name; }
        }
        public int MembersCount
        {
            get { return membersCount; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public void AddScore(int score)
        {
            this.score += score;
        }
    }
}
