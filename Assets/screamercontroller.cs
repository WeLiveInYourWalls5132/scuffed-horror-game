
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class screamercontroller : MonoBehaviour
{
    public List<Sprite> images;
    public GameObject scremerimage;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Scremer"))
        {
            GetAndSetImage();
        }
    }

    private void GetAndSetImage()
    {
        scremerimage.SetActive(true);
        Image imageComponent = scremerimage.GetComponent<Image>();
        imageComponent.sprite = images[Random.Range(0,3)];
    }
}
