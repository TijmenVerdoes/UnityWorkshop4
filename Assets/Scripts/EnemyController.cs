using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject playerObject;
    public float speed = 2;
    
    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }
    
    private void Update()
    {
        var position = playerObject.transform.position;
        var heightlessPosition = new Vector3(position.x, 0, position.z);
        
        transform.LookAt(heightlessPosition);

        var heightlessTransform = new Vector3(transform.position.x, 0, transform.position.z);
        var diffPosition = heightlessPosition - heightlessTransform;

        
        Debug.Log(diffPosition.normalized);
        transform.position += diffPosition.normalized * (speed * Time.deltaTime);
    }
}
