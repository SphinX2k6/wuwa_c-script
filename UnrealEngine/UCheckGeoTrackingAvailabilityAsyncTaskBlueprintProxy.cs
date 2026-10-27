using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003DA RID: 986
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy : UARBaseAsyncTaskBlueprintProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003738 RID: 14136 RVA: 0x00053C7A File Offset: 0x00051E7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy._ClassPtr;
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00053C88 File Offset: 0x00051E88
		public UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy() : this(BuiltinUtils.AllocNativeUObject(UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00053CB0 File Offset: 0x00051EB0
		public UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x00053CE4 File Offset: 0x00051EE4
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x00053D1D File Offset: 0x00051F1D
		public FGeoTrackingAvailabilityDelegate OnSuccess
		{
			get
			{
				base.FastCheckIsValid();
				FGeoTrackingAvailabilityDelegate result;
				if ((result = this._OnSuccess) == null)
				{
					result = (this._OnSuccess = new FGeoTrackingAvailabilityDelegate(base.NativePtr + (IntPtr)UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__PropertyOffset_OnSuccess, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x00053D40 File Offset: 0x00051F40
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x00053D79 File Offset: 0x00051F79
		public FGeoTrackingAvailabilityDelegate OnFailed
		{
			get
			{
				base.FastCheckIsValid();
				FGeoTrackingAvailabilityDelegate result;
				if ((result = this._OnFailed) == null)
				{
					result = (this._OnFailed = new FGeoTrackingAvailabilityDelegate(base.NativePtr + (IntPtr)UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__PropertyOffset_OnFailed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00053D9A File Offset: 0x00051F9A
		[NullableContext(2)]
		public static UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailabilityAtLocation(UObject WorldContextObject, float Longitude, float Latitude)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy>(UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__CheckGeoTrackingAvailabilityAtLocation_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Longitude, Latitude));
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00053DB8 File Offset: 0x00051FB8
		[NullableContext(2)]
		public static UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy CheckGeoTrackingAvailability(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy>(UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy.__CheckGeoTrackingAvailability_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06003741 RID: 14145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CheckGeoTrackingAvailabilityAtLocation_Internal(IntPtr WorldContextObject, float Longitude, float Latitude);

		// Token: 0x06003742 RID: 14146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CheckGeoTrackingAvailability_Internal(IntPtr WorldContextObject);

		// Token: 0x06003743 RID: 14147 RVA: 0x00053DD4 File Offset: 0x00051FD4
		static UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy");
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00053DE2 File Offset: 0x00051FE2
		protected UCheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040017F3 RID: 6131
		public new const string __ObjectPath = "/Script/AugmentedReality.CheckGeoTrackingAvailabilityAsyncTaskBlueprintProxy";

		// Token: 0x040017F4 RID: 6132
		private static IntPtr _ClassPtr;

		// Token: 0x040017F5 RID: 6133
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040017F6 RID: 6134
		public static IntPtr __GeoTrackingAvailabilityDelegate__DelegateSignature_NativeFunctionPtr;

		// Token: 0x040017F7 RID: 6135
		internal static int __PropertyOffset_OnSuccess;

		// Token: 0x040017F8 RID: 6136
		[Nullable(2)]
		private FGeoTrackingAvailabilityDelegate _OnSuccess;

		// Token: 0x040017F9 RID: 6137
		internal static int __PropertyOffset_OnFailed;

		// Token: 0x040017FA RID: 6138
		[Nullable(2)]
		private FGeoTrackingAvailabilityDelegate _OnFailed;
	}
}
