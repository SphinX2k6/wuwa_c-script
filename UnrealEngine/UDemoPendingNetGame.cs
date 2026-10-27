using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009B3 RID: 2483
	[UnrealObjectPath("/Script/Engine.DemoPendingNetGame")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UDemoPendingNetGame : UPendingNetGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008C66 RID: 35942 RVA: 0x000C8F4A File Offset: 0x000C714A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDemoPendingNetGame._ClassPtr;
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x000C8F58 File Offset: 0x000C7158
		public UDemoPendingNetGame() : this(BuiltinUtils.AllocNativeUObject(UDemoPendingNetGame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008C68 RID: 35944 RVA: 0x000C8F80 File Offset: 0x000C7180
		[NullableContext(1)]
		public UDemoPendingNetGame(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDemoPendingNetGame.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x000C8FB3 File Offset: 0x000C71B3
		static UDemoPendingNetGame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DemoPendingNetGame");
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x000C8FC1 File Offset: 0x000C71C1
		protected UDemoPendingNetGame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042A7 RID: 17063
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DemoPendingNetGame";

		// Token: 0x040042A8 RID: 17064
		private static IntPtr _ClassPtr;

		// Token: 0x040042A9 RID: 17065
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
