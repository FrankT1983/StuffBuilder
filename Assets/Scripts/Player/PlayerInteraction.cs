using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {
    static public float InteractionRange = 1.0f;

    public PlayerMovement FacingSource;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            this.TryInteraction();
        }
    }

    private void TryInteraction()
    {
        var obj = FindInteractionObject();
        if (obj == null) return;
        obj.Interact();
    }

    private InteractableObject FindInteractionObject()
    {
        if (FacingSource == null) return null;
        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, this.FacingSource.Facing);
        Debug.DrawLine(transform.position, (Vector2)transform.position + this.FacingSource.Facing.normalized * InteractionRange, Color.red, InteractionRange);
        if (hits!= null)
        {
            foreach(var h in hits)
            {
                var gameObject = h.transform.gameObject;                
                if (gameObject == this.gameObject) continue;
                if (gameObject == null) continue;

                var inter= gameObject.GetComponent(typeof(InteractableObject)) as InteractableObject;
                if (inter == null) continue;
                inter.Interact();                
            }            
        }
        return null;

    }
}
