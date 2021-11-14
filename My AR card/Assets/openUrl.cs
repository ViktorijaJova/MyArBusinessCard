using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openUrl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void github()
    {

        Application.OpenURL("https://github.com/ViktorijaJova");
    }
    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/viktorija-jovanovska-7868571b0/");
    }
}
