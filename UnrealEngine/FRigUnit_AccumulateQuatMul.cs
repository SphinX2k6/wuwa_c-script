using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000535 RID: 1333
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateQuatMul")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_AccumulateQuatMul : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060045EE RID: 17902 RVA: 0x00067E9B File Offset: 0x0006609B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateQuatMul._ScriptStructPtr != 0) ? FRigUnit_AccumulateQuatMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateQuatMul", ref FRigUnit_AccumulateQuatMul._ScriptStructPtr);
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x060045EF RID: 17903 RVA: 0x00067EBF File Offset: 0x000660BF
		// (set) Token: 0x060045F0 RID: 17904 RVA: 0x00067ED3 File Offset: 0x000660D3
		public unsafe FQuat Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_Multiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_Multiplier) = value;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x060045F1 RID: 17905 RVA: 0x00067EE8 File Offset: 0x000660E8
		// (set) Token: 0x060045F2 RID: 17906 RVA: 0x00067EFC File Offset: 0x000660FC
		public unsafe FQuat InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x060045F3 RID: 17907 RVA: 0x00067F11 File Offset: 0x00066111
		// (set) Token: 0x060045F4 RID: 17908 RVA: 0x00067F21 File Offset: 0x00066121
		public unsafe bool bFlipOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_bFlipOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_bFlipOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x00067F32 File Offset: 0x00066132
		// (set) Token: 0x060045F6 RID: 17910 RVA: 0x00067F42 File Offset: 0x00066142
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x00067F53 File Offset: 0x00066153
		// (set) Token: 0x060045F8 RID: 17912 RVA: 0x00067F67 File Offset: 0x00066167
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x00067F7C File Offset: 0x0006617C
		// (set) Token: 0x060045FA RID: 17914 RVA: 0x00067F90 File Offset: 0x00066190
		public unsafe FQuat AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatMul.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x060045FB RID: 17915 RVA: 0x00067FA5 File Offset: 0x000661A5
		public FRigUnit_AccumulateQuatMul()
		{
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x00067FAD File Offset: 0x000661AD
		public FRigUnit_AccumulateQuatMul(FQuat Multiplier, FQuat InitialValue, bool bFlipOrder, bool bIntegrateDeltaTime, FQuat Result, FQuat AccumulatedValue)
		{
			this.Multiplier = Multiplier;
			this.InitialValue = InitialValue;
			this.bFlipOrder = bFlipOrder;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x00067FE2 File Offset: 0x000661E2
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateQuatMul.StaticStruct();
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x00067FEE File Offset: 0x000661EE
		[NullableContext(2)]
		public FRigUnit_AccumulateQuatMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00067FF8 File Offset: 0x000661F8
		public FRigUnit_AccumulateQuatMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00068003 File Offset: 0x00066203
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateQuatMul(Pointer, false, true);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x0006800D File Offset: 0x0006620D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateQuatMul(Pointer, MemoryOwner);
		}

		// Token: 0x04002202 RID: 8706
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateQuatMul";

		// Token: 0x04002203 RID: 8707
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002204 RID: 8708
		internal static int __PropertyOffset_Multiplier;

		// Token: 0x04002205 RID: 8709
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x04002206 RID: 8710
		internal static int __PropertyOffset_bFlipOrder;

		// Token: 0x04002207 RID: 8711
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x04002208 RID: 8712
		internal static int __PropertyOffset_Result;

		// Token: 0x04002209 RID: 8713
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
