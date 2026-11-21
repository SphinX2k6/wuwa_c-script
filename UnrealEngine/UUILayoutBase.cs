using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000710 RID: 1808
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILayoutBase")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public abstract class UUILayoutBase : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B34 RID: 39732 RVA: 0x000E841E File Offset: 0x000E661E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILayoutBase._ClassPtr;
		}

		// Token: 0x17001CC3 RID: 7363
		// (get) Token: 0x06009B35 RID: 39733 RVA: 0x000E842A File Offset: 0x000E662A
		// (set) Token: 0x06009B36 RID: 39734 RVA: 0x000E843A File Offset: 0x000E663A
		public unsafe float GridAnimationStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_GridAnimationStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_GridAnimationStartTime) = value;
			}
		}

		// Token: 0x17001CC4 RID: 7364
		// (get) Token: 0x06009B37 RID: 39735 RVA: 0x000E844B File Offset: 0x000E664B
		// (set) Token: 0x06009B38 RID: 39736 RVA: 0x000E845B File Offset: 0x000E665B
		public unsafe float GridAnimationInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_GridAnimationInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_GridAnimationInterval) = value;
			}
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x06009B39 RID: 39737 RVA: 0x000E846C File Offset: 0x000E666C
		// (set) Token: 0x06009B3A RID: 39738 RVA: 0x000E847C File Offset: 0x000E667C
		public unsafe bool IsInAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_IsInAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_IsInAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x06009B3B RID: 39739 RVA: 0x000E848D File Offset: 0x000E668D
		// (set) Token: 0x06009B3C RID: 39740 RVA: 0x000E849D File Offset: 0x000E669D
		public unsafe bool bIsScaleCalculated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_bIsScaleCalculated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_bIsScaleCalculated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x06009B3D RID: 39741 RVA: 0x000E84AE File Offset: 0x000E66AE
		// (set) Token: 0x06009B3E RID: 39742 RVA: 0x000E84BE File Offset: 0x000E66BE
		public unsafe bool bUseOriginalChildrenOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_bUseOriginalChildrenOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_bUseOriginalChildrenOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x06009B3F RID: 39743 RVA: 0x000E84D0 File Offset: 0x000E66D0
		// (set) Token: 0x06009B40 RID: 39744 RVA: 0x000E8509 File Offset: 0x000E6709
		public FOnRebuildLayoutDelegate OnRebuildLayoutDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FOnRebuildLayoutDelegate result;
				if ((result = this._OnRebuildLayoutDelegate) == null)
				{
					result = (this._OnRebuildLayoutDelegate = new FOnRebuildLayoutDelegate(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_OnRebuildLayoutDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_OnRebuildLayoutDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x000E852A File Offset: 0x000E672A
		public void SetInAnimation(bool state)
		{
			UUILayoutBase.__SetInAnimation_Internal(base.NativePtr, state);
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x000E8538 File Offset: 0x000E6738
		public void SetGridAnimationStartTime(float value)
		{
			UUILayoutBase.__SetGridAnimationStartTime_Internal(base.NativePtr, value);
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x000E8546 File Offset: 0x000E6746
		public void SetGridAnimationInterval(float value)
		{
			UUILayoutBase.__SetGridAnimationInterval_Internal(base.NativePtr, value);
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x000E8554 File Offset: 0x000E6754
		public bool GetInAnimation()
		{
			return UUILayoutBase.__GetInAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x000E8561 File Offset: 0x000E6761
		public float GetGridAnimationStartTime()
		{
			return UUILayoutBase.__GetGridAnimationStartTime_Internal(base.NativePtr);
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x000E856E File Offset: 0x000E676E
		public float GetGridAnimationInterval()
		{
			return UUILayoutBase.__GetGridAnimationInterval_Internal(base.NativePtr);
		}

		// Token: 0x06009B47 RID: 39751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInAnimation_Internal(IntPtr @this, bool state);

		// Token: 0x06009B48 RID: 39752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationStartTime_Internal(IntPtr @this, float value);

		// Token: 0x06009B49 RID: 39753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationInterval_Internal(IntPtr @this, float value);

		// Token: 0x06009B4A RID: 39754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInAnimation_Internal(IntPtr @this);

		// Token: 0x06009B4B RID: 39755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationStartTime_Internal(IntPtr @this);

		// Token: 0x06009B4C RID: 39756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationInterval_Internal(IntPtr @this);

		// Token: 0x06009B4D RID: 39757 RVA: 0x000E857B File Offset: 0x000E677B
		static UUILayoutBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILayoutBase");
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x000E858C File Offset: 0x000E678C
		protected UUILayoutBase() : this(BuiltinUtils.AllocNativeUObject(UUILayoutBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x000E85B4 File Offset: 0x000E67B4
		protected UUILayoutBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004302 RID: 17154
		public new const string __ObjectPath = "/Script/LGUI.UILayoutBase";

		// Token: 0x04004303 RID: 17155
		private static IntPtr _ClassPtr;

		// Token: 0x04004304 RID: 17156
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004305 RID: 17157
		internal static int __PropertyOffset_GridAnimationStartTime;

		// Token: 0x04004306 RID: 17158
		internal static int __PropertyOffset_GridAnimationInterval;

		// Token: 0x04004307 RID: 17159
		internal static int __PropertyOffset_IsInAnimation;

		// Token: 0x04004308 RID: 17160
		internal static int __PropertyOffset_bIsScaleCalculated;

		// Token: 0x04004309 RID: 17161
		internal static int __PropertyOffset_bUseOriginalChildrenOrder;

		// Token: 0x0400430A RID: 17162
		internal static int __PropertyOffset_OnRebuildLayoutDelegate;

		// Token: 0x0400430B RID: 17163
		[Nullable(2)]
		private FOnRebuildLayoutDelegate _OnRebuildLayoutDelegate;
	}
}
