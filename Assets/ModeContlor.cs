using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModeContlor : MonoBehaviour {

    public int GameMode;

    private void Start()
    {
        CompleteProject.GameOverManager.GameMode = this.GameMode;
    }

    public void OnClick()
    {
        SceneManager.LoadScene("GameMode");

    }

}
