using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject shootingItem;
    public Transform shootingPoint;
    public bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isShoot();
        }
    }

    void isShoot()
    {
        if (!canShoot)
            return;
        GameObject si = Instantiate(shootingItem, shootingPoint);
        si.transform.parent = null;
    }
}
