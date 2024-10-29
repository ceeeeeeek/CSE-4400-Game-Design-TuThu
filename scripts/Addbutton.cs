using UnityEngine;
using System.Collections;

public class Addbutton : MonoBehaviour
{
    [SerializeField]
    private Transform puzzleField;

    [SerializeField]
    private GameObject btn;
   void Awake()
   {
        for(int i = 0; i < 0; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }

    }
}
