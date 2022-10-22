using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitToWin : MonoBehaviour
{
    [SerializeField]
    GameObject winText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
     winText.SetActive(true);
    }
}
