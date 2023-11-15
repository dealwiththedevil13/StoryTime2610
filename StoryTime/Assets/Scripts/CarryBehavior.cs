using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryBehavior : MonoBehaviour
{
    public ID placedID;
    public GameObject heldObject;

    public void PickUp(PickupBehavior pickup)
    {
        if(pickup.pickupID.id == placedID.id)
        {
            heldObject = pickup.gameObject;
            heldObject.transform.parent = transform; 
        }
    }
  
    public void Release()
    {
        if(heldObject != null)
        {
            heldObject.transform.parent = null;
            heldObject = null;
        }
    }
}
