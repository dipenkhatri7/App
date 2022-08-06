using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnScanARClick(){
        SceneManager.LoadScene("ScanAr");
    }
    public void OnMenuClick(){
SceneManager.LoadScene("Menu");
    }
    public void OnProfileClick(){
        SceneManager.LoadScene("Profile");
    }
}
