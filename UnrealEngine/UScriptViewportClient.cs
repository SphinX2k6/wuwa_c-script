using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200027A RID: 634
	[UnrealObjectPath("/Script/Engine.ScriptViewportClient")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UScriptViewportClient : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x0005E217 File Offset: 0x0005C417
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScriptViewportClient._ClassPtr;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x0005E224 File Offset: 0x0005C424
		public UScriptViewportClient() : this(BuiltinUtils.AllocNativeUObject(UScriptViewportClient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x0005E24C File Offset: 0x0005C44C
		[NullableContext(1)]
		public UScriptViewportClient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScriptViewportClient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x0005E27F File Offset: 0x0005C47F
		static UScriptViewportClient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ScriptViewportClient");
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x0005E28D File Offset: 0x0005C48D
		protected UScriptViewportClient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040019BA RID: 6586
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ScriptViewportClient";

		// Token: 0x040019BB RID: 6587
		private static IntPtr _ClassPtr;

		// Token: 0x040019BC RID: 6588
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
