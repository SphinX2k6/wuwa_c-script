using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C2A RID: 3114
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODBuildInputReferencedAssets")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FHLODBuildInputReferencedAssets : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009DFB RID: 40443 RVA: 0x000E0902 File Offset: 0x000DEB02
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODBuildInputReferencedAssets._ScriptStructPtr != 0) ? FHLODBuildInputReferencedAssets._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODBuildInputReferencedAssets", ref FHLODBuildInputReferencedAssets._ScriptStructPtr);
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x06009DFC RID: 40444 RVA: 0x000E0928 File Offset: 0x000DEB28
		// (set) Token: 0x06009DFD RID: 40445 RVA: 0x000E096B File Offset: 0x000DEB6B
		public TMap<FTopLevelAssetPath, uint> StaticMeshes
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FTopLevelAssetPath, uint> result;
				if ((result = this._StaticMeshes) == null)
				{
					result = (this._StaticMeshes = new TMap<FTopLevelAssetPath, uint>(base.NativePtr + (IntPtr)FHLODBuildInputReferencedAssets.__PropertyOffset_StaticMeshes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticMeshes.CopyAssign(value);
			}
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x000E0979 File Offset: 0x000DEB79
		public FHLODBuildInputReferencedAssets()
		{
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x000E0981 File Offset: 0x000DEB81
		public FHLODBuildInputReferencedAssets(TMap<FTopLevelAssetPath, uint> StaticMeshes)
		{
			this.StaticMeshes = StaticMeshes;
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x000E0990 File Offset: 0x000DEB90
		protected override IntPtr GetUStructPtr()
		{
			return FHLODBuildInputReferencedAssets.StaticStruct();
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x000E099C File Offset: 0x000DEB9C
		[NullableContext(2)]
		public FHLODBuildInputReferencedAssets(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x000E09A6 File Offset: 0x000DEBA6
		public FHLODBuildInputReferencedAssets(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x000E09B1 File Offset: 0x000DEBB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODBuildInputReferencedAssets(Pointer, false, true);
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x000E09BB File Offset: 0x000DEBBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODBuildInputReferencedAssets(Pointer, MemoryOwner);
		}

		// Token: 0x0400571D RID: 22301
		public const string __ObjectPath = "/Script/Engine.HLODBuildInputReferencedAssets";

		// Token: 0x0400571E RID: 22302
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400571F RID: 22303
		internal static int __PropertyOffset_StaticMeshes;

		// Token: 0x04005720 RID: 22304
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FTopLevelAssetPath, uint> _StaticMeshes;
	}
}
