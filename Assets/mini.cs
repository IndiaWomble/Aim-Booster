using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini : MonoBehaviour
{
    public GameController obj;
    private bool onObject = false;
    private void OnMouseEnter()
    {
        onObject = true;
    }
    private void OnMouseExit()
    {
        onObject = false;
    }
    void MouseDownOutside()
    {
        obj.transform.position = new Vector3(Random.Range(-0.5F, 0.5F) * 7, Random.Range(-0.5f, 0.5f) * 5, 0.0f);
        gameObject.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, -1.0f);
        GameController.count += 50;
        obj.score.text = "Score : " + GameController.count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (onObject)
            {
                MouseDownOutside();
            }
            else if(obj.onObject && !onObject)
            {
                obj.MouseDownOutside();
            }
            else
            {
                GameController.count -= 10;
                obj.score.text = "Score : " + GameController.count;
            }
        }
    }
}
