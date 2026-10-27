using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E61 RID: 3681
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureObject")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionTextureObject : UMaterialExpressionTextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C53B RID: 50491 RVA: 0x0011D837 File Offset: 0x0011BA37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureObject._ClassPtr;
		}

		// Token: 0x0600C53C RID: 50492 RVA: 0x0011D844 File Offset: 0x0011BA44
		public UMaterialExpressionTextureObject() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C53D RID: 50493 RVA: 0x0011D86C File Offset: 0x0011BA6C
		[NullableContext(1)]
		public UMaterialExpressionTextureObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C53E RID: 50494 RVA: 0x0011D89F File Offset: 0x0011BA9F
		static UMaterialExpressionTextureObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureObject");
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x0011D8AD File Offset: 0x0011BAAD
		protected UMaterialExpressionTextureObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006977 RID: 26999
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureObject";

		// Token: 0x04006978 RID: 27000
		private static IntPtr _ClassPtr;

		// Token: 0x04006979 RID: 27001
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
