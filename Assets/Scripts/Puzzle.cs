using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour {

    public int otherHit;

    internal void Add(int id) {
        if (otherHit == 0) {
            otherHit = id;
        } else {


            if (otherHit == 1 && id == 2)
                Destroy(gameObject);

            otherHit = 0;
        }
    }
}
