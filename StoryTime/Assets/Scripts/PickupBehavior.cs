using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
   public ID pickupID;

   public void OnTriggerEnter(Collider other)
   {
      if (other.TryGetComponent(out CarryBehavior carry))
      {
         carry.PickUp(this);
      }
   }
}
