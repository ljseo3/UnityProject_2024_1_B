using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExMousButton : MonoBehaviour
{
    public int HP = 100;
    public Text textUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textUI.text = "ü�� :" + HP.ToString();

        if(Input.GetMouseButtonDown(0))
        {
            HP -= 10;
            Debug.Log("ü�� :" + HP);
            if(HP < 0)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
