using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Playables;

namespace BlendShapePlayable
{

    public class BlendShapeControlMixerBehaviour : PlayableBehaviour
    {
        private List<float> m_Blendings = new List<float>();
        SkinnedMeshRenderer m_TrackingBinding;
        private bool m_FirstFrameHappened;
        private int amount;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            //毎フレーム実行する
            m_TrackingBinding = playerData as SkinnedMeshRenderer;
            if (m_TrackingBinding == null)
                return;
            amount = m_TrackingBinding.sharedMesh.blendShapeCount;
            if (!m_FirstFrameHappened)
            {
                //初期値を記憶
                for (int i = 0; i < m_TrackingBinding.sharedMesh.blendShapeCount; ++i)
                {
                    m_Blendings.Add(m_TrackingBinding.GetBlendShapeWeight(i));
                }
                m_FirstFrameHappened = true;
                return;
            }
            
            //全Clipの値をweightに応じて合計
            int inputCount = playable.GetInputCount();
            List<float> blends = new List<float>();
            for (int i = 0; i < amount; i++)
                blends.Add(0);

            float greatestWeight = 0f;
            int currentInputs = 0;
            for (int i = 0; i < inputCount; i++)
            {
                float inputWeight = playable.GetInputWeight(i);
                ScriptPlayable<BlendShapeControlBehaviour> inputPlayable =
                    (ScriptPlayable<BlendShapeControlBehaviour>) playable.GetInput(i);
                BlendShapeControlBehaviour input = inputPlayable.GetBehaviour();
                blends[0] += input.shape1 * inputWeight;
                blends[1] += input.shape2 * inputWeight;
                blends[2] += input.shape3 * inputWeight;
                blends[3] += input.shape4 * inputWeight;
                blends[4] += input.shape5 * inputWeight;
                blends[5] += input.shape6 * inputWeight;
                blends[6] += input.shape7 * inputWeight;
                blends[7] += input.shape8 * inputWeight;
                blends[8] += input.shape9 * inputWeight;
                blends[9] += input.shape10 * inputWeight;
                blends[10] += input.shape11 * inputWeight;
                blends[11] += input.shape12 * inputWeight;
                blends[12] += input.shape13 * inputWeight;
                blends[13] += input.shape14 * inputWeight;
                blends[14] += input.shape15 * inputWeight;
                blends[15] += input.shape16 * inputWeight;
                blends[16] += input.shape17 * inputWeight;
                blends[17] += input.shape18 * inputWeight;
                blends[18] += input.shape19 * inputWeight;
                blends[19] += input.shape20 * inputWeight;
                blends[20] += input.shape21 * inputWeight;
                blends[21] += input.shape22 * inputWeight;
                blends[22] += input.shape23 * inputWeight;
                blends[23] += input.shape24 * inputWeight;
                blends[24] += input.shape25 * inputWeight;
                blends[25] += input.shape26 * inputWeight;
                blends[26] += input.shape27 * inputWeight;
                blends[27] += input.shape28 * inputWeight;
                blends[28] += input.shape29 * inputWeight;
                blends[29] += input.shape30 * inputWeight;
                blends[30] += input.shape31 * inputWeight;
                blends[31] += input.shape32 * inputWeight;
                blends[32] += input.shape33 * inputWeight;
                blends[33] += input.shape34 * inputWeight;
                blends[34] += input.shape35 * inputWeight;
                blends[35] += input.shape36 * inputWeight;
                blends[36] += input.shape37 * inputWeight;
                blends[37] += input.shape38 * inputWeight;
                blends[38] += input.shape39 * inputWeight;
                blends[39] += input.shape40 * inputWeight;
                blends[40] += input.shape41 * inputWeight;


                if (inputWeight > greatestWeight)
                {
                    greatestWeight = inputWeight;
                }

                if (!Mathf.Approximately(inputWeight, 0f))
                    currentInputs++;
            }

            for (int i = 0; i < amount; i++)
            {
                m_TrackingBinding.SetBlendShapeWeight(i, blends[i]);
            }


        }

        public override void OnPlayableDestroy(Playable playable)
        {
            m_FirstFrameHappened = false;
            if (m_TrackingBinding == null)
                return;

            for (int i = 0; i < amount; i++)
            {
                m_TrackingBinding.SetBlendShapeWeight(i, m_Blendings[i]);
            }
        }
    }
}