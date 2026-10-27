using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001021 RID: 4129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PoseSnapshot")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPoseSnapshot : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E1E4 RID: 57828 RVA: 0x0014BF61 File Offset: 0x0014A161
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPoseSnapshot._ScriptStructPtr != 0) ? FPoseSnapshot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PoseSnapshot", ref FPoseSnapshot._ScriptStructPtr);
		}

		// Token: 0x17003509 RID: 13577
		// (get) Token: 0x0600E1E5 RID: 57829 RVA: 0x0014BF88 File Offset: 0x0014A188
		// (set) Token: 0x0600E1E6 RID: 57830 RVA: 0x0014BFCB File Offset: 0x0014A1CB
		public TArray<FTransform> LocalTransforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._LocalTransforms) == null)
				{
					result = (this._LocalTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_LocalTransforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LocalTransforms.CopyAssign(value);
			}
		}

		// Token: 0x1700350A RID: 13578
		// (get) Token: 0x0600E1E7 RID: 57831 RVA: 0x0014BFDC File Offset: 0x0014A1DC
		// (set) Token: 0x0600E1E8 RID: 57832 RVA: 0x0014C01F File Offset: 0x0014A21F
		public TArray<FName> BoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._BoneNames) == null)
				{
					result = (this._BoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_BoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneNames.CopyAssign(value);
			}
		}

		// Token: 0x1700350B RID: 13579
		// (get) Token: 0x0600E1E9 RID: 57833 RVA: 0x0014C02D File Offset: 0x0014A22D
		// (set) Token: 0x0600E1EA RID: 57834 RVA: 0x0014C041 File Offset: 0x0014A241
		public unsafe FName SkeletalMeshName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_SkeletalMeshName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_SkeletalMeshName) = value;
			}
		}

		// Token: 0x1700350C RID: 13580
		// (get) Token: 0x0600E1EB RID: 57835 RVA: 0x0014C056 File Offset: 0x0014A256
		// (set) Token: 0x0600E1EC RID: 57836 RVA: 0x0014C06A File Offset: 0x0014A26A
		public unsafe FName SnapshotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_SnapshotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_SnapshotName) = value;
			}
		}

		// Token: 0x1700350D RID: 13581
		// (get) Token: 0x0600E1ED RID: 57837 RVA: 0x0014C07F File Offset: 0x0014A27F
		// (set) Token: 0x0600E1EE RID: 57838 RVA: 0x0014C08F File Offset: 0x0014A28F
		public unsafe bool bIsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_bIsValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseSnapshot.__PropertyOffset_bIsValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600E1EF RID: 57839 RVA: 0x0014C0A0 File Offset: 0x0014A2A0
		public FPoseSnapshot()
		{
		}

		// Token: 0x0600E1F0 RID: 57840 RVA: 0x0014C0A8 File Offset: 0x0014A2A8
		public FPoseSnapshot(TArray<FTransform> LocalTransforms, TArray<FName> BoneNames, FName SkeletalMeshName, FName SnapshotName, bool bIsValid)
		{
			this.LocalTransforms = LocalTransforms;
			this.BoneNames = BoneNames;
			this.SkeletalMeshName = SkeletalMeshName;
			this.SnapshotName = SnapshotName;
			this.bIsValid = bIsValid;
		}

		// Token: 0x0600E1F1 RID: 57841 RVA: 0x0014C0D5 File Offset: 0x0014A2D5
		protected override IntPtr GetUStructPtr()
		{
			return FPoseSnapshot.StaticStruct();
		}

		// Token: 0x0600E1F2 RID: 57842 RVA: 0x0014C0E1 File Offset: 0x0014A2E1
		[NullableContext(2)]
		public FPoseSnapshot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E1F3 RID: 57843 RVA: 0x0014C0EB File Offset: 0x0014A2EB
		public FPoseSnapshot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E1F4 RID: 57844 RVA: 0x0014C0F6 File Offset: 0x0014A2F6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPoseSnapshot(Pointer, false, true);
		}

		// Token: 0x0600E1F5 RID: 57845 RVA: 0x0014C100 File Offset: 0x0014A300
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPoseSnapshot(Pointer, MemoryOwner);
		}

		// Token: 0x0400793E RID: 31038
		public const string __ObjectPath = "/Script/Engine.PoseSnapshot";

		// Token: 0x0400793F RID: 31039
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007940 RID: 31040
		internal static int __PropertyOffset_LocalTransforms;

		// Token: 0x04007941 RID: 31041
		[Nullable(2)]
		private TArray<FTransform> _LocalTransforms;

		// Token: 0x04007942 RID: 31042
		internal static int __PropertyOffset_BoneNames;

		// Token: 0x04007943 RID: 31043
		[Nullable(2)]
		private TArray<FName> _BoneNames;

		// Token: 0x04007944 RID: 31044
		internal static int __PropertyOffset_SkeletalMeshName;

		// Token: 0x04007945 RID: 31045
		internal static int __PropertyOffset_SnapshotName;

		// Token: 0x04007946 RID: 31046
		internal static int __PropertyOffset_bIsValid;
	}
}
