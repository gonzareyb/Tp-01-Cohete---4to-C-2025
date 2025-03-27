using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoheteScript : MonoBehaviour
{
<<<<<<< HEAD

    float coheteSpeed = 0;
=======
    float coheteSpeed = 0;

>>>>>>> 259e3fa4dd151ee468f6aa7f53f1ed24ff7ff156
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, coheteSpeed, 0);
    }

<<<<<<< HEAD

=======
>>>>>>> 259e3fa4dd151ee468f6aa7f53f1ed24ff7ff156
    public void Despegue()
    {
        coheteSpeed = 0.1f;
        //debe activarse el objeto coheteFuego
<<<<<<< HEAD
       
=======
>>>>>>> 259e3fa4dd151ee468f6aa7f53f1ed24ff7ff156
    }
}
