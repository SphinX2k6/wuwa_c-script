using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000206 RID: 518
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGameObject")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UAkGameObject : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E63 RID: 7779 RVA: 0x0002D096 File Offset: 0x0002B296
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkGameObject._ClassPtr;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0002D0A4 File Offset: 0x0002B2A4
		public UAkGameObject() : this(BuiltinUtils.AllocNativeUObject(UAkGameObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0002D0CC File Offset: 0x0002B2CC
		public UAkGameObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkGameObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0002D0FF File Offset: 0x0002B2FF
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0002D113 File Offset: 0x0002B313
		[Nullable(2)]
		public unsafe UAkAudioEvent AkAudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UAkGameObject.__PropertyOffset_AkAudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkGameObject.__PropertyOffset_AkAudioEvent, value);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0002D128 File Offset: 0x0002B328
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0002D13C File Offset: 0x0002B33C
		public unsafe string EventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkGameObject.__PropertyOffset_EventName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkGameObject.__PropertyOffset_EventName)), value);
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0002D151 File Offset: 0x0002B351
		public void Stop()
		{
			UAkGameObject.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0002D160 File Offset: 0x0002B360
		public unsafe void SetRTPCValue([Nullable(2)] UAkRtpc RTPCValue, float Value, int InterpolationTimeMs, string RTPC)
		{
			FString fstring = FString.AllocTemp(RTPC);
			UAkGameObject.__SetRTPCValue_Internal(base.NativePtr, (RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, Value, InterpolationTimeMs, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		[NullableContext(2)]
		public unsafe void PostAssociatedAkEventAsync(UObject WorldContextObject, int CallbackMask, in FOnAkPostEventCallback PostEventCallback, FLatentActionInfo LatentInfo, ref int PlayingID)
		{
			fixed (int* ptr = &PlayingID)
			{
				void* ptr2 = (void*)ptr;
				IntPtr nativePtr = base.NativePtr;
				IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
				FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
				UAkGameObject.__PostAssociatedAkEventAsync_Internal(nativePtr, worldContextObject, CallbackMask, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), (LatentInfo ?? new FLatentActionInfo()).NativePtr, ref PlayingID);
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0002D1F3 File Offset: 0x0002B3F3
		[NullableContext(2)]
		public int PostAssociatedAkEvent(int CallbackMask, in FOnAkPostEventCallback PostEventCallback)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			return UAkGameObject.__PostAssociatedAkEvent_Internal(nativePtr, CallbackMask, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0002D210 File Offset: 0x0002B410
		[NullableContext(2)]
		public unsafe void PostAkEventAsync(UObject WorldContextObject, UAkAudioEvent AkEvent, ref int PlayingID, int CallbackMask, in FOnAkPostEventCallback PostEventCallback, FLatentActionInfo LatentInfo)
		{
			fixed (int* ptr = &PlayingID)
			{
				void* ptr2 = (void*)ptr;
				IntPtr nativePtr = base.NativePtr;
				IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
				IntPtr akEvent = (AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero;
				FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
				UAkGameObject.__PostAkEventAsync_Internal(nativePtr, worldContextObject, akEvent, ref PlayingID, CallbackMask, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), (LatentInfo ?? new FLatentActionInfo()).NativePtr);
			}
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0002D274 File Offset: 0x0002B474
		[NullableContext(2)]
		public unsafe int PostAkEvent(UAkAudioEvent AkEvent, int CallbackMask, in FOnAkPostEventCallback PostEventCallback, [Nullable(1)] string InEventName)
		{
			FString fstring = FString.AllocTemp(InEventName);
			IntPtr nativePtr = base.NativePtr;
			IntPtr akEvent = (AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			int result = UAkGameObject.__PostAkEvent_Internal(nativePtr, akEvent, CallbackMask, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0002D2C0 File Offset: 0x0002B4C0
		public unsafe void GetRTPCValue([Nullable(2)] UAkRtpc RTPCValue, ERTPCValueType InputValueType, ref float Value, ref ERTPCValueType OutputValueType, string RTPC, int PlayingID = 0)
		{
			FString fstring = FString.AllocTemp(RTPC);
			fixed (float* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				fixed (ERTPCValueType* ptr3 = &OutputValueType)
				{
					void* ptr4 = (void*)ptr3;
					UAkGameObject.__GetRTPCValue_Internal(base.NativePtr, (RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, InputValueType, ref Value, ref OutputValueType, fstring, PlayingID);
					FString.NativeDestruct(&fstring, 1);
					ptr = null;
				}
			}
		}

		// Token: 0x06001E71 RID: 7793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06001E72 RID: 7794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRTPCValue_Internal(IntPtr @this, IntPtr RTPCValue, float Value, int InterpolationTimeMs, in FString RTPC);

		// Token: 0x06001E73 RID: 7795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostAssociatedAkEventAsync_Internal(IntPtr @this, IntPtr WorldContextObject, int CallbackMask, IntPtr PostEventCallback, IntPtr LatentInfo, ref int PlayingID);

		// Token: 0x06001E74 RID: 7796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAssociatedAkEvent_Internal(IntPtr @this, int CallbackMask, IntPtr PostEventCallback);

		// Token: 0x06001E75 RID: 7797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PostAkEventAsync_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr AkEvent, ref int PlayingID, int CallbackMask, IntPtr PostEventCallback, IntPtr LatentInfo);

		// Token: 0x06001E76 RID: 7798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAkEvent_Internal(IntPtr @this, IntPtr AkEvent, int CallbackMask, IntPtr PostEventCallback, in FString InEventName);

		// Token: 0x06001E77 RID: 7799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRTPCValue_Internal(IntPtr @this, IntPtr RTPCValue, ERTPCValueType InputValueType, ref float Value, ref ERTPCValueType OutputValueType, in FString RTPC, int PlayingID);

		// Token: 0x06001E78 RID: 7800 RVA: 0x0002D315 File Offset: 0x0002B515
		static UAkGameObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkGameObject");
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0002D323 File Offset: 0x0002B523
		protected UAkGameObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A1B RID: 2587
		public new const string __ObjectPath = "/Script/AkAudio.AkGameObject";

		// Token: 0x04000A1C RID: 2588
		private static IntPtr _ClassPtr;

		// Token: 0x04000A1D RID: 2589
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A1E RID: 2590
		internal static int __PropertyOffset_AkAudioEvent;

		// Token: 0x04000A1F RID: 2591
		internal static int __PropertyOffset_EventName;
	}
}
