using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001291 RID: 4753
	[UnrealObjectPath("/Script/Engine.WorldSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UWorldSubsystem : USubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011733 RID: 71475 RVA: 0x00199EE4 File Offset: 0x001980E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldSubsystem._ClassPtr;
		}

		// Token: 0x06011734 RID: 71476 RVA: 0x00199EF0 File Offset: 0x001980F0
		static UWorldSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldSubsystem");
		}

		// Token: 0x06011735 RID: 71477 RVA: 0x00199F00 File Offset: 0x00198100
		protected UWorldSubsystem() : this(BuiltinUtils.AllocNativeUObject(UWorldSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011736 RID: 71478 RVA: 0x00199F28 File Offset: 0x00198128
		protected UWorldSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009578 RID: 38264
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldSubsystem";

		// Token: 0x04009579 RID: 38265
		private static IntPtr _ClassPtr;

		// Token: 0x0400957A RID: 38266
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
