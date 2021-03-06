using System;
using UnityEngine;
using InfinityTech.Core;

namespace InfinityTech.Rendering.MeshPipeline
{
    public enum EGatherMethod
    {
        DotsV1,
        DotsV2,
        DefaultV1,
        DefaultV2
    }

    public struct FMeshDrawCommand : IComparable<FMeshDrawCommand>, IEquatable<FMeshDrawCommand>
    {
        public int MeshID;
        public int HashCode;
        public int MaterialID;
        public int SubmeshIndex;

        public FMeshDrawCommand(in int InMeshID, in int InMaterialID, in int InSubmeshIndex, in int InHashCode)
        {
            MeshID = InMeshID;
            HashCode = InHashCode;
            MaterialID = InMaterialID;
            SubmeshIndex = InSubmeshIndex;
        }

        public int CompareTo(FMeshDrawCommand Target)
        {
            return HashCode.CompareTo(Target.HashCode);
        }

        public bool Equals(FMeshDrawCommand Target)
        {
            return HashCode == Target.HashCode;
        }

        /*public bool Equals(FMeshDrawCommand Target)
        {
            int SelfValue = SubmeshIndex + (MeshID << 16 | MaterialID);
            int TargetValue = Target.SubmeshIndex + (Target.MeshID << 16 | Target.MaterialID);
            return SelfValue == TargetValue;
        }*/

        /*public bool Equals(FMeshDrawCommand Target)
        {
            long SelfValue = (long)SubmeshIndex + ((long)MeshID << 16 | (long)MaterialID);
            long TargetValue = (long)Target.SubmeshIndex + ((long)Target.MeshID << 16 | (long)Target.MaterialID);
            return SelfValue == TargetValue;
        }*/

        public override bool Equals(object obj)
        {
            return Equals((FMeshBatch)obj);
        }

        public override int GetHashCode()
        {
            return HashCode;
            //return SubmeshIndex + (MeshID << 16 | MaterialID);
        }
    }

    public struct FMeshDrawCommandV2 : IComparable<FMeshDrawCommandV2>, IEquatable<FMeshDrawCommandV2>
    {
        public int MeshID;
        public int MaterialID;
        public int SubmeshIndex;

        public FMeshDrawCommandV2(in int InMeshID, in int InMaterialID, in int InSubmeshIndex)
        {
            MeshID = InMeshID;
            MaterialID = InMaterialID;
            SubmeshIndex = InSubmeshIndex;
        }

        public int CompareTo(FMeshDrawCommandV2 Target)
        {
            return SubmeshIndex + (MeshID << 16 | MaterialID);
        }

        public bool Equals(FMeshDrawCommandV2 Target)
        {
            int SelfValue = SubmeshIndex + (MeshID << 16 | MaterialID);
            int TargetValue = Target.SubmeshIndex + (Target.MeshID << 16 | Target.MaterialID);
            return SelfValue == TargetValue;
        }

        public override bool Equals(object obj)
        {
            return Equals((FMeshBatch)obj);
        }

        public override int GetHashCode()
        {
            return SubmeshIndex + (MeshID << 16 | MaterialID);
        }
    }
}
