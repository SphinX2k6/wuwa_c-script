using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ECB RID: 7883
	[UnrealObjectPath("/Script/KuroUtility.KuroSilenceGameMode")]
	[UnrealStructLayout(1296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1296)]
	public class AKuroSilenceGameMode : AGameMode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DE88 RID: 122504 RVA: 0x002C3C1A File Offset: 0x002C1E1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroSilenceGameMode._ClassPtr;
		}

		// Token: 0x0601DE89 RID: 122505 RVA: 0x002C3C28 File Offset: 0x002C1E28
		public AKuroSilenceGameMode() : this(BuiltinUtils.AllocNativeUObject(AKuroSilenceGameMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE8A RID: 122506 RVA: 0x002C3C50 File Offset: 0x002C1E50
		[NullableContext(1)]
		public AKuroSilenceGameMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroSilenceGameMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE8B RID: 122507 RVA: 0x002C3C83 File Offset: 0x002C1E83
		public void GameInitialized()
		{
			AKuroSilenceGameMode.__GameInitialized_Internal(base.NativePtr);
		}

		// Token: 0x0601DE8C RID: 122508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GameInitialized_Internal(IntPtr @this);

		// Token: 0x0601DE8D RID: 122509 RVA: 0x002C3C90 File Offset: 0x002C1E90
		static AKuroSilenceGameMode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroSilenceGameMode");
		}

		// Token: 0x0601DE8E RID: 122510 RVA: 0x002C3C9E File Offset: 0x002C1E9E
		protected AKuroSilenceGameMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010315 RID: 66325
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroSilenceGameMode";

		// Token: 0x04010316 RID: 66326
		private static IntPtr _ClassPtr;

		// Token: 0x04010317 RID: 66327
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
