using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;       //��ֹ� �̵� �ӵ�

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
