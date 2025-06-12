using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;       //장애물 이동 속도
    private float leftBound = -15;  //지나간 장애물 삭제용

    private PlayerController playerControllerScript;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }


    void Update()
    {
        //플레이어가 게임 오버되면 장애물 정지
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //화면에서 벗어난 장애물 삭제
        if (transform.position.x > leftBound && gameObject.CompareTag("Obstacle"))
            Destroy(gameObject);
    }
}
