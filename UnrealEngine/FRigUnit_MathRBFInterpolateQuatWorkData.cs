using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200064B RID: 1611
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatWorkData")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MathRBFInterpolateQuatWorkData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060055EF RID: 21999 RVA: 0x0007C844 File Offset: 0x0007AA44
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathRBFInterpolateQuatWorkData._ScriptStructPtr != 0) ? FRigUnit_MathRBFInterpolateQuatWorkData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathRBFInterpolateQuatWorkData", ref FRigUnit_MathRBFInterpolateQuatWorkData._ScriptStructPtr);
		}

		// Token: 0x060055F0 RID: 22000 RVA: 0x0007C868 File Offset: 0x0007AA68
		public FRigUnit_MathRBFInterpolateQuatWorkData()
		{
		}

		// Token: 0x060055F1 RID: 22001 RVA: 0x0007C870 File Offset: 0x0007AA70
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathRBFInterpolateQuatWorkData.StaticStruct();
		}

		// Token: 0x060055F2 RID: 22002 RVA: 0x0007C87C File Offset: 0x0007AA7C
		[NullableContext(2)]
		public FRigUnit_MathRBFInterpolateQuatWorkData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x0007C886 File Offset: 0x0007AA86
		public FRigUnit_MathRBFInterpolateQuatWorkData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x0007C891 File Offset: 0x0007AA91
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathRBFInterpolateQuatWorkData(Pointer, false, true);
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x0007C89B File Offset: 0x0007AA9B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathRBFInterpolateQuatWorkData(Pointer, MemoryOwner);
		}

		// Token: 0x040028A9 RID: 10409
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_MathRBFInterpolateQuatWorkData";

		// Token: 0x040028AA RID: 10410
		private static IntPtr _ScriptStructPtr;
	}
}
