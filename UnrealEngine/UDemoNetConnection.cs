using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009B1 RID: 2481
	[UnrealObjectPath("/Script/Engine.DemoNetConnection")]
	[UnrealStructLayout(7144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7144)]
	public class UDemoNetConnection : UNetConnection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C52 RID: 35922 RVA: 0x000C8D34 File Offset: 0x000C6F34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDemoNetConnection._ClassPtr;
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x000C8D40 File Offset: 0x000C6F40
		public UDemoNetConnection() : this(BuiltinUtils.AllocNativeUObject(UDemoNetConnection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x000C8D68 File Offset: 0x000C6F68
		[NullableContext(1)]
		public UDemoNetConnection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDemoNetConnection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x000C8D9B File Offset: 0x000C6F9B
		static UDemoNetConnection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DemoNetConnection");
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x000C8DA9 File Offset: 0x000C6FA9
		protected UDemoNetConnection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004299 RID: 17049
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DemoNetConnection";

		// Token: 0x0400429A RID: 17050
		private static IntPtr _ClassPtr;

		// Token: 0x0400429B RID: 17051
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
