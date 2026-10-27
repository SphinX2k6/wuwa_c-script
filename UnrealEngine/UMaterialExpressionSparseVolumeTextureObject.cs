using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E4D RID: 3661
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSparseVolumeTextureObject")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionSparseVolumeTextureObject : UMaterialExpressionSparseVolumeTextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C464 RID: 50276 RVA: 0x0011BF9D File Offset: 0x0011A19D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSparseVolumeTextureObject._ClassPtr;
		}

		// Token: 0x0600C465 RID: 50277 RVA: 0x0011BFAC File Offset: 0x0011A1AC
		public UMaterialExpressionSparseVolumeTextureObject() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C466 RID: 50278 RVA: 0x0011BFD4 File Offset: 0x0011A1D4
		[NullableContext(1)]
		public UMaterialExpressionSparseVolumeTextureObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C467 RID: 50279 RVA: 0x0011C007 File Offset: 0x0011A207
		static UMaterialExpressionSparseVolumeTextureObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSparseVolumeTextureObject");
		}

		// Token: 0x0600C468 RID: 50280 RVA: 0x0011C015 File Offset: 0x0011A215
		protected UMaterialExpressionSparseVolumeTextureObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068DF RID: 26847
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSparseVolumeTextureObject";

		// Token: 0x040068E0 RID: 26848
		private static IntPtr _ClassPtr;

		// Token: 0x040068E1 RID: 26849
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
