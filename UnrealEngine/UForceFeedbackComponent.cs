using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200020F RID: 527
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ForceFeedbackComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UForceFeedbackComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x0003186E File Offset: 0x0002FA6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UForceFeedbackComponent._ClassPtr;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0003187C File Offset: 0x0002FA7C
		public UForceFeedbackComponent() : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000318A4 File Offset: 0x0002FAA4
		[NullableContext(1)]
		public UForceFeedbackComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060021CD RID: 8653 RVA: 0x000318D7 File Offset: 0x0002FAD7
		// (set) Token: 0x060021CE RID: 8654 RVA: 0x000318EB File Offset: 0x0002FAEB
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

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060021CF RID: 8655 RVA: 0x00031900 File Offset: 0x0002FB00
		// (set) Token: 0x060021D0 RID: 8656 RVA: 0x00031919 File Offset: 0x0002FB19
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

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00031949 File Offset: 0x0002FB49
		// (set) Token: 0x060021D2 RID: 8658 RVA: 0x00031962 File Offset: 0x0002FB62
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

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060021D3 RID: 8659 RVA: 0x00031992 File Offset: 0x0002FB92
		// (set) Token: 0x060021D4 RID: 8660 RVA: 0x000319AB File Offset: 0x0002FBAB
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

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060021D5 RID: 8661 RVA: 0x000319DB File Offset: 0x0002FBDB
		// (set) Token: 0x060021D6 RID: 8662 RVA: 0x000319F4 File Offset: 0x0002FBF4
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

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x00031A24 File Offset: 0x0002FC24
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x00031A3D File Offset: 0x0002FC3D
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

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x00031A6D File Offset: 0x0002FC6D
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00031A7D File Offset: 0x0002FC7D
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

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060021DB RID: 8667 RVA: 0x00031A8E File Offset: 0x0002FC8E
		// (set) Token: 0x060021DC RID: 8668 RVA: 0x00031AA2 File Offset: 0x0002FCA2
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

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060021DD RID: 8669 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		// (set) Token: 0x060021DE RID: 8670 RVA: 0x00031AF1 File Offset: 0x0002FCF1
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

		// Token: 0x060021DF RID: 8671 RVA: 0x00031B12 File Offset: 0x0002FD12
		public void Stop()
		{
			UForceFeedbackComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00031B1F File Offset: 0x0002FD1F
		public void SetIntensityMultiplier(float NewIntensityMultiplier)
		{
			UForceFeedbackComponent.__SetIntensityMultiplier_Internal(base.NativePtr, NewIntensityMultiplier);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00031B2D File Offset: 0x0002FD2D
		public void SetForceFeedbackEffect(UForceFeedbackEffect NewForceFeedbackEffect)
		{
			UForceFeedbackComponent.__SetForceFeedbackEffect_Internal(base.NativePtr, (NewForceFeedbackEffect != null) ? NewForceFeedbackEffect.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00031B4A File Offset: 0x0002FD4A
		public void Play(float StartTime = 0f)
		{
			UForceFeedbackComponent.__Play_Internal(base.NativePtr, StartTime);
		}

		// Token: 0x060021E3 RID: 8675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060021E4 RID: 8676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntensityMultiplier_Internal(IntPtr @this, float NewIntensityMultiplier);

		// Token: 0x060021E5 RID: 8677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceFeedbackEffect_Internal(IntPtr @this, IntPtr NewForceFeedbackEffect);

		// Token: 0x060021E6 RID: 8678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, float StartTime);

		// Token: 0x060021E7 RID: 8679 RVA: 0x00031B58 File Offset: 0x0002FD58
		static UForceFeedbackComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ForceFeedbackComponent");
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00031B66 File Offset: 0x0002FD66
		protected UForceFeedbackComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000D36 RID: 3382
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ForceFeedbackComponent";

		// Token: 0x04000D37 RID: 3383
		private static IntPtr _ClassPtr;

		// Token: 0x04000D38 RID: 3384
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000D39 RID: 3385
		internal static int __PropertyOffset_ForceFeedbackEffect;

		// Token: 0x04000D3A RID: 3386
		internal static int __PropertyOffset_bAutoDestroy;

		// Token: 0x04000D3B RID: 3387
		internal static byte __PropertyMask_bAutoDestroy;

		// Token: 0x04000D3C RID: 3388
		internal static int __PropertyOffset_bStopWhenOwnerDestroyed;

		// Token: 0x04000D3D RID: 3389
		internal static byte __PropertyMask_bStopWhenOwnerDestroyed;

		// Token: 0x04000D3E RID: 3390
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04000D3F RID: 3391
		internal static byte __PropertyMask_bLooping;

		// Token: 0x04000D40 RID: 3392
		internal static int __PropertyOffset_bIgnoreTimeDilation;

		// Token: 0x04000D41 RID: 3393
		internal static byte __PropertyMask_bIgnoreTimeDilation;

		// Token: 0x04000D42 RID: 3394
		internal static int __PropertyOffset_bOverrideAttenuation;

		// Token: 0x04000D43 RID: 3395
		internal static byte __PropertyMask_bOverrideAttenuation;

		// Token: 0x04000D44 RID: 3396
		internal static int __PropertyOffset_IntensityMultiplier;

		// Token: 0x04000D45 RID: 3397
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x04000D46 RID: 3398
		internal static int __PropertyOffset_OnForceFeedbackFinished;

		// Token: 0x04000D47 RID: 3399
		private FOnForceFeedbackFinished _OnForceFeedbackFinished;
	}
}
