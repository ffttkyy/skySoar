/* 
    ------------------- Sky Soar -------------------
    Team :  1. Rizky W
            2. Elis
            3. Safira
            4. Ridwan
            5. Khabib
            6. Shindy
            7. Shella 

    
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class MainMenuWindow : MonoBehaviour {

    private void Awake() {
        transform.Find("playBtn").GetComponent<Button_UI>().ClickFunc = () => { Loader.Load(Loader.Scene.GameScene); };
        transform.Find("playBtn").GetComponent<Button_UI>().AddButtonSounds();

        transform.Find("quitBtn").GetComponent<Button_UI>().ClickFunc = () => { Application.Quit(); };
        transform.Find("quitBtn").GetComponent<Button_UI>().AddButtonSounds();
    }

}
