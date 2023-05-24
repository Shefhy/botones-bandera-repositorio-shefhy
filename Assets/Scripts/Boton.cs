using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public void AddTextFromButton()
    {
        PickableItem pickable = GetComponent<PickableItem>();
        if(pickable != null)
        {
            InventoryManager.instance.AddText(pickable.traduccion);
        }
    }
}
