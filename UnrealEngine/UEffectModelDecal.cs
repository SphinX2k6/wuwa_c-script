using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200189F RID: 6303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelDecal")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class UEffectModelDecal : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017357 RID: 95063 RVA: 0x0021D943 File Offset: 0x0021BB43
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelDecal._ClassPtr;
		}

		// Token: 0x06017358 RID: 95064 RVA: 0x0021D950 File Offset: 0x0021BB50
		public UEffectModelDecal() : this(BuiltinUtils.AllocNativeUObject(UEffectModelDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017359 RID: 95065 RVA: 0x0021D978 File Offset: 0x0021BB78
		public UEffectModelDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D4E RID: 23886
		// (get) Token: 0x0601735A RID: 95066 RVA: 0x0021D9AB File Offset: 0x0021BBAB
		// (set) Token: 0x0601735B RID: 95067 RVA: 0x0021D9BF File Offset: 0x0021BBBF
		[Nullable(2)]
		public unsafe UMaterialInterface DecalMaterialRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelDecal.__PropertyOffset_DecalMaterialRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelDecal.__PropertyOffset_DecalMaterialRef, value);
			}
		}

		// Token: 0x17005D4F RID: 23887
		// (get) Token: 0x0601735C RID: 95068 RVA: 0x0021D9D4 File Offset: 0x0021BBD4
		// (set) Token: 0x0601735D RID: 95069 RVA: 0x0021DA0D File Offset: 0x0021BC0D
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D50 RID: 23888
		// (get) Token: 0x0601735E RID: 95070 RVA: 0x0021DA30 File Offset: 0x0021BC30
		// (set) Token: 0x0601735F RID: 95071 RVA: 0x0021DA69 File Offset: 0x0021BC69
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D51 RID: 23889
		// (get) Token: 0x06017360 RID: 95072 RVA: 0x0021DA8C File Offset: 0x0021BC8C
		// (set) Token: 0x06017361 RID: 95073 RVA: 0x0021DAC5 File Offset: 0x0021BCC5
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D52 RID: 23890
		// (get) Token: 0x06017362 RID: 95074 RVA: 0x0021DAE6 File Offset: 0x0021BCE6
		// (set) Token: 0x06017363 RID: 95075 RVA: 0x0021DAF6 File Offset: 0x0021BCF6
		public unsafe int SortOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_SortOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_SortOrder) = value;
			}
		}

		// Token: 0x17005D53 RID: 23891
		// (get) Token: 0x06017364 RID: 95076 RVA: 0x0021DB07 File Offset: 0x0021BD07
		// (set) Token: 0x06017365 RID: 95077 RVA: 0x0021DB17 File Offset: 0x0021BD17
		public unsafe float ZfadingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ZfadingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ZfadingFactor) = value;
			}
		}

		// Token: 0x17005D54 RID: 23892
		// (get) Token: 0x06017366 RID: 95078 RVA: 0x0021DB28 File Offset: 0x0021BD28
		// (set) Token: 0x06017367 RID: 95079 RVA: 0x0021DB38 File Offset: 0x0021BD38
		public unsafe float ZfadingPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ZfadingPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ZfadingPower) = value;
			}
		}

		// Token: 0x17005D55 RID: 23893
		// (get) Token: 0x06017368 RID: 95080 RVA: 0x0021DB49 File Offset: 0x0021BD49
		// (set) Token: 0x06017369 RID: 95081 RVA: 0x0021DB59 File Offset: 0x0021BD59
		public unsafe bool ForceRenderScene
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ForceRenderScene) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ForceRenderScene) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D56 RID: 23894
		// (get) Token: 0x0601736A RID: 95082 RVA: 0x0021DB6A File Offset: 0x0021BD6A
		// (set) Token: 0x0601736B RID: 95083 RVA: 0x0021DB7A File Offset: 0x0021BD7A
		public unsafe bool ForceRenderCharactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ForceRenderCharactor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_ForceRenderCharactor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005D57 RID: 23895
		// (get) Token: 0x0601736C RID: 95084 RVA: 0x0021DB8C File Offset: 0x0021BD8C
		// (set) Token: 0x0601736D RID: 95085 RVA: 0x0021DBC5 File Offset: 0x0021BDC5
		public TMap<FName, FKuroCurveFloat> MaterialFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._MaterialFloatParameters) == null)
				{
					result = (this._MaterialFloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_MaterialFloatParameters, this));
				}
				return result;
			}
			set
			{
				this.MaterialFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005D58 RID: 23896
		// (get) Token: 0x0601736E RID: 95086 RVA: 0x0021DBD4 File Offset: 0x0021BDD4
		// (set) Token: 0x0601736F RID: 95087 RVA: 0x0021DC0D File Offset: 0x0021BE0D
		public TMap<FName, FKuroCurveLinearColor> MaterialColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._MaterialColorParameters) == null)
				{
					result = (this._MaterialColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelDecal.__PropertyOffset_MaterialColorParameters, this));
				}
				return result;
			}
			set
			{
				this.MaterialColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x06017370 RID: 95088 RVA: 0x0021DC1B File Offset: 0x0021BE1B
		static UEffectModelDecal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelDecal");
		}

		// Token: 0x06017371 RID: 95089 RVA: 0x0021DC29 File Offset: 0x0021BE29
		protected UEffectModelDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C967 RID: 51559
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelDecal";

		// Token: 0x0400C968 RID: 51560
		private static IntPtr _ClassPtr;

		// Token: 0x0400C969 RID: 51561
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C96A RID: 51562
		internal static int __PropertyOffset_DecalMaterialRef;

		// Token: 0x0400C96B RID: 51563
		internal static int __PropertyOffset_Location;

		// Token: 0x0400C96C RID: 51564
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400C96D RID: 51565
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400C96E RID: 51566
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400C96F RID: 51567
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400C970 RID: 51568
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400C971 RID: 51569
		internal static int __PropertyOffset_SortOrder;

		// Token: 0x0400C972 RID: 51570
		internal static int __PropertyOffset_ZfadingFactor;

		// Token: 0x0400C973 RID: 51571
		internal static int __PropertyOffset_ZfadingPower;

		// Token: 0x0400C974 RID: 51572
		internal static int __PropertyOffset_ForceRenderScene;

		// Token: 0x0400C975 RID: 51573
		internal static int __PropertyOffset_ForceRenderCharactor;

		// Token: 0x0400C976 RID: 51574
		internal static int __PropertyOffset_MaterialFloatParameters;

		// Token: 0x0400C977 RID: 51575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _MaterialFloatParameters;

		// Token: 0x0400C978 RID: 51576
		internal static int __PropertyOffset_MaterialColorParameters;

		// Token: 0x0400C979 RID: 51577
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _MaterialColorParameters;
	}
}
