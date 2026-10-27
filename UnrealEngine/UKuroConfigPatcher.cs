using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001988 RID: 6536
	[UnrealObjectPath("/Script/KuroHotPatch.KuroConfigPatcher")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroConfigPatcher : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018467 RID: 99431 RVA: 0x0023CF3C File Offset: 0x0023B13C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroConfigPatcher._ClassPtr;
		}

		// Token: 0x06018468 RID: 99432 RVA: 0x0023CF48 File Offset: 0x0023B148
		public UKuroConfigPatcher() : this(BuiltinUtils.AllocNativeUObject(UKuroConfigPatcher.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018469 RID: 99433 RVA: 0x0023CF70 File Offset: 0x0023B170
		[NullableContext(1)]
		public UKuroConfigPatcher(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroConfigPatcher.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601846A RID: 99434 RVA: 0x0023CFA4 File Offset: 0x0023B1A4
		[NullableContext(1)]
		public unsafe static void UpdateConfigs(string ConfigListPath)
		{
			FString fstring = FString.AllocTemp(ConfigListPath);
			UKuroConfigPatcher.__UpdateConfigs_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601846B RID: 99435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateConfigs_Internal(in FString ConfigListPath);

		// Token: 0x0601846C RID: 99436 RVA: 0x0023CFC8 File Offset: 0x0023B1C8
		static UKuroConfigPatcher()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroHotPatch.KuroConfigPatcher");
		}

		// Token: 0x0601846D RID: 99437 RVA: 0x0023CFD6 File Offset: 0x0023B1D6
		protected UKuroConfigPatcher(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D251 RID: 53841
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroHotPatch.KuroConfigPatcher";

		// Token: 0x0400D252 RID: 53842
		private static IntPtr _ClassPtr;

		// Token: 0x0400D253 RID: 53843
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
