using System.Collections;
using UnityEngine;

namespace QuestSystem
{
    public class CollectionObjective : IQuestObjective
    {
        private string title;
        private string description;
        private bool isComplete;
        private bool isBonus;
        private string verb;
        private int collectionAmount; //total amount we need
        private int currentAmount;  //starts at 0
        private GameObject itemToCollection;
        /// <summary>
        /// This constructor builds a collection objective
        /// </summary>
        /// <param name="titleVerb"> Describes the type of collection</param>
        /// <param name="totalAmount">Amount required to complete objective</param>
        /// <param name="item">Item to be collected</param>
        /// <param name="descrip">Describes what will  be collected</param>
        /// <param name="bonus">Is this a bonus objective?</param>
        public CollectionObjective(string titleVerb, int totalAmount, GameObject item, string descrip, bool bonus)
        {
            title = titleVerb + " " + totalAmount + " " + item.name;
            description = descrip;
            itemToCollection = item;
            collectionAmount = totalAmount;
            currentAmount = 0;
            isBonus = bonus;
            CheckProgress();
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Description
        {
            get
            {
                return Description;
            }
        }
        public int CollectionAmount
        {
            get
            {
                return collectionAmount;
            }
        }
        public int CurrentAmount
        {
            get
            {
                return currentAmount;
            }
        }
        public GameObject ItemToCollection
        {
            get
            {
                return itemToCollection;
            }
        }

        public bool IsComplete
        {
            get
            {
                return isComplete;
            }
        }

        public bool IsBonus
        {
            get
            {
                return isBonus;
            }
        }

        public void CheckProgress()
        {
            if (currentAmount >= collectionAmount)
            {
                isComplete = true;
            }
            else
            {
                isComplete = false;
            }

        }


        public void UpdateProgress()
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            return currentAmount + "/" + collectionAmount + " " + itemToCollection.name + " " + verb + "ed";
        }
    }
}