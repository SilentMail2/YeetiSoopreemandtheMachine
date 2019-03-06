using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    enum weaponType { Shotgun, Handgun}
    [SerializeField] weaponType Weapon;
    [SerializeField] GameObject[] bullet;
    [SerializeField] GameObject barrelEnd;
    [SerializeField] GameObject Smoke;
    [SerializeField] Animator shotgunAnim;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Player_Control>().inDialogue == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (Weapon == weaponType.Shotgun)
                {
                    if (shotgunAnim.GetBool("ShotReady"))
                    {
                        Smoke.SetActive(true);
                        Instantiate(bullet[0], barrelEnd.transform.position, barrelEnd.transform.rotation);
                        shotgunAnim.SetBool("ShotReady", false);
                    }
                }
                if (Weapon == weaponType.Handgun)
                {
                    if (shotgunAnim.GetBool("ShotReady"))
                    {
                        Smoke.SetActive(true);
                        Instantiate(bullet[0], barrelEnd.transform.position, barrelEnd.transform.rotation);
                        shotgunAnim.SetBool("ShotReady", false);
                    }
                }
            }
        }
    }
    public void ShotReady ()
    {
        Smoke.SetActive(false);
        shotgunAnim.SetBool("ShotReady", true);
        this.transform.eulerAngles = new Vector3(0, 90, 0);
    }
}
