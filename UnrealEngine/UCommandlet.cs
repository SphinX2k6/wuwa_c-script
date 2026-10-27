using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200094C RID: 2380
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Commandlet")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UCommandlet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060086C2 RID: 34498 RVA: 0x000C011B File Offset: 0x000BE31B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCommandlet._ClassPtr;
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x060086C3 RID: 34499 RVA: 0x000C0127 File Offset: 0x000BE327
		// (set) Token: 0x060086C4 RID: 34500 RVA: 0x000C013B File Offset: 0x000BE33B
		public unsafe string HelpDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCommandlet.__PropertyOffset_HelpDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCommandlet.__PropertyOffset_HelpDescription)), value);
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x060086C5 RID: 34501 RVA: 0x000C0150 File Offset: 0x000BE350
		// (set) Token: 0x060086C6 RID: 34502 RVA: 0x000C0164 File Offset: 0x000BE364
		public unsafe string HelpUsage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCommandlet.__PropertyOffset_HelpUsage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCommandlet.__PropertyOffset_HelpUsage)), value);
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x060086C7 RID: 34503 RVA: 0x000C0179 File Offset: 0x000BE379
		// (set) Token: 0x060086C8 RID: 34504 RVA: 0x000C018D File Offset: 0x000BE38D
		public unsafe string HelpWebLink
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UCommandlet.__PropertyOffset_HelpWebLink)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UCommandlet.__PropertyOffset_HelpWebLink)), value);
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x060086C9 RID: 34505 RVA: 0x000C01A4 File Offset: 0x000BE3A4
		// (set) Token: 0x060086CA RID: 34506 RVA: 0x000C01DD File Offset: 0x000BE3DD
		public TArray<string> HelpParamNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HelpParamNames) == null)
				{
					result = (this._HelpParamNames = new TArray<string>(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_HelpParamNames, this));
				}
				return result;
			}
			set
			{
				this.HelpParamNames.CopyAssign(value);
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x060086CB RID: 34507 RVA: 0x000C01EC File Offset: 0x000BE3EC
		// (set) Token: 0x060086CC RID: 34508 RVA: 0x000C0225 File Offset: 0x000BE425
		public TArray<string> HelpParamDescriptions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._HelpParamDescriptions) == null)
				{
					result = (this._HelpParamDescriptions = new TArray<string>(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_HelpParamDescriptions, this));
				}
				return result;
			}
			set
			{
				this.HelpParamDescriptions.CopyAssign(value);
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x000C0233 File Offset: 0x000BE433
		// (set) Token: 0x060086CE RID: 34510 RVA: 0x000C024C File Offset: 0x000BE44C
		public unsafe bool IsServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsServer) & UCommandlet.__PropertyMask_IsServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsServer) = ((*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsServer) & ~UCommandlet.__PropertyMask_IsServer) | (value ? UCommandlet.__PropertyMask_IsServer : 0));
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x060086CF RID: 34511 RVA: 0x000C027C File Offset: 0x000BE47C
		// (set) Token: 0x060086D0 RID: 34512 RVA: 0x000C0295 File Offset: 0x000BE495
		public unsafe bool IsClient
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsClient) & UCommandlet.__PropertyMask_IsClient) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsClient) = ((*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsClient) & ~UCommandlet.__PropertyMask_IsClient) | (value ? UCommandlet.__PropertyMask_IsClient : 0));
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x060086D1 RID: 34513 RVA: 0x000C02C5 File Offset: 0x000BE4C5
		// (set) Token: 0x060086D2 RID: 34514 RVA: 0x000C02DE File Offset: 0x000BE4DE
		public unsafe bool IsEditor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsEditor) & UCommandlet.__PropertyMask_IsEditor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsEditor) = ((*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_IsEditor) & ~UCommandlet.__PropertyMask_IsEditor) | (value ? UCommandlet.__PropertyMask_IsEditor : 0));
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x060086D3 RID: 34515 RVA: 0x000C030E File Offset: 0x000BE50E
		// (set) Token: 0x060086D4 RID: 34516 RVA: 0x000C0327 File Offset: 0x000BE527
		public unsafe bool LogToConsole
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_LogToConsole) & UCommandlet.__PropertyMask_LogToConsole) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCommandlet.__PropertyOffset_LogToConsole) = ((*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_LogToConsole) & ~UCommandlet.__PropertyMask_LogToConsole) | (value ? UCommandlet.__PropertyMask_LogToConsole : 0));
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x060086D5 RID: 34517 RVA: 0x000C0357 File Offset: 0x000BE557
		// (set) Token: 0x060086D6 RID: 34518 RVA: 0x000C0370 File Offset: 0x000BE570
		public unsafe bool ShowErrorCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_ShowErrorCount) & UCommandlet.__PropertyMask_ShowErrorCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCommandlet.__PropertyOffset_ShowErrorCount) = ((*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_ShowErrorCount) & ~UCommandlet.__PropertyMask_ShowErrorCount) | (value ? UCommandlet.__PropertyMask_ShowErrorCount : 0));
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x060086D7 RID: 34519 RVA: 0x000C03A0 File Offset: 0x000BE5A0
		// (set) Token: 0x060086D8 RID: 34520 RVA: 0x000C03B9 File Offset: 0x000BE5B9
		public unsafe bool ShowProgress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_ShowProgress) & UCommandlet.__PropertyMask_ShowProgress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCommandlet.__PropertyOffset_ShowProgress) = ((*(base.NativePtr + (IntPtr)UCommandlet.__PropertyOffset_ShowProgress) & ~UCommandlet.__PropertyMask_ShowProgress) | (value ? UCommandlet.__PropertyMask_ShowProgress : 0));
			}
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x000C03E9 File Offset: 0x000BE5E9
		static UCommandlet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Commandlet");
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x000C03F8 File Offset: 0x000BE5F8
		protected UCommandlet() : this(BuiltinUtils.AllocNativeUObject(UCommandlet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060086DB RID: 34523 RVA: 0x000C0420 File Offset: 0x000BE620
		protected UCommandlet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400401B RID: 16411
		public new const string __ObjectPath = "/Script/Engine.Commandlet";

		// Token: 0x0400401C RID: 16412
		private static IntPtr _ClassPtr;

		// Token: 0x0400401D RID: 16413
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400401E RID: 16414
		internal static int __PropertyOffset_HelpDescription;

		// Token: 0x0400401F RID: 16415
		internal static int __PropertyOffset_HelpUsage;

		// Token: 0x04004020 RID: 16416
		internal static int __PropertyOffset_HelpWebLink;

		// Token: 0x04004021 RID: 16417
		internal static int __PropertyOffset_HelpParamNames;

		// Token: 0x04004022 RID: 16418
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HelpParamNames;

		// Token: 0x04004023 RID: 16419
		internal static int __PropertyOffset_HelpParamDescriptions;

		// Token: 0x04004024 RID: 16420
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _HelpParamDescriptions;

		// Token: 0x04004025 RID: 16421
		internal static int __PropertyOffset_IsServer;

		// Token: 0x04004026 RID: 16422
		internal static byte __PropertyMask_IsServer;

		// Token: 0x04004027 RID: 16423
		internal static int __PropertyOffset_IsClient;

		// Token: 0x04004028 RID: 16424
		internal static byte __PropertyMask_IsClient;

		// Token: 0x04004029 RID: 16425
		internal static int __PropertyOffset_IsEditor;

		// Token: 0x0400402A RID: 16426
		internal static byte __PropertyMask_IsEditor;

		// Token: 0x0400402B RID: 16427
		internal static int __PropertyOffset_LogToConsole;

		// Token: 0x0400402C RID: 16428
		internal static byte __PropertyMask_LogToConsole;

		// Token: 0x0400402D RID: 16429
		internal static int __PropertyOffset_ShowErrorCount;

		// Token: 0x0400402E RID: 16430
		internal static byte __PropertyMask_ShowErrorCount;

		// Token: 0x0400402F RID: 16431
		internal static int __PropertyOffset_ShowProgress;

		// Token: 0x04004030 RID: 16432
		internal static byte __PropertyMask_ShowProgress;
	}
}
