using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ScoreUI : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;
}
 /*   void Start()
    {
        scoreManager.AddScore(new Score("farhan", 1000));
        scoreManager.AddScore(new Score("utat", 1500));

        var scores = scoreManager.GetHighScores().ToArray;
        for (int i = 0; i < scores.Length; i++) {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.number.text = (i+1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }
}
*/