using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006A0 RID: 1696
	[UnrealObjectPath("/Script/ControlRig.RigUnit_NoiseVector")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_NoiseVector : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005A13 RID: 23059 RVA: 0x00081468 File Offset: 0x0007F668
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_NoiseVector._ScriptStructPtr != 0) ? FRigUnit_NoiseVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_NoiseVector", ref FRigUnit_NoiseVector._ScriptStructPtr);
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06005A14 RID: 23060 RVA: 0x0008148C File Offset: 0x0007F68C
		// (set) Token: 0x06005A15 RID: 23061 RVA: 0x000814A0 File Offset: 0x0007F6A0
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06005A16 RID: 23062 RVA: 0x000814B5 File Offset: 0x0007F6B5
		// (set) Token: 0x06005A17 RID: 23063 RVA: 0x000814C9 File Offset: 0x0007F6C9
		public unsafe FVector Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06005A18 RID: 23064 RVA: 0x000814DE File Offset: 0x0007F6DE
		// (set) Token: 0x06005A19 RID: 23065 RVA: 0x000814F2 File Offset: 0x0007F6F2
		public unsafe FVector Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x06005A1A RID: 23066 RVA: 0x00081507 File Offset: 0x0007F707
		// (set) Token: 0x06005A1B RID: 23067 RVA: 0x00081517 File Offset: 0x0007F717
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06005A1C RID: 23068 RVA: 0x00081528 File Offset: 0x0007F728
		// (set) Token: 0x06005A1D RID: 23069 RVA: 0x00081538 File Offset: 0x0007F738
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06005A1E RID: 23070 RVA: 0x00081549 File Offset: 0x0007F749
		// (set) Token: 0x06005A1F RID: 23071 RVA: 0x0008155D File Offset: 0x0007F75D
		public unsafe FVector Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06005A20 RID: 23072 RVA: 0x00081572 File Offset: 0x0007F772
		// (set) Token: 0x06005A21 RID: 23073 RVA: 0x00081586 File Offset: 0x0007F786
		public unsafe FVector Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseVector.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x0008159B File Offset: 0x0007F79B
		public FRigUnit_NoiseVector()
		{
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x000815A3 File Offset: 0x0007F7A3
		public FRigUnit_NoiseVector(FVector Position, FVector Speed, FVector Frequency, float Minimum, float Maximum, FVector Result, FVector Time)
		{
			this.Position = Position;
			this.Speed = Speed;
			this.Frequency = Frequency;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.Result = Result;
			this.Time = Time;
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x000815E0 File Offset: 0x0007F7E0
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_NoiseVector.StaticStruct();
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x000815EC File Offset: 0x0007F7EC
		[NullableContext(2)]
		public FRigUnit_NoiseVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x000815F6 File Offset: 0x0007F7F6
		public FRigUnit_NoiseVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00081601 File Offset: 0x0007F801
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_NoiseVector(Pointer, false, true);
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x0008160B File Offset: 0x0007F80B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_NoiseVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002A28 RID: 10792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_NoiseVector";

		// Token: 0x04002A29 RID: 10793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A2A RID: 10794
		internal static int __PropertyOffset_Position;

		// Token: 0x04002A2B RID: 10795
		internal static int __PropertyOffset_Speed;

		// Token: 0x04002A2C RID: 10796
		internal static int __PropertyOffset_Frequency;

		// Token: 0x04002A2D RID: 10797
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002A2E RID: 10798
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002A2F RID: 10799
		internal static int __PropertyOffset_Result;

		// Token: 0x04002A30 RID: 10800
		internal static int __PropertyOffset_Time;
	}
}
