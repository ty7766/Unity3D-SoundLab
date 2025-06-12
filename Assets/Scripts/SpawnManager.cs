using UnityEditor.VisionOS;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;   //장애물

    private Vector3 spawnPos = new Vector3(25, 0, 0); //초기 생성 위치
    private float startDelay = 2;
    private float repeatRate = 2;

    private PlayerController playerControllerScript;

    void Start()
    {
        //장애물 초기 위치에 생성
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        //Player가 gameOver시 장애물 생성 정지
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
