using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;       //장애물 이동 속도

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
