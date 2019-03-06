namespace QuestSystem
{
    public interface IQuestInformation
    {
        string Name { get; }
        string DescriptionSummary { get; }
        string Hint { get; }
        string Dialog { get; }
        int SourceID { get; }
        int ChainQuestID { get; }
        int QuestID { get; }

    }

}
//Name
//DescriptionSummary
//Quest Hint
//Quest Dialogue
//SourceID
//QuestID
//ChainQuest and then quest is blank
//ChainQuestID
//Objectives
//Bonus Objectives
//Rewards
//Events
//OnCompletion
//OnFail
//OnUpdate
