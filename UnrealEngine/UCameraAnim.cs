using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000907 RID: 2311
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraAnim")]
	[UnrealStructLayout(2720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2720)]
	public class UCameraAnim : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007ED4 RID: 32468 RVA: 0x000B5F2E File Offset: 0x000B412E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraAnim._ClassPtr;
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x000B5F3C File Offset: 0x000B413C
		public UCameraAnim() : this(BuiltinUtils.AllocNativeUObject(UCameraAnim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x000B5F64 File Offset: 0x000B4164
		public UCameraAnim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraAnim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x06007ED7 RID: 32471 RVA: 0x000B5F97 File Offset: 0x000B4197
		// (set) Token: 0x06007ED8 RID: 32472 RVA: 0x000B5FAB File Offset: 0x000B41AB
		[Nullable(2)]
		public unsafe UInterpGroup CameraInterpGroup
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpGroup>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnim.__PropertyOffset_CameraInterpGroup);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnim.__PropertyOffset_CameraInterpGroup, value);
			}
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x06007ED9 RID: 32473 RVA: 0x000B5FC0 File Offset: 0x000B41C0
		// (set) Token: 0x06007EDA RID: 32474 RVA: 0x000B5FD0 File Offset: 0x000B41D0
		public unsafe float AnimLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_AnimLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_AnimLength) = value;
			}
		}

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x06007EDB RID: 32475 RVA: 0x000B5FE1 File Offset: 0x000B41E1
		// (set) Token: 0x06007EDC RID: 32476 RVA: 0x000B5FF5 File Offset: 0x000B41F5
		public unsafe FBox BoundingBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BoundingBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BoundingBox) = value;
			}
		}

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x06007EDD RID: 32477 RVA: 0x000B600A File Offset: 0x000B420A
		// (set) Token: 0x06007EDE RID: 32478 RVA: 0x000B6023 File Offset: 0x000B4223
		public unsafe bool bRelativeToInitialTransform
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_bRelativeToInitialTransform) & UCameraAnim.__PropertyMask_bRelativeToInitialTransform) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_bRelativeToInitialTransform) = ((*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_bRelativeToInitialTransform) & ~UCameraAnim.__PropertyMask_bRelativeToInitialTransform) | (value ? UCameraAnim.__PropertyMask_bRelativeToInitialTransform : 0));
			}
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x06007EDF RID: 32479 RVA: 0x000B6053 File Offset: 0x000B4253
		// (set) Token: 0x06007EE0 RID: 32480 RVA: 0x000B606C File Offset: 0x000B426C
		public unsafe bool bRelativeToInitialFOV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_bRelativeToInitialFOV) & UCameraAnim.__PropertyMask_bRelativeToInitialFOV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_bRelativeToInitialFOV) = ((*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_bRelativeToInitialFOV) & ~UCameraAnim.__PropertyMask_bRelativeToInitialFOV) | (value ? UCameraAnim.__PropertyMask_bRelativeToInitialFOV : 0));
			}
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x06007EE1 RID: 32481 RVA: 0x000B609C File Offset: 0x000B429C
		// (set) Token: 0x06007EE2 RID: 32482 RVA: 0x000B60AC File Offset: 0x000B42AC
		public unsafe float BaseFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BaseFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BaseFOV) = value;
			}
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x06007EE3 RID: 32483 RVA: 0x000B60C0 File Offset: 0x000B42C0
		// (set) Token: 0x06007EE4 RID: 32484 RVA: 0x000B60F9 File Offset: 0x000B42F9
		public FPostProcessSettings BasePostProcessSettings
		{
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._BasePostProcessSettings) == null)
				{
					result = (this._BasePostProcessSettings = new FPostProcessSettings(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BasePostProcessSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BasePostProcessSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x06007EE5 RID: 32485 RVA: 0x000B611A File Offset: 0x000B431A
		// (set) Token: 0x06007EE6 RID: 32486 RVA: 0x000B612A File Offset: 0x000B432A
		public unsafe float BasePostProcessBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BasePostProcessBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraAnim.__PropertyOffset_BasePostProcessBlendWeight) = value;
			}
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x000B613B File Offset: 0x000B433B
		static UCameraAnim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraAnim");
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x000B6149 File Offset: 0x000B4349
		protected UCameraAnim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CD9 RID: 15577
		public new const string __ObjectPath = "/Script/Engine.CameraAnim";

		// Token: 0x04003CDA RID: 15578
		private static IntPtr _ClassPtr;

		// Token: 0x04003CDB RID: 15579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003CDC RID: 15580
		internal static int __PropertyOffset_CameraInterpGroup;

		// Token: 0x04003CDD RID: 15581
		internal static int __PropertyOffset_AnimLength;

		// Token: 0x04003CDE RID: 15582
		internal static int __PropertyOffset_BoundingBox;

		// Token: 0x04003CDF RID: 15583
		internal static int __PropertyOffset_bRelativeToInitialTransform;

		// Token: 0x04003CE0 RID: 15584
		internal static byte __PropertyMask_bRelativeToInitialTransform;

		// Token: 0x04003CE1 RID: 15585
		internal static int __PropertyOffset_bRelativeToInitialFOV;

		// Token: 0x04003CE2 RID: 15586
		internal static byte __PropertyMask_bRelativeToInitialFOV;

		// Token: 0x04003CE3 RID: 15587
		internal static int __PropertyOffset_BaseFOV;

		// Token: 0x04003CE4 RID: 15588
		internal static int __PropertyOffset_BasePostProcessSettings;

		// Token: 0x04003CE5 RID: 15589
		[Nullable(2)]
		private FPostProcessSettings _BasePostProcessSettings;

		// Token: 0x04003CE6 RID: 15590
		internal static int __PropertyOffset_BasePostProcessBlendWeight;
	}
}
