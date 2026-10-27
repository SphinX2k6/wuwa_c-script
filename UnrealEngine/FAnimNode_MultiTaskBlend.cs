using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200161B RID: 5659
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_MultiTaskBlend")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAnimNode_MultiTaskBlend : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601472C RID: 83756 RVA: 0x001E1300 File Offset: 0x001DF500
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MultiTaskBlend._ScriptStructPtr != 0) ? FAnimNode_MultiTaskBlend._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_MultiTaskBlend", ref FAnimNode_MultiTaskBlend._ScriptStructPtr);
		}

		// Token: 0x1700506C RID: 20588
		// (get) Token: 0x0601472D RID: 83757 RVA: 0x001E1324 File Offset: 0x001DF524
		// (set) Token: 0x0601472E RID: 83758 RVA: 0x001E1367 File Offset: 0x001DF567
		public TArray<UAnimSequenceBase> AdditiveSeqs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimSequenceBase> result;
				if ((result = this._AdditiveSeqs) == null)
				{
					result = (this._AdditiveSeqs = new TArray<UAnimSequenceBase>(base.NativePtr + (IntPtr)FAnimNode_MultiTaskBlend.__PropertyOffset_AdditiveSeqs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AdditiveSeqs.CopyAssign(value);
			}
		}

		// Token: 0x1700506D RID: 20589
		// (get) Token: 0x0601472F RID: 83759 RVA: 0x001E1378 File Offset: 0x001DF578
		// (set) Token: 0x06014730 RID: 83760 RVA: 0x001E13BB File Offset: 0x001DF5BB
		public TArray<float> MixInfo
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._MixInfo) == null)
				{
					result = (this._MixInfo = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_MultiTaskBlend.__PropertyOffset_MixInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MixInfo.CopyAssign(value);
			}
		}

		// Token: 0x1700506E RID: 20590
		// (get) Token: 0x06014731 RID: 83761 RVA: 0x001E13C9 File Offset: 0x001DF5C9
		// (set) Token: 0x06014732 RID: 83762 RVA: 0x001E13D9 File Offset: 0x001DF5D9
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MultiTaskBlend.__PropertyOffset_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MultiTaskBlend.__PropertyOffset_BlendTime) = value;
			}
		}

		// Token: 0x1700506F RID: 20591
		// (get) Token: 0x06014733 RID: 83763 RVA: 0x001E13EA File Offset: 0x001DF5EA
		// (set) Token: 0x06014734 RID: 83764 RVA: 0x001E13FA File Offset: 0x001DF5FA
		public unsafe bool Trigger
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MultiTaskBlend.__PropertyOffset_Trigger) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MultiTaskBlend.__PropertyOffset_Trigger) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014735 RID: 83765 RVA: 0x001E140B File Offset: 0x001DF60B
		public FAnimNode_MultiTaskBlend()
		{
		}

		// Token: 0x06014736 RID: 83766 RVA: 0x001E1413 File Offset: 0x001DF613
		public FAnimNode_MultiTaskBlend(TArray<UAnimSequenceBase> AdditiveSeqs, TArray<float> MixInfo, float BlendTime, bool Trigger)
		{
			this.AdditiveSeqs = AdditiveSeqs;
			this.MixInfo = MixInfo;
			this.BlendTime = BlendTime;
			this.Trigger = Trigger;
		}

		// Token: 0x06014737 RID: 83767 RVA: 0x001E1438 File Offset: 0x001DF638
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MultiTaskBlend.StaticStruct();
		}

		// Token: 0x06014738 RID: 83768 RVA: 0x001E1444 File Offset: 0x001DF644
		[NullableContext(2)]
		public FAnimNode_MultiTaskBlend(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014739 RID: 83769 RVA: 0x001E144E File Offset: 0x001DF64E
		public FAnimNode_MultiTaskBlend(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601473A RID: 83770 RVA: 0x001E1459 File Offset: 0x001DF659
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MultiTaskBlend(Pointer, false, true);
		}

		// Token: 0x0601473B RID: 83771 RVA: 0x001E1463 File Offset: 0x001DF663
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MultiTaskBlend(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1FC RID: 45564
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_MultiTaskBlend";

		// Token: 0x0400B1FD RID: 45565
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1FE RID: 45566
		internal static int __PropertyOffset_AdditiveSeqs;

		// Token: 0x0400B1FF RID: 45567
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimSequenceBase> _AdditiveSeqs;

		// Token: 0x0400B200 RID: 45568
		internal static int __PropertyOffset_MixInfo;

		// Token: 0x0400B201 RID: 45569
		[Nullable(2)]
		private TArray<float> _MixInfo;

		// Token: 0x0400B202 RID: 45570
		internal static int __PropertyOffset_BlendTime;

		// Token: 0x0400B203 RID: 45571
		internal static int __PropertyOffset_Trigger;
	}
}
