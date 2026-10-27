using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C28 RID: 3112
	[UnrealObjectPath("/Script/Engine.HLODBuilder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UHLODBuilder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009DF2 RID: 40434 RVA: 0x000E0836 File Offset: 0x000DEA36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODBuilder._ClassPtr;
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x000E0842 File Offset: 0x000DEA42
		static UHLODBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODBuilder");
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x000E0850 File Offset: 0x000DEA50
		protected UHLODBuilder() : this(BuiltinUtils.AllocNativeUObject(UHLODBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x000E0878 File Offset: 0x000DEA78
		protected UHLODBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005717 RID: 22295
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODBuilder";

		// Token: 0x04005718 RID: 22296
		private static IntPtr _ClassPtr;

		// Token: 0x04005719 RID: 22297
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
