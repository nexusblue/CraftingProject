using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalInventory : MonoBehaviour
{
    public enum CraftableItem { POTIONBOMB, SAFEZONE, XXX };
    public enum ResourceItem { DRAGONSCALE, MAGICSTONE, GECKO };

    public int dragonscale;
    public int magicstone;
    public int gecko;

    public Text dragonscaleText;
    public Text magicrockText;
    public Text geckoText;

    public bool hasPotion;
    public bool hasSafezone;
    public bool hasXXX;

    public GameObject SpawnSword;
    public GameObject SpawnBow;
    public GameObject SpawnPickaxe;

    private void Update()
    {
        dragonscaleText.text = dragonscaleText.ToString();
        magicrockText.text = magicrockText.ToString();
        geckoText.text = geckoText.ToString();

    }

    /*
    //taking button number from UI
    public void CraftbyInt(int craftInt)
    {
        if (craftInt == 1)
        {
            Craft(CraftableItem.SWORD);
        }
        else if (craftInt == 2)
        {
            Craft(CraftableItem.BOW);
        }
        else if (craftInt == 3)
        {
            Craft(CraftableItem.PICKAXE);
        }

    }

    public bool Craft(CraftableItem craft)
    {

        bool success = false;
        switch (craft)
        {
            case CraftableItem.SWORD:
                if (dragonscale >= 1 && magicstone >= 2)
                {
                    success = true;
                    dragonscale -= 1;
                    magicstone -= 2;
                    hasSword = true;
                    Instantiate(Resources.Load("TempSword"), SpawnSword.transform.position, Quaternion.identity);

                }
                break;
            case CraftableItem.BOW:
                if (dragonscale >= 2 && gecko >= 2)
                {
                    success = true;
                    dragonscale -= 2;
                    gecko -= 2;
                    hasBow = true;
                    Instantiate(Resources.Load("TempBow"), SpawnBow.transform.position, Quaternion.identity);
                }
                break;
            case CraftableItem.PICKAXE:
                if (dragonscale >= 1 && magicstone >= 2)
                {
                    success = true;
                    dragonscale -= 1;
                    magicstone -= 2;
                    hasPickaxe = true;
                    Instantiate(Resources.Load("TempPickaxe"), SpawnPickaxe.transform.position, Quaternion.identity);

                }
                break;
        }
        return success;

    }
    */
}
