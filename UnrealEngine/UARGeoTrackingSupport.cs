using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A7 RID: 935
	[UnrealObjectPath("/Script/AugmentedReality.ARGeoTrackingSupport")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UARGeoTrackingSupport : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060033E3 RID: 13283 RVA: 0x0004F513 File Offset: 0x0004D713
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARGeoTrackingSupport._ClassPtr;
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x0004F51F File Offset: 0x0004D71F
		[NullableContext(2)]
		public static UARGeoTrackingSupport GetGeoTrackingSupport()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARGeoTrackingSupport>(UARGeoTrackingSupport.__GetGeoTrackingSupport_Internal());
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x0004F52B File Offset: 0x0004D72B
		public EARGeoTrackingStateReason GetGeoTrackingStateReason()
		{
			return UARGeoTrackingSupport.__GetGeoTrackingStateReason_Internal(base.NativePtr);
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x0004F538 File Offset: 0x0004D738
		public EARGeoTrackingState GetGeoTrackingState()
		{
			return UARGeoTrackingSupport.__GetGeoTrackingState_Internal(base.NativePtr);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x0004F545 File Offset: 0x0004D745
		public EARGeoTrackingAccuracy GetGeoTrackingAccuracy()
		{
			return UARGeoTrackingSupport.__GetGeoTrackingAccuracy_Internal(base.NativePtr);
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x0004F554 File Offset: 0x0004D754
		[NullableContext(1)]
		public unsafe bool AddGeoAnchorAtLocationWithAltitude(float Longitude, float Latitude, float AltitudeMeters, string OptionalAnchorName)
		{
			FString fstring = FString.AllocTemp(OptionalAnchorName);
			bool result = UARGeoTrackingSupport.__AddGeoAnchorAtLocationWithAltitude_Internal(base.NativePtr, Longitude, Latitude, AltitudeMeters, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x0004F584 File Offset: 0x0004D784
		[NullableContext(1)]
		public unsafe bool AddGeoAnchorAtLocation(float Longitude, float Latitude, string OptionalAnchorName)
		{
			FString fstring = FString.AllocTemp(OptionalAnchorName);
			bool result = UARGeoTrackingSupport.__AddGeoAnchorAtLocation_Internal(base.NativePtr, Longitude, Latitude, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060033EA RID: 13290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGeoTrackingSupport_Internal();

		// Token: 0x060033EB RID: 13291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARGeoTrackingStateReason __GetGeoTrackingStateReason_Internal(IntPtr @this);

		// Token: 0x060033EC RID: 13292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARGeoTrackingState __GetGeoTrackingState_Internal(IntPtr @this);

		// Token: 0x060033ED RID: 13293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARGeoTrackingAccuracy __GetGeoTrackingAccuracy_Internal(IntPtr @this);

		// Token: 0x060033EE RID: 13294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddGeoAnchorAtLocationWithAltitude_Internal(IntPtr @this, float Longitude, float Latitude, float AltitudeMeters, in FString OptionalAnchorName);

		// Token: 0x060033EF RID: 13295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddGeoAnchorAtLocation_Internal(IntPtr @this, float Longitude, float Latitude, in FString OptionalAnchorName);

		// Token: 0x060033F0 RID: 13296 RVA: 0x0004F5B0 File Offset: 0x0004D7B0
		static UARGeoTrackingSupport()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARGeoTrackingSupport");
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x0004F5C0 File Offset: 0x0004D7C0
		protected UARGeoTrackingSupport() : this(BuiltinUtils.AllocNativeUObject(UARGeoTrackingSupport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x0004F5E8 File Offset: 0x0004D7E8
		protected UARGeoTrackingSupport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001685 RID: 5765
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARGeoTrackingSupport";

		// Token: 0x04001686 RID: 5766
		private static IntPtr _ClassPtr;

		// Token: 0x04001687 RID: 5767
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
