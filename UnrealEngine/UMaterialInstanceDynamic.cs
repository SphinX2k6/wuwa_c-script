using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023C RID: 572
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialInstanceDynamic")]
	[UnrealStructLayout(1968, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1968)]
	public class UMaterialInstanceDynamic : UMaterialInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003115 RID: 12565 RVA: 0x00045F73 File Offset: 0x00044173
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialInstanceDynamic._ClassPtr;
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x00045F80 File Offset: 0x00044180
		public UMaterialInstanceDynamic() : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00045FA8 File Offset: 0x000441A8
		[NullableContext(1)]
		public UMaterialInstanceDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialInstanceDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x00045FDB File Offset: 0x000441DB
		public void SetVectorParameterValue(FName ParameterName, FLinearColor Value)
		{
			UMaterialInstanceDynamic.__SetVectorParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00045FEA File Offset: 0x000441EA
		public void SetTextureParameterValue(FName ParameterName, UTexture Value)
		{
			UMaterialInstanceDynamic.__SetTextureParameterValue_Internal(base.NativePtr, ParameterName, (Value != null) ? Value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x00046008 File Offset: 0x00044208
		public void SetScalarParameterValue(FName ParameterName, float Value)
		{
			UMaterialInstanceDynamic.__SetScalarParameterValue_Internal(base.NativePtr, ParameterName, Value);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x00046017 File Offset: 0x00044217
		public void K2_InterpolateMaterialInstanceParams(UMaterialInstance SourceA, UMaterialInstance SourceB, float Alpha)
		{
			UMaterialInstanceDynamic.__K2_InterpolateMaterialInstanceParams_Internal(base.NativePtr, (SourceA != null) ? SourceA.NativePtr : IntPtr.Zero, (SourceB != null) ? SourceB.NativePtr : IntPtr.Zero, Alpha);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00046045 File Offset: 0x00044245
		public FLinearColor K2_GetVectorParameterValue(FName ParameterName)
		{
			return UMaterialInstanceDynamic.__K2_GetVectorParameterValue_Internal(base.NativePtr, ParameterName);
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x00046053 File Offset: 0x00044253
		public UTexture K2_GetTextureParameterValue(FName ParameterName)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UMaterialInstanceDynamic.__K2_GetTextureParameterValue_Internal(base.NativePtr, ParameterName));
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x00046066 File Offset: 0x00044266
		public float K2_GetScalarParameterValue(FName ParameterName)
		{
			return UMaterialInstanceDynamic.__K2_GetScalarParameterValue_Internal(base.NativePtr, ParameterName);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x00046074 File Offset: 0x00044274
		public void K2_CopyMaterialInstanceParameters(UMaterialInterface Source, bool bQuickParametersOnly = false)
		{
			UMaterialInstanceDynamic.__K2_CopyMaterialInstanceParameters_Internal(base.NativePtr, (Source != null) ? Source.NativePtr : IntPtr.Zero, bQuickParametersOnly);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x00046092 File Offset: 0x00044292
		public void CopyParameterOverrides(UMaterialInstance MaterialInstance)
		{
			UMaterialInstanceDynamic.__CopyParameterOverrides_Internal(base.NativePtr, (MaterialInstance != null) ? MaterialInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000460AF File Offset: 0x000442AF
		public void CopyInterpParameters(UMaterialInstance Source)
		{
			UMaterialInstanceDynamic.__CopyInterpParameters_Internal(base.NativePtr, (Source != null) ? Source.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000460CC File Offset: 0x000442CC
		public void BatchSetParameters(in TMap<FName, float> ScalarParameters, in TMap<FName, FLinearColor> VectorParameters, [Nullable(new byte[]
		{
			2,
			1
		})] in TMap<FName, UTexture> TextureParameters, bool bReset)
		{
			UMaterialInstanceDynamic.__BatchSetParameters_Internal(base.NativePtr, (ScalarParameters ?? new TMap<FName, float>()).NativeMapPtr, (VectorParameters ?? new TMap<FName, FLinearColor>()).NativeMapPtr, (TextureParameters ?? new TMap<FName, UTexture>()).NativeMapPtr, bReset);
		}

		// Token: 0x06003123 RID: 12579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVectorParameterValue_Internal(IntPtr @this, FName ParameterName, FLinearColor Value);

		// Token: 0x06003124 RID: 12580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTextureParameterValue_Internal(IntPtr @this, FName ParameterName, IntPtr Value);

		// Token: 0x06003125 RID: 12581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScalarParameterValue_Internal(IntPtr @this, FName ParameterName, float Value);

		// Token: 0x06003126 RID: 12582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_InterpolateMaterialInstanceParams_Internal(IntPtr @this, IntPtr SourceA, IntPtr SourceB, float Alpha);

		// Token: 0x06003127 RID: 12583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __K2_GetVectorParameterValue_Internal(IntPtr @this, FName ParameterName);

		// Token: 0x06003128 RID: 12584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetTextureParameterValue_Internal(IntPtr @this, FName ParameterName);

		// Token: 0x06003129 RID: 12585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetScalarParameterValue_Internal(IntPtr @this, FName ParameterName);

		// Token: 0x0600312A RID: 12586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_CopyMaterialInstanceParameters_Internal(IntPtr @this, IntPtr Source, bool bQuickParametersOnly);

		// Token: 0x0600312B RID: 12587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyParameterOverrides_Internal(IntPtr @this, IntPtr MaterialInstance);

		// Token: 0x0600312C RID: 12588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CopyInterpParameters_Internal(IntPtr @this, IntPtr Source);

		// Token: 0x0600312D RID: 12589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BatchSetParameters_Internal(IntPtr @this, IntPtr ScalarParameters, IntPtr VectorParameters, IntPtr TextureParameters, bool bReset);

		// Token: 0x0600312E RID: 12590 RVA: 0x0004610B File Offset: 0x0004430B
		static UMaterialInstanceDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialInstanceDynamic");
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x00046119 File Offset: 0x00044319
		protected UMaterialInstanceDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040010D3 RID: 4307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialInstanceDynamic";

		// Token: 0x040010D4 RID: 4308
		private static IntPtr _ClassPtr;

		// Token: 0x040010D5 RID: 4309
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
