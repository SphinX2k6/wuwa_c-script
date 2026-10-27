using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200053D RID: 1341
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Add_FloatFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_Add_FloatFloat : FRigUnit_BinaryFloatOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004688 RID: 18056 RVA: 0x00068A3D File Offset: 0x00066C3D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Add_FloatFloat._ScriptStructPtr != 0) ? FRigUnit_Add_FloatFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Add_FloatFloat", ref FRigUnit_Add_FloatFloat._ScriptStructPtr);
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x00068A61 File Offset: 0x00066C61
		public FRigUnit_Add_FloatFloat()
		{
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x00068A69 File Offset: 0x00066C69
		public FRigUnit_Add_FloatFloat(float Argument0, float Argument1, float Result)
		{
			base.Argument0 = Argument0;
			base.Argument1 = Argument1;
			base.Result = Result;
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x00068A86 File Offset: 0x00066C86
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Add_FloatFloat.StaticStruct();
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x00068A92 File Offset: 0x00066C92
		[NullableContext(2)]
		public FRigUnit_Add_FloatFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x00068A9C File Offset: 0x00066C9C
		public FRigUnit_Add_FloatFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x00068AA7 File Offset: 0x00066CA7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Add_FloatFloat(Pointer, false, true);
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x00068AB1 File Offset: 0x00066CB1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Add_FloatFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002240 RID: 8768
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Add_FloatFloat";

		// Token: 0x04002241 RID: 8769
		private static IntPtr _ScriptStructPtr;
	}
}
