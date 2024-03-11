using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GunShooting : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] Transform BulletSpawn;
    [SerializeField] float speed = 5f;
    void Start()
    {
        XRBaseInteractable interact = GetComponent<XRBaseInteractable>();
        interact.activated.AddListener(FireGun);
    }

    public void FireGun(ActivateEventArgs args)
    {
        GameObject tempBullet = Instantiate(Bullet, BulletSpawn.position, Quaternion.identity);
        tempBullet.GetComponent<Rigidbody>().velocity = BulletSpawn.forward * speed;
        Destroy(tempBullet, 5f);
    }
    
}
