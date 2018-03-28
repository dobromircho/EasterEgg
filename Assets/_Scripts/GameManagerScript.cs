using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    
    public Transform upRight;
    public Transform downRight;
    public Transform upLeft;
    public Transform downLeft;
    float timeToInstantiate;
    float timeToMin = 0.6f;
    public GameObject egg;
    float timer;
    Transform[] startPoints;
    public Text scoreText;
    public Text levelText;
    public Text livesText;
    public static int lives = 10;
    public static int level = 1;
    public static int score;
    public static int eggCount;

    void Start()
    {
        
        startPoints = new Transform[] { upLeft, upRight, downLeft, downRight};
        timeToInstantiate = 3;
    }
    
    void Update()
    {
        scoreText.text = "SCORE: " + score;
        levelText.text = "LEVEL: " + level;
        livesText.text = "Eggs: " + lives;
        timer += Time.deltaTime;
        if (timer > timeToInstantiate)
        {
            DropEgg();
            TimeDecrease(level);
            timer = 0;
        }
        
    }

    void DropEgg()
    {
        Instantiate(egg, startPoints[Random.Range(0,3)].position, Quaternion.identity);
    }

    void TimeDecrease(int level)
    {
        timeToInstantiate -= 0.2f * level;
        if (timeToInstantiate <= (0.7f - level/10))
        {
            timeToInstantiate = 1.4f - level/10;
        }
        if (timeToInstantiate < timeToMin)
        {
            timeToInstantiate = 0.8f;
        }
    }

    public static void IncreaseScore()
    {
        score += 100;
    }

    public static void IncreaseLevel()
    {
        level += 1;
        if (level >= 18)
        {
            SceneManager.LoadScene("DemoSceneFree");
        }
    }

    public static void IncreaseEggCount()
    {
        eggCount += 1;
        if (eggCount >= 10)
        {
            level += 1;
            eggCount = 1;
        }
    }

    public static void DecreaseLives()
    {
        lives -= 1;
        if (lives <= 0)
        {
            lives = 10;
            SceneManager.LoadScene("DemoSceneFree");
        }
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}
