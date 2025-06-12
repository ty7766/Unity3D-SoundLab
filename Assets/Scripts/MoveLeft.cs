using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;       //��ֹ� �̵� �ӵ�
    private float leftBound = -15;  //������ ��ֹ� ������

    private PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    void Update()
    {
        //�÷��̾ ���� �����Ǹ� ��ֹ� ����
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //ȭ�鿡�� ��� ��ֹ� ����
        if (transform.position.x > leftBound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
