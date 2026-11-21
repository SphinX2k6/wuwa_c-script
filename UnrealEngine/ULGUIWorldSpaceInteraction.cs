using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CB RID: 1739
	[UnrealObjectPath("/Script/LGUI.LGUIWorldSpaceInteraction")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class ULGUIWorldSpaceInteraction : ULGUI_UIRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600944C RID: 37964 RVA: 0x000DFC2A File Offset: 0x000DDE2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIWorldSpaceInteraction._ClassPtr;
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x000DFC38 File Offset: 0x000DDE38
		public ULGUIWorldSpaceInteraction() : this(BuiltinUtils.AllocNativeUObject(ULGUIWorldSpaceInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x000DFC60 File Offset: 0x000DDE60
		[NullableContext(1)]
		public ULGUIWorldSpaceInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIWorldSpaceInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x0600944F RID: 37967 RVA: 0x000DFC93 File Offset: 0x000DDE93
		// (set) Token: 0x06009450 RID: 37968 RVA: 0x000DFCA3 File Offset: 0x000DDEA3
		public unsafe float clickThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_clickThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_clickThreshold) = value;
			}
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06009451 RID: 37969 RVA: 0x000DFCB4 File Offset: 0x000DDEB4
		// (set) Token: 0x06009452 RID: 37970 RVA: 0x000DFCC4 File Offset: 0x000DDEC4
		public unsafe bool holdToDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_holdToDrag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_holdToDrag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06009453 RID: 37971 RVA: 0x000DFCD5 File Offset: 0x000DDED5
		// (set) Token: 0x06009454 RID: 37972 RVA: 0x000DFCE5 File Offset: 0x000DDEE5
		public unsafe float holdToDragTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_holdToDragTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_holdToDragTime) = value;
			}
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x000DFCF6 File Offset: 0x000DDEF6
		public void SetHoldToDragTime(float value)
		{
			ULGUIWorldSpaceInteraction.__SetHoldToDragTime_Internal(base.NativePtr, value);
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x000DFD04 File Offset: 0x000DDF04
		public void SetHoldToDrag(bool value)
		{
			ULGUIWorldSpaceInteraction.__SetHoldToDrag_Internal(base.NativePtr, value);
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x000DFD12 File Offset: 0x000DDF12
		public void SetClickThreshold(float value)
		{
			ULGUIWorldSpaceInteraction.__SetClickThreshold_Internal(base.NativePtr, value);
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x000DFD20 File Offset: 0x000DDF20
		public float GetHoldToDragTime()
		{
			return ULGUIWorldSpaceInteraction.__GetHoldToDragTime_Internal(base.NativePtr);
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x000DFD2D File Offset: 0x000DDF2D
		public bool GetHoldToDrag()
		{
			return ULGUIWorldSpaceInteraction.__GetHoldToDrag_Internal(base.NativePtr);
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x000DFD3A File Offset: 0x000DDF3A
		public float GetClickThreshold()
		{
			return ULGUIWorldSpaceInteraction.__GetClickThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0600945B RID: 37979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDragTime_Internal(IntPtr @this, float value);

		// Token: 0x0600945C RID: 37980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDrag_Internal(IntPtr @this, bool value);

		// Token: 0x0600945D RID: 37981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float value);

		// Token: 0x0600945E RID: 37982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHoldToDragTime_Internal(IntPtr @this);

		// Token: 0x0600945F RID: 37983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHoldToDrag_Internal(IntPtr @this);

		// Token: 0x06009460 RID: 37984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClickThreshold_Internal(IntPtr @this);

		// Token: 0x06009461 RID: 37985 RVA: 0x000DFD47 File Offset: 0x000DDF47
		static ULGUIWorldSpaceInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIWorldSpaceInteraction");
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x000DFD55 File Offset: 0x000DDF55
		protected ULGUIWorldSpaceInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004099 RID: 16537
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIWorldSpaceInteraction";

		// Token: 0x0400409A RID: 16538
		private static IntPtr _ClassPtr;

		// Token: 0x0400409B RID: 16539
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400409C RID: 16540
		internal static int __PropertyOffset_clickThreshold;

		// Token: 0x0400409D RID: 16541
		internal static int __PropertyOffset_holdToDrag;

		// Token: 0x0400409E RID: 16542
		internal static int __PropertyOffset_holdToDragTime;
	}
}
