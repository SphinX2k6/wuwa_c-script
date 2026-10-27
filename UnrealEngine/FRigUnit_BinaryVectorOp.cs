using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000553 RID: 1363
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BinaryVectorOp")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_BinaryVectorOp : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600480F RID: 18447 RVA: 0x0006AE1F File Offset: 0x0006901F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BinaryVectorOp._ScriptStructPtr != 0) ? FRigUnit_BinaryVectorOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BinaryVectorOp", ref FRigUnit_BinaryVectorOp._ScriptStructPtr);
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06004810 RID: 18448 RVA: 0x0006AE43 File Offset: 0x00069043
		// (set) Token: 0x06004811 RID: 18449 RVA: 0x0006AE57 File Offset: 0x00069057
		public unsafe FVector Argument0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryVectorOp.__PropertyOffset_Argument0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryVectorOp.__PropertyOffset_Argument0) = value;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x0006AE6C File Offset: 0x0006906C
		// (set) Token: 0x06004813 RID: 18451 RVA: 0x0006AE80 File Offset: 0x00069080
		public unsafe FVector Argument1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryVectorOp.__PropertyOffset_Argument1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryVectorOp.__PropertyOffset_Argument1) = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x0006AE95 File Offset: 0x00069095
		// (set) Token: 0x06004815 RID: 18453 RVA: 0x0006AEA9 File Offset: 0x000690A9
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryVectorOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryVectorOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x0006AEBE File Offset: 0x000690BE
		public FRigUnit_BinaryVectorOp()
		{
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x0006AEC6 File Offset: 0x000690C6
		public FRigUnit_BinaryVectorOp(FVector Argument0, FVector Argument1, FVector Result)
		{
			this.Argument0 = Argument0;
			this.Argument1 = Argument1;
			this.Result = Result;
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x0006AEE3 File Offset: 0x000690E3
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BinaryVectorOp.StaticStruct();
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x0006AEEF File Offset: 0x000690EF
		[NullableContext(2)]
		public FRigUnit_BinaryVectorOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600481A RID: 18458 RVA: 0x0006AEF9 File Offset: 0x000690F9
		public FRigUnit_BinaryVectorOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x0006AF04 File Offset: 0x00069104
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BinaryVectorOp(Pointer, false, true);
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x0006AF0E File Offset: 0x0006910E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BinaryVectorOp(Pointer, MemoryOwner);
		}

		// Token: 0x040022F9 RID: 8953
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BinaryVectorOp";

		// Token: 0x040022FA RID: 8954
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022FB RID: 8955
		internal static int __PropertyOffset_Argument0;

		// Token: 0x040022FC RID: 8956
		internal static int __PropertyOffset_Argument1;

		// Token: 0x040022FD RID: 8957
		internal static int __PropertyOffset_Result;
	}
}
