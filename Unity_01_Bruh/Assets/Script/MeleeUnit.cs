using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : Unit
{

    // Start is called before the first frame update
    void Start()
    {
        hp = 10;
        maxHP = hp;
        atk = 2;
        range = 1;
        speed = 1;
        team = Random.Range(0, 2);
        GetComponent<MeshRenderer>().material = mat[team];
    }

}
