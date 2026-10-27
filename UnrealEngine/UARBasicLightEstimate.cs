using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000396 RID: 918
	[UnrealObjectPath("/Script/AugmentedReality.ARBasicLightEstimate")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UARBasicLightEstimate : UARLightEstimate, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003266 RID: 12902 RVA: 0x0004DB85 File Offset: 0x0004BD85
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UARBasicLightEstimate._ClassPtr;
		}

		// Token: 0x06003267 RID: 12903 RVA: 0x0004DB94 File Offset: 0x0004BD94
		public UARBasicLightEstimate() : this(BuiltinUtils.AllocNativeUObject(UARBasicLightEstimate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003268 RID: 12904 RVA: 0x0004DBBC File Offset: 0x0004BDBC
		[NullableContext(1)]
		public UARBasicLightEstimate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UARBasicLightEstimate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x0004DBEF File Offset: 0x0004BDEF
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x0004DBFF File Offset: 0x0004BDFF
		public unsafe float AmbientIntensityLumens
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARBasicLightEstimate.__PropertyOffset_AmbientIntensityLumens);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARBasicLightEstimate.__PropertyOffset_AmbientIntensityLumens) = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x0004DC10 File Offset: 0x0004BE10
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x0004DC20 File Offset: 0x0004BE20
		public unsafe float AmbientColorTemperatureKelvin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARBasicLightEstimate.__PropertyOffset_AmbientColorTemperatureKelvin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARBasicLightEstimate.__PropertyOffset_AmbientColorTemperatureKelvin) = value;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x0004DC31 File Offset: 0x0004BE31
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x0004DC45 File Offset: 0x0004BE45
		public unsafe FLinearColor AmbientColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UARBasicLightEstimate.__PropertyOffset_AmbientColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UARBasicLightEstimate.__PropertyOffset_AmbientColor) = value;
			}
		}

		// Token: 0x0600326F RID: 12911 RVA: 0x0004DC5A File Offset: 0x0004BE5A
		public float GetAmbientIntensityLumens()
		{
			return UARBasicLightEstimate.__GetAmbientIntensityLumens_Internal(base.NativePtr);
		}

		// Token: 0x06003270 RID: 12912 RVA: 0x0004DC67 File Offset: 0x0004BE67
		public float GetAmbientColorTemperatureKelvin()
		{
			return UARBasicLightEstimate.__GetAmbientColorTemperatureKelvin_Internal(base.NativePtr);
		}

		// Token: 0x06003271 RID: 12913 RVA: 0x0004DC74 File Offset: 0x0004BE74
		public FLinearColor GetAmbientColor()
		{
			return UARBasicLightEstimate.__GetAmbientColor_Internal(base.NativePtr);
		}

		// Token: 0x06003272 RID: 12914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAmbientIntensityLumens_Internal(IntPtr @this);

		// Token: 0x06003273 RID: 12915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAmbientColorTemperatureKelvin_Internal(IntPtr @this);

		// Token: 0x06003274 RID: 12916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetAmbientColor_Internal(IntPtr @this);

		// Token: 0x06003275 RID: 12917 RVA: 0x0004DC81 File Offset: 0x0004BE81
		static UARBasicLightEstimate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARBasicLightEstimate");
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x0004DC8F File Offset: 0x0004BE8F
		protected UARBasicLightEstimate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400161E RID: 5662
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARBasicLightEstimate";

		// Token: 0x0400161F RID: 5663
		private static IntPtr _ClassPtr;

		// Token: 0x04001620 RID: 5664
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001621 RID: 5665
		internal static int __PropertyOffset_AmbientIntensityLumens;

		// Token: 0x04001622 RID: 5666
		internal static int __PropertyOffset_AmbientColorTemperatureKelvin;

		// Token: 0x04001623 RID: 5667
		internal static int __PropertyOffset_AmbientColor;
	}
}
