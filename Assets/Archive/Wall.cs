using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject particle;

    public int width = 100;
    public int height = 100;
    public int depth = 100;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = -50; x < width; x+=4)
        {
            for (int y=-50; y < height; y+=4)
            {
                for (int z= -50; z < depth; z+=4)
                {
                    Instantiate(particle, new Vector3(x, y, z), Quaternion.identity);
                }
            }
        }
    }
}
