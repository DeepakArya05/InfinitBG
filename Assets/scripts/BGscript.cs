using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscript : MonoBehaviour
{
    public float scroll_speed = 0.3f;
    private MeshRenderer mesh_renderer;
    private void Awake()
    {
        mesh_renderer = GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
    }
    void scroll()
    {
        Vector2 offset = mesh_renderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.y -= Time.deltaTime * scroll_speed;
        mesh_renderer.sharedMaterial.SetTextureOffset("_MainTex",offset);

    }
}
