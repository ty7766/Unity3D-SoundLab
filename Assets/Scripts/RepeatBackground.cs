using UnityEngine;
using UnityEngine.Rendering;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;       //��� ���� ��ġ
    private float repeatWidth;
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        //����� ������� �̵��ϸ� �ʱ�ȭ (�����ΰ�ó�� ���̱�)
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
