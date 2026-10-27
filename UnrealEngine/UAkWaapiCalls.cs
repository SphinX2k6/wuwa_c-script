using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000251 RID: 593
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkWaapiCalls")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAkWaapiCalls : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060022F6 RID: 8950 RVA: 0x00033CE2 File Offset: 0x00031EE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWaapiCalls._ClassPtr;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00033CF0 File Offset: 0x00031EF0
		public UAkWaapiCalls() : this(BuiltinUtils.AllocNativeUObject(UAkWaapiCalls.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00033D18 File Offset: 0x00031F18
		[NullableContext(1)]
		public UAkWaapiCalls(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWaapiCalls.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00033D4C File Offset: 0x00031F4C
		[NullableContext(1)]
		public unsafe static FAKWaapiJsonObject Unsubscribe([Nullable(2)] in FAkWaapiSubscriptionId SubscriptionId, ref bool UnsubscriptionDone)
		{
			fixed (bool* ptr = &UnsubscriptionDone)
			{
				void* ptr2 = (void*)ptr;
				return new FAKWaapiJsonObject(UAkWaapiCalls.__Unsubscribe_Internal((SubscriptionId ?? new FAkWaapiSubscriptionId()).NativePtr, ref UnsubscriptionDone), null);
			}
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00033D7C File Offset: 0x00031F7C
		[return: Nullable(1)]
		public unsafe static FAKWaapiJsonObject SubscribeToWaapi(in FAkWaapiUri WaapiUri, in FAKWaapiJsonObject WaapiOptions, in FOnEventCallback CallBack, ref FAkWaapiSubscriptionId SubscriptionId, ref bool SubscriptionDone)
		{
			fixed (bool* ptr = &SubscriptionDone)
			{
				void* ptr2 = (void*)ptr;
				IntPtr nativePtr = (WaapiUri ?? new FAkWaapiUri()).NativePtr;
				IntPtr nativePtr2 = (WaapiOptions ?? new FAKWaapiJsonObject()).NativePtr;
				FOnEventCallback fonEventCallback = CallBack;
				return new FAKWaapiJsonObject(UAkWaapiCalls.__SubscribeToWaapi_Internal(nativePtr, nativePtr2, (fonEventCallback != null) ? fonEventCallback.NativePtr : ((IntPtr)0), (SubscriptionId ?? new FAkWaapiSubscriptionId()).NativePtr, ref SubscriptionDone), null);
			}
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00033DDB File Offset: 0x00031FDB
		public static void SetSubscriptionID(in FAkWaapiSubscriptionId Subscription, int id)
		{
			UAkWaapiCalls.__SetSubscriptionID_Internal((Subscription ?? new FAkWaapiSubscriptionId()).NativePtr, id);
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x00033DF3 File Offset: 0x00031FF3
		public static bool RegisterWaapiProjectLoadedCallback(in FOnWaapiProjectLoaded Callback)
		{
			FOnWaapiProjectLoaded fonWaapiProjectLoaded = Callback;
			return UAkWaapiCalls.__RegisterWaapiProjectLoadedCallback_Internal((fonWaapiProjectLoaded != null) ? fonWaapiProjectLoaded.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x00033E09 File Offset: 0x00032009
		public static bool RegisterWaapiConnectionLostCallback(in FOnWaapiConnectionLost Callback)
		{
			FOnWaapiConnectionLost fonWaapiConnectionLost = Callback;
			return UAkWaapiCalls.__RegisterWaapiConnectionLostCallback_Internal((fonWaapiConnectionLost != null) ? fonWaapiConnectionLost.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00033E1F File Offset: 0x0003201F
		public static int GetSubscriptionID(in FAkWaapiSubscriptionId Subscription)
		{
			return UAkWaapiCalls.__GetSubscriptionID_Internal((Subscription ?? new FAkWaapiSubscriptionId()).NativePtr);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x00033E36 File Offset: 0x00032036
		[NullableContext(1)]
		public static FText Conv_FAkWaapiSubscriptionIdToText([Nullable(2)] in FAkWaapiSubscriptionId INAkWaapiSubscriptionId)
		{
			return new FText(UAkWaapiCalls.__Conv_FAkWaapiSubscriptionIdToText_Internal((INAkWaapiSubscriptionId ?? new FAkWaapiSubscriptionId()).NativePtr), null);
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x00033E53 File Offset: 0x00032053
		[NullableContext(1)]
		public static string Conv_FAkWaapiSubscriptionIdToString([Nullable(2)] in FAkWaapiSubscriptionId INAkWaapiSubscriptionId)
		{
			return FString.ToStringAndDeleteNativePtr(UAkWaapiCalls.__Conv_FAkWaapiSubscriptionIdToString_Internal((INAkWaapiSubscriptionId ?? new FAkWaapiSubscriptionId()).NativePtr));
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x00033E6F File Offset: 0x0003206F
		[return: Nullable(1)]
		public static FAKWaapiJsonObject CallWaapi(in FAkWaapiUri WaapiUri, in FAKWaapiJsonObject WaapiArgs, in FAKWaapiJsonObject WaapiOptions)
		{
			return new FAKWaapiJsonObject(UAkWaapiCalls.__CallWaapi_Internal((WaapiUri ?? new FAkWaapiUri()).NativePtr, (WaapiArgs ?? new FAKWaapiJsonObject()).NativePtr, (WaapiOptions ?? new FAKWaapiJsonObject()).NativePtr), null);
		}

		// Token: 0x06002302 RID: 8962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Unsubscribe_Internal(IntPtr SubscriptionId, ref bool UnsubscriptionDone);

		// Token: 0x06002303 RID: 8963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SubscribeToWaapi_Internal(IntPtr WaapiUri, IntPtr WaapiOptions, IntPtr CallBack, IntPtr SubscriptionId, ref bool SubscriptionDone);

		// Token: 0x06002304 RID: 8964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubscriptionID_Internal(IntPtr Subscription, int id);

		// Token: 0x06002305 RID: 8965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RegisterWaapiProjectLoadedCallback_Internal(IntPtr Callback);

		// Token: 0x06002306 RID: 8966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RegisterWaapiConnectionLostCallback_Internal(IntPtr Callback);

		// Token: 0x06002307 RID: 8967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSubscriptionID_Internal(IntPtr Subscription);

		// Token: 0x06002308 RID: 8968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Conv_FAkWaapiSubscriptionIdToText_Internal(IntPtr INAkWaapiSubscriptionId);

		// Token: 0x06002309 RID: 8969
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __Conv_FAkWaapiSubscriptionIdToString_Internal(IntPtr INAkWaapiSubscriptionId);

		// Token: 0x0600230A RID: 8970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CallWaapi_Internal(IntPtr WaapiUri, IntPtr WaapiArgs, IntPtr WaapiOptions);

		// Token: 0x0600230B RID: 8971 RVA: 0x00033EAC File Offset: 0x000320AC
		static UAkWaapiCalls()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWaapiCalls");
		}

		// Token: 0x0600230C RID: 8972 RVA: 0x00033EBA File Offset: 0x000320BA
		protected UAkWaapiCalls(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C1D RID: 3101
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWaapiCalls";

		// Token: 0x04000C1E RID: 3102
		private static IntPtr _ClassPtr;

		// Token: 0x04000C1F RID: 3103
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
