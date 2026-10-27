using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CFF RID: 3327
	[UnrealObjectPath("/Script/Engine.KuroObjectSubSystem")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UKuroObjectSubSystem : UEngineSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B12D RID: 45357 RVA: 0x000FB94B File Offset: 0x000F9B4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroObjectSubSystem._ClassPtr;
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x000FB958 File Offset: 0x000F9B58
		public UKuroObjectSubSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroObjectSubSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x000FB980 File Offset: 0x000F9B80
		[NullableContext(1)]
		public UKuroObjectSubSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroObjectSubSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x000FB9B3 File Offset: 0x000F9BB3
		static UKuroObjectSubSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroObjectSubSystem");
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x000FB9C1 File Offset: 0x000F9BC1
		protected UKuroObjectSubSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005CD4 RID: 23764
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroObjectSubSystem";

		// Token: 0x04005CD5 RID: 23765
		private static IntPtr _ClassPtr;

		// Token: 0x04005CD6 RID: 23766
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
