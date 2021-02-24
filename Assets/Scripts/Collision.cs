using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void collision(Collision col)
	{
      if(col.gameObject.name == "Player")
	  {
		  Debug.Log("turn collision");
	  }
	}
}
