using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012D8 RID: 4824
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.ProceduralFoliageTile")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UProceduralFoliageTile : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011B1D RID: 72477 RVA: 0x0019FAD8 File Offset: 0x0019DCD8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UProceduralFoliageTile._ClassPtr;
		}

		// Token: 0x06011B1E RID: 72478 RVA: 0x0019FAE4 File Offset: 0x0019DCE4
		public UProceduralFoliageTile() : this(BuiltinUtils.AllocNativeUObject(UProceduralFoliageTile.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011B1F RID: 72479 RVA: 0x0019FB0C File Offset: 0x0019DD0C
		public UProceduralFoliageTile(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UProceduralFoliageTile.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004542 RID: 17730
		// (get) Token: 0x06011B20 RID: 72480 RVA: 0x0019FB3F File Offset: 0x0019DD3F
		// (set) Token: 0x06011B21 RID: 72481 RVA: 0x0019FB53 File Offset: 0x0019DD53
		[Nullable(2)]
		public unsafe UProceduralFoliageSpawner FoliageSpawner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UProceduralFoliageSpawner>(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralFoliageTile.__PropertyOffset_FoliageSpawner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UProceduralFoliageTile.__PropertyOffset_FoliageSpawner, value);
			}
		}

		// Token: 0x17004543 RID: 17731
		// (get) Token: 0x06011B22 RID: 72482 RVA: 0x0019FB68 File Offset: 0x0019DD68
		// (set) Token: 0x06011B23 RID: 72483 RVA: 0x0019FBA1 File Offset: 0x0019DDA1
		public TArray<FProceduralFoliageInstance> InstancesArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FProceduralFoliageInstance> result;
				if ((result = this._InstancesArray) == null)
				{
					result = (this._InstancesArray = new TArray<FProceduralFoliageInstance>(base.NativePtr + (IntPtr)UProceduralFoliageTile.__PropertyOffset_InstancesArray, this));
				}
				return result;
			}
			set
			{
				this.InstancesArray.CopyAssign(value);
			}
		}

		// Token: 0x06011B24 RID: 72484 RVA: 0x0019FBAF File Offset: 0x0019DDAF
		static UProceduralFoliageTile()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.ProceduralFoliageTile");
		}

		// Token: 0x06011B25 RID: 72485 RVA: 0x0019FBBD File Offset: 0x0019DDBD
		protected UProceduralFoliageTile(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040097DC RID: 38876
		public new const string __ObjectPath = "/Script/Foliage.ProceduralFoliageTile";

		// Token: 0x040097DD RID: 38877
		private static IntPtr _ClassPtr;

		// Token: 0x040097DE RID: 38878
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040097DF RID: 38879
		internal static int __PropertyOffset_FoliageSpawner;

		// Token: 0x040097E0 RID: 38880
		internal static int __PropertyOffset_InstancesArray;

		// Token: 0x040097E1 RID: 38881
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FProceduralFoliageInstance> _InstancesArray;
	}
}
