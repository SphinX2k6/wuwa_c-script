using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A4 RID: 932
	[UnrealObjectPath("/Script/AugmentedReality.ARGeoAnchor")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UARGeoAnchor : UARTrackedGeometry, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060033B2 RID: 13234 RVA: 0x0004F158 File Offset: 0x0004D358
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARGeoAnchor._ClassPtr;
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x0004F164 File Offset: 0x0004D364
		public UARGeoAnchor() : this(BuiltinUtils.AllocNativeUObject(UARGeoAnchor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x0004F18C File Offset: 0x0004D38C
		[NullableContext(1)]
		public UARGeoAnchor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARGeoAnchor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x0004F1BF File Offset: 0x0004D3BF
		public float GetLongitude()
		{
			return UARGeoAnchor.__GetLongitude_Internal(base.NativePtr);
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x0004F1CC File Offset: 0x0004D3CC
		public float GetLatitude()
		{
			return UARGeoAnchor.__GetLatitude_Internal(base.NativePtr);
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x0004F1D9 File Offset: 0x0004D3D9
		public EARAltitudeSource GetAltitudeSource()
		{
			return UARGeoAnchor.__GetAltitudeSource_Internal(base.NativePtr);
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x0004F1E6 File Offset: 0x0004D3E6
		public float GetAltitudeMeters()
		{
			return UARGeoAnchor.__GetAltitudeMeters_Internal(base.NativePtr);
		}

		// Token: 0x060033B9 RID: 13241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLongitude_Internal(IntPtr @this);

		// Token: 0x060033BA RID: 13242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLatitude_Internal(IntPtr @this);

		// Token: 0x060033BB RID: 13243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EARAltitudeSource __GetAltitudeSource_Internal(IntPtr @this);

		// Token: 0x060033BC RID: 13244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAltitudeMeters_Internal(IntPtr @this);

		// Token: 0x060033BD RID: 13245 RVA: 0x0004F1F3 File Offset: 0x0004D3F3
		static UARGeoAnchor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARGeoAnchor");
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x0004F201 File Offset: 0x0004D401
		protected UARGeoAnchor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001673 RID: 5747
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARGeoAnchor";

		// Token: 0x04001674 RID: 5748
		private static IntPtr _ClassPtr;

		// Token: 0x04001675 RID: 5749
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
