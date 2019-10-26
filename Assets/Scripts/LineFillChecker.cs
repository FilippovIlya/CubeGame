using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LineFillChecker : MonoBehaviour
{
    public int Score;
    private CubeController forscore;
    //список деталей в чекере
    public List<GameObject> inChekersarea;
    public GameObject panelmove;
    public GameObject panelrotation;
    private void Start()
    {
        GameObject controller = GameObject.Find("Controller");
        forscore = controller.GetComponent<CubeController>();
        panelmove = GameObject.Find("PanelMove");
        panelrotation = GameObject.Find("PanelRotation");
    }
    //при вхождении в зону чекера
    private void OnTriggerEnter(Collider other)
    {
        //если это деталь 
        if (other.CompareTag("Detail"))
        {
            //добавляем деталь в список
            inChekersarea.Add(other.gameObject);
        }
    }
    //при покидании зоны чекера
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Detail"))
        {
            //убираем деталь из списка
            inChekersarea.Remove(other.gameObject);

        }
    }
    private void OnTriggerStay(Collider other)
    {
        //если счетчик достиг 3 - деталь линия из трех
        if(inChekersarea.Count == 4)
        {
            if (other.CompareTag("Detail") && other.GetComponentInChildren<DetailMoving>().speed == 0f)
            {
                for (int i = 0; i < inChekersarea.Count; i++)
                {
                    Destroy(inChekersarea[i]);

                }
                //чистим список
                if (!panelmove.activeSelf) panelmove.SetActive(true);
                if (!panelrotation.activeSelf) panelrotation.SetActive(true);
                forscore.Score += 80;
                inChekersarea.Clear();


            }
        } else if (inChekersarea.Count == 3)
        {
            //если 3 детали и их скорость равно нулю, удаляем все 
            if (other.CompareTag("Detail")&&other.GetComponentInChildren<DetailMoving>().speed==0f)
            {
               for(int i = 0; i < inChekersarea.Count; i++)
                {
                    Destroy(inChekersarea[i]);
                    
                }
                //чистим список
                if(!panelmove.activeSelf) panelmove.SetActive(true);
                if (!panelrotation.activeSelf) panelrotation.SetActive(true);
                forscore.Score += 50;
                inChekersarea.Clear();
                

            }
        }
    }
    private void Update()
    {

        //в апдейте удаляем пустые индексы
        if (inChekersarea.Count >= 1)
        {
            if (inChekersarea[0] == null)
            {
                inChekersarea.RemoveAt(0);

            }
        }
        if (inChekersarea.Count >= 2)
        {
            if (inChekersarea[0] == null)
            {
                inChekersarea.RemoveAt(0);

            }
            if (inChekersarea[1] == null)
            {
                inChekersarea.RemoveAt(1);

            }
        }
        if (inChekersarea.Count >= 3)
        {
            if (inChekersarea[0] == null)
            {
                inChekersarea.RemoveAt(0);

            }
            if (inChekersarea[1] == null)
            {
                inChekersarea.RemoveAt(1);

            }
            if (inChekersarea[2] == null)
            {
                inChekersarea.RemoveAt(2);

            }
        }
        if (inChekersarea.Count >= 4)
        {
            if (inChekersarea[0] == null)
            {
                inChekersarea.RemoveAt(0);

            }
            if (inChekersarea[1] == null)
            {
                inChekersarea.RemoveAt(1);

            }
            if (inChekersarea[2] == null)
            {
                inChekersarea.RemoveAt(2);

            }
            if (inChekersarea[3] == null)
            {
                inChekersarea.RemoveAt(3);

            }
        }
    }
    
    
}
