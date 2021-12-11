namespace GameLogic
{
    public class Player
    {
        private readonly char r_Mark;
        private int m_Points;
        private readonly bool r_IsHuman;

        public Player(char i_Mark, bool i_IsHuman)
        {
            r_Mark = i_Mark;
            r_IsHuman = i_IsHuman;
            m_Points = 0;
        }

        public char Mark
        {
            get
            {
                return r_Mark;
            }
        }

        public int Points
        {
            get
            {
                return m_Points;
            }
            set
            {
                m_Points = value;
            }
        }

        public bool IsHuman
        {
            get
            {
                return r_IsHuman;
            }
        }
    }
}