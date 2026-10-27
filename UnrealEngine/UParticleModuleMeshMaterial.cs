using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F85 RID: 3973
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleMeshMaterial")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UParticleModuleMeshMaterial : UParticleModuleMaterialBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D626 RID: 54822 RVA: 0x0013B431 File Offset: 0x00139631
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleMeshMaterial._ClassPtr;
		}

		// Token: 0x0600D627 RID: 54823 RVA: 0x0013B440 File Offset: 0x00139640
		public UParticleModuleMeshMaterial() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshMaterial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D628 RID: 54824 RVA: 0x0013B468 File Offset: 0x00139668
		public UParticleModuleMeshMaterial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleMeshMaterial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600D629 RID: 54825 RVA: 0x0013B49C File Offset: 0x0013969C
		// (set) Token: 0x0600D62A RID: 54826 RVA: 0x0013B4D5 File Offset: 0x001396D5
		public TArray<UMaterialInterface> MeshMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._MeshMaterials) == null)
				{
					result = (this._MeshMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UParticleModuleMeshMaterial.__PropertyOffset_MeshMaterials, this));
				}
				return result;
			}
			set
			{
				this.MeshMaterials.CopyAssign(value);
			}
		}

		// Token: 0x0600D62B RID: 54827 RVA: 0x0013B4E3 File Offset: 0x001396E3
		static UParticleModuleMeshMaterial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleMeshMaterial");
		}

		// Token: 0x0600D62C RID: 54828 RVA: 0x0013B4F1 File Offset: 0x001396F1
		protected UParticleModuleMeshMaterial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400739C RID: 29596
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleMeshMaterial";

		// Token: 0x0400739D RID: 29597
		private static IntPtr _ClassPtr;

		// Token: 0x0400739E RID: 29598
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400739F RID: 29599
		internal static int __PropertyOffset_MeshMaterials;

		// Token: 0x040073A0 RID: 29600
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _MeshMaterials;
	}
}
