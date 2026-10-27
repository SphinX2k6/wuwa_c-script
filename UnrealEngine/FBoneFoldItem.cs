using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008D4 RID: 2260
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneFoldItem")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBoneFoldItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C54 RID: 31828 RVA: 0x000B2574 File Offset: 0x000B0774
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFoldItem._ScriptStructPtr != 0) ? FBoneFoldItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneFoldItem", ref FBoneFoldItem._ScriptStructPtr);
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06007C55 RID: 31829 RVA: 0x000B2598 File Offset: 0x000B0798
		// (set) Token: 0x06007C56 RID: 31830 RVA: 0x000B25A8 File Offset: 0x000B07A8
		public unsafe ushort FolderBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFoldItem.__PropertyOffset_FolderBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFoldItem.__PropertyOffset_FolderBone) = (short)value;
			}
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06007C57 RID: 31831 RVA: 0x000B25BC File Offset: 0x000B07BC
		// (set) Token: 0x06007C58 RID: 31832 RVA: 0x000B25FF File Offset: 0x000B07FF
		public TArray<ushort> FoldedBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ushort> result;
				if ((result = this._FoldedBones) == null)
				{
					result = (this._FoldedBones = new TArray<ushort>(base.NativePtr + (IntPtr)FBoneFoldItem.__PropertyOffset_FoldedBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FoldedBones.CopyAssign(value);
			}
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x000B260D File Offset: 0x000B080D
		public FBoneFoldItem()
		{
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x000B2615 File Offset: 0x000B0815
		public FBoneFoldItem(ushort FolderBone, EBoneFoldMethod BoneFoldMethod, TArray<ushort> FoldedBones)
		{
			this.FolderBone = FolderBone;
			this.FoldedBones = FoldedBones;
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x000B262B File Offset: 0x000B082B
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFoldItem.StaticStruct();
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x000B2637 File Offset: 0x000B0837
		[NullableContext(2)]
		public FBoneFoldItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x000B2641 File Offset: 0x000B0841
		public FBoneFoldItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x000B264C File Offset: 0x000B084C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFoldItem(Pointer, false, true);
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x000B2656 File Offset: 0x000B0856
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFoldItem(Pointer, MemoryOwner);
		}

		// Token: 0x04003B99 RID: 15257
		public const string __ObjectPath = "/Script/Engine.BoneFoldItem";

		// Token: 0x04003B9A RID: 15258
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B9B RID: 15259
		internal static int __PropertyOffset_FolderBone;

		// Token: 0x04003B9C RID: 15260
		internal static int __PropertyOffset_FoldedBones;

		// Token: 0x04003B9D RID: 15261
		[Nullable(2)]
		private TArray<ushort> _FoldedBones;
	}
}
