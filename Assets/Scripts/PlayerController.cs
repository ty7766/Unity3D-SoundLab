using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;             //���� ����
    public float gravityModifier;       //�߷� ����
    public bool isOnGround = true;      //2�� ���� ������
    public bool gameOver = false;       //���� ���� ����

    private Rigidbody playerRb;
    private Animator playerAnim;


    //------------- �ʱ�ȭ ---------------
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;     //�߷� �� ���� ����
    }

    void Update()
    {
        //���� (����, Ʈ����, �ִϸ��̼�)
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
