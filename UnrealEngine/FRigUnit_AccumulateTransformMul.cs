using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000537 RID: 1335
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateTransformMul")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_AccumulateTransformMul : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004616 RID: 17942 RVA: 0x00068191 File Offset: 0x00066391
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateTransformMul._ScriptStructPtr != 0) ? FRigUnit_AccumulateTransformMul._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateTransformMul", ref FRigUnit_AccumulateTransformMul._ScriptStructPtr);
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x000681B5 File Offset: 0x000663B5
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x000681C9 File Offset: 0x000663C9
		public unsafe FTransform Multiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_Multiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_Multiplier) = value;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x000681DE File Offset: 0x000663DE
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x000681F2 File Offset: 0x000663F2
		public unsafe FTransform InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x00068207 File Offset: 0x00066407
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x00068217 File Offset: 0x00066417
		public unsafe bool bFlipOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_bFlipOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_bFlipOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x00068228 File Offset: 0x00066428
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x00068238 File Offset: 0x00066438
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x00068249 File Offset: 0x00066449
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x0006825D File Offset: 0x0006645D
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x00068272 File Offset: 0x00066472
		// (set) Token: 0x06004622 RID: 17954 RVA: 0x00068286 File Offset: 0x00066486
		public unsafe FTransform AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformMul.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x0006829B File Offset: 0x0006649B
		public FRigUnit_AccumulateTransformMul()
		{
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x000682A3 File Offset: 0x000664A3
		public FRigUnit_AccumulateTransformMul(FTransform Multiplier, FTransform InitialValue, bool bFlipOrder, bool bIntegrateDeltaTime, FTransform Result, FTransform AccumulatedValue)
		{
			this.Multiplier = Multiplier;
			this.InitialValue = InitialValue;
			this.bFlipOrder = bFlipOrder;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x000682D8 File Offset: 0x000664D8
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateTransformMul.StaticStruct();
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x000682E4 File Offset: 0x000664E4
		[NullableContext(2)]
		public FRigUnit_AccumulateTransformMul(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x000682EE File Offset: 0x000664EE
		public FRigUnit_AccumulateTransformMul(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x000682F9 File Offset: 0x000664F9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateTransformMul(Pointer, false, true);
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00068303 File Offset: 0x00066503
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateTransformMul(Pointer, MemoryOwner);
		}

		// Token: 0x04002212 RID: 8722
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateTransformMul";

		// Token: 0x04002213 RID: 8723
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002214 RID: 8724
		internal static int __PropertyOffset_Multiplier;

		// Token: 0x04002215 RID: 8725
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x04002216 RID: 8726
		internal static int __PropertyOffset_bFlipOrder;

		// Token: 0x04002217 RID: 8727
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x04002218 RID: 8728
		internal static int __PropertyOffset_Result;

		// Token: 0x04002219 RID: 8729
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
