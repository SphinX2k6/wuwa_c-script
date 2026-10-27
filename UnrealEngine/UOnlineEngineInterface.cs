using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F18 RID: 3864
	[UnrealObjectPath("/Script/Engine.OnlineEngineInterface")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UOnlineEngineInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D0DB RID: 53467 RVA: 0x00131542 File Offset: 0x0012F742
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOnlineEngineInterface._ClassPtr;
		}

		// Token: 0x0600D0DC RID: 53468 RVA: 0x00131550 File Offset: 0x0012F750
		public UOnlineEngineInterface() : this(BuiltinUtils.AllocNativeUObject(UOnlineEngineInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D0DD RID: 53469 RVA: 0x00131578 File Offset: 0x0012F778
		[NullableContext(1)]
		public UOnlineEngineInterface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOnlineEngineInterface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600D0DE RID: 53470 RVA: 0x001315AB File Offset: 0x0012F7AB
		static UOnlineEngineInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.OnlineEngineInterface");
		}

		// Token: 0x0600D0DF RID: 53471 RVA: 0x001315B9 File Offset: 0x0012F7B9
		protected UOnlineEngineInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007057 RID: 28759
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.OnlineEngineInterface";

		// Token: 0x04007058 RID: 28760
		private static IntPtr _ClassPtr;

		// Token: 0x04007059 RID: 28761
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
