using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelDetail : MonoBehaviour
{
    private CubeController forscore;
    public GameObject gameOverPanel;
    public bool deliter;
    public bool ender;
    public GameObject panelmove;
    public GameObject panelrotation;
    public List<GameObject> baddetails;
    private void OnTriggerEnter(Collider other)
    {
        if (deliter && other.CompareTag("Detail")&&other.GetComponent<DetailMoving>().speed!=0)
        {
            Destroy(other.gameObject);
            forscore.Score -= 15;
            panelmove.SetActive(true);
            panelrotation.SetActive(true);
        }
        
    }
    private void Start()
    {
        panelmove = GameObject.Find("PanelMove");
        panelrotation = GameObject.Find("PanelRotation");
        GameObject controller = GameObject.Find("Controller");
        forscore = controller.GetComponent<CubeController>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (ender && other.CompareTag("Detail") && other.GetComponent<DetailMoving>().speed == 0)
        {
            //тут проигрыш в игре
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
    private void Update()
    {
        if (deliter) {
            
                if (baddetails.Count >= 1 && baddetails[0] == null)
                {
                    baddetails.RemoveAt(0);
                }
                if (baddetails.Count >= 2 && baddetails[1] == null)
                {
                    baddetails.RemoveAt(1);
                }
            
        GameObject[] details = GameObject.FindGameObjectsWithTag("Detail");
        for (int i = 0; i < details.Length; i++)
        {
            if (details[i].GetComponent<DetailMoving>().speed != 0 && details[i].transform.localPosition.z > -70.5f && details[i].transform.localPosition.z < -51.2f && panelmove.activeSelf && panelrotation.activeSelf)
            {
                baddetails.Add(details[i]);
            }
        }
        if (baddetails.Count == 0 && !panelrotation.activeSelf)
        {
            panelrotation.SetActive(true);
            panelmove.SetActive(true);
        } else if(panelmove.activeSelf && panelrotation.activeSelf && baddetails.Count!=0) {
            panelrotation.SetActive(false);
            panelmove.SetActive(false);
        }
        for(int j = 0; j < baddetails.Count; j++)
            {
                if (baddetails[j] != null) {
                    if (baddetails[j].GetComponent<DetailMoving>().speed == 0)
                    {
                        baddetails.RemoveAt(j);
                    }
                }
                
            }
        }
    }
}
    
