using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200069F RID: 1695
	[UnrealObjectPath("/Script/ControlRig.RigUnit_NoiseFloat")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_NoiseFloat : FRigUnit_MathBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060059FD RID: 23037 RVA: 0x000812E4 File Offset: 0x0007F4E4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_NoiseFloat._ScriptStructPtr != 0) ? FRigUnit_NoiseFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_NoiseFloat", ref FRigUnit_NoiseFloat._ScriptStructPtr);
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x00081308 File Offset: 0x0007F508
		// (set) Token: 0x060059FF RID: 23039 RVA: 0x00081318 File Offset: 0x0007F518
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06005A00 RID: 23040 RVA: 0x00081329 File Offset: 0x0007F529
		// (set) Token: 0x06005A01 RID: 23041 RVA: 0x00081339 File Offset: 0x0007F539
		public unsafe float Speed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Speed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Speed) = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x0008134A File Offset: 0x0007F54A
		// (set) Token: 0x06005A03 RID: 23043 RVA: 0x0008135A File Offset: 0x0007F55A
		public unsafe float Frequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Frequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Frequency) = value;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06005A04 RID: 23044 RVA: 0x0008136B File Offset: 0x0007F56B
		// (set) Token: 0x06005A05 RID: 23045 RVA: 0x0008137B File Offset: 0x0007F57B
		public unsafe float Minimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Minimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Minimum) = value;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06005A06 RID: 23046 RVA: 0x0008138C File Offset: 0x0007F58C
		// (set) Token: 0x06005A07 RID: 23047 RVA: 0x0008139C File Offset: 0x0007F59C
		public unsafe float Maximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Maximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Maximum) = value;
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06005A08 RID: 23048 RVA: 0x000813AD File Offset: 0x0007F5AD
		// (set) Token: 0x06005A09 RID: 23049 RVA: 0x000813BD File Offset: 0x0007F5BD
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06005A0A RID: 23050 RVA: 0x000813CE File Offset: 0x0007F5CE
		// (set) Token: 0x06005A0B RID: 23051 RVA: 0x000813DE File Offset: 0x0007F5DE
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_NoiseFloat.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x000813EF File Offset: 0x0007F5EF
		public FRigUnit_NoiseFloat()
		{
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x000813F7 File Offset: 0x0007F5F7
		public FRigUnit_NoiseFloat(float Value, float Speed, float Frequency, float Minimum, float Maximum, float Result, float Time)
		{
			this.Value = Value;
			this.Speed = Speed;
			this.Frequency = Frequency;
			this.Minimum = Minimum;
			this.Maximum = Maximum;
			this.Result = Result;
			this.Time = Time;
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x00081434 File Offset: 0x0007F634
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_NoiseFloat.StaticStruct();
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x00081440 File Offset: 0x0007F640
		[NullableContext(2)]
		public FRigUnit_NoiseFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x0008144A File Offset: 0x0007F64A
		public FRigUnit_NoiseFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x00081455 File Offset: 0x0007F655
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_NoiseFloat(Pointer, false, true);
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x0008145F File Offset: 0x0007F65F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_NoiseFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002A1F RID: 10783
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_NoiseFloat";

		// Token: 0x04002A20 RID: 10784
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A21 RID: 10785
		internal static int __PropertyOffset_Value;

		// Token: 0x04002A22 RID: 10786
		internal static int __PropertyOffset_Speed;

		// Token: 0x04002A23 RID: 10787
		internal static int __PropertyOffset_Frequency;

		// Token: 0x04002A24 RID: 10788
		internal static int __PropertyOffset_Minimum;

		// Token: 0x04002A25 RID: 10789
		internal static int __PropertyOffset_Maximum;

		// Token: 0x04002A26 RID: 10790
		internal static int __PropertyOffset_Result;

		// Token: 0x04002A27 RID: 10791
		internal static int __PropertyOffset_Time;
	}
}
