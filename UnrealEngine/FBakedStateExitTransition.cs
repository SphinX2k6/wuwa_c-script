using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200089C RID: 2204
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedStateExitTransition")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FBakedStateExitTransition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007896 RID: 30870 RVA: 0x000ACADE File Offset: 0x000AACDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBakedStateExitTransition._ScriptStructPtr != 0) ? FBakedStateExitTransition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BakedStateExitTransition", ref FBakedStateExitTransition._ScriptStructPtr);
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06007897 RID: 30871 RVA: 0x000ACB02 File Offset: 0x000AAD02
		// (set) Token: 0x06007898 RID: 30872 RVA: 0x000ACB12 File Offset: 0x000AAD12
		public unsafe int CanTakeDelegateIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_CanTakeDelegateIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_CanTakeDelegateIndex) = value;
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06007899 RID: 30873 RVA: 0x000ACB23 File Offset: 0x000AAD23
		// (set) Token: 0x0600789A RID: 30874 RVA: 0x000ACB33 File Offset: 0x000AAD33
		public unsafe int CustomResultNodeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_CustomResultNodeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_CustomResultNodeIndex) = value;
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x0600789B RID: 30875 RVA: 0x000ACB44 File Offset: 0x000AAD44
		// (set) Token: 0x0600789C RID: 30876 RVA: 0x000ACB54 File Offset: 0x000AAD54
		public unsafe int TransitionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_TransitionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_TransitionIndex) = value;
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x0600789D RID: 30877 RVA: 0x000ACB65 File Offset: 0x000AAD65
		// (set) Token: 0x0600789E RID: 30878 RVA: 0x000ACB75 File Offset: 0x000AAD75
		public unsafe bool bDesiredTransitionReturnValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_bDesiredTransitionReturnValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_bDesiredTransitionReturnValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x0600789F RID: 30879 RVA: 0x000ACB86 File Offset: 0x000AAD86
		// (set) Token: 0x060078A0 RID: 30880 RVA: 0x000ACB96 File Offset: 0x000AAD96
		public unsafe bool bAutomaticRemainingTimeRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_bAutomaticRemainingTimeRule) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_bAutomaticRemainingTimeRule) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x060078A1 RID: 30881 RVA: 0x000ACBA8 File Offset: 0x000AADA8
		// (set) Token: 0x060078A2 RID: 30882 RVA: 0x000ACBEB File Offset: 0x000AADEB
		public TArray<int> PoseEvaluatorLinks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._PoseEvaluatorLinks) == null)
				{
					result = (this._PoseEvaluatorLinks = new TArray<int>(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_PoseEvaluatorLinks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PoseEvaluatorLinks.CopyAssign(value);
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x060078A3 RID: 30883 RVA: 0x000ACBFC File Offset: 0x000AADFC
		// (set) Token: 0x060078A4 RID: 30884 RVA: 0x000ACC3F File Offset: 0x000AAE3F
		public TArray<FKuroBakedTransitionCondition> NativeConditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroBakedTransitionCondition> result;
				if ((result = this._NativeConditions) == null)
				{
					result = (this._NativeConditions = new TArray<FKuroBakedTransitionCondition>(base.NativePtr + (IntPtr)FBakedStateExitTransition.__PropertyOffset_NativeConditions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NativeConditions.CopyAssign(value);
			}
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x000ACC4D File Offset: 0x000AAE4D
		public FBakedStateExitTransition()
		{
		}

		// Token: 0x060078A6 RID: 30886 RVA: 0x000ACC55 File Offset: 0x000AAE55
		public FBakedStateExitTransition(int CanTakeDelegateIndex, int CustomResultNodeIndex, int TransitionIndex, bool bDesiredTransitionReturnValue, bool bAutomaticRemainingTimeRule, TArray<int> PoseEvaluatorLinks, TArray<FKuroBakedTransitionCondition> NativeConditions)
		{
			this.CanTakeDelegateIndex = CanTakeDelegateIndex;
			this.CustomResultNodeIndex = CustomResultNodeIndex;
			this.TransitionIndex = TransitionIndex;
			this.bDesiredTransitionReturnValue = bDesiredTransitionReturnValue;
			this.bAutomaticRemainingTimeRule = bAutomaticRemainingTimeRule;
			this.PoseEvaluatorLinks = PoseEvaluatorLinks;
			this.NativeConditions = NativeConditions;
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x000ACC92 File Offset: 0x000AAE92
		protected override IntPtr GetUStructPtr()
		{
			return FBakedStateExitTransition.StaticStruct();
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x000ACC9E File Offset: 0x000AAE9E
		[NullableContext(2)]
		public FBakedStateExitTransition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x000ACCA8 File Offset: 0x000AAEA8
		public FBakedStateExitTransition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x000ACCB3 File Offset: 0x000AAEB3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBakedStateExitTransition(Pointer, false, true);
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x000ACCBD File Offset: 0x000AAEBD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBakedStateExitTransition(Pointer, MemoryOwner);
		}

		// Token: 0x040039EC RID: 14828
		public const string __ObjectPath = "/Script/Engine.BakedStateExitTransition";

		// Token: 0x040039ED RID: 14829
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040039EE RID: 14830
		internal static int __PropertyOffset_CanTakeDelegateIndex;

		// Token: 0x040039EF RID: 14831
		internal static int __PropertyOffset_CustomResultNodeIndex;

		// Token: 0x040039F0 RID: 14832
		internal static int __PropertyOffset_TransitionIndex;

		// Token: 0x040039F1 RID: 14833
		internal static int __PropertyOffset_bDesiredTransitionReturnValue;

		// Token: 0x040039F2 RID: 14834
		internal static int __PropertyOffset_bAutomaticRemainingTimeRule;

		// Token: 0x040039F3 RID: 14835
		internal static int __PropertyOffset_PoseEvaluatorLinks;

		// Token: 0x040039F4 RID: 14836
		[Nullable(2)]
		private TArray<int> _PoseEvaluatorLinks;

		// Token: 0x040039F5 RID: 14837
		internal static int __PropertyOffset_NativeConditions;

		// Token: 0x040039F6 RID: 14838
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroBakedTransitionCondition> _NativeConditions;
	}
}
