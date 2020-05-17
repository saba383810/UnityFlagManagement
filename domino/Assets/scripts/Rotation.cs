using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private bool flag1 = false;

    void Update()
    {
        if (flag1 == true)
        {
            transform.Rotate(0.5f, 0, 0);
        }
    }
     public void FlagTrue() {

        flag1 = true;
	}
}

