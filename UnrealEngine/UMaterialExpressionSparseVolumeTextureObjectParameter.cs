using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E4E RID: 3662
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSparseVolumeTextureObjectParameter")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UMaterialExpressionSparseVolumeTextureObjectParameter : UMaterialExpressionSparseVolumeTextureSampleParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C469 RID: 50281 RVA: 0x0011C01E File Offset: 0x0011A21E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSparseVolumeTextureObjectParameter._ClassPtr;
		}

		// Token: 0x0600C46A RID: 50282 RVA: 0x0011C02C File Offset: 0x0011A22C
		public UMaterialExpressionSparseVolumeTextureObjectParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureObjectParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x0011C054 File Offset: 0x0011A254
		[NullableContext(1)]
		public UMaterialExpressionSparseVolumeTextureObjectParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureObjectParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C46C RID: 50284 RVA: 0x0011C087 File Offset: 0x0011A287
		static UMaterialExpressionSparseVolumeTextureObjectParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSparseVolumeTextureObjectParameter");
		}

		// Token: 0x0600C46D RID: 50285 RVA: 0x0011C095 File Offset: 0x0011A295
		protected UMaterialExpressionSparseVolumeTextureObjectParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068E2 RID: 26850
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSparseVolumeTextureObjectParameter";

		// Token: 0x040068E3 RID: 26851
		private static IntPtr _ClassPtr;

		// Token: 0x040068E4 RID: 26852
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
