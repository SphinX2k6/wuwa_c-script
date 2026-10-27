using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B0B RID: 6923
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroGISettings")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UKuroGISettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019F0A RID: 106250 RVA: 0x002651B4 File Offset: 0x002633B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGISettings._ClassPtr;
		}

		// Token: 0x06019F0B RID: 106251 RVA: 0x002651C0 File Offset: 0x002633C0
		public UKuroGISettings() : this(BuiltinUtils.AllocNativeUObject(UKuroGISettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019F0C RID: 106252 RVA: 0x002651E8 File Offset: 0x002633E8
		public UKuroGISettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGISettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006801 RID: 26625
		// (get) Token: 0x06019F0D RID: 106253 RVA: 0x0026521C File Offset: 0x0026341C
		// (set) Token: 0x06019F0E RID: 106254 RVA: 0x00265255 File Offset: 0x00263455
		public TArray<FName> ThunderProfileNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ThunderProfileNames) == null)
				{
					result = (this._ThunderProfileNames = new TArray<FName>(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_ThunderProfileNames, this));
				}
				return result;
			}
			set
			{
				this.ThunderProfileNames.CopyAssign(value);
			}
		}

		// Token: 0x17006802 RID: 26626
		// (get) Token: 0x06019F0F RID: 106255 RVA: 0x00265264 File Offset: 0x00263464
		// (set) Token: 0x06019F10 RID: 106256 RVA: 0x0026529D File Offset: 0x0026349D
		public TArray<FName> RainProfileNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._RainProfileNames) == null)
				{
					result = (this._RainProfileNames = new TArray<FName>(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_RainProfileNames, this));
				}
				return result;
			}
			set
			{
				this.RainProfileNames.CopyAssign(value);
			}
		}

		// Token: 0x17006803 RID: 26627
		// (get) Token: 0x06019F11 RID: 106257 RVA: 0x002652AC File Offset: 0x002634AC
		// (set) Token: 0x06019F12 RID: 106258 RVA: 0x002652E5 File Offset: 0x002634E5
		public TArray<FSoftObjectPath> LensflareDatas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._LensflareDatas) == null)
				{
					result = (this._LensflareDatas = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_LensflareDatas, this));
				}
				return result;
			}
			set
			{
				this.LensflareDatas.CopyAssign(value);
			}
		}

		// Token: 0x17006804 RID: 26628
		// (get) Token: 0x06019F13 RID: 106259 RVA: 0x002652F3 File Offset: 0x002634F3
		// (set) Token: 0x06019F14 RID: 106260 RVA: 0x00265308 File Offset: 0x00263508
		public TSoftObjectPtr<UKuroLandscapeParametersData> LandscapeParametersData
		{
			get
			{
				return new TSoftObjectPtr<UKuroLandscapeParametersData>(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_LandscapeParametersData, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_LandscapeParametersData, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17006805 RID: 26629
		// (get) Token: 0x06019F15 RID: 106261 RVA: 0x0026532D File Offset: 0x0026352D
		// (set) Token: 0x06019F16 RID: 106262 RVA: 0x00265341 File Offset: 0x00263541
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UKuroMaterialControllerDataAsset> MaterialControllerBlueprintClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_MaterialControllerBlueprintClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_MaterialControllerBlueprintClass) = value;
			}
		}

		// Token: 0x17006806 RID: 26630
		// (get) Token: 0x06019F17 RID: 106263 RVA: 0x00265358 File Offset: 0x00263558
		// (set) Token: 0x06019F18 RID: 106264 RVA: 0x00265391 File Offset: 0x00263591
		public FSoftObjectPath EmptyMaterial
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._EmptyMaterial) == null)
				{
					result = (this._EmptyMaterial = new FSoftObjectPath(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_EmptyMaterial, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_EmptyMaterial, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006807 RID: 26631
		// (get) Token: 0x06019F19 RID: 106265 RVA: 0x002653B2 File Offset: 0x002635B2
		// (set) Token: 0x06019F1A RID: 106266 RVA: 0x002653C6 File Offset: 0x002635C6
		[Nullable(2)]
		public unsafe UMaterialInterface EmptyMaterialLoaded
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISettings.__PropertyOffset_EmptyMaterialLoaded);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroGISettings.__PropertyOffset_EmptyMaterialLoaded, value);
			}
		}

		// Token: 0x17006808 RID: 26632
		// (get) Token: 0x06019F1B RID: 106267 RVA: 0x002653DC File Offset: 0x002635DC
		// (set) Token: 0x06019F1C RID: 106268 RVA: 0x00265415 File Offset: 0x00263615
		public TArray<UKuroPPLensflareData> LensflareDatasLoaded
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UKuroPPLensflareData> result;
				if ((result = this._LensflareDatasLoaded) == null)
				{
					result = (this._LensflareDatasLoaded = new TArray<UKuroPPLensflareData>(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_LensflareDatasLoaded, this));
				}
				return result;
			}
			set
			{
				this.LensflareDatasLoaded.CopyAssign(value);
			}
		}

		// Token: 0x17006809 RID: 26633
		// (get) Token: 0x06019F1D RID: 106269 RVA: 0x00265423 File Offset: 0x00263623
		// (set) Token: 0x06019F1E RID: 106270 RVA: 0x00265437 File Offset: 0x00263637
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AKuroCurveTrailDecalSpawner> KuroCurveTrailDecalSpawnerClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_KuroCurveTrailDecalSpawnerClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroGISettings.__PropertyOffset_KuroCurveTrailDecalSpawnerClass) = value;
			}
		}

		// Token: 0x06019F1F RID: 106271 RVA: 0x0026544C File Offset: 0x0026364C
		static UKuroGISettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroGISettings");
		}

		// Token: 0x06019F20 RID: 106272 RVA: 0x0026545A File Offset: 0x0026365A
		protected UKuroGISettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E1B2 RID: 57778
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroGISettings";

		// Token: 0x0400E1B3 RID: 57779
		private static IntPtr _ClassPtr;

		// Token: 0x0400E1B4 RID: 57780
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E1B5 RID: 57781
		internal static int __PropertyOffset_ThunderProfileNames;

		// Token: 0x0400E1B6 RID: 57782
		[Nullable(2)]
		private TArray<FName> _ThunderProfileNames;

		// Token: 0x0400E1B7 RID: 57783
		internal static int __PropertyOffset_RainProfileNames;

		// Token: 0x0400E1B8 RID: 57784
		[Nullable(2)]
		private TArray<FName> _RainProfileNames;

		// Token: 0x0400E1B9 RID: 57785
		internal static int __PropertyOffset_LensflareDatas;

		// Token: 0x0400E1BA RID: 57786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _LensflareDatas;

		// Token: 0x0400E1BB RID: 57787
		internal static int __PropertyOffset_LandscapeParametersData;

		// Token: 0x0400E1BC RID: 57788
		internal static int __PropertyOffset_MaterialControllerBlueprintClass;

		// Token: 0x0400E1BD RID: 57789
		internal static int __PropertyOffset_EmptyMaterial;

		// Token: 0x0400E1BE RID: 57790
		[Nullable(2)]
		private FSoftObjectPath _EmptyMaterial;

		// Token: 0x0400E1BF RID: 57791
		internal static int __PropertyOffset_EmptyMaterialLoaded;

		// Token: 0x0400E1C0 RID: 57792
		internal static int __PropertyOffset_LensflareDatasLoaded;

		// Token: 0x0400E1C1 RID: 57793
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKuroPPLensflareData> _LensflareDatasLoaded;

		// Token: 0x0400E1C2 RID: 57794
		internal static int __PropertyOffset_KuroCurveTrailDecalSpawnerClass;
	}
}
