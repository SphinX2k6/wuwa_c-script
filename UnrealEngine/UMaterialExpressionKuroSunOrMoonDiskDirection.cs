using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE2 RID: 3554
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroSunOrMoonDiskDirection")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionKuroSunOrMoonDiskDirection : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C060 RID: 49248 RVA: 0x00114616 File Offset: 0x00112816
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroSunOrMoonDiskDirection._ClassPtr;
		}

		// Token: 0x0600C061 RID: 49249 RVA: 0x00114624 File Offset: 0x00112824
		public UMaterialExpressionKuroSunOrMoonDiskDirection() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroSunOrMoonDiskDirection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C062 RID: 49250 RVA: 0x0011464C File Offset: 0x0011284C
		[NullableContext(1)]
		public UMaterialExpressionKuroSunOrMoonDiskDirection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroSunOrMoonDiskDirection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C063 RID: 49251 RVA: 0x0011467F File Offset: 0x0011287F
		static UMaterialExpressionKuroSunOrMoonDiskDirection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroSunOrMoonDiskDirection");
		}

		// Token: 0x0600C064 RID: 49252 RVA: 0x0011468D File Offset: 0x0011288D
		protected UMaterialExpressionKuroSunOrMoonDiskDirection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006607 RID: 26119
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroSunOrMoonDiskDirection";

		// Token: 0x04006608 RID: 26120
		private static IntPtr _ClassPtr;

		// Token: 0x04006609 RID: 26121
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
