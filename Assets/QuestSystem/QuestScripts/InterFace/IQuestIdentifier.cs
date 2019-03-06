﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem
{
    public interface IQuestIdentifier
    {
        int ID { get; }
        int ChainQuestID { get; }
        int SourceID { get; }

    }
}
