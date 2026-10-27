using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200061B RID: 1563
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathIntClamp")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathIntClamp : FRigUnit_MathIntBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060053A7 RID: 21415 RVA: 0x0007A061 File Offset: 0x00078261
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathIntClamp._ScriptStructPtr != 0) ? FRigUnit_MathIntClamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathIntClamp", ref FRigUnit_MathIntClamp._ScriptStructPtr);
		}

		// Token: 0x17001441 RID: 5185
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x0007A085 File Offset: 0x00078285
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x0007A095 File Offset: 0x00078295
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x060053AA RID: 21418 RVA: 0x0007A0A6 File Offset: 0x000782A6
		// (set) Token: 0x060053AB RID: 21419 RVA: 0x0007A0B6 File Offset: 0x000782B6
		public unsafe int Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x060053AC RID: 21420 RVA: 0x0007A0C7 File Offset: 0x000782C7
		// (set) Token: 0x060053AD RID: 21421 RVA: 0x0007A0D7 File Offset: 0x000782D7
		public unsafe int Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x060053AE RID: 21422 RVA: 0x0007A0E8 File Offset: 0x000782E8
		// (set) Token: 0x060053AF RID: 21423 RVA: 0x0007A0F8 File Offset: 0x000782F8
		public unsafe int Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathIntClamp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x0007A109 File Offset: 0x00078309
		public FRigUnit_MathIntClamp()
		{
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x0007A111 File Offset: 0x00078311
		public FRigUnit_MathIntClamp(int Value, int Minimum, int Maximum, int Result)
		{
			this.Value = Value;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.Result = Result;
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x0007A136 File Offset: 0x00078336
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathIntClamp.StaticStruct();
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x0007A142 File Offset: 0x00078342
		[NullableContext(2)]
		public FRigUnit_MathIntClamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x0007A14C File Offset: 0x0007834C
		public FRigUnit_MathIntClamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x0007A157 File Offset: 0x00078357
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathIntClamp(Pointer, false, true);
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x0007A161 File Offset: 0x00078361
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathIntClamp(Pointer, MemoryOwner);
		}

		// Token: 0x040027DF RID: 10207
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathIntClamp";

		// Token: 0x040027E0 RID: 10208
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040027E1 RID: 10209
		internal static int __PropertyOffset_Value;

		// Token: 0x040027E2 RID: 10210
		internal static int __PropertyOffset_Minimum;

		// Token: 0x040027E3 RID: 10211
		internal static int __PropertyOffset_Maximum;

		// Token: 0x040027E4 RID: 10212
		internal static int __PropertyOffset_Result;
	}
}
