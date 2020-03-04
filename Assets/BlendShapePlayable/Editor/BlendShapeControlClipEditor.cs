using UnityEditor;

namespace BlendShapePlayable
{
    [CustomEditor(typeof(BlendShapeControlClip))]
    public class BlendShapeControlClipEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            BlendShapeControlClip clip = target as BlendShapeControlClip;

            var template = clip.template;
            EditorGUILayout.LabelField("-----ALL-----");
            template.shape1 = EditorGUILayout.FloatField(ShapeInfo.shape1, template.shape1);
            template.shape2 = EditorGUILayout.FloatField(ShapeInfo.shape2, template.shape2);
            template.shape3 = EditorGUILayout.FloatField(ShapeInfo.shape3, template.shape3);
            template.shape4 = EditorGUILayout.FloatField(ShapeInfo.shape4, template.shape4);
            template.shape5 = EditorGUILayout.FloatField(ShapeInfo.shape5, template.shape5);
            EditorGUILayout.LabelField("-----BRW-----");
            template.shape6 = EditorGUILayout.FloatField(ShapeInfo.shape6, template.shape6);
            template.shape7 = EditorGUILayout.FloatField(ShapeInfo.shape7, template.shape7);
            template.shape8 = EditorGUILayout.FloatField(ShapeInfo.shape2, template.shape8);
            template.shape9 = EditorGUILayout.FloatField(ShapeInfo.shape3, template.shape9);
            template.shape10 = EditorGUILayout.FloatField(ShapeInfo.shape4, template.shape10);
            EditorGUILayout.LabelField("-----EYE-----");
            template.shape11 = EditorGUILayout.FloatField(ShapeInfo.shape5, template.shape11);
            template.shape12 = EditorGUILayout.FloatField(ShapeInfo.shape6, template.shape12);
            template.shape13 = EditorGUILayout.FloatField(ShapeInfo.shape7, template.shape13);
            template.shape14 = EditorGUILayout.FloatField(ShapeInfo.shape2, template.shape14);
            template.shape15 = EditorGUILayout.FloatField(ShapeInfo.shape3, template.shape15);
            template.shape16 = EditorGUILayout.FloatField(ShapeInfo.shape4, template.shape16);
            template.shape17 = EditorGUILayout.FloatField(ShapeInfo.shape5, template.shape17);
            template.shape18 = EditorGUILayout.FloatField(ShapeInfo.shape6, template.shape18);
            template.shape19 = EditorGUILayout.FloatField(ShapeInfo.shape7, template.shape19);
            template.shape20 = EditorGUILayout.FloatField(ShapeInfo.shape2, template.shape20);
            template.shape21 = EditorGUILayout.FloatField(ShapeInfo.shape3, template.shape21);
            EditorGUILayout.LabelField("-----MTH-----");
            template.shape22 = EditorGUILayout.FloatField(ShapeInfo.shape4, template.shape22);
            template.shape23 = EditorGUILayout.FloatField(ShapeInfo.shape5, template.shape23);
            template.shape24 = EditorGUILayout.FloatField(ShapeInfo.shape6, template.shape24);
            template.shape25 = EditorGUILayout.FloatField(ShapeInfo.shape7, template.shape25);
            template.shape26 = EditorGUILayout.FloatField(ShapeInfo.shape26, template.shape26);
            template.shape27 = EditorGUILayout.FloatField(ShapeInfo.shape27, template.shape27);
            template.shape28 = EditorGUILayout.FloatField(ShapeInfo.shape28, template.shape28);
            template.shape29 = EditorGUILayout.FloatField(ShapeInfo.shape29, template.shape29);
            template.shape30 = EditorGUILayout.FloatField(ShapeInfo.shape30, template.shape30);
            template.shape31 = EditorGUILayout.FloatField(ShapeInfo.shape31, template.shape31);
            template.shape32 = EditorGUILayout.FloatField(ShapeInfo.shape32, template.shape32);
            template.shape33 = EditorGUILayout.FloatField(ShapeInfo.shape33, template.shape33);
            template.shape34 = EditorGUILayout.FloatField(ShapeInfo.shape34, template.shape34);
            EditorGUILayout.LabelField("-----HA-----");
            template.shape35 = EditorGUILayout.FloatField(ShapeInfo.shape35, template.shape35);
            template.shape36 = EditorGUILayout.FloatField(ShapeInfo.shape36, template.shape36);
            template.shape37 = EditorGUILayout.FloatField(ShapeInfo.shape37, template.shape37);
            template.shape38 = EditorGUILayout.FloatField(ShapeInfo.shape38, template.shape38);
            template.shape39 = EditorGUILayout.FloatField(ShapeInfo.shape39, template.shape39);
            template.shape40 = EditorGUILayout.FloatField(ShapeInfo.shape40, template.shape40);
            template.shape41 = EditorGUILayout.FloatField(ShapeInfo.shape41, template.shape41);
        }
    }

    static class ShapeInfo
    {
        //ALL
        public const string shape1 = "1.Angry";
        public const string shape2 = "2.Fun";
        public const string shape3 = "3.Joy";
        public const string shape4 = "4.Sorrow";
        public const string shape5 = "5.Surprised";
        //BRW
        public const string shape6 = "6.Angry";
        public const string shape7 = "7.Fun";
        public const string shape8 = "8.Joy";
        public const string shape9 = "9.Sorrow";
        public const string shape10 = "10.Surprised";
        //EYE
        public const string shape11 = "11.Natural";
        public const string shape12 = "12.Angry";
        public const string shape13 = "13.Close";
        public const string shape14 = "14.Close_R";
        public const string shape15 = "15.Close_L";
        public const string shape16 = "16.Joy";
        public const string shape17 = "17.Joy_R";
        public const string shape18 = "18.Joy_L";
        public const string shape19 = "19.Sorrow";
        public const string shape20 = "20.Surprised";
        public const string shape21 = "21.Extra";
        //MTH
        public const string shape22 = "22.Up";
        public const string shape23 = "23.Down";
        public const string shape24 = "24.Angry";
        public const string shape25 = "25.Neutral";
        public const string shape26 = "26.Fun";
        public const string shape27 = "27.Joy";
        public const string shape28 = "28.Sorrow";
        public const string shape29 = "29.Surprised";
        public const string shape30 = "30.A";
        public const string shape31 = "31.I";
        public const string shape32 = "32.U";
        public const string shape33 = "33.E";
        public const string shape34 = "34.O";
        //HA
        public const string shape35 = "35.Fung1";
        public const string shape36 = "36.Fung1_Low";
        public const string shape37 = "37.Fung1_Up";
        public const string shape38 = "38.Fung2";
        public const string shape39 = "39.Fung2_Low";
        public const string shape40 = "40.Fung2_Up";
        public const string shape41 = "41.EyeExtra_On";
    }
}