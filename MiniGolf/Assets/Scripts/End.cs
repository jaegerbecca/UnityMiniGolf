using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
	public GameObject hole1Par;
	public GameObject hole2Par;
	public GameObject hole3Par;
	public GameObject hole4Par;
	public GameObject hole5Par;
	public GameObject hole6Par;
	public GameObject hole7Par;
	public GameObject hole8Par;
	public GameObject hole9Par;
	public GameObject totalPar;
	
	public GameObject hole1Strokes;
	public GameObject hole2Strokes;
	public GameObject hole3Strokes;
	public GameObject hole4Strokes;
	public GameObject hole5Strokes;
	public GameObject hole6Strokes;
	public GameObject hole7Strokes;
	public GameObject hole8Strokes;
	public GameObject hole9Strokes;
	public GameObject totalStrokes;
    // Start is called before the first frame update
    void Start()
    {
		switch (DifficultyManager.Difficulty)
            {
                case DifficultyManager.Difficulties.easy:
                    hole1Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole2Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole3Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole4Par.GetComponent<TMPro.TextMeshProUGUI>().text = "5";
					hole5Par.GetComponent<TMPro.TextMeshProUGUI>().text = "5";
					hole6Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole7Par.GetComponent<TMPro.TextMeshProUGUI>().text = "5";
					hole8Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole9Par.GetComponent<TMPro.TextMeshProUGUI>().text = "5";
					totalPar.GetComponent<TMPro.TextMeshProUGUI>().text = "40";
                    break;
                case DifficultyManager.Difficulties.normal:
                    hole1Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole2Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole3Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole4Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole5Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole6Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole7Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					hole8Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole9Par.GetComponent<TMPro.TextMeshProUGUI>().text = "4";
					totalPar.GetComponent<TMPro.TextMeshProUGUI>().text = "31";
                    break;
                case DifficultyManager.Difficulties.hard:
                    hole1Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					hole2Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					hole3Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					hole4Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole5Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole6Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					hole7Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					hole8Par.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
					hole9Par.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
					totalPar.GetComponent<TMPro.TextMeshProUGUI>().text = "22";
                    break;
            }
			
		hole1Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole1.ToString();
		hole2Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole2.ToString();
		hole3Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole3.ToString();
		hole4Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole4.ToString();
		hole5Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole5.ToString();
		hole6Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole6.ToString();
		hole7Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole7.ToString();
		hole8Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole8.ToString();
		hole9Strokes.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole9.ToString();
		totalStrokes.GetComponent<TMPro.TextMeshProUGUI>().text = (GameManager.hole1 + GameManager.hole2 + GameManager.hole3 + GameManager.hole4 + GameManager.hole5 +
														   GameManager.hole6 + GameManager.hole7 + GameManager.hole8 + GameManager.hole9).ToString();

        switch (DifficultyManager.Difficulty)
        {
            case DifficultyManager.Difficulties.easy:
                GameManager.maxStrokes = 20;
                GameManager.strokes = 20;
                break;
            case DifficultyManager.Difficulties.normal:
                GameManager.maxStrokes = 15;
                GameManager.strokes = 15;
                break;
            case DifficultyManager.Difficulties.hard:
                GameManager.maxStrokes = 10;
                GameManager.strokes = 10;
                break;
        }
    }

    public void PlayGame()
    {
        GameManager.hole1 = 0;
        GameManager.hole2 = 0;
        GameManager.hole3 = 0;
        GameManager.hole4 = 0;
        GameManager.hole5 = 0;
        GameManager.hole6 = 0;
        GameManager.hole7 = 0;
        GameManager.hole8 = 0;
        GameManager.hole9 = 0;
       
        SceneManager.LoadScene("hole1");
    }
	
	public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
