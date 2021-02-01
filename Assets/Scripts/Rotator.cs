using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private MeshRenderer _pickupColor;

    private void Start()
    {
        _pickupColor = GetComponent<MeshRenderer>();
        StartCoroutine(RandomizeColor());
    }
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);  
    }

    IEnumerator RandomizeColor()
    {
        while (true)
        {
            Debug.Log("aaa");
            _pickupColor.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            yield return new WaitForSeconds(Random.Range(.5f, 3f));
        }
    }
}
