using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002182 RID: 8578
	[UnrealObjectPath("/Script/LGUI.UILayoutBase")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public abstract class UUILayoutBase : ULGUIBehaviour, IUnrealUObject, IUnrealObject, ILGUIGridAnimationInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPrefabCheckerInterface, IUILayoutInterface
	{
		// Token: 0x06020797 RID: 133015 RVA: 0x003020E2 File Offset: 0x003002E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILayoutBase._ClassPtr;
		}

		// Token: 0x06020798 RID: 133016 RVA: 0x003020EE File Offset: 0x003002EE
		int ILGUIGridAnimationInterface.InterfaceOffset()
		{
			return UUILayoutBase.__InterfaceOffset_ILGUIGridAnimationInterface;
		}

		// Token: 0x06020799 RID: 133017 RVA: 0x003020F5 File Offset: 0x003002F5
		int ILGUIPrefabCheckerInterface.InterfaceOffset()
		{
			return UUILayoutBase.__InterfaceOffset_ILGUIPrefabCheckerInterface;
		}

		// Token: 0x0602079A RID: 133018 RVA: 0x003020FC File Offset: 0x003002FC
		int IUILayoutInterface.InterfaceOffset()
		{
			return UUILayoutBase.__InterfaceOffset_IUILayoutInterface;
		}

		// Token: 0x17007F14 RID: 32532
		// (get) Token: 0x0602079B RID: 133019 RVA: 0x00302103 File Offset: 0x00300303
		// (set) Token: 0x0602079C RID: 133020 RVA: 0x00302113 File Offset: 0x00300313
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

		// Token: 0x17007F15 RID: 32533
		// (get) Token: 0x0602079D RID: 133021 RVA: 0x00302124 File Offset: 0x00300324
		// (set) Token: 0x0602079E RID: 133022 RVA: 0x00302134 File Offset: 0x00300334
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

		// Token: 0x17007F16 RID: 32534
		// (get) Token: 0x0602079F RID: 133023 RVA: 0x00302145 File Offset: 0x00300345
		// (set) Token: 0x060207A0 RID: 133024 RVA: 0x00302155 File Offset: 0x00300355
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

		// Token: 0x17007F17 RID: 32535
		// (get) Token: 0x060207A1 RID: 133025 RVA: 0x00302166 File Offset: 0x00300366
		// (set) Token: 0x060207A2 RID: 133026 RVA: 0x00302176 File Offset: 0x00300376
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

		// Token: 0x17007F18 RID: 32536
		// (get) Token: 0x060207A3 RID: 133027 RVA: 0x00302187 File Offset: 0x00300387
		// (set) Token: 0x060207A4 RID: 133028 RVA: 0x00302197 File Offset: 0x00300397
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

		// Token: 0x17007F19 RID: 32537
		// (get) Token: 0x060207A5 RID: 133029 RVA: 0x003021A8 File Offset: 0x003003A8
		// (set) Token: 0x060207A6 RID: 133030 RVA: 0x003021E1 File Offset: 0x003003E1
		[Nullable(1)]
		public FOnRebuildLayoutDelegate OnRebuildLayoutDelegate
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUILayoutBase.__PropertyOffset_OnRebuildLayoutDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060207A7 RID: 133031 RVA: 0x00302202 File Offset: 0x00300402
		public void SetInAnimation(bool state)
		{
			UUILayoutBase.__SetInAnimation_Internal(base.NativePtr, state);
		}

		// Token: 0x060207A8 RID: 133032 RVA: 0x00302210 File Offset: 0x00300410
		public void SetGridAnimationStartTime(float value)
		{
			UUILayoutBase.__SetGridAnimationStartTime_Internal(base.NativePtr, value);
		}

		// Token: 0x060207A9 RID: 133033 RVA: 0x0030221E File Offset: 0x0030041E
		public void SetGridAnimationInterval(float value)
		{
			UUILayoutBase.__SetGridAnimationInterval_Internal(base.NativePtr, value);
		}

		// Token: 0x060207AA RID: 133034 RVA: 0x0030222C File Offset: 0x0030042C
		public bool GetInAnimation()
		{
			return UUILayoutBase.__GetInAnimation_Internal(base.NativePtr);
		}

		// Token: 0x060207AB RID: 133035 RVA: 0x00302239 File Offset: 0x00300439
		public float GetGridAnimationStartTime()
		{
			return UUILayoutBase.__GetGridAnimationStartTime_Internal(base.NativePtr);
		}

		// Token: 0x060207AC RID: 133036 RVA: 0x00302246 File Offset: 0x00300446
		public float GetGridAnimationInterval()
		{
			return UUILayoutBase.__GetGridAnimationInterval_Internal(base.NativePtr);
		}

		// Token: 0x060207AD RID: 133037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInAnimation_Internal(IntPtr @this, bool state);

		// Token: 0x060207AE RID: 133038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationStartTime_Internal(IntPtr @this, float value);

		// Token: 0x060207AF RID: 133039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationInterval_Internal(IntPtr @this, float value);

		// Token: 0x060207B0 RID: 133040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInAnimation_Internal(IntPtr @this);

		// Token: 0x060207B1 RID: 133041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationStartTime_Internal(IntPtr @this);

		// Token: 0x060207B2 RID: 133042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationInterval_Internal(IntPtr @this);

		// Token: 0x060207B3 RID: 133043 RVA: 0x00302253 File Offset: 0x00300453
		static UUILayoutBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILayoutBase");
		}

		// Token: 0x060207B4 RID: 133044 RVA: 0x00302264 File Offset: 0x00300464
		protected UUILayoutBase() : this(BuiltinUtils.AllocNativeUObject(UUILayoutBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060207B5 RID: 133045 RVA: 0x0030228C File Offset: 0x0030048C
		protected UUILayoutBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011675 RID: 71285
		internal static int __InterfaceOffset_ILGUIGridAnimationInterface;

		// Token: 0x04011676 RID: 71286
		internal static int __InterfaceOffset_ILGUIPrefabCheckerInterface;

		// Token: 0x04011677 RID: 71287
		internal static int __InterfaceOffset_IUILayoutInterface;

		// Token: 0x04011678 RID: 71288
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UILayoutBase";

		// Token: 0x04011679 RID: 71289
		private static IntPtr _ClassPtr;

		// Token: 0x0401167A RID: 71290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401167B RID: 71291
		internal static int __PropertyOffset_GridAnimationStartTime;

		// Token: 0x0401167C RID: 71292
		internal static int __PropertyOffset_GridAnimationInterval;

		// Token: 0x0401167D RID: 71293
		internal static int __PropertyOffset_IsInAnimation;

		// Token: 0x0401167E RID: 71294
		internal static int __PropertyOffset_bIsScaleCalculated;

		// Token: 0x0401167F RID: 71295
		internal static int __PropertyOffset_bUseOriginalChildrenOrder;

		// Token: 0x04011680 RID: 71296
		internal static int __PropertyOffset_OnRebuildLayoutDelegate;

		// Token: 0x04011681 RID: 71297
		[Nullable(2)]
		private FOnRebuildLayoutDelegate _OnRebuildLayoutDelegate;
	}
}
