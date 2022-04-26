using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClickAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void OnClickWorks()
    {
        SceneManager.LoadScene("Works");
    }

    public void OnClickLinks()
    {
        SceneManager.LoadScene("Links");
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene("Top");
    }

}
