using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;             //점프 조절
    public float gravityModifier;       //중력 조절
    public bool isOnGround = true;      //2단 점프 방지용
    private Rigidbody playerRb;


    //------------- 초기화 ---------------
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;     //중력 값 새로 설정
    }

    void Update()
    {
        //점프
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;      //2단점프 방지
    }
}
