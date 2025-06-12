using UnityEditor.VisionOS;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;   //��ֹ�

    private Vector3 spawnPos = new Vector3(25, 0, 0); //�ʱ� ���� ��ġ
    private float startDelay = 2;
    private float repeatRate = 2;

    void Start()
    {
        //��ֹ� �ʱ� ��ġ�� ����
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
