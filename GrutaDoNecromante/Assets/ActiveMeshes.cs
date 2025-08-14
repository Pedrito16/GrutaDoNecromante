using UnityEngine;
using UnityEngine.Rendering;

public class ActiveMeshes : MonoBehaviour
{
    [SerializeField] GameObject treeRoot;
    [SerializeField] MeshRenderer[] meshRenderers;
    float timer;
    void Awake()
    {
        meshRenderers = treeRoot.GetComponentsInChildren<MeshRenderer>();
    }
    private void Start()
    {
        Invoke("Active", 1f);
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            Active();
            timer = 0;
        }
    }
    public void Active()
    { 
        foreach (var mr in meshRenderers)
        {
            mr.enabled = true;
        }
    }
}
