using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ogre : MonoBehaviour
{
    public int intel = 5;
    public bool hitOnHead = true;
    public bool readABook = true;
    float test()
    {
        return 5.0f;
}
    void Greet()
    {
        switch(intel)
        {
            case 5:
                print("Hello good sir do you have time to speak about our lord and savior CTHULU?");
                if (hitOnHead)
                {
                    intel = 4;
                    Greet();
                }
                if (readABook)
                {
                    intel = 5;
                    Greet();
                }
                break; 

            case 4:
                print("Ello gov");
                if (hitOnHead)
                {
                    intel = 3;
                    Greet();
                }
                if (readABook)
                {
                    intel = 5;
                    Greet();
                }
                break;

            case 3:
                print("Sah Dood");
                if (hitOnHead)
                {
                    intel = 2;
                    Greet();
                }
                if (readABook)
                {
                    intel = 4;
                    Greet();
                }
                break;

            case 2:
                print("Howdy");
                if (hitOnHead)
                {
                    intel = 1;
                    Greet();
                }
                if (readABook)
                {
                    intel = 3;
                    Greet();
                }
                break;

            case 1:
                print("Yarp");
                if (hitOnHead)
                {
                    intel = default;
                    Greet();
                }
                if (readABook)
                {
                    intel = 2;
                    Greet();
                }
                break;

            default:
                print("*DABS");
                if (hitOnHead)
                {
                    intel = default;
                    Greet();
                }
                if (readABook)
                {
                    intel = 1;
                    Greet();
                }
                break;

        }
    }

    void Start()
    {
        Greet();
        float testNum = test();
        print(testNum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
