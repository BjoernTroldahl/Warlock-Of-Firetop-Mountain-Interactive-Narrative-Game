using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ShaderControlAsset : PlayableAsset
{
    public float floatVal = 0;
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<ShaderPlayable>.Create(graph);

        ShaderPlayable runtimePlayable = playable.GetBehaviour();
        runtimePlayable.floatVal = floatVal;

        return playable;
    }
}
