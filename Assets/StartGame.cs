using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject sText;
    public GameObject CM1;
    public GameObject CM2;
    public GameObject CM3;
    public GameObject CM4;
    public GameObject CM5;
    public GameObject CM6;
    public GameObject CM7;

    private void Start()
    {
        sText.SetActive(true);
        CM1.SetActive(true);
        CM2.SetActive(false);
        CM3.SetActive(false);
        CM4.SetActive(false);
        CM5.SetActive(false);
        CM6.SetActive(false);
        CM7.SetActive(false);

    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.isKinematic = false;
            sText.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
           
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

            
            
        }
    }
}
