using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200055B RID: 1371
	[UnrealObjectPath("/Script/ControlRig.RigUnit_CCDIK_RotationLimit")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_CCDIK_RotationLimit : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060048A7 RID: 18599 RVA: 0x0006BB1C File Offset: 0x00069D1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_CCDIK_RotationLimit._ScriptStructPtr != 0) ? FRigUnit_CCDIK_RotationLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_CCDIK_RotationLimit", ref FRigUnit_CCDIK_RotationLimit._ScriptStructPtr);
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x0006BB40 File Offset: 0x00069D40
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x0006BB54 File Offset: 0x00069D54
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimit.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimit.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x0006BB69 File Offset: 0x00069D69
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x0006BB79 File Offset: 0x00069D79
		public unsafe float Limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimit.__PropertyOffset_Limit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_CCDIK_RotationLimit.__PropertyOffset_Limit) = value;
			}
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x0006BB8A File Offset: 0x00069D8A
		public FRigUnit_CCDIK_RotationLimit()
		{
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x0006BB92 File Offset: 0x00069D92
		public FRigUnit_CCDIK_RotationLimit(FName Bone, float Limit)
		{
			this.Bone = Bone;
			this.Limit = Limit;
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x0006BBA8 File Offset: 0x00069DA8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_CCDIK_RotationLimit.StaticStruct();
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x0006BBB4 File Offset: 0x00069DB4
		[NullableContext(2)]
		public FRigUnit_CCDIK_RotationLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x0006BBBE File Offset: 0x00069DBE
		public FRigUnit_CCDIK_RotationLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x0006BBC9 File Offset: 0x00069DC9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_CCDIK_RotationLimit(Pointer, false, true);
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x0006BBD3 File Offset: 0x00069DD3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_CCDIK_RotationLimit(Pointer, MemoryOwner);
		}

		// Token: 0x0400233E RID: 9022
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_CCDIK_RotationLimit";

		// Token: 0x0400233F RID: 9023
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002340 RID: 9024
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002341 RID: 9025
		internal static int __PropertyOffset_Limit;
	}
}
