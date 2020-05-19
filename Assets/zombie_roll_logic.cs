using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_roll_logic : MonoBehaviour
{

    Rigidbody m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
