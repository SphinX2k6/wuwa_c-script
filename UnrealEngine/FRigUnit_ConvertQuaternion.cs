using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000578 RID: 1400
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ConvertQuaternion")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_ConvertQuaternion : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A8C RID: 19084 RVA: 0x0006EB17 File Offset: 0x0006CD17
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ConvertQuaternion._ScriptStructPtr != 0) ? FRigUnit_ConvertQuaternion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ConvertQuaternion", ref FRigUnit_ConvertQuaternion._ScriptStructPtr);
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06004A8D RID: 19085 RVA: 0x0006EB3B File Offset: 0x0006CD3B
		// (set) Token: 0x06004A8E RID: 19086 RVA: 0x0006EB4F File Offset: 0x0006CD4F
		public unsafe FQuat Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternion.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternion.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06004A8F RID: 19087 RVA: 0x0006EB64 File Offset: 0x0006CD64
		// (set) Token: 0x06004A90 RID: 19088 RVA: 0x0006EB78 File Offset: 0x0006CD78
		public unsafe FRotator Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternion.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ConvertQuaternion.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004A91 RID: 19089 RVA: 0x0006EB8D File Offset: 0x0006CD8D
		public FRigUnit_ConvertQuaternion()
		{
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x0006EB95 File Offset: 0x0006CD95
		public FRigUnit_ConvertQuaternion(FQuat Input, FRotator Result)
		{
			this.Input = Input;
			this.Result = Result;
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x0006EBAB File Offset: 0x0006CDAB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ConvertQuaternion.StaticStruct();
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x0006EBB7 File Offset: 0x0006CDB7
		[NullableContext(2)]
		public FRigUnit_ConvertQuaternion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A95 RID: 19093 RVA: 0x0006EBC1 File Offset: 0x0006CDC1
		public FRigUnit_ConvertQuaternion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A96 RID: 19094 RVA: 0x0006EBCC File Offset: 0x0006CDCC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ConvertQuaternion(Pointer, false, true);
		}

		// Token: 0x06004A97 RID: 19095 RVA: 0x0006EBD6 File Offset: 0x0006CDD6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ConvertQuaternion(Pointer, MemoryOwner);
		}

		// Token: 0x04002432 RID: 9266
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ConvertQuaternion";

		// Token: 0x04002433 RID: 9267
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002434 RID: 9268
		internal static int __PropertyOffset_Input;

		// Token: 0x04002435 RID: 9269
		internal static int __PropertyOffset_Result;
	}
}
