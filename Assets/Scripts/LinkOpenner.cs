using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkOpenner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenLinkTwitter()
    {
        Application.OpenURL("https://twitter.com/NagatsukiSep");
    }

    public void OpenLinkGitHub()
    {
        Application.OpenURL("https://github.com/NagatsukiSep");
    }
}
