using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000621 RID: 1569
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntLess")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntLess : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053FD RID: 21501 RVA: 0x0007A60A File Offset: 0x0007880A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntLess._ScriptStructPtr != 0) ? FRigUnit_MathIntLess._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntLess", ref FRigUnit_MathIntLess._ScriptStructPtr);
		}

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x060053FE RID: 21502 RVA: 0x0007A62E File Offset: 0x0007882E
		// (set) Token: 0x060053FF RID: 21503 RVA: 0x0007A63E File Offset: 0x0007883E
		public unsafe int A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntLess.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntLess.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06005400 RID: 21504 RVA: 0x0007A64F File Offset: 0x0007884F
		// (set) Token: 0x06005401 RID: 21505 RVA: 0x0007A65F File Offset: 0x0007885F
		public unsafe int B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntLess.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntLess.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x0007A670 File Offset: 0x00078870
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x0007A680 File Offset: 0x00078880
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntLess.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntLess.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005404 RID: 21508 RVA: 0x0007A691 File Offset: 0x00078891
		public FRigUnit_MathIntLess()
		{
		}

		// Token: 0x06005405 RID: 21509 RVA: 0x0007A699 File Offset: 0x00078899
		public FRigUnit_MathIntLess(int A, int B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005406 RID: 21510 RVA: 0x0007A6B6 File Offset: 0x000788B6
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntLess.StaticStruct();
		}

		// Token: 0x06005407 RID: 21511 RVA: 0x0007A6C2 File Offset: 0x000788C2
		[NullableContext(2)]
		public FRigUnit_MathIntLess(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005408 RID: 21512 RVA: 0x0007A6CC File Offset: 0x000788CC
		public FRigUnit_MathIntLess(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x0007A6D7 File Offset: 0x000788D7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntLess(Pointer, false, true);
		}

		// Token: 0x0600540A RID: 21514 RVA: 0x0007A6E1 File Offset: 0x000788E1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntLess(Pointer, MemoryOwner);
		}

		// Token: 0x040027FE RID: 10238
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntLess";

		// Token: 0x040027FF RID: 10239
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002800 RID: 10240
		internal static int __PropertyOffset_A;

		// Token: 0x04002801 RID: 10241
		internal static int __PropertyOffset_B;

		// Token: 0x04002802 RID: 10242
		internal static int __PropertyOffset_Result;
	}
}
