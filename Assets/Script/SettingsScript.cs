using System;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{

    // Start is called before the first frame update
    public void ButtonBack()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        SceneManager.LoadScene("MainMenu");
    }
}
