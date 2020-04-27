using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
	
	public GameObject hole1;
	public GameObject hole2;
	public GameObject hole3;
	public GameObject hole4;
	public GameObject hole5;
	public GameObject hole6;
	public GameObject hole7;
	public GameObject hole8;
	public GameObject hole9;
	public GameObject total;
    // Start is called before the first frame update
    void Start()
    {
		hole1.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole1.ToString();
		hole2.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole2.ToString();
		hole3.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole3.ToString();
		hole4.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole4.ToString();
		hole5.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole5.ToString();
		hole6.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole6.ToString();
		hole7.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole7.ToString();
		hole8.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole8.ToString();
		hole9.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.hole9.ToString();
		total.GetComponent<TMPro.TextMeshProUGUI>().text = (GameManager.hole1 + GameManager.hole2 + GameManager.hole3 + GameManager.hole4 + GameManager.hole5 +
														   GameManager.hole6 + GameManager.hole7 + GameManager.hole8 + GameManager.hole9).ToString();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("hole1");
    }
	
	public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
