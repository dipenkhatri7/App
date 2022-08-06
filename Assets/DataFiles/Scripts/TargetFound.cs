using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFound : MonoBehaviour
{
    public GameObject cupcake;
    public GameObject chocolatecake;
    // Start is called before the first frame update
    void Start()
    {
        // cupcake.SetActive(true);
        // chocolatecake.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ImageTargetFound(){
        GameObject Cupcake = Instantiate(cupcake);
        GameObject Chocolatecake = Instantiate(chocolatecake);
        Chocolatecake.transform.SetParent(GameObject.Find("ImageTarget").transform, false);
        Cupcake.transform.SetParent(GameObject.Find("ImageTarget").transform, false);
    }
    public void ImageTargetLost(){
            Destroy(GameObject.FindWithTag("CUPCAKE"));
            Destroy(GameObject.FindWithTag("CHOCOLATECAKE"));
    }
}
