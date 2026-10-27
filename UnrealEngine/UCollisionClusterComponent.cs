using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001744 RID: 5956
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCollision.CollisionClusterComponent")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UCollisionClusterComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060156DA RID: 87770 RVA: 0x001F7D14 File Offset: 0x001F5F14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCollisionClusterComponent._ClassPtr;
		}

		// Token: 0x060156DB RID: 87771 RVA: 0x001F7D20 File Offset: 0x001F5F20
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return UCollisionClusterComponent.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x060156DC RID: 87772 RVA: 0x001F7D28 File Offset: 0x001F5F28
		public UCollisionClusterComponent() : this(BuiltinUtils.AllocNativeUObject(UCollisionClusterComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060156DD RID: 87773 RVA: 0x001F7D50 File Offset: 0x001F5F50
		public UCollisionClusterComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCollisionClusterComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700549C RID: 21660
		// (get) Token: 0x060156DE RID: 87774 RVA: 0x001F7D84 File Offset: 0x001F5F84
		// (set) Token: 0x060156DF RID: 87775 RVA: 0x001F7DBD File Offset: 0x001F5FBD
		public TArray<FSoftObjectPath> StaticMeshPathNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._StaticMeshPathNames) == null)
				{
					result = (this._StaticMeshPathNames = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_StaticMeshPathNames, this));
				}
				return result;
			}
			set
			{
				this.StaticMeshPathNames.CopyAssign(value);
			}
		}

		// Token: 0x1700549D RID: 21661
		// (get) Token: 0x060156E0 RID: 87776 RVA: 0x001F7DCC File Offset: 0x001F5FCC
		// (set) Token: 0x060156E1 RID: 87777 RVA: 0x001F7E05 File Offset: 0x001F6005
		public TArray<UPhysicalMaterial> PhysicalMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPhysicalMaterial> result;
				if ((result = this._PhysicalMaterials) == null)
				{
					result = (this._PhysicalMaterials = new TArray<UPhysicalMaterial>(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_PhysicalMaterials, this));
				}
				return result;
			}
			set
			{
				this.PhysicalMaterials.CopyAssign(value);
			}
		}

		// Token: 0x1700549E RID: 21662
		// (get) Token: 0x060156E2 RID: 87778 RVA: 0x001F7E14 File Offset: 0x001F6014
		// (set) Token: 0x060156E3 RID: 87779 RVA: 0x001F7E4D File Offset: 0x001F604D
		public TArray<FKAggregateGeom> AggGeometries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKAggregateGeom> result;
				if ((result = this._AggGeometries) == null)
				{
					result = (this._AggGeometries = new TArray<FKAggregateGeom>(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_AggGeometries, this));
				}
				return result;
			}
			set
			{
				this.AggGeometries.CopyAssign(value);
			}
		}

		// Token: 0x1700549F RID: 21663
		// (get) Token: 0x060156E4 RID: 87780 RVA: 0x001F7E5C File Offset: 0x001F605C
		// (set) Token: 0x060156E5 RID: 87781 RVA: 0x001F7E95 File Offset: 0x001F6095
		public TArray<UBodySetup> BodySetups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBodySetup> result;
				if ((result = this._BodySetups) == null)
				{
					result = (this._BodySetups = new TArray<UBodySetup>(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_BodySetups, this));
				}
				return result;
			}
			set
			{
				this.BodySetups.CopyAssign(value);
			}
		}

		// Token: 0x170054A0 RID: 21664
		// (get) Token: 0x060156E6 RID: 87782 RVA: 0x001F7EA4 File Offset: 0x001F60A4
		// (set) Token: 0x060156E7 RID: 87783 RVA: 0x001F7EDD File Offset: 0x001F60DD
		public TArray<UBodySetup> StandaloneBodySetups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UBodySetup> result;
				if ((result = this._StandaloneBodySetups) == null)
				{
					result = (this._StandaloneBodySetups = new TArray<UBodySetup>(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_StandaloneBodySetups, this));
				}
				return result;
			}
			set
			{
				this.StandaloneBodySetups.CopyAssign(value);
			}
		}

		// Token: 0x170054A1 RID: 21665
		// (get) Token: 0x060156E8 RID: 87784 RVA: 0x001F7EEC File Offset: 0x001F60EC
		// (set) Token: 0x060156E9 RID: 87785 RVA: 0x001F7F25 File Offset: 0x001F6125
		public TArray<int> BodySetupComplexPhysicalMaterialNums
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._BodySetupComplexPhysicalMaterialNums) == null)
				{
					result = (this._BodySetupComplexPhysicalMaterialNums = new TArray<int>(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_BodySetupComplexPhysicalMaterialNums, this));
				}
				return result;
			}
			set
			{
				this.BodySetupComplexPhysicalMaterialNums.CopyAssign(value);
			}
		}

		// Token: 0x170054A2 RID: 21666
		// (get) Token: 0x060156EA RID: 87786 RVA: 0x001F7F33 File Offset: 0x001F6133
		// (set) Token: 0x060156EB RID: 87787 RVA: 0x001F7F47 File Offset: 0x001F6147
		public unsafe FBoxSphereBounds RelativeBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_RelativeBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCollisionClusterComponent.__PropertyOffset_RelativeBounds) = value;
			}
		}

		// Token: 0x060156EC RID: 87788 RVA: 0x001F7F5C File Offset: 0x001F615C
		static UCollisionClusterComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.CollisionClusterComponent");
		}

		// Token: 0x060156ED RID: 87789 RVA: 0x001F7F6A File Offset: 0x001F616A
		protected UCollisionClusterComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BAE8 RID: 47848
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x0400BAE9 RID: 47849
		public new const string __ObjectPath = "/Script/KuroCollision.CollisionClusterComponent";

		// Token: 0x0400BAEA RID: 47850
		private static IntPtr _ClassPtr;

		// Token: 0x0400BAEB RID: 47851
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BAEC RID: 47852
		internal static int __PropertyOffset_StaticMeshPathNames;

		// Token: 0x0400BAED RID: 47853
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _StaticMeshPathNames;

		// Token: 0x0400BAEE RID: 47854
		internal static int __PropertyOffset_PhysicalMaterials;

		// Token: 0x0400BAEF RID: 47855
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _PhysicalMaterials;

		// Token: 0x0400BAF0 RID: 47856
		internal static int __PropertyOffset_AggGeometries;

		// Token: 0x0400BAF1 RID: 47857
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKAggregateGeom> _AggGeometries;

		// Token: 0x0400BAF2 RID: 47858
		internal static int __PropertyOffset_BodySetups;

		// Token: 0x0400BAF3 RID: 47859
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _BodySetups;

		// Token: 0x0400BAF4 RID: 47860
		internal static int __PropertyOffset_StandaloneBodySetups;

		// Token: 0x0400BAF5 RID: 47861
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _StandaloneBodySetups;

		// Token: 0x0400BAF6 RID: 47862
		internal static int __PropertyOffset_BodySetupComplexPhysicalMaterialNums;

		// Token: 0x0400BAF7 RID: 47863
		[Nullable(2)]
		private TArray<int> _BodySetupComplexPhysicalMaterialNums;

		// Token: 0x0400BAF8 RID: 47864
		internal static int __PropertyOffset_RelativeBounds;
	}
}
