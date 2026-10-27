using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D4 RID: 4820
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.ProceduralFoliageBlockingVolume")]
	[UnrealStructLayout(1256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1256)]
	public class AProceduralFoliageBlockingVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011AE2 RID: 72418 RVA: 0x0019F5E3 File Offset: 0x0019D7E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AProceduralFoliageBlockingVolume._ClassPtr;
		}

		// Token: 0x06011AE3 RID: 72419 RVA: 0x0019F5F0 File Offset: 0x0019D7F0
		public AProceduralFoliageBlockingVolume() : this(BuiltinUtils.AllocNativeUObject(AProceduralFoliageBlockingVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011AE4 RID: 72420 RVA: 0x0019F618 File Offset: 0x0019D818
		public AProceduralFoliageBlockingVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AProceduralFoliageBlockingVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x06011AE5 RID: 72421 RVA: 0x0019F64B File Offset: 0x0019D84B
		// (set) Token: 0x06011AE6 RID: 72422 RVA: 0x0019F65F File Offset: 0x0019D85F
		[Nullable(2)]
		public unsafe AProceduralFoliageVolume ProceduralFoliageVolume
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AProceduralFoliageVolume>(base.NativePtr / (IntPtr)sizeof(void*) + AProceduralFoliageBlockingVolume.__PropertyOffset_ProceduralFoliageVolume);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AProceduralFoliageBlockingVolume.__PropertyOffset_ProceduralFoliageVolume, value);
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x06011AE7 RID: 72423 RVA: 0x0019F674 File Offset: 0x0019D874
		// (set) Token: 0x06011AE8 RID: 72424 RVA: 0x0019F6AD File Offset: 0x0019D8AD
		public FFoliageDensityFalloff DensityFalloff
		{
			get
			{
				base.FastCheckIsValid();
				FFoliageDensityFalloff result;
				if ((result = this._DensityFalloff) == null)
				{
					result = (this._DensityFalloff = new FFoliageDensityFalloff(base.NativePtr + (IntPtr)AProceduralFoliageBlockingVolume.__PropertyOffset_DensityFalloff, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFoliageDensityFalloff.StaticStruct(), base.NativePtr + (IntPtr)AProceduralFoliageBlockingVolume.__PropertyOffset_DensityFalloff, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06011AE9 RID: 72425 RVA: 0x0019F6CE File Offset: 0x0019D8CE
		static AProceduralFoliageBlockingVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.ProceduralFoliageBlockingVolume");
		}

		// Token: 0x06011AEA RID: 72426 RVA: 0x0019F6DC File Offset: 0x0019D8DC
		protected AProceduralFoliageBlockingVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040097BE RID: 38846
		public new const string __ObjectPath = "/Script/Foliage.ProceduralFoliageBlockingVolume";

		// Token: 0x040097BF RID: 38847
		private static IntPtr _ClassPtr;

		// Token: 0x040097C0 RID: 38848
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040097C1 RID: 38849
		internal static int __PropertyOffset_ProceduralFoliageVolume;

		// Token: 0x040097C2 RID: 38850
		internal static int __PropertyOffset_DensityFalloff;

		// Token: 0x040097C3 RID: 38851
		[Nullable(2)]
		private FFoliageDensityFalloff _DensityFalloff;
	}
}
