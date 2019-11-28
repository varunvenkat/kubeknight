using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float movementSpeed = 10;
    public float sprintSpeed = 20;
    public float turningSpeed = 120;
    public Rigidbody rb;
    public float badHeight = 300;
    public float distToGround = 0.6f;
    public Transform tr;
    public float jumpforce = 30;
    public bool isFight = false;
    public float health;
    public bool isSaving = false;
    public bool isLoaded = false;
    public Weapon weapon;
    public float horizontal;
    public float vertical;
    Quaternion WeRo;
    Animation anim;
    public ChangeScene CS;

    // Start is called before the first frame update
    void Start()
    {
        CS = GameObject.Find("ButtonManager").GetComponent<ChangeScene>();

        SaveSystem.LoadPlayer();
        SaveData data = SaveSystem.LoadPlayer();
        GetComponent<PlayerData>().playerHealth = data.health;
        GetComponent<PlayerData>().currentHealth = data.currentHealth;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        GetComponent<PlayerData>().transform.position = position;
        isLoaded = true;

        
    }

    IEnumerator Savetime()
    {
        isSaving = true;
        yield return new WaitForSeconds(0.5f);
        isSaving = false;
        SaveSystem.SavePlayer(GetComponent<PlayerData>());
    }

    // Update is called once per frame
    void LateUpdate()
    {


        horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);

        if (Input.GetAxis("Vertical") == 1 && Input.GetKey("left shift"))
        {
            float sprintVertical = sprintSpeed * Time.deltaTime;
            transform.Translate(0, 0, sprintVertical);
        }

        bool isJumping = true;

        if (Input.GetButtonDown("Fire1") && Physics.Raycast(tr.position, Vector3.down, distToGround))
        {
            isJumping = false;
        }

        if (!isJumping)
        {
         
            rb.AddForce(0, jumpforce, 0);
        }

        if (Input.GetKeyDown("s"))
        {
            if (!isSaving)
            {
                StartCoroutine(Savetime());
            }
        }

        if (Input.GetKeyDown("escape"))
        {
            CS.changeTheScene(3);
        }
    }
    public void OnCollisionEnter(Collision other)
    {

        if (other.collider.tag == "Enemy")
        {

            string enemyID = other.collider.name;
            float damage = GameObject.Find(enemyID).GetComponent<EntityData>().enemyDamage;
            this.GetComponent<PlayerData>().currentHealth = this.GetComponent<PlayerData>().currentHealth - 20;
        }

    }
}

