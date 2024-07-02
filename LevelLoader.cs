using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public int iLevelToLoad;
    [SerializeField] private AudioSource levelsound;
    public string sLevelToLoad;
    public bool useInetegerToLoadLevel = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        
    }
private void OnTriggerEnter2D(Collider2D collision){

    GameObject collisionGameObject = collision.gameObject;
    if(collisionGameObject.name =="Knight"){

levelsound.Play();
        LoadScene();
    }
}
void LoadScene(){
    if(useInetegerToLoadLevel){
        SceneManager.LoadScene(iLevelToLoad);
    }
    else{
        SceneManager.LoadScene(sLevelToLoad);
    }
}


}
