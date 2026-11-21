using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B9 RID: 697
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.FoliageType_InstancedStaticMesh")]
	[UnrealStructLayout(2504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2504)]
	public class UFoliageType_InstancedStaticMesh : UFoliageType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004C4E RID: 19534 RVA: 0x0006B059 File Offset: 0x00069259
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFoliageType_InstancedStaticMesh._ClassPtr;
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x0006B068 File Offset: 0x00069268
		public UFoliageType_InstancedStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UFoliageType_InstancedStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x0006B090 File Offset: 0x00069290
		public UFoliageType_InstancedStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFoliageType_InstancedStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06004C51 RID: 19537 RVA: 0x0006B0C3 File Offset: 0x000692C3
		// (set) Token: 0x06004C52 RID: 19538 RVA: 0x0006B0D7 File Offset: 0x000692D7
		[Nullable(2)]
		public unsafe UStaticMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UFoliageType_InstancedStaticMesh.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UFoliageType_InstancedStaticMesh.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x0006B0EC File Offset: 0x000692EC
		// (set) Token: 0x06004C54 RID: 19540 RVA: 0x0006B125 File Offset: 0x00069325
		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UFoliageType_InstancedStaticMesh.__PropertyOffset_OverrideMaterials, this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x0006B133 File Offset: 0x00069333
		static UFoliageType_InstancedStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.FoliageType_InstancedStaticMesh");
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x0006B141 File Offset: 0x00069341
		protected UFoliageType_InstancedStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001E83 RID: 7811
		public new const string __ObjectPath = "/Script/Foliage.FoliageType_InstancedStaticMesh";

		// Token: 0x04001E84 RID: 7812
		private static IntPtr _ClassPtr;

		// Token: 0x04001E85 RID: 7813
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001E86 RID: 7814
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04001E87 RID: 7815
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x04001E88 RID: 7816
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;
	}
}
