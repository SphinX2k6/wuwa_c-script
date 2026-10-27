using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B74 RID: 7028
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMediaAlignWorldSubsystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroMediaAlignWorldSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A9DE RID: 109022 RVA: 0x00273BE9 File Offset: 0x00271DE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMediaAlignWorldSubsystem._ClassPtr;
		}

		// Token: 0x0601A9DF RID: 109023 RVA: 0x00273BF8 File Offset: 0x00271DF8
		public UKuroMediaAlignWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroMediaAlignWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A9E0 RID: 109024 RVA: 0x00273C20 File Offset: 0x00271E20
		[NullableContext(1)]
		public UKuroMediaAlignWorldSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMediaAlignWorldSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601A9E1 RID: 109025 RVA: 0x00273C53 File Offset: 0x00271E53
		static UKuroMediaAlignWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroMediaAlignWorldSubsystem");
		}

		// Token: 0x0601A9E2 RID: 109026 RVA: 0x00273C61 File Offset: 0x00271E61
		protected UKuroMediaAlignWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E672 RID: 58994
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMediaAlignWorldSubsystem";

		// Token: 0x0400E673 RID: 58995
		private static IntPtr _ClassPtr;

		// Token: 0x0400E674 RID: 58996
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
