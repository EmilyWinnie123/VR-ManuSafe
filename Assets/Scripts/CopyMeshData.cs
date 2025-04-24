using UnityEngine;

public class CopyMeshData : MonoBehaviour
{
    public GameObject sourceObject; // 源对象

    void Start()
    {
        if (sourceObject == null)
        {
            Debug.LogError("Source object is not assigned.");
            return;
        }

        // 获取源对象的Mesh Filter组件
        MeshFilter meshFilter = sourceObject.GetComponent<MeshFilter>();
        
        if (meshFilter == null || meshFilter.sharedMesh == null)
        {
            Debug.LogError("No MeshFilter or sharedMesh found on the source object.");
            return;
        }
        
        // 复制Mesh数据
        GetComponent<MeshFilter>().sharedMesh = meshFilter.sharedMesh;
        
        // 更新Mesh Renderer组件的材质
        GetComponent<MeshRenderer>().material = sourceObject.GetComponent<MeshRenderer>().material;
    }
}