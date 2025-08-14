using UnityEngine;
using UnityEditor;
using UnityEngine.ProBuilder;
using UnityEngine.ProBuilder.MeshOperations;

public class BatchFreezeTransform : MonoBehaviour
{
    [MenuItem("Tools/ProBuilder/Batch Freeze Transform (All Selected)")]
    static void FreezeAllSelected()
    {
        foreach (var obj in Selection.gameObjects)
        {
            var pbMesh = obj.GetComponent<ProBuilderMesh>();
            if (pbMesh != null)
            {
                // Aplica posição, rotação e escala na malha
                pbMesh.FreezeScaleTransform();
                pbMesh.ToMesh();
                pbMesh.Refresh();

                Debug.Log($"Freeze Transform aplicado em: {obj.name}");
            }
        }
    }
}
