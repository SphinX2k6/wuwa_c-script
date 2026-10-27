using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000499 RID: 1177
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeNv.ClothPhysicalMeshDataNv_Legacy")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UClothPhysicalMeshDataNv_Legacy : UClothPhysicalMeshDataBase_Legacy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003F5C RID: 16220 RVA: 0x0005F2A4 File Offset: 0x0005D4A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothPhysicalMeshDataNv_Legacy._ClassPtr;
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x0005F2B0 File Offset: 0x0005D4B0
		public UClothPhysicalMeshDataNv_Legacy() : this(BuiltinUtils.AllocNativeUObject(UClothPhysicalMeshDataNv_Legacy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x0005F2D8 File Offset: 0x0005D4D8
		public UClothPhysicalMeshDataNv_Legacy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClothPhysicalMeshDataNv_Legacy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06003F5F RID: 16223 RVA: 0x0005F30C File Offset: 0x0005D50C
		// (set) Token: 0x06003F60 RID: 16224 RVA: 0x0005F345 File Offset: 0x0005D545
		public TArray<float> MaxDistances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._MaxDistances) == null)
				{
					result = (this._MaxDistances = new TArray<float>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataNv_Legacy.__PropertyOffset_MaxDistances, this));
				}
				return result;
			}
			set
			{
				this.MaxDistances.CopyAssign(value);
			}
		}

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06003F61 RID: 16225 RVA: 0x0005F354 File Offset: 0x0005D554
		// (set) Token: 0x06003F62 RID: 16226 RVA: 0x0005F38D File Offset: 0x0005D58D
		public TArray<float> BackstopDistances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BackstopDistances) == null)
				{
					result = (this._BackstopDistances = new TArray<float>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataNv_Legacy.__PropertyOffset_BackstopDistances, this));
				}
				return result;
			}
			set
			{
				this.BackstopDistances.CopyAssign(value);
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06003F63 RID: 16227 RVA: 0x0005F39C File Offset: 0x0005D59C
		// (set) Token: 0x06003F64 RID: 16228 RVA: 0x0005F3D5 File Offset: 0x0005D5D5
		public TArray<float> BackstopRadiuses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BackstopRadiuses) == null)
				{
					result = (this._BackstopRadiuses = new TArray<float>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataNv_Legacy.__PropertyOffset_BackstopRadiuses, this));
				}
				return result;
			}
			set
			{
				this.BackstopRadiuses.CopyAssign(value);
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06003F65 RID: 16229 RVA: 0x0005F3E4 File Offset: 0x0005D5E4
		// (set) Token: 0x06003F66 RID: 16230 RVA: 0x0005F41D File Offset: 0x0005D61D
		public TArray<float> AnimDriveMultipliers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._AnimDriveMultipliers) == null)
				{
					result = (this._AnimDriveMultipliers = new TArray<float>(base.NativePtr + (IntPtr)UClothPhysicalMeshDataNv_Legacy.__PropertyOffset_AnimDriveMultipliers, this));
				}
				return result;
			}
			set
			{
				this.AnimDriveMultipliers.CopyAssign(value);
			}
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x0005F42B File Offset: 0x0005D62B
		static UClothPhysicalMeshDataNv_Legacy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeNv.ClothPhysicalMeshDataNv_Legacy");
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x0005F439 File Offset: 0x0005D639
		protected UClothPhysicalMeshDataNv_Legacy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001DEB RID: 7659
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeNv.ClothPhysicalMeshDataNv_Legacy";

		// Token: 0x04001DEC RID: 7660
		private static IntPtr _ClassPtr;

		// Token: 0x04001DED RID: 7661
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001DEE RID: 7662
		internal static int __PropertyOffset_MaxDistances;

		// Token: 0x04001DEF RID: 7663
		[Nullable(2)]
		private TArray<float> _MaxDistances;

		// Token: 0x04001DF0 RID: 7664
		internal static int __PropertyOffset_BackstopDistances;

		// Token: 0x04001DF1 RID: 7665
		[Nullable(2)]
		private TArray<float> _BackstopDistances;

		// Token: 0x04001DF2 RID: 7666
		internal static int __PropertyOffset_BackstopRadiuses;

		// Token: 0x04001DF3 RID: 7667
		[Nullable(2)]
		private TArray<float> _BackstopRadiuses;

		// Token: 0x04001DF4 RID: 7668
		internal static int __PropertyOffset_AnimDriveMultipliers;

		// Token: 0x04001DF5 RID: 7669
		[Nullable(2)]
		private TArray<float> _AnimDriveMultipliers;
	}
}
