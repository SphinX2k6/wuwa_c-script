using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057A RID: 1402
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertRotation")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_ConvertRotation : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004AA4 RID: 19108 RVA: 0x0006ECA7 File Offset: 0x0006CEA7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertRotation._ScriptStructPtr != 0) ? FRigUnit_ConvertRotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertRotation", ref FRigUnit_ConvertRotation._ScriptStructPtr);
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x06004AA5 RID: 19109 RVA: 0x0006ECCB File Offset: 0x0006CECB
		// (set) Token: 0x06004AA6 RID: 19110 RVA: 0x0006ECDF File Offset: 0x0006CEDF
		public unsafe FRotator Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertRotation.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertRotation.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x0006ECF4 File Offset: 0x0006CEF4
		// (set) Token: 0x06004AA8 RID: 19112 RVA: 0x0006ED08 File Offset: 0x0006CF08
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertRotation.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertRotation.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004AA9 RID: 19113 RVA: 0x0006ED1D File Offset: 0x0006CF1D
		public FRigUnit_ConvertRotation()
		{
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x0006ED25 File Offset: 0x0006CF25
		public FRigUnit_ConvertRotation(FRotator Input, FQuat Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x0006ED3B File Offset: 0x0006CF3B
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertRotation.StaticStruct();
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x0006ED47 File Offset: 0x0006CF47
		[NullableContext(2)]
		public FRigUnit_ConvertRotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x0006ED51 File Offset: 0x0006CF51
		public FRigUnit_ConvertRotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x0006ED5C File Offset: 0x0006CF5C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertRotation(Pointer, false, true);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x0006ED66 File Offset: 0x0006CF66
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertRotation(Pointer, MemoryOwner);
		}

		// Token: 0x0400243A RID: 9274
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertRotation";

		// Token: 0x0400243B RID: 9275
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400243C RID: 9276
		internal static int __PropertyOffset_Input;

		// Token: 0x0400243D RID: 9277
		internal static int __PropertyOffset_Result;
	}
}
