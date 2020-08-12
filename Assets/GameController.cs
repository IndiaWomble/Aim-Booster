using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public mini obj;
    float timeleft = 25;
    public bool onObject = false;
    public static int count = 0;
    public Text score;
    public Text time_left;

    private void Update()
    {
        timeleft -= Time.deltaTime;
        time_left.text = "Time Left : " + (int)timeleft;
        if (timeleft < 0)
        {
            SceneManager.LoadScene(2);
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(!onObject)
                {
                    count -= 10;
                    score.text = "Score : " + count;
                }
            }
        }
    }
        private void OnMouseEnter()
        {
            onObject = true;
        }
        private void OnMouseExit()
        {
            onObject = false;
        }
        public void MouseDownOutside()
        {
            gameObject.transform.position = new Vector3(Random.Range(-0.5F, 0.5F) * 7, Random.Range(-0.5f, 0.5f) * 5, 0.0f);
            obj.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, -1.0f);
            count += 25;
            score.text = "Score : " + count;
        }
}
