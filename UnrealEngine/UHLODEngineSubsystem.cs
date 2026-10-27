using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C2C RID: 3116
	[UnrealObjectPath("/Script/Engine.HLODEngineSubsystem")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UHLODEngineSubsystem : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E0F RID: 40463 RVA: 0x000E0A84 File Offset: 0x000DEC84
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODEngineSubsystem._ClassPtr;
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x000E0A90 File Offset: 0x000DEC90
		public UHLODEngineSubsystem() : this(BuiltinUtils.AllocNativeUObject(UHLODEngineSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x000E0AB8 File Offset: 0x000DECB8
		[NullableContext(1)]
		public UHLODEngineSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODEngineSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009E12 RID: 40466 RVA: 0x000E0AEB File Offset: 0x000DECEB
		static UHLODEngineSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODEngineSubsystem");
		}

		// Token: 0x06009E13 RID: 40467 RVA: 0x000E0AF9 File Offset: 0x000DECF9
		protected UHLODEngineSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005725 RID: 22309
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODEngineSubsystem";

		// Token: 0x04005726 RID: 22310
		private static IntPtr _ClassPtr;

		// Token: 0x04005727 RID: 22311
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
