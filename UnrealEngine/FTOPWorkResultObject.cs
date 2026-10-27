using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200150D RID: 5389
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.TOPWorkResultObject")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FTOPWorkResultObject : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060139CD RID: 80333 RVA: 0x001CCE3A File Offset: 0x001CB03A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTOPWorkResultObject._ScriptStructPtr != 0) ? FTOPWorkResultObject._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.TOPWorkResultObject", ref FTOPWorkResultObject._ScriptStructPtr);
		}

		// Token: 0x17004CD7 RID: 19671
		// (get) Token: 0x060139CE RID: 80334 RVA: 0x001CCE5E File Offset: 0x001CB05E
		// (set) Token: 0x060139CF RID: 80335 RVA: 0x001CCE72 File Offset: 0x001CB072
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTOPWorkResultObject.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTOPWorkResultObject.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x17004CD8 RID: 19672
		// (get) Token: 0x060139D0 RID: 80336 RVA: 0x001CCE87 File Offset: 0x001CB087
		// (set) Token: 0x060139D1 RID: 80337 RVA: 0x001CCE9B File Offset: 0x001CB09B
		public unsafe string FilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTOPWorkResultObject.__PropertyOffset_FilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTOPWorkResultObject.__PropertyOffset_FilePath)), value);
			}
		}

		// Token: 0x17004CD9 RID: 19673
		// (get) Token: 0x060139D2 RID: 80338 RVA: 0x001CCEB0 File Offset: 0x001CB0B0
		// (set) Token: 0x060139D3 RID: 80339 RVA: 0x001CCEC0 File Offset: 0x001CB0C0
		public unsafe EPDGWorkResultState State
		{
			get
			{
				return (EPDGWorkResultState)(*(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_State));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_State) = (byte)value;
			}
		}

		// Token: 0x17004CDA RID: 19674
		// (get) Token: 0x060139D4 RID: 80340 RVA: 0x001CCED1 File Offset: 0x001CB0D1
		// (set) Token: 0x060139D5 RID: 80341 RVA: 0x001CCEE1 File Offset: 0x001CB0E1
		public unsafe int WorkItemResultInfoIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_WorkItemResultInfoIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_WorkItemResultInfoIndex) = value;
			}
		}

		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x060139D6 RID: 80342 RVA: 0x001CCEF4 File Offset: 0x001CB0F4
		// (set) Token: 0x060139D7 RID: 80343 RVA: 0x001CCF37 File Offset: 0x001CB137
		public TArray<UHoudiniOutput> ResultOutputs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniOutput> result;
				if ((result = this._ResultOutputs) == null)
				{
					result = (this._ResultOutputs = new TArray<UHoudiniOutput>(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_ResultOutputs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ResultOutputs.CopyAssign(value);
			}
		}

		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x060139D8 RID: 80344 RVA: 0x001CCF45 File Offset: 0x001CB145
		// (set) Token: 0x060139D9 RID: 80345 RVA: 0x001CCF55 File Offset: 0x001CB155
		public unsafe bool bAutoBakedSinceLastLoad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_bAutoBakedSinceLastLoad) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_bAutoBakedSinceLastLoad) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x060139DA RID: 80346 RVA: 0x001CCF68 File Offset: 0x001CB168
		// (set) Token: 0x060139DB RID: 80347 RVA: 0x001CCFAB File Offset: 0x001CB1AB
		public FOutputActorOwner OutputActorOwner
		{
			get
			{
				base.FastCheckIsValid();
				FOutputActorOwner result;
				if ((result = this._OutputActorOwner) == null)
				{
					result = (this._OutputActorOwner = new FOutputActorOwner(base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_OutputActorOwner, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOutputActorOwner.StaticStruct(), base.NativePtr + (IntPtr)FTOPWorkResultObject.__PropertyOffset_OutputActorOwner, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060139DC RID: 80348 RVA: 0x001CCFCC File Offset: 0x001CB1CC
		public FTOPWorkResultObject()
		{
		}

		// Token: 0x060139DD RID: 80349 RVA: 0x001CCFD4 File Offset: 0x001CB1D4
		public FTOPWorkResultObject(string Name, string FilePath, EPDGWorkResultState State, int WorkItemResultInfoIndex, TArray<UHoudiniOutput> ResultOutputs, bool bAutoBakedSinceLastLoad, FOutputActorOwner OutputActorOwner)
		{
			this.Name = Name;
			this.FilePath = FilePath;
			this.State = State;
			this.WorkItemResultInfoIndex = WorkItemResultInfoIndex;
			this.ResultOutputs = ResultOutputs;
			this.bAutoBakedSinceLastLoad = bAutoBakedSinceLastLoad;
			this.OutputActorOwner = OutputActorOwner;
		}

		// Token: 0x060139DE RID: 80350 RVA: 0x001CD011 File Offset: 0x001CB211
		protected override IntPtr GetUStructPtr()
		{
			return FTOPWorkResultObject.StaticStruct();
		}

		// Token: 0x060139DF RID: 80351 RVA: 0x001CD01D File Offset: 0x001CB21D
		[NullableContext(2)]
		public FTOPWorkResultObject(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060139E0 RID: 80352 RVA: 0x001CD027 File Offset: 0x001CB227
		public FTOPWorkResultObject(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060139E1 RID: 80353 RVA: 0x001CD032 File Offset: 0x001CB232
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTOPWorkResultObject(Pointer, false, true);
		}

		// Token: 0x060139E2 RID: 80354 RVA: 0x001CD03C File Offset: 0x001CB23C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTOPWorkResultObject(Pointer, MemoryOwner);
		}

		// Token: 0x0400A980 RID: 43392
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.TOPWorkResultObject";

		// Token: 0x0400A981 RID: 43393
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A982 RID: 43394
		internal static int __PropertyOffset_Name;

		// Token: 0x0400A983 RID: 43395
		internal static int __PropertyOffset_FilePath;

		// Token: 0x0400A984 RID: 43396
		internal static int __PropertyOffset_State;

		// Token: 0x0400A985 RID: 43397
		internal static int __PropertyOffset_WorkItemResultInfoIndex;

		// Token: 0x0400A986 RID: 43398
		internal static int __PropertyOffset_ResultOutputs;

		// Token: 0x0400A987 RID: 43399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniOutput> _ResultOutputs;

		// Token: 0x0400A988 RID: 43400
		internal static int __PropertyOffset_bAutoBakedSinceLastLoad;

		// Token: 0x0400A989 RID: 43401
		internal static int __PropertyOffset_OutputActorOwner;

		// Token: 0x0400A98A RID: 43402
		[Nullable(2)]
		private FOutputActorOwner _OutputActorOwner;
	}
}
