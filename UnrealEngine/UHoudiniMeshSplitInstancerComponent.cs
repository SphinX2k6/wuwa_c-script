using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014E2 RID: 5346
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniMeshSplitInstancerComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UHoudiniMeshSplitInstancerComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060135B1 RID: 79281 RVA: 0x001C7612 File Offset: 0x001C5812
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniMeshSplitInstancerComponent._ClassPtr;
		}

		// Token: 0x060135B2 RID: 79282 RVA: 0x001C7620 File Offset: 0x001C5820
		public UHoudiniMeshSplitInstancerComponent() : this(BuiltinUtils.AllocNativeUObject(UHoudiniMeshSplitInstancerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060135B3 RID: 79283 RVA: 0x001C7648 File Offset: 0x001C5848
		public UHoudiniMeshSplitInstancerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniMeshSplitInstancerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B73 RID: 19315
		// (get) Token: 0x060135B4 RID: 79284 RVA: 0x001C767C File Offset: 0x001C587C
		// (set) Token: 0x060135B5 RID: 79285 RVA: 0x001C76B5 File Offset: 0x001C58B5
		public TArray<UStaticMeshComponent> Instances
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._Instances) == null)
				{
					result = (this._Instances = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)UHoudiniMeshSplitInstancerComponent.__PropertyOffset_Instances, this));
				}
				return result;
			}
			set
			{
				this.Instances.CopyAssign(value);
			}
		}

		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x060135B6 RID: 79286 RVA: 0x001C76C4 File Offset: 0x001C58C4
		// (set) Token: 0x060135B7 RID: 79287 RVA: 0x001C76FD File Offset: 0x001C58FD
		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UHoudiniMeshSplitInstancerComponent.__PropertyOffset_OverrideMaterials, this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x060135B8 RID: 79288 RVA: 0x001C770B File Offset: 0x001C590B
		// (set) Token: 0x060135B9 RID: 79289 RVA: 0x001C771F File Offset: 0x001C591F
		[Nullable(2)]
		public unsafe UStaticMesh InstancedMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniMeshSplitInstancerComponent.__PropertyOffset_InstancedMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHoudiniMeshSplitInstancerComponent.__PropertyOffset_InstancedMesh, value);
			}
		}

		// Token: 0x060135BA RID: 79290 RVA: 0x001C7734 File Offset: 0x001C5934
		static UHoudiniMeshSplitInstancerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniMeshSplitInstancerComponent");
		}

		// Token: 0x060135BB RID: 79291 RVA: 0x001C7742 File Offset: 0x001C5942
		protected UHoudiniMeshSplitInstancerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A74D RID: 42829
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniMeshSplitInstancerComponent";

		// Token: 0x0400A74E RID: 42830
		private static IntPtr _ClassPtr;

		// Token: 0x0400A74F RID: 42831
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A750 RID: 42832
		internal static int __PropertyOffset_Instances;

		// Token: 0x0400A751 RID: 42833
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _Instances;

		// Token: 0x0400A752 RID: 42834
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x0400A753 RID: 42835
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;

		// Token: 0x0400A754 RID: 42836
		internal static int __PropertyOffset_InstancedMesh;
	}
}
