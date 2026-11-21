using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C2 RID: 962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelDecal")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class UEffectModelDecal : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005E00 RID: 24064 RVA: 0x00084DB6 File Offset: 0x00082FB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelDecal._ClassPtr;
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x00084DC4 File Offset: 0x00082FC4
		public UEffectModelDecal() : this(BuiltinUtils.AllocNativeUObject(UEffectModelDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x00084DEC File Offset: 0x00082FEC
		public UEffectModelDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x06005E03 RID: 24067 RVA: 0x00084E1F File Offset: 0x0008301F
		// (set) Token: 0x06005E04 RID: 24068 RVA: 0x00084E33 File Offset: 0x00083033
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

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x00084E48 File Offset: 0x00083048
		// (set) Token: 0x06005E06 RID: 24070 RVA: 0x00084E81 File Offset: 0x00083081
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

		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x06005E07 RID: 24071 RVA: 0x00084EA4 File Offset: 0x000830A4
		// (set) Token: 0x06005E08 RID: 24072 RVA: 0x00084EDD File Offset: 0x000830DD
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

		// Token: 0x17001293 RID: 4755
		// (get) Token: 0x06005E09 RID: 24073 RVA: 0x00084F00 File Offset: 0x00083100
		// (set) Token: 0x06005E0A RID: 24074 RVA: 0x00084F39 File Offset: 0x00083139
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

		// Token: 0x17001294 RID: 4756
		// (get) Token: 0x06005E0B RID: 24075 RVA: 0x00084F5A File Offset: 0x0008315A
		// (set) Token: 0x06005E0C RID: 24076 RVA: 0x00084F6A File Offset: 0x0008316A
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

		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x06005E0D RID: 24077 RVA: 0x00084F7B File Offset: 0x0008317B
		// (set) Token: 0x06005E0E RID: 24078 RVA: 0x00084F8B File Offset: 0x0008318B
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

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x00084F9C File Offset: 0x0008319C
		// (set) Token: 0x06005E10 RID: 24080 RVA: 0x00084FAC File Offset: 0x000831AC
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

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x00084FBD File Offset: 0x000831BD
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x00084FCD File Offset: 0x000831CD
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

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06005E13 RID: 24083 RVA: 0x00084FDE File Offset: 0x000831DE
		// (set) Token: 0x06005E14 RID: 24084 RVA: 0x00084FEE File Offset: 0x000831EE
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

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x00085000 File Offset: 0x00083200
		// (set) Token: 0x06005E16 RID: 24086 RVA: 0x00085039 File Offset: 0x00083239
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

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06005E17 RID: 24087 RVA: 0x00085048 File Offset: 0x00083248
		// (set) Token: 0x06005E18 RID: 24088 RVA: 0x00085081 File Offset: 0x00083281
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

		// Token: 0x06005E19 RID: 24089 RVA: 0x0008508F File Offset: 0x0008328F
		static UEffectModelDecal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelDecal");
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x0008509D File Offset: 0x0008329D
		protected UEffectModelDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002735 RID: 10037
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelDecal";

		// Token: 0x04002736 RID: 10038
		private static IntPtr _ClassPtr;

		// Token: 0x04002737 RID: 10039
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002738 RID: 10040
		internal static int __PropertyOffset_DecalMaterialRef;

		// Token: 0x04002739 RID: 10041
		internal static int __PropertyOffset_Location;

		// Token: 0x0400273A RID: 10042
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400273B RID: 10043
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400273C RID: 10044
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400273D RID: 10045
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400273E RID: 10046
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400273F RID: 10047
		internal static int __PropertyOffset_SortOrder;

		// Token: 0x04002740 RID: 10048
		internal static int __PropertyOffset_ZfadingFactor;

		// Token: 0x04002741 RID: 10049
		internal static int __PropertyOffset_ZfadingPower;

		// Token: 0x04002742 RID: 10050
		internal static int __PropertyOffset_ForceRenderScene;

		// Token: 0x04002743 RID: 10051
		internal static int __PropertyOffset_ForceRenderCharactor;

		// Token: 0x04002744 RID: 10052
		internal static int __PropertyOffset_MaterialFloatParameters;

		// Token: 0x04002745 RID: 10053
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _MaterialFloatParameters;

		// Token: 0x04002746 RID: 10054
		internal static int __PropertyOffset_MaterialColorParameters;

		// Token: 0x04002747 RID: 10055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _MaterialColorParameters;
	}
}
