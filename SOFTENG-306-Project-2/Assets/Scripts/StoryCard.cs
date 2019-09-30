﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryCard : Card
{
    public string Id { get; set; }
    public List<Transition> Transitions { get; set; }
    public string NextStateId { get; private set; }

    public StoryCard(string id, string dialogue, List<Transition> transitions)
    {
        Id = id;
        Dialogue = dialogue;
        Transitions = transitions;
    }

    public StoryCard(string dialogue, List<Transition> transitions)
    {
        Dialogue = dialogue;
        Transitions = transitions;
    }

    public override void HandleDecision(int decisionIndex)
    {
        // TODO: improve error handling here. Right now just sets next 
        // state to null if no transitions exist
        NextStateId = Transitions[decisionIndex]?.NextStateId;
    }
}