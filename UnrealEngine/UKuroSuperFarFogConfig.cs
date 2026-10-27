using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BCD RID: 7117
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFogConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKuroSuperFarFogConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B4FD RID: 111869 RVA: 0x00283D84 File Offset: 0x00281F84
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSuperFarFogConfig._ClassPtr;
		}

		// Token: 0x0601B4FE RID: 111870 RVA: 0x00283D90 File Offset: 0x00281F90
		public UKuroSuperFarFogConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroSuperFarFogConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B4FF RID: 111871 RVA: 0x00283DB8 File Offset: 0x00281FB8
		public UKuroSuperFarFogConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSuperFarFogConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DBA RID: 28090
		// (get) Token: 0x0601B500 RID: 111872 RVA: 0x00283DEC File Offset: 0x00281FEC
		// (set) Token: 0x0601B501 RID: 111873 RVA: 0x00283E25 File Offset: 0x00282025
		public TArray<FKuroSuperFarFogLayer> Layers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSuperFarFogLayer> result;
				if ((result = this._Layers) == null)
				{
					result = (this._Layers = new TArray<FKuroSuperFarFogLayer>(base.NativePtr + (IntPtr)UKuroSuperFarFogConfig.__PropertyOffset_Layers, this));
				}
				return result;
			}
			set
			{
				this.Layers.CopyAssign(value);
			}
		}

		// Token: 0x17006DBB RID: 28091
		// (get) Token: 0x0601B502 RID: 111874 RVA: 0x00283E33 File Offset: 0x00282033
		// (set) Token: 0x0601B503 RID: 111875 RVA: 0x00283E43 File Offset: 0x00282043
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSuperFarFogConfig.__PropertyOffset_MinDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSuperFarFogConfig.__PropertyOffset_MinDistance) = value;
			}
		}

		// Token: 0x17006DBC RID: 28092
		// (get) Token: 0x0601B504 RID: 111876 RVA: 0x00283E54 File Offset: 0x00282054
		// (set) Token: 0x0601B505 RID: 111877 RVA: 0x00283E64 File Offset: 0x00282064
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSuperFarFogConfig.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSuperFarFogConfig.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17006DBD RID: 28093
		// (get) Token: 0x0601B506 RID: 111878 RVA: 0x00283E75 File Offset: 0x00282075
		// (set) Token: 0x0601B507 RID: 111879 RVA: 0x00283E85 File Offset: 0x00282085
		public unsafe float MobileDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSuperFarFogConfig.__PropertyOffset_MobileDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSuperFarFogConfig.__PropertyOffset_MobileDistanceScale) = value;
			}
		}

		// Token: 0x0601B508 RID: 111880 RVA: 0x00283E96 File Offset: 0x00282096
		static UKuroSuperFarFogConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFogConfig");
		}

		// Token: 0x0601B509 RID: 111881 RVA: 0x00283EA4 File Offset: 0x002820A4
		protected UKuroSuperFarFogConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB4C RID: 60236
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSuperFarFogConfig";

		// Token: 0x0400EB4D RID: 60237
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB4E RID: 60238
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EB4F RID: 60239
		internal static int __PropertyOffset_Layers;

		// Token: 0x0400EB50 RID: 60240
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSuperFarFogLayer> _Layers;

		// Token: 0x0400EB51 RID: 60241
		internal static int __PropertyOffset_MinDistance;

		// Token: 0x0400EB52 RID: 60242
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400EB53 RID: 60243
		internal static int __PropertyOffset_MobileDistanceScale;
	}
}
