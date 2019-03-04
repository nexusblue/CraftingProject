using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag )
            case Inventory.ResourceItem.WOOD:
                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().wood++;
                break;
            case Inventory.ResourceItem.STONE:
                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().stone++;
                break;
            case Inventory.ResourceItem.TWINE:
                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().twine++;
                break;

        //Destroy(gameObject);
    }

}
