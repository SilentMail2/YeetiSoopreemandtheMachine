namespace QuestSystem {


    public class QuestInformation : IQuestInformation
    {
        private string name;
        private string descriptionSummary;
        private string hint;
        private string dialog;
        private int questID;
        private int chainQuestID;
        private int sourceID;




        public string Name
        {
            get
            {
                return name;
            }
        }

        public string DescriptionSummary
        {
            get
            {
                return descriptionSummary;
            }
        }

        public string Hint
        {
            get
            {
                return hint;
            }
        }

        public string Dialog
        {
            get
            {
                return dialog;
            }
        }

        public int SourceID
        {
            get
            {
                return sourceID;
            }
        }

        public int ChainQuestID
        {
            get
            {
                return chainQuestID;
            }
        }

        public int QuestID
        {
            get
            {
                return questID;
            }
        }
    }
}

