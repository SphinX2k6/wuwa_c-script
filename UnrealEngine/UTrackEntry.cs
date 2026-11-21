using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000843 RID: 2115
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.TrackEntry")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UTrackEntry : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B87D RID: 47229 RVA: 0x00127B4F File Offset: 0x00125D4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTrackEntry._ClassPtr;
		}

		// Token: 0x0600B87E RID: 47230 RVA: 0x00127B5C File Offset: 0x00125D5C
		public UTrackEntry() : this(BuiltinUtils.AllocNativeUObject(UTrackEntry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B87F RID: 47231 RVA: 0x00127B84 File Offset: 0x00125D84
		public UTrackEntry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTrackEntry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002273 RID: 8819
		// (get) Token: 0x0600B880 RID: 47232 RVA: 0x00127BB8 File Offset: 0x00125DB8
		// (set) Token: 0x0600B881 RID: 47233 RVA: 0x00127BF1 File Offset: 0x00125DF1
		public FSpineAnimationStartDelegate AnimationStart
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationStartDelegate result;
				if ((result = this._AnimationStart) == null)
				{
					result = (this._AnimationStart = new FSpineAnimationStartDelegate(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationStart, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationStart, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x0600B882 RID: 47234 RVA: 0x00127C14 File Offset: 0x00125E14
		// (set) Token: 0x0600B883 RID: 47235 RVA: 0x00127C4D File Offset: 0x00125E4D
		public FSpineAnimationInterruptDelegate AnimationInterrupt
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationInterruptDelegate result;
				if ((result = this._AnimationInterrupt) == null)
				{
					result = (this._AnimationInterrupt = new FSpineAnimationInterruptDelegate(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationInterrupt, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationInterrupt, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x0600B884 RID: 47236 RVA: 0x00127C70 File Offset: 0x00125E70
		// (set) Token: 0x0600B885 RID: 47237 RVA: 0x00127CA9 File Offset: 0x00125EA9
		public FSpineAnimationCompleteDelegate AnimationComplete
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationCompleteDelegate result;
				if ((result = this._AnimationComplete) == null)
				{
					result = (this._AnimationComplete = new FSpineAnimationCompleteDelegate(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationComplete, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x0600B886 RID: 47238 RVA: 0x00127CCC File Offset: 0x00125ECC
		// (set) Token: 0x0600B887 RID: 47239 RVA: 0x00127D05 File Offset: 0x00125F05
		public FSpineAnimationEndDelegate AnimationEnd
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationEndDelegate result;
				if ((result = this._AnimationEnd) == null)
				{
					result = (this._AnimationEnd = new FSpineAnimationEndDelegate(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationEnd, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationEnd, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x0600B888 RID: 47240 RVA: 0x00127D28 File Offset: 0x00125F28
		// (set) Token: 0x0600B889 RID: 47241 RVA: 0x00127D61 File Offset: 0x00125F61
		public FSpineAnimationDisposeDelegate AnimationDispose
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationDisposeDelegate result;
				if ((result = this._AnimationDispose) == null)
				{
					result = (this._AnimationDispose = new FSpineAnimationDisposeDelegate(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationDispose, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationDispose, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600B88A RID: 47242 RVA: 0x00127D82 File Offset: 0x00125F82
		public void SetTrackTime(float trackTime)
		{
			UTrackEntry.__SetTrackTime_Internal(base.NativePtr, trackTime);
		}

		// Token: 0x0600B88B RID: 47243 RVA: 0x00127D90 File Offset: 0x00125F90
		public void SetTrackEnd(float trackEnd)
		{
			UTrackEntry.__SetTrackEnd_Internal(base.NativePtr, trackEnd);
		}

		// Token: 0x0600B88C RID: 47244 RVA: 0x00127D9E File Offset: 0x00125F9E
		public void SetTimeScale(float timeScale)
		{
			UTrackEntry.__SetTimeScale_Internal(base.NativePtr, timeScale);
		}

		// Token: 0x0600B88D RID: 47245 RVA: 0x00127DAC File Offset: 0x00125FAC
		public void SetMixTime(float mixTime)
		{
			UTrackEntry.__SetMixTime_Internal(base.NativePtr, mixTime);
		}

		// Token: 0x0600B88E RID: 47246 RVA: 0x00127DBA File Offset: 0x00125FBA
		public void SetMixDuration(float mixDuration)
		{
			UTrackEntry.__SetMixDuration_Internal(base.NativePtr, mixDuration);
		}

		// Token: 0x0600B88F RID: 47247 RVA: 0x00127DC8 File Offset: 0x00125FC8
		public void SetLoop(bool loop)
		{
			UTrackEntry.__SetLoop_Internal(base.NativePtr, loop);
		}

		// Token: 0x0600B890 RID: 47248 RVA: 0x00127DD6 File Offset: 0x00125FD6
		public void SetEventThreshold(float eventThreshold)
		{
			UTrackEntry.__SetEventThreshold_Internal(base.NativePtr, eventThreshold);
		}

		// Token: 0x0600B891 RID: 47249 RVA: 0x00127DE4 File Offset: 0x00125FE4
		public void SetDrawOrderThreshold(float drawOrderThreshold)
		{
			UTrackEntry.__SetDrawOrderThreshold_Internal(base.NativePtr, drawOrderThreshold);
		}

		// Token: 0x0600B892 RID: 47250 RVA: 0x00127DF2 File Offset: 0x00125FF2
		public void SetDelay(float delay)
		{
			UTrackEntry.__SetDelay_Internal(base.NativePtr, delay);
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x00127E00 File Offset: 0x00126000
		public void SetAttachmentThreshold(float attachmentThreshold)
		{
			UTrackEntry.__SetAttachmentThreshold_Internal(base.NativePtr, attachmentThreshold);
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x00127E0E File Offset: 0x0012600E
		public void SetAnimationStart(float animationStart)
		{
			UTrackEntry.__SetAnimationStart_Internal(base.NativePtr, animationStart);
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x00127E1C File Offset: 0x0012601C
		public void SetAnimationLast(float animationLast)
		{
			UTrackEntry.__SetAnimationLast_Internal(base.NativePtr, animationLast);
		}

		// Token: 0x0600B896 RID: 47254 RVA: 0x00127E2A File Offset: 0x0012602A
		public void SetAnimationEnd(float animationEnd)
		{
			UTrackEntry.__SetAnimationEnd_Internal(base.NativePtr, animationEnd);
		}

		// Token: 0x0600B897 RID: 47255 RVA: 0x00127E38 File Offset: 0x00126038
		public void SetAlpha(float alpha)
		{
			UTrackEntry.__SetAlpha_Internal(base.NativePtr, alpha);
		}

		// Token: 0x0600B898 RID: 47256 RVA: 0x00127E46 File Offset: 0x00126046
		public bool isValidAnimation()
		{
			return UTrackEntry.__isValidAnimation_Internal(base.NativePtr);
		}

		// Token: 0x0600B899 RID: 47257 RVA: 0x00127E53 File Offset: 0x00126053
		public float GetTrackTime()
		{
			return UTrackEntry.__GetTrackTime_Internal(base.NativePtr);
		}

		// Token: 0x0600B89A RID: 47258 RVA: 0x00127E60 File Offset: 0x00126060
		public int GetTrackIndex()
		{
			return UTrackEntry.__GetTrackIndex_Internal(base.NativePtr);
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x00127E6D File Offset: 0x0012606D
		public float GetTrackEnd()
		{
			return UTrackEntry.__GetTrackEnd_Internal(base.NativePtr);
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x00127E7A File Offset: 0x0012607A
		public float GetTimeScale()
		{
			return UTrackEntry.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x00127E87 File Offset: 0x00126087
		public float GetMixTime()
		{
			return UTrackEntry.__GetMixTime_Internal(base.NativePtr);
		}

		// Token: 0x0600B89E RID: 47262 RVA: 0x00127E94 File Offset: 0x00126094
		public float GetMixDuration()
		{
			return UTrackEntry.__GetMixDuration_Internal(base.NativePtr);
		}

		// Token: 0x0600B89F RID: 47263 RVA: 0x00127EA1 File Offset: 0x001260A1
		public bool GetLoop()
		{
			return UTrackEntry.__GetLoop_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x00127EAE File Offset: 0x001260AE
		public float GetEventThreshold()
		{
			return UTrackEntry.__GetEventThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A1 RID: 47265 RVA: 0x00127EBB File Offset: 0x001260BB
		public float GetDrawOrderThreshold()
		{
			return UTrackEntry.__GetDrawOrderThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x00127EC8 File Offset: 0x001260C8
		public float GetDelay()
		{
			return UTrackEntry.__GetDelay_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x00127ED5 File Offset: 0x001260D5
		public float GetAttachmentThreshold()
		{
			return UTrackEntry.__GetAttachmentThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x00127EE2 File Offset: 0x001260E2
		public float GetAnimationStart()
		{
			return UTrackEntry.__GetAnimationStart_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A5 RID: 47269 RVA: 0x00127EEF File Offset: 0x001260EF
		public string getAnimationName()
		{
			return FString.ToStringAndDeleteNativePtr(UTrackEntry.__getAnimationName_Internal(base.NativePtr));
		}

		// Token: 0x0600B8A6 RID: 47270 RVA: 0x00127F01 File Offset: 0x00126101
		public float GetAnimationLast()
		{
			return UTrackEntry.__GetAnimationLast_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A7 RID: 47271 RVA: 0x00127F0E File Offset: 0x0012610E
		public float GetAnimationEnd()
		{
			return UTrackEntry.__GetAnimationEnd_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x00127F1B File Offset: 0x0012611B
		public float getAnimationDuration()
		{
			return UTrackEntry.__getAnimationDuration_Internal(base.NativePtr);
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x00127F28 File Offset: 0x00126128
		public float GetAlpha()
		{
			return UTrackEntry.__GetAlpha_Internal(base.NativePtr);
		}

		// Token: 0x0600B8AA RID: 47274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrackTime_Internal(IntPtr @this, float trackTime);

		// Token: 0x0600B8AB RID: 47275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrackEnd_Internal(IntPtr @this, float trackEnd);

		// Token: 0x0600B8AC RID: 47276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeScale_Internal(IntPtr @this, float timeScale);

		// Token: 0x0600B8AD RID: 47277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMixTime_Internal(IntPtr @this, float mixTime);

		// Token: 0x0600B8AE RID: 47278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMixDuration_Internal(IntPtr @this, float mixDuration);

		// Token: 0x0600B8AF RID: 47279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoop_Internal(IntPtr @this, bool loop);

		// Token: 0x0600B8B0 RID: 47280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEventThreshold_Internal(IntPtr @this, float eventThreshold);

		// Token: 0x0600B8B1 RID: 47281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawOrderThreshold_Internal(IntPtr @this, float drawOrderThreshold);

		// Token: 0x0600B8B2 RID: 47282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDelay_Internal(IntPtr @this, float delay);

		// Token: 0x0600B8B3 RID: 47283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttachmentThreshold_Internal(IntPtr @this, float attachmentThreshold);

		// Token: 0x0600B8B4 RID: 47284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationStart_Internal(IntPtr @this, float animationStart);

		// Token: 0x0600B8B5 RID: 47285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationLast_Internal(IntPtr @this, float animationLast);

		// Token: 0x0600B8B6 RID: 47286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationEnd_Internal(IntPtr @this, float animationEnd);

		// Token: 0x0600B8B7 RID: 47287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlpha_Internal(IntPtr @this, float alpha);

		// Token: 0x0600B8B8 RID: 47288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __isValidAnimation_Internal(IntPtr @this);

		// Token: 0x0600B8B9 RID: 47289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTrackTime_Internal(IntPtr @this);

		// Token: 0x0600B8BA RID: 47290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTrackIndex_Internal(IntPtr @this);

		// Token: 0x0600B8BB RID: 47291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTrackEnd_Internal(IntPtr @this);

		// Token: 0x0600B8BC RID: 47292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x0600B8BD RID: 47293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMixTime_Internal(IntPtr @this);

		// Token: 0x0600B8BE RID: 47294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMixDuration_Internal(IntPtr @this);

		// Token: 0x0600B8BF RID: 47295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLoop_Internal(IntPtr @this);

		// Token: 0x0600B8C0 RID: 47296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEventThreshold_Internal(IntPtr @this);

		// Token: 0x0600B8C1 RID: 47297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDrawOrderThreshold_Internal(IntPtr @this);

		// Token: 0x0600B8C2 RID: 47298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDelay_Internal(IntPtr @this);

		// Token: 0x0600B8C3 RID: 47299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttachmentThreshold_Internal(IntPtr @this);

		// Token: 0x0600B8C4 RID: 47300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationStart_Internal(IntPtr @this);

		// Token: 0x0600B8C5 RID: 47301
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __getAnimationName_Internal(IntPtr @this);

		// Token: 0x0600B8C6 RID: 47302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationLast_Internal(IntPtr @this);

		// Token: 0x0600B8C7 RID: 47303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationEnd_Internal(IntPtr @this);

		// Token: 0x0600B8C8 RID: 47304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __getAnimationDuration_Internal(IntPtr @this);

		// Token: 0x0600B8C9 RID: 47305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAlpha_Internal(IntPtr @this);

		// Token: 0x0600B8CA RID: 47306 RVA: 0x00127F35 File Offset: 0x00126135
		static UTrackEntry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.TrackEntry");
		}

		// Token: 0x0600B8CB RID: 47307 RVA: 0x00127F43 File Offset: 0x00126143
		protected UTrackEntry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053D1 RID: 21457
		public new const string __ObjectPath = "/Script/SpinePlugin.TrackEntry";

		// Token: 0x040053D2 RID: 21458
		private static IntPtr _ClassPtr;

		// Token: 0x040053D3 RID: 21459
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040053D4 RID: 21460
		internal static int __PropertyOffset_AnimationStart;

		// Token: 0x040053D5 RID: 21461
		[Nullable(2)]
		private FSpineAnimationStartDelegate _AnimationStart;

		// Token: 0x040053D6 RID: 21462
		internal static int __PropertyOffset_AnimationInterrupt;

		// Token: 0x040053D7 RID: 21463
		[Nullable(2)]
		private FSpineAnimationInterruptDelegate _AnimationInterrupt;

		// Token: 0x040053D8 RID: 21464
		internal static int __PropertyOffset_AnimationComplete;

		// Token: 0x040053D9 RID: 21465
		[Nullable(2)]
		private FSpineAnimationCompleteDelegate _AnimationComplete;

		// Token: 0x040053DA RID: 21466
		internal static int __PropertyOffset_AnimationEnd;

		// Token: 0x040053DB RID: 21467
		[Nullable(2)]
		private FSpineAnimationEndDelegate _AnimationEnd;

		// Token: 0x040053DC RID: 21468
		internal static int __PropertyOffset_AnimationDispose;

		// Token: 0x040053DD RID: 21469
		[Nullable(2)]
		private FSpineAnimationDisposeDelegate _AnimationDispose;
	}
}
