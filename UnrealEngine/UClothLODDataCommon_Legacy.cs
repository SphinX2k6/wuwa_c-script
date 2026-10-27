using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000482 RID: 1154
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon_Legacy")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UClothLODDataCommon_Legacy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003E15 RID: 15893 RVA: 0x0005D52B File Offset: 0x0005B72B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClothLODDataCommon_Legacy._ClassPtr;
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x0005D538 File Offset: 0x0005B738
		public UClothLODDataCommon_Legacy() : this(BuiltinUtils.AllocNativeUObject(UClothLODDataCommon_Legacy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x0005D560 File Offset: 0x0005B760
		public UClothLODDataCommon_Legacy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClothLODDataCommon_Legacy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06003E18 RID: 15896 RVA: 0x0005D593 File Offset: 0x0005B793
		// (set) Token: 0x06003E19 RID: 15897 RVA: 0x0005D5A7 File Offset: 0x0005B7A7
		[Nullable(2)]
		public unsafe UClothPhysicalMeshDataBase_Legacy PhysicalMeshData_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClothPhysicalMeshDataBase_Legacy>(base.NativePtr / (IntPtr)sizeof(void*) + UClothLODDataCommon_Legacy.__PropertyOffset_PhysicalMeshData_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UClothLODDataCommon_Legacy.__PropertyOffset_PhysicalMeshData_DEPRECATED, value);
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x0005D5BC File Offset: 0x0005B7BC
		// (set) Token: 0x06003E1B RID: 15899 RVA: 0x0005D5F5 File Offset: 0x0005B7F5
		public FClothPhysicalMeshData ClothPhysicalMeshData
		{
			get
			{
				base.FastCheckIsValid();
				FClothPhysicalMeshData result;
				if ((result = this._ClothPhysicalMeshData) == null)
				{
					result = (this._ClothPhysicalMeshData = new FClothPhysicalMeshData(base.NativePtr + (IntPtr)UClothLODDataCommon_Legacy.__PropertyOffset_ClothPhysicalMeshData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothPhysicalMeshData.StaticStruct(), base.NativePtr + (IntPtr)UClothLODDataCommon_Legacy.__PropertyOffset_ClothPhysicalMeshData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06003E1C RID: 15900 RVA: 0x0005D618 File Offset: 0x0005B818
		// (set) Token: 0x06003E1D RID: 15901 RVA: 0x0005D651 File Offset: 0x0005B851
		public FClothCollisionData CollisionData
		{
			get
			{
				base.FastCheckIsValid();
				FClothCollisionData result;
				if ((result = this._CollisionData) == null)
				{
					result = (this._CollisionData = new FClothCollisionData(base.NativePtr + (IntPtr)UClothLODDataCommon_Legacy.__PropertyOffset_CollisionData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothCollisionData.StaticStruct(), base.NativePtr + (IntPtr)UClothLODDataCommon_Legacy.__PropertyOffset_CollisionData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x0005D672 File Offset: 0x0005B872
		static UClothLODDataCommon_Legacy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon_Legacy");
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x0005D680 File Offset: 0x0005B880
		protected UClothLODDataCommon_Legacy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D2E RID: 7470
		public new const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon_Legacy";

		// Token: 0x04001D2F RID: 7471
		private static IntPtr _ClassPtr;

		// Token: 0x04001D30 RID: 7472
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D31 RID: 7473
		internal static int __PropertyOffset_PhysicalMeshData_DEPRECATED;

		// Token: 0x04001D32 RID: 7474
		internal static int __PropertyOffset_ClothPhysicalMeshData;

		// Token: 0x04001D33 RID: 7475
		[Nullable(2)]
		private FClothPhysicalMeshData _ClothPhysicalMeshData;

		// Token: 0x04001D34 RID: 7476
		internal static int __PropertyOffset_CollisionData;

		// Token: 0x04001D35 RID: 7477
		[Nullable(2)]
		private FClothCollisionData _CollisionData;
	}
}
