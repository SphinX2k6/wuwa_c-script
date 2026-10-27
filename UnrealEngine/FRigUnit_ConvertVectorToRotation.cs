using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200057F RID: 1407
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertVectorToRotation")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_ConvertVectorToRotation : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004ADC RID: 19164 RVA: 0x0006F078 File Offset: 0x0006D278
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertVectorToRotation._ScriptStructPtr != 0) ? FRigUnit_ConvertVectorToRotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertVectorToRotation", ref FRigUnit_ConvertVectorToRotation._ScriptStructPtr);
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x06004ADD RID: 19165 RVA: 0x0006F09C File Offset: 0x0006D29C
		// (set) Token: 0x06004ADE RID: 19166 RVA: 0x0006F0B0 File Offset: 0x0006D2B0
		public unsafe FVector Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToRotation.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToRotation.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x06004ADF RID: 19167 RVA: 0x0006F0C5 File Offset: 0x0006D2C5
		// (set) Token: 0x06004AE0 RID: 19168 RVA: 0x0006F0D9 File Offset: 0x0006D2D9
		public unsafe FRotator Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToRotation.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertVectorToRotation.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x0006F0EE File Offset: 0x0006D2EE
		public FRigUnit_ConvertVectorToRotation()
		{
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0006F0F6 File Offset: 0x0006D2F6
		public FRigUnit_ConvertVectorToRotation(FVector Input, FRotator Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x0006F10C File Offset: 0x0006D30C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertVectorToRotation.StaticStruct();
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x0006F118 File Offset: 0x0006D318
		[NullableContext(2)]
		public FRigUnit_ConvertVectorToRotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x0006F122 File Offset: 0x0006D322
		public FRigUnit_ConvertVectorToRotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x0006F12D File Offset: 0x0006D32D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertVectorToRotation(Pointer, false, true);
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x0006F137 File Offset: 0x0006D337
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertVectorToRotation(Pointer, MemoryOwner);
		}

		// Token: 0x0400244D RID: 9293
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertVectorToRotation";

		// Token: 0x0400244E RID: 9294
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400244F RID: 9295
		internal static int __PropertyOffset_Input;

		// Token: 0x04002450 RID: 9296
		internal static int __PropertyOffset_Result;
	}
}
