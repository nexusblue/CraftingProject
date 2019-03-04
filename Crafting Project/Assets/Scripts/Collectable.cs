using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public Inventory.ResourceItem resourceType ;

    private void OnMouseDown()
    {
        switch (resourceType) {
            case Inventory.ResourceItem.WOOD:
                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().wood++;
                break;
            case Inventory.ResourceItem.STONE:
                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().stone++;
                break;
            case Inventory.ResourceItem.TWINE:
                GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().twine++;
                break;


        }


    }



}
