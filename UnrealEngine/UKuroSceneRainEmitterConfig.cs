using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BAD RID: 7085
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneRainEmitterConfig")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroSceneRainEmitterConfig : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B189 RID: 110985 RVA: 0x0027EDB4 File Offset: 0x0027CFB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneRainEmitterConfig._ClassPtr;
		}

		// Token: 0x0601B18A RID: 110986 RVA: 0x0027EDC0 File Offset: 0x0027CFC0
		public UKuroSceneRainEmitterConfig() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneRainEmitterConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B18B RID: 110987 RVA: 0x0027EDE8 File Offset: 0x0027CFE8
		public UKuroSceneRainEmitterConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneRainEmitterConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006C98 RID: 27800
		// (get) Token: 0x0601B18C RID: 110988 RVA: 0x0027EE1C File Offset: 0x0027D01C
		// (set) Token: 0x0601B18D RID: 110989 RVA: 0x0027EE55 File Offset: 0x0027D055
		public TArray<FKuroRainActorSpawnProperties> SpawnProperties
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRainActorSpawnProperties> result;
				if ((result = this._SpawnProperties) == null)
				{
					result = (this._SpawnProperties = new TArray<FKuroRainActorSpawnProperties>(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_SpawnProperties, this));
				}
				return result;
			}
			set
			{
				this.SpawnProperties.CopyAssign(value);
			}
		}

		// Token: 0x17006C99 RID: 27801
		// (get) Token: 0x0601B18E RID: 110990 RVA: 0x0027EE63 File Offset: 0x0027D063
		// (set) Token: 0x0601B18F RID: 110991 RVA: 0x0027EE77 File Offset: 0x0027D077
		public unsafe FVector CycleBoxExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_CycleBoxExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_CycleBoxExtent) = value;
			}
		}

		// Token: 0x17006C9A RID: 27802
		// (get) Token: 0x0601B190 RID: 110992 RVA: 0x0027EE8C File Offset: 0x0027D08C
		// (set) Token: 0x0601B191 RID: 110993 RVA: 0x0027EE9C File Offset: 0x0027D09C
		public unsafe float DragSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_DragSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_DragSize) = value;
			}
		}

		// Token: 0x17006C9B RID: 27803
		// (get) Token: 0x0601B192 RID: 110994 RVA: 0x0027EEAD File Offset: 0x0027D0AD
		// (set) Token: 0x0601B193 RID: 110995 RVA: 0x0027EEBD File Offset: 0x0027D0BD
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x17006C9C RID: 27804
		// (get) Token: 0x0601B194 RID: 110996 RVA: 0x0027EECE File Offset: 0x0027D0CE
		// (set) Token: 0x0601B195 RID: 110997 RVA: 0x0027EEE2 File Offset: 0x0027D0E2
		public unsafe FVector WindSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_WindSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_WindSize) = value;
			}
		}

		// Token: 0x17006C9D RID: 27805
		// (get) Token: 0x0601B196 RID: 110998 RVA: 0x0027EEF7 File Offset: 0x0027D0F7
		// (set) Token: 0x0601B197 RID: 110999 RVA: 0x0027EF0B File Offset: 0x0027D10B
		[Nullable(2)]
		public unsafe UVectorFieldStatic VectorField
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UVectorFieldStatic>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneRainEmitterConfig.__PropertyOffset_VectorField);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSceneRainEmitterConfig.__PropertyOffset_VectorField, value);
			}
		}

		// Token: 0x17006C9E RID: 27806
		// (get) Token: 0x0601B198 RID: 111000 RVA: 0x0027EF20 File Offset: 0x0027D120
		// (set) Token: 0x0601B199 RID: 111001 RVA: 0x0027EF34 File Offset: 0x0027D134
		public unsafe FVector VectorFieldPosScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_VectorFieldPosScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_VectorFieldPosScale) = value;
			}
		}

		// Token: 0x17006C9F RID: 27807
		// (get) Token: 0x0601B19A RID: 111002 RVA: 0x0027EF49 File Offset: 0x0027D149
		// (set) Token: 0x0601B19B RID: 111003 RVA: 0x0027EF5D File Offset: 0x0027D15D
		public unsafe FVector VectorFieldMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_VectorFieldMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_VectorFieldMoveSpeed) = value;
			}
		}

		// Token: 0x17006CA0 RID: 27808
		// (get) Token: 0x0601B19C RID: 111004 RVA: 0x0027EF72 File Offset: 0x0027D172
		// (set) Token: 0x0601B19D RID: 111005 RVA: 0x0027EF82 File Offset: 0x0027D182
		public unsafe float VectorFieldForceSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_VectorFieldForceSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_VectorFieldForceSize) = value;
			}
		}

		// Token: 0x17006CA1 RID: 27809
		// (get) Token: 0x0601B19E RID: 111006 RVA: 0x0027EF93 File Offset: 0x0027D193
		// (set) Token: 0x0601B19F RID: 111007 RVA: 0x0027EFA3 File Offset: 0x0027D1A3
		public unsafe float CenterBiasByWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_CenterBiasByWind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneRainEmitterConfig.__PropertyOffset_CenterBiasByWind) = value;
			}
		}

		// Token: 0x0601B1A0 RID: 111008 RVA: 0x0027EFB4 File Offset: 0x0027D1B4
		static UKuroSceneRainEmitterConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneRainEmitterConfig");
		}

		// Token: 0x0601B1A1 RID: 111009 RVA: 0x0027EFC2 File Offset: 0x0027D1C2
		protected UKuroSceneRainEmitterConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E96E RID: 59758
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneRainEmitterConfig";

		// Token: 0x0400E96F RID: 59759
		private static IntPtr _ClassPtr;

		// Token: 0x0400E970 RID: 59760
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E971 RID: 59761
		internal static int __PropertyOffset_SpawnProperties;

		// Token: 0x0400E972 RID: 59762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRainActorSpawnProperties> _SpawnProperties;

		// Token: 0x0400E973 RID: 59763
		internal static int __PropertyOffset_CycleBoxExtent;

		// Token: 0x0400E974 RID: 59764
		internal static int __PropertyOffset_DragSize;

		// Token: 0x0400E975 RID: 59765
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400E976 RID: 59766
		internal static int __PropertyOffset_WindSize;

		// Token: 0x0400E977 RID: 59767
		internal static int __PropertyOffset_VectorField;

		// Token: 0x0400E978 RID: 59768
		internal static int __PropertyOffset_VectorFieldPosScale;

		// Token: 0x0400E979 RID: 59769
		internal static int __PropertyOffset_VectorFieldMoveSpeed;

		// Token: 0x0400E97A RID: 59770
		internal static int __PropertyOffset_VectorFieldForceSize;

		// Token: 0x0400E97B RID: 59771
		internal static int __PropertyOffset_CenterBiasByWind;
	}
}
