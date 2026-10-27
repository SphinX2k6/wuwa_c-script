using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005D6 RID: 1494
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MapRange_Float")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_MapRange_Float : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060050C0 RID: 20672 RVA: 0x000772C7 File Offset: 0x000754C7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MapRange_Float._ScriptStructPtr != 0) ? FRigUnit_MapRange_Float._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MapRange_Float", ref FRigUnit_MapRange_Float._ScriptStructPtr);
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060050C1 RID: 20673 RVA: 0x000772EB File Offset: 0x000754EB
		// (set) Token: 0x060050C2 RID: 20674 RVA: 0x000772FB File Offset: 0x000754FB
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060050C3 RID: 20675 RVA: 0x0007730C File Offset: 0x0007550C
		// (set) Token: 0x060050C4 RID: 20676 RVA: 0x0007731C File Offset: 0x0007551C
		public unsafe float MinIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MinIn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MinIn) = value;
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060050C5 RID: 20677 RVA: 0x0007732D File Offset: 0x0007552D
		// (set) Token: 0x060050C6 RID: 20678 RVA: 0x0007733D File Offset: 0x0007553D
		public unsafe float MaxIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MaxIn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MaxIn) = value;
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x0007734E File Offset: 0x0007554E
		// (set) Token: 0x060050C8 RID: 20680 RVA: 0x0007735E File Offset: 0x0007555E
		public unsafe float MinOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MinOut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MinOut) = value;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060050C9 RID: 20681 RVA: 0x0007736F File Offset: 0x0007556F
		// (set) Token: 0x060050CA RID: 20682 RVA: 0x0007737F File Offset: 0x0007557F
		public unsafe float MaxOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MaxOut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_MaxOut) = value;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x00077390 File Offset: 0x00075590
		// (set) Token: 0x060050CC RID: 20684 RVA: 0x000773A0 File Offset: 0x000755A0
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MapRange_Float.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x000773B1 File Offset: 0x000755B1
		public FRigUnit_MapRange_Float()
		{
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x000773B9 File Offset: 0x000755B9
		public FRigUnit_MapRange_Float(float Value, float MinIn, float MaxIn, float MinOut, float MaxOut, float Result)
		{
			this.Value = Value;
			this.MinIn = MinIn;
			this.MaxIn = MaxIn;
			this.MinOut = MinOut;
			this.MaxOut = MaxOut;
			this.Result = Result;
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x000773EE File Offset: 0x000755EE
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MapRange_Float.StaticStruct();
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x000773FA File Offset: 0x000755FA
		[NullableContext(2)]
		public FRigUnit_MapRange_Float(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00077404 File Offset: 0x00075604
		public FRigUnit_MapRange_Float(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x0007740F File Offset: 0x0007560F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MapRange_Float(Pointer, false, true);
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x00077419 File Offset: 0x00075619
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MapRange_Float(Pointer, MemoryOwner);
		}

		// Token: 0x040026F3 RID: 9971
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MapRange_Float";

		// Token: 0x040026F4 RID: 9972
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040026F5 RID: 9973
		internal static int __PropertyOffset_Value;

		// Token: 0x040026F6 RID: 9974
		internal static int __PropertyOffset_MinIn;

		// Token: 0x040026F7 RID: 9975
		internal static int __PropertyOffset_MaxIn;

		// Token: 0x040026F8 RID: 9976
		internal static int __PropertyOffset_MinOut;

		// Token: 0x040026F9 RID: 9977
		internal static int __PropertyOffset_MaxOut;

		// Token: 0x040026FA RID: 9978
		internal static int __PropertyOffset_Result;
	}
}
