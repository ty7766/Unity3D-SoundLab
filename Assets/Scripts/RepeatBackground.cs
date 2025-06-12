using UnityEngine;
using UnityEngine.Rendering;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;       //배경 시작 위치
    private float repeatWidth;
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    void Update()
    {
        //배경이 어느정도 이동하면 초기화 (연속인것처럼 보이기)
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
