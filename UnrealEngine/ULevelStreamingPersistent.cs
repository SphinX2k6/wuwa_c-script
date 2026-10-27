using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D3E RID: 3390
	[UnrealObjectPath("/Script/Engine.LevelStreamingPersistent")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class ULevelStreamingPersistent : ULevelStreaming, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B5B0 RID: 46512 RVA: 0x00103362 File Offset: 0x00101562
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreamingPersistent._ClassPtr;
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x00103370 File Offset: 0x00101570
		public ULevelStreamingPersistent() : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingPersistent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B5B2 RID: 46514 RVA: 0x00103398 File Offset: 0x00101598
		[NullableContext(1)]
		public ULevelStreamingPersistent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingPersistent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x001033CB File Offset: 0x001015CB
		static ULevelStreamingPersistent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreamingPersistent");
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x001033D9 File Offset: 0x001015D9
		protected ULevelStreamingPersistent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F7C RID: 24444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelStreamingPersistent";

		// Token: 0x04005F7D RID: 24445
		private static IntPtr _ClassPtr;

		// Token: 0x04005F7E RID: 24446
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
