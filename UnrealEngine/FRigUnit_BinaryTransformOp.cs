using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000552 RID: 1362
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BinaryTransformOp")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_BinaryTransformOp : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004801 RID: 18433 RVA: 0x0006AD27 File Offset: 0x00068F27
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BinaryTransformOp._ScriptStructPtr != 0) ? FRigUnit_BinaryTransformOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BinaryTransformOp", ref FRigUnit_BinaryTransformOp._ScriptStructPtr);
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06004802 RID: 18434 RVA: 0x0006AD4B File Offset: 0x00068F4B
		// (set) Token: 0x06004803 RID: 18435 RVA: 0x0006AD5F File Offset: 0x00068F5F
		public unsafe FTransform Argument0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryTransformOp.__PropertyOffset_Argument0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryTransformOp.__PropertyOffset_Argument0) = value;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06004804 RID: 18436 RVA: 0x0006AD74 File Offset: 0x00068F74
		// (set) Token: 0x06004805 RID: 18437 RVA: 0x0006AD88 File Offset: 0x00068F88
		public unsafe FTransform Argument1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryTransformOp.__PropertyOffset_Argument1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryTransformOp.__PropertyOffset_Argument1) = value;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06004806 RID: 18438 RVA: 0x0006AD9D File Offset: 0x00068F9D
		// (set) Token: 0x06004807 RID: 18439 RVA: 0x0006ADB1 File Offset: 0x00068FB1
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryTransformOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryTransformOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x0006ADC6 File Offset: 0x00068FC6
		public FRigUnit_BinaryTransformOp()
		{
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x0006ADCE File Offset: 0x00068FCE
		public FRigUnit_BinaryTransformOp(FTransform Argument0, FTransform Argument1, FTransform Result)
		{
			this.Argument0 = Argument0;
			this.Argument1 = Argument1;
			this.Result = Result;
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x0006ADEB File Offset: 0x00068FEB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BinaryTransformOp.StaticStruct();
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x0006ADF7 File Offset: 0x00068FF7
		[NullableContext(2)]
		public FRigUnit_BinaryTransformOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x0006AE01 File Offset: 0x00069001
		public FRigUnit_BinaryTransformOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x0006AE0C File Offset: 0x0006900C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BinaryTransformOp(Pointer, false, true);
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x0006AE16 File Offset: 0x00069016
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BinaryTransformOp(Pointer, MemoryOwner);
		}

		// Token: 0x040022F4 RID: 8948
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BinaryTransformOp";

		// Token: 0x040022F5 RID: 8949
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022F6 RID: 8950
		internal static int __PropertyOffset_Argument0;

		// Token: 0x040022F7 RID: 8951
		internal static int __PropertyOffset_Argument1;

		// Token: 0x040022F8 RID: 8952
		internal static int __PropertyOffset_Result;
	}
}
