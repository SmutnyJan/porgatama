using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordersConstructor : MonoBehaviour
{
    public GameObject Border;

    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {


        GameObject top = Instantiate(Border);
        GameObject bot = Instantiate(Border);
        GameObject left = Instantiate(Border);
        GameObject right = Instantiate(Border);

        top.transform.position = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height, 0));
        top.transform.localEulerAngles = new Vector3(0, 0, 90);

        bot.transform.position = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width / 2, 0, 0));
        bot.transform.localEulerAngles = new Vector3(0, 0, 90);


        left.transform.position = MainCamera.ScreenToWorldPoint(new Vector3(0, Screen.height / 2, 0));
        right.transform.position = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height / 2, 0));

        top.transform.position = new Vector3(top.transform.position.x, top.transform.position.y, 0);
        bot.transform.position = new Vector3(bot.transform.position.x, bot.transform.position.y, 0);
        left.transform.position = new Vector3(left.transform.position.x, left.transform.position.y, 0);
        right.transform.position = new Vector3(right.transform.position.x, right.transform.position.y, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
