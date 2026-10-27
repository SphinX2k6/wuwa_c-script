using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B0 RID: 10416
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.SpineSkeletonAnimationComponent")]
	[UnrealStructLayout(624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class USpineSkeletonAnimationComponent : USpineSkeletonComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060269E7 RID: 158183 RVA: 0x003AEE76 File Offset: 0x003AD076
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineSkeletonAnimationComponent._ClassPtr;
		}

		// Token: 0x060269E8 RID: 158184 RVA: 0x003AEE84 File Offset: 0x003AD084
		public USpineSkeletonAnimationComponent() : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonAnimationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060269E9 RID: 158185 RVA: 0x003AEEAC File Offset: 0x003AD0AC
		public USpineSkeletonAnimationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineSkeletonAnimationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170094E0 RID: 38112
		// (get) Token: 0x060269EA RID: 158186 RVA: 0x003AEEE0 File Offset: 0x003AD0E0
		// (set) Token: 0x060269EB RID: 158187 RVA: 0x003AEF19 File Offset: 0x003AD119
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

		// Token: 0x170094E1 RID: 38113
		// (get) Token: 0x060269EC RID: 158188 RVA: 0x003AEF3C File Offset: 0x003AD13C
		// (set) Token: 0x060269ED RID: 158189 RVA: 0x003AEF75 File Offset: 0x003AD175
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

		// Token: 0x170094E2 RID: 38114
		// (get) Token: 0x060269EE RID: 158190 RVA: 0x003AEF98 File Offset: 0x003AD198
		// (set) Token: 0x060269EF RID: 158191 RVA: 0x003AEFD1 File Offset: 0x003AD1D1
		public FSpineAnimationEventDelegate AnimationEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationEventDelegate result;
				if ((result = this._AnimationEvent) == null)
				{
					result = (this._AnimationEvent = new FSpineAnimationEventDelegate(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USpineSkeletonAnimationComponent.__PropertyOffset_AnimationEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170094E3 RID: 38115
		// (get) Token: 0x060269F0 RID: 158192 RVA: 0x003AEFF4 File Offset: 0x003AD1F4
		// (set) Token: 0x060269F1 RID: 158193 RVA: 0x003AF02D File Offset: 0x003AD22D
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

		// Token: 0x170094E4 RID: 38116
		// (get) Token: 0x060269F2 RID: 158194 RVA: 0x003AF050 File Offset: 0x003AD250
		// (set) Token: 0x060269F3 RID: 158195 RVA: 0x003AF089 File Offset: 0x003AD289
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

		// Token: 0x170094E5 RID: 38117
		// (get) Token: 0x060269F4 RID: 158196 RVA: 0x003AF0AC File Offset: 0x003AD2AC
		// (set) Token: 0x060269F5 RID: 158197 RVA: 0x003AF0E5 File Offset: 0x003AD2E5
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

		// Token: 0x170094E6 RID: 38118
		// (get) Token: 0x060269F6 RID: 158198 RVA: 0x003AF106 File Offset: 0x003AD306
		// (set) Token: 0x060269F7 RID: 158199 RVA: 0x003AF11A File Offset: 0x003AD31A
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

		// Token: 0x170094E7 RID: 38119
		// (get) Token: 0x060269F8 RID: 158200 RVA: 0x003AF12F File Offset: 0x003AD32F
		// (set) Token: 0x060269F9 RID: 158201 RVA: 0x003AF143 File Offset: 0x003AD343
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

		// Token: 0x170094E8 RID: 38120
		// (get) Token: 0x060269FA RID: 158202 RVA: 0x003AF158 File Offset: 0x003AD358
		// (set) Token: 0x060269FB RID: 158203 RVA: 0x003AF191 File Offset: 0x003AD391
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

		// Token: 0x170094E9 RID: 38121
		// (get) Token: 0x060269FC RID: 158204 RVA: 0x003AF19F File Offset: 0x003AD39F
		// (set) Token: 0x060269FD RID: 158205 RVA: 0x003AF1AF File Offset: 0x003AD3AF
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

		// Token: 0x060269FE RID: 158206 RVA: 0x003AF1C0 File Offset: 0x003AD3C0
		public void SetTimeScale(float timeScale)
		{
			USpineSkeletonAnimationComponent.__SetTimeScale_Internal(base.NativePtr, timeScale);
		}

		// Token: 0x060269FF RID: 158207 RVA: 0x003AF1CE File Offset: 0x003AD3CE
		public void SetPlaybackTime(float InPlaybackTime, bool bCallDelegates = true)
		{
			USpineSkeletonAnimationComponent.__SetPlaybackTime_Internal(base.NativePtr, InPlaybackTime, bCallDelegates);
		}

		// Token: 0x06026A00 RID: 158208 RVA: 0x003AF1DD File Offset: 0x003AD3DD
		[NullableContext(2)]
		public UTrackEntry SetEmptyAnimation(int trackIndex, float mixDuration)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__SetEmptyAnimation_Internal(base.NativePtr, trackIndex, mixDuration));
		}

		// Token: 0x06026A01 RID: 158209 RVA: 0x003AF1F1 File Offset: 0x003AD3F1
		public void SetAutoPlay(bool bInAutoPlays)
		{
			USpineSkeletonAnimationComponent.__SetAutoPlay_Internal(base.NativePtr, bInAutoPlays);
		}

		// Token: 0x06026A02 RID: 158210 RVA: 0x003AF200 File Offset: 0x003AD400
		[return: Nullable(2)]
		public unsafe UTrackEntry SetAnimation(int trackIndex, string animationName, bool loop)
		{
			FString fstring = FString.AllocTemp(animationName);
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__SetAnimation_Internal(base.NativePtr, trackIndex, fstring, loop));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06026A03 RID: 158211 RVA: 0x003AF231 File Offset: 0x003AD431
		public float GetTimeScale()
		{
			return USpineSkeletonAnimationComponent.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x06026A04 RID: 158212 RVA: 0x003AF23E File Offset: 0x003AD43E
		[NullableContext(2)]
		public UTrackEntry GetCurrent(int trackIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__GetCurrent_Internal(base.NativePtr, trackIndex));
		}

		// Token: 0x06026A05 RID: 158213 RVA: 0x003AF251 File Offset: 0x003AD451
		public void ClearTracks()
		{
			USpineSkeletonAnimationComponent.__ClearTracks_Internal(base.NativePtr);
		}

		// Token: 0x06026A06 RID: 158214 RVA: 0x003AF25E File Offset: 0x003AD45E
		public void ClearTrack(int trackIndex)
		{
			USpineSkeletonAnimationComponent.__ClearTrack_Internal(base.NativePtr, trackIndex);
		}

		// Token: 0x06026A07 RID: 158215 RVA: 0x003AF26C File Offset: 0x003AD46C
		[NullableContext(2)]
		public UTrackEntry AddEmptyAnimation(int trackIndex, float mixDuration, float delay)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__AddEmptyAnimation_Internal(base.NativePtr, trackIndex, mixDuration, delay));
		}

		// Token: 0x06026A08 RID: 158216 RVA: 0x003AF284 File Offset: 0x003AD484
		[return: Nullable(2)]
		public unsafe UTrackEntry AddAnimation(int trackIndex, string animationName, bool loop, float delay)
		{
			FString fstring = FString.AllocTemp(animationName);
			UTrackEntry orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UTrackEntry>(USpineSkeletonAnimationComponent.__AddAnimation_Internal(base.NativePtr, trackIndex, fstring, loop, delay));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x06026A09 RID: 158217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeScale_Internal(IntPtr @this, float timeScale);

		// Token: 0x06026A0A RID: 158218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackTime_Internal(IntPtr @this, float InPlaybackTime, bool bCallDelegates);

		// Token: 0x06026A0B RID: 158219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetEmptyAnimation_Internal(IntPtr @this, int trackIndex, float mixDuration);

		// Token: 0x06026A0C RID: 158220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAutoPlay_Internal(IntPtr @this, bool bInAutoPlays);

		// Token: 0x06026A0D RID: 158221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetAnimation_Internal(IntPtr @this, int trackIndex, in FString animationName, bool loop);

		// Token: 0x06026A0E RID: 158222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x06026A0F RID: 158223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrent_Internal(IntPtr @this, int trackIndex);

		// Token: 0x06026A10 RID: 158224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTracks_Internal(IntPtr @this);

		// Token: 0x06026A11 RID: 158225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTrack_Internal(IntPtr @this, int trackIndex);

		// Token: 0x06026A12 RID: 158226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddEmptyAnimation_Internal(IntPtr @this, int trackIndex, float mixDuration, float delay);

		// Token: 0x06026A13 RID: 158227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddAnimation_Internal(IntPtr @this, int trackIndex, in FString animationName, bool loop, float delay);

		// Token: 0x06026A14 RID: 158228 RVA: 0x003AF2B7 File Offset: 0x003AD4B7
		static USpineSkeletonAnimationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.SpineSkeletonAnimationComponent");
		}

		// Token: 0x06026A15 RID: 158229 RVA: 0x003AF2C5 File Offset: 0x003AD4C5
		protected USpineSkeletonAnimationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401535B RID: 86875
		public new const string __ObjectPath = "/Script/SpinePlugin.SpineSkeletonAnimationComponent";

		// Token: 0x0401535C RID: 86876
		private static IntPtr _ClassPtr;

		// Token: 0x0401535D RID: 86877
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401535E RID: 86878
		internal static int __PropertyOffset_AnimationStart;

		// Token: 0x0401535F RID: 86879
		[Nullable(2)]
		private FSpineAnimationStartDelegate _AnimationStart;

		// Token: 0x04015360 RID: 86880
		internal static int __PropertyOffset_AnimationInterrupt;

		// Token: 0x04015361 RID: 86881
		[Nullable(2)]
		private FSpineAnimationInterruptDelegate _AnimationInterrupt;

		// Token: 0x04015362 RID: 86882
		internal static int __PropertyOffset_AnimationEvent;

		// Token: 0x04015363 RID: 86883
		[Nullable(2)]
		private FSpineAnimationEventDelegate _AnimationEvent;

		// Token: 0x04015364 RID: 86884
		internal static int __PropertyOffset_AnimationComplete;

		// Token: 0x04015365 RID: 86885
		[Nullable(2)]
		private FSpineAnimationCompleteDelegate _AnimationComplete;

		// Token: 0x04015366 RID: 86886
		internal static int __PropertyOffset_AnimationEnd;

		// Token: 0x04015367 RID: 86887
		[Nullable(2)]
		private FSpineAnimationEndDelegate _AnimationEnd;

		// Token: 0x04015368 RID: 86888
		internal static int __PropertyOffset_AnimationDispose;

		// Token: 0x04015369 RID: 86889
		[Nullable(2)]
		private FSpineAnimationDisposeDelegate _AnimationDispose;

		// Token: 0x0401536A RID: 86890
		internal static int __PropertyOffset_PreviewAnimation;

		// Token: 0x0401536B RID: 86891
		internal static int __PropertyOffset_PreviewSkin;

		// Token: 0x0401536C RID: 86892
		internal static int __PropertyOffset_trackEntries;

		// Token: 0x0401536D RID: 86893
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UTrackEntry> _trackEntries;

		// Token: 0x0401536E RID: 86894
		internal static int __PropertyOffset_bAutoPlaying;
	}
}
