using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000703 RID: 1795
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AssetBundleData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAssetBundleData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006132 RID: 24882 RVA: 0x0008B5F2 File Offset: 0x000897F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetBundleData._ScriptStructPtr != 0) ? FAssetBundleData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AssetBundleData", ref FAssetBundleData._ScriptStructPtr);
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06006133 RID: 24883 RVA: 0x0008B618 File Offset: 0x00089818
		// (set) Token: 0x06006134 RID: 24884 RVA: 0x0008B65B File Offset: 0x0008985B
		public TArray<FAssetBundleEntry> Bundles
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAssetBundleEntry> result;
				if ((result = this._Bundles) == null)
				{
					result = (this._Bundles = new TArray<FAssetBundleEntry>(base.NativePtr + (IntPtr)FAssetBundleData.__PropertyOffset_Bundles, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Bundles.CopyAssign(value);
			}
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x0008B669 File Offset: 0x00089869
		public FAssetBundleData()
		{
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x0008B671 File Offset: 0x00089871
		public FAssetBundleData(TArray<FAssetBundleEntry> Bundles)
		{
			this.Bundles = Bundles;
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x0008B680 File Offset: 0x00089880
		protected override IntPtr GetUStructPtr()
		{
			return FAssetBundleData.StaticStruct();
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x0008B68C File Offset: 0x0008988C
		[NullableContext(2)]
		public FAssetBundleData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x0008B696 File Offset: 0x00089896
		public FAssetBundleData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x0008B6A1 File Offset: 0x000898A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetBundleData(Pointer, false, true);
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x0008B6AB File Offset: 0x000898AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetBundleData(Pointer, MemoryOwner);
		}

		// Token: 0x04002D76 RID: 11638
		public const string __ObjectPath = "/Script/CoreUObject.AssetBundleData";

		// Token: 0x04002D77 RID: 11639
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D78 RID: 11640
		internal static int __PropertyOffset_Bundles;

		// Token: 0x04002D79 RID: 11641
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetBundleEntry> _Bundles;
	}
}
