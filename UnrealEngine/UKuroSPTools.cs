using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A9 RID: 1449
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroSPTools")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSPTools : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600827E RID: 33406 RVA: 0x000C0FE8 File Offset: 0x000BF1E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSPTools._ClassPtr;
		}

		// Token: 0x0600827F RID: 33407 RVA: 0x000C0FF4 File Offset: 0x000BF1F4
		public UKuroSPTools() : this(BuiltinUtils.AllocNativeUObject(UKuroSPTools.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008280 RID: 33408 RVA: 0x000C101C File Offset: 0x000BF21C
		public UKuroSPTools(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSPTools.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008281 RID: 33409
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetSoVersionUpdateTime(int UpdateTime);

		// Token: 0x06008282 RID: 33410 RVA: 0x000C1050 File Offset: 0x000BF250
		public unsafe static void SetChannelId(string ChannelID)
		{
			FString fstring = FString.AllocTemp(ChannelID);
			UKuroSPTools.__SetChannelId_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008283 RID: 33411 RVA: 0x000C1074 File Offset: 0x000BF274
		public unsafe static void SetCDNConfig(string CDNPrefix, string CDNPath)
		{
			FString fstring = FString.AllocTemp(CDNPrefix);
			FString fstring2 = FString.AllocTemp(CDNPath);
			UKuroSPTools.__SetCDNConfig_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06008284 RID: 33412
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSoVersionUpdateTime();

		// Token: 0x06008285 RID: 33413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChannelId_Internal(in FString ChannelID);

		// Token: 0x06008286 RID: 33414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCDNConfig_Internal(in FString CDNPrefix, in FString CDNPath);

		// Token: 0x06008287 RID: 33415 RVA: 0x000C10AA File Offset: 0x000BF2AA
		static UKuroSPTools()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroSPTools");
		}

		// Token: 0x06008288 RID: 33416 RVA: 0x000C10B8 File Offset: 0x000BF2B8
		protected UKuroSPTools(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038D8 RID: 14552
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroSPTools";

		// Token: 0x040038D9 RID: 14553
		private static IntPtr _ClassPtr;

		// Token: 0x040038DA RID: 14554
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
