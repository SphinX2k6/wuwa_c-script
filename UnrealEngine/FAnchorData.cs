using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002935 RID: 10549
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.AnchorData")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAnchorData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027040 RID: 159808 RVA: 0x003B836E File Offset: 0x003B656E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnchorData._ScriptStructPtr != 0) ? FAnchorData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.AnchorData", ref FAnchorData._ScriptStructPtr);
		}

		// Token: 0x17009622 RID: 38434
		// (get) Token: 0x06027041 RID: 159809 RVA: 0x003B8392 File Offset: 0x003B6592
		// (set) Token: 0x06027042 RID: 159810 RVA: 0x003B83A6 File Offset: 0x003B65A6
		public unsafe FMargin Offsets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnchorData.__PropertyOffset_Offsets);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnchorData.__PropertyOffset_Offsets) = value;
			}
		}

		// Token: 0x17009623 RID: 38435
		// (get) Token: 0x06027043 RID: 159811 RVA: 0x003B83BC File Offset: 0x003B65BC
		// (set) Token: 0x06027044 RID: 159812 RVA: 0x003B83FF File Offset: 0x003B65FF
		public FAnchors Anchors
		{
			get
			{
				base.FastCheckIsValid();
				FAnchors result;
				if ((result = this._Anchors) == null)
				{
					result = (this._Anchors = new FAnchors(base.NativePtr + (IntPtr)FAnchorData.__PropertyOffset_Anchors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnchors.StaticStruct(), base.NativePtr + (IntPtr)FAnchorData.__PropertyOffset_Anchors, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009624 RID: 38436
		// (get) Token: 0x06027045 RID: 159813 RVA: 0x003B8420 File Offset: 0x003B6620
		// (set) Token: 0x06027046 RID: 159814 RVA: 0x003B8434 File Offset: 0x003B6634
		public unsafe FVector2D Alignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnchorData.__PropertyOffset_Alignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnchorData.__PropertyOffset_Alignment) = value;
			}
		}

		// Token: 0x06027047 RID: 159815 RVA: 0x003B8449 File Offset: 0x003B6649
		public FAnchorData()
		{
		}

		// Token: 0x06027048 RID: 159816 RVA: 0x003B8451 File Offset: 0x003B6651
		public FAnchorData(FMargin Offsets, FAnchors Anchors, FVector2D Alignment)
		{
			this.Offsets = Offsets;
			this.Anchors = Anchors;
			this.Alignment = Alignment;
		}

		// Token: 0x06027049 RID: 159817 RVA: 0x003B846E File Offset: 0x003B666E
		protected override IntPtr GetUStructPtr()
		{
			return FAnchorData.StaticStruct();
		}

		// Token: 0x0602704A RID: 159818 RVA: 0x003B847A File Offset: 0x003B667A
		[NullableContext(2)]
		public FAnchorData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602704B RID: 159819 RVA: 0x003B8484 File Offset: 0x003B6684
		public FAnchorData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602704C RID: 159820 RVA: 0x003B848F File Offset: 0x003B668F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnchorData(Pointer, false, true);
		}

		// Token: 0x0602704D RID: 159821 RVA: 0x003B8499 File Offset: 0x003B6699
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnchorData(Pointer, MemoryOwner);
		}

		// Token: 0x04015714 RID: 87828
		public const string __ObjectPath = "/Script/UMG.AnchorData";

		// Token: 0x04015715 RID: 87829
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015716 RID: 87830
		internal static int __PropertyOffset_Offsets;

		// Token: 0x04015717 RID: 87831
		internal static int __PropertyOffset_Anchors;

		// Token: 0x04015718 RID: 87832
		[Nullable(2)]
		private FAnchors _Anchors;

		// Token: 0x04015719 RID: 87833
		internal static int __PropertyOffset_Alignment;
	}
}
