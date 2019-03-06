using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem
{
    public class QuestIdentifier : IQuestIdentifier
    {
        int sourceID;
        int chainQuestID;
        int id;
        public int ID
        {
            get
            {
                return id;
            }
        }

        public int ChainQuestID
        {
            get
            {
                return chainQuestID;
            }
        }

        public int SourceID
        {
            get
            {
                return sourceID;
            }
        }
    }
}
