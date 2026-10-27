using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000579 RID: 1401
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertQuaternionToVector")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_ConvertQuaternionToVector : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A98 RID: 19096 RVA: 0x0006EBDF File Offset: 0x0006CDDF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertQuaternionToVector._ScriptStructPtr != 0) ? FRigUnit_ConvertQuaternionToVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertQuaternionToVector", ref FRigUnit_ConvertQuaternionToVector._ScriptStructPtr);
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06004A99 RID: 19097 RVA: 0x0006EC03 File Offset: 0x0006CE03
		// (set) Token: 0x06004A9A RID: 19098 RVA: 0x0006EC17 File Offset: 0x0006CE17
		public unsafe FQuat Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternionToVector.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternionToVector.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06004A9B RID: 19099 RVA: 0x0006EC2C File Offset: 0x0006CE2C
		// (set) Token: 0x06004A9C RID: 19100 RVA: 0x0006EC40 File Offset: 0x0006CE40
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternionToVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternionToVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x0006EC55 File Offset: 0x0006CE55
		public FRigUnit_ConvertQuaternionToVector()
		{
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x0006EC5D File Offset: 0x0006CE5D
		public FRigUnit_ConvertQuaternionToVector(FQuat Input, FVector Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x0006EC73 File Offset: 0x0006CE73
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertQuaternionToVector.StaticStruct();
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x0006EC7F File Offset: 0x0006CE7F
		[NullableContext(2)]
		public FRigUnit_ConvertQuaternionToVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x0006EC89 File Offset: 0x0006CE89
		public FRigUnit_ConvertQuaternionToVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x0006EC94 File Offset: 0x0006CE94
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertQuaternionToVector(Pointer, false, true);
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x0006EC9E File Offset: 0x0006CE9E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertQuaternionToVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002436 RID: 9270
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertQuaternionToVector";

		// Token: 0x04002437 RID: 9271
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002438 RID: 9272
		internal static int __PropertyOffset_Input;

		// Token: 0x04002439 RID: 9273
		internal static int __PropertyOffset_Result;
	}
}
