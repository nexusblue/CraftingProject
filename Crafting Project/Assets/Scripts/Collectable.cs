using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    //go to resource script for the enum resource
    public Inventory.ResourceItem resourceType ;

    //GameObject InvenTag = GameObject.FindGameObjectWithTag("Inventory");
    /*
    private void OnMouseDown()
    {
        switch (resourceType) {
            case Inventory.ResourceItem.WOOD:
                InvenTag.GetComponent<Inventory>().wood++;
                break;
            case Inventory.ResourceItem.STONE:
                InvenTag.GetComponent<Inventory>().stone++;
                break;
            case Inventory.ResourceItem.TWINE:
                InvenTag.GetComponent<Inventory>().twine++;
                break;
        }
        //Destroy(gameObject);
    }
    */

    //check for player tag and if yes
    //destroy game collectable and add one to inventory 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            switch (resourceType)
            {
                case Inventory.ResourceItem.WOOD:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().wood++;
                    break;
                case Inventory.ResourceItem.STONE:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().stone++;
                    break;
                case Inventory.ResourceItem.TWINE:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().twine++;
                    break;

                case Inventory.ResourceItem.DRAGONSCALE:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().dragonscale++;
                    break;
                case Inventory.ResourceItem.MAGICSTONE:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().magicstone++;
                    break;
                case Inventory.ResourceItem.GECKO:
                    GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>().gecko++;
                    break;

            }
            Destroy(gameObject);
        }
    }

}
