using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001084 RID: 4228
	[UnrealObjectPath("/Script/Engine.ReplaySubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UReplaySubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F1C2 RID: 61890 RVA: 0x00166C4E File Offset: 0x00164E4E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReplaySubsystem._ClassPtr;
		}

		// Token: 0x0600F1C3 RID: 61891 RVA: 0x00166C5C File Offset: 0x00164E5C
		public UReplaySubsystem() : this(BuiltinUtils.AllocNativeUObject(UReplaySubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F1C4 RID: 61892 RVA: 0x00166C84 File Offset: 0x00164E84
		[NullableContext(1)]
		public UReplaySubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReplaySubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F1C5 RID: 61893 RVA: 0x00166CB7 File Offset: 0x00164EB7
		static UReplaySubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReplaySubsystem");
		}

		// Token: 0x0600F1C6 RID: 61894 RVA: 0x00166CC5 File Offset: 0x00164EC5
		protected UReplaySubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008318 RID: 33560
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReplaySubsystem";

		// Token: 0x04008319 RID: 33561
		private static IntPtr _ClassPtr;

		// Token: 0x0400831A RID: 33562
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
