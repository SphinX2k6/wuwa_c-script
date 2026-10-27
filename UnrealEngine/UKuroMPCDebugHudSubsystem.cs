using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200268E RID: 9870
	[UnrealObjectPath("/Script/Renderer.KuroMPCDebugHudSubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroMPCDebugHudSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024A25 RID: 150053 RVA: 0x00363C2E File Offset: 0x00361E2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMPCDebugHudSubsystem._ClassPtr;
		}

		// Token: 0x06024A26 RID: 150054 RVA: 0x00363C3C File Offset: 0x00361E3C
		public UKuroMPCDebugHudSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroMPCDebugHudSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024A27 RID: 150055 RVA: 0x00363C64 File Offset: 0x00361E64
		[NullableContext(1)]
		public UKuroMPCDebugHudSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMPCDebugHudSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024A28 RID: 150056 RVA: 0x00363C97 File Offset: 0x00361E97
		static UKuroMPCDebugHudSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Renderer.KuroMPCDebugHudSubsystem");
		}

		// Token: 0x06024A29 RID: 150057 RVA: 0x00363CA5 File Offset: 0x00361EA5
		protected UKuroMPCDebugHudSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013B24 RID: 80676
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Renderer.KuroMPCDebugHudSubsystem";

		// Token: 0x04013B25 RID: 80677
		private static IntPtr _ClassPtr;

		// Token: 0x04013B26 RID: 80678
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
