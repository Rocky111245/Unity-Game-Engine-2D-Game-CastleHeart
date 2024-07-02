using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFollowBoss : MonoBehaviour
{
    public Transform objectToFollow;
    RectTransform rectTransform;
    private void Awake()
    
    {
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    private void Update()
    { if (objectToFollow !=null)
    rectTransform.anchoredPosition = objectToFollow.localPosition;
        
    }
}
