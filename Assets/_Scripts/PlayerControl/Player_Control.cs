using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_Control : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed;
    [SerializeField] private float dashSpeed;
    [SerializeField] public bool inDialogue;
    float yRot;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private Vector3 camPos;
    [SerializeField] private CharacterController cc;
    [Space(10)]
    [Header("Weapon")]
    [SerializeField] private GameObject ObjectPool;
    [SerializeField] private GameObject weaponSpawn;
    [SerializeField] private GameObject[] weaponList;
    [SerializeField] private float rotSp;
    [SerializeField] private bool hasGun;
    [SerializeField] private int ammo;
    [SerializeField] private int maxAmmo;
    [SerializeField] private float health;
    [SerializeField] private PickUp pickUpScript;
    [SerializeField] private GameObject equppedWeapon;

    
    private enum WeaponType
    {
        Unarmed, Shotgun, Handgun
    }
    [SerializeField] private WeaponType weapon;

    [Space(10)]
    [Header("Health")]
    [SerializeField] private float hp;

    // Start is called before the first frame update
    void Start()
    {
        ObjectPool = GameObject.FindGameObjectWithTag("ObjectPool");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        EquipGun(weapon);
    }

    // Update is called once per frame
    void Update()
    {
        if (!inDialogue)
        {
            Moving();
            Dash();
            cameraMovement();
            Rotation();
        }
    }

    private void Moving()
    {
        cc.transform.Translate(new Vector3((Input.GetAxis("Horizontal") * speed * Time.deltaTime), 0, (Input.GetAxis("Vertical") * speed * Time.deltaTime)));
    }
    private void Dash()
    {
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            //Dashleft
            cc.transform.Translate (-dashSpeed*Time.deltaTime,0,0);
                }
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            //Dashright
            cc.transform.Translate(dashSpeed * Time.deltaTime, 0, 0);
        }
    }
    private void cameraMovement()
    {
        playerCamera.transform.position = this.transform.position + camPos;
    }
    private void Rotation()
    {
        yRot += (Input.GetAxis("Rotate") * rotSp * Time.deltaTime);
        transform.eulerAngles = new Vector3(0, yRot, 0);
    }
    private void EquipGun(WeaponType weaponSelected)
    {
        Debug.Log("Pickup Gun");
        weapon = weaponSelected;
        if (weapon == WeaponType.Shotgun)
        {
            Instantiate(weaponList[0], weaponSpawn.transform.position, Quaternion.identity, weaponSpawn.transform);
            equppedWeapon = GameObject.FindGameObjectWithTag("PlayersGun");
            equppedWeapon.transform.localEulerAngles = weaponSpawn.transform.localEulerAngles;
            hasGun = true;
        }
        if (weapon == WeaponType.Handgun)
        {
            Instantiate(weaponList[1], weaponSpawn.transform.position, Quaternion.identity, weaponSpawn.transform);
            equppedWeapon = GameObject.FindGameObjectWithTag("PlayersGun");
            equppedWeapon.transform.localEulerAngles = weaponSpawn.transform.localEulerAngles;
            hasGun = true;
        }


    }
    /*void TakeDamage(float dam)
    {
        hp -= dam;
        if (hp<=0)
        {
            Debug.Log("I diagnose you as dead");
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
       /* if (other.tag == "Bullet")
        {
            TakeDamage(5);
        }*/
        if (other.tag == "pickup")
        {
            pickUpScript = other.gameObject.GetComponent<PickUp>();
            if (pickUpScript.type == PickUp.pickUpType.weapon)
            {
                if (pickUpScript.Weapon == PickUp.weaponType.handgun)
                {
                    if (!hasGun)
                    {
                        EquipGun(WeaponType.Handgun);
                        other.gameObject.SetActive(false);
                        pickUpScript = null;
                    }
                    if (hasGun) { return; }
                }
                if (pickUpScript.Weapon == PickUp.weaponType.shotgun)
                {
                    if (!hasGun)
                    {
                        EquipGun(WeaponType.Shotgun);
                        other.gameObject.SetActive(false);
                        pickUpScript = null;
                    }
                    if (hasGun) { return; }
                }
                
            }
            if (pickUpScript.type == PickUp.pickUpType.health)
            {
                this.GetComponent<HealthScript>().TakeHealth(pickUpScript.health);
                other.gameObject.SetActive(false);
                pickUpScript = null;
            }
        }
    }
    public void DialogueExit()
    {
        inDialogue = false;
    }
}
