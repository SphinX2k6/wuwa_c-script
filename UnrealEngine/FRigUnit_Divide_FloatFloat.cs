using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200059D RID: 1437
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Divide_FloatFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_Divide_FloatFloat : FRigUnit_BinaryFloatOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D25 RID: 19749 RVA: 0x000720FA File Offset: 0x000702FA
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Divide_FloatFloat._ScriptStructPtr != 0) ? FRigUnit_Divide_FloatFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Divide_FloatFloat", ref FRigUnit_Divide_FloatFloat._ScriptStructPtr);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x0007211E File Offset: 0x0007031E
		public FRigUnit_Divide_FloatFloat()
		{
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x00072126 File Offset: 0x00070326
		public FRigUnit_Divide_FloatFloat(float Argument0, float Argument1, float Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x00072143 File Offset: 0x00070343
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Divide_FloatFloat.StaticStruct();
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x0007214F File Offset: 0x0007034F
		[NullableContext(2)]
		public FRigUnit_Divide_FloatFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00072159 File Offset: 0x00070359
		public FRigUnit_Divide_FloatFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x00072164 File Offset: 0x00070364
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Divide_FloatFloat(Pointer, false, true);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x0007216E File Offset: 0x0007036E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Divide_FloatFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400254D RID: 9549
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Divide_FloatFloat";

		// Token: 0x0400254E RID: 9550
		private static IntPtr _ScriptStructPtr;
	}
}
