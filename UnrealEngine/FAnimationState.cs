using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007E5 RID: 2021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimationState")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAnimationState : FAnimationStateBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006BB8 RID: 27576 RVA: 0x0009AFCC File Offset: 0x000991CC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationState._ScriptStructPtr != 0) ? FAnimationState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationState", ref FAnimationState._ScriptStructPtr);
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x0009AFF0 File Offset: 0x000991F0
		// (set) Token: 0x06006BBA RID: 27578 RVA: 0x0009B033 File Offset: 0x00099233
		public TArray<FAnimationTransitionRule> Transitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimationTransitionRule> result;
				if ((result = this._Transitions) == null)
				{
					result = (this._Transitions = new TArray<FAnimationTransitionRule>(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_Transitions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transitions.CopyAssign(value);
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06006BBB RID: 27579 RVA: 0x0009B041 File Offset: 0x00099241
		// (set) Token: 0x06006BBC RID: 27580 RVA: 0x0009B051 File Offset: 0x00099251
		public unsafe int StateRootNodeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_StateRootNodeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_StateRootNodeIndex) = value;
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06006BBD RID: 27581 RVA: 0x0009B062 File Offset: 0x00099262
		// (set) Token: 0x06006BBE RID: 27582 RVA: 0x0009B072 File Offset: 0x00099272
		public unsafe int StartNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_StartNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_StartNotify) = value;
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x0009B083 File Offset: 0x00099283
		// (set) Token: 0x06006BC0 RID: 27584 RVA: 0x0009B093 File Offset: 0x00099293
		public unsafe int EndNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_EndNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_EndNotify) = value;
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06006BC1 RID: 27585 RVA: 0x0009B0A4 File Offset: 0x000992A4
		// (set) Token: 0x06006BC2 RID: 27586 RVA: 0x0009B0B4 File Offset: 0x000992B4
		public unsafe int FullyBlendedNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_FullyBlendedNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationState.__PropertyOffset_FullyBlendedNotify) = value;
			}
		}

		// Token: 0x06006BC3 RID: 27587 RVA: 0x0009B0C5 File Offset: 0x000992C5
		public FAnimationState()
		{
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x0009B0CD File Offset: 0x000992CD
		public FAnimationState(TArray<FAnimationTransitionRule> Transitions, int StateRootNodeIndex, int StartNotify, int EndNotify, int FullyBlendedNotify, FName StateName)
		{
			this.Transitions = Transitions;
			this.StateRootNodeIndex = StateRootNodeIndex;
			this.StartNotify = StartNotify;
			this.EndNotify = EndNotify;
			this.FullyBlendedNotify = FullyBlendedNotify;
			base.StateName = StateName;
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x0009B102 File Offset: 0x00099302
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationState.StaticStruct();
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x0009B10E File Offset: 0x0009930E
		[NullableContext(2)]
		public FAnimationState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x0009B118 File Offset: 0x00099318
		public FAnimationState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x0009B123 File Offset: 0x00099323
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationState(Pointer, false, true);
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x0009B12D File Offset: 0x0009932D
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationState(Pointer, MemoryOwner);
		}

		// Token: 0x040033D7 RID: 13271
		public new const string __ObjectPath = "/Script/Engine.AnimationState";

		// Token: 0x040033D8 RID: 13272
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040033D9 RID: 13273
		internal static int __PropertyOffset_Transitions;

		// Token: 0x040033DA RID: 13274
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimationTransitionRule> _Transitions;

		// Token: 0x040033DB RID: 13275
		internal static int __PropertyOffset_StateRootNodeIndex;

		// Token: 0x040033DC RID: 13276
		internal static int __PropertyOffset_StartNotify;

		// Token: 0x040033DD RID: 13277
		internal static int __PropertyOffset_EndNotify;

		// Token: 0x040033DE RID: 13278
		internal static int __PropertyOffset_FullyBlendedNotify;
	}
}
