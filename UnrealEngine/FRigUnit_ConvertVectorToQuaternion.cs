using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057E RID: 1406
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertVectorToQuaternion")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_ConvertVectorToQuaternion : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004AD0 RID: 19152 RVA: 0x0006EFB0 File Offset: 0x0006D1B0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertVectorToQuaternion._ScriptStructPtr != 0) ? FRigUnit_ConvertVectorToQuaternion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertVectorToQuaternion", ref FRigUnit_ConvertVectorToQuaternion._ScriptStructPtr);
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x06004AD1 RID: 19153 RVA: 0x0006EFD4 File Offset: 0x0006D1D4
		// (set) Token: 0x06004AD2 RID: 19154 RVA: 0x0006EFE8 File Offset: 0x0006D1E8
		public unsafe FVector Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToQuaternion.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToQuaternion.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x0006EFFD File Offset: 0x0006D1FD
		// (set) Token: 0x06004AD4 RID: 19156 RVA: 0x0006F011 File Offset: 0x0006D211
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToQuaternion.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToQuaternion.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x0006F026 File Offset: 0x0006D226
		public FRigUnit_ConvertVectorToQuaternion()
		{
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x0006F02E File Offset: 0x0006D22E
		public FRigUnit_ConvertVectorToQuaternion(FVector Input, FQuat Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0006F044 File Offset: 0x0006D244
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertVectorToQuaternion.StaticStruct();
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0006F050 File Offset: 0x0006D250
		[NullableContext(2)]
		public FRigUnit_ConvertVectorToQuaternion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0006F05A File Offset: 0x0006D25A
		public FRigUnit_ConvertVectorToQuaternion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0006F065 File Offset: 0x0006D265
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertVectorToQuaternion(Pointer, false, true);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0006F06F File Offset: 0x0006D26F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertVectorToQuaternion(Pointer, MemoryOwner);
		}

		// Token: 0x04002449 RID: 9289
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertVectorToQuaternion";

		// Token: 0x0400244A RID: 9290
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400244B RID: 9291
		internal static int __PropertyOffset_Input;

		// Token: 0x0400244C RID: 9292
		internal static int __PropertyOffset_Result;
	}
}
