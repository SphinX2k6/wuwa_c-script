using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200033D RID: 829
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCollision.CollisionClusterComponent")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UCollisionClusterComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060055C9 RID: 21961 RVA: 0x00078232 File Offset: 0x00076432
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCollisionClusterComponent._ClassPtr;
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00078240 File Offset: 0x00076440
		public UCollisionClusterComponent() : this(BuiltinUtils.AllocNativeUObject(UCollisionClusterComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00078268 File Offset: 0x00076468
		public UCollisionClusterComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCollisionClusterComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x0007829C File Offset: 0x0007649C
		// (set) Token: 0x060055CD RID: 21965 RVA: 0x000782D5 File Offset: 0x000764D5
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

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x060055CE RID: 21966 RVA: 0x000782E4 File Offset: 0x000764E4
		// (set) Token: 0x060055CF RID: 21967 RVA: 0x0007831D File Offset: 0x0007651D
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

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x060055D0 RID: 21968 RVA: 0x0007832C File Offset: 0x0007652C
		// (set) Token: 0x060055D1 RID: 21969 RVA: 0x00078365 File Offset: 0x00076565
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

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x060055D2 RID: 21970 RVA: 0x00078374 File Offset: 0x00076574
		// (set) Token: 0x060055D3 RID: 21971 RVA: 0x000783AD File Offset: 0x000765AD
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

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x060055D4 RID: 21972 RVA: 0x000783BC File Offset: 0x000765BC
		// (set) Token: 0x060055D5 RID: 21973 RVA: 0x000783F5 File Offset: 0x000765F5
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

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x060055D6 RID: 21974 RVA: 0x00078403 File Offset: 0x00076603
		// (set) Token: 0x060055D7 RID: 21975 RVA: 0x00078417 File Offset: 0x00076617
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

		// Token: 0x060055D8 RID: 21976 RVA: 0x0007842C File Offset: 0x0007662C
		static UCollisionClusterComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCollision.CollisionClusterComponent");
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x0007843A File Offset: 0x0007663A
		protected UCollisionClusterComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002315 RID: 8981
		public new const string __ObjectPath = "/Script/KuroCollision.CollisionClusterComponent";

		// Token: 0x04002316 RID: 8982
		private static IntPtr _ClassPtr;

		// Token: 0x04002317 RID: 8983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002318 RID: 8984
		internal static int __PropertyOffset_StaticMeshPathNames;

		// Token: 0x04002319 RID: 8985
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _StaticMeshPathNames;

		// Token: 0x0400231A RID: 8986
		internal static int __PropertyOffset_PhysicalMaterials;

		// Token: 0x0400231B RID: 8987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPhysicalMaterial> _PhysicalMaterials;

		// Token: 0x0400231C RID: 8988
		internal static int __PropertyOffset_BodySetups;

		// Token: 0x0400231D RID: 8989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _BodySetups;

		// Token: 0x0400231E RID: 8990
		internal static int __PropertyOffset_StandaloneBodySetups;

		// Token: 0x0400231F RID: 8991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBodySetup> _StandaloneBodySetups;

		// Token: 0x04002320 RID: 8992
		internal static int __PropertyOffset_BodySetupComplexPhysicalMaterialNums;

		// Token: 0x04002321 RID: 8993
		[Nullable(2)]
		private TArray<int> _BodySetupComplexPhysicalMaterialNums;

		// Token: 0x04002322 RID: 8994
		internal static int __PropertyOffset_RelativeBounds;
	}
}
