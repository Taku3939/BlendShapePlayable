using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace BlendShapePlayable
{
    [TrackColor(0f, 0.25f, 0.60f)]
    [TrackClipType(typeof(BlendShapeControlClip))]
    [TrackBindingType(typeof(SkinnedMeshRenderer))]
    public class BlendShapeControlTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return ScriptPlayable<BlendShapeControlMixerBehaviour>.Create(graph, inputCount);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
#if UNITY_EDITOR
            SkinnedMeshRenderer trackBinding = director.GetGenericBinding(this) as SkinnedMeshRenderer;
            if (trackBinding == null)
                return;
#endif
            base.GatherProperties(director, driver);
        }
    }
}