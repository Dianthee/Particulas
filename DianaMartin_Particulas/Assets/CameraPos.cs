using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    
    public GameObject[] pos;
    public int index = 0;
    



    public void NextParticle(){
        index++;

        if (index >= pos.Length)
        {
            index = 0;
        }

        transform.position = pos[index].transform.position;
        transform.rotation = pos[index].transform.rotation;
    }
}
