using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public GameObject bullet;
    public Transform firePoint;

    private Vector2 mousePosition;
    public Camera sceneCamera;

    public GameObject playerObject;

    /// 

    public float speed;

    public void Fire()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }

    void Update()
    {
        ProcessShoot();
    }

    void ProcessShoot()
    {
        Vector3 direction = Camera.main.WorldToScreenPoint(playerObject.transform.position) - Input.mousePosition;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
