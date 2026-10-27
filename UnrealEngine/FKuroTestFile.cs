using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016A8 RID: 5800
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroTestFile")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FKuroTestFile : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015067 RID: 86119 RVA: 0x001EE492 File Offset: 0x001EC692
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroTestFile._ScriptStructPtr != 0) ? FKuroTestFile._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAutomationTool.KuroTestFile", ref FKuroTestFile._ScriptStructPtr);
		}

		// Token: 0x17005330 RID: 21296
		// (get) Token: 0x06015068 RID: 86120 RVA: 0x001EE4B6 File Offset: 0x001EC6B6
		// (set) Token: 0x06015069 RID: 86121 RVA: 0x001EE4CA File Offset: 0x001EC6CA
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17005331 RID: 21297
		// (get) Token: 0x0601506A RID: 86122 RVA: 0x001EE4DF File Offset: 0x001EC6DF
		// (set) Token: 0x0601506B RID: 86123 RVA: 0x001EE4F3 File Offset: 0x001EC6F3
		public unsafe string ModuleName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_ModuleName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_ModuleName)), value);
			}
		}

		// Token: 0x17005332 RID: 21298
		// (get) Token: 0x0601506C RID: 86124 RVA: 0x001EE508 File Offset: 0x001EC708
		// (set) Token: 0x0601506D RID: 86125 RVA: 0x001EE51C File Offset: 0x001EC71C
		public unsafe string Map
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_Map)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_Map)), value);
			}
		}

		// Token: 0x17005333 RID: 21299
		// (get) Token: 0x0601506E RID: 86126 RVA: 0x001EE531 File Offset: 0x001EC731
		// (set) Token: 0x0601506F RID: 86127 RVA: 0x001EE545 File Offset: 0x001EC745
		public unsafe string TransmitterSender
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_TransmitterSender)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_TransmitterSender)), value);
			}
		}

		// Token: 0x17005334 RID: 21300
		// (get) Token: 0x06015070 RID: 86128 RVA: 0x001EE55A File Offset: 0x001EC75A
		// (set) Token: 0x06015071 RID: 86129 RVA: 0x001EE56E File Offset: 0x001EC76E
		public unsafe string TransmitterReceiver
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_TransmitterReceiver)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_TransmitterReceiver)), value);
			}
		}

		// Token: 0x17005335 RID: 21301
		// (get) Token: 0x06015072 RID: 86130 RVA: 0x001EE583 File Offset: 0x001EC783
		// (set) Token: 0x06015073 RID: 86131 RVA: 0x001EE593 File Offset: 0x001EC793
		public unsafe int Timeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_Timeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_Timeout) = value;
			}
		}

		// Token: 0x17005336 RID: 21302
		// (get) Token: 0x06015074 RID: 86132 RVA: 0x001EE5A4 File Offset: 0x001EC7A4
		// (set) Token: 0x06015075 RID: 86133 RVA: 0x001EE5B4 File Offset: 0x001EC7B4
		public unsafe bool UseHackMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_UseHackMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_UseHackMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005337 RID: 21303
		// (get) Token: 0x06015076 RID: 86134 RVA: 0x001EE5C5 File Offset: 0x001EC7C5
		// (set) Token: 0x06015077 RID: 86135 RVA: 0x001EE5D5 File Offset: 0x001EC7D5
		public unsafe bool TestWithFullscreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_TestWithFullscreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_TestWithFullscreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005338 RID: 21304
		// (get) Token: 0x06015078 RID: 86136 RVA: 0x001EE5E6 File Offset: 0x001EC7E6
		// (set) Token: 0x06015079 RID: 86137 RVA: 0x001EE5FA File Offset: 0x001EC7FA
		public unsafe string TsServerAddr
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_TsServerAddr)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_TsServerAddr)), value);
			}
		}

		// Token: 0x17005339 RID: 21305
		// (get) Token: 0x0601507A RID: 86138 RVA: 0x001EE610 File Offset: 0x001EC810
		// (set) Token: 0x0601507B RID: 86139 RVA: 0x001EE653 File Offset: 0x001EC853
		public TMap<string, string> Params
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new TMap<string, string>(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_Params, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Params.CopyAssign(value);
			}
		}

		// Token: 0x1700533A RID: 21306
		// (get) Token: 0x0601507C RID: 86140 RVA: 0x001EE664 File Offset: 0x001EC864
		// (set) Token: 0x0601507D RID: 86141 RVA: 0x001EE6A7 File Offset: 0x001EC8A7
		public TArray<string> Metrics
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Metrics) == null)
				{
					result = (this._Metrics = new TArray<string>(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_Metrics, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Metrics.CopyAssign(value);
			}
		}

		// Token: 0x1700533B RID: 21307
		// (get) Token: 0x0601507E RID: 86142 RVA: 0x001EE6B8 File Offset: 0x001EC8B8
		// (set) Token: 0x0601507F RID: 86143 RVA: 0x001EE6FB File Offset: 0x001EC8FB
		public TArray<FKuroTestExpectation> Expectations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroTestExpectation> result;
				if ((result = this._Expectations) == null)
				{
					result = (this._Expectations = new TArray<FKuroTestExpectation>(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_Expectations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Expectations.CopyAssign(value);
			}
		}

		// Token: 0x1700533C RID: 21308
		// (get) Token: 0x06015080 RID: 86144 RVA: 0x001EE709 File Offset: 0x001EC909
		// (set) Token: 0x06015081 RID: 86145 RVA: 0x001EE71D File Offset: 0x001EC91D
		public unsafe string OutputDir
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_OutputDir)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_OutputDir)), value);
			}
		}

		// Token: 0x1700533D RID: 21309
		// (get) Token: 0x06015082 RID: 86146 RVA: 0x001EE732 File Offset: 0x001EC932
		// (set) Token: 0x06015083 RID: 86147 RVA: 0x001EE742 File Offset: 0x001EC942
		public unsafe bool EnableRecordScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_EnableRecordScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_EnableRecordScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700533E RID: 21310
		// (get) Token: 0x06015084 RID: 86148 RVA: 0x001EE753 File Offset: 0x001EC953
		// (set) Token: 0x06015085 RID: 86149 RVA: 0x001EE763 File Offset: 0x001EC963
		public unsafe bool EnableTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_EnableTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroTestFile.__PropertyOffset_EnableTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700533F RID: 21311
		// (get) Token: 0x06015086 RID: 86150 RVA: 0x001EE774 File Offset: 0x001EC974
		// (set) Token: 0x06015087 RID: 86151 RVA: 0x001EE788 File Offset: 0x001EC988
		public unsafe string RecorderDir
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_RecorderDir)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroTestFile.__PropertyOffset_RecorderDir)), value);
			}
		}

		// Token: 0x06015088 RID: 86152 RVA: 0x001EE79D File Offset: 0x001EC99D
		public FKuroTestFile()
		{
		}

		// Token: 0x06015089 RID: 86153 RVA: 0x001EE7A8 File Offset: 0x001EC9A8
		public FKuroTestFile(string Name, string ModuleName, string Map, string TransmitterSender, string TransmitterReceiver, int Timeout, bool UseHackMode, bool TestWithFullscreen, string TsServerAddr, TMap<string, string> Params, TArray<string> Metrics, TArray<FKuroTestExpectation> Expectations, string OutputDir, bool EnableRecordScreen, bool EnableTrace, string RecorderDir)
		{
			this.Name = Name;
			this.ModuleName = ModuleName;
			this.Map = Map;
			this.TransmitterSender = TransmitterSender;
			this.TransmitterReceiver = TransmitterReceiver;
			this.Timeout = Timeout;
			this.UseHackMode = UseHackMode;
			this.TestWithFullscreen = TestWithFullscreen;
			this.TsServerAddr = TsServerAddr;
			this.Params = Params;
			this.Metrics = Metrics;
			this.Expectations = Expectations;
			this.OutputDir = OutputDir;
			this.EnableRecordScreen = EnableRecordScreen;
			this.EnableTrace = EnableTrace;
			this.RecorderDir = RecorderDir;
		}

		// Token: 0x0601508A RID: 86154 RVA: 0x001EE838 File Offset: 0x001ECA38
		protected override IntPtr GetUStructPtr()
		{
			return FKuroTestFile.StaticStruct();
		}

		// Token: 0x0601508B RID: 86155 RVA: 0x001EE844 File Offset: 0x001ECA44
		[NullableContext(2)]
		public FKuroTestFile(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601508C RID: 86156 RVA: 0x001EE84E File Offset: 0x001ECA4E
		public FKuroTestFile(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601508D RID: 86157 RVA: 0x001EE859 File Offset: 0x001ECA59
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroTestFile(Pointer, false, true);
		}

		// Token: 0x0601508E RID: 86158 RVA: 0x001EE863 File Offset: 0x001ECA63
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroTestFile(Pointer, MemoryOwner);
		}

		// Token: 0x0400B723 RID: 46883
		public const string __ObjectPath = "/Script/KuroAutomationTool.KuroTestFile";

		// Token: 0x0400B724 RID: 46884
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B725 RID: 46885
		internal static int __PropertyOffset_Name;

		// Token: 0x0400B726 RID: 46886
		internal static int __PropertyOffset_ModuleName;

		// Token: 0x0400B727 RID: 46887
		internal static int __PropertyOffset_Map;

		// Token: 0x0400B728 RID: 46888
		internal static int __PropertyOffset_TransmitterSender;

		// Token: 0x0400B729 RID: 46889
		internal static int __PropertyOffset_TransmitterReceiver;

		// Token: 0x0400B72A RID: 46890
		internal static int __PropertyOffset_Timeout;

		// Token: 0x0400B72B RID: 46891
		internal static int __PropertyOffset_UseHackMode;

		// Token: 0x0400B72C RID: 46892
		internal static int __PropertyOffset_TestWithFullscreen;

		// Token: 0x0400B72D RID: 46893
		internal static int __PropertyOffset_TsServerAddr;

		// Token: 0x0400B72E RID: 46894
		internal static int __PropertyOffset_Params;

		// Token: 0x0400B72F RID: 46895
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _Params;

		// Token: 0x0400B730 RID: 46896
		internal static int __PropertyOffset_Metrics;

		// Token: 0x0400B731 RID: 46897
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Metrics;

		// Token: 0x0400B732 RID: 46898
		internal static int __PropertyOffset_Expectations;

		// Token: 0x0400B733 RID: 46899
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroTestExpectation> _Expectations;

		// Token: 0x0400B734 RID: 46900
		internal static int __PropertyOffset_OutputDir;

		// Token: 0x0400B735 RID: 46901
		internal static int __PropertyOffset_EnableRecordScreen;

		// Token: 0x0400B736 RID: 46902
		internal static int __PropertyOffset_EnableTrace;

		// Token: 0x0400B737 RID: 46903
		internal static int __PropertyOffset_RecorderDir;
	}
}
