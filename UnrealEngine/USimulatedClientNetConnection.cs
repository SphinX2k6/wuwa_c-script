using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010EE RID: 4334
	[UnrealObjectPath("/Script/Engine.SimulatedClientNetConnection")]
	[UnrealStructLayout(7032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 7032)]
	public class USimulatedClientNetConnection : UNetConnection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F8A8 RID: 63656 RVA: 0x0016FC54 File Offset: 0x0016DE54
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimulatedClientNetConnection._ClassPtr;
		}

		// Token: 0x0600F8A9 RID: 63657 RVA: 0x0016FC60 File Offset: 0x0016DE60
		public USimulatedClientNetConnection() : this(BuiltinUtils.AllocNativeUObject(USimulatedClientNetConnection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F8AA RID: 63658 RVA: 0x0016FC88 File Offset: 0x0016DE88
		[NullableContext(1)]
		public USimulatedClientNetConnection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimulatedClientNetConnection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F8AB RID: 63659 RVA: 0x0016FCBB File Offset: 0x0016DEBB
		static USimulatedClientNetConnection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SimulatedClientNetConnection");
		}

		// Token: 0x0600F8AC RID: 63660 RVA: 0x0016FCC9 File Offset: 0x0016DEC9
		protected USimulatedClientNetConnection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008656 RID: 34390
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SimulatedClientNetConnection";

		// Token: 0x04008657 RID: 34391
		private static IntPtr _ClassPtr;

		// Token: 0x04008658 RID: 34392
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
