using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public GameObject gamebject1;
    public GameObject gamebject2;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame

	void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "player") {

            gamebject1.GetComponent<Rotation>().FlagTrue();
            gamebject2.GetComponent<Rotation2>().FlagTrue();

   		}
	}
}
