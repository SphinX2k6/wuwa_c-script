using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008D5 RID: 2261
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneFoldLayer")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBoneFoldLayer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C60 RID: 31840 RVA: 0x000B265F File Offset: 0x000B085F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFoldLayer._ScriptStructPtr != 0) ? FBoneFoldLayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneFoldLayer", ref FBoneFoldLayer._ScriptStructPtr);
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06007C61 RID: 31841 RVA: 0x000B2684 File Offset: 0x000B0884
		// (set) Token: 0x06007C62 RID: 31842 RVA: 0x000B26C7 File Offset: 0x000B08C7
		public FBoneFolders BoneFolders
		{
			get
			{
				base.FastCheckIsValid();
				FBoneFolders result;
				if ((result = this._BoneFolders) == null)
				{
					result = (this._BoneFolders = new FBoneFolders(base.NativePtr + (IntPtr)FBoneFoldLayer.__PropertyOffset_BoneFolders, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneFolders.StaticStruct(), base.NativePtr + (IntPtr)FBoneFoldLayer.__PropertyOffset_BoneFolders, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06007C63 RID: 31843 RVA: 0x000B26E8 File Offset: 0x000B08E8
		// (set) Token: 0x06007C64 RID: 31844 RVA: 0x000B272B File Offset: 0x000B092B
		public TArray<EBoneFoldLODIndex> LODIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EBoneFoldLODIndex> result;
				if ((result = this._LODIndices) == null)
				{
					result = (this._LODIndices = new TArray<EBoneFoldLODIndex>(base.NativePtr + (IntPtr)FBoneFoldLayer.__PropertyOffset_LODIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LODIndices.CopyAssign(value);
			}
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x000B2739 File Offset: 0x000B0939
		public FBoneFoldLayer()
		{
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x000B2741 File Offset: 0x000B0941
		public FBoneFoldLayer(FBoneFolders BoneFolders, TArray<EBoneFoldLODIndex> LODIndices)
		{
			this.BoneFolders = BoneFolders;
			this.LODIndices = LODIndices;
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x000B2757 File Offset: 0x000B0957
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFoldLayer.StaticStruct();
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x000B2763 File Offset: 0x000B0963
		[NullableContext(2)]
		public FBoneFoldLayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x000B276D File Offset: 0x000B096D
		public FBoneFoldLayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x000B2778 File Offset: 0x000B0978
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFoldLayer(Pointer, false, true);
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x000B2782 File Offset: 0x000B0982
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFoldLayer(Pointer, MemoryOwner);
		}

		// Token: 0x04003B9E RID: 15262
		public const string __ObjectPath = "/Script/Engine.BoneFoldLayer";

		// Token: 0x04003B9F RID: 15263
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BA0 RID: 15264
		internal static int __PropertyOffset_BoneFolders;

		// Token: 0x04003BA1 RID: 15265
		[Nullable(2)]
		private FBoneFolders _BoneFolders;

		// Token: 0x04003BA2 RID: 15266
		internal static int __PropertyOffset_LODIndices;

		// Token: 0x04003BA3 RID: 15267
		[Nullable(2)]
		private TArray<EBoneFoldLODIndex> _LODIndices;
	}
}
