using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E5F RID: 3679
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureBase")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UMaterialExpressionTextureBase : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C526 RID: 50470 RVA: 0x0011D64B File Offset: 0x0011B84B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureBase._ClassPtr;
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0600C527 RID: 50471 RVA: 0x0011D657 File Offset: 0x0011B857
		// (set) Token: 0x0600C528 RID: 50472 RVA: 0x0011D66B File Offset: 0x0011B86B
		[Nullable(2)]
		public unsafe UTexture Texture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionTextureBase.__PropertyOffset_Texture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionTextureBase.__PropertyOffset_Texture, value);
			}
		}

		// Token: 0x0600C529 RID: 50473 RVA: 0x0011D680 File Offset: 0x0011B880
		static UMaterialExpressionTextureBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureBase");
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x0011D690 File Offset: 0x0011B890
		protected UMaterialExpressionTextureBase() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C52B RID: 50475 RVA: 0x0011D6B8 File Offset: 0x0011B8B8
		protected UMaterialExpressionTextureBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006969 RID: 26985
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureBase";

		// Token: 0x0400696A RID: 26986
		private static IntPtr _ClassPtr;

		// Token: 0x0400696B RID: 26987
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400696C RID: 26988
		internal static int __PropertyOffset_Texture;
	}
}
