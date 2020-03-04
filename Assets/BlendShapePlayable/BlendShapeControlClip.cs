using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace BlendShapePlayable
{

    [Serializable]
    public class BlendShapeControlClip : PlayableAsset, ITimelineClipAsset
    {
        public BlendShapeControlBehaviour template = new BlendShapeControlBehaviour();

        public ClipCaps clipCaps
        {
            get { return ClipCaps.Blending; }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<BlendShapeControlBehaviour>.Create(graph, template);
            return playable;
        }
    }
}

