using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRaw : MonoBehaviour
{
    #region Singleton
    private static CreateRaw instance = null;
    private void Awake()
    {
        if (null == instance)
        {
            instance = this;
        }
    }
    public static CreateRaw Instance
    {
        get
        {
            if (null == instance)
            {
                instance = null;
            }
            return instance;
        }
    }
    #endregion
    [SerializeField] private GameObject spawnObject;
    [SerializeField] private Transform[] positions;
    public bool[] place = new bool[4];

    private bool OnTimer = false;
    private float timer = 0;

    void Start()
    {
        for (int i = 0; i < place.Length; i++)
        {
            Instantiate(spawnObject, positions[i].position, Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        if (OnTimer)
        {
            timer += Time.deltaTime;
            if (timer >= 2f)
            {
                for (int i = 0; i < place.Length; i++)
                {
                    if (!place[i])
                    {
                        Instantiate(spawnObject, positions[i].position, Quaternion.identity);
                        break;
                    }
                }
                timer = 0;
            }
            if (place[0] && place[1] && place[2] && place[3])
            {
                OnTimer = false;
            }
        }
    }

    public void RemovePlace(int id)
    {
        place[id] = false;
        OnTimer = true;
    }
}
