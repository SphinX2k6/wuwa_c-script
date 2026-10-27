using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028F2 RID: 10482
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TUConfig")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FTUConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026E01 RID: 159233 RVA: 0x003B4D2D File Offset: 0x003B2F2D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTUConfig._ScriptStructPtr != 0) ? FTUConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TUConfig", ref FTUConfig._ScriptStructPtr);
		}

		// Token: 0x170095C3 RID: 38339
		// (get) Token: 0x06026E02 RID: 159234 RVA: 0x003B4D51 File Offset: 0x003B2F51
		// (set) Token: 0x06026E03 RID: 159235 RVA: 0x003B4D65 File Offset: 0x003B2F65
		public unsafe string ClientID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ClientID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ClientID)), value);
			}
		}

		// Token: 0x170095C4 RID: 38340
		// (get) Token: 0x06026E04 RID: 159236 RVA: 0x003B4D7A File Offset: 0x003B2F7A
		// (set) Token: 0x06026E05 RID: 159237 RVA: 0x003B4D8E File Offset: 0x003B2F8E
		public unsafe string ClientToken
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ClientToken)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ClientToken)), value);
			}
		}

		// Token: 0x170095C5 RID: 38341
		// (get) Token: 0x06026E06 RID: 159238 RVA: 0x003B4DA3 File Offset: 0x003B2FA3
		// (set) Token: 0x06026E07 RID: 159239 RVA: 0x003B4DB7 File Offset: 0x003B2FB7
		public unsafe string ClientPublicKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ClientPublicKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ClientPublicKey)), value);
			}
		}

		// Token: 0x170095C6 RID: 38342
		// (get) Token: 0x06026E08 RID: 159240 RVA: 0x003B4DCC File Offset: 0x003B2FCC
		// (set) Token: 0x06026E09 RID: 159241 RVA: 0x003B4DDC File Offset: 0x003B2FDC
		public unsafe ERegionType RegionType
		{
			get
			{
				return (ERegionType)(*(base.NativePtr + (IntPtr)FTUConfig.__PropertyOffset_RegionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTUConfig.__PropertyOffset_RegionType) = (byte)value;
			}
		}

		// Token: 0x170095C7 RID: 38343
		// (get) Token: 0x06026E0A RID: 159242 RVA: 0x003B4DED File Offset: 0x003B2FED
		// (set) Token: 0x06026E0B RID: 159243 RVA: 0x003B4E01 File Offset: 0x003B3001
		public unsafe string ServerURL
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ServerURL)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTUConfig.__PropertyOffset_ServerURL)), value);
			}
		}

		// Token: 0x06026E0C RID: 159244 RVA: 0x003B4E16 File Offset: 0x003B3016
		public FTUConfig()
		{
		}

		// Token: 0x06026E0D RID: 159245 RVA: 0x003B4E1E File Offset: 0x003B301E
		public FTUConfig(string ClientID, string ClientToken, string ClientPublicKey, ERegionType RegionType, string ServerURL)
		{
			this.ClientID = ClientID;
			this.ClientToken = ClientToken;
			this.ClientPublicKey = ClientPublicKey;
			this.RegionType = RegionType;
			this.ServerURL = ServerURL;
		}

		// Token: 0x06026E0E RID: 159246 RVA: 0x003B4E4B File Offset: 0x003B304B
		protected override IntPtr GetUStructPtr()
		{
			return FTUConfig.StaticStruct();
		}

		// Token: 0x06026E0F RID: 159247 RVA: 0x003B4E57 File Offset: 0x003B3057
		[NullableContext(2)]
		public FTUConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026E10 RID: 159248 RVA: 0x003B4E61 File Offset: 0x003B3061
		public FTUConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026E11 RID: 159249 RVA: 0x003B4E6C File Offset: 0x003B306C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTUConfig(Pointer, false, true);
		}

		// Token: 0x06026E12 RID: 159250 RVA: 0x003B4E76 File Offset: 0x003B3076
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTUConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04015582 RID: 87426
		public const string __ObjectPath = "/Script/TapCommon.TUConfig";

		// Token: 0x04015583 RID: 87427
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015584 RID: 87428
		internal static int __PropertyOffset_ClientID;

		// Token: 0x04015585 RID: 87429
		internal static int __PropertyOffset_ClientToken;

		// Token: 0x04015586 RID: 87430
		internal static int __PropertyOffset_ClientPublicKey;

		// Token: 0x04015587 RID: 87431
		internal static int __PropertyOffset_RegionType;

		// Token: 0x04015588 RID: 87432
		internal static int __PropertyOffset_ServerURL;
	}
}
