using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class BulletEnum : MonoBehaviour
{
    public enum EProjectileType
    {
        Fire,
        Poison,
        Water,
    }

    [field: SerializeField] public EProjectileType BulletType {get; private set;}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            BulletType = EProjectileType.Fire;
            print("Using fire bullets.");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            BulletType = EProjectileType.Poison;
            print("Using poison bullets.");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            BulletType = EProjectileType.Water;
            print("Using water bullets.");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (BulletType == EProjectileType.Fire)
            {
                print("Firing fire bullets.");
            }
            if (BulletType == EProjectileType.Poison)
            {
                print("Firing poison bullets.");
            }
            if (BulletType == EProjectileType.Water)
            {
                print("Firing water bullets.");
            }
        }
    }


}
