using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000704 RID: 1796
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AssetBundleEntry")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAssetBundleEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600613C RID: 24892 RVA: 0x0008B6B4 File Offset: 0x000898B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetBundleEntry._ScriptStructPtr != 0) ? FAssetBundleEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AssetBundleEntry", ref FAssetBundleEntry._ScriptStructPtr);
		}

		// Token: 0x1700176E RID: 5998
		// (get) Token: 0x0600613D RID: 24893 RVA: 0x0008B6D8 File Offset: 0x000898D8
		// (set) Token: 0x0600613E RID: 24894 RVA: 0x0008B71B File Offset: 0x0008991B
		public FPrimaryAssetId BundleScope
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetId result;
				if ((result = this._BundleScope) == null)
				{
					result = (this._BundleScope = new FPrimaryAssetId(base.NativePtr + (IntPtr)FAssetBundleEntry.__PropertyOffset_BundleScope, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetId.StaticStruct(), base.NativePtr + (IntPtr)FAssetBundleEntry.__PropertyOffset_BundleScope, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x0600613F RID: 24895 RVA: 0x0008B73C File Offset: 0x0008993C
		// (set) Token: 0x06006140 RID: 24896 RVA: 0x0008B750 File Offset: 0x00089950
		public unsafe FName BundleName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAssetBundleEntry.__PropertyOffset_BundleName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAssetBundleEntry.__PropertyOffset_BundleName) = value;
			}
		}

		// Token: 0x17001770 RID: 6000
		// (get) Token: 0x06006141 RID: 24897 RVA: 0x0008B768 File Offset: 0x00089968
		// (set) Token: 0x06006142 RID: 24898 RVA: 0x0008B7AB File Offset: 0x000899AB
		public TArray<FSoftObjectPath> BundleAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._BundleAssets) == null)
				{
					result = (this._BundleAssets = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)FAssetBundleEntry.__PropertyOffset_BundleAssets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BundleAssets.CopyAssign(value);
			}
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0008B7B9 File Offset: 0x000899B9
		public FAssetBundleEntry()
		{
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x0008B7C1 File Offset: 0x000899C1
		public FAssetBundleEntry(FPrimaryAssetId BundleScope, FName BundleName, TArray<FSoftObjectPath> BundleAssets)
		{
			this.BundleScope = BundleScope;
			this.BundleName = BundleName;
			this.BundleAssets = BundleAssets;
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x0008B7DE File Offset: 0x000899DE
		protected override IntPtr GetUStructPtr()
		{
			return FAssetBundleEntry.StaticStruct();
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x0008B7EA File Offset: 0x000899EA
		[NullableContext(2)]
		public FAssetBundleEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x0008B7F4 File Offset: 0x000899F4
		public FAssetBundleEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x0008B7FF File Offset: 0x000899FF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetBundleEntry(Pointer, false, true);
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x0008B809 File Offset: 0x00089A09
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetBundleEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04002D7A RID: 11642
		public const string __ObjectPath = "/Script/CoreUObject.AssetBundleEntry";

		// Token: 0x04002D7B RID: 11643
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D7C RID: 11644
		internal static int __PropertyOffset_BundleScope;

		// Token: 0x04002D7D RID: 11645
		[Nullable(2)]
		private FPrimaryAssetId _BundleScope;

		// Token: 0x04002D7E RID: 11646
		internal static int __PropertyOffset_BundleName;

		// Token: 0x04002D7F RID: 11647
		internal static int __PropertyOffset_BundleAssets;

		// Token: 0x04002D80 RID: 11648
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _BundleAssets;
	}
}
