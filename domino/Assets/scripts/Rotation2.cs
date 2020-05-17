using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation2 : MonoBehaviour
{
    private bool flag2 = false;

    void Update()
    {
        if (flag2 == true)
        {
            transform.Rotate(-0.5f, 0, 0);
        }
    }
	public void FlagTrue() {

        flag2 = true;
	}
}

