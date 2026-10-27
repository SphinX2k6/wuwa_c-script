using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D02 RID: 3330
	[UnrealObjectPath("/Script/Engine.KuroPhysicsSplitSystemBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UKuroPhysicsSplitSystemBase : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B159 RID: 45401 RVA: 0x000FBBF1 File Offset: 0x000F9DF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPhysicsSplitSystemBase._ClassPtr;
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x000FBBFD File Offset: 0x000F9DFD
		static UKuroPhysicsSplitSystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroPhysicsSplitSystemBase");
		}

		// Token: 0x0600B15B RID: 45403 RVA: 0x000FBC0C File Offset: 0x000F9E0C
		protected UKuroPhysicsSplitSystemBase() : this(BuiltinUtils.AllocNativeUObject(UKuroPhysicsSplitSystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B15C RID: 45404 RVA: 0x000FBC34 File Offset: 0x000F9E34
		protected UKuroPhysicsSplitSystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005CDE RID: 23774
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroPhysicsSplitSystemBase";

		// Token: 0x04005CDF RID: 23775
		private static IntPtr _ClassPtr;

		// Token: 0x04005CE0 RID: 23776
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
