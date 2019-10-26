using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementCheker : MonoBehaviour
{
    public GameObject Parent;
    private void OnTriggerEnter(Collider other)
    {
        //если это деталь 
        if (other.CompareTag("Detail"))
        {
            //добавляем деталь в список
            Parent.GetComponent<ParentCheker>().FilledElements.Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Detail"))
        {
            //убираем деталь из списка
            Parent.GetComponent<ParentCheker>().FilledElements.Remove(other.gameObject);

        }
    }
}
