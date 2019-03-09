using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public enum CraftableItem { SWORD, BOW, PICKAXE };
    public enum ResourceItem { WOOD, STONE, TWINE , DRAGONSCALE, MAGICSTONE, GECKO };

    public int wood;
    public int stone;
    public int twine;
    public int dragonscale;
    public int magicstone;
    public int gecko;

    public Text woodText;
    public Text magicrockText;
    public Text geckoText;

    public Text dragonscaleText;
    public Text stoneText;
    public Text twineText;

    public bool hasSword;
    public bool hasBow;
    public bool hasPickaxe;

    public GameObject SpawnSword;
    public GameObject SpawnBow;
    public GameObject SpawnPickaxe;

    private void Update(){
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();
        twineText.text = twine.ToString();
    }

    //taking button number from UI
    public void CraftbyInt(int craftInt){
        if(craftInt == 1) {
            Craft(CraftableItem.SWORD);
        }
        else if (craftInt == 2){
            Craft(CraftableItem.BOW);
        }
        else if (craftInt == 3){
            Craft(CraftableItem.PICKAXE);
        }

    }

    public bool Craft(CraftableItem craft){

        bool success = false;
        switch (craft) {
            case CraftableItem.SWORD:
                if (wood>=1 && stone >=2) {
                    success = true;
                    wood -= 1;
                    stone -= 2;
                    hasSword = true;
                    Instantiate(Resources.Load("TempSword"), SpawnSword.transform.position , Quaternion.identity);

                }
                break;
            case CraftableItem.BOW:
                if (wood >= 2 && twine >= 2){
                    success = true;
                    wood -= 2;
                    twine -= 2;
                    hasBow = true;
                    Instantiate(Resources.Load("TempBow"), SpawnBow.transform.position, Quaternion.identity);
                }
                break;
            case CraftableItem.PICKAXE:
                if (wood >= 1 && stone >= 2){
                    success = true;
                    wood -= 1;
                    stone -= 2;
                    hasPickaxe = true;
                    Instantiate(Resources.Load("TempPickaxe"), SpawnPickaxe.transform.position, Quaternion.identity);

                }
                break;
        }
        return success;

    }

}
