using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B4 RID: 1204
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBPActorComponent")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroBPActorComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F26 RID: 28454 RVA: 0x000A47C6 File Offset: 0x000A29C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBPActorComponent._ClassPtr;
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x000A47D4 File Offset: 0x000A29D4
		public UKuroBPActorComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroBPActorComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x000A47FC File Offset: 0x000A29FC
		[NullableContext(1)]
		public UKuroBPActorComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBPActorComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x000A482F File Offset: 0x000A2A2F
		static UKuroBPActorComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActorComponent");
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x000A483D File Offset: 0x000A2A3D
		protected UKuroBPActorComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003011 RID: 12305
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBPActorComponent";

		// Token: 0x04003012 RID: 12306
		private static IntPtr _ClassPtr;

		// Token: 0x04003013 RID: 12307
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
