using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DDF RID: 3551
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroMainLightDirection")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionKuroMainLightDirection : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C04F RID: 49231 RVA: 0x0011443B File Offset: 0x0011263B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroMainLightDirection._ClassPtr;
		}

		// Token: 0x0600C050 RID: 49232 RVA: 0x00114448 File Offset: 0x00112648
		public UMaterialExpressionKuroMainLightDirection() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroMainLightDirection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C051 RID: 49233 RVA: 0x00114470 File Offset: 0x00112670
		[NullableContext(1)]
		public UMaterialExpressionKuroMainLightDirection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroMainLightDirection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C052 RID: 49234 RVA: 0x001144A3 File Offset: 0x001126A3
		static UMaterialExpressionKuroMainLightDirection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroMainLightDirection");
		}

		// Token: 0x0600C053 RID: 49235 RVA: 0x001144B1 File Offset: 0x001126B1
		protected UMaterialExpressionKuroMainLightDirection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065FC RID: 26108
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroMainLightDirection";

		// Token: 0x040065FD RID: 26109
		private static IntPtr _ClassPtr;

		// Token: 0x040065FE RID: 26110
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
