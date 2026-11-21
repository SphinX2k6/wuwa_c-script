using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B5 RID: 1717
	[UnrealObjectPath("/Script/LGUI.LGUIScreenSpaceInteraction")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class ULGUIScreenSpaceInteraction : ULGUI_UIRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009375 RID: 37749 RVA: 0x000DE0D6 File Offset: 0x000DC2D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIScreenSpaceInteraction._ClassPtr;
		}

		// Token: 0x06009376 RID: 37750 RVA: 0x000DE0E4 File Offset: 0x000DC2E4
		public ULGUIScreenSpaceInteraction() : this(BuiltinUtils.AllocNativeUObject(ULGUIScreenSpaceInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009377 RID: 37751 RVA: 0x000DE10C File Offset: 0x000DC30C
		[NullableContext(1)]
		public ULGUIScreenSpaceInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIScreenSpaceInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06009378 RID: 37752 RVA: 0x000DE13F File Offset: 0x000DC33F
		// (set) Token: 0x06009379 RID: 37753 RVA: 0x000DE14F File Offset: 0x000DC34F
		public unsafe float clickThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteraction.__PropertyOffset_clickThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteraction.__PropertyOffset_clickThreshold) = value;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x0600937A RID: 37754 RVA: 0x000DE160 File Offset: 0x000DC360
		// (set) Token: 0x0600937B RID: 37755 RVA: 0x000DE170 File Offset: 0x000DC370
		public unsafe bool holdToDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteraction.__PropertyOffset_holdToDrag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteraction.__PropertyOffset_holdToDrag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x000DE181 File Offset: 0x000DC381
		// (set) Token: 0x0600937D RID: 37757 RVA: 0x000DE191 File Offset: 0x000DC391
		public unsafe float holdToDragTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteraction.__PropertyOffset_holdToDragTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteraction.__PropertyOffset_holdToDragTime) = value;
			}
		}

		// Token: 0x0600937E RID: 37758 RVA: 0x000DE1A2 File Offset: 0x000DC3A2
		public void SetHoldToDragTime(float value)
		{
			ULGUIScreenSpaceInteraction.__SetHoldToDragTime_Internal(base.NativePtr, value);
		}

		// Token: 0x0600937F RID: 37759 RVA: 0x000DE1B0 File Offset: 0x000DC3B0
		public void SetHoldToDrag(bool value)
		{
			ULGUIScreenSpaceInteraction.__SetHoldToDrag_Internal(base.NativePtr, value);
		}

		// Token: 0x06009380 RID: 37760 RVA: 0x000DE1BE File Offset: 0x000DC3BE
		public void SetClickThreshold(float value)
		{
			ULGUIScreenSpaceInteraction.__SetClickThreshold_Internal(base.NativePtr, value);
		}

		// Token: 0x06009381 RID: 37761 RVA: 0x000DE1CC File Offset: 0x000DC3CC
		public float GetHoldToDragTime()
		{
			return ULGUIScreenSpaceInteraction.__GetHoldToDragTime_Internal(base.NativePtr);
		}

		// Token: 0x06009382 RID: 37762 RVA: 0x000DE1D9 File Offset: 0x000DC3D9
		public bool GetHoldToDrag()
		{
			return ULGUIScreenSpaceInteraction.__GetHoldToDrag_Internal(base.NativePtr);
		}

		// Token: 0x06009383 RID: 37763 RVA: 0x000DE1E6 File Offset: 0x000DC3E6
		public float GetClickThreshold()
		{
			return ULGUIScreenSpaceInteraction.__GetClickThreshold_Internal(base.NativePtr);
		}

		// Token: 0x06009384 RID: 37764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDragTime_Internal(IntPtr @this, float value);

		// Token: 0x06009385 RID: 37765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDrag_Internal(IntPtr @this, bool value);

		// Token: 0x06009386 RID: 37766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float value);

		// Token: 0x06009387 RID: 37767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHoldToDragTime_Internal(IntPtr @this);

		// Token: 0x06009388 RID: 37768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHoldToDrag_Internal(IntPtr @this);

		// Token: 0x06009389 RID: 37769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClickThreshold_Internal(IntPtr @this);

		// Token: 0x0600938A RID: 37770 RVA: 0x000DE1F3 File Offset: 0x000DC3F3
		static ULGUIScreenSpaceInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIScreenSpaceInteraction");
		}

		// Token: 0x0600938B RID: 37771 RVA: 0x000DE201 File Offset: 0x000DC401
		protected ULGUIScreenSpaceInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004051 RID: 16465
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIScreenSpaceInteraction";

		// Token: 0x04004052 RID: 16466
		private static IntPtr _ClassPtr;

		// Token: 0x04004053 RID: 16467
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004054 RID: 16468
		internal static int __PropertyOffset_clickThreshold;

		// Token: 0x04004055 RID: 16469
		internal static int __PropertyOffset_holdToDrag;

		// Token: 0x04004056 RID: 16470
		internal static int __PropertyOffset_holdToDragTime;
	}
}
