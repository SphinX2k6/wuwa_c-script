using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001411 RID: 5137
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCache.GeometryCacheComponent")]
	[UnrealStructLayout(1712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1712)]
	public class UGeometryCacheComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012BE6 RID: 76774 RVA: 0x001B97DA File Offset: 0x001B79DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGeometryCacheComponent._ClassPtr;
		}

		// Token: 0x06012BE7 RID: 76775 RVA: 0x001B97E8 File Offset: 0x001B79E8
		public UGeometryCacheComponent() : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012BE8 RID: 76776 RVA: 0x001B9810 File Offset: 0x001B7A10
		[NullableContext(1)]
		public UGeometryCacheComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGeometryCacheComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170048A6 RID: 18598
		// (get) Token: 0x06012BE9 RID: 76777 RVA: 0x001B9843 File Offset: 0x001B7A43
		// (set) Token: 0x06012BEA RID: 76778 RVA: 0x001B9857 File Offset: 0x001B7A57
		public unsafe UGeometryCache GeometryCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCache>(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCacheComponent.__PropertyOffset_GeometryCache);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGeometryCacheComponent.__PropertyOffset_GeometryCache, value);
			}
		}

		// Token: 0x170048A7 RID: 18599
		// (get) Token: 0x06012BEB RID: 76779 RVA: 0x001B986C File Offset: 0x001B7A6C
		// (set) Token: 0x06012BEC RID: 76780 RVA: 0x001B987C File Offset: 0x001B7A7C
		public unsafe bool bRunning
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_bRunning) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_bRunning) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x06012BED RID: 76781 RVA: 0x001B988D File Offset: 0x001B7A8D
		// (set) Token: 0x06012BEE RID: 76782 RVA: 0x001B989D File Offset: 0x001B7A9D
		public unsafe bool bLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_bLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_bLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x06012BEF RID: 76783 RVA: 0x001B98AE File Offset: 0x001B7AAE
		// (set) Token: 0x06012BF0 RID: 76784 RVA: 0x001B98BE File Offset: 0x001B7ABE
		public unsafe float StartTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_StartTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_StartTimeOffset) = value;
			}
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x06012BF1 RID: 76785 RVA: 0x001B98CF File Offset: 0x001B7ACF
		// (set) Token: 0x06012BF2 RID: 76786 RVA: 0x001B98DF File Offset: 0x001B7ADF
		public unsafe float PlaybackSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_PlaybackSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_PlaybackSpeed) = value;
			}
		}

		// Token: 0x170048AB RID: 18603
		// (get) Token: 0x06012BF3 RID: 76787 RVA: 0x001B98F0 File Offset: 0x001B7AF0
		// (set) Token: 0x06012BF4 RID: 76788 RVA: 0x001B9900 File Offset: 0x001B7B00
		public unsafe int NumTracks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_NumTracks);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_NumTracks) = value;
			}
		}

		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x06012BF5 RID: 76789 RVA: 0x001B9911 File Offset: 0x001B7B11
		// (set) Token: 0x06012BF6 RID: 76790 RVA: 0x001B9921 File Offset: 0x001B7B21
		public unsafe float ElapsedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_ElapsedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_ElapsedTime) = value;
			}
		}

		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x06012BF7 RID: 76791 RVA: 0x001B9932 File Offset: 0x001B7B32
		// (set) Token: 0x06012BF8 RID: 76792 RVA: 0x001B9942 File Offset: 0x001B7B42
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170048AE RID: 18606
		// (get) Token: 0x06012BF9 RID: 76793 RVA: 0x001B9953 File Offset: 0x001B7B53
		// (set) Token: 0x06012BFA RID: 76794 RVA: 0x001B9963 File Offset: 0x001B7B63
		public unsafe bool bManualTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_bManualTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGeometryCacheComponent.__PropertyOffset_bManualTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x06012BFB RID: 76795 RVA: 0x001B9974 File Offset: 0x001B7B74
		public void TickAtThisTime(float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping)
		{
			UGeometryCacheComponent.__TickAtThisTime_Internal(base.NativePtr, Time, bInIsRunning, bInBackwards, bInIsLooping);
		}

		// Token: 0x06012BFC RID: 76796 RVA: 0x001B9986 File Offset: 0x001B7B86
		public void Stop()
		{
			UGeometryCacheComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06012BFD RID: 76797 RVA: 0x001B9993 File Offset: 0x001B7B93
		public void SetStartTimeOffset(float NewStartTimeOffset)
		{
			UGeometryCacheComponent.__SetStartTimeOffset_Internal(base.NativePtr, NewStartTimeOffset);
		}

		// Token: 0x06012BFE RID: 76798 RVA: 0x001B99A1 File Offset: 0x001B7BA1
		public void SetPlaybackSpeed(float NewPlaybackSpeed)
		{
			UGeometryCacheComponent.__SetPlaybackSpeed_Internal(base.NativePtr, NewPlaybackSpeed);
		}

		// Token: 0x06012BFF RID: 76799 RVA: 0x001B99AF File Offset: 0x001B7BAF
		public void SetLooping(bool bNewLooping)
		{
			UGeometryCacheComponent.__SetLooping_Internal(base.NativePtr, bNewLooping);
		}

		// Token: 0x06012C00 RID: 76800 RVA: 0x001B99BD File Offset: 0x001B7BBD
		public bool SetGeometryCache(UGeometryCache NewGeomCache)
		{
			return UGeometryCacheComponent.__SetGeometryCache_Internal(base.NativePtr, (NewGeomCache != null) ? NewGeomCache.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06012C01 RID: 76801 RVA: 0x001B99DA File Offset: 0x001B7BDA
		public void PlayReversedFromEnd()
		{
			UGeometryCacheComponent.__PlayReversedFromEnd_Internal(base.NativePtr);
		}

		// Token: 0x06012C02 RID: 76802 RVA: 0x001B99E7 File Offset: 0x001B7BE7
		public void PlayReversed()
		{
			UGeometryCacheComponent.__PlayReversed_Internal(base.NativePtr);
		}

		// Token: 0x06012C03 RID: 76803 RVA: 0x001B99F4 File Offset: 0x001B7BF4
		public void PlayFromStart()
		{
			UGeometryCacheComponent.__PlayFromStart_Internal(base.NativePtr);
		}

		// Token: 0x06012C04 RID: 76804 RVA: 0x001B9A01 File Offset: 0x001B7C01
		public void Play()
		{
			UGeometryCacheComponent.__Play_Internal(base.NativePtr);
		}

		// Token: 0x06012C05 RID: 76805 RVA: 0x001B9A0E File Offset: 0x001B7C0E
		public void Pause()
		{
			UGeometryCacheComponent.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x06012C06 RID: 76806 RVA: 0x001B9A1B File Offset: 0x001B7C1B
		public bool IsPlayingReversed()
		{
			return UGeometryCacheComponent.__IsPlayingReversed_Internal(base.NativePtr);
		}

		// Token: 0x06012C07 RID: 76807 RVA: 0x001B9A28 File Offset: 0x001B7C28
		public bool IsPlaying()
		{
			return UGeometryCacheComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x06012C08 RID: 76808 RVA: 0x001B9A35 File Offset: 0x001B7C35
		public bool IsLooping()
		{
			return UGeometryCacheComponent.__IsLooping_Internal(base.NativePtr);
		}

		// Token: 0x06012C09 RID: 76809 RVA: 0x001B9A42 File Offset: 0x001B7C42
		public float GetStartTimeOffset()
		{
			return UGeometryCacheComponent.__GetStartTimeOffset_Internal(base.NativePtr);
		}

		// Token: 0x06012C0A RID: 76810 RVA: 0x001B9A4F File Offset: 0x001B7C4F
		public float GetPlaybackSpeed()
		{
			return UGeometryCacheComponent.__GetPlaybackSpeed_Internal(base.NativePtr);
		}

		// Token: 0x06012C0B RID: 76811 RVA: 0x001B9A5C File Offset: 0x001B7C5C
		public float GetPlaybackDirection()
		{
			return UGeometryCacheComponent.__GetPlaybackDirection_Internal(base.NativePtr);
		}

		// Token: 0x06012C0C RID: 76812 RVA: 0x001B9A69 File Offset: 0x001B7C69
		public int GetNumberOfFrames()
		{
			return UGeometryCacheComponent.__GetNumberOfFrames_Internal(base.NativePtr);
		}

		// Token: 0x06012C0D RID: 76813 RVA: 0x001B9A76 File Offset: 0x001B7C76
		public float GetDuration()
		{
			return UGeometryCacheComponent.__GetDuration_Internal(base.NativePtr);
		}

		// Token: 0x06012C0E RID: 76814 RVA: 0x001B9A83 File Offset: 0x001B7C83
		public float GetAnimationTime()
		{
			return UGeometryCacheComponent.__GetAnimationTime_Internal(base.NativePtr);
		}

		// Token: 0x06012C0F RID: 76815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickAtThisTime_Internal(IntPtr @this, float Time, bool bInIsRunning, bool bInBackwards, bool bInIsLooping);

		// Token: 0x06012C10 RID: 76816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06012C11 RID: 76817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartTimeOffset_Internal(IntPtr @this, float NewStartTimeOffset);

		// Token: 0x06012C12 RID: 76818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackSpeed_Internal(IntPtr @this, float NewPlaybackSpeed);

		// Token: 0x06012C13 RID: 76819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLooping_Internal(IntPtr @this, bool bNewLooping);

		// Token: 0x06012C14 RID: 76820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetGeometryCache_Internal(IntPtr @this, IntPtr NewGeomCache);

		// Token: 0x06012C15 RID: 76821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayReversedFromEnd_Internal(IntPtr @this);

		// Token: 0x06012C16 RID: 76822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayReversed_Internal(IntPtr @this);

		// Token: 0x06012C17 RID: 76823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayFromStart_Internal(IntPtr @this);

		// Token: 0x06012C18 RID: 76824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x06012C19 RID: 76825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x06012C1A RID: 76826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingReversed_Internal(IntPtr @this);

		// Token: 0x06012C1B RID: 76827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06012C1C RID: 76828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLooping_Internal(IntPtr @this);

		// Token: 0x06012C1D RID: 76829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartTimeOffset_Internal(IntPtr @this);

		// Token: 0x06012C1E RID: 76830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlaybackSpeed_Internal(IntPtr @this);

		// Token: 0x06012C1F RID: 76831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlaybackDirection_Internal(IntPtr @this);

		// Token: 0x06012C20 RID: 76832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumberOfFrames_Internal(IntPtr @this);

		// Token: 0x06012C21 RID: 76833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDuration_Internal(IntPtr @this);

		// Token: 0x06012C22 RID: 76834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationTime_Internal(IntPtr @this);

		// Token: 0x06012C23 RID: 76835 RVA: 0x001B9A90 File Offset: 0x001B7C90
		static UGeometryCacheComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCache.GeometryCacheComponent");
		}

		// Token: 0x06012C24 RID: 76836 RVA: 0x001B9A9E File Offset: 0x001B7C9E
		protected UGeometryCacheComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A05A RID: 41050
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GeometryCache.GeometryCacheComponent";

		// Token: 0x0400A05B RID: 41051
		private static IntPtr _ClassPtr;

		// Token: 0x0400A05C RID: 41052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A05D RID: 41053
		internal static int __PropertyOffset_GeometryCache;

		// Token: 0x0400A05E RID: 41054
		internal static int __PropertyOffset_bRunning;

		// Token: 0x0400A05F RID: 41055
		internal static int __PropertyOffset_bLooping;

		// Token: 0x0400A060 RID: 41056
		internal static int __PropertyOffset_StartTimeOffset;

		// Token: 0x0400A061 RID: 41057
		internal static int __PropertyOffset_PlaybackSpeed;

		// Token: 0x0400A062 RID: 41058
		internal static int __PropertyOffset_NumTracks;

		// Token: 0x0400A063 RID: 41059
		internal static int __PropertyOffset_ElapsedTime;

		// Token: 0x0400A064 RID: 41060
		internal static int __PropertyOffset_Duration;

		// Token: 0x0400A065 RID: 41061
		internal static int __PropertyOffset_bManualTick;
	}
}
