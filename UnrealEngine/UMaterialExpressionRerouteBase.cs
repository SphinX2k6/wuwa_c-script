using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E29 RID: 3625
	[UnrealObjectPath("/Script/Engine.MaterialExpressionRerouteBase")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class UMaterialExpressionRerouteBase : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2EE RID: 49902 RVA: 0x00119401 File Offset: 0x00117601
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionRerouteBase._ClassPtr;
		}

		// Token: 0x0600C2EF RID: 49903 RVA: 0x0011940D File Offset: 0x0011760D
		static UMaterialExpressionRerouteBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionRerouteBase");
		}

		// Token: 0x0600C2F0 RID: 49904 RVA: 0x0011941C File Offset: 0x0011761C
		protected UMaterialExpressionRerouteBase() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionRerouteBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2F1 RID: 49905 RVA: 0x00119444 File Offset: 0x00117644
		protected UMaterialExpressionRerouteBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067D8 RID: 26584
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionRerouteBase";

		// Token: 0x040067D9 RID: 26585
		private static IntPtr _ClassPtr;

		// Token: 0x040067DA RID: 26586
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
