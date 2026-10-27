using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200094D RID: 2381
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CompilerNativizationOptions")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FCompilerNativizationOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060086DC RID: 34524 RVA: 0x000C0429 File Offset: 0x000BE629
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompilerNativizationOptions._ScriptStructPtr != 0) ? FCompilerNativizationOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CompilerNativizationOptions", ref FCompilerNativizationOptions._ScriptStructPtr);
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x060086DD RID: 34525 RVA: 0x000C044D File Offset: 0x000BE64D
		// (set) Token: 0x060086DE RID: 34526 RVA: 0x000C0461 File Offset: 0x000BE661
		public unsafe FName PlatformName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_PlatformName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_PlatformName) = value;
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x060086DF RID: 34527 RVA: 0x000C0476 File Offset: 0x000BE676
		// (set) Token: 0x060086E0 RID: 34528 RVA: 0x000C0486 File Offset: 0x000BE686
		public unsafe bool ServerOnlyPlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_ServerOnlyPlatform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_ServerOnlyPlatform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x060086E1 RID: 34529 RVA: 0x000C0497 File Offset: 0x000BE697
		// (set) Token: 0x060086E2 RID: 34530 RVA: 0x000C04A7 File Offset: 0x000BE6A7
		public unsafe bool ClientOnlyPlatform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_ClientOnlyPlatform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_ClientOnlyPlatform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x060086E3 RID: 34531 RVA: 0x000C04B8 File Offset: 0x000BE6B8
		// (set) Token: 0x060086E4 RID: 34532 RVA: 0x000C04C8 File Offset: 0x000BE6C8
		public unsafe bool bExcludeMonolithicHeaders
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_bExcludeMonolithicHeaders) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_bExcludeMonolithicHeaders) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x060086E5 RID: 34533 RVA: 0x000C04DC File Offset: 0x000BE6DC
		// (set) Token: 0x060086E6 RID: 34534 RVA: 0x000C051F File Offset: 0x000BE71F
		public TArray<FName> ExcludedModules
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._ExcludedModules) == null)
				{
					result = (this._ExcludedModules = new TArray<FName>(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_ExcludedModules, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExcludedModules.CopyAssign(value);
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x060086E7 RID: 34535 RVA: 0x000C0530 File Offset: 0x000BE730
		// (set) Token: 0x060086E8 RID: 34536 RVA: 0x000C0573 File Offset: 0x000BE773
		public TSet<FSoftObjectPath> ExcludedAssets
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FSoftObjectPath> result;
				if ((result = this._ExcludedAssets) == null)
				{
					result = (this._ExcludedAssets = new TSet<FSoftObjectPath>(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_ExcludedAssets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExcludedAssets.CopyAssign(value);
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x060086E9 RID: 34537 RVA: 0x000C0584 File Offset: 0x000BE784
		// (set) Token: 0x060086EA RID: 34538 RVA: 0x000C05C7 File Offset: 0x000BE7C7
		public TArray<string> ExcludedFolderPaths
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._ExcludedFolderPaths) == null)
				{
					result = (this._ExcludedFolderPaths = new TArray<string>(base.NativePtr + (IntPtr)FCompilerNativizationOptions.__PropertyOffset_ExcludedFolderPaths, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExcludedFolderPaths.CopyAssign(value);
			}
		}

		// Token: 0x060086EB RID: 34539 RVA: 0x000C05D5 File Offset: 0x000BE7D5
		public FCompilerNativizationOptions()
		{
		}

		// Token: 0x060086EC RID: 34540 RVA: 0x000C05DD File Offset: 0x000BE7DD
		public FCompilerNativizationOptions(FName PlatformName, bool ServerOnlyPlatform, bool ClientOnlyPlatform, bool bExcludeMonolithicHeaders, TArray<FName> ExcludedModules, TSet<FSoftObjectPath> ExcludedAssets, TArray<string> ExcludedFolderPaths)
		{
			this.PlatformName = PlatformName;
			this.ServerOnlyPlatform = ServerOnlyPlatform;
			this.ClientOnlyPlatform = ClientOnlyPlatform;
			this.bExcludeMonolithicHeaders = bExcludeMonolithicHeaders;
			this.ExcludedModules = ExcludedModules;
			this.ExcludedAssets = ExcludedAssets;
			this.ExcludedFolderPaths = ExcludedFolderPaths;
		}

		// Token: 0x060086ED RID: 34541 RVA: 0x000C061A File Offset: 0x000BE81A
		protected override IntPtr GetUStructPtr()
		{
			return FCompilerNativizationOptions.StaticStruct();
		}

		// Token: 0x060086EE RID: 34542 RVA: 0x000C0626 File Offset: 0x000BE826
		[NullableContext(2)]
		public FCompilerNativizationOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060086EF RID: 34543 RVA: 0x000C0630 File Offset: 0x000BE830
		public FCompilerNativizationOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060086F0 RID: 34544 RVA: 0x000C063B File Offset: 0x000BE83B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompilerNativizationOptions(Pointer, false, true);
		}

		// Token: 0x060086F1 RID: 34545 RVA: 0x000C0645 File Offset: 0x000BE845
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompilerNativizationOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04004031 RID: 16433
		public const string __ObjectPath = "/Script/Engine.CompilerNativizationOptions";

		// Token: 0x04004032 RID: 16434
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004033 RID: 16435
		internal static int __PropertyOffset_PlatformName;

		// Token: 0x04004034 RID: 16436
		internal static int __PropertyOffset_ServerOnlyPlatform;

		// Token: 0x04004035 RID: 16437
		internal static int __PropertyOffset_ClientOnlyPlatform;

		// Token: 0x04004036 RID: 16438
		internal static int __PropertyOffset_bExcludeMonolithicHeaders;

		// Token: 0x04004037 RID: 16439
		internal static int __PropertyOffset_ExcludedModules;

		// Token: 0x04004038 RID: 16440
		[Nullable(2)]
		private TArray<FName> _ExcludedModules;

		// Token: 0x04004039 RID: 16441
		internal static int __PropertyOffset_ExcludedAssets;

		// Token: 0x0400403A RID: 16442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FSoftObjectPath> _ExcludedAssets;

		// Token: 0x0400403B RID: 16443
		internal static int __PropertyOffset_ExcludedFolderPaths;

		// Token: 0x0400403C RID: 16444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _ExcludedFolderPaths;
	}
}
