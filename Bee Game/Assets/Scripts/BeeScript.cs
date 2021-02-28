using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeeScript : MonoBehaviour
{
    public int honeyFavor = 0;
    public int bumbleFavor = 0;
    public int flyFavor = 0;
    public int carpFavor = 0;
    public int leafFavor = 0;
    public int minerFavor = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPointHoney()
    {
        honeyFavor += 1;
    }
    public void AddPointBumble()
    {
        bumbleFavor += 1;
    }
    public void AddPointFly()
    {
        flyFavor += 1;
    }
    public void AddPointCarp()
    {
        carpFavor += 1;
    }
    public void AddPointLeaf()
    {
        leafFavor += 1;
    }
    public void AddPointMiner()
    {
        minerFavor += 1;
    }
}
