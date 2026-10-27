using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002F5 RID: 757
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_RefPose")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAnimNode_RefPose : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B2D RID: 11053 RVA: 0x00041B3E File Offset: 0x0003FD3E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_RefPose._ScriptStructPtr != 0) ? FAnimNode_RefPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_RefPose", ref FAnimNode_RefPose._ScriptStructPtr);
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x00041B62 File Offset: 0x0003FD62
		// (set) Token: 0x06002B2F RID: 11055 RVA: 0x00041B76 File Offset: 0x0003FD76
		public unsafe TEnumAsByte<ERefPoseType> RefPoseType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RefPose.__PropertyOffset_RefPoseType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RefPose.__PropertyOffset_RefPoseType) = value;
			}
		}

		// Token: 0x06002B30 RID: 11056 RVA: 0x00041B8B File Offset: 0x0003FD8B
		public FAnimNode_RefPose()
		{
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x00041B93 File Offset: 0x0003FD93
		public FAnimNode_RefPose(TEnumAsByte<ERefPoseType> RefPoseType)
		{
			this.RefPoseType = RefPoseType;
		}

		// Token: 0x06002B32 RID: 11058 RVA: 0x00041BA2 File Offset: 0x0003FDA2
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_RefPose.StaticStruct();
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00041BAE File Offset: 0x0003FDAE
		[NullableContext(2)]
		public FAnimNode_RefPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x00041BB8 File Offset: 0x0003FDB8
		public FAnimNode_RefPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x00041BC3 File Offset: 0x0003FDC3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_RefPose(Pointer, false, true);
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x00041BCD File Offset: 0x0003FDCD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_RefPose(Pointer, MemoryOwner);
		}

		// Token: 0x0400118B RID: 4491
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_RefPose";

		// Token: 0x0400118C RID: 4492
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400118D RID: 4493
		internal static int __PropertyOffset_RefPoseType;
	}
}
