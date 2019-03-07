﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public enum CraftableItem { SWORD, BOW, PICKAXE };
    public enum ResourceItem { WOOD, STONE, TWINE };

    public int wood;
    public int stone;
    public int twine;

    public Text woodText;
    public Text stoneText;
    public Text twineText;

    public bool hasSword;
    public bool hasBow;
    public bool hasPickaxe;

    private void Update()
    {
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
                    Instantiate(Resources.Load("TempSword"), new Vector3(4.20f, -1.3f, -1f), Quaternion.identity);

                }
                break;
            case CraftableItem.BOW:
                if (wood >= 2 && twine >= 2){
                    success = true;
                    wood -= 2;
                    twine -= 2;
                    hasBow = true;
                    Instantiate(Resources.Load("TempBow"), new Vector3(4.20f, -1.3f, 0f), Quaternion.identity);
                }
                break;
            case CraftableItem.PICKAXE:
                if (wood >= 1 && stone >= 2){
                    success = true;
                    wood -= 1;
                    stone -= 2;
                    hasPickaxe = true;
                    Instantiate(Resources.Load("TempPickaxe"), new Vector3(4.20f, -1.3f, 1f), Quaternion.identity);

                }
                break;
        }
        return success;

    }

}
