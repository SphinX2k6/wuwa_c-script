using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000550 RID: 1360
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BinaryFloatOp")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_BinaryFloatOp : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060047E5 RID: 18405 RVA: 0x0006AB4F File Offset: 0x00068D4F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BinaryFloatOp._ScriptStructPtr != 0) ? FRigUnit_BinaryFloatOp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BinaryFloatOp", ref FRigUnit_BinaryFloatOp._ScriptStructPtr);
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060047E6 RID: 18406 RVA: 0x0006AB73 File Offset: 0x00068D73
		// (set) Token: 0x060047E7 RID: 18407 RVA: 0x0006AB83 File Offset: 0x00068D83
		public unsafe float Argument0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryFloatOp.__PropertyOffset_Argument0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryFloatOp.__PropertyOffset_Argument0) = value;
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x0006AB94 File Offset: 0x00068D94
		// (set) Token: 0x060047E9 RID: 18409 RVA: 0x0006ABA4 File Offset: 0x00068DA4
		public unsafe float Argument1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryFloatOp.__PropertyOffset_Argument1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryFloatOp.__PropertyOffset_Argument1) = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x0006ABB5 File Offset: 0x00068DB5
		// (set) Token: 0x060047EB RID: 18411 RVA: 0x0006ABC5 File Offset: 0x00068DC5
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BinaryFloatOp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BinaryFloatOp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x0006ABD6 File Offset: 0x00068DD6
		public FRigUnit_BinaryFloatOp()
		{
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x0006ABDE File Offset: 0x00068DDE
		public FRigUnit_BinaryFloatOp(float Argument0, float Argument1, float Result)
		{
			this.Argument0 = Argument0;
			this.Argument1 = Argument1;
			this.Result = Result;
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x0006ABFB File Offset: 0x00068DFB
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BinaryFloatOp.StaticStruct();
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x0006AC07 File Offset: 0x00068E07
		[NullableContext(2)]
		public FRigUnit_BinaryFloatOp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x0006AC11 File Offset: 0x00068E11
		public FRigUnit_BinaryFloatOp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x0006AC1C File Offset: 0x00068E1C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BinaryFloatOp(Pointer, false, true);
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x0006AC26 File Offset: 0x00068E26
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BinaryFloatOp(Pointer, MemoryOwner);
		}

		// Token: 0x040022EA RID: 8938
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BinaryFloatOp";

		// Token: 0x040022EB RID: 8939
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040022EC RID: 8940
		internal static int __PropertyOffset_Argument0;

		// Token: 0x040022ED RID: 8941
		internal static int __PropertyOffset_Argument1;

		// Token: 0x040022EE RID: 8942
		internal static int __PropertyOffset_Result;
	}
}
