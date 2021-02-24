using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeroma : MonoBehaviour
{
    public Animator anim;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame //No its not.
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();

        float horizontal = Input.GetAxis("Horizontal") * 5;
        float vertical = Input.GetAxis("Vertical") * 5;

        Vector3 nopeus = new Vector3(horizontal, 0, vertical);
        //SimpleMove(nopeus);

        hahmokontrolleri.Move(nopeus * Time.deltaTime);

           if (Input.GetAxis("Vertical") != 0)
		   { 
		       anim.SetBool("walk", false); 
		   } 
		   else 
		   { 
		      anim.SetBool("walk", false);
	}          }
}          
        