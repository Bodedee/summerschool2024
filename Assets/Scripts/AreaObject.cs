using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaObject : MonoBehaviour
{
    public string areaName = "n/a";
    public int areaIndex = 0;
    public Sprite defaultImage;
    public List<object> ListOfEncounters = new List<object>();
    public int currentEncounter = 0;

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
     public bool StartEncounter()
    {
        return true;
        //return ListOfEncounters<object>;
        // instinate an object from listOfEncounters
    }
    public bool EndEncounter()
    {
        return true;
        // delete object spawned above
        
    }
}

