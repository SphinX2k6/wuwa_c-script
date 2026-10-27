using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D3 RID: 467
	[UnrealObjectPath("/Script/AIModule.PathFollowingManager")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UPathFollowingManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B91 RID: 7057 RVA: 0x000291EE File Offset: 0x000273EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPathFollowingManager._ClassPtr;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000291FC File Offset: 0x000273FC
		public UPathFollowingManager() : this(BuiltinUtils.AllocNativeUObject(UPathFollowingManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x00029224 File Offset: 0x00027424
		[NullableContext(1)]
		public UPathFollowingManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPathFollowingManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x00029257 File Offset: 0x00027457
		static UPathFollowingManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PathFollowingManager");
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x00029265 File Offset: 0x00027465
		protected UPathFollowingManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008D5 RID: 2261
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PathFollowingManager";

		// Token: 0x040008D6 RID: 2262
		private static IntPtr _ClassPtr;

		// Token: 0x040008D7 RID: 2263
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
