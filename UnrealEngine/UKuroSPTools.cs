using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E76 RID: 7798
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSoHotPatch.KuroSPTools")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroSPTools : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB14 RID: 121620 RVA: 0x002BDD0C File Offset: 0x002BBF0C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSPTools._ClassPtr;
		}

		// Token: 0x0601DB15 RID: 121621 RVA: 0x002BDD18 File Offset: 0x002BBF18
		public UKuroSPTools() : this(BuiltinUtils.AllocNativeUObject(UKuroSPTools.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB16 RID: 121622 RVA: 0x002BDD40 File Offset: 0x002BBF40
		public UKuroSPTools(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSPTools.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DB17 RID: 121623
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetSoVersionUpdateTime(int UpdateTime);

		// Token: 0x0601DB18 RID: 121624 RVA: 0x002BDD74 File Offset: 0x002BBF74
		public unsafe static void SetChannelId(string ChannelID)
		{
			FString fstring = FString.AllocTemp(ChannelID);
			UKuroSPTools.__SetChannelId_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DB19 RID: 121625 RVA: 0x002BDD98 File Offset: 0x002BBF98
		public unsafe static void SetCDNConfig(string CDNPrefix, string CDNPath)
		{
			FString fstring = FString.AllocTemp(CDNPrefix);
			FString fstring2 = FString.AllocTemp(CDNPath);
			UKuroSPTools.__SetCDNConfig_Internal(fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601DB1A RID: 121626
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetSoVersionUpdateTime();

		// Token: 0x0601DB1B RID: 121627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChannelId_Internal(in FString ChannelID);

		// Token: 0x0601DB1C RID: 121628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCDNConfig_Internal(in FString CDNPrefix, in FString CDNPath);

		// Token: 0x0601DB1D RID: 121629 RVA: 0x002BDDCE File Offset: 0x002BBFCE
		static UKuroSPTools()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSoHotPatch.KuroSPTools");
		}

		// Token: 0x0601DB1E RID: 121630 RVA: 0x002BDDDC File Offset: 0x002BBFDC
		protected UKuroSPTools(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010143 RID: 65859
		public new const string __ObjectPath = "/Script/KuroSoHotPatch.KuroSPTools";

		// Token: 0x04010144 RID: 65860
		private static IntPtr _ClassPtr;

		// Token: 0x04010145 RID: 65861
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
