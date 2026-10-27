using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B7 RID: 10423
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SpinePlugin.TrackEntry")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UTrackEntry : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B1E RID: 158494 RVA: 0x003B0B41 File Offset: 0x003AED41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTrackEntry._ClassPtr;
		}

		// Token: 0x06026B1F RID: 158495 RVA: 0x003B0B50 File Offset: 0x003AED50
		public UTrackEntry() : this(BuiltinUtils.AllocNativeUObject(UTrackEntry.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026B20 RID: 158496 RVA: 0x003B0B78 File Offset: 0x003AED78
		public UTrackEntry(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTrackEntry.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009522 RID: 38178
		// (get) Token: 0x06026B21 RID: 158497 RVA: 0x003B0BAC File Offset: 0x003AEDAC
		// (set) Token: 0x06026B22 RID: 158498 RVA: 0x003B0BE5 File Offset: 0x003AEDE5
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

		// Token: 0x17009523 RID: 38179
		// (get) Token: 0x06026B23 RID: 158499 RVA: 0x003B0C08 File Offset: 0x003AEE08
		// (set) Token: 0x06026B24 RID: 158500 RVA: 0x003B0C41 File Offset: 0x003AEE41
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

		// Token: 0x17009524 RID: 38180
		// (get) Token: 0x06026B25 RID: 158501 RVA: 0x003B0C64 File Offset: 0x003AEE64
		// (set) Token: 0x06026B26 RID: 158502 RVA: 0x003B0C9D File Offset: 0x003AEE9D
		public FSpineAnimationEventDelegate AnimationEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSpineAnimationEventDelegate result;
				if ((result = this._AnimationEvent) == null)
				{
					result = (this._AnimationEvent = new FSpineAnimationEventDelegate(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UTrackEntry.__PropertyOffset_AnimationEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009525 RID: 38181
		// (get) Token: 0x06026B27 RID: 158503 RVA: 0x003B0CC0 File Offset: 0x003AEEC0
		// (set) Token: 0x06026B28 RID: 158504 RVA: 0x003B0CF9 File Offset: 0x003AEEF9
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

		// Token: 0x17009526 RID: 38182
		// (get) Token: 0x06026B29 RID: 158505 RVA: 0x003B0D1C File Offset: 0x003AEF1C
		// (set) Token: 0x06026B2A RID: 158506 RVA: 0x003B0D55 File Offset: 0x003AEF55
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

		// Token: 0x17009527 RID: 38183
		// (get) Token: 0x06026B2B RID: 158507 RVA: 0x003B0D78 File Offset: 0x003AEF78
		// (set) Token: 0x06026B2C RID: 158508 RVA: 0x003B0DB1 File Offset: 0x003AEFB1
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

		// Token: 0x06026B2D RID: 158509 RVA: 0x003B0DD2 File Offset: 0x003AEFD2
		public void SetTrackTime(float trackTime)
		{
			UTrackEntry.__SetTrackTime_Internal(base.NativePtr, trackTime);
		}

		// Token: 0x06026B2E RID: 158510 RVA: 0x003B0DE0 File Offset: 0x003AEFE0
		public void SetTrackEnd(float trackEnd)
		{
			UTrackEntry.__SetTrackEnd_Internal(base.NativePtr, trackEnd);
		}

		// Token: 0x06026B2F RID: 158511 RVA: 0x003B0DEE File Offset: 0x003AEFEE
		public void SetTimeScale(float timeScale)
		{
			UTrackEntry.__SetTimeScale_Internal(base.NativePtr, timeScale);
		}

		// Token: 0x06026B30 RID: 158512 RVA: 0x003B0DFC File Offset: 0x003AEFFC
		public void SetMixTime(float mixTime)
		{
			UTrackEntry.__SetMixTime_Internal(base.NativePtr, mixTime);
		}

		// Token: 0x06026B31 RID: 158513 RVA: 0x003B0E0A File Offset: 0x003AF00A
		public void SetMixDuration(float mixDuration)
		{
			UTrackEntry.__SetMixDuration_Internal(base.NativePtr, mixDuration);
		}

		// Token: 0x06026B32 RID: 158514 RVA: 0x003B0E18 File Offset: 0x003AF018
		public void SetLoop(bool loop)
		{
			UTrackEntry.__SetLoop_Internal(base.NativePtr, loop);
		}

		// Token: 0x06026B33 RID: 158515 RVA: 0x003B0E26 File Offset: 0x003AF026
		public void SetEventThreshold(float eventThreshold)
		{
			UTrackEntry.__SetEventThreshold_Internal(base.NativePtr, eventThreshold);
		}

		// Token: 0x06026B34 RID: 158516 RVA: 0x003B0E34 File Offset: 0x003AF034
		public void SetDrawOrderThreshold(float drawOrderThreshold)
		{
			UTrackEntry.__SetDrawOrderThreshold_Internal(base.NativePtr, drawOrderThreshold);
		}

		// Token: 0x06026B35 RID: 158517 RVA: 0x003B0E42 File Offset: 0x003AF042
		public void SetDelay(float delay)
		{
			UTrackEntry.__SetDelay_Internal(base.NativePtr, delay);
		}

		// Token: 0x06026B36 RID: 158518 RVA: 0x003B0E50 File Offset: 0x003AF050
		public void SetAttachmentThreshold(float attachmentThreshold)
		{
			UTrackEntry.__SetAttachmentThreshold_Internal(base.NativePtr, attachmentThreshold);
		}

		// Token: 0x06026B37 RID: 158519 RVA: 0x003B0E5E File Offset: 0x003AF05E
		public void SetAnimationStart(float animationStart)
		{
			UTrackEntry.__SetAnimationStart_Internal(base.NativePtr, animationStart);
		}

		// Token: 0x06026B38 RID: 158520 RVA: 0x003B0E6C File Offset: 0x003AF06C
		public void SetAnimationLast(float animationLast)
		{
			UTrackEntry.__SetAnimationLast_Internal(base.NativePtr, animationLast);
		}

		// Token: 0x06026B39 RID: 158521 RVA: 0x003B0E7A File Offset: 0x003AF07A
		public void SetAnimationEnd(float animationEnd)
		{
			UTrackEntry.__SetAnimationEnd_Internal(base.NativePtr, animationEnd);
		}

		// Token: 0x06026B3A RID: 158522 RVA: 0x003B0E88 File Offset: 0x003AF088
		public void SetAlpha(float alpha)
		{
			UTrackEntry.__SetAlpha_Internal(base.NativePtr, alpha);
		}

		// Token: 0x06026B3B RID: 158523 RVA: 0x003B0E96 File Offset: 0x003AF096
		public bool isValidAnimation()
		{
			return UTrackEntry.__isValidAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06026B3C RID: 158524 RVA: 0x003B0EA3 File Offset: 0x003AF0A3
		public float GetTrackTime()
		{
			return UTrackEntry.__GetTrackTime_Internal(base.NativePtr);
		}

		// Token: 0x06026B3D RID: 158525 RVA: 0x003B0EB0 File Offset: 0x003AF0B0
		public int GetTrackIndex()
		{
			return UTrackEntry.__GetTrackIndex_Internal(base.NativePtr);
		}

		// Token: 0x06026B3E RID: 158526 RVA: 0x003B0EBD File Offset: 0x003AF0BD
		public float GetTrackEnd()
		{
			return UTrackEntry.__GetTrackEnd_Internal(base.NativePtr);
		}

		// Token: 0x06026B3F RID: 158527 RVA: 0x003B0ECA File Offset: 0x003AF0CA
		public float GetTimeScale()
		{
			return UTrackEntry.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x06026B40 RID: 158528 RVA: 0x003B0ED7 File Offset: 0x003AF0D7
		public float GetMixTime()
		{
			return UTrackEntry.__GetMixTime_Internal(base.NativePtr);
		}

		// Token: 0x06026B41 RID: 158529 RVA: 0x003B0EE4 File Offset: 0x003AF0E4
		public float GetMixDuration()
		{
			return UTrackEntry.__GetMixDuration_Internal(base.NativePtr);
		}

		// Token: 0x06026B42 RID: 158530 RVA: 0x003B0EF1 File Offset: 0x003AF0F1
		public bool GetLoop()
		{
			return UTrackEntry.__GetLoop_Internal(base.NativePtr);
		}

		// Token: 0x06026B43 RID: 158531 RVA: 0x003B0EFE File Offset: 0x003AF0FE
		public float GetEventThreshold()
		{
			return UTrackEntry.__GetEventThreshold_Internal(base.NativePtr);
		}

		// Token: 0x06026B44 RID: 158532 RVA: 0x003B0F0B File Offset: 0x003AF10B
		public float GetDrawOrderThreshold()
		{
			return UTrackEntry.__GetDrawOrderThreshold_Internal(base.NativePtr);
		}

		// Token: 0x06026B45 RID: 158533 RVA: 0x003B0F18 File Offset: 0x003AF118
		public float GetDelay()
		{
			return UTrackEntry.__GetDelay_Internal(base.NativePtr);
		}

		// Token: 0x06026B46 RID: 158534 RVA: 0x003B0F25 File Offset: 0x003AF125
		public float GetAttachmentThreshold()
		{
			return UTrackEntry.__GetAttachmentThreshold_Internal(base.NativePtr);
		}

		// Token: 0x06026B47 RID: 158535 RVA: 0x003B0F32 File Offset: 0x003AF132
		public float GetAnimationStart()
		{
			return UTrackEntry.__GetAnimationStart_Internal(base.NativePtr);
		}

		// Token: 0x06026B48 RID: 158536 RVA: 0x003B0F3F File Offset: 0x003AF13F
		public string getAnimationName()
		{
			return FString.ToStringAndDeleteNativePtr(UTrackEntry.__getAnimationName_Internal(base.NativePtr));
		}

		// Token: 0x06026B49 RID: 158537 RVA: 0x003B0F51 File Offset: 0x003AF151
		public float GetAnimationLast()
		{
			return UTrackEntry.__GetAnimationLast_Internal(base.NativePtr);
		}

		// Token: 0x06026B4A RID: 158538 RVA: 0x003B0F5E File Offset: 0x003AF15E
		public float GetAnimationEnd()
		{
			return UTrackEntry.__GetAnimationEnd_Internal(base.NativePtr);
		}

		// Token: 0x06026B4B RID: 158539 RVA: 0x003B0F6B File Offset: 0x003AF16B
		public float getAnimationDuration()
		{
			return UTrackEntry.__getAnimationDuration_Internal(base.NativePtr);
		}

		// Token: 0x06026B4C RID: 158540 RVA: 0x003B0F78 File Offset: 0x003AF178
		public float GetAlpha()
		{
			return UTrackEntry.__GetAlpha_Internal(base.NativePtr);
		}

		// Token: 0x06026B4D RID: 158541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrackTime_Internal(IntPtr @this, float trackTime);

		// Token: 0x06026B4E RID: 158542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTrackEnd_Internal(IntPtr @this, float trackEnd);

		// Token: 0x06026B4F RID: 158543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeScale_Internal(IntPtr @this, float timeScale);

		// Token: 0x06026B50 RID: 158544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMixTime_Internal(IntPtr @this, float mixTime);

		// Token: 0x06026B51 RID: 158545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMixDuration_Internal(IntPtr @this, float mixDuration);

		// Token: 0x06026B52 RID: 158546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLoop_Internal(IntPtr @this, bool loop);

		// Token: 0x06026B53 RID: 158547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEventThreshold_Internal(IntPtr @this, float eventThreshold);

		// Token: 0x06026B54 RID: 158548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawOrderThreshold_Internal(IntPtr @this, float drawOrderThreshold);

		// Token: 0x06026B55 RID: 158549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDelay_Internal(IntPtr @this, float delay);

		// Token: 0x06026B56 RID: 158550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttachmentThreshold_Internal(IntPtr @this, float attachmentThreshold);

		// Token: 0x06026B57 RID: 158551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationStart_Internal(IntPtr @this, float animationStart);

		// Token: 0x06026B58 RID: 158552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationLast_Internal(IntPtr @this, float animationLast);

		// Token: 0x06026B59 RID: 158553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationEnd_Internal(IntPtr @this, float animationEnd);

		// Token: 0x06026B5A RID: 158554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlpha_Internal(IntPtr @this, float alpha);

		// Token: 0x06026B5B RID: 158555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __isValidAnimation_Internal(IntPtr @this);

		// Token: 0x06026B5C RID: 158556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTrackTime_Internal(IntPtr @this);

		// Token: 0x06026B5D RID: 158557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTrackIndex_Internal(IntPtr @this);

		// Token: 0x06026B5E RID: 158558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTrackEnd_Internal(IntPtr @this);

		// Token: 0x06026B5F RID: 158559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x06026B60 RID: 158560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMixTime_Internal(IntPtr @this);

		// Token: 0x06026B61 RID: 158561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMixDuration_Internal(IntPtr @this);

		// Token: 0x06026B62 RID: 158562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLoop_Internal(IntPtr @this);

		// Token: 0x06026B63 RID: 158563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEventThreshold_Internal(IntPtr @this);

		// Token: 0x06026B64 RID: 158564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDrawOrderThreshold_Internal(IntPtr @this);

		// Token: 0x06026B65 RID: 158565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDelay_Internal(IntPtr @this);

		// Token: 0x06026B66 RID: 158566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAttachmentThreshold_Internal(IntPtr @this);

		// Token: 0x06026B67 RID: 158567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationStart_Internal(IntPtr @this);

		// Token: 0x06026B68 RID: 158568
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __getAnimationName_Internal(IntPtr @this);

		// Token: 0x06026B69 RID: 158569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationLast_Internal(IntPtr @this);

		// Token: 0x06026B6A RID: 158570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationEnd_Internal(IntPtr @this);

		// Token: 0x06026B6B RID: 158571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __getAnimationDuration_Internal(IntPtr @this);

		// Token: 0x06026B6C RID: 158572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAlpha_Internal(IntPtr @this);

		// Token: 0x06026B6D RID: 158573 RVA: 0x003B0F85 File Offset: 0x003AF185
		static UTrackEntry()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SpinePlugin.TrackEntry");
		}

		// Token: 0x06026B6E RID: 158574 RVA: 0x003B0F93 File Offset: 0x003AF193
		protected UTrackEntry(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040153D9 RID: 87001
		public new const string __ObjectPath = "/Script/SpinePlugin.TrackEntry";

		// Token: 0x040153DA RID: 87002
		private static IntPtr _ClassPtr;

		// Token: 0x040153DB RID: 87003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040153DC RID: 87004
		internal static int __PropertyOffset_AnimationStart;

		// Token: 0x040153DD RID: 87005
		[Nullable(2)]
		private FSpineAnimationStartDelegate _AnimationStart;

		// Token: 0x040153DE RID: 87006
		internal static int __PropertyOffset_AnimationInterrupt;

		// Token: 0x040153DF RID: 87007
		[Nullable(2)]
		private FSpineAnimationInterruptDelegate _AnimationInterrupt;

		// Token: 0x040153E0 RID: 87008
		internal static int __PropertyOffset_AnimationEvent;

		// Token: 0x040153E1 RID: 87009
		[Nullable(2)]
		private FSpineAnimationEventDelegate _AnimationEvent;

		// Token: 0x040153E2 RID: 87010
		internal static int __PropertyOffset_AnimationComplete;

		// Token: 0x040153E3 RID: 87011
		[Nullable(2)]
		private FSpineAnimationCompleteDelegate _AnimationComplete;

		// Token: 0x040153E4 RID: 87012
		internal static int __PropertyOffset_AnimationEnd;

		// Token: 0x040153E5 RID: 87013
		[Nullable(2)]
		private FSpineAnimationEndDelegate _AnimationEnd;

		// Token: 0x040153E6 RID: 87014
		internal static int __PropertyOffset_AnimationDispose;

		// Token: 0x040153E7 RID: 87015
		[Nullable(2)]
		private FSpineAnimationDisposeDelegate _AnimationDispose;
	}
}
