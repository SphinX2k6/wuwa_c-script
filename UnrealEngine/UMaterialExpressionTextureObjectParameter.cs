using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E62 RID: 3682
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureObjectParameter")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UMaterialExpressionTextureObjectParameter : UMaterialExpressionTextureSampleParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C540 RID: 50496 RVA: 0x0011D8B6 File Offset: 0x0011BAB6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureObjectParameter._ClassPtr;
		}

		// Token: 0x0600C541 RID: 50497 RVA: 0x0011D8C4 File Offset: 0x0011BAC4
		public UMaterialExpressionTextureObjectParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureObjectParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C542 RID: 50498 RVA: 0x0011D8EC File Offset: 0x0011BAEC
		[NullableContext(1)]
		public UMaterialExpressionTextureObjectParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureObjectParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C543 RID: 50499 RVA: 0x0011D91F File Offset: 0x0011BB1F
		static UMaterialExpressionTextureObjectParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureObjectParameter");
		}

		// Token: 0x0600C544 RID: 50500 RVA: 0x0011D92D File Offset: 0x0011BB2D
		protected UMaterialExpressionTextureObjectParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400697A RID: 27002
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureObjectParameter";

		// Token: 0x0400697B RID: 27003
		private static IntPtr _ClassPtr;

		// Token: 0x0400697C RID: 27004
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
