using System.Collections;
using System.Collections.Generic;
using States;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private StateController statemachine;
    
    private void Start()
    {
        statemachine = GetComponent<StateController>();
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            statemachine.ChangeState();
        }
    }
}
