using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001038 RID: 4152
	[UnrealObjectPath("/Script/Engine.PrimaryAssetRules")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FPrimaryAssetRules : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E989 RID: 59785 RVA: 0x0015AF31 File Offset: 0x00159131
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetRules._ScriptStructPtr != 0) ? FPrimaryAssetRules._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrimaryAssetRules", ref FPrimaryAssetRules._ScriptStructPtr);
		}

		// Token: 0x1700388D RID: 14477
		// (get) Token: 0x0600E98A RID: 59786 RVA: 0x0015AF55 File Offset: 0x00159155
		// (set) Token: 0x0600E98B RID: 59787 RVA: 0x0015AF65 File Offset: 0x00159165
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x1700388E RID: 14478
		// (get) Token: 0x0600E98C RID: 59788 RVA: 0x0015AF76 File Offset: 0x00159176
		// (set) Token: 0x0600E98D RID: 59789 RVA: 0x0015AF86 File Offset: 0x00159186
		public unsafe int ChunkId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_ChunkId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_ChunkId) = value;
			}
		}

		// Token: 0x1700388F RID: 14479
		// (get) Token: 0x0600E98E RID: 59790 RVA: 0x0015AF97 File Offset: 0x00159197
		// (set) Token: 0x0600E98F RID: 59791 RVA: 0x0015AFA7 File Offset: 0x001591A7
		public unsafe bool bApplyRecursively
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_bApplyRecursively) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_bApplyRecursively) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600E990 RID: 59792 RVA: 0x0015AFB8 File Offset: 0x001591B8
		// (set) Token: 0x0600E991 RID: 59793 RVA: 0x0015AFC8 File Offset: 0x001591C8
		public unsafe EPrimaryAssetCookRule CookRule
		{
			get
			{
				return (EPrimaryAssetCookRule)(*(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_CookRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetRules.__PropertyOffset_CookRule) = (byte)value;
			}
		}

		// Token: 0x0600E992 RID: 59794 RVA: 0x0015AFD9 File Offset: 0x001591D9
		public FPrimaryAssetRules()
		{
		}

		// Token: 0x0600E993 RID: 59795 RVA: 0x0015AFE1 File Offset: 0x001591E1
		public FPrimaryAssetRules(int Priority, int ChunkId, bool bApplyRecursively, EPrimaryAssetCookRule CookRule)
		{
			this.Priority = Priority;
			this.ChunkId = ChunkId;
			this.bApplyRecursively = bApplyRecursively;
			this.CookRule = CookRule;
		}

		// Token: 0x0600E994 RID: 59796 RVA: 0x0015B006 File Offset: 0x00159206
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetRules.StaticStruct();
		}

		// Token: 0x0600E995 RID: 59797 RVA: 0x0015B012 File Offset: 0x00159212
		[NullableContext(2)]
		public FPrimaryAssetRules(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E996 RID: 59798 RVA: 0x0015B01C File Offset: 0x0015921C
		public FPrimaryAssetRules(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E997 RID: 59799 RVA: 0x0015B027 File Offset: 0x00159227
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetRules(Pointer, false, true);
		}

		// Token: 0x0600E998 RID: 59800 RVA: 0x0015B031 File Offset: 0x00159231
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetRules(Pointer, MemoryOwner);
		}

		// Token: 0x04007EC9 RID: 32457
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PrimaryAssetRules";

		// Token: 0x04007ECA RID: 32458
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007ECB RID: 32459
		internal static int __PropertyOffset_Priority;

		// Token: 0x04007ECC RID: 32460
		internal static int __PropertyOffset_ChunkId;

		// Token: 0x04007ECD RID: 32461
		internal static int __PropertyOffset_bApplyRecursively;

		// Token: 0x04007ECE RID: 32462
		internal static int __PropertyOffset_CookRule;
	}
}
