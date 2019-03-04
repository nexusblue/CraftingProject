using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public enum CraftableItem { SWORD,BOW, PICKAXE  };
    public enum ResourceItem { WOOD, STONE, TWINE};

    public int wood;
    public int stone;
    public int twine;

    public Text woodText;
    public Text stoneText;
    public Text twineText;

    private void Update()
    {
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();
        twineText.text = twine.ToString();
    }

    public bool Craft(CraftableItem craft)
    {
        bool success = false;
        switch (craft) {
            case CraftableItem.SWORD:
                break;
            case CraftableItem.BOW:
                break;
            case CraftableItem.PICKAXE:
                break;
        }
        return false;

    }

}
