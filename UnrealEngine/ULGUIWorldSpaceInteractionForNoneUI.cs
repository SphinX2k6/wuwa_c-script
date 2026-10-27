using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E0 RID: 8416
	[UnrealObjectPath("/Script/LGUI.LGUIWorldSpaceInteractionForNoneUI")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class ULGUIWorldSpaceInteractionForNoneUI : ULGUI_WorldRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB15 RID: 129813 RVA: 0x002F2276 File Offset: 0x002F0476
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIWorldSpaceInteractionForNoneUI._ClassPtr;
		}

		// Token: 0x0601FB16 RID: 129814 RVA: 0x002F2284 File Offset: 0x002F0484
		public ULGUIWorldSpaceInteractionForNoneUI() : this(BuiltinUtils.AllocNativeUObject(ULGUIWorldSpaceInteractionForNoneUI.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB17 RID: 129815 RVA: 0x002F22AC File Offset: 0x002F04AC
		[NullableContext(1)]
		public ULGUIWorldSpaceInteractionForNoneUI(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIWorldSpaceInteractionForNoneUI.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CE2 RID: 31970
		// (get) Token: 0x0601FB18 RID: 129816 RVA: 0x002F22DF File Offset: 0x002F04DF
		// (set) Token: 0x0601FB19 RID: 129817 RVA: 0x002F22EF File Offset: 0x002F04EF
		public unsafe float clickThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_clickThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_clickThreshold) = value;
			}
		}

		// Token: 0x17007CE3 RID: 31971
		// (get) Token: 0x0601FB1A RID: 129818 RVA: 0x002F2300 File Offset: 0x002F0500
		// (set) Token: 0x0601FB1B RID: 129819 RVA: 0x002F2310 File Offset: 0x002F0510
		public unsafe bool holdToDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_holdToDrag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_holdToDrag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007CE4 RID: 31972
		// (get) Token: 0x0601FB1C RID: 129820 RVA: 0x002F2321 File Offset: 0x002F0521
		// (set) Token: 0x0601FB1D RID: 129821 RVA: 0x002F2331 File Offset: 0x002F0531
		public unsafe float holdToDragTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_holdToDragTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_holdToDragTime) = value;
			}
		}

		// Token: 0x17007CE5 RID: 31973
		// (get) Token: 0x0601FB1E RID: 129822 RVA: 0x002F2342 File Offset: 0x002F0542
		// (set) Token: 0x0601FB1F RID: 129823 RVA: 0x002F2352 File Offset: 0x002F0552
		public unsafe ELGUIWorldSpaceInteractionSource interactionSource
		{
			get
			{
				return (ELGUIWorldSpaceInteractionSource)(*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_interactionSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteractionForNoneUI.__PropertyOffset_interactionSource) = (byte)value;
			}
		}

		// Token: 0x0601FB20 RID: 129824 RVA: 0x002F2363 File Offset: 0x002F0563
		public void SetInteractionSource(ELGUIWorldSpaceInteractionSource value)
		{
			ULGUIWorldSpaceInteractionForNoneUI.__SetInteractionSource_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB21 RID: 129825 RVA: 0x002F2371 File Offset: 0x002F0571
		public void SetHoldToDragTime(float value)
		{
			ULGUIWorldSpaceInteractionForNoneUI.__SetHoldToDragTime_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB22 RID: 129826 RVA: 0x002F237F File Offset: 0x002F057F
		public void SetHoldToDrag(bool value)
		{
			ULGUIWorldSpaceInteractionForNoneUI.__SetHoldToDrag_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB23 RID: 129827 RVA: 0x002F238D File Offset: 0x002F058D
		public void SetClickThreshold(float value)
		{
			ULGUIWorldSpaceInteractionForNoneUI.__SetClickThreshold_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB24 RID: 129828 RVA: 0x002F239B File Offset: 0x002F059B
		public ELGUIWorldSpaceInteractionSource GetInteractionSource()
		{
			return ULGUIWorldSpaceInteractionForNoneUI.__GetInteractionSource_Internal(base.NativePtr);
		}

		// Token: 0x0601FB25 RID: 129829 RVA: 0x002F23A8 File Offset: 0x002F05A8
		public float GetHoldToDragTime()
		{
			return ULGUIWorldSpaceInteractionForNoneUI.__GetHoldToDragTime_Internal(base.NativePtr);
		}

		// Token: 0x0601FB26 RID: 129830 RVA: 0x002F23B5 File Offset: 0x002F05B5
		public bool GetHoldToDrag()
		{
			return ULGUIWorldSpaceInteractionForNoneUI.__GetHoldToDrag_Internal(base.NativePtr);
		}

		// Token: 0x0601FB27 RID: 129831 RVA: 0x002F23C2 File Offset: 0x002F05C2
		public float GetClickThreshold()
		{
			return ULGUIWorldSpaceInteractionForNoneUI.__GetClickThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0601FB28 RID: 129832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInteractionSource_Internal(IntPtr @this, ELGUIWorldSpaceInteractionSource value);

		// Token: 0x0601FB29 RID: 129833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDragTime_Internal(IntPtr @this, float value);

		// Token: 0x0601FB2A RID: 129834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDrag_Internal(IntPtr @this, bool value);

		// Token: 0x0601FB2B RID: 129835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float value);

		// Token: 0x0601FB2C RID: 129836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUIWorldSpaceInteractionSource __GetInteractionSource_Internal(IntPtr @this);

		// Token: 0x0601FB2D RID: 129837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHoldToDragTime_Internal(IntPtr @this);

		// Token: 0x0601FB2E RID: 129838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHoldToDrag_Internal(IntPtr @this);

		// Token: 0x0601FB2F RID: 129839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClickThreshold_Internal(IntPtr @this);

		// Token: 0x0601FB30 RID: 129840 RVA: 0x002F23CF File Offset: 0x002F05CF
		static ULGUIWorldSpaceInteractionForNoneUI()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIWorldSpaceInteractionForNoneUI");
		}

		// Token: 0x0601FB31 RID: 129841 RVA: 0x002F23DD File Offset: 0x002F05DD
		protected ULGUIWorldSpaceInteractionForNoneUI(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011189 RID: 70025
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIWorldSpaceInteractionForNoneUI";

		// Token: 0x0401118A RID: 70026
		private static IntPtr _ClassPtr;

		// Token: 0x0401118B RID: 70027
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401118C RID: 70028
		internal static int __PropertyOffset_clickThreshold;

		// Token: 0x0401118D RID: 70029
		internal static int __PropertyOffset_holdToDrag;

		// Token: 0x0401118E RID: 70030
		internal static int __PropertyOffset_holdToDragTime;

		// Token: 0x0401118F RID: 70031
		internal static int __PropertyOffset_interactionSource;
	}
}
