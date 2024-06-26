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

public class WaitingToStartWindow : MonoBehaviour {

    private void Start() {
        Bird.GetInstance().OnStartedPlaying += WaitingToStartWindow_OnStartedPlaying;
    }

    private void WaitingToStartWindow_OnStartedPlaying(object sender, System.EventArgs e) {
        Hide();
    }

    private void Hide() {
        gameObject.SetActive(false);
    }

    private void Show() {
        gameObject.SetActive(true);
    }

}
