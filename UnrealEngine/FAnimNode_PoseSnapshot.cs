using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F2 RID: 754
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FAnimNode_PoseSnapshot : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B01 RID: 11009 RVA: 0x00041765 File Offset: 0x0003F965
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_PoseSnapshot._ScriptStructPtr != 0) ? FAnimNode_PoseSnapshot._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_PoseSnapshot", ref FAnimNode_PoseSnapshot._ScriptStructPtr);
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x00041789 File Offset: 0x0003F989
		// (set) Token: 0x06002B03 RID: 11011 RVA: 0x0004179D File Offset: 0x0003F99D
		public unsafe FName SnapshotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PoseSnapshot.__PropertyOffset_SnapshotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseSnapshot.__PropertyOffset_SnapshotName) = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x000417B4 File Offset: 0x0003F9B4
		// (set) Token: 0x06002B05 RID: 11013 RVA: 0x000417F7 File Offset: 0x0003F9F7
		public FPoseSnapshot Snapshot
		{
			get
			{
				base.FastCheckIsValid();
				FPoseSnapshot result;
				if ((result = this._Snapshot) == null)
				{
					result = (this._Snapshot = new FPoseSnapshot(base.NativePtr + (IntPtr)FAnimNode_PoseSnapshot.__PropertyOffset_Snapshot, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseSnapshot.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_PoseSnapshot.__PropertyOffset_Snapshot, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002B06 RID: 11014 RVA: 0x00041818 File Offset: 0x0003FA18
		// (set) Token: 0x06002B07 RID: 11015 RVA: 0x00041828 File Offset: 0x0003FA28
		public unsafe ESnapshotSourceMode Mode
		{
			get
			{
				return (ESnapshotSourceMode)(*(base.NativePtr + (IntPtr)FAnimNode_PoseSnapshot.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PoseSnapshot.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x00041839 File Offset: 0x0003FA39
		public FAnimNode_PoseSnapshot()
		{
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00041841 File Offset: 0x0003FA41
		public FAnimNode_PoseSnapshot(FName SnapshotName, FPoseSnapshot Snapshot, ESnapshotSourceMode Mode)
		{
			this.SnapshotName = SnapshotName;
			this.Snapshot = Snapshot;
			this.Mode = Mode;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x0004185E File Offset: 0x0003FA5E
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_PoseSnapshot.StaticStruct();
		}

		// Token: 0x06002B0B RID: 11019 RVA: 0x0004186A File Offset: 0x0003FA6A
		[NullableContext(2)]
		public FAnimNode_PoseSnapshot(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00041874 File Offset: 0x0003FA74
		public FAnimNode_PoseSnapshot(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0004187F File Offset: 0x0003FA7F
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_PoseSnapshot(Pointer, false, true);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x00041889 File Offset: 0x0003FA89
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_PoseSnapshot(Pointer, MemoryOwner);
		}

		// Token: 0x04001177 RID: 4471
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_PoseSnapshot";

		// Token: 0x04001178 RID: 4472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001179 RID: 4473
		internal static int __PropertyOffset_SnapshotName;

		// Token: 0x0400117A RID: 4474
		internal static int __PropertyOffset_Snapshot;

		// Token: 0x0400117B RID: 4475
		[Nullable(2)]
		private FPoseSnapshot _Snapshot;

		// Token: 0x0400117C RID: 4476
		internal static int __PropertyOffset_Mode;
	}
}
