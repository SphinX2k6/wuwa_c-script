using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000386 RID: 902
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroFauxPhysicsComponentBase")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public abstract class UKuroFauxPhysicsComponentBase : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005A81 RID: 23169 RVA: 0x0007FF4E File Offset: 0x0007E14E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFauxPhysicsComponentBase._ClassPtr;
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x0007FF5A File Offset: 0x0007E15A
		// (set) Token: 0x06005A83 RID: 23171 RVA: 0x0007FF6A File Offset: 0x0007E16A
		public unsafe bool bStartDisabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStartDisabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStartDisabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x0007FF7B File Offset: 0x0007E17B
		// (set) Token: 0x06005A85 RID: 23173 RVA: 0x0007FF8B File Offset: 0x0007E18B
		public unsafe bool bIgnoreActorTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bIgnoreActorTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bIgnoreActorTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x0007FF9C File Offset: 0x0007E19C
		// (set) Token: 0x06005A87 RID: 23175 RVA: 0x0007FFAC File Offset: 0x0007E1AC
		public unsafe bool bStopVelocityWhenDisabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStopVelocityWhenDisabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_bStopVelocityWhenDisabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06005A88 RID: 23176 RVA: 0x0007FFBD File Offset: 0x0007E1BD
		// (set) Token: 0x06005A89 RID: 23177 RVA: 0x0007FFCD File Offset: 0x0007E1CD
		public unsafe float PreventSleepFrameAfterWake
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_PreventSleepFrameAfterWake);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_PreventSleepFrameAfterWake) = value;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x06005A8A RID: 23178 RVA: 0x0007FFDE File Offset: 0x0007E1DE
		// (set) Token: 0x06005A8B RID: 23179 RVA: 0x0007FFEE File Offset: 0x0007E1EE
		public unsafe float MaxStepTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_MaxStepTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFauxPhysicsComponentBase.__PropertyOffset_MaxStepTime) = value;
			}
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x0007FFFF File Offset: 0x0007E1FF
		public void Wake()
		{
			UKuroFauxPhysicsComponentBase.__Wake_Internal(base.NativePtr);
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x0008000C File Offset: 0x0007E20C
		public void Sleep()
		{
			UKuroFauxPhysicsComponentBase.__Sleep_Internal(base.NativePtr);
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00080019 File Offset: 0x0007E219
		public void ResetPhysics()
		{
			UKuroFauxPhysicsComponentBase.__ResetPhysics_Internal(base.NativePtr);
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00080026 File Offset: 0x0007E226
		public void ResetInternalState()
		{
			UKuroFauxPhysicsComponentBase.__ResetInternalState_Internal(base.NativePtr);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00080033 File Offset: 0x0007E233
		public void ResetForces()
		{
			UKuroFauxPhysicsComponentBase.__ResetForces_Internal(base.NativePtr);
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00080040 File Offset: 0x0007E240
		public void RemoveAllDisablers()
		{
			UKuroFauxPhysicsComponentBase.__RemoveAllDisablers_Internal(base.NativePtr);
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x0008004D File Offset: 0x0007E24D
		public bool IsSleeping()
		{
			return UKuroFauxPhysicsComponentBase.__IsSleeping_Internal(base.NativePtr);
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x0008005A File Offset: 0x0007E25A
		public bool IsEnabled()
		{
			return UKuroFauxPhysicsComponentBase.__IsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00080067 File Offset: 0x0007E267
		public bool HasFauxPhysicsControl()
		{
			return UKuroFauxPhysicsComponentBase.__HasFauxPhysicsControl_Internal(base.NativePtr);
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00080074 File Offset: 0x0007E274
		public bool CanSleep()
		{
			return UKuroFauxPhysicsComponentBase.__CanSleep_Internal(base.NativePtr);
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x00080081 File Offset: 0x0007E281
		public void ApplyMovement(in FVector Origin, in FVector Movement)
		{
			UKuroFauxPhysicsComponentBase.__ApplyMovement_Internal(base.NativePtr, Origin, Movement);
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x00080090 File Offset: 0x0007E290
		public void ApplyImpulse(in FVector Origin, in FVector Impulse)
		{
			UKuroFauxPhysicsComponentBase.__ApplyImpulse_Internal(base.NativePtr, Origin, Impulse);
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x0008009F File Offset: 0x0007E29F
		public void ApplyForce(in FVector Origin, in FVector Force)
		{
			UKuroFauxPhysicsComponentBase.__ApplyForce_Internal(base.NativePtr, Origin, Force);
		}

		// Token: 0x06005A99 RID: 23193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Wake_Internal(IntPtr @this);

		// Token: 0x06005A9A RID: 23194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Sleep_Internal(IntPtr @this);

		// Token: 0x06005A9B RID: 23195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetPhysics_Internal(IntPtr @this);

		// Token: 0x06005A9C RID: 23196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInternalState_Internal(IntPtr @this);

		// Token: 0x06005A9D RID: 23197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetForces_Internal(IntPtr @this);

		// Token: 0x06005A9E RID: 23198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllDisablers_Internal(IntPtr @this);

		// Token: 0x06005A9F RID: 23199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSleeping_Internal(IntPtr @this);

		// Token: 0x06005AA0 RID: 23200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsEnabled_Internal(IntPtr @this);

		// Token: 0x06005AA1 RID: 23201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasFauxPhysicsControl_Internal(IntPtr @this);

		// Token: 0x06005AA2 RID: 23202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanSleep_Internal(IntPtr @this);

		// Token: 0x06005AA3 RID: 23203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyMovement_Internal(IntPtr @this, in FVector Origin, in FVector Movement);

		// Token: 0x06005AA4 RID: 23204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyImpulse_Internal(IntPtr @this, in FVector Origin, in FVector Impulse);

		// Token: 0x06005AA5 RID: 23205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyForce_Internal(IntPtr @this, in FVector Origin, in FVector Force);

		// Token: 0x06005AA6 RID: 23206 RVA: 0x000800AE File Offset: 0x0007E2AE
		static UKuroFauxPhysicsComponentBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroFauxPhysics.KuroFauxPhysicsComponentBase");
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x000800BC File Offset: 0x0007E2BC
		protected UKuroFauxPhysicsComponentBase() : this(BuiltinUtils.AllocNativeUObject(UKuroFauxPhysicsComponentBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x000800E4 File Offset: 0x0007E2E4
		protected UKuroFauxPhysicsComponentBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040025A0 RID: 9632
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroFauxPhysics.KuroFauxPhysicsComponentBase";

		// Token: 0x040025A1 RID: 9633
		private static IntPtr _ClassPtr;

		// Token: 0x040025A2 RID: 9634
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040025A3 RID: 9635
		internal static int __PropertyOffset_bStartDisabled;

		// Token: 0x040025A4 RID: 9636
		internal static int __PropertyOffset_bIgnoreActorTimeDilation;

		// Token: 0x040025A5 RID: 9637
		internal static int __PropertyOffset_bStopVelocityWhenDisabled;

		// Token: 0x040025A6 RID: 9638
		internal static int __PropertyOffset_PreventSleepFrameAfterWake;

		// Token: 0x040025A7 RID: 9639
		internal static int __PropertyOffset_MaxStepTime;
	}
}
