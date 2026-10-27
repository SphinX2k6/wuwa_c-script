using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012CB RID: 4811
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.FoliageType_InstancedStaticMesh")]
	[UnrealStructLayout(2504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2504)]
	public class UFoliageType_InstancedStaticMesh : UFoliageType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011A79 RID: 72313 RVA: 0x0019E9AA File Offset: 0x0019CBAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFoliageType_InstancedStaticMesh._ClassPtr;
		}

		// Token: 0x06011A7A RID: 72314 RVA: 0x0019E9B8 File Offset: 0x0019CBB8
		public UFoliageType_InstancedStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UFoliageType_InstancedStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011A7B RID: 72315 RVA: 0x0019E9E0 File Offset: 0x0019CBE0
		public UFoliageType_InstancedStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFoliageType_InstancedStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004519 RID: 17689
		// (get) Token: 0x06011A7C RID: 72316 RVA: 0x0019EA13 File Offset: 0x0019CC13
		// (set) Token: 0x06011A7D RID: 72317 RVA: 0x0019EA27 File Offset: 0x0019CC27
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

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x06011A7E RID: 72318 RVA: 0x0019EA3C File Offset: 0x0019CC3C
		// (set) Token: 0x06011A7F RID: 72319 RVA: 0x0019EA75 File Offset: 0x0019CC75
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

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x06011A80 RID: 72320 RVA: 0x0019EA83 File Offset: 0x0019CC83
		// (set) Token: 0x06011A81 RID: 72321 RVA: 0x0019EA97 File Offset: 0x0019CC97
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UFoliageInstancedStaticMeshComponent> ComponentClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UFoliageType_InstancedStaticMesh.__PropertyOffset_ComponentClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UFoliageType_InstancedStaticMesh.__PropertyOffset_ComponentClass) = value;
			}
		}

		// Token: 0x06011A82 RID: 72322 RVA: 0x0019EAAC File Offset: 0x0019CCAC
		static UFoliageType_InstancedStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.FoliageType_InstancedStaticMesh");
		}

		// Token: 0x06011A83 RID: 72323 RVA: 0x0019EABA File Offset: 0x0019CCBA
		protected UFoliageType_InstancedStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009783 RID: 38787
		public new const string __ObjectPath = "/Script/Foliage.FoliageType_InstancedStaticMesh";

		// Token: 0x04009784 RID: 38788
		private static IntPtr _ClassPtr;

		// Token: 0x04009785 RID: 38789
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009786 RID: 38790
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04009787 RID: 38791
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x04009788 RID: 38792
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;

		// Token: 0x04009789 RID: 38793
		internal static int __PropertyOffset_ComponentClass;
	}
}
