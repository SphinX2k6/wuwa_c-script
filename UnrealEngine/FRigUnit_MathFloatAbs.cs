using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005EB RID: 1515
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatAbs")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatAbs : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600519B RID: 20891 RVA: 0x00078045 File Offset: 0x00076245
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatAbs._ScriptStructPtr != 0) ? FRigUnit_MathFloatAbs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatAbs", ref FRigUnit_MathFloatAbs._ScriptStructPtr);
		}

		// Token: 0x0600519C RID: 20892 RVA: 0x00078069 File Offset: 0x00076269
		public FRigUnit_MathFloatAbs()
		{
		}

		// Token: 0x0600519D RID: 20893 RVA: 0x00078071 File Offset: 0x00076271
		public FRigUnit_MathFloatAbs(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x0600519E RID: 20894 RVA: 0x00078087 File Offset: 0x00076287
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatAbs.StaticStruct();
		}

		// Token: 0x0600519F RID: 20895 RVA: 0x00078093 File Offset: 0x00076293
		[NullableContext(2)]
		public FRigUnit_MathFloatAbs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060051A0 RID: 20896 RVA: 0x0007809D File Offset: 0x0007629D
		public FRigUnit_MathFloatAbs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060051A1 RID: 20897 RVA: 0x000780A8 File Offset: 0x000762A8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatAbs(Pointer, false, true);
		}

		// Token: 0x060051A2 RID: 20898 RVA: 0x000780B2 File Offset: 0x000762B2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatAbs(Pointer, MemoryOwner);
		}

		// Token: 0x04002738 RID: 10040
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatAbs";

		// Token: 0x04002739 RID: 10041
		private static IntPtr _ScriptStructPtr;
	}
}
