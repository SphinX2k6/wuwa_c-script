using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200083F RID: 2111
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonAnimationComponent")]
	[UnrealStructLayout(624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class USpineSkeletonAnimationComponent : USpineSkeletonComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B7D7 RID: 47063 RVA: 0x00126C2D File Offset: 0x00124E2D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonAnimationComponent._ClassPtr;
		}

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x00126C3C File Offset: 0x00124E3C
		public USpineSkeletonAnimationComponent() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonAnimationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x00126C64 File Offset: 0x00124E64
		public USpineSkeletonAnimationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonAnimationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x0600B7DA RID: 47066 RVA: 0x00126C98 File Offset: 0x00124E98
		// (set) Token: 0x0600B7DB RID: 47067 RVA: 0x00126CD1 File Offset: 0x00124ED1
		public FSpineAnimationStartDelegate AnimationStart
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationStartDelegate result;
				if ((result = this._AnimationStart) == null)
				{
					result = (this._AnimationStart = new FSpineAnimationStartDelegate(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationStart, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationStart, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x0600B7DC RID: 47068 RVA: 0x00126CF4 File Offset: 0x00124EF4
		// (set) Token: 0x0600B7DD RID: 47069 RVA: 0x00126D2D File Offset: 0x00124F2D
		public FSpineAnimationInterruptDelegate AnimationInterrupt
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationInterruptDelegate result;
				if ((result = this._AnimationInterrupt) == null)
				{
					result = (this._AnimationInterrupt = new FSpineAnimationInterruptDelegate(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationInterrupt, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationInterrupt, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x0600B7DE RID: 47070 RVA: 0x00126D50 File Offset: 0x00124F50
		// (set) Token: 0x0600B7DF RID: 47071 RVA: 0x00126D89 File Offset: 0x00124F89
		public FSpineAnimationCompleteDelegate AnimationComplete
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationCompleteDelegate result;
				if ((result = this._AnimationComplete) == null)
				{
					result = (this._AnimationComplete = new FSpineAnimationCompleteDelegate(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationComplete, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x0600B7E0 RID: 47072 RVA: 0x00126DAC File Offset: 0x00124FAC
		// (set) Token: 0x0600B7E1 RID: 47073 RVA: 0x00126DE5 File Offset: 0x00124FE5
		public FSpineAnimationEndDelegate AnimationEnd
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationEndDelegate result;
				if ((result = this._AnimationEnd) == null)
				{
					result = (this._AnimationEnd = new FSpineAnimationEndDelegate(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x0600B7E2 RID: 47074 RVA: 0x00126E08 File Offset: 0x00125008
		// (set) Token: 0x0600B7E3 RID: 47075 RVA: 0x00126E41 File Offset: 0x00125041
		public FSpineAnimationDisposeDelegate AnimationDispose
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationDisposeDelegate result;
				if ((result = this._AnimationDispose) == null)
				{
					result = (this._AnimationDispose = new FSpineAnimationDisposeDelegate(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationDispose, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationDispose, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0600B7E4 RID: 47076 RVA: 0x00126E62 File Offset: 0x00125062
		// (set) Token: 0x0600B7E5 RID: 47077 RVA: 0x00126E76 File Offset: 0x00125076
		public unsafe string PreviewAnimation
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_PreviewAnimation)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_PreviewAnimation)), value);
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0600B7E6 RID: 47078 RVA: 0x00126E8B File Offset: 0x0012508B
		// (set) Token: 0x0600B7E7 RID: 47079 RVA: 0x00126E9F File Offset: 0x0012509F
		public unsafe string PreviewSkin
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_PreviewSkin)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_PreviewSkin)), value);
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x00126EB4 File Offset: 0x001250B4
		// (set) Token: 0x0600B7E9 RID: 47081 RVA: 0x00126EED File Offset: 0x001250ED
		public TSet<UTrackEntry> trackEntries
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UTrackEntry> result;
				if ((result = this._trackEntries) == null)
				{
					result = (this._trackEntries = new TSet<UTrackEntry>(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_trackEntries, this));
				}
				return result;
			}
			set
			{
				this.trackEntries.CopyAssign(value);
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x00126EFB File Offset: 0x001250FB
		// (set) Token: 0x0600B7EB RID: 47083 RVA: 0x00126F0B File Offset: 0x0012510B
		public unsafe bool bAutoPlaying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_bAutoPlaying) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_bAutoPlaying) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x00126F1C File Offset: 0x0012511C
		public void SetTimeScale(float timeScale)
		{
			USpineSkeletonAnimationComponent.__SetTimeScale_Internal(base.NativePtr, timeScale);
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x00126F2A File Offset: 0x0012512A
		public void SetPlaybackTime(float InPlaybackTime, bool bCallDelegates = true)
		{
			USpineSkeletonAnimationComponent.__SetPlaybackTime_Internal(base.NativePtr, InPlaybackTime, bCallDelegates);
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x00126F39 File Offset: 0x00125139
		[NullableContext(2)]
		public UTrackEntry SetEmptyAnimation(int trackIndex, float mixDuration)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__SetEmptyAnimation_Internal(base.NativePtr, trackIndex, mixDuration));
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x00126F4D File Offset: 0x0012514D
		public void SetAutoPlay(bool bInAutoPlays)
		{
			USpineSkeletonAnimationComponent.__SetAutoPlay_Internal(base.NativePtr, bInAutoPlays);
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x00126F5C File Offset: 0x0012515C
		[return: Nullable(2)]
		public unsafe UTrackEntry SetAnimation(int trackIndex, string animationName, bool loop)
		{
			FString fstring = FString.AllocTemp(animationName);
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__SetAnimation_Internal(base.NativePtr, trackIndex, fstring, loop));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x00126F8D File Offset: 0x0012518D
		public float GetTimeScale()
		{
			return USpineSkeletonAnimationComponent.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x00126F9A File Offset: 0x0012519A
		[NullableContext(2)]
		public UTrackEntry GetCurrent(int trackIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__GetCurrent_Internal(base.NativePtr, trackIndex));
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x00126FAD File Offset: 0x001251AD
		public void ClearTracks()
		{
			USpineSkeletonAnimationComponent.__ClearTracks_Internal(base.NativePtr);
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x00126FBA File Offset: 0x001251BA
		public void ClearTrack(int trackIndex)
		{
			USpineSkeletonAnimationComponent.__ClearTrack_Internal(base.NativePtr, trackIndex);
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x00126FC8 File Offset: 0x001251C8
		[NullableContext(2)]
		public UTrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__AddEmptyAnimation_Internal(base.NativePtr, trackIndex, mixDuration, delay));
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x00126FE0 File Offset: 0x001251E0
		[return: Nullable(2)]
		public unsafe UTrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay)
		{
			FString fstring = FString.AllocTemp(animationName);
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__AddAnimation_Internal(base.NativePtr, trackIndex, fstring, loop, delay));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0600B7F7 RID: 47095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeScale_Internal(IntPtr @this, float timeScale);

		// Token: 0x0600B7F8 RID: 47096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackTime_Internal(IntPtr @this, float InPlaybackTime, bool bCallDelegates);

		// Token: 0x0600B7F9 RID: 47097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetEmptyAnimation_Internal(IntPtr @this, int trackIndex, float mixDuration);

		// Token: 0x0600B7FA RID: 47098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoPlay_Internal(IntPtr @this, bool bInAutoPlays);

		// Token: 0x0600B7FB RID: 47099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetAnimation_Internal(IntPtr @this, int trackIndex, in FString animationName, bool loop);

		// Token: 0x0600B7FC RID: 47100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x0600B7FD RID: 47101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrent_Internal(IntPtr @this, int trackIndex);

		// Token: 0x0600B7FE RID: 47102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTracks_Internal(IntPtr @this);

		// Token: 0x0600B7FF RID: 47103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTrack_Internal(IntPtr @this, int trackIndex);

		// Token: 0x0600B800 RID: 47104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddEmptyAnimation_Internal(IntPtr @this, int trackIndex, float mixDuration, float delay);

		// Token: 0x0600B801 RID: 47105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddAnimation_Internal(IntPtr @this, int trackIndex, in FString animationName, bool loop, float delay);

		// Token: 0x0600B802 RID: 47106 RVA: 0x00127013 File Offset: 0x00125213
		static USpineSkeletonAnimationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonAnimationComponent");
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x00127021 File Offset: 0x00125221
		protected USpineSkeletonAnimationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005387 RID: 21383
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonAnimationComponent";

		// Token: 0x04005388 RID: 21384
		private static IntPtr _ClassPtr;

		// Token: 0x04005389 RID: 21385
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400538A RID: 21386
		internal static int __PropertyOffset_AnimationStart;

		// Token: 0x0400538B RID: 21387
		[Nullable(2)]
		private FSpineAnimationStartDelegate _AnimationStart;

		// Token: 0x0400538C RID: 21388
		internal static int __PropertyOffset_AnimationInterrupt;

		// Token: 0x0400538D RID: 21389
		[Nullable(2)]
		private FSpineAnimationInterruptDelegate _AnimationInterrupt;

		// Token: 0x0400538E RID: 21390
		internal static int __PropertyOffset_AnimationComplete;

		// Token: 0x0400538F RID: 21391
		[Nullable(2)]
		private FSpineAnimationCompleteDelegate _AnimationComplete;

		// Token: 0x04005390 RID: 21392
		internal static int __PropertyOffset_AnimationEnd;

		// Token: 0x04005391 RID: 21393
		[Nullable(2)]
		private FSpineAnimationEndDelegate _AnimationEnd;

		// Token: 0x04005392 RID: 21394
		internal static int __PropertyOffset_AnimationDispose;

		// Token: 0x04005393 RID: 21395
		[Nullable(2)]
		private FSpineAnimationDisposeDelegate _AnimationDispose;

		// Token: 0x04005394 RID: 21396
		internal static int __PropertyOffset_PreviewAnimation;

		// Token: 0x04005395 RID: 21397
		internal static int __PropertyOffset_PreviewSkin;

		// Token: 0x04005396 RID: 21398
		internal static int __PropertyOffset_trackEntries;

		// Token: 0x04005397 RID: 21399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UTrackEntry> _trackEntries;

		// Token: 0x04005398 RID: 21400
		internal static int __PropertyOffset_bAutoPlaying;
	}
}
