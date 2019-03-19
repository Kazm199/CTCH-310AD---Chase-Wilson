using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip crash;

    private AudioSource source;

    private void Awake()
    {
        source = GetComponent<AudioSource>(); 
    }
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        getplayerinput(); 
    }
    void getplayerinput()
    {
        Pew();
        Cursor.lockState = CursorLockMode.Locked;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        if(this.transform.rotation.eulerAngles.z !=0)
        {
            this.transform.Rotate(0, 0, -this.transform.eulerAngles.z);
        }

        transform.Rotate(-v, 0, 0);
        transform.Rotate(0, h, 0);
    }
    void Pew()
    {
        source.PlayOneShot(crash, 0.5f);
    }

}