using System.Collections;
using QuestSystem;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        IQuestObjective qo = new CollectionObjective("Gather", 10, item, "Gather 10 meath!", false);
        Debug.Log(qo.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
