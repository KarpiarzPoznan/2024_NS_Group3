using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{

    public float Speed = -2;
    public float XSpawnPosition;
    public float XDespawnPosition;

    public float YMin;
    public float YMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);

        if (transform.position.x < XDespawnPosition)
        {
            transform.position = new Vector3(XSpawnPosition, Random.Range);
        }
    }
}
