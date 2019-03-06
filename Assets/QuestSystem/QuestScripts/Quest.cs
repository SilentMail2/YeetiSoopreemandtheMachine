using System.Collections.Generic;
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
        public Quest ()
        {

        }



        //Objectives
        private List<IQuestObjective> objectives;

        //CollectionObjective
        //Collect 4 feathers
        //Kill 4 Enemy types
        //Location Objective
        //go from point A to B
        //Timed you have 10 mins to get to point B from A


        //Bonus Objectives

        //Rewards

        //Events
        //OnCompletion
        //OnFail
        //OnUpdate
        private bool IsCompleted()
        {
            for (int i = 0; i < objectives.Count; i++)
            {
                if (!objectives[i].IsComplete && !objectives[i].IsBonus)
                {
                    return false;
                }
            }
            return true; //get reward/storyprogression
        }
        
    }
}