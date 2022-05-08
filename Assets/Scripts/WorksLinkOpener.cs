using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorksLinkOpener : MonoBehaviour
{
    [SerializeField] private string worksUrl;
    public void OpenLink()
    {
        if (worksUrl.Length <= 0)
        {
            Debug.Log("worksUrl is null");
            return;
        }
        Application.OpenURL(worksUrl);
    }
}
