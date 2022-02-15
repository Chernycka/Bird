using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawner : MonoBehaviour
{
    
    [SerializeField] float timeToSpawn = 1f;
    [SerializeField] float bordertop = 0.8f;
    [SerializeField] float borderbottom =-0.2f;
    [SerializeField] GameObject pipes;
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public void StartSpawning()
    {
        StartCoroutine(spawnpipes());
    }
    IEnumerator spawnpipes()
    {
        while (true)
        {
        GameObject newPipe = Instantiate(pipes);
        Vector3 randomFactor = new Vector3(0,Random.Range(borderbottom,bordertop),0);
        newPipe.transform.position =transform.position+ randomFactor;
        Destroy(newPipe, 6f);
        yield return new WaitForSeconds(timeToSpawn);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
