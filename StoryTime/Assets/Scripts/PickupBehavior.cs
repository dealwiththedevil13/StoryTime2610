using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickupBehavior : MonoBehaviour
{
  public ID pickupID;
  
    public UnityEvent onPickup;
  
    private void OnTriggerEnter(Collider other)
    {
      if(other.TryGetComponent(out Carry carry))
      {
        if(carry.placedID == pickupID)
        {
          carry.PickUp(this);
          onPickup.Invoke();
        }
      }
    }
  }

  public class Carry : MonoBehaviour
  {
    public ID placedID;
  
    public void PickUp(PickupBehavior pickup)
    {
      // Pick up logic
    }
  }
