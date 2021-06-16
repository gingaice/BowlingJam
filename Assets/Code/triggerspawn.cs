using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerspawn : MonoBehaviour
{
    public Transform ball;
    public Transform spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            ball.position = spawn.position;
            
        }
    }
}
