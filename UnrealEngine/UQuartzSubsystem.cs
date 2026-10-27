using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037C RID: 892
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.QuartzSubsystem")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UQuartzSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060030E7 RID: 12519 RVA: 0x0004BB8B File Offset: 0x00049D8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UQuartzSubsystem._ClassPtr;
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x0004BB98 File Offset: 0x00049D98
		public UQuartzSubsystem() : this(BuiltinUtils.AllocNativeUObject(UQuartzSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x0004BBC0 File Offset: 0x00049DC0
		[NullableContext(1)]
		public UQuartzSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UQuartzSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x0004BBF3 File Offset: 0x00049DF3
		public float GetRoundTripMinLatency(UObject WorldContextObject)
		{
			return UQuartzSubsystem.__GetRoundTripMinLatency_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x0004BC10 File Offset: 0x00049E10
		public float GetRoundTripMaxLatency(UObject WorldContextObject)
		{
			return UQuartzSubsystem.__GetRoundTripMaxLatency_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x0004BC2D File Offset: 0x00049E2D
		public float GetRoundTripAverageLatency(UObject WorldContextObject)
		{
			return UQuartzSubsystem.__GetRoundTripAverageLatency_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0004BC4A File Offset: 0x00049E4A
		public UQuartzClockHandle GetHandleForClock(UObject WorldContextObject, FName ClockName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UQuartzClockHandle>(UQuartzSubsystem.__GetHandleForClock_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ClockName));
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x0004BC6D File Offset: 0x00049E6D
		public float GetGameThreadToAudioRenderThreadMinLatency(UObject WorldContextObject)
		{
			return UQuartzSubsystem.__GetGameThreadToAudioRenderThreadMinLatency_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x0004BC8A File Offset: 0x00049E8A
		public float GetGameThreadToAudioRenderThreadMaxLatency(UObject WorldContextObject)
		{
			return UQuartzSubsystem.__GetGameThreadToAudioRenderThreadMaxLatency_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x0004BCA7 File Offset: 0x00049EA7
		public float GetGameThreadToAudioRenderThreadAverageLatency(UObject WorldContextObject)
		{
			return UQuartzSubsystem.__GetGameThreadToAudioRenderThreadAverageLatency_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x0004BCC4 File Offset: 0x00049EC4
		public float GetAudioRenderThreadToGameThreadMinLatency()
		{
			return UQuartzSubsystem.__GetAudioRenderThreadToGameThreadMinLatency_Internal(base.NativePtr);
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0004BCD1 File Offset: 0x00049ED1
		public float GetAudioRenderThreadToGameThreadMaxLatency()
		{
			return UQuartzSubsystem.__GetAudioRenderThreadToGameThreadMaxLatency_Internal(base.NativePtr);
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x0004BCDE File Offset: 0x00049EDE
		public float GetAudioRenderThreadToGameThreadAverageLatency()
		{
			return UQuartzSubsystem.__GetAudioRenderThreadToGameThreadAverageLatency_Internal(base.NativePtr);
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x0004BCEB File Offset: 0x00049EEB
		public bool DoesClockExist(UObject WorldContextObject, FName ClockName)
		{
			return UQuartzSubsystem.__DoesClockExist_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ClockName);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x0004BD09 File Offset: 0x00049F09
		public UQuartzClockHandle CreateNewClock(UObject WorldContextObject, FName ClockName, FQuartzClockSettings InSettings, bool bOverrideSettingsIfClockExists = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UQuartzClockHandle>(UQuartzSubsystem.__CreateNewClock_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ClockName, (InSettings ?? new FQuartzClockSettings()).NativePtr, bOverrideSettingsIfClockExists));
		}

		// Token: 0x060030F6 RID: 12534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRoundTripMinLatency_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030F7 RID: 12535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRoundTripMaxLatency_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030F8 RID: 12536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRoundTripAverageLatency_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030F9 RID: 12537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHandleForClock_Internal(IntPtr @this, IntPtr WorldContextObject, FName ClockName);

		// Token: 0x060030FA RID: 12538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameThreadToAudioRenderThreadMinLatency_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030FB RID: 12539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameThreadToAudioRenderThreadMaxLatency_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030FC RID: 12540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGameThreadToAudioRenderThreadAverageLatency_Internal(IntPtr @this, IntPtr WorldContextObject);

		// Token: 0x060030FD RID: 12541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAudioRenderThreadToGameThreadMinLatency_Internal(IntPtr @this);

		// Token: 0x060030FE RID: 12542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAudioRenderThreadToGameThreadMaxLatency_Internal(IntPtr @this);

		// Token: 0x060030FF RID: 12543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAudioRenderThreadToGameThreadAverageLatency_Internal(IntPtr @this);

		// Token: 0x06003100 RID: 12544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DoesClockExist_Internal(IntPtr @this, IntPtr WorldContextObject, FName ClockName);

		// Token: 0x06003101 RID: 12545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateNewClock_Internal(IntPtr @this, IntPtr WorldContextObject, FName ClockName, IntPtr InSettings, bool bOverrideSettingsIfClockExists);

		// Token: 0x06003102 RID: 12546 RVA: 0x0004BD3D File Offset: 0x00049F3D
		static UQuartzSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.QuartzSubsystem");
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x0004BD4B File Offset: 0x00049F4B
		protected UQuartzSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400154B RID: 5451
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMixer.QuartzSubsystem";

		// Token: 0x0400154C RID: 5452
		private static IntPtr _ClassPtr;

		// Token: 0x0400154D RID: 5453
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
