using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    public GameObject one,two;
    // Start is called before the first frame update
    void Start()
    {
        two.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextObject(){
        two.SetActive(true);
        one.SetActive(false);
    }
    public void previousObject(){
        one.SetActive(true);
        two.SetActive(false);
    }

}
