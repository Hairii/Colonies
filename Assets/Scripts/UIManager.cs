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

    }

    public void Scene1()
    {
        SceneManager.LoadScene("MainLevel 1");
        Object[0].SetActive(false);
        Object[1].SetActive(false);

    }
    public void Exit()
    {
        Application.Quit();
    }

    public void PanelRecap(bool PanelTrue)
    {
        if (PanelTrue == true)
            Object[2].SetActive(true);
        else
            Object[2].SetActive(false);
        Object[3].SetActive(false);

    }

    public void Voyage()
    {
        Object[2].SetActive(false);
        //falsePanel= false;
        Object[3].SetActive(true);
        // Object[5].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

}
