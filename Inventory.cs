using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour{
    public Text Bronzecounter;
    public Text Silvercounter;
    public Text Goldcounter;
    

    private int Bronze = 0;
    private int Silver = 0;
    private int Gold = 0;
    [SerializeField] private AudioSource collect;
 void OnTriggerEnter2D(Collider2D other){

if(other.CompareTag("Collectible")){
    Collect(other.GetComponent<Collectible>());
collect.Play();

}
}

private void Collect(Collectible collectible){

    if(collectible.Collect()){

        if(collectible is BronzeCollectible){
            Bronze++;

        }else if (collectible is SilverCollectible){
            Silver++;
        }else if (collectible is GoldCollectible){
           Gold++;
           UpdateGUI();
    }
    UpdateGUI();
}

}
private void UpdateGUI(){
    Bronzecounter.text = Bronze.ToString();
    Silvercounter.text = Silver.ToString();
    Goldcounter.text = Gold.ToString();
}



}











