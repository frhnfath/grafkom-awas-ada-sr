using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {
  public AudioSource musicPlayer; // the bgm audio source and/or whatever else you need
  public static BGM instance { get; private set; }
 
  void Awake () {
    instance = this;
    DontDestroyOnLoad( gameObject );
  }
}
