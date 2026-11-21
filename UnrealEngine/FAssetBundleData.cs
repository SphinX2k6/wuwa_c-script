using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000EE RID: 238
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.AssetBundleData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAssetBundleData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600109E RID: 4254 RVA: 0x0001A732 File Offset: 0x00018932
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAssetBundleData._ScriptStructPtr != 0) ? FAssetBundleData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.AssetBundleData", ref FAssetBundleData._ScriptStructPtr);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x0001A758 File Offset: 0x00018958
		// (set) Token: 0x060010A0 RID: 4256 RVA: 0x0001A79B File Offset: 0x0001899B
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

		// Token: 0x060010A1 RID: 4257 RVA: 0x0001A7A9 File Offset: 0x000189A9
		public FAssetBundleData()
		{
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0001A7B1 File Offset: 0x000189B1
		protected override IntPtr GetUStructPtr()
		{
			return FAssetBundleData.StaticStruct();
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x0001A7BD File Offset: 0x000189BD
		[NullableContext(2)]
		public FAssetBundleData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x0001A7C7 File Offset: 0x000189C7
		public FAssetBundleData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0001A7D2 File Offset: 0x000189D2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAssetBundleData(Pointer, false, true);
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x0001A7DC File Offset: 0x000189DC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAssetBundleData(Pointer, MemoryOwner);
		}

		// Token: 0x04000405 RID: 1029
		public const string __ObjectPath = "/Script/CoreUObject.AssetBundleData";

		// Token: 0x04000406 RID: 1030
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000407 RID: 1031
		internal static int __PropertyOffset_Bundles;

		// Token: 0x04000408 RID: 1032
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAssetBundleEntry> _Bundles;
	}
}
