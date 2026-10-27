using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001986 RID: 6534
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroHotPatch.KuroCheckInfoEntry")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroCheckInfoEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018447 RID: 99399 RVA: 0x0023CC43 File Offset: 0x0023AE43
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCheckInfoEntry._ScriptStructPtr != 0) ? FKuroCheckInfoEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroHotPatch.KuroCheckInfoEntry", ref FKuroCheckInfoEntry._ScriptStructPtr);
		}

		// Token: 0x17006108 RID: 24840
		// (get) Token: 0x06018448 RID: 99400 RVA: 0x0023CC67 File Offset: 0x0023AE67
		// (set) Token: 0x06018449 RID: 99401 RVA: 0x0023CC7B File Offset: 0x0023AE7B
		public unsafe string FileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FileName)), value);
			}
		}

		// Token: 0x17006109 RID: 24841
		// (get) Token: 0x0601844A RID: 99402 RVA: 0x0023CC90 File Offset: 0x0023AE90
		// (set) Token: 0x0601844B RID: 99403 RVA: 0x0023CCA4 File Offset: 0x0023AEA4
		public unsafe string FilePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FilePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_FilePath)), value);
			}
		}

		// Token: 0x1700610A RID: 24842
		// (get) Token: 0x0601844C RID: 99404 RVA: 0x0023CCB9 File Offset: 0x0023AEB9
		// (set) Token: 0x0601844D RID: 99405 RVA: 0x0023CCCD File Offset: 0x0023AECD
		public unsafe string Hash
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Hash)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Hash)), value);
			}
		}

		// Token: 0x1700610B RID: 24843
		// (get) Token: 0x0601844E RID: 99406 RVA: 0x0023CCE2 File Offset: 0x0023AEE2
		// (set) Token: 0x0601844F RID: 99407 RVA: 0x0023CCF2 File Offset: 0x0023AEF2
		public unsafe long Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x1700610C RID: 24844
		// (get) Token: 0x06018450 RID: 99408 RVA: 0x0023CD03 File Offset: 0x0023AF03
		// (set) Token: 0x06018451 RID: 99409 RVA: 0x0023CD17 File Offset: 0x0023AF17
		public unsafe string Url
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Url)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Url)), value);
			}
		}

		// Token: 0x1700610D RID: 24845
		// (get) Token: 0x06018452 RID: 99410 RVA: 0x0023CD2C File Offset: 0x0023AF2C
		// (set) Token: 0x06018453 RID: 99411 RVA: 0x0023CD3C File Offset: 0x0023AF3C
		public unsafe bool NeedRestart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_NeedRestart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_NeedRestart) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700610E RID: 24846
		// (get) Token: 0x06018454 RID: 99412 RVA: 0x0023CD4D File Offset: 0x0023AF4D
		// (set) Token: 0x06018455 RID: 99413 RVA: 0x0023CD5D File Offset: 0x0023AF5D
		public unsafe int Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCheckInfoEntry.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06018456 RID: 99414 RVA: 0x0023CD6E File Offset: 0x0023AF6E
		public FKuroCheckInfoEntry()
		{
		}

		// Token: 0x06018457 RID: 99415 RVA: 0x0023CD76 File Offset: 0x0023AF76
		public FKuroCheckInfoEntry(string FileName, string FilePath, string Hash, long Size, string Url, bool NeedRestart, int Result)
		{
			this.FileName = FileName;
			this.FilePath = FilePath;
			this.Hash = Hash;
			this.Size = Size;
			this.Url = Url;
			this.NeedRestart = NeedRestart;
			this.Result = Result;
		}

		// Token: 0x06018458 RID: 99416 RVA: 0x0023CDB3 File Offset: 0x0023AFB3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCheckInfoEntry.StaticStruct();
		}

		// Token: 0x06018459 RID: 99417 RVA: 0x0023CDBF File Offset: 0x0023AFBF
		[NullableContext(2)]
		public FKuroCheckInfoEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601845A RID: 99418 RVA: 0x0023CDC9 File Offset: 0x0023AFC9
		public FKuroCheckInfoEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601845B RID: 99419 RVA: 0x0023CDD4 File Offset: 0x0023AFD4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCheckInfoEntry(Pointer, false, true);
		}

		// Token: 0x0601845C RID: 99420 RVA: 0x0023CDDE File Offset: 0x0023AFDE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCheckInfoEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400D245 RID: 53829
		public const string __ObjectPath = "/Script/KuroHotPatch.KuroCheckInfoEntry";

		// Token: 0x0400D246 RID: 53830
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D247 RID: 53831
		internal static int __PropertyOffset_FileName;

		// Token: 0x0400D248 RID: 53832
		internal static int __PropertyOffset_FilePath;

		// Token: 0x0400D249 RID: 53833
		internal static int __PropertyOffset_Hash;

		// Token: 0x0400D24A RID: 53834
		internal static int __PropertyOffset_Size;

		// Token: 0x0400D24B RID: 53835
		internal static int __PropertyOffset_Url;

		// Token: 0x0400D24C RID: 53836
		internal static int __PropertyOffset_NeedRestart;

		// Token: 0x0400D24D RID: 53837
		internal static int __PropertyOffset_Result;
	}
}
