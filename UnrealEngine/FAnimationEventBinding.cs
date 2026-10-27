using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002936 RID: 10550
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.AnimationEventBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAnimationEventBinding : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602704E RID: 159822 RVA: 0x003B84A2 File Offset: 0x003B66A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationEventBinding._ScriptStructPtr != 0) ? FAnimationEventBinding._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.AnimationEventBinding", ref FAnimationEventBinding._ScriptStructPtr);
		}

		// Token: 0x17009625 RID: 38437
		// (get) Token: 0x0602704F RID: 159823 RVA: 0x003B84C6 File Offset: 0x003B66C6
		// (set) Token: 0x06027050 RID: 159824 RVA: 0x003B84DA File Offset: 0x003B66DA
		[Nullable(2)]
		public unsafe UWidgetAnimation Animation
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetAnimation>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationEventBinding.__PropertyOffset_Animation);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationEventBinding.__PropertyOffset_Animation, value);
			}
		}

		// Token: 0x17009626 RID: 38438
		// (get) Token: 0x06027051 RID: 159825 RVA: 0x003B84F0 File Offset: 0x003B66F0
		// (set) Token: 0x06027052 RID: 159826 RVA: 0x003B8533 File Offset: 0x003B6733
		public FWidgetAnimationDynamicEvent Delegate
		{
			get
			{
				base.FastCheckIsValid();
				FWidgetAnimationDynamicEvent result;
				if ((result = this._Delegate) == null)
				{
					result = (this._Delegate = new FWidgetAnimationDynamicEvent(base.NativePtr + (IntPtr)FAnimationEventBinding.__PropertyOffset_Delegate, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FAnimationEventBinding.__PropertyOffset_Delegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009627 RID: 38439
		// (get) Token: 0x06027053 RID: 159827 RVA: 0x003B8554 File Offset: 0x003B6754
		// (set) Token: 0x06027054 RID: 159828 RVA: 0x003B8564 File Offset: 0x003B6764
		public unsafe EWidgetAnimationEvent AnimationEvent
		{
			get
			{
				return (EWidgetAnimationEvent)(*(base.NativePtr + (IntPtr)FAnimationEventBinding.__PropertyOffset_AnimationEvent));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationEventBinding.__PropertyOffset_AnimationEvent) = (byte)value;
			}
		}

		// Token: 0x17009628 RID: 38440
		// (get) Token: 0x06027055 RID: 159829 RVA: 0x003B8575 File Offset: 0x003B6775
		// (set) Token: 0x06027056 RID: 159830 RVA: 0x003B8589 File Offset: 0x003B6789
		public unsafe FName UserTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationEventBinding.__PropertyOffset_UserTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationEventBinding.__PropertyOffset_UserTag) = value;
			}
		}

		// Token: 0x06027057 RID: 159831 RVA: 0x003B859E File Offset: 0x003B679E
		public FAnimationEventBinding()
		{
		}

		// Token: 0x06027058 RID: 159832 RVA: 0x003B85A6 File Offset: 0x003B67A6
		public FAnimationEventBinding(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate, EWidgetAnimationEvent AnimationEvent, FName UserTag)
		{
			this.Animation = Animation;
			this.Delegate = Delegate;
			this.AnimationEvent = AnimationEvent;
			this.UserTag = UserTag;
		}

		// Token: 0x06027059 RID: 159833 RVA: 0x003B85CB File Offset: 0x003B67CB
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationEventBinding.StaticStruct();
		}

		// Token: 0x0602705A RID: 159834 RVA: 0x003B85D7 File Offset: 0x003B67D7
		[NullableContext(2)]
		public FAnimationEventBinding(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602705B RID: 159835 RVA: 0x003B85E1 File Offset: 0x003B67E1
		public FAnimationEventBinding(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602705C RID: 159836 RVA: 0x003B85EC File Offset: 0x003B67EC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationEventBinding(Pointer, false, true);
		}

		// Token: 0x0602705D RID: 159837 RVA: 0x003B85F6 File Offset: 0x003B67F6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationEventBinding(Pointer, MemoryOwner);
		}

		// Token: 0x0401571A RID: 87834
		public const string __ObjectPath = "/Script/UMG.AnimationEventBinding";

		// Token: 0x0401571B RID: 87835
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401571C RID: 87836
		internal static int __PropertyOffset_Animation;

		// Token: 0x0401571D RID: 87837
		internal static int __PropertyOffset_Delegate;

		// Token: 0x0401571E RID: 87838
		[Nullable(2)]
		private FWidgetAnimationDynamicEvent _Delegate;

		// Token: 0x0401571F RID: 87839
		internal static int __PropertyOffset_AnimationEvent;

		// Token: 0x04015720 RID: 87840
		internal static int __PropertyOffset_UserTag;
	}
}
