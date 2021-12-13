using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ScoreData : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Score> scores;

    public ScoreData() {
        scores = new List<Score>();
    }
}
