using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000242 RID: 578
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MeshComponent")]
	[UnrealStructLayout(1616, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1616)]
	public abstract class UMeshComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060031B0 RID: 12720 RVA: 0x00046C96 File Offset: 0x00044E96
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMeshComponent._ClassPtr;
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x00046CA4 File Offset: 0x00044EA4
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x00046CDD File Offset: 0x00044EDD
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

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x00046CEC File Offset: 0x00044EEC
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x00046D25 File Offset: 0x00044F25
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

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x00046D33 File Offset: 0x00044F33
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x00046D4C File Offset: 0x00044F4C
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

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x00046D7C File Offset: 0x00044F7C
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x00046D95 File Offset: 0x00044F95
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

		// Token: 0x060031B9 RID: 12729 RVA: 0x00046DC5 File Offset: 0x00044FC5
		public void SetVectorParameterValueOnMaterials(FName ParameterName, FVector ParameterValue)
		{
			UMeshComponent.__SetVectorParameterValueOnMaterials_Internal(base.NativePtr, ParameterName, ParameterValue);
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x00046DD4 File Offset: 0x00044FD4
		public void SetScalarParameterValueOnMaterials(FName ParameterName, float ParameterValue)
		{
			UMeshComponent.__SetScalarParameterValueOnMaterials_Internal(base.NativePtr, ParameterName, ParameterValue);
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x00046DE3 File Offset: 0x00044FE3
		[NullableContext(2)]
		public void SetColorChangeMaterial(int ElementIndex, UMaterialInterface Material)
		{
			UMeshComponent.__SetColorChangeMaterial_Internal(base.NativePtr, ElementIndex, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x00046E01 File Offset: 0x00045001
		public void PrestreamTextures(float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups = 0)
		{
			UMeshComponent.__PrestreamTextures_Internal(base.NativePtr, Seconds, bPrioritizeCharacterTextures, CinematicTextureGroups);
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x00046E11 File Offset: 0x00045011
		public bool IsMaterialSlotNameValid(FName MaterialSlotName)
		{
			return UMeshComponent.__IsMaterialSlotNameValid_Internal(base.NativePtr, MaterialSlotName);
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x00046E1F File Offset: 0x0004501F
		public TArray<FName> GetMaterialSlotNames()
		{
			return new TArray<FName>(UMeshComponent.__GetMaterialSlotNames_Internal(base.NativePtr), null);
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x00046E32 File Offset: 0x00045032
		public TArray<UMaterialInterface> GetMaterials()
		{
			return new TArray<UMaterialInterface>(UMeshComponent.__GetMaterials_Internal(base.NativePtr), null);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x00046E45 File Offset: 0x00045045
		public int GetMaterialIndex(FName MaterialSlotName)
		{
			return UMeshComponent.__GetMaterialIndex_Internal(base.NativePtr, MaterialSlotName);
		}

		// Token: 0x060031C1 RID: 12737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValueOnMaterials_Internal(IntPtr @this, FName ParameterName, FVector ParameterValue);

		// Token: 0x060031C2 RID: 12738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScalarParameterValueOnMaterials_Internal(IntPtr @this, FName ParameterName, float ParameterValue);

		// Token: 0x060031C3 RID: 12739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorChangeMaterial_Internal(IntPtr @this, int ElementIndex, IntPtr Material);

		// Token: 0x060031C4 RID: 12740
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PrestreamTextures_Internal(IntPtr @this, float Seconds, bool bPrioritizeCharacterTextures, int CinematicTextureGroups);

		// Token: 0x060031C5 RID: 12741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMaterialSlotNameValid_Internal(IntPtr @this, FName MaterialSlotName);

		// Token: 0x060031C6 RID: 12742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialSlotNames_Internal(IntPtr @this);

		// Token: 0x060031C7 RID: 12743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterials_Internal(IntPtr @this);

		// Token: 0x060031C8 RID: 12744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaterialIndex_Internal(IntPtr @this, FName MaterialSlotName);

		// Token: 0x060031C9 RID: 12745 RVA: 0x00046E53 File Offset: 0x00045053
		static UMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MeshComponent");
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x00046E64 File Offset: 0x00045064
		protected UMeshComponent() : this(BuiltinUtils.AllocNativeUObject(UMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00046E8C File Offset: 0x0004508C
		protected UMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001121 RID: 4385
		public new const string __ObjectPath = "/Script/Engine.MeshComponent";

		// Token: 0x04001122 RID: 4386
		private static IntPtr _ClassPtr;

		// Token: 0x04001123 RID: 4387
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001124 RID: 4388
		internal static int __PropertyOffset_OverrideMaterials;

		// Token: 0x04001125 RID: 4389
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _OverrideMaterials;

		// Token: 0x04001126 RID: 4390
		internal static int __PropertyOffset_KuroColorChangeMaterials;

		// Token: 0x04001127 RID: 4391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _KuroColorChangeMaterials;

		// Token: 0x04001128 RID: 4392
		internal static int __PropertyOffset_bEnableMaterialParameterCaching;

		// Token: 0x04001129 RID: 4393
		internal static byte __PropertyMask_bEnableMaterialParameterCaching;

		// Token: 0x0400112A RID: 4394
		internal static int __PropertyOffset_bHideLogicallyOnBeginPlay;

		// Token: 0x0400112B RID: 4395
		internal static byte __PropertyMask_bHideLogicallyOnBeginPlay;
	}
}
