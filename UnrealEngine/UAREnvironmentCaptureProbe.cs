using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039D RID: 925
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.AREnvironmentCaptureProbe")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UAREnvironmentCaptureProbe : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003347 RID: 13127 RVA: 0x0004E91D File Offset: 0x0004CB1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAREnvironmentCaptureProbe._ClassPtr;
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x0004E92C File Offset: 0x0004CB2C
		public UAREnvironmentCaptureProbe() : this(BuiltinUtils.AllocNativeUObject(UAREnvironmentCaptureProbe.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x0004E954 File Offset: 0x0004CB54
		[NullableContext(1)]
		public UAREnvironmentCaptureProbe(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAREnvironmentCaptureProbe.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x0004E987 File Offset: 0x0004CB87
		// (set) Token: 0x0600334B RID: 13131 RVA: 0x0004E99B File Offset: 0x0004CB9B
		public unsafe FVector Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbe.__PropertyOffset_Extent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAREnvironmentCaptureProbe.__PropertyOffset_Extent) = value;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x0004E9B0 File Offset: 0x0004CBB0
		// (set) Token: 0x0600334D RID: 13133 RVA: 0x0004E9C4 File Offset: 0x0004CBC4
		public unsafe UAREnvironmentCaptureProbeTexture EnvironmentCaptureTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAREnvironmentCaptureProbeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UAREnvironmentCaptureProbe.__PropertyOffset_EnvironmentCaptureTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAREnvironmentCaptureProbe.__PropertyOffset_EnvironmentCaptureTexture, value);
			}
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x0004E9D9 File Offset: 0x0004CBD9
		public FVector GetExtent()
		{
			return UAREnvironmentCaptureProbe.__GetExtent_Internal(base.NativePtr);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x0004E9E6 File Offset: 0x0004CBE6
		public UAREnvironmentCaptureProbeTexture GetEnvironmentCaptureTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAREnvironmentCaptureProbeTexture>(UAREnvironmentCaptureProbe.__GetEnvironmentCaptureTexture_Internal(base.NativePtr));
		}

		// Token: 0x06003350 RID: 13136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetExtent_Internal(IntPtr @this);

		// Token: 0x06003351 RID: 13137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEnvironmentCaptureTexture_Internal(IntPtr @this);

		// Token: 0x06003352 RID: 13138 RVA: 0x0004E9F8 File Offset: 0x0004CBF8
		static UAREnvironmentCaptureProbe()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.AREnvironmentCaptureProbe");
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x0004EA06 File Offset: 0x0004CC06
		protected UAREnvironmentCaptureProbe(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001647 RID: 5703
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.AREnvironmentCaptureProbe";

		// Token: 0x04001648 RID: 5704
		private static IntPtr _ClassPtr;

		// Token: 0x04001649 RID: 5705
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400164A RID: 5706
		internal static int __PropertyOffset_Extent;

		// Token: 0x0400164B RID: 5707
		internal static int __PropertyOffset_EnvironmentCaptureTexture;
	}
}
