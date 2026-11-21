using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EF RID: 239
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AssetBundleEntry")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAssetBundleEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060010A7 RID: 4263 RVA: 0x0001A7E5 File Offset: 0x000189E5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetBundleEntry._ScriptStructPtr != 0) ? FAssetBundleEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AssetBundleEntry", ref FAssetBundleEntry._ScriptStructPtr);
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x0001A80C File Offset: 0x00018A0C
		// (set) Token: 0x060010A9 RID: 4265 RVA: 0x0001A84F File Offset: 0x00018A4F
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

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x0001A870 File Offset: 0x00018A70
		// (set) Token: 0x060010AB RID: 4267 RVA: 0x0001A884 File Offset: 0x00018A84
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

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060010AC RID: 4268 RVA: 0x0001A89C File Offset: 0x00018A9C
		// (set) Token: 0x060010AD RID: 4269 RVA: 0x0001A8DF File Offset: 0x00018ADF
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

		// Token: 0x060010AE RID: 4270 RVA: 0x0001A8ED File Offset: 0x00018AED
		public FAssetBundleEntry()
		{
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x0001A8F5 File Offset: 0x00018AF5
		protected override IntPtr GetUStructPtr()
		{
			return FAssetBundleEntry.StaticStruct();
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0001A901 File Offset: 0x00018B01
		[NullableContext(2)]
		public FAssetBundleEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0001A90B File Offset: 0x00018B0B
		public FAssetBundleEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0001A916 File Offset: 0x00018B16
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetBundleEntry(Pointer, false, true);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0001A920 File Offset: 0x00018B20
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetBundleEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04000409 RID: 1033
		public const string __ObjectPath = "/Script/CoreUObject.AssetBundleEntry";

		// Token: 0x0400040A RID: 1034
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400040B RID: 1035
		internal static int __PropertyOffset_BundleScope;

		// Token: 0x0400040C RID: 1036
		[Nullable(2)]
		private FPrimaryAssetId _BundleScope;

		// Token: 0x0400040D RID: 1037
		internal static int __PropertyOffset_BundleName;

		// Token: 0x0400040E RID: 1038
		internal static int __PropertyOffset_BundleAssets;

		// Token: 0x0400040F RID: 1039
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _BundleAssets;
	}
}
