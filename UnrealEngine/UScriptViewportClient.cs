using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010DE RID: 4318
	[UnrealObjectPath("/Script/Engine.ScriptViewportClient")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UScriptViewportClient : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F7A0 RID: 63392 RVA: 0x0016E6F8 File Offset: 0x0016C8F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScriptViewportClient._ClassPtr;
		}

		// Token: 0x0600F7A1 RID: 63393 RVA: 0x0016E704 File Offset: 0x0016C904
		public UScriptViewportClient() : this(BuiltinUtils.AllocNativeUObject(UScriptViewportClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F7A2 RID: 63394 RVA: 0x0016E72C File Offset: 0x0016C92C
		[NullableContext(1)]
		public UScriptViewportClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScriptViewportClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F7A3 RID: 63395 RVA: 0x0016E75F File Offset: 0x0016C95F
		static UScriptViewportClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ScriptViewportClient");
		}

		// Token: 0x0600F7A4 RID: 63396 RVA: 0x0016E76D File Offset: 0x0016C96D
		protected UScriptViewportClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040085CC RID: 34252
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ScriptViewportClient";

		// Token: 0x040085CD RID: 34253
		private static IntPtr _ClassPtr;

		// Token: 0x040085CE RID: 34254
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
