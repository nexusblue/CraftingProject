using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public enum CraftableItem { SWORD, BOW, PICKAXE, REDPOTION,BLUEPOTION,YELLOWPOTION };
    public enum ResourceItem { WOOD, STONE, TWINE , DRAGONSCALE, MAGICSTONE, GECKO };

    public Text dragonScaleText;
    public Text magicStoneText;
    public Text geckoText;

    public int dragonScale;
    public int magicStone;
    public int gecko;

    public GameObject SpawnPotionRed;
    public GameObject SpawnPotionBlue;
    public GameObject SpawnPotionYellow;

   
    public bool hasPotionRed;
    public bool hasPotionBlue;
    public bool hasPotionYellow;

    private void Update(){
        dragonScaleText.text = dragonScale.ToString();
        magicStoneText.text = magicStone.ToString();
        geckoText.text = gecko.ToString();
    }

    //taking button number from UI
    public void CraftbyInt(int craftInt){
        if(craftInt == 1) {
            Craft(CraftableItem.REDPOTION);
        }
        else if (craftInt == 2){
            Craft(CraftableItem.BLUEPOTION);
        }
        else if (craftInt == 3){
            Craft(CraftableItem.YELLOWPOTION);
        }

    }

    public bool Craft(CraftableItem craft){

        bool success = false;
        switch (craft) {
            case CraftableItem.REDPOTION:
                if (gecko>=3 && magicStone >= 2) {
                    success = true;
                    gecko -= 3;
                    magicStone -= 2;
                    hasPotionRed = true;
                    Instantiate(Resources.Load("PotionRed"), SpawnPotionRed.transform.position , Quaternion.identity);

                }
                break;
            case CraftableItem.BLUEPOTION:
                if (magicStone >= 4 && dragonScale >= 1){
                    success = true;
                    magicStone -= 4;
                    dragonScale -= 1;
                    hasPotionBlue = true;
                    Instantiate(Resources.Load("PotionBlue"), SpawnPotionBlue.transform.position, Quaternion.identity);
                }
                break;
            case CraftableItem.YELLOWPOTION:
                if (dragonScale >= 2 && magicStone >= 2 && gecko >=2){
                    success = true;
                    dragonScale -= 2;
                    magicStone -= 2;
                    gecko -= 2;
                    hasPotionYellow = true;
                    Instantiate(Resources.Load("PotionYellow"), SpawnPotionYellow.transform.position, Quaternion.identity);

                }
                break;
        }
        return success;

    }

}
