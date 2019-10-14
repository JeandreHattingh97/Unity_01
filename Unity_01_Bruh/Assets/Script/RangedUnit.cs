using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedUnit : Unit
{
    // Start is called before the first frame update
    void Start()
    {
        hp = 8;
        maxHP = hp;
        atk = 3;
        range = 2;
        speed = 0.5f;
        team = Random.Range(0, 2);
        GetComponent<MeshRenderer>().material = mat[team];
    }

}
