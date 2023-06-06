using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * horizontal * 5 * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PickableItem pickable = other.gameObject.GetComponent<PickableItem>();
        if(pickable != null)
        {
            InventoryManager.instance.AddWeapon(pickable.weapon);

            Destroy(other.gameObject);
        }
    }
}
