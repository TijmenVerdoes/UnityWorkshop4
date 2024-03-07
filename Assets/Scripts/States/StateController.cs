using System.Collections;
using System.Collections.Generic;
using States;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public IdleState idleState;
    public ChaseState chaseState;

    public void ChangeState()
    {
        if (idleState.enabled)
        {
            idleState.enabled = false;
            chaseState.enabled = true;
        }
        else
        {
            idleState.enabled = true;
            chaseState.enabled = false;
        }
    }
}
