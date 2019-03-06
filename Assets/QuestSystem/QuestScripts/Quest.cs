namespace QuestSystem
{
    public class Quest
    {

        //Name
        //DescriptionSummary
        //Quest Hint
        //Quest Dialogue
        //SourceID
        //QuestID
        //ChainQuest and then quest is blank
        //ChainQuestID
        private IQuestInformation information;
        public IQuestInformation Information
        {
            get { return information; }
        }


        //Objectives
        //Bonus Objectives
        //Rewards
        //Events
            //OnCompletion
            //OnFail
            //OnUpdate

    }
}