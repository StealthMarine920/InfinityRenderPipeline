using UnityEngine;
using Unity.Mathematics;
using Unity.Collections;
using System.Collections.Generic;
using InfinityTech.Core.Geometry;
using InfinityTech.Rendering.Feature.Foliage;

namespace InfinityTech.Component
{
    [AddComponentMenu("InfinityRenderer/Foliage Component")]
    public class FoliageComponent : EntityComponent
    {
        [Header("Culling")]
        public float CullDistance;

        [Header("Foliage")]
        public FoliageAsset FoliageProfile;

        [Header("Instances")]
        [HideInInspector]
        public FTransform[] InstancesTransfrom;


        public FoliageComponent() : base()
        {

        }

        protected override void OnRigister()
        {

        }

        protected override void OnTransformChange()
        {

        }

        protected override void EventPlay()
        {

        }

        protected override void EventTick()
        {

        }

        protected override void UnRigister()
        {

        }

#if UNITY_EDITOR
        private void DrawBound()
        {

        }

        void OnDrawGizmosSelected()
        {
            DrawBound();
        }
#endif
    }
}
