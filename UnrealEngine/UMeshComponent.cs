using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EA2 RID: 3746
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshComponent")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public abstract class UMeshComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CA3D RID: 51773 RVA: 0x00126882 File Offset: 0x00124A82
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshComponent._ClassPtr;
		}

		// Token: 0x17002F78 RID: 12152
		// (get) Token: 0x0600CA3E RID: 51774 RVA: 0x00126890 File Offset: 0x00124A90
		// (set) Token: 0x0600CA3F RID: 51775 RVA: 0x001268C9 File Offset: 0x00124AC9
		public TArray<UMaterialInterface> OverrideMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._OverrideMaterials) == null)
				{
					result = (this._OverrideMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_OverrideMaterials, this));
				}
				return result;
			}
			set
			{
				this.OverrideMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17002F79 RID: 12153
		// (get) Token: 0x0600CA40 RID: 51776 RVA: 0x001268D8 File Offset: 0x00124AD8
		// (set) Token: 0x0600CA41 RID: 51777 RVA: 0x00126911 File Offset: 0x00124B11
		public TArray<UMaterialInterface> KuroColorChangeMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._KuroColorChangeMaterials) == null)
				{
					result = (this._KuroColorChangeMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_KuroColorChangeMaterials, this));
				}
				return result;
			}
			set
			{
				this.KuroColorChangeMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17002F7A RID: 12154
		// (get) Token: 0x0600CA42 RID: 51778 RVA: 0x0012691F File Offset: 0x00124B1F
		// (set) Token: 0x0600CA43 RID: 51779 RVA: 0x00126938 File Offset: 0x00124B38
		public unsafe bool bEnableMaterialParameterCaching
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_bEnableMaterialParameterCaching) & UMeshComponent.__PropertyMask_bEnableMaterialParameterCaching) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_bEnableMaterialParameterCaching) = ((*(base.NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_bEnableMaterialParameterCaching) & ~UMeshComponent.__PropertyMask_bEnableMaterialParameterCaching) | (value ? UMeshComponent.__PropertyMask_bEnableMaterialParameterCaching : 0));
			}
		}

		// Token: 0x17002F7B RID: 12155
		// (get) Token: 0x0600CA44 RID: 51780 RVA: 0x00126968 File Offset: 0x00124B68
		// (set) Token: 0x0600CA45 RID: 51781 RVA: 0x00126981 File Offset: 0x00124B81
		public unsafe bool bHideLogicallyOnBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_bHideLogicallyOnBeginPlay) & UMeshComponent.__PropertyMask_bHideLogicallyOnBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_bHideLogicallyOnBeginPlay) = ((*(base.NativePtr + (IntPtr)UMeshComponent.__PropertyOffset_bHideLogicallyOnBeginPlay) & ~UMeshComponent.__PropertyMask_bHideLogicallyOnBeginPlay) | (value ? UMeshComponent.__PropertyMask_bHideLogicallyOnBeginPlay : 0));
			}
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x001269B1 File Offset: 0x00124BB1
		public void SetVectorParameterValueOnMaterials(FName ParameterName, FVector ParameterValue)
		{
			UMeshComponent.__SetVectorParameterValueOnMaterials_Internal(base.NativePtr, ParameterName, ParameterValue);
		}

		// Token: 0x0600CA47 RID: 51783 RVA: 0x001269C0 File Offset: 0x00124BC0
		public void SetScalarParameterValueOnMaterials(FName ParameterName, float ParameterValue)
		{
			UMeshComponent.__SetScalarParameterValueOnMaterials_Internal(base.NativePtr, ParameterName, ParameterValue);
		}

		// Token: 0x0600CA48 RID: 51784 RVA: 0x001269CF File Offset: 0x00124BCF
		[NullableContext(2)]
		public void SetColorChangeMaterial(int ElementIndex, UMaterialInterface Material)
		{
			UMeshComponent.__SetColorChangeMaterial_Internal(base.NativePtr, ElementIndex, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600CA49 RID: 51785 RVA: 0x001269ED File Offset: 0x00124BED
		public void PrestreamTextures(float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups = 0)
		{
			UMeshComponent.__PrestreamTextures_Internal(base.NativePtr, Seconds, bPrioritizeCharacterTextures, CinematicTextureGroups);
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x001269FD File Offset: 0x00124BFD
		public bool IsMaterialSlotNameValid(FName MaterialSlotName)
		{
			return UMeshComponent.__IsMaterialSlotNameValid_Internal(base.NativePtr, MaterialSlotName);
		}

		// Token: 0x0600CA4B RID: 51787 RVA: 0x00126A0B File Offset: 0x00124C0B
		public TArray<FName> GetMaterialSlotNames()
		{
			return new TArray<FName>(UMeshComponent.__GetMaterialSlotNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x00126A1E File Offset: 0x00124C1E
		public TArray<UMaterialInterface> GetMaterials()
		{
			return new TArray<UMaterialInterface>(UMeshComponent.__GetMaterials_Internal(base.NativePtr), null);
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x00126A31 File Offset: 0x00124C31
		public int GetMaterialIndex(FName MaterialSlotName)
		{
			return UMeshComponent.__GetMaterialIndex_Internal(base.NativePtr, MaterialSlotName);
		}

		// Token: 0x0600CA4E RID: 51790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValueOnMaterials_Internal(IntPtr @this, FName ParameterName, FVector ParameterValue);

		// Token: 0x0600CA4F RID: 51791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScalarParameterValueOnMaterials_Internal(IntPtr @this, FName ParameterName, float ParameterValue);

		// Token: 0x0600CA50 RID: 51792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorChangeMaterial_Internal(IntPtr @this, int ElementIndex, IntPtr Material);

		// Token: 0x0600CA51 RID: 51793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrestreamTextures_Internal(IntPtr @this, float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups);

		// Token: 0x0600CA52 RID: 51794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMaterialSlotNameValid_Internal(IntPtr @this, FName MaterialSlotName);

		// Token: 0x0600CA53 RID: 51795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialSlotNames_Internal(IntPtr @this);

		// Token: 0x0600CA54 RID: 51796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterials_Internal(IntPtr @this);

		// Token: 0x0600CA55 RID: 51797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaterialIndex_Internal(IntPtr @this, FName MaterialSlotName);

		// Token: 0x0600CA56 RID: 51798 RVA: 0x00126A3F File Offset: 0x00124C3F
		static UMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MeshComponent");
		}

		// Token: 0x0600CA57 RID: 51799 RVA: 0x00126A50 File Offset: 0x00124C50
		protected UMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x00126A78 File Offset: 0x00124C78
		protected UMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006CE4 RID: 27876
		public new const string __ObjectPath = "/Script/Engine.MeshComponent";

		// Token: 0x04006CE5 RID: 27877
		private static IntPtr _ClassPtr;

		// Token: 0x04006CE6 RID: 27878
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006CE7 RID: 27879
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x04006CE8 RID: 27880
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;

		// Token: 0x04006CE9 RID: 27881
		internal static int __PropertyOffset_KuroColorChangeMaterials;

		// Token: 0x04006CEA RID: 27882
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _KuroColorChangeMaterials;

		// Token: 0x04006CEB RID: 27883
		internal static int __PropertyOffset_bEnableMaterialParameterCaching;

		// Token: 0x04006CEC RID: 27884
		internal static byte __PropertyMask_bEnableMaterialParameterCaching;

		// Token: 0x04006CED RID: 27885
		internal static int __PropertyOffset_bHideLogicallyOnBeginPlay;

		// Token: 0x04006CEE RID: 27886
		internal static byte __PropertyMask_bHideLogicallyOnBeginPlay;
	}
}
