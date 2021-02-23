using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawn : MonoBehaviour
{
    
    public GameObject Path;

    // Start is called before the first frame update
    void Start()
    {
       Instantiate(Path, new Vector3(0, 0, 0), Quaternion.identity);
    }

  void update()
  {
      
  }

   
}
