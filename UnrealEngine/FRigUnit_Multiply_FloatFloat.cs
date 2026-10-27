using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000699 RID: 1689
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Multiply_FloatFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_Multiply_FloatFloat : FRigUnit_BinaryFloatOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059B6 RID: 22966 RVA: 0x00080E1F File Offset: 0x0007F01F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Multiply_FloatFloat._ScriptStructPtr != 0) ? FRigUnit_Multiply_FloatFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Multiply_FloatFloat", ref FRigUnit_Multiply_FloatFloat._ScriptStructPtr);
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00080E43 File Offset: 0x0007F043
		public FRigUnit_Multiply_FloatFloat()
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00080E4B File Offset: 0x0007F04B
		public FRigUnit_Multiply_FloatFloat(float Argument0, float Argument1, float Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00080E68 File Offset: 0x0007F068
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Multiply_FloatFloat.StaticStruct();
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00080E74 File Offset: 0x0007F074
		[NullableContext(2)]
		public FRigUnit_Multiply_FloatFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x00080E7E File Offset: 0x0007F07E
		public FRigUnit_Multiply_FloatFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x00080E89 File Offset: 0x0007F089
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Multiply_FloatFloat(Pointer, false, true);
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00080E93 File Offset: 0x0007F093
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Multiply_FloatFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002A07 RID: 10759
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Multiply_FloatFloat";

		// Token: 0x04002A08 RID: 10760
		private static IntPtr _ScriptStructPtr;
	}
}
