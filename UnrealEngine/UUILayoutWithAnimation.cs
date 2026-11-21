using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000711 RID: 1809
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILayoutWithAnimation")]
	[UnrealStructLayout(416, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public abstract class UUILayoutWithAnimation : UUILayoutBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B50 RID: 39760 RVA: 0x000E85BD File Offset: 0x000E67BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILayoutWithAnimation._ClassPtr;
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x06009B51 RID: 39761 RVA: 0x000E85C9 File Offset: 0x000E67C9
		// (set) Token: 0x06009B52 RID: 39762 RVA: 0x000E85D9 File Offset: 0x000E67D9
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

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x06009B53 RID: 39763 RVA: 0x000E85EC File Offset: 0x000E67EC
		// (set) Token: 0x06009B54 RID: 39764 RVA: 0x000E8625 File Offset: 0x000E6825
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

		// Token: 0x06009B55 RID: 39765 RVA: 0x000E8633 File Offset: 0x000E6833
		public void SetAnimationDuration(float value)
		{
			UUILayoutWithAnimation.__SetAnimationDuration_Internal(base.NativePtr, value);
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x000E8641 File Offset: 0x000E6841
		public float GetAnimationDuration()
		{
			return UUILayoutWithAnimation.__GetAnimationDuration_Internal(base.NativePtr);
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x000E864E File Offset: 0x000E684E
		public void CancelAnimation(bool callComplete = false)
		{
			UUILayoutWithAnimation.__CancelAnimation_Internal(base.NativePtr, callComplete);
		}

		// Token: 0x06009B58 RID: 39768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationDuration_Internal(IntPtr @this, float value);

		// Token: 0x06009B59 RID: 39769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationDuration_Internal(IntPtr @this);

		// Token: 0x06009B5A RID: 39770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelAnimation_Internal(IntPtr @this, bool callComplete);

		// Token: 0x06009B5B RID: 39771 RVA: 0x000E865C File Offset: 0x000E685C
		static UUILayoutWithAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILayoutWithAnimation");
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x000E866C File Offset: 0x000E686C
		protected UUILayoutWithAnimation() : this(BuiltinUtils.AllocNativeUObject(UUILayoutWithAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x000E8694 File Offset: 0x000E6894
		protected UUILayoutWithAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400430C RID: 17164
		public new const string __ObjectPath = "/Script/LGUI.UILayoutWithAnimation";

		// Token: 0x0400430D RID: 17165
		private static IntPtr _ClassPtr;

		// Token: 0x0400430E RID: 17166
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400430F RID: 17167
		internal static int __PropertyOffset_AnimationDuration;

		// Token: 0x04004310 RID: 17168
		internal static int __PropertyOffset_TweenerArray;

		// Token: 0x04004311 RID: 17169
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULTweener> _TweenerArray;
	}
}
