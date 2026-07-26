using UnityEngine;

public class OutlineOnLook : MonoBehaviour
{
    public Material mat;
    public int indexOfMat = 1;

    private void Awake()
    {
        mat = GetComponent<Renderer>().materials[indexOfMat];
    }

    public void Outline(bool show)
    {
        Debug.Log(message: (show));
        mat.SetFloat("_ShowOutline", show? 1 : 0);
    }

    public void BeDestroyed()
    {
        if (this.gameObject.name == "Plant" && GameObject.Find("LevelManager").GetComponent<LevelManager>().gotWater == false)
            return;
        else if (this.gameObject.name == "StreetLamp" && GameObject.Find("LevelManager").GetComponent<LevelManager>().gotLightbulb == false)
            return;
        else if (this.gameObject.name == "Bathtub" && GameObject.Find("LevelManager").GetComponent<LevelManager>().gotSoap == false)
            return;
        else
            Destroy(this);
    }

}
