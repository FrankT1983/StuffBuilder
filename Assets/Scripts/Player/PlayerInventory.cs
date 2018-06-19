using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour {

    public Inventory PlayerInventor = null;

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("i"))
        {
            if (PlayerInventor != null)
            {
                PlayerInventor.ToggleVisibility();
            }
        }
    }
}
