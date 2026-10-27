using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BED RID: 3053
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ForceFeedbackComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UForceFeedbackComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009682 RID: 38530 RVA: 0x000D6B35 File Offset: 0x000D4D35
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UForceFeedbackComponent._ClassPtr;
		}

		// Token: 0x06009683 RID: 38531 RVA: 0x000D6B44 File Offset: 0x000D4D44
		public UForceFeedbackComponent() : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009684 RID: 38532 RVA: 0x000D6B6C File Offset: 0x000D4D6C
		[NullableContext(1)]
		public UForceFeedbackComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x06009685 RID: 38533 RVA: 0x000D6B9F File Offset: 0x000D4D9F
		// (set) Token: 0x06009686 RID: 38534 RVA: 0x000D6BB3 File Offset: 0x000D4DB3
		public unsafe UForceFeedbackEffect ForceFeedbackEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UForceFeedbackEffect>(base.NativePtr / (IntPtr)sizeof(void*) + UForceFeedbackComponent.__PropertyOffset_ForceFeedbackEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UForceFeedbackComponent.__PropertyOffset_ForceFeedbackEffect, value);
			}
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x06009687 RID: 38535 RVA: 0x000D6BC8 File Offset: 0x000D4DC8
		// (set) Token: 0x06009688 RID: 38536 RVA: 0x000D6BE1 File Offset: 0x000D4DE1
		public unsafe bool bAutoDestroy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bAutoDestroy) & UForceFeedbackComponent.__PropertyMask_bAutoDestroy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bAutoDestroy) = ((*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bAutoDestroy) & ~UForceFeedbackComponent.__PropertyMask_bAutoDestroy) | (value ? UForceFeedbackComponent.__PropertyMask_bAutoDestroy : 0));
			}
		}

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x06009689 RID: 38537 RVA: 0x000D6C11 File Offset: 0x000D4E11
		// (set) Token: 0x0600968A RID: 38538 RVA: 0x000D6C2A File Offset: 0x000D4E2A
		public unsafe bool bStopWhenOwnerDestroyed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bStopWhenOwnerDestroyed) & UForceFeedbackComponent.__PropertyMask_bStopWhenOwnerDestroyed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bStopWhenOwnerDestroyed) = ((*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bStopWhenOwnerDestroyed) & ~UForceFeedbackComponent.__PropertyMask_bStopWhenOwnerDestroyed) | (value ? UForceFeedbackComponent.__PropertyMask_bStopWhenOwnerDestroyed : 0));
			}
		}

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x0600968B RID: 38539 RVA: 0x000D6C5A File Offset: 0x000D4E5A
		// (set) Token: 0x0600968C RID: 38540 RVA: 0x000D6C73 File Offset: 0x000D4E73
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bLooping) & UForceFeedbackComponent.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bLooping) & ~UForceFeedbackComponent.__PropertyMask_bLooping) | (value ? UForceFeedbackComponent.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0600968D RID: 38541 RVA: 0x000D6CA3 File Offset: 0x000D4EA3
		// (set) Token: 0x0600968E RID: 38542 RVA: 0x000D6CBC File Offset: 0x000D4EBC
		public unsafe bool bIgnoreTimeDilation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bIgnoreTimeDilation) & UForceFeedbackComponent.__PropertyMask_bIgnoreTimeDilation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bIgnoreTimeDilation) = ((*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bIgnoreTimeDilation) & ~UForceFeedbackComponent.__PropertyMask_bIgnoreTimeDilation) | (value ? UForceFeedbackComponent.__PropertyMask_bIgnoreTimeDilation : 0));
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0600968F RID: 38543 RVA: 0x000D6CEC File Offset: 0x000D4EEC
		// (set) Token: 0x06009690 RID: 38544 RVA: 0x000D6D05 File Offset: 0x000D4F05
		public unsafe bool bOverrideAttenuation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bOverrideAttenuation) & UForceFeedbackComponent.__PropertyMask_bOverrideAttenuation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bOverrideAttenuation) = ((*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_bOverrideAttenuation) & ~UForceFeedbackComponent.__PropertyMask_bOverrideAttenuation) | (value ? UForceFeedbackComponent.__PropertyMask_bOverrideAttenuation : 0));
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x06009691 RID: 38545 RVA: 0x000D6D35 File Offset: 0x000D4F35
		// (set) Token: 0x06009692 RID: 38546 RVA: 0x000D6D45 File Offset: 0x000D4F45
		public unsafe float IntensityMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_IntensityMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_IntensityMultiplier) = value;
			}
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x06009693 RID: 38547 RVA: 0x000D6D56 File Offset: 0x000D4F56
		// (set) Token: 0x06009694 RID: 38548 RVA: 0x000D6D6A File Offset: 0x000D4F6A
		public unsafe UForceFeedbackAttenuation AttenuationSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UForceFeedbackAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + UForceFeedbackComponent.__PropertyOffset_AttenuationSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UForceFeedbackComponent.__PropertyOffset_AttenuationSettings, value);
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x06009695 RID: 38549 RVA: 0x000D6D80 File Offset: 0x000D4F80
		// (set) Token: 0x06009696 RID: 38550 RVA: 0x000D6DB9 File Offset: 0x000D4FB9
		[Nullable(1)]
		public FForceFeedbackAttenuationSettings AttenuationOverrides
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FForceFeedbackAttenuationSettings result;
				if ((result = this._AttenuationOverrides) == null)
				{
					result = (this._AttenuationOverrides = new FForceFeedbackAttenuationSettings(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_AttenuationOverrides, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FForceFeedbackAttenuationSettings.StaticStruct(), base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_AttenuationOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x06009697 RID: 38551 RVA: 0x000D6DDC File Offset: 0x000D4FDC
		// (set) Token: 0x06009698 RID: 38552 RVA: 0x000D6E15 File Offset: 0x000D5015
		[Nullable(1)]
		public FOnForceFeedbackFinished OnForceFeedbackFinished
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnForceFeedbackFinished result;
				if ((result = this._OnForceFeedbackFinished) == null)
				{
					result = (this._OnForceFeedbackFinished = new FOnForceFeedbackFinished(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_OnForceFeedbackFinished, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UForceFeedbackComponent.__PropertyOffset_OnForceFeedbackFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06009699 RID: 38553 RVA: 0x000D6E36 File Offset: 0x000D5036
		public void Stop()
		{
			UForceFeedbackComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0600969A RID: 38554 RVA: 0x000D6E43 File Offset: 0x000D5043
		public void SetIntensityMultiplier(float NewIntensityMultiplier)
		{
			UForceFeedbackComponent.__SetIntensityMultiplier_Internal(base.NativePtr, NewIntensityMultiplier);
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x000D6E51 File Offset: 0x000D5051
		public void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect)
		{
			UForceFeedbackComponent.__SetForceFeedbackEffect_Internal(base.NativePtr, (NewForceFeedbackEffect != null) ? NewForceFeedbackEffect.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x000D6E6E File Offset: 0x000D506E
		public void Play(float StartTime = 0f)
		{
			UForceFeedbackComponent.__Play_Internal(base.NativePtr, StartTime);
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x000D6E7C File Offset: 0x000D507C
		public bool BP_GetAttenuationSettingsToApply(ref FForceFeedbackAttenuationSettings OutAttenuationSettings)
		{
			return UForceFeedbackComponent.__BP_GetAttenuationSettingsToApply_Internal(base.NativePtr, (OutAttenuationSettings ?? new FForceFeedbackAttenuationSettings()).NativePtr);
		}

		// Token: 0x0600969E RID: 38558 RVA: 0x000D6E99 File Offset: 0x000D5099
		public void AdjustAttenuation(in FForceFeedbackAttenuationSettings InAttenuationSettings)
		{
			UForceFeedbackComponent.__AdjustAttenuation_Internal(base.NativePtr, (InAttenuationSettings ?? new FForceFeedbackAttenuationSettings()).NativePtr);
		}

		// Token: 0x0600969F RID: 38559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060096A0 RID: 38560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntensityMultiplier_Internal(IntPtr @this, float NewIntensityMultiplier);

		// Token: 0x060096A1 RID: 38561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceFeedbackEffect_Internal(IntPtr @this, IntPtr NewForceFeedbackEffect);

		// Token: 0x060096A2 RID: 38562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, float StartTime);

		// Token: 0x060096A3 RID: 38563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BP_GetAttenuationSettingsToApply_Internal(IntPtr @this, IntPtr OutAttenuationSettings);

		// Token: 0x060096A4 RID: 38564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AdjustAttenuation_Internal(IntPtr @this, IntPtr InAttenuationSettings);

		// Token: 0x060096A5 RID: 38565 RVA: 0x000D6EB6 File Offset: 0x000D50B6
		static UForceFeedbackComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ForceFeedbackComponent");
		}

		// Token: 0x060096A6 RID: 38566 RVA: 0x000D6EC4 File Offset: 0x000D50C4
		protected UForceFeedbackComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005471 RID: 21617
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ForceFeedbackComponent";

		// Token: 0x04005472 RID: 21618
		private static IntPtr _ClassPtr;

		// Token: 0x04005473 RID: 21619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005474 RID: 21620
		internal static int __PropertyOffset_ForceFeedbackEffect;

		// Token: 0x04005475 RID: 21621
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x04005476 RID: 21622
		internal static byte __PropertyMask_bAutoDestroy;

		// Token: 0x04005477 RID: 21623
		internal static int __PropertyOffset_bStopWhenOwnerDestroyed;

		// Token: 0x04005478 RID: 21624
		internal static byte __PropertyMask_bStopWhenOwnerDestroyed;

		// Token: 0x04005479 RID: 21625
		internal static int __PropertyOffset_bLooping;

		// Token: 0x0400547A RID: 21626
		internal static byte __PropertyMask_bLooping;

		// Token: 0x0400547B RID: 21627
		internal static int __PropertyOffset_bIgnoreTimeDilation;

		// Token: 0x0400547C RID: 21628
		internal static byte __PropertyMask_bIgnoreTimeDilation;

		// Token: 0x0400547D RID: 21629
		internal static int __PropertyOffset_bOverrideAttenuation;

		// Token: 0x0400547E RID: 21630
		internal static byte __PropertyMask_bOverrideAttenuation;

		// Token: 0x0400547F RID: 21631
		internal static int __PropertyOffset_IntensityMultiplier;

		// Token: 0x04005480 RID: 21632
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x04005481 RID: 21633
		internal static int __PropertyOffset_AttenuationOverrides;

		// Token: 0x04005482 RID: 21634
		private FForceFeedbackAttenuationSettings _AttenuationOverrides;

		// Token: 0x04005483 RID: 21635
		internal static int __PropertyOffset_OnForceFeedbackFinished;

		// Token: 0x04005484 RID: 21636
		private FOnForceFeedbackFinished _OnForceFeedbackFinished;
	}
}
