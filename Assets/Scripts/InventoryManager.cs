using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    
    public ScriptableText[] traductions;
    public Text[] textOne;
    public Text[] textTwo;
    public Text[] textThree;
    public Text[] textFour;
    //public Image[] weaponsSprites;

    
    void Awake()
    {
        instance = this;
    }
    
    
    public void AddText(ScriptableText traduccion)
    {
        for (int i = 0; i < traductions.Length; i++)
        {
            if(traductions [i] == null)
            {
                traductions[i] = traduccion;
                textOne[i].text = traduccion.textName1;
                textTwo[i].text = traduccion.textName2;
                textThree[i].text = traduccion.textName3;
                textFour[i].text = traduccion.textName4;
                return;
            }
        }
    }


   
}
