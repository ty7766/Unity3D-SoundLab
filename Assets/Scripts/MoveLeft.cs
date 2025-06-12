using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;       //��ֹ� �̵� �ӵ�
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
    }
}
