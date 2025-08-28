using UnityEngine;

public class CubeBasic : MonoBehaviour
{
    public float SizeChanger = 2.5f;
    public string CubeName = "MyCube";
    public bool IsRotated = false;

    string NameChange(string newName)
    {
        return "[[" + newName + "]]"; 
    }

    void Start()
    {
        transform.localScale *= SizeChanger;
        gameObject.name = NameChange(CubeName);
    }

    void Update()
    {
        transform.localScale = Vector3.one * SizeChanger;
        if (IsRotated)
        {
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        }
    }
}
