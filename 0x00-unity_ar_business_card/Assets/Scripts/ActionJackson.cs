using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionJackson : MonoBehaviour
{
    public string FbURL;
    public string TwitURL;
    public string LkinURL;
    public string IgURL;  

    public void OpenFB()
    {
        Application.OpenURL(FbURL);
    }

    public void OpenTwit()
    {
        Application.OpenURL(TwitURL); 
    }

    public void OpenIG()
    {
        Application.OpenURL(IgURL);
    }

    public void OpenLkin()
    {
        Application.OpenURL(LkinURL);
    }
}