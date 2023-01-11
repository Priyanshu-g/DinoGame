using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using UnityEngine.SceneManagement;

public class DinoAgent : Agent
{
    public bool jumping;
    public bool isTraining;
    Vector3 ogPosition;
    public ScoreManagerScript scoreManagerScript;
    public override void Initialize()
    {
        ogPosition = transform.position;
    }

    public override void OnEpisodeBegin()
    {
        transform.position = ogPosition;
    }


    public override void CollectObservations(VectorSensor sensor)
    {
        /*
        sensor.AddObservation(scoreManagerScript.score);
        sensor.AddObservation(transform.localRotation.normalized);
        sensor.AddObservation(transform.localPosition.normalized);
        */
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        if (vectorAction[0] >= 0)
        {
            jumping = true;
        }
        else
        {
            jumping = false;
        }
        if (isTraining)
        {
            AddReward(scoreManagerScript.score / 1000f);
            Debug.Log(vectorAction[0]);
            Debug.Log(scoreManagerScript.score / 1000f);
        }
    }

    public override void Heuristic(float[] actionsOut)
    {
        return;
    }
}
