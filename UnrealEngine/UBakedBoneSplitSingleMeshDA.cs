using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000894 RID: 2196
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBoneSplitSingleMeshDA")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UBakedBoneSplitSingleMeshDA : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007811 RID: 30737 RVA: 0x000ABEDF File Offset: 0x000AA0DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBoneSplitSingleMeshDA._ClassPtr;
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x000ABEEC File Offset: 0x000AA0EC
		public UBakedBoneSplitSingleMeshDA() : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitSingleMeshDA.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x000ABF14 File Offset: 0x000AA114
		public UBakedBoneSplitSingleMeshDA(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBoneSplitSingleMeshDA.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06007814 RID: 30740 RVA: 0x000ABF47 File Offset: 0x000AA147
		// (set) Token: 0x06007815 RID: 30741 RVA: 0x000ABF5B File Offset: 0x000AA15B
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneSplitSingleMeshDA.__PropertyOffset_Mesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBakedBoneSplitSingleMeshDA.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06007816 RID: 30742 RVA: 0x000ABF70 File Offset: 0x000AA170
		// (set) Token: 0x06007817 RID: 30743 RVA: 0x000ABFA9 File Offset: 0x000AA1A9
		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UBakedBoneSplitSingleMeshDA.__PropertyOffset_OverrideMaterials, this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x000ABFB7 File Offset: 0x000AA1B7
		static UBakedBoneSplitSingleMeshDA()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBoneSplitSingleMeshDA");
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x000ABFC5 File Offset: 0x000AA1C5
		protected UBakedBoneSplitSingleMeshDA(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039A8 RID: 14760
		public new const string __ObjectPath = "/Script/Engine.BakedBoneSplitSingleMeshDA";

		// Token: 0x040039A9 RID: 14761
		private static IntPtr _ClassPtr;

		// Token: 0x040039AA RID: 14762
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039AB RID: 14763
		internal static int __PropertyOffset_Mesh;

		// Token: 0x040039AC RID: 14764
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x040039AD RID: 14765
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;
	}
}
