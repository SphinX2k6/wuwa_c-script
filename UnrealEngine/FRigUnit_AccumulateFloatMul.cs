using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000532 RID: 1330
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateFloatMul")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_AccumulateFloatMul : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060045B6 RID: 17846 RVA: 0x00067ABC File Offset: 0x00065CBC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateFloatMul._ScriptStructPtr != 0) ? FRigUnit_AccumulateFloatMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateFloatMul", ref FRigUnit_AccumulateFloatMul._ScriptStructPtr);
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x060045B7 RID: 17847 RVA: 0x00067AE0 File Offset: 0x00065CE0
		// (set) Token: 0x060045B8 RID: 17848 RVA: 0x00067AF0 File Offset: 0x00065CF0
		public unsafe float Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_Multiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_Multiplier) = value;
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x060045B9 RID: 17849 RVA: 0x00067B01 File Offset: 0x00065D01
		// (set) Token: 0x060045BA RID: 17850 RVA: 0x00067B11 File Offset: 0x00065D11
		public unsafe float InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x060045BB RID: 17851 RVA: 0x00067B22 File Offset: 0x00065D22
		// (set) Token: 0x060045BC RID: 17852 RVA: 0x00067B32 File Offset: 0x00065D32
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x060045BD RID: 17853 RVA: 0x00067B43 File Offset: 0x00065D43
		// (set) Token: 0x060045BE RID: 17854 RVA: 0x00067B53 File Offset: 0x00065D53
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x060045BF RID: 17855 RVA: 0x00067B64 File Offset: 0x00065D64
		// (set) Token: 0x060045C0 RID: 17856 RVA: 0x00067B74 File Offset: 0x00065D74
		public unsafe float AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateFloatMul.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00067B85 File Offset: 0x00065D85
		public FRigUnit_AccumulateFloatMul()
		{
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00067B8D File Offset: 0x00065D8D
		public FRigUnit_AccumulateFloatMul(float Multiplier, float InitialValue, bool bIntegrateDeltaTime, float Result, float AccumulatedValue)
		{
			this.Multiplier = Multiplier;
			this.InitialValue = InitialValue;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00067BBA File Offset: 0x00065DBA
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateFloatMul.StaticStruct();
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00067BC6 File Offset: 0x00065DC6
		[NullableContext(2)]
		public FRigUnit_AccumulateFloatMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00067BD0 File Offset: 0x00065DD0
		public FRigUnit_AccumulateFloatMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00067BDB File Offset: 0x00065DDB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateFloatMul(Pointer, false, true);
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00067BE5 File Offset: 0x00065DE5
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateFloatMul(Pointer, MemoryOwner);
		}

		// Token: 0x040021EC RID: 8684
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateFloatMul";

		// Token: 0x040021ED RID: 8685
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021EE RID: 8686
		internal static int __PropertyOffset_Multiplier;

		// Token: 0x040021EF RID: 8687
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x040021F0 RID: 8688
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x040021F1 RID: 8689
		internal static int __PropertyOffset_Result;

		// Token: 0x040021F2 RID: 8690
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
