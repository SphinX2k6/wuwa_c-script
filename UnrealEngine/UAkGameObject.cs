using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C2 RID: 194
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGameObject")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UAkGameObject : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000E50 RID: 3664 RVA: 0x00016542 File Offset: 0x00014742
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkGameObject._ClassPtr;
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00016550 File Offset: 0x00014750
		public UAkGameObject() : this(BuiltinUtils.AllocNativeUObject(UAkGameObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00016578 File Offset: 0x00014778
		public UAkGameObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkGameObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x000165AB File Offset: 0x000147AB
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x000165BF File Offset: 0x000147BF
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x000165D4 File Offset: 0x000147D4
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x000165E8 File Offset: 0x000147E8
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

		// Token: 0x06000E57 RID: 3671 RVA: 0x000165FD File Offset: 0x000147FD
		public void Stop()
		{
			UAkGameObject.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0001660C File Offset: 0x0001480C
		public unsafe void SetRTPCValue([Nullable(2)] UAkRtpc RTPCValue, float Value, int InterpolationTimeMs, string RTPC)
		{
			FString fstring = FString.AllocTemp(RTPC);
			UAkGameObject.__SetRTPCValue_Internal(base.NativePtr, (RTPCValue != null) ? RTPCValue.NativePtr : IntPtr.Zero, Value, InterpolationTimeMs, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00016649 File Offset: 0x00014849
		[NullableContext(2)]
		public int PostAssociatedAkEvent(int CallbackMask, in FOnAkPostEventCallback PostEventCallback)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			return UAkGameObject.__PostAssociatedAkEvent_Internal(nativePtr, CallbackMask, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00016668 File Offset: 0x00014868
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

		// Token: 0x06000E5B RID: 3675 RVA: 0x000166B4 File Offset: 0x000148B4
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

		// Token: 0x06000E5C RID: 3676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06000E5D RID: 3677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRTPCValue_Internal(IntPtr @this, IntPtr RTPCValue, float Value, int InterpolationTimeMs, in FString RTPC);

		// Token: 0x06000E5E RID: 3678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAssociatedAkEvent_Internal(IntPtr @this, int CallbackMask, IntPtr PostEventCallback);

		// Token: 0x06000E5F RID: 3679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PostAkEvent_Internal(IntPtr @this, IntPtr AkEvent, int CallbackMask, IntPtr PostEventCallback, in FString InEventName);

		// Token: 0x06000E60 RID: 3680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetRTPCValue_Internal(IntPtr @this, IntPtr RTPCValue, ERTPCValueType InputValueType, ref float Value, ref ERTPCValueType OutputValueType, in FString RTPC, int PlayingID);

		// Token: 0x06000E61 RID: 3681 RVA: 0x00016709 File Offset: 0x00014909
		static UAkGameObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkGameObject");
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00016717 File Offset: 0x00014917
		protected UAkGameObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002CE RID: 718
		public new const string __ObjectPath = "/Script/AkAudio.AkGameObject";

		// Token: 0x040002CF RID: 719
		private static IntPtr _ClassPtr;

		// Token: 0x040002D0 RID: 720
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002D1 RID: 721
		internal static int __PropertyOffset_AkAudioEvent;

		// Token: 0x040002D2 RID: 722
		internal static int __PropertyOffset_EventName;
	}
}
