using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DDA RID: 3546
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroGlobalGroundHeight")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionKuroGlobalGroundHeight : UMaterialExpressionKuroGlobalHeight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C02C RID: 49196 RVA: 0x00114071 File Offset: 0x00112271
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroGlobalGroundHeight._ClassPtr;
		}

		// Token: 0x0600C02D RID: 49197 RVA: 0x00114080 File Offset: 0x00112280
		public UMaterialExpressionKuroGlobalGroundHeight() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGlobalGroundHeight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C02E RID: 49198 RVA: 0x001140A8 File Offset: 0x001122A8
		[NullableContext(1)]
		public UMaterialExpressionKuroGlobalGroundHeight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGlobalGroundHeight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C02F RID: 49199 RVA: 0x001140DB File Offset: 0x001122DB
		static UMaterialExpressionKuroGlobalGroundHeight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroGlobalGroundHeight");
		}

		// Token: 0x0600C030 RID: 49200 RVA: 0x001140E9 File Offset: 0x001122E9
		protected UMaterialExpressionKuroGlobalGroundHeight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065E5 RID: 26085
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroGlobalGroundHeight";

		// Token: 0x040065E6 RID: 26086
		private static IntPtr _ClassPtr;

		// Token: 0x040065E7 RID: 26087
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
