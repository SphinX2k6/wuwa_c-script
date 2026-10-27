using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016A9 RID: 5801
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroTestResultFile")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 408)]
	public class FKuroTestResultFile : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601508F RID: 86159 RVA: 0x001EE86C File Offset: 0x001ECA6C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTestResultFile._ScriptStructPtr != 0) ? FKuroTestResultFile._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAutomationTool.KuroTestResultFile", ref FKuroTestResultFile._ScriptStructPtr);
		}

		// Token: 0x17005340 RID: 21312
		// (get) Token: 0x06015090 RID: 86160 RVA: 0x001EE890 File Offset: 0x001ECA90
		// (set) Token: 0x06015091 RID: 86161 RVA: 0x001EE8A4 File Offset: 0x001ECAA4
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17005341 RID: 21313
		// (get) Token: 0x06015092 RID: 86162 RVA: 0x001EE8B9 File Offset: 0x001ECAB9
		// (set) Token: 0x06015093 RID: 86163 RVA: 0x001EE8CD File Offset: 0x001ECACD
		public unsafe string ModuleName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_ModuleName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_ModuleName)), value);
			}
		}

		// Token: 0x17005342 RID: 21314
		// (get) Token: 0x06015094 RID: 86164 RVA: 0x001EE8E2 File Offset: 0x001ECAE2
		// (set) Token: 0x06015095 RID: 86165 RVA: 0x001EE8F6 File Offset: 0x001ECAF6
		public unsafe string Map
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_Map)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_Map)), value);
			}
		}

		// Token: 0x17005343 RID: 21315
		// (get) Token: 0x06015096 RID: 86166 RVA: 0x001EE90B File Offset: 0x001ECB0B
		// (set) Token: 0x06015097 RID: 86167 RVA: 0x001EE91F File Offset: 0x001ECB1F
		public unsafe string TransmitterSender
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_TransmitterSender)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_TransmitterSender)), value);
			}
		}

		// Token: 0x17005344 RID: 21316
		// (get) Token: 0x06015098 RID: 86168 RVA: 0x001EE934 File Offset: 0x001ECB34
		// (set) Token: 0x06015099 RID: 86169 RVA: 0x001EE948 File Offset: 0x001ECB48
		public unsafe string TransmitterReceiver
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_TransmitterReceiver)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_TransmitterReceiver)), value);
			}
		}

		// Token: 0x17005345 RID: 21317
		// (get) Token: 0x0601509A RID: 86170 RVA: 0x001EE95D File Offset: 0x001ECB5D
		// (set) Token: 0x0601509B RID: 86171 RVA: 0x001EE96D File Offset: 0x001ECB6D
		public unsafe int Timeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_Timeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_Timeout) = value;
			}
		}

		// Token: 0x17005346 RID: 21318
		// (get) Token: 0x0601509C RID: 86172 RVA: 0x001EE97E File Offset: 0x001ECB7E
		// (set) Token: 0x0601509D RID: 86173 RVA: 0x001EE98E File Offset: 0x001ECB8E
		public unsafe bool UseHackMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_UseHackMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_UseHackMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005347 RID: 21319
		// (get) Token: 0x0601509E RID: 86174 RVA: 0x001EE99F File Offset: 0x001ECB9F
		// (set) Token: 0x0601509F RID: 86175 RVA: 0x001EE9B3 File Offset: 0x001ECBB3
		public unsafe string TsServerAddr
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_TsServerAddr)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_TsServerAddr)), value);
			}
		}

		// Token: 0x17005348 RID: 21320
		// (get) Token: 0x060150A0 RID: 86176 RVA: 0x001EE9C8 File Offset: 0x001ECBC8
		// (set) Token: 0x060150A1 RID: 86177 RVA: 0x001EEA0B File Offset: 0x001ECC0B
		public TMap<string, string> Params
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new TMap<string, string>(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_Params, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Params.CopyAssign(value);
			}
		}

		// Token: 0x17005349 RID: 21321
		// (get) Token: 0x060150A2 RID: 86178 RVA: 0x001EEA1C File Offset: 0x001ECC1C
		// (set) Token: 0x060150A3 RID: 86179 RVA: 0x001EEA5F File Offset: 0x001ECC5F
		public TArray<string> Metrics
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Metrics) == null)
				{
					result = (this._Metrics = new TArray<string>(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_Metrics, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Metrics.CopyAssign(value);
			}
		}

		// Token: 0x1700534A RID: 21322
		// (get) Token: 0x060150A4 RID: 86180 RVA: 0x001EEA70 File Offset: 0x001ECC70
		// (set) Token: 0x060150A5 RID: 86181 RVA: 0x001EEAB3 File Offset: 0x001ECCB3
		public TArray<FKuroTestExpectation> Expectations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroTestExpectation> result;
				if ((result = this._Expectations) == null)
				{
					result = (this._Expectations = new TArray<FKuroTestExpectation>(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_Expectations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Expectations.CopyAssign(value);
			}
		}

		// Token: 0x1700534B RID: 21323
		// (get) Token: 0x060150A6 RID: 86182 RVA: 0x001EEAC1 File Offset: 0x001ECCC1
		// (set) Token: 0x060150A7 RID: 86183 RVA: 0x001EEAD5 File Offset: 0x001ECCD5
		public unsafe string OutputDir
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_OutputDir)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_OutputDir)), value);
			}
		}

		// Token: 0x1700534C RID: 21324
		// (get) Token: 0x060150A8 RID: 86184 RVA: 0x001EEAEA File Offset: 0x001ECCEA
		// (set) Token: 0x060150A9 RID: 86185 RVA: 0x001EEAFE File Offset: 0x001ECCFE
		public unsafe string FinishTime
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_FinishTime)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_FinishTime)), value);
			}
		}

		// Token: 0x1700534D RID: 21325
		// (get) Token: 0x060150AA RID: 86186 RVA: 0x001EEB13 File Offset: 0x001ECD13
		// (set) Token: 0x060150AB RID: 86187 RVA: 0x001EEB23 File Offset: 0x001ECD23
		public unsafe int CostSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_CostSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_CostSeconds) = value;
			}
		}

		// Token: 0x1700534E RID: 21326
		// (get) Token: 0x060150AC RID: 86188 RVA: 0x001EEB34 File Offset: 0x001ECD34
		// (set) Token: 0x060150AD RID: 86189 RVA: 0x001EEB44 File Offset: 0x001ECD44
		public unsafe bool IsPass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_IsPass) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_IsPass) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700534F RID: 21327
		// (get) Token: 0x060150AE RID: 86190 RVA: 0x001EEB55 File Offset: 0x001ECD55
		// (set) Token: 0x060150AF RID: 86191 RVA: 0x001EEB65 File Offset: 0x001ECD65
		public unsafe int ErrorCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_ErrorCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_ErrorCode) = value;
			}
		}

		// Token: 0x17005350 RID: 21328
		// (get) Token: 0x060150B0 RID: 86192 RVA: 0x001EEB76 File Offset: 0x001ECD76
		// (set) Token: 0x060150B1 RID: 86193 RVA: 0x001EEB8A File Offset: 0x001ECD8A
		public unsafe string ErrorMsg
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_ErrorMsg)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_ErrorMsg)), value);
			}
		}

		// Token: 0x17005351 RID: 21329
		// (get) Token: 0x060150B2 RID: 86194 RVA: 0x001EEB9F File Offset: 0x001ECD9F
		// (set) Token: 0x060150B3 RID: 86195 RVA: 0x001EEBB3 File Offset: 0x001ECDB3
		public unsafe string ExtraMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_ExtraMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestResultFile.__PropertyOffset_ExtraMessage)), value);
			}
		}

		// Token: 0x17005352 RID: 21330
		// (get) Token: 0x060150B4 RID: 86196 RVA: 0x001EEBC8 File Offset: 0x001ECDC8
		// (set) Token: 0x060150B5 RID: 86197 RVA: 0x001EEC0B File Offset: 0x001ECE0B
		public TMap<string, int> RawMetrics
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._RawMetrics) == null)
				{
					result = (this._RawMetrics = new TMap<string, int>(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_RawMetrics, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RawMetrics.CopyAssign(value);
			}
		}

		// Token: 0x17005353 RID: 21331
		// (get) Token: 0x060150B6 RID: 86198 RVA: 0x001EEC1C File Offset: 0x001ECE1C
		// (set) Token: 0x060150B7 RID: 86199 RVA: 0x001EEC5F File Offset: 0x001ECE5F
		public TArray<string> Errors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Errors) == null)
				{
					result = (this._Errors = new TArray<string>(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_Errors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Errors.CopyAssign(value);
			}
		}

		// Token: 0x17005354 RID: 21332
		// (get) Token: 0x060150B8 RID: 86200 RVA: 0x001EEC70 File Offset: 0x001ECE70
		// (set) Token: 0x060150B9 RID: 86201 RVA: 0x001EECB3 File Offset: 0x001ECEB3
		public TArray<string> Warnings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Warnings) == null)
				{
					result = (this._Warnings = new TArray<string>(base.NativePtr + (IntPtr)FKuroTestResultFile.__PropertyOffset_Warnings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Warnings.CopyAssign(value);
			}
		}

		// Token: 0x060150BA RID: 86202 RVA: 0x001EECC1 File Offset: 0x001ECEC1
		public FKuroTestResultFile()
		{
		}

		// Token: 0x060150BB RID: 86203 RVA: 0x001EECCC File Offset: 0x001ECECC
		public FKuroTestResultFile(string Name, string ModuleName, string Map, string TransmitterSender, string TransmitterReceiver, int Timeout, bool UseHackMode, string TsServerAddr, TMap<string, string> Params, TArray<string> Metrics, TArray<FKuroTestExpectation> Expectations, string OutputDir, string FinishTime, int CostSeconds, bool IsPass, int ErrorCode, string ErrorMsg, string ExtraMessage, TMap<string, int> RawMetrics, TArray<string> Errors, TArray<string> Warnings)
		{
			this.Name = Name;
			this.ModuleName = ModuleName;
			this.Map = Map;
			this.TransmitterSender = TransmitterSender;
			this.TransmitterReceiver = TransmitterReceiver;
			this.Timeout = Timeout;
			this.UseHackMode = UseHackMode;
			this.TsServerAddr = TsServerAddr;
			this.Params = Params;
			this.Metrics = Metrics;
			this.Expectations = Expectations;
			this.OutputDir = OutputDir;
			this.FinishTime = FinishTime;
			this.CostSeconds = CostSeconds;
			this.IsPass = IsPass;
			this.ErrorCode = ErrorCode;
			this.ErrorMsg = ErrorMsg;
			this.ExtraMessage = ExtraMessage;
			this.RawMetrics = RawMetrics;
			this.Errors = Errors;
			this.Warnings = Warnings;
		}

		// Token: 0x060150BC RID: 86204 RVA: 0x001EED84 File Offset: 0x001ECF84
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTestResultFile.StaticStruct();
		}

		// Token: 0x060150BD RID: 86205 RVA: 0x001EED90 File Offset: 0x001ECF90
		[NullableContext(2)]
		public FKuroTestResultFile(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060150BE RID: 86206 RVA: 0x001EED9A File Offset: 0x001ECF9A
		public FKuroTestResultFile(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060150BF RID: 86207 RVA: 0x001EEDA5 File Offset: 0x001ECFA5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTestResultFile(Pointer, false, true);
		}

		// Token: 0x060150C0 RID: 86208 RVA: 0x001EEDAF File Offset: 0x001ECFAF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTestResultFile(Pointer, MemoryOwner);
		}

		// Token: 0x0400B738 RID: 46904
		public const string __ObjectPath = "/Script/KuroAutomationTool.KuroTestResultFile";

		// Token: 0x0400B739 RID: 46905
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B73A RID: 46906
		internal static int __PropertyOffset_Name;

		// Token: 0x0400B73B RID: 46907
		internal static int __PropertyOffset_ModuleName;

		// Token: 0x0400B73C RID: 46908
		internal static int __PropertyOffset_Map;

		// Token: 0x0400B73D RID: 46909
		internal static int __PropertyOffset_TransmitterSender;

		// Token: 0x0400B73E RID: 46910
		internal static int __PropertyOffset_TransmitterReceiver;

		// Token: 0x0400B73F RID: 46911
		internal static int __PropertyOffset_Timeout;

		// Token: 0x0400B740 RID: 46912
		internal static int __PropertyOffset_UseHackMode;

		// Token: 0x0400B741 RID: 46913
		internal static int __PropertyOffset_TsServerAddr;

		// Token: 0x0400B742 RID: 46914
		internal static int __PropertyOffset_Params;

		// Token: 0x0400B743 RID: 46915
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _Params;

		// Token: 0x0400B744 RID: 46916
		internal static int __PropertyOffset_Metrics;

		// Token: 0x0400B745 RID: 46917
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Metrics;

		// Token: 0x0400B746 RID: 46918
		internal static int __PropertyOffset_Expectations;

		// Token: 0x0400B747 RID: 46919
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroTestExpectation> _Expectations;

		// Token: 0x0400B748 RID: 46920
		internal static int __PropertyOffset_OutputDir;

		// Token: 0x0400B749 RID: 46921
		internal static int __PropertyOffset_FinishTime;

		// Token: 0x0400B74A RID: 46922
		internal static int __PropertyOffset_CostSeconds;

		// Token: 0x0400B74B RID: 46923
		internal static int __PropertyOffset_IsPass;

		// Token: 0x0400B74C RID: 46924
		internal static int __PropertyOffset_ErrorCode;

		// Token: 0x0400B74D RID: 46925
		internal static int __PropertyOffset_ErrorMsg;

		// Token: 0x0400B74E RID: 46926
		internal static int __PropertyOffset_ExtraMessage;

		// Token: 0x0400B74F RID: 46927
		internal static int __PropertyOffset_RawMetrics;

		// Token: 0x0400B750 RID: 46928
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _RawMetrics;

		// Token: 0x0400B751 RID: 46929
		internal static int __PropertyOffset_Errors;

		// Token: 0x0400B752 RID: 46930
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Errors;

		// Token: 0x0400B753 RID: 46931
		internal static int __PropertyOffset_Warnings;

		// Token: 0x0400B754 RID: 46932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Warnings;
	}
}
