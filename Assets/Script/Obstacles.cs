using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    float maxTime;
    float timer;

    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public GameObject powerUp;
    int chooseObstacle = 0;
    int chooseObject = 0;

    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime && chooseObject !=1)
        {
            
            GenerateObstacle();
            timer = 0;
        }
        else if(chooseObject == 1 && timer >= 7f)
        {
            timer = 0;
            chooseObject = 0;
        }
    }

    

    public void GenerateObstacle()
    {
        chooseObstacle = Random.Range(1, 14);
        if (chooseObstacle == 1 || chooseObstacle ==5 || chooseObstacle ==9 )
        {
            GameObject newObstacle = Instantiate(obstacle1);
        }
        else if(chooseObstacle == 2 || chooseObstacle ==6 || chooseObstacle ==10)
        {
            GameObject newObstacle = Instantiate(obstacle2);
        }
        else if(chooseObstacle == 3 || chooseObstacle ==7 || chooseObstacle ==11)
        {
            GameObject newObstacle = Instantiate(obstacle3);
        }
        else if(chooseObstacle == 4 || chooseObstacle ==8 || chooseObstacle ==12)
        {
            GameObject newObstacle = Instantiate(obstacle4);
        }
        else
        {
            chooseObject = 1;
            GameObject newObstacle = Instantiate(powerUp);
        }
    }

    
    
}
