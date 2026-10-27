using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015BB RID: 5563
	[UnrealObjectPath("/Script/JsEnv.TypeScriptBlueprint")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class UTypeScriptBlueprint : UBlueprint, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014135 RID: 82229 RVA: 0x001D772E File Offset: 0x001D592E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTypeScriptBlueprint._ClassPtr;
		}

		// Token: 0x06014136 RID: 82230 RVA: 0x001D773C File Offset: 0x001D593C
		public UTypeScriptBlueprint() : this(BuiltinUtils.AllocNativeUObject(UTypeScriptBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014137 RID: 82231 RVA: 0x001D7764 File Offset: 0x001D5964
		[NullableContext(1)]
		public UTypeScriptBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTypeScriptBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014138 RID: 82232 RVA: 0x001D7797 File Offset: 0x001D5997
		static UTypeScriptBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.TypeScriptBlueprint");
		}

		// Token: 0x06014139 RID: 82233 RVA: 0x001D77A5 File Offset: 0x001D59A5
		protected UTypeScriptBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AE9E RID: 44702
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsEnv.TypeScriptBlueprint";

		// Token: 0x0400AE9F RID: 44703
		private static IntPtr _ClassPtr;

		// Token: 0x0400AEA0 RID: 44704
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
