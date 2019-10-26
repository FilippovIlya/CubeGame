using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCheker : MonoBehaviour
{
    public List<GameObject> FilledElements;
    public bool isFigure1One;
    public bool isFigure1Two;
    public bool isFigure2;
    public bool isFigure3;
    public bool isFigure4;
    public bool isFigure5;
    private CubeController forscore;
    public GameObject panelmove;
    public GameObject panelrotation;
    public bool isReady=true;

    //в апдейте удаляем пустые индексы
    private void Start()
    {
        GameObject controller = GameObject.Find("Controller");
        forscore = controller.GetComponent<CubeController>();
        panelmove = GameObject.Find("PanelMove");
        panelrotation = GameObject.Find("PanelRotation");
    }
    private void Update()
    {
        if (isFigure1One&& FilledElements.Count==3 && isReady)
        {
            StartCoroutine(Figure1One());
        }
        if (isFigure1Two && FilledElements.Count == 3 && isReady)
        {
            StartCoroutine(Figure1Two());
        }
        if (isFigure2 && FilledElements.Count == 5 && isReady)
        {
            StartCoroutine(Figure2());
        }
        if (isFigure3 && FilledElements.Count == 5 && isReady)
        {
            StartCoroutine(Figure3());
        }
        if (isFigure4 && FilledElements.Count == 5 && isReady)
        {
            StartCoroutine(Figure4());
        }
        if (isFigure5 && FilledElements.Count == 8 && isReady)
        {
            StartCoroutine(Figure5());
        }

        //в апдейте удаляем пустые индексы
        if(FilledElements.Count >= 1 && FilledElements[0] == null)
        {
            FilledElements.RemoveAt(0);
        }
        if (FilledElements.Count >= 2 && FilledElements[1] == null)
        {
            FilledElements.RemoveAt(1);
        }
        if (FilledElements.Count >= 3 && FilledElements[2] == null)
        {
            FilledElements.RemoveAt(2);
        }
        if (FilledElements.Count >= 4 && FilledElements[3] == null)
        {
            FilledElements.RemoveAt(3);
        }
        if (FilledElements.Count >= 5 && FilledElements[4] == null)
        {
            FilledElements.RemoveAt(4);
        }
        if (FilledElements.Count >= 6 && FilledElements[5] == null)
        {
            FilledElements.RemoveAt(5);
        }
        if (FilledElements.Count >= 7 && FilledElements[6] == null)
        {
            FilledElements.RemoveAt(6);
        }
        if (FilledElements.Count >= 8 && FilledElements[7] == null)
        {
            FilledElements.RemoveAt(7);
        }
        
    }
    IEnumerator Figure1One()
    {
            
            yield return new WaitForSeconds(0.5f);
        isReady = false;
        if (FilledElements.Count >= 3)
        {
            Destroy(FilledElements[2]);
            Destroy(FilledElements[1]);
            Destroy(FilledElements[0]);
            //if (panelmove != null && panelrotation != null && !panelmove.activeSelf) panelmove.SetActive(true);
            //if (panelmove != null && panelrotation != null && !panelrotation.activeSelf) panelrotation.SetActive(true);
            FilledElements.Clear();
            forscore.Score += 50;
            isReady = true;
            StopCoroutine(Figure1One());
        }
        else { isReady = true; }
    }
    IEnumerator Figure1Two()
    {

        yield return new WaitForSeconds(0.45f);
        isReady = false;
        if (FilledElements.Count >= 3)
        {
            Destroy(FilledElements[2]);
            Destroy(FilledElements[1]);
            Destroy(FilledElements[0]);
            //if ( panelmove != null && panelrotation != null && !panelmove.activeSelf) panelmove.SetActive(true);
            //if (panelmove != null && panelrotation != null && !panelrotation.activeSelf) panelrotation.SetActive(true);
            FilledElements.Clear();
            forscore.Score += 50;
            isReady = true;
            StopCoroutine(Figure1Two());
        }
        else { isReady = true; }
    }
    IEnumerator Figure2()
    {
        isReady = false;
        yield return new WaitForSeconds(0.4f);
        if (FilledElements.Count >= 5)
        {
            
            Destroy(FilledElements[4]);
            Destroy(FilledElements[3]);
            Destroy(FilledElements[2]);
            Destroy(FilledElements[1]);
            Destroy(FilledElements[0]);
            //if (panelmove != null && panelrotation != null && !panelmove.activeSelf) panelmove.SetActive(true);
            //if (panelmove != null && panelrotation != null && !panelrotation.activeSelf) panelrotation.SetActive(true);
            FilledElements.Clear();
            forscore.Score += 100;
            isReady = true;
            StopCoroutine(Figure2());
        }
        else { isReady = true; }
    }
    IEnumerator Figure3()
    {
        isReady = false;
        yield return new WaitForSeconds(0.35f);
        if (FilledElements.Count >= 5)
        {

            Destroy(FilledElements[4]);
            Destroy(FilledElements[3]);
            Destroy(FilledElements[2]);
            Destroy(FilledElements[1]);
            Destroy(FilledElements[0]);
            //if (panelmove != null && panelrotation != null && !panelmove.activeSelf) panelmove.SetActive(true);
            //if (panelmove != null && panelrotation != null && !panelrotation.activeSelf) panelrotation.SetActive(true);
            FilledElements.Clear();
            forscore.Score += 120;
            isReady = true;
            StopCoroutine(Figure3());
        }
        else { isReady = true; }
    }
    IEnumerator Figure4()
    {
        isReady = false;
        yield return new WaitForSeconds(0.3f);
        if (FilledElements.Count >= 5)
        {

            Destroy(FilledElements[4]);
            Destroy(FilledElements[3]);
            Destroy(FilledElements[2]);
            Destroy(FilledElements[1]);
            Destroy(FilledElements[0]);
            //if (panelmove != null && panelrotation != null && !panelmove.activeSelf) panelmove.SetActive(true);
            //if (panelmove != null && panelrotation != null && !panelrotation.activeSelf) panelrotation.SetActive(true);
            FilledElements.Clear();
            forscore.Score += 150;
            isReady = true;
            StopCoroutine(Figure4());
        }
        else { isReady = true; }
    }
    IEnumerator Figure5()
    {
        isReady = false;
        yield return new WaitForSeconds(0.25f);
        if (FilledElements.Count >= 8)
        {
            Destroy(FilledElements[7]);
            Destroy(FilledElements[6]);
            Destroy(FilledElements[5]);
            Destroy(FilledElements[4]);
            Destroy(FilledElements[3]);
            Destroy(FilledElements[2]);
            Destroy(FilledElements[1]);
            Destroy(FilledElements[0]);
            
            
            
            //if (panelmove != null && panelrotation != null && !panelmove.activeSelf) panelmove.SetActive(true);
            //if (panelmove != null && panelrotation != null && !panelrotation.activeSelf) panelrotation.SetActive(true);
            FilledElements.Clear();
            forscore.Score += 200;
            isReady = true;
            StopCoroutine(Figure5());
        }
        else { isReady = true; }
    }
}
    

