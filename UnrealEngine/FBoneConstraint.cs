using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008D0 RID: 2256
	[UnrealObjectPath("/Script/Engine.BoneConstraint")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FBoneConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C26 RID: 31782 RVA: 0x000B2242 File Offset: 0x000B0442
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneConstraint._ScriptStructPtr != 0) ? FBoneConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneConstraint", ref FBoneConstraint._ScriptStructPtr);
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06007C27 RID: 31783 RVA: 0x000B2266 File Offset: 0x000B0466
		// (set) Token: 0x06007C28 RID: 31784 RVA: 0x000B2276 File Offset: 0x000B0476
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneConstraint.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneConstraint.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06007C29 RID: 31785 RVA: 0x000B2287 File Offset: 0x000B0487
		// (set) Token: 0x06007C2A RID: 31786 RVA: 0x000B229B File Offset: 0x000B049B
		public unsafe FRotator MinRotationDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneConstraint.__PropertyOffset_MinRotationDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneConstraint.__PropertyOffset_MinRotationDelta) = value;
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06007C2B RID: 31787 RVA: 0x000B22B0 File Offset: 0x000B04B0
		// (set) Token: 0x06007C2C RID: 31788 RVA: 0x000B22C4 File Offset: 0x000B04C4
		public unsafe FRotator MaxRotationDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneConstraint.__PropertyOffset_MaxRotationDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneConstraint.__PropertyOffset_MaxRotationDelta) = value;
			}
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x000B22D9 File Offset: 0x000B04D9
		public FBoneConstraint()
		{
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x000B22E1 File Offset: 0x000B04E1
		public FBoneConstraint(bool bEnable, FRotator MinRotationDelta, FRotator MaxRotationDelta)
		{
			this.bEnable = bEnable;
			this.MinRotationDelta = MinRotationDelta;
			this.MaxRotationDelta = MaxRotationDelta;
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x000B22FE File Offset: 0x000B04FE
		protected override IntPtr GetUStructPtr()
		{
			return FBoneConstraint.StaticStruct();
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x000B230A File Offset: 0x000B050A
		[NullableContext(2)]
		public FBoneConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x000B2314 File Offset: 0x000B0514
		public FBoneConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x000B231F File Offset: 0x000B051F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneConstraint(Pointer, false, true);
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x000B2329 File Offset: 0x000B0529
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x04003B88 RID: 15240
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoneConstraint";

		// Token: 0x04003B89 RID: 15241
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B8A RID: 15242
		internal static int __PropertyOffset_bEnable;

		// Token: 0x04003B8B RID: 15243
		internal static int __PropertyOffset_MinRotationDelta;

		// Token: 0x04003B8C RID: 15244
		internal static int __PropertyOffset_MaxRotationDelta;
	}
}
