using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DEC RID: 3564
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLightmapUVs")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionLightmapUVs : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0D4 RID: 49364 RVA: 0x00115515 File Offset: 0x00113715
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLightmapUVs._ClassPtr;
		}

		// Token: 0x0600C0D5 RID: 49365 RVA: 0x00115524 File Offset: 0x00113724
		public UMaterialExpressionLightmapUVs() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLightmapUVs.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0D6 RID: 49366 RVA: 0x0011554C File Offset: 0x0011374C
		[NullableContext(1)]
		public UMaterialExpressionLightmapUVs(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLightmapUVs.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x0011557F File Offset: 0x0011377F
		static UMaterialExpressionLightmapUVs()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLightmapUVs");
		}

		// Token: 0x0600C0D8 RID: 49368 RVA: 0x0011558D File Offset: 0x0011378D
		protected UMaterialExpressionLightmapUVs(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400665E RID: 26206
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLightmapUVs";

		// Token: 0x0400665F RID: 26207
		private static IntPtr _ClassPtr;

		// Token: 0x04006660 RID: 26208
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
