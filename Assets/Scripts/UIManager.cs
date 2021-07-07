using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject[] Object;
    private bool falsePanel;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadSceneAsync("MainLevel");
    }

    public void Scene1()
    {
        SceneManager.LoadScene("MainLevel");
        Object[0].SetActive(false);
        Object[1].SetActive(false);
        Object[7].SetActive(true);

    }
    public void Exit()
    {
        Application.Quit();
    }

    public void PanelRecap(bool PanelTrue)
    {
        if (PanelTrue == true)
        {
            Object[7].SetActive(false);
            Object[2].SetActive(true);

        }

        else
        {
            Object[2].SetActive(false);
            Object[3].SetActive(false);
            Object[4].SetActive(false);
            Object[5].SetActive(false);
            Object[6].SetActive(false);

            Object[7].SetActive(true);
        }

    }

    public void Voyage()
    {
        Object[2].SetActive(false);
        Object[6].SetActive(true);
        Object[3].SetActive(true);
       

    }

    public void Manuel()
    {
        
        Object[4].SetActive(true);
        Object[5].SetActive(false);
    }

    public void Automatique()
    {
        Object[5].SetActive(true);
        Object[4].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
