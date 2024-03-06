using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : Interactab
{
    public Item item;

    public override void Interact()
    {
        base.Interact();
        PickUp();
    }
    private void PickUp()
    {
        Debug.Log("Picking up" + item.name);
        bool wasPickedUp = Inventory.Instance.Add(item);

        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
       
    }
}
