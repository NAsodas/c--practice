using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
 
    }
    void Update()
    {
        Debug.Log("001");
        StartCoroutine(Test());
        Debug.Log("003");

    }

     IEnumerator Test()
    {
        Debug.Log("002");
        yield return null;
        Debug.Log("004");
    }

    void LateUpdate()
    {
       
        
        Debug.Log("005");

    }

}
