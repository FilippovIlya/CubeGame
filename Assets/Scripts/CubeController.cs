using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    
    public GameObject CubeMain;
    public Text score_text;
    public Text best_score_text;
    public GameObject panelPause;
    //счетчик мувов по горизонтали
    public int countHorizontal=0;
    //счетчик мувов по вертикали
    public int countVertical=0;

    public int bestScore;
    private int score;
    //свойство для управления очками
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            score_text.GetComponent<Text>().text = "Score: " + score;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("InfoSaveScore");
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Score > bestScore)
        {
            bestScore = Score;
        }
        best_score_text.GetComponent<Text>().text = "Record: " + bestScore;
    }
    public void MoveLeft()
    {
        if(countHorizontal>-1 )
        {
            CubeMain.transform.position = new Vector3(CubeMain.transform.position.x + 5, CubeMain.transform.position.y, CubeMain.transform.position.z);
            countHorizontal -= 1;
        }
    }
    public void MoveRight()
    {
        if ( countHorizontal < 1)
        {
            CubeMain.transform.position = new Vector3(CubeMain.transform.position.x - 5, CubeMain.transform.position.y, CubeMain.transform.position.z);
            
            countHorizontal += 1;
        }
    }
    public void MoveTop()
    {
        if ( countVertical < 1)
        {
            CubeMain.transform.position = new Vector3(CubeMain.transform.position.x, CubeMain.transform.position.y + 5, CubeMain.transform.position.z);
            
            countVertical += 1;
        }
    }
    public void MoveBottom()
    {
        if (countVertical > -1)
        {
            CubeMain.transform.position = new Vector3(CubeMain.transform.position.x, CubeMain.transform.position.y - 5, CubeMain.transform.position.z);
            
            countVertical -= 1;
        }
    }
    public void RotateLeft()
    {
        CubeMain.transform.Rotate(0, 90, 0, Space.World);
        //CubeMain.transform.eulerAngles = new Vector3(CubeMain.transform.eulerAngles.x, CubeMain.transform.eulerAngles.y + 90, CubeMain.transform.eulerAngles.z);

    }
    public void RotateRight()
    {
        CubeMain.transform.Rotate(0, -90, 0, Space.World);
        //CubeMain.transform.eulerAngles = new Vector3(CubeMain.transform.eulerAngles.x, CubeMain.transform.rotation.y - 90, CubeMain.transform.eulerAngles.z);

    }
    public void RotateTop()
    {
        CubeMain.transform.Rotate(-90, 0, 0, Space.World);
        //CubeMain.transform.eulerAngles = new Vector3(CubeMain.transform.eulerAngles.x - 90, CubeMain.transform.eulerAngles.y, CubeMain.transform.eulerAngles.z);

    }
    public void RotateBottom()
    {
        CubeMain.transform.Rotate(90, 0, 0, Space.World);
        //CubeMain.transform.eulerAngles = new Vector3(CubeMain.transform.eulerAngles.x + 90, CubeMain.transform.eulerAngles.y, CubeMain.transform.eulerAngles.z);

    }
    public void RestartBtn()
    {

        Score = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitBtn()
    {
        PlayerPrefs.SetInt("InfoSaveScore", bestScore);
        Application.Quit();
    }
    public void PauseBtn()
    {
        if (!panelPause.activeSelf)
        {
            Time.timeScale = 0;
            panelPause.SetActive(true);
        } else
        {
            Time.timeScale = 1;
            panelPause.SetActive(false);
        }
    }
    
}
