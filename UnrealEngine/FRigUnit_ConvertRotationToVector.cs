using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057B RID: 1403
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertRotationToVector")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_ConvertRotationToVector : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004AB0 RID: 19120 RVA: 0x0006ED6F File Offset: 0x0006CF6F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertRotationToVector._ScriptStructPtr != 0) ? FRigUnit_ConvertRotationToVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertRotationToVector", ref FRigUnit_ConvertRotationToVector._ScriptStructPtr);
		}

		// Token: 0x17001241 RID: 4673
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x0006ED93 File Offset: 0x0006CF93
		// (set) Token: 0x06004AB2 RID: 19122 RVA: 0x0006EDA7 File Offset: 0x0006CFA7
		public unsafe FRotator Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertRotationToVector.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertRotationToVector.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x0006EDBC File Offset: 0x0006CFBC
		// (set) Token: 0x06004AB4 RID: 19124 RVA: 0x0006EDD0 File Offset: 0x0006CFD0
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertRotationToVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertRotationToVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x0006EDE5 File Offset: 0x0006CFE5
		public FRigUnit_ConvertRotationToVector()
		{
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x0006EDED File Offset: 0x0006CFED
		public FRigUnit_ConvertRotationToVector(FRotator Input, FVector Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x0006EE03 File Offset: 0x0006D003
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertRotationToVector.StaticStruct();
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x0006EE0F File Offset: 0x0006D00F
		[NullableContext(2)]
		public FRigUnit_ConvertRotationToVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x0006EE19 File Offset: 0x0006D019
		public FRigUnit_ConvertRotationToVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x0006EE24 File Offset: 0x0006D024
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertRotationToVector(Pointer, false, true);
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x0006EE2E File Offset: 0x0006D02E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertRotationToVector(Pointer, MemoryOwner);
		}

		// Token: 0x0400243E RID: 9278
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertRotationToVector";

		// Token: 0x0400243F RID: 9279
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002440 RID: 9280
		internal static int __PropertyOffset_Input;

		// Token: 0x04002441 RID: 9281
		internal static int __PropertyOffset_Result;
	}
}
