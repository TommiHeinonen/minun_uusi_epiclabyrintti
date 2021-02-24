using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeroma : MonoBehaviour
{
    public Animator anim;
	private float horisontaalinenPyorinta = 0;
    // Start is called before the first frame update // tämä oli järkevä elämän tarkoitus. // Button is a button which can be color. U can press it.
	
	//sä olet vakooja jos olet täällä
	
    void Start()
    {
       anim = GetComponentInChildren<Animator>();
	   }

    // Update is called once per frame //No its not.
    void Update()
    {
        CharacterController hahmokontrolleri = GetComponent<CharacterController>();
        //Eteen ja sivulle liikkuminen
        float horizontal = Input.GetAxis("Horizontal") * 5;
        float vertical = Input.GetAxis("Vertical") * 5;
        Vector3 nopeus = new Vector3(horizontal, 0, vertical);
        hahmokontrolleri.Move(nopeus * Time.deltaTime);
		
		
		horisontaalinenPyorinta += Input.GetAxis("Mouse X");
		
        transform.localRotation = Quaternion.Euler(0, horisontaalinenPyorinta, 0);
           if (Input.GetAxis("Vertical") != 0)
		   { 
		       anim.SetBool("walk1", true); 
		   } 
		   else 
		   { 
		      anim.SetBool("walk1", false);
			  
	       }
	}
}          
        //sä olet vakooja jos olet täällä//sä olet vakooja jos olet täällä//sä olet vakooja jos olet täällä//sä olet vakooja jos olet täällä//sä olet vakooja jos olet täällä