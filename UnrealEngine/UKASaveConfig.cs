using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015E1 RID: 5601
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KRDataAnalyticsPlugin.KASaveConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKASaveConfig : USaveGame, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014325 RID: 82725 RVA: 0x001DAA82 File Offset: 0x001D8C82
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKASaveConfig._ClassPtr;
		}

		// Token: 0x06014326 RID: 82726 RVA: 0x001DAA90 File Offset: 0x001D8C90
		public UKASaveConfig() : this(BuiltinUtils.AllocNativeUObject(UKASaveConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014327 RID: 82727 RVA: 0x001DAAB8 File Offset: 0x001D8CB8
		public UKASaveConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKASaveConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x06014328 RID: 82728 RVA: 0x001DAAEB File Offset: 0x001D8CEB
		// (set) Token: 0x06014329 RID: 82729 RVA: 0x001DAAFB File Offset: 0x001D8CFB
		public unsafe int TrackState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKASaveConfig.__PropertyOffset_TrackState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKASaveConfig.__PropertyOffset_TrackState) = value;
			}
		}

		// Token: 0x17004F3B RID: 20283
		// (get) Token: 0x0601432A RID: 82730 RVA: 0x001DAB0C File Offset: 0x001D8D0C
		// (set) Token: 0x0601432B RID: 82731 RVA: 0x001DAB20 File Offset: 0x001D8D20
		public unsafe string DistinctID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKASaveConfig.__PropertyOffset_DistinctID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKASaveConfig.__PropertyOffset_DistinctID)), value);
			}
		}

		// Token: 0x17004F3C RID: 20284
		// (get) Token: 0x0601432C RID: 82732 RVA: 0x001DAB35 File Offset: 0x001D8D35
		// (set) Token: 0x0601432D RID: 82733 RVA: 0x001DAB49 File Offset: 0x001D8D49
		public unsafe string AccountID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKASaveConfig.__PropertyOffset_AccountID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKASaveConfig.__PropertyOffset_AccountID)), value);
			}
		}

		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x0601432E RID: 82734 RVA: 0x001DAB5E File Offset: 0x001D8D5E
		// (set) Token: 0x0601432F RID: 82735 RVA: 0x001DAB72 File Offset: 0x001D8D72
		public unsafe string SuperProperties
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKASaveConfig.__PropertyOffset_SuperProperties)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKASaveConfig.__PropertyOffset_SuperProperties)), value);
			}
		}

		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x06014330 RID: 82736 RVA: 0x001DAB87 File Offset: 0x001D8D87
		// (set) Token: 0x06014331 RID: 82737 RVA: 0x001DAB97 File Offset: 0x001D8D97
		public unsafe uint UserIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKASaveConfig.__PropertyOffset_UserIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKASaveConfig.__PropertyOffset_UserIndex) = (int)value;
			}
		}

		// Token: 0x06014332 RID: 82738 RVA: 0x001DABA8 File Offset: 0x001D8DA8
		static UKASaveConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KRDataAnalyticsPlugin.KASaveConfig");
		}

		// Token: 0x06014333 RID: 82739 RVA: 0x001DABB6 File Offset: 0x001D8DB6
		protected UKASaveConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AFC2 RID: 44994
		public new const string __ObjectPath = "/Script/KRDataAnalyticsPlugin.KASaveConfig";

		// Token: 0x0400AFC3 RID: 44995
		private static IntPtr _ClassPtr;

		// Token: 0x0400AFC4 RID: 44996
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AFC5 RID: 44997
		internal static int __PropertyOffset_TrackState;

		// Token: 0x0400AFC6 RID: 44998
		internal static int __PropertyOffset_DistinctID;

		// Token: 0x0400AFC7 RID: 44999
		internal static int __PropertyOffset_AccountID;

		// Token: 0x0400AFC8 RID: 45000
		internal static int __PropertyOffset_SuperProperties;

		// Token: 0x0400AFC9 RID: 45001
		internal static int __PropertyOffset_UserIndex;
	}
}
