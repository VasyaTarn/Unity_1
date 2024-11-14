using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentCotroller : MonoBehaviour
{
    [SerializeField] private float speed;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float vercticalInput = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 direction = new Vector3(horizontalInput, 0, vercticalInput);

        transform.Translate(direction);
    }
}
