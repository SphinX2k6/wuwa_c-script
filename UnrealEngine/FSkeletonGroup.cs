using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001682 RID: 5762
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.SkeletonGroup")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSkeletonGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E80 RID: 85632 RVA: 0x001EBBE5 File Offset: 0x001E9DE5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletonGroup._ScriptStructPtr != 0) ? FSkeletonGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.SkeletonGroup", ref FSkeletonGroup._ScriptStructPtr);
		}

		// Token: 0x170052D4 RID: 21204
		// (get) Token: 0x06014E81 RID: 85633 RVA: 0x001EBC0C File Offset: 0x001E9E0C
		// (set) Token: 0x06014E82 RID: 85634 RVA: 0x001EBC4F File Offset: 0x001E9E4F
		public TArray<FBoneBlock> Blocks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneBlock> result;
				if ((result = this._Blocks) == null)
				{
					result = (this._Blocks = new TArray<FBoneBlock>(base.NativePtr + (IntPtr)FSkeletonGroup.__PropertyOffset_Blocks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Blocks.CopyAssign(value);
			}
		}

		// Token: 0x170052D5 RID: 21205
		// (get) Token: 0x06014E83 RID: 85635 RVA: 0x001EBC60 File Offset: 0x001E9E60
		// (set) Token: 0x06014E84 RID: 85636 RVA: 0x001EBCA3 File Offset: 0x001E9EA3
		public TArray<FSpecialBoneShakeData> SpeicalBoneShakeData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpecialBoneShakeData> result;
				if ((result = this._SpeicalBoneShakeData) == null)
				{
					result = (this._SpeicalBoneShakeData = new TArray<FSpecialBoneShakeData>(base.NativePtr + (IntPtr)FSkeletonGroup.__PropertyOffset_SpeicalBoneShakeData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpeicalBoneShakeData.CopyAssign(value);
			}
		}

		// Token: 0x06014E85 RID: 85637 RVA: 0x001EBCB1 File Offset: 0x001E9EB1
		public FSkeletonGroup()
		{
		}

		// Token: 0x06014E86 RID: 85638 RVA: 0x001EBCB9 File Offset: 0x001E9EB9
		public FSkeletonGroup(TArray<FBoneBlock> Blocks, TArray<FSpecialBoneShakeData> SpeicalBoneShakeData)
		{
			this.Blocks = Blocks;
			this.SpeicalBoneShakeData = SpeicalBoneShakeData;
		}

		// Token: 0x06014E87 RID: 85639 RVA: 0x001EBCCF File Offset: 0x001E9ECF
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletonGroup.StaticStruct();
		}

		// Token: 0x06014E88 RID: 85640 RVA: 0x001EBCDB File Offset: 0x001E9EDB
		[NullableContext(2)]
		public FSkeletonGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E89 RID: 85641 RVA: 0x001EBCE5 File Offset: 0x001E9EE5
		public FSkeletonGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E8A RID: 85642 RVA: 0x001EBCF0 File Offset: 0x001E9EF0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletonGroup(Pointer, false, true);
		}

		// Token: 0x06014E8B RID: 85643 RVA: 0x001EBCFA File Offset: 0x001E9EFA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletonGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400B642 RID: 46658
		public const string __ObjectPath = "/Script/KuroAnim.SkeletonGroup";

		// Token: 0x0400B643 RID: 46659
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B644 RID: 46660
		internal static int __PropertyOffset_Blocks;

		// Token: 0x0400B645 RID: 46661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneBlock> _Blocks;

		// Token: 0x0400B646 RID: 46662
		internal static int __PropertyOffset_SpeicalBoneShakeData;

		// Token: 0x0400B647 RID: 46663
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpecialBoneShakeData> _SpeicalBoneShakeData;
	}
}
