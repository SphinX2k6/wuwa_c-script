using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002185 RID: 8581
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILayoutWithAnimation")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public abstract class UUILayoutWithAnimation : UUILayoutBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060207DA RID: 133082 RVA: 0x0030245C File Offset: 0x0030065C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILayoutWithAnimation._ClassPtr;
		}

		// Token: 0x17007F20 RID: 32544
		// (get) Token: 0x060207DB RID: 133083 RVA: 0x00302468 File Offset: 0x00300668
		// (set) Token: 0x060207DC RID: 133084 RVA: 0x00302478 File Offset: 0x00300678
		public unsafe EUILayoutChangePositionAnimationType AnimationType
		{
			get
			{
				return (EUILayoutChangePositionAnimationType)(*(base.NativePtr + (IntPtr)UUILayoutWithAnimation.__PropertyOffset_AnimationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutWithAnimation.__PropertyOffset_AnimationType) = (byte)value;
			}
		}

		// Token: 0x17007F21 RID: 32545
		// (get) Token: 0x060207DD RID: 133085 RVA: 0x00302489 File Offset: 0x00300689
		// (set) Token: 0x060207DE RID: 133086 RVA: 0x00302499 File Offset: 0x00300699
		public unsafe float AnimationDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutWithAnimation.__PropertyOffset_AnimationDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutWithAnimation.__PropertyOffset_AnimationDuration) = value;
			}
		}

		// Token: 0x17007F22 RID: 32546
		// (get) Token: 0x060207DF RID: 133087 RVA: 0x003024AC File Offset: 0x003006AC
		// (set) Token: 0x060207E0 RID: 133088 RVA: 0x003024E5 File Offset: 0x003006E5
		public TArray<ULTweener> TweenerArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULTweener> result;
				if ((result = this._TweenerArray) == null)
				{
					result = (this._TweenerArray = new TArray<ULTweener>(base.NativePtr + (IntPtr)UUILayoutWithAnimation.__PropertyOffset_TweenerArray, this));
				}
				return result;
			}
			set
			{
				this.TweenerArray.CopyAssign(value);
			}
		}

		// Token: 0x060207E1 RID: 133089 RVA: 0x003024F3 File Offset: 0x003006F3
		public void SetAnimationType(EUILayoutChangePositionAnimationType value)
		{
			UUILayoutWithAnimation.__SetAnimationType_Internal(base.NativePtr, value);
		}

		// Token: 0x060207E2 RID: 133090 RVA: 0x00302501 File Offset: 0x00300701
		public void SetAnimationDuration(float value)
		{
			UUILayoutWithAnimation.__SetAnimationDuration_Internal(base.NativePtr, value);
		}

		// Token: 0x060207E3 RID: 133091 RVA: 0x0030250F File Offset: 0x0030070F
		public EUILayoutChangePositionAnimationType GetAnimationType()
		{
			return UUILayoutWithAnimation.__GetAnimationType_Internal(base.NativePtr);
		}

		// Token: 0x060207E4 RID: 133092 RVA: 0x0030251C File Offset: 0x0030071C
		public float GetAnimationDuration()
		{
			return UUILayoutWithAnimation.__GetAnimationDuration_Internal(base.NativePtr);
		}

		// Token: 0x060207E5 RID: 133093 RVA: 0x00302529 File Offset: 0x00300729
		public void CancelAnimation(bool callComplete = false)
		{
			UUILayoutWithAnimation.__CancelAnimation_Internal(base.NativePtr, callComplete);
		}

		// Token: 0x060207E6 RID: 133094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationType_Internal(IntPtr @this, EUILayoutChangePositionAnimationType value);

		// Token: 0x060207E7 RID: 133095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationDuration_Internal(IntPtr @this, float value);

		// Token: 0x060207E8 RID: 133096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUILayoutChangePositionAnimationType __GetAnimationType_Internal(IntPtr @this);

		// Token: 0x060207E9 RID: 133097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationDuration_Internal(IntPtr @this);

		// Token: 0x060207EA RID: 133098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelAnimation_Internal(IntPtr @this, bool callComplete);

		// Token: 0x060207EB RID: 133099 RVA: 0x00302537 File Offset: 0x00300737
		static UUILayoutWithAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILayoutWithAnimation");
		}

		// Token: 0x060207EC RID: 133100 RVA: 0x00302548 File Offset: 0x00300748
		protected UUILayoutWithAnimation() : this(BuiltinUtils.AllocNativeUObject(UUILayoutWithAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060207ED RID: 133101 RVA: 0x00302570 File Offset: 0x00300770
		protected UUILayoutWithAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401168C RID: 71308
		public new const string __ObjectPath = "/Script/LGUI.UILayoutWithAnimation";

		// Token: 0x0401168D RID: 71309
		private static IntPtr _ClassPtr;

		// Token: 0x0401168E RID: 71310
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401168F RID: 71311
		internal static int __PropertyOffset_AnimationType;

		// Token: 0x04011690 RID: 71312
		internal static int __PropertyOffset_AnimationDuration;

		// Token: 0x04011691 RID: 71313
		internal static int __PropertyOffset_TweenerArray;

		// Token: 0x04011692 RID: 71314
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _TweenerArray;
	}
}
