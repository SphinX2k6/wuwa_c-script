using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CCB RID: 3275
	[UnrealObjectPath("/Script/Engine.KillZVolume")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class AKillZVolume : APhysicsVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A585 RID: 42373 RVA: 0x000EB7E0 File Offset: 0x000E99E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKillZVolume._ClassPtr;
		}

		// Token: 0x0600A586 RID: 42374 RVA: 0x000EB7EC File Offset: 0x000E99EC
		public AKillZVolume() : this(BuiltinUtils.AllocNativeUObject(AKillZVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A587 RID: 42375 RVA: 0x000EB814 File Offset: 0x000E9A14
		[NullableContext(1)]
		public AKillZVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKillZVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A588 RID: 42376 RVA: 0x000EB847 File Offset: 0x000E9A47
		static AKillZVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KillZVolume");
		}

		// Token: 0x0600A589 RID: 42377 RVA: 0x000EB855 File Offset: 0x000E9A55
		protected AKillZVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B0E RID: 23310
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KillZVolume";

		// Token: 0x04005B0F RID: 23311
		private static IntPtr _ClassPtr;

		// Token: 0x04005B10 RID: 23312
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
