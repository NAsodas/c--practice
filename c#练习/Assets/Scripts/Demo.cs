using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> list = new List<string>();
        list.Add("Hello");
        list.Add("World");
        list.Add("!");


        //for(int i = 0; i < list.Count; i++)
        //{
        //    Debug.Log(list[i]);
        //}

        foreach(string item in list)
        {
            Debug.Log(item);
        }
    }


}
