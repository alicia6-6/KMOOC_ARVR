using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public GameObject cubePrefab;
    public int CubeNumber = 10;
    public float RandomNumber = 10f;

    void Start()
    {
        // 4강. for루프. 랜덤 위치에 생성
        // for (int i = 0; i < CubeNumber; i++)
        // {
        //     GameObject CubeObject = Instantiate(cubePrefab);
        //     CubeObject.transform.position = new Vector3(
        //         Random.Range(-RandomNumber, RandomNumber),
        //         Random.Range(-RandomNumber, RandomNumber),
        //         Random.Range(-RandomNumber, RandomNumber)
        //     );
        // }

        // 4강. while 루프. 랜덤 위치에 생성
        // int j = 0;
        // while (j < CubeNumber)
        // {
        //     GameObject CubeObject = Instantiate(cubePrefab);
        //     CubeObject.transform.position = new Vector3(
        //         Random.Range(-RandomNumber, RandomNumber),
        //         Random.Range(-RandomNumber, RandomNumber),
        //         Random.Range(-RandomNumber, RandomNumber)
        //     );
        //     j++;
        // }

        // 활용 - 일렬로 생성
        // 프리팹에 CubeBasic 스크립트의 SizeChanger를 2.5로 해서 서로 튕겨나가듯이 생성 됨
        for (int i = 0; i < CubeNumber; i++)
        {
            Instantiate(cubePrefab, new Vector3(i * 2.0f, 5, 0), Quaternion.identity);
        }
    }
}
