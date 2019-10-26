using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailMoving : MonoBehaviour
{
    //скорость детали
    public float speed;
    public float level2;
    public GameObject panelmove;
    public GameObject panelrotation;
    private CubeController forscore;
    public bool level2complete;


    public GameObject parent;
    private bool level3complete;
    private bool level4complete;

    // Start is called before the first frame update

    private void Start()
    {
        GameObject controller = GameObject.Find("Controller");
        forscore = controller.GetComponent<CubeController>();
        panelmove = GameObject.Find("PanelMove");
        panelrotation = GameObject.Find("PanelRotation");
        
    }
    // Update is called once per frame
    void Update()
    {
        if (speed != 0 && forscore.Score >= 500 && !level2complete)
        {
            speed = speed + level2;
            level2complete = true;
        }
        if (speed != 0 && forscore.Score >= 1000 && !level3complete)
        {
            speed = speed + level2*2;
            level3complete = true;
        }
        if (speed != 0 && forscore.Score >= 2000 && !level4complete)
        {
            speed = speed + level2 * 2;
            level4complete = true;
        }
        if (parent != null)
        {
            if (parent.GetComponent<StartMove>().doehali == true)
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
        }
        
        //if ((transform.localPosition.z > -70.5f && transform.localPosition.z < -51.2f) )
        //{
        //    if( speed != 0 && panelmove!=null && panelrotation!=null && panelmove.activeSelf && panelrotation.activeSelf)
        //    {
        //        panelrotation.SetActive(false);
        //        panelmove.SetActive(false);
        //    }
            

        //}
        //else if (speed == 0 &&  panelmove != null && panelrotation != null && !panelrotation.activeSelf )
        //{
        //    panelmove.SetActive(true);
        //    panelrotation.SetActive(true);
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CubeMain")|| other.CompareTag("Detail"))
        {
            transform.SetParent(GameObject.Find("CubeMain").transform);

            speed = 0f;
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    speed = 25f;
    //    GetComponent<BoxCollider>().isTrigger = false;
    //}

}
