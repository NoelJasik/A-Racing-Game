using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarDriving : MonoBehaviour
{
    [SerializeField]
    float AccelartionForce;
    [SerializeField]
    float maxSpeed;
    [SerializeField]
    float minSpeed;
    [SerializeField]
    float turnSpeed;
    [SerializeField]
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");
        float verInput = Input.GetAxis("Vertical");
        rb.AddForce(AccelartionForce * verInput * transform.forward);
        
        if (rb.velocity.x != 0 || rb.velocity.z != 0 || rb.velocity.y != 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, turnSpeed * horInput * Time.deltaTime, 0f));
        }
        
    }
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
