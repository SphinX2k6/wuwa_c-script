using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008D3 RID: 2259
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BoneFolders")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBoneFolders : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C4A RID: 31818 RVA: 0x000B24B4 File Offset: 0x000B06B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFolders._ScriptStructPtr != 0) ? FBoneFolders._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneFolders", ref FBoneFolders._ScriptStructPtr);
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06007C4B RID: 31819 RVA: 0x000B24D8 File Offset: 0x000B06D8
		// (set) Token: 0x06007C4C RID: 31820 RVA: 0x000B251B File Offset: 0x000B071B
		public TArray<FBoneFoldItem> BoneFoldItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneFoldItem> result;
				if ((result = this._BoneFoldItems) == null)
				{
					result = (this._BoneFoldItems = new TArray<FBoneFoldItem>(base.NativePtr + (IntPtr)FBoneFolders.__PropertyOffset_BoneFoldItems, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneFoldItems.CopyAssign(value);
			}
		}

		// Token: 0x06007C4D RID: 31821 RVA: 0x000B2529 File Offset: 0x000B0729
		public FBoneFolders()
		{
		}

		// Token: 0x06007C4E RID: 31822 RVA: 0x000B2531 File Offset: 0x000B0731
		public FBoneFolders(TArray<FBoneFoldItem> BoneFoldItems)
		{
			this.BoneFoldItems = BoneFoldItems;
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x000B2540 File Offset: 0x000B0740
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFolders.StaticStruct();
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x000B254C File Offset: 0x000B074C
		[NullableContext(2)]
		public FBoneFolders(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x000B2556 File Offset: 0x000B0756
		public FBoneFolders(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x000B2561 File Offset: 0x000B0761
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFolders(Pointer, false, true);
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x000B256B File Offset: 0x000B076B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFolders(Pointer, MemoryOwner);
		}

		// Token: 0x04003B95 RID: 15253
		public const string __ObjectPath = "/Script/Engine.BoneFolders";

		// Token: 0x04003B96 RID: 15254
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B97 RID: 15255
		internal static int __PropertyOffset_BoneFoldItems;

		// Token: 0x04003B98 RID: 15256
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneFoldItem> _BoneFoldItems;
	}
}
