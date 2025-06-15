using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;             //점프 조절
    public float gravityModifier;       //중력 조절
    public bool isOnGround = true;      //2단 점프 방지용
    public bool gameOver = false;       //게임 오버 판정
    public ParticleSystem explosionParticle;       //폭발 이펙트
    public ParticleSystem dirtParticle;            //먼지 이펙트

    private Rigidbody playerRb;
    private Animator playerAnim;

    //------------- 초기화 ---------------
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;     //중력 값 새로 설정
    }

    void Update()
    {
        //점프 (물리, 트리거, 애니메이션)
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        //달릴 때
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParticle.Stop();
        }
        //장애물에 맞았을 때
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
        }
    }
}
