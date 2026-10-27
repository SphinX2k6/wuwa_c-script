using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005F9 RID: 1529
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatDeg")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_MathFloatDeg : FRigUnit_MathFloatUnaryOp, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005220 RID: 21024 RVA: 0x00078816 File Offset: 0x00076A16
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatDeg._ScriptStructPtr != 0) ? FRigUnit_MathFloatDeg._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatDeg", ref FRigUnit_MathFloatDeg._ScriptStructPtr);
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x0007883A File Offset: 0x00076A3A
		public FRigUnit_MathFloatDeg()
		{
		}

		// Token: 0x06005222 RID: 21026 RVA: 0x00078842 File Offset: 0x00076A42
		public FRigUnit_MathFloatDeg(float Value, float Result)
		{
			base.Value = Value;
			base.Result = Result;
		}

		// Token: 0x06005223 RID: 21027 RVA: 0x00078858 File Offset: 0x00076A58
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatDeg.StaticStruct();
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00078864 File Offset: 0x00076A64
		[NullableContext(2)]
		public FRigUnit_MathFloatDeg(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x0007886E File Offset: 0x00076A6E
		public FRigUnit_MathFloatDeg(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00078879 File Offset: 0x00076A79
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatDeg(Pointer, false, true);
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00078883 File Offset: 0x00076A83
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatDeg(Pointer, MemoryOwner);
		}

		// Token: 0x0400275F RID: 10079
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatDeg";

		// Token: 0x04002760 RID: 10080
		private static IntPtr _ScriptStructPtr;
	}
}
