using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKyBoxController : MonoBehaviour
{
    public Material mat1;
    public Material mat2;
    public Material mat3;

    private bool mat1Enabled;
    private bool mat2Enabled;
    private bool mat3Enabled;
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = mat1;
        mat1Enabled = true;
        mat2Enabled = false;
        mat3Enabled = false;
    }
    //as player ascends stairs, triggers cause the skybox to change, building tension
    public void ChangeSkyBox()
    {
        if (mat1Enabled)
        {
            RenderSettings.skybox = mat2;
            mat1Enabled = false;
            mat2Enabled = true;   
        }
        else if (mat2Enabled)
        {
            RenderSettings.skybox = mat3;
            mat2Enabled = false;
            mat3Enabled = true;
        }
        else if (mat3Enabled)
        {
            RenderSettings.skybox = mat1;
            mat3Enabled = false;
            mat1Enabled = true;

            Destroy(gameObject);
        }
    }
}
