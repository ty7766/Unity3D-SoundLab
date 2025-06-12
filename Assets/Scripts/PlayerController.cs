using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce;             //���� ����
    public float gravityModifier;       //�߷� ����
    public bool isOnGround = true;      //2�� ���� ������
    private Rigidbody playerRb;


    //------------- �ʱ�ȭ ---------------
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;     //�߷� �� ���� ����
    }

    void Update()
    {
        //����
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;      //2������ ����
    }
}
