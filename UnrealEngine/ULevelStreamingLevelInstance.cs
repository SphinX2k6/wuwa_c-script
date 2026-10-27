using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D3B RID: 3387
	[UnrealObjectPath("/Script/Engine.LevelStreamingLevelInstance")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class ULevelStreamingLevelInstance : ULevelStreamingDynamic, IUnrealUObject, IUnrealObject, ILevelInstanceLevelStreamingInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600B59A RID: 46490 RVA: 0x00103144 File Offset: 0x00101344
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreamingLevelInstance._ClassPtr;
		}

		// Token: 0x0600B59B RID: 46491 RVA: 0x00103150 File Offset: 0x00101350
		int ILevelInstanceLevelStreamingInterface.InterfaceOffset()
		{
			return ULevelStreamingLevelInstance.__InterfaceOffset_ILevelInstanceLevelStreamingInterface;
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x00103158 File Offset: 0x00101358
		public ULevelStreamingLevelInstance() : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingLevelInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x00103180 File Offset: 0x00101380
		[NullableContext(1)]
		public ULevelStreamingLevelInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingLevelInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B59E RID: 46494 RVA: 0x001031B3 File Offset: 0x001013B3
		static ULevelStreamingLevelInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreamingLevelInstance");
		}

		// Token: 0x0600B59F RID: 46495 RVA: 0x001031C1 File Offset: 0x001013C1
		protected ULevelStreamingLevelInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F71 RID: 24433
		internal static int __InterfaceOffset_ILevelInstanceLevelStreamingInterface;

		// Token: 0x04005F72 RID: 24434
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelStreamingLevelInstance";

		// Token: 0x04005F73 RID: 24435
		private static IntPtr _ClassPtr;

		// Token: 0x04005F74 RID: 24436
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
