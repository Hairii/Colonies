using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public Transform target;
    private Transform Maintarget;
    private Transform Center;

   // private GameObject PlanetPanel;

    float damping = 3.0f; // Vitesse de la cam

    int zoomEarth = 40;
    int zoomT1 = 20;
    int zoomT2 = 15;
    int normal = 60;
    float zoomsmooth = 3;
    private bool Looking = false;
    private bool isZoomed = false;

    private UIManager PlanetPanel;
    // private GameObject BaseLookingObject;

    private void Start()
    {
        PlanetPanel = GameObject.Find("Canvas").GetComponent<UIManager>();
        
        Maintarget = target;
        // BaseLookingObject = CurrentLookingObject;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Looking == false)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //Ray Camera --> MousePos

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)//ouvrire UI
                {
                    
                    Looking = true;
                    PrintName(hit.transform.gameObject);
                    target = hit.transform.gameObject.GetComponent<Transform>();    //Recupérer le centre de la planète ciblée
                    isZoomed = true;
                    PlanetPanel.PanelRecap(true);
                }
            }

        }

        if (Input.GetMouseButtonDown(1))//ferme Ui
        {
            
            target = Maintarget;
            Looking = false;
            isZoomed = !isZoomed;
            PlanetPanel.PanelRecap(false);
        }
    }

    private void LateUpdate()
    {
        var rotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping); // Rotate la camera vers la cible progressivement

        if (isZoomed)
        {
            if (target.tag == "Earth")
            {
                print("Earth");
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoomEarth, Time.deltaTime * zoomsmooth);
                // CurrentLookingObject.transform.position = target.transform.position;
            }
            else if(target.tag == "Type1")
            {
                print("T1");
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoomT1, Time.deltaTime * zoomsmooth);
                // CurrentLookingObject.transform.position = target.transform.position;
            }
            else
            {
                print("T2");
                GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoomT2, Time.deltaTime * zoomsmooth);
                //CurrentLookingObject.transform.position = target.transform.position;
            }
        }

        else
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * zoomsmooth);
            //CurrentLookingObject.transform.position = BaseLookingObject.transform.position;
        }
    }

    private void PrintName(GameObject go)
    {
        print(go.name);
    }
}
    