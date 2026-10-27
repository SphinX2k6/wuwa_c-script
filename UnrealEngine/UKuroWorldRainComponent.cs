using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BE9 RID: 7145
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponent")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 800)]
	public class UKuroWorldRainComponent : UKuroRainComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B7C1 RID: 112577 RVA: 0x00287952 File Offset: 0x00285B52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroWorldRainComponent._ClassPtr;
		}

		// Token: 0x0601B7C2 RID: 112578 RVA: 0x00287960 File Offset: 0x00285B60
		public UKuroWorldRainComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B7C3 RID: 112579 RVA: 0x00287988 File Offset: 0x00285B88
		[NullableContext(1)]
		public UKuroWorldRainComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroWorldRainComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006E99 RID: 28313
		// (get) Token: 0x0601B7C4 RID: 112580 RVA: 0x002879BB File Offset: 0x00285BBB
		// (set) Token: 0x0601B7C5 RID: 112581 RVA: 0x002879CF File Offset: 0x00285BCF
		public unsafe UKuroWorldRainComponentSpawnConfig SpawnConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldRainComponentSpawnConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponent.__PropertyOffset_SpawnConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponent.__PropertyOffset_SpawnConfig, value);
			}
		}

		// Token: 0x17006E9A RID: 28314
		// (get) Token: 0x0601B7C6 RID: 112582 RVA: 0x002879E4 File Offset: 0x00285BE4
		// (set) Token: 0x0601B7C7 RID: 112583 RVA: 0x002879F8 File Offset: 0x00285BF8
		public unsafe UKuroWorldRainComponentPhysicsConfig PhysicsConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldRainComponentPhysicsConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponent.__PropertyOffset_PhysicsConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponent.__PropertyOffset_PhysicsConfig, value);
			}
		}

		// Token: 0x17006E9B RID: 28315
		// (get) Token: 0x0601B7C8 RID: 112584 RVA: 0x00287A0D File Offset: 0x00285C0D
		// (set) Token: 0x0601B7C9 RID: 112585 RVA: 0x00287A21 File Offset: 0x00285C21
		public unsafe UKuroWorldRainComponentCustomDataConfig CustomDataConfig
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroWorldRainComponentCustomDataConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponent.__PropertyOffset_CustomDataConfig);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroWorldRainComponent.__PropertyOffset_CustomDataConfig, value);
			}
		}

		// Token: 0x17006E9C RID: 28316
		// (get) Token: 0x0601B7CA RID: 112586 RVA: 0x00287A36 File Offset: 0x00285C36
		// (set) Token: 0x0601B7CB RID: 112587 RVA: 0x00287A4F File Offset: 0x00285C4F
		public unsafe bool bOverridePhysics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_bOverridePhysics) & UKuroWorldRainComponent.__PropertyMask_bOverridePhysics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_bOverridePhysics) = ((*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_bOverridePhysics) & ~UKuroWorldRainComponent.__PropertyMask_bOverridePhysics) | (value ? UKuroWorldRainComponent.__PropertyMask_bOverridePhysics : 0));
			}
		}

		// Token: 0x17006E9D RID: 28317
		// (get) Token: 0x0601B7CC RID: 112588 RVA: 0x00287A7F File Offset: 0x00285C7F
		// (set) Token: 0x0601B7CD RID: 112589 RVA: 0x00287A8F File Offset: 0x00285C8F
		public unsafe float WindSizeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_WindSizeOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_WindSizeOverride) = value;
			}
		}

		// Token: 0x17006E9E RID: 28318
		// (get) Token: 0x0601B7CE RID: 112590 RVA: 0x00287AA0 File Offset: 0x00285CA0
		// (set) Token: 0x0601B7CF RID: 112591 RVA: 0x00287AB4 File Offset: 0x00285CB4
		public unsafe FVector GravityOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_GravityOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_GravityOverride) = value;
			}
		}

		// Token: 0x17006E9F RID: 28319
		// (get) Token: 0x0601B7D0 RID: 112592 RVA: 0x00287AC9 File Offset: 0x00285CC9
		// (set) Token: 0x0601B7D1 RID: 112593 RVA: 0x00287AD9 File Offset: 0x00285CD9
		public unsafe float DragOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_DragOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_DragOverride) = value;
			}
		}

		// Token: 0x17006EA0 RID: 28320
		// (get) Token: 0x0601B7D2 RID: 112594 RVA: 0x00287AEA File Offset: 0x00285CEA
		// (set) Token: 0x0601B7D3 RID: 112595 RVA: 0x00287AFA File Offset: 0x00285CFA
		public unsafe float SpawnScaleOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_SpawnScaleOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_SpawnScaleOverride) = value;
			}
		}

		// Token: 0x17006EA1 RID: 28321
		// (get) Token: 0x0601B7D4 RID: 112596 RVA: 0x00287B0B File Offset: 0x00285D0B
		// (set) Token: 0x0601B7D5 RID: 112597 RVA: 0x00287B1B File Offset: 0x00285D1B
		public unsafe float TimeDilationOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_TimeDilationOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_TimeDilationOverride) = value;
			}
		}

		// Token: 0x17006EA2 RID: 28322
		// (get) Token: 0x0601B7D6 RID: 112598 RVA: 0x00287B2C File Offset: 0x00285D2C
		// (set) Token: 0x0601B7D7 RID: 112599 RVA: 0x00287B3C File Offset: 0x00285D3C
		public unsafe float PassTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_PassTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_PassTime) = value;
			}
		}

		// Token: 0x17006EA3 RID: 28323
		// (get) Token: 0x0601B7D8 RID: 112600 RVA: 0x00287B4D File Offset: 0x00285D4D
		// (set) Token: 0x0601B7D9 RID: 112601 RVA: 0x00287B5D File Offset: 0x00285D5D
		public unsafe float BaseSpawnScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_BaseSpawnScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_BaseSpawnScale) = value;
			}
		}

		// Token: 0x17006EA4 RID: 28324
		// (get) Token: 0x0601B7DA RID: 112602 RVA: 0x00287B6E File Offset: 0x00285D6E
		// (set) Token: 0x0601B7DB RID: 112603 RVA: 0x00287B82 File Offset: 0x00285D82
		public unsafe FVector GlobalWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_GlobalWind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_GlobalWind) = value;
			}
		}

		// Token: 0x17006EA5 RID: 28325
		// (get) Token: 0x0601B7DC RID: 112604 RVA: 0x00287B97 File Offset: 0x00285D97
		// (set) Token: 0x0601B7DD RID: 112605 RVA: 0x00287BAB File Offset: 0x00285DAB
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroWorldRainComponent.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x0601B7DE RID: 112606 RVA: 0x00287BC0 File Offset: 0x00285DC0
		public void StopRain()
		{
			UKuroWorldRainComponent.__StopRain_Internal(base.NativePtr);
		}

		// Token: 0x0601B7DF RID: 112607 RVA: 0x00287BCD File Offset: 0x00285DCD
		public void StartRain()
		{
			UKuroWorldRainComponent.__StartRain_Internal(base.NativePtr);
		}

		// Token: 0x0601B7E0 RID: 112608 RVA: 0x00287BDA File Offset: 0x00285DDA
		public void SetGlobalWind(in FVector InGlobalWind)
		{
			UKuroWorldRainComponent.__SetGlobalWind_Internal(base.NativePtr, InGlobalWind);
		}

		// Token: 0x0601B7E1 RID: 112609 RVA: 0x00287BE8 File Offset: 0x00285DE8
		public void SetCenter(in FVector InCenter)
		{
			UKuroWorldRainComponent.__SetCenter_Internal(base.NativePtr, InCenter);
		}

		// Token: 0x0601B7E2 RID: 112610 RVA: 0x00287BF6 File Offset: 0x00285DF6
		public void SetBaseSpawnScale(float SpawnScale)
		{
			UKuroWorldRainComponent.__SetBaseSpawnScale_Internal(base.NativePtr, SpawnScale);
		}

		// Token: 0x0601B7E3 RID: 112611 RVA: 0x00287C04 File Offset: 0x00285E04
		public virtual void OnReceiveStopRain()
		{
			UKuroWorldRainComponent.__OnReceiveStopRain_Internal(base.NativePtr);
		}

		// Token: 0x0601B7E4 RID: 112612 RVA: 0x00287C11 File Offset: 0x00285E11
		public virtual void OnReceiveStartRain()
		{
			UKuroWorldRainComponent.__OnReceiveStartRain_Internal(base.NativePtr);
		}

		// Token: 0x0601B7E5 RID: 112613 RVA: 0x00287C1E File Offset: 0x00285E1E
		public virtual void OnReceiveDeactivateRain()
		{
			UKuroWorldRainComponent.__OnReceiveDeactivateRain_Internal(base.NativePtr);
		}

		// Token: 0x0601B7E6 RID: 112614 RVA: 0x00287C2B File Offset: 0x00285E2B
		public bool GetIsRainPlaying()
		{
			return UKuroWorldRainComponent.__GetIsRainPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0601B7E7 RID: 112615 RVA: 0x00287C38 File Offset: 0x00285E38
		public bool GetIsRainActive()
		{
			return UKuroWorldRainComponent.__GetIsRainActive_Internal(base.NativePtr);
		}

		// Token: 0x0601B7E8 RID: 112616 RVA: 0x00287C45 File Offset: 0x00285E45
		public void DeactivateRain()
		{
			UKuroWorldRainComponent.__DeactivateRain_Internal(base.NativePtr);
		}

		// Token: 0x0601B7E9 RID: 112617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopRain_Internal(IntPtr @this);

		// Token: 0x0601B7EA RID: 112618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartRain_Internal(IntPtr @this);

		// Token: 0x0601B7EB RID: 112619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGlobalWind_Internal(IntPtr @this, in FVector InGlobalWind);

		// Token: 0x0601B7EC RID: 112620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCenter_Internal(IntPtr @this, in FVector InCenter);

		// Token: 0x0601B7ED RID: 112621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBaseSpawnScale_Internal(IntPtr @this, float SpawnScale);

		// Token: 0x0601B7EE RID: 112622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveStopRain_Internal(IntPtr @this);

		// Token: 0x0601B7EF RID: 112623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveStartRain_Internal(IntPtr @this);

		// Token: 0x0601B7F0 RID: 112624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnReceiveDeactivateRain_Internal(IntPtr @this);

		// Token: 0x0601B7F1 RID: 112625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsRainPlaying_Internal(IntPtr @this);

		// Token: 0x0601B7F2 RID: 112626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsRainActive_Internal(IntPtr @this);

		// Token: 0x0601B7F3 RID: 112627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateRain_Internal(IntPtr @this);

		// Token: 0x0601B7F4 RID: 112628 RVA: 0x00287C52 File Offset: 0x00285E52
		static UKuroWorldRainComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponent");
		}

		// Token: 0x0601B7F5 RID: 112629 RVA: 0x00287C60 File Offset: 0x00285E60
		protected UKuroWorldRainComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EC9C RID: 60572
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWorldRainComponent";

		// Token: 0x0400EC9D RID: 60573
		private static IntPtr _ClassPtr;

		// Token: 0x0400EC9E RID: 60574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EC9F RID: 60575
		internal static int __PropertyOffset_SpawnConfig;

		// Token: 0x0400ECA0 RID: 60576
		internal static int __PropertyOffset_PhysicsConfig;

		// Token: 0x0400ECA1 RID: 60577
		internal static int __PropertyOffset_CustomDataConfig;

		// Token: 0x0400ECA2 RID: 60578
		internal static int __PropertyOffset_bOverridePhysics;

		// Token: 0x0400ECA3 RID: 60579
		internal static byte __PropertyMask_bOverridePhysics;

		// Token: 0x0400ECA4 RID: 60580
		internal static int __PropertyOffset_WindSizeOverride;

		// Token: 0x0400ECA5 RID: 60581
		internal static int __PropertyOffset_GravityOverride;

		// Token: 0x0400ECA6 RID: 60582
		internal static int __PropertyOffset_DragOverride;

		// Token: 0x0400ECA7 RID: 60583
		internal static int __PropertyOffset_SpawnScaleOverride;

		// Token: 0x0400ECA8 RID: 60584
		internal static int __PropertyOffset_TimeDilationOverride;

		// Token: 0x0400ECA9 RID: 60585
		internal static int __PropertyOffset_PassTime;

		// Token: 0x0400ECAA RID: 60586
		internal static int __PropertyOffset_BaseSpawnScale;

		// Token: 0x0400ECAB RID: 60587
		internal static int __PropertyOffset_GlobalWind;

		// Token: 0x0400ECAC RID: 60588
		internal static int __PropertyOffset_Center;
	}
}
