using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class over : MonoBehaviour
{

    public Text end;

    // Update is called once per frame
    void Update()
    {
        end.text = "Game Over\nYour Score : " + GameController.count;
    }
}
