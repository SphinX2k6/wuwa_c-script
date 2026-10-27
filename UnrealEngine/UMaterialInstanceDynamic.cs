using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E8D RID: 3725
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialInstanceDynamic")]
	[UnrealStructLayout(1944, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1944)]
	public class UMaterialInstanceDynamic : UMaterialInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C847 RID: 51271 RVA: 0x00123920 File Offset: 0x00121B20
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInstanceDynamic._ClassPtr;
		}

		// Token: 0x0600C848 RID: 51272 RVA: 0x0012392C File Offset: 0x00121B2C
		public UMaterialInstanceDynamic() : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C849 RID: 51273 RVA: 0x00123954 File Offset: 0x00121B54
		[NullableContext(1)]
		public UMaterialInstanceDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C84A RID: 51274 RVA: 0x00123987 File Offset: 0x00121B87
		public void SetVectorParameterValueByInfo(in FMaterialParameterInfo ParameterInfo, FLinearColor Value)
		{
			UMaterialInstanceDynamic.__SetVectorParameterValueByInfo_Internal(base.NativePtr, (ParameterInfo ?? new FMaterialParameterInfo()).NativePtr, Value);
		}

		// Token: 0x0600C84B RID: 51275 RVA: 0x001239A5 File Offset: 0x00121BA5
		public void SetVectorParameterValue(FName ParameterName, FLinearColor Value)
		{
			UMaterialInstanceDynamic.__SetVectorParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x0600C84C RID: 51276 RVA: 0x001239B4 File Offset: 0x00121BB4
		public void SetTextureParameterValueByInfo(in FMaterialParameterInfo ParameterInfo, UTexture Value)
		{
			UMaterialInstanceDynamic.__SetTextureParameterValueByInfo_Internal(base.NativePtr, (ParameterInfo ?? new FMaterialParameterInfo()).NativePtr, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600C84D RID: 51277 RVA: 0x001239E1 File Offset: 0x00121BE1
		public void SetTextureParameterValue(FName ParameterName, UTexture Value)
		{
			UMaterialInstanceDynamic.__SetTextureParameterValue_Internal(base.NativePtr, ParameterName, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600C84E RID: 51278 RVA: 0x001239FF File Offset: 0x00121BFF
		public void SetSparseVolumeTextureParameterValue(FName ParameterName, USparseVolumeTexture Value)
		{
			UMaterialInstanceDynamic.__SetSparseVolumeTextureParameterValue_Internal(base.NativePtr, ParameterName, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600C84F RID: 51279 RVA: 0x00123A1D File Offset: 0x00121C1D
		public void SetScalarParameterValueByInfo(in FMaterialParameterInfo ParameterInfo, float Value)
		{
			UMaterialInstanceDynamic.__SetScalarParameterValueByInfo_Internal(base.NativePtr, (ParameterInfo ?? new FMaterialParameterInfo()).NativePtr, Value);
		}

		// Token: 0x0600C850 RID: 51280 RVA: 0x00123A3B File Offset: 0x00121C3B
		public void SetScalarParameterValue(FName ParameterName, float Value)
		{
			UMaterialInstanceDynamic.__SetScalarParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x0600C851 RID: 51281 RVA: 0x00123A4A File Offset: 0x00121C4A
		public void K2_InterpolateMaterialInstanceParams(UMaterialInstance SourceA, UMaterialInstance SourceB, float Alpha)
		{
			UMaterialInstanceDynamic.__K2_InterpolateMaterialInstanceParams_Internal(base.NativePtr, (SourceA != null) ? SourceA.NativePtr : IntPtr.Zero, (SourceB != null) ? SourceB.NativePtr : IntPtr.Zero, Alpha);
		}

		// Token: 0x0600C852 RID: 51282 RVA: 0x00123A78 File Offset: 0x00121C78
		public FLinearColor K2_GetVectorParameterValueByInfo(in FMaterialParameterInfo ParameterInfo)
		{
			return UMaterialInstanceDynamic.__K2_GetVectorParameterValueByInfo_Internal(base.NativePtr, (ParameterInfo ?? new FMaterialParameterInfo()).NativePtr);
		}

		// Token: 0x0600C853 RID: 51283 RVA: 0x00123A95 File Offset: 0x00121C95
		public FLinearColor K2_GetVectorParameterValue(FName ParameterName)
		{
			return UMaterialInstanceDynamic.__K2_GetVectorParameterValue_Internal(base.NativePtr, ParameterName);
		}

		// Token: 0x0600C854 RID: 51284 RVA: 0x00123AA3 File Offset: 0x00121CA3
		public UTexture K2_GetTextureParameterValueByInfo(in FMaterialParameterInfo ParameterInfo)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UMaterialInstanceDynamic.__K2_GetTextureParameterValueByInfo_Internal(base.NativePtr, (ParameterInfo ?? new FMaterialParameterInfo()).NativePtr));
		}

		// Token: 0x0600C855 RID: 51285 RVA: 0x00123AC5 File Offset: 0x00121CC5
		public UTexture K2_GetTextureParameterValue(FName ParameterName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UMaterialInstanceDynamic.__K2_GetTextureParameterValue_Internal(base.NativePtr, ParameterName));
		}

		// Token: 0x0600C856 RID: 51286 RVA: 0x00123AD8 File Offset: 0x00121CD8
		public float K2_GetScalarParameterValueByInfo(in FMaterialParameterInfo ParameterInfo)
		{
			return UMaterialInstanceDynamic.__K2_GetScalarParameterValueByInfo_Internal(base.NativePtr, (ParameterInfo ?? new FMaterialParameterInfo()).NativePtr);
		}

		// Token: 0x0600C857 RID: 51287 RVA: 0x00123AF5 File Offset: 0x00121CF5
		public float K2_GetScalarParameterValue(FName ParameterName)
		{
			return UMaterialInstanceDynamic.__K2_GetScalarParameterValue_Internal(base.NativePtr, ParameterName);
		}

		// Token: 0x0600C858 RID: 51288 RVA: 0x00123B03 File Offset: 0x00121D03
		public void K2_CopyMaterialInstanceParameters(UMaterialInterface Source, bool bQuickParametersOnly = false)
		{
			UMaterialInstanceDynamic.__K2_CopyMaterialInstanceParameters_Internal(base.NativePtr, (Source != null) ? Source.NativePtr : IntPtr.Zero, bQuickParametersOnly);
		}

		// Token: 0x0600C859 RID: 51289 RVA: 0x00123B21 File Offset: 0x00121D21
		public void CopyParameterOverrides(UMaterialInstance MaterialInstance)
		{
			UMaterialInstanceDynamic.__CopyParameterOverrides_Internal(base.NativePtr, (MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600C85A RID: 51290 RVA: 0x00123B3E File Offset: 0x00121D3E
		public void CopyInterpParameters(UMaterialInstance Source)
		{
			UMaterialInstanceDynamic.__CopyInterpParameters_Internal(base.NativePtr, (Source != null) ? Source.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600C85B RID: 51291 RVA: 0x00123B5B File Offset: 0x00121D5B
		public void BatchSetParameters(in TMap<FName, float> ScalarParameters, in TMap<FName, FLinearColor> VectorParameters, [Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FName, UTexture> TextureParameters, bool bReset)
		{
			UMaterialInstanceDynamic.__BatchSetParameters_Internal(base.NativePtr, (ScalarParameters ?? new TMap<FName, float>()).NativeMapPtr, (VectorParameters ?? new TMap<FName, FLinearColor>()).NativeMapPtr, (TextureParameters ?? new TMap<FName, UTexture>()).NativeMapPtr, bReset);
		}

		// Token: 0x0600C85C RID: 51292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValueByInfo_Internal(IntPtr @this, IntPtr ParameterInfo, FLinearColor Value);

		// Token: 0x0600C85D RID: 51293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValue_Internal(IntPtr @this, FName ParameterName, FLinearColor Value);

		// Token: 0x0600C85E RID: 51294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureParameterValueByInfo_Internal(IntPtr @this, IntPtr ParameterInfo, IntPtr Value);

		// Token: 0x0600C85F RID: 51295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureParameterValue_Internal(IntPtr @this, FName ParameterName, IntPtr Value);

		// Token: 0x0600C860 RID: 51296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSparseVolumeTextureParameterValue_Internal(IntPtr @this, FName ParameterName, IntPtr Value);

		// Token: 0x0600C861 RID: 51297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScalarParameterValueByInfo_Internal(IntPtr @this, IntPtr ParameterInfo, float Value);

		// Token: 0x0600C862 RID: 51298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScalarParameterValue_Internal(IntPtr @this, FName ParameterName, float Value);

		// Token: 0x0600C863 RID: 51299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_InterpolateMaterialInstanceParams_Internal(IntPtr @this, IntPtr SourceA, IntPtr SourceB, float Alpha);

		// Token: 0x0600C864 RID: 51300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __K2_GetVectorParameterValueByInfo_Internal(IntPtr @this, IntPtr ParameterInfo);

		// Token: 0x0600C865 RID: 51301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __K2_GetVectorParameterValue_Internal(IntPtr @this, FName ParameterName);

		// Token: 0x0600C866 RID: 51302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetTextureParameterValueByInfo_Internal(IntPtr @this, IntPtr ParameterInfo);

		// Token: 0x0600C867 RID: 51303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetTextureParameterValue_Internal(IntPtr @this, FName ParameterName);

		// Token: 0x0600C868 RID: 51304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetScalarParameterValueByInfo_Internal(IntPtr @this, IntPtr ParameterInfo);

		// Token: 0x0600C869 RID: 51305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetScalarParameterValue_Internal(IntPtr @this, FName ParameterName);

		// Token: 0x0600C86A RID: 51306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_CopyMaterialInstanceParameters_Internal(IntPtr @this, IntPtr Source, bool bQuickParametersOnly);

		// Token: 0x0600C86B RID: 51307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyParameterOverrides_Internal(IntPtr @this, IntPtr MaterialInstance);

		// Token: 0x0600C86C RID: 51308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyInterpParameters_Internal(IntPtr @this, IntPtr Source);

		// Token: 0x0600C86D RID: 51309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BatchSetParameters_Internal(IntPtr @this, IntPtr ScalarParameters, IntPtr VectorParameters, IntPtr TextureParameters, bool bReset);

		// Token: 0x0600C86E RID: 51310 RVA: 0x00123B9A File Offset: 0x00121D9A
		static UMaterialInstanceDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInstanceDynamic");
		}

		// Token: 0x0600C86F RID: 51311 RVA: 0x00123BA8 File Offset: 0x00121DA8
		protected UMaterialInstanceDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006BD4 RID: 27604
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialInstanceDynamic";

		// Token: 0x04006BD5 RID: 27605
		private static IntPtr _ClassPtr;

		// Token: 0x04006BD6 RID: 27606
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
