using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037B RID: 891
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.QuartzClockHandle")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UQuartzClockHandle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060030C0 RID: 12480 RVA: 0x0004B84A File Offset: 0x00049A4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UQuartzClockHandle._ClassPtr;
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0004B858 File Offset: 0x00049A58
		public UQuartzClockHandle() : this(BuiltinUtils.AllocNativeUObject(UQuartzClockHandle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x0004B880 File Offset: 0x00049A80
		[NullableContext(1)]
		public UQuartzClockHandle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UQuartzClockHandle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x0004B8B3 File Offset: 0x00049AB3
		public void UnsubscribeFromTimeDivision(UObject WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary)
		{
			UQuartzClockHandle.__UnsubscribeFromTimeDivision_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InQuantizationBoundary);
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0004B8D1 File Offset: 0x00049AD1
		public void UnsubscribeFromAllTimeDivisions(UObject WorldContextObject)
		{
			UQuartzClockHandle.__UnsubscribeFromAllTimeDivisions_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0004B8EE File Offset: 0x00049AEE
		public void SubscribeToQuantizationEvent(UObject WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, in FOnQuartzMetronomeEventBP OnQuantizationEvent)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			FOnQuartzMetronomeEventBP fonQuartzMetronomeEventBP = OnQuantizationEvent;
			UQuartzClockHandle.__SubscribeToQuantizationEvent_Internal(nativePtr, worldContextObject, InQuantizationBoundary, (fonQuartzMetronomeEventBP != null) ? fonQuartzMetronomeEventBP.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0004B91B File Offset: 0x00049B1B
		public void SubscribeToAllQuantizationEvents(UObject WorldContextObject, in FOnQuartzMetronomeEventBP OnQuantizationEvent)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			FOnQuartzMetronomeEventBP fonQuartzMetronomeEventBP = OnQuantizationEvent;
			UQuartzClockHandle.__SubscribeToAllQuantizationEvents_Internal(nativePtr, worldContextObject, (fonQuartzMetronomeEventBP != null) ? fonQuartzMetronomeEventBP.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0004B947 File Offset: 0x00049B47
		public void SetTicksPerSecond(UObject WorldContextObject, in FQuartzQuantizationBoundary QuantizationBoundary, in FOnQuartzCommandEventBP Delegate, float TicksPerSecond = 10f)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr2 = (QuantizationBoundary ?? new FQuartzQuantizationBoundary()).NativePtr;
			FOnQuartzCommandEventBP fonQuartzCommandEventBP = Delegate;
			UQuartzClockHandle.__SetTicksPerSecond_Internal(nativePtr, worldContextObject, nativePtr2, (fonQuartzCommandEventBP != null) ? fonQuartzCommandEventBP.NativePtr : ((IntPtr)0), TicksPerSecond);
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0004B985 File Offset: 0x00049B85
		public void SetThirtySecondNotesPerMinute(UObject WorldContextObject, in FQuartzQuantizationBoundary QuantizationBoundary, in FOnQuartzCommandEventBP Delegate, float ThirtySecondsNotesPerMinute = 960f)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr2 = (QuantizationBoundary ?? new FQuartzQuantizationBoundary()).NativePtr;
			FOnQuartzCommandEventBP fonQuartzCommandEventBP = Delegate;
			UQuartzClockHandle.__SetThirtySecondNotesPerMinute_Internal(nativePtr, worldContextObject, nativePtr2, (fonQuartzCommandEventBP != null) ? fonQuartzCommandEventBP.NativePtr : ((IntPtr)0), ThirtySecondsNotesPerMinute);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x0004B9C3 File Offset: 0x00049BC3
		public void SetSecondsPerTick(UObject WorldContextObject, in FQuartzQuantizationBoundary QuantizationBoundary, in FOnQuartzCommandEventBP Delegate, float SecondsPerTick = 0.25f)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr2 = (QuantizationBoundary ?? new FQuartzQuantizationBoundary()).NativePtr;
			FOnQuartzCommandEventBP fonQuartzCommandEventBP = Delegate;
			UQuartzClockHandle.__SetSecondsPerTick_Internal(nativePtr, worldContextObject, nativePtr2, (fonQuartzCommandEventBP != null) ? fonQuartzCommandEventBP.NativePtr : ((IntPtr)0), SecondsPerTick);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0004BA01 File Offset: 0x00049C01
		public void SetMillisecondsPerTick(UObject WorldContextObject, in FQuartzQuantizationBoundary QuantizationBoundary, in FOnQuartzCommandEventBP Delegate, float MillisecondsPerTick = 100f)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr2 = (QuantizationBoundary ?? new FQuartzQuantizationBoundary()).NativePtr;
			FOnQuartzCommandEventBP fonQuartzCommandEventBP = Delegate;
			UQuartzClockHandle.__SetMillisecondsPerTick_Internal(nativePtr, worldContextObject, nativePtr2, (fonQuartzCommandEventBP != null) ? fonQuartzCommandEventBP.NativePtr : ((IntPtr)0), MillisecondsPerTick);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x0004BA3F File Offset: 0x00049C3F
		public void SetBeatsPerMinute(UObject WorldContextObject, in FQuartzQuantizationBoundary QuantizationBoundary, in FOnQuartzCommandEventBP Delegate, float BeatsPerMinute = 60f)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr nativePtr2 = (QuantizationBoundary ?? new FQuartzQuantizationBoundary()).NativePtr;
			FOnQuartzCommandEventBP fonQuartzCommandEventBP = Delegate;
			UQuartzClockHandle.__SetBeatsPerMinute_Internal(nativePtr, worldContextObject, nativePtr2, (fonQuartzCommandEventBP != null) ? fonQuartzCommandEventBP.NativePtr : ((IntPtr)0), BeatsPerMinute);
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x0004BA7D File Offset: 0x00049C7D
		public void ResumeClock(UObject WorldContextObject)
		{
			UQuartzClockHandle.__ResumeClock_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0004BA9A File Offset: 0x00049C9A
		public void ResetTransport(UObject WorldContextObject, in FOnQuartzCommandEventBP InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			FOnQuartzCommandEventBP fonQuartzCommandEventBP = InDelegate;
			UQuartzClockHandle.__ResetTransport_Internal(nativePtr, worldContextObject, (fonQuartzCommandEventBP != null) ? fonQuartzCommandEventBP.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x0004BAC6 File Offset: 0x00049CC6
		public void PauseClock(UObject WorldContextObject)
		{
			UQuartzClockHandle.__PauseClock_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0004BAE3 File Offset: 0x00049CE3
		public float GetTicksPerSecond(UObject WorldContextObject)
		{
			return UQuartzClockHandle.__GetTicksPerSecond_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0004BB00 File Offset: 0x00049D00
		public float GetThirtySecondNotesPerMinute(UObject WorldContextObject)
		{
			return UQuartzClockHandle.__GetThirtySecondNotesPerMinute_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x0004BB1D File Offset: 0x00049D1D
		public float GetSecondsPerTick(UObject WorldContextObject)
		{
			return UQuartzClockHandle.__GetSecondsPerTick_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0004BB3A File Offset: 0x00049D3A
		public float GetMillisecondsPerTick(UObject WorldContextObject)
		{
			return UQuartzClockHandle.__GetMillisecondsPerTick_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0004BB57 File Offset: 0x00049D57
		public float GetBeatsPerMinute(UObject WorldContextObject)
		{
			return UQuartzClockHandle.__GetBeatsPerMinute_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030D4 RID: 12500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnsubscribeFromTimeDivision_Internal(IntPtr @this, IntPtr WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary);

		// Token: 0x060030D5 RID: 12501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnsubscribeFromAllTimeDivisions_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030D6 RID: 12502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SubscribeToQuantizationEvent_Internal(IntPtr @this, IntPtr WorldContextObject, EQuartzCommandQuantization InQuantizationBoundary, IntPtr OnQuantizationEvent);

		// Token: 0x060030D7 RID: 12503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SubscribeToAllQuantizationEvents_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr OnQuantizationEvent);

		// Token: 0x060030D8 RID: 12504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTicksPerSecond_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr QuantizationBoundary, IntPtr Delegate, float TicksPerSecond);

		// Token: 0x060030D9 RID: 12505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetThirtySecondNotesPerMinute_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr QuantizationBoundary, IntPtr Delegate, float ThirtySecondsNotesPerMinute);

		// Token: 0x060030DA RID: 12506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSecondsPerTick_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr QuantizationBoundary, IntPtr Delegate, float SecondsPerTick);

		// Token: 0x060030DB RID: 12507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMillisecondsPerTick_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr QuantizationBoundary, IntPtr Delegate, float MillisecondsPerTick);

		// Token: 0x060030DC RID: 12508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBeatsPerMinute_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr QuantizationBoundary, IntPtr Delegate, float BeatsPerMinute);

		// Token: 0x060030DD RID: 12509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeClock_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030DE RID: 12510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetTransport_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr InDelegate);

		// Token: 0x060030DF RID: 12511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseClock_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030E0 RID: 12512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTicksPerSecond_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030E1 RID: 12513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetThirtySecondNotesPerMinute_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030E2 RID: 12514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSecondsPerTick_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030E3 RID: 12515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMillisecondsPerTick_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030E4 RID: 12516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBeatsPerMinute_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030E5 RID: 12517 RVA: 0x0004BB74 File Offset: 0x00049D74
		static UQuartzClockHandle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.QuartzClockHandle");
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x0004BB82 File Offset: 0x00049D82
		protected UQuartzClockHandle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001548 RID: 5448
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMixer.QuartzClockHandle";

		// Token: 0x04001549 RID: 5449
		private static IntPtr _ClassPtr;

		// Token: 0x0400154A RID: 5450
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
