using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000536 RID: 1334
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateTransformLerp")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_AccumulateTransformLerp : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004602 RID: 17922 RVA: 0x00068016 File Offset: 0x00066216
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateTransformLerp._ScriptStructPtr != 0) ? FRigUnit_AccumulateTransformLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateTransformLerp", ref FRigUnit_AccumulateTransformLerp._ScriptStructPtr);
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06004603 RID: 17923 RVA: 0x0006803A File Offset: 0x0006623A
		// (set) Token: 0x06004604 RID: 17924 RVA: 0x0006804E File Offset: 0x0006624E
		public unsafe FTransform TargetValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_TargetValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_TargetValue) = value;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06004605 RID: 17925 RVA: 0x00068063 File Offset: 0x00066263
		// (set) Token: 0x06004606 RID: 17926 RVA: 0x00068077 File Offset: 0x00066277
		public unsafe FTransform InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x0006808C File Offset: 0x0006628C
		// (set) Token: 0x06004608 RID: 17928 RVA: 0x0006809C File Offset: 0x0006629C
		public unsafe float Blend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_Blend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_Blend) = value;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06004609 RID: 17929 RVA: 0x000680AD File Offset: 0x000662AD
		// (set) Token: 0x0600460A RID: 17930 RVA: 0x000680BD File Offset: 0x000662BD
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x0600460B RID: 17931 RVA: 0x000680CE File Offset: 0x000662CE
		// (set) Token: 0x0600460C RID: 17932 RVA: 0x000680E2 File Offset: 0x000662E2
		public unsafe FTransform Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x000680F7 File Offset: 0x000662F7
		// (set) Token: 0x0600460E RID: 17934 RVA: 0x0006810B File Offset: 0x0006630B
		public unsafe FTransform AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateTransformLerp.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x0600460F RID: 17935 RVA: 0x00068120 File Offset: 0x00066320
		public FRigUnit_AccumulateTransformLerp()
		{
		}

		// Token: 0x06004610 RID: 17936 RVA: 0x00068128 File Offset: 0x00066328
		public FRigUnit_AccumulateTransformLerp(FTransform TargetValue, FTransform InitialValue, float Blend, bool bIntegrateDeltaTime, FTransform Result, FTransform AccumulatedValue)
		{
			this.TargetValue = TargetValue;
			this.InitialValue = InitialValue;
			this.Blend = Blend;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x06004611 RID: 17937 RVA: 0x0006815D File Offset: 0x0006635D
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateTransformLerp.StaticStruct();
		}

		// Token: 0x06004612 RID: 17938 RVA: 0x00068169 File Offset: 0x00066369
		[NullableContext(2)]
		public FRigUnit_AccumulateTransformLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004613 RID: 17939 RVA: 0x00068173 File Offset: 0x00066373
		public FRigUnit_AccumulateTransformLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004614 RID: 17940 RVA: 0x0006817E File Offset: 0x0006637E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateTransformLerp(Pointer, false, true);
		}

		// Token: 0x06004615 RID: 17941 RVA: 0x00068188 File Offset: 0x00066388
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateTransformLerp(Pointer, MemoryOwner);
		}

		// Token: 0x0400220A RID: 8714
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateTransformLerp";

		// Token: 0x0400220B RID: 8715
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400220C RID: 8716
		internal static int __PropertyOffset_TargetValue;

		// Token: 0x0400220D RID: 8717
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x0400220E RID: 8718
		internal static int __PropertyOffset_Blend;

		// Token: 0x0400220F RID: 8719
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x04002210 RID: 8720
		internal static int __PropertyOffset_Result;

		// Token: 0x04002211 RID: 8721
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
