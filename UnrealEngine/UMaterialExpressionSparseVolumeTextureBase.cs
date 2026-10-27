using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E4C RID: 3660
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSparseVolumeTextureBase")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public abstract class UMaterialExpressionSparseVolumeTextureBase : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C45E RID: 50270 RVA: 0x0011BF27 File Offset: 0x0011A127
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSparseVolumeTextureBase._ClassPtr;
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x0600C45F RID: 50271 RVA: 0x0011BF33 File Offset: 0x0011A133
		// (set) Token: 0x0600C460 RID: 50272 RVA: 0x0011BF47 File Offset: 0x0011A147
		[Nullable(2)]
		public unsafe USparseVolumeTexture SparseVolumeTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USparseVolumeTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionSparseVolumeTextureBase.__PropertyOffset_SparseVolumeTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionSparseVolumeTextureBase.__PropertyOffset_SparseVolumeTexture, value);
			}
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x0011BF5C File Offset: 0x0011A15C
		static UMaterialExpressionSparseVolumeTextureBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSparseVolumeTextureBase");
		}

		// Token: 0x0600C462 RID: 50274 RVA: 0x0011BF6C File Offset: 0x0011A16C
		protected UMaterialExpressionSparseVolumeTextureBase() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSparseVolumeTextureBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C463 RID: 50275 RVA: 0x0011BF94 File Offset: 0x0011A194
		protected UMaterialExpressionSparseVolumeTextureBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068DB RID: 26843
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSparseVolumeTextureBase";

		// Token: 0x040068DC RID: 26844
		private static IntPtr _ClassPtr;

		// Token: 0x040068DD RID: 26845
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068DE RID: 26846
		internal static int __PropertyOffset_SparseVolumeTexture;
	}
}
