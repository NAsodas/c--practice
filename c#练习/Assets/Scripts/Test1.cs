using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(0, 0, 0);
    public Vector3 endPosition = new Vector3(10, 10, 10);
    public float interpolationFactor = 1f; // 插值因子在 [0, 1] 之间

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector3.Lerp(startPosition, endPosition, interpolationFactor * Time.deltaTime);
    }
}
