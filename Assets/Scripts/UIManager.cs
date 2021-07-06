using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject[] Object;

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
    
    public void Voyage()
    {
        Object[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveFalse()
    {

    }

    public void ActiveTrue()
    {

    }
}
