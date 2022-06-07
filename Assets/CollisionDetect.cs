using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollisionDetect : MonoBehaviour
{   
    [SerializeField] AudioSource au;
    bool scaleup;
    private Vector3 ScaleUp;
    bool scaledown;
    bool contact;
    // Start is called before the first frame update
    void Start()
    {
        contact = true;
        ScaleUp = new Vector3(0.1f, 0.1f, 0.1f);
        scaleup = false;
        scaledown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (scaleup)
        {
            this.transform.localScale = this.transform.localScale + ScaleUp;
            scaleup = false;
        }

        if (scaledown && contact)
        {
            this.transform.localScale = this.transform.localScale - ScaleUp;
            scaledown = false;
            contact = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.SetActive(false);
            au.Play();
            scaleup = true;
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            scaledown = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            contact = true;
        }
    }

}
