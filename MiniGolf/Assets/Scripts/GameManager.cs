using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour { 

    public static int hole1 = 0;
    public static int hole2 = 0;
    public static int hole3 = 0;
    public static int hole4 = 0;
    public static int hole5 = 0;
    public static int hole6 = 0;
    public static int hole7 = 0;
    public static int hole8 = 0;
    public static int hole9 = 0;
    public static int maxStrokes = 15;
    public static int strokes = maxStrokes;
    public Text curStrokes;
    public static int currentHole = 0;
    public static int par = 0;
    public Text curPar;

    // Start is called before the first frame update
    void Start()
    {
        switch (DifficultyManager.Difficulty)
        {
            case DifficultyManager.Difficulties.easy:
                maxStrokes = 20;
                strokes = 20;
                break;
            case DifficultyManager.Difficulties.normal:
                maxStrokes = 15;
                strokes = 15;
                break;
            case DifficultyManager.Difficulties.hard:
                maxStrokes = 10;
                strokes = 10;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "hole1")
        {
            currentHole = hole1;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 3;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 2;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole2")
        {
            currentHole = hole2;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 3;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 2;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole3")
        {
            currentHole = hole3;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 3;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 2;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole4")
        {
            currentHole = hole4;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 5;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 3;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole5")
        {
            currentHole = hole5; ;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 5;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 3;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole6")
        {
            currentHole = hole6;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 3;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 2;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole7")
        {
            currentHole = hole7;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 5;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 3;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole8")
        {
            currentHole = hole8;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 3;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 2;
                    break;
            }
        }
        else if (SceneManager.GetActiveScene().name == "hole9")
        {
            currentHole = hole9;
            switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    par = 5;
                    break;
                case DifficultyManager.Difficulties.normal:
                    par = 4;
                    break;
                case DifficultyManager.Difficulties.hard:
                    par = 3;
                    break;
            }
        }

        curStrokes.GetComponent<Text>().text = "Strokes: " + currentHole.ToString() + "/" + maxStrokes.ToString();
        curPar.GetComponent<Text>().text = "Par: " + par.ToString();
    }
}