using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020DF RID: 8415
	[UnrealObjectPath("/Script/LGUI.LGUIWorldSpaceInteraction")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class ULGUIWorldSpaceInteraction : ULGUI_UIRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAF8 RID: 129784 RVA: 0x002F2106 File Offset: 0x002F0306
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIWorldSpaceInteraction._ClassPtr;
		}

		// Token: 0x0601FAF9 RID: 129785 RVA: 0x002F2114 File Offset: 0x002F0314
		public ULGUIWorldSpaceInteraction() : this(BuiltinUtils.AllocNativeUObject(ULGUIWorldSpaceInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAFA RID: 129786 RVA: 0x002F213C File Offset: 0x002F033C
		[NullableContext(1)]
		public ULGUIWorldSpaceInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIWorldSpaceInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CDE RID: 31966
		// (get) Token: 0x0601FAFB RID: 129787 RVA: 0x002F216F File Offset: 0x002F036F
		// (set) Token: 0x0601FAFC RID: 129788 RVA: 0x002F217F File Offset: 0x002F037F
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

		// Token: 0x17007CDF RID: 31967
		// (get) Token: 0x0601FAFD RID: 129789 RVA: 0x002F2190 File Offset: 0x002F0390
		// (set) Token: 0x0601FAFE RID: 129790 RVA: 0x002F21A0 File Offset: 0x002F03A0
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

		// Token: 0x17007CE0 RID: 31968
		// (get) Token: 0x0601FAFF RID: 129791 RVA: 0x002F21B1 File Offset: 0x002F03B1
		// (set) Token: 0x0601FB00 RID: 129792 RVA: 0x002F21C1 File Offset: 0x002F03C1
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

		// Token: 0x17007CE1 RID: 31969
		// (get) Token: 0x0601FB01 RID: 129793 RVA: 0x002F21D2 File Offset: 0x002F03D2
		// (set) Token: 0x0601FB02 RID: 129794 RVA: 0x002F21E2 File Offset: 0x002F03E2
		public unsafe ELGUIWorldSpaceInteractionSource interactionSource
		{
			get
			{
				return (ELGUIWorldSpaceInteractionSource)(*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_interactionSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIWorldSpaceInteraction.__PropertyOffset_interactionSource) = (byte)value;
			}
		}

		// Token: 0x0601FB03 RID: 129795 RVA: 0x002F21F3 File Offset: 0x002F03F3
		public void SetInteractionSource(ELGUIWorldSpaceInteractionSource value)
		{
			ULGUIWorldSpaceInteraction.__SetInteractionSource_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB04 RID: 129796 RVA: 0x002F2201 File Offset: 0x002F0401
		public void SetHoldToDragTime(float value)
		{
			ULGUIWorldSpaceInteraction.__SetHoldToDragTime_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB05 RID: 129797 RVA: 0x002F220F File Offset: 0x002F040F
		public void SetHoldToDrag(bool value)
		{
			ULGUIWorldSpaceInteraction.__SetHoldToDrag_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB06 RID: 129798 RVA: 0x002F221D File Offset: 0x002F041D
		public void SetClickThreshold(float value)
		{
			ULGUIWorldSpaceInteraction.__SetClickThreshold_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB07 RID: 129799 RVA: 0x002F222B File Offset: 0x002F042B
		public ELGUIWorldSpaceInteractionSource GetInteractionSource()
		{
			return ULGUIWorldSpaceInteraction.__GetInteractionSource_Internal(base.NativePtr);
		}

		// Token: 0x0601FB08 RID: 129800 RVA: 0x002F2238 File Offset: 0x002F0438
		public float GetHoldToDragTime()
		{
			return ULGUIWorldSpaceInteraction.__GetHoldToDragTime_Internal(base.NativePtr);
		}

		// Token: 0x0601FB09 RID: 129801 RVA: 0x002F2245 File Offset: 0x002F0445
		public bool GetHoldToDrag()
		{
			return ULGUIWorldSpaceInteraction.__GetHoldToDrag_Internal(base.NativePtr);
		}

		// Token: 0x0601FB0A RID: 129802 RVA: 0x002F2252 File Offset: 0x002F0452
		public float GetClickThreshold()
		{
			return ULGUIWorldSpaceInteraction.__GetClickThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0601FB0B RID: 129803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInteractionSource_Internal(IntPtr @this, ELGUIWorldSpaceInteractionSource value);

		// Token: 0x0601FB0C RID: 129804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDragTime_Internal(IntPtr @this, float value);

		// Token: 0x0601FB0D RID: 129805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDrag_Internal(IntPtr @this, bool value);

		// Token: 0x0601FB0E RID: 129806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float value);

		// Token: 0x0601FB0F RID: 129807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUIWorldSpaceInteractionSource __GetInteractionSource_Internal(IntPtr @this);

		// Token: 0x0601FB10 RID: 129808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHoldToDragTime_Internal(IntPtr @this);

		// Token: 0x0601FB11 RID: 129809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHoldToDrag_Internal(IntPtr @this);

		// Token: 0x0601FB12 RID: 129810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClickThreshold_Internal(IntPtr @this);

		// Token: 0x0601FB13 RID: 129811 RVA: 0x002F225F File Offset: 0x002F045F
		static ULGUIWorldSpaceInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIWorldSpaceInteraction");
		}

		// Token: 0x0601FB14 RID: 129812 RVA: 0x002F226D File Offset: 0x002F046D
		protected ULGUIWorldSpaceInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011182 RID: 70018
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIWorldSpaceInteraction";

		// Token: 0x04011183 RID: 70019
		private static IntPtr _ClassPtr;

		// Token: 0x04011184 RID: 70020
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011185 RID: 70021
		internal static int __PropertyOffset_clickThreshold;

		// Token: 0x04011186 RID: 70022
		internal static int __PropertyOffset_holdToDrag;

		// Token: 0x04011187 RID: 70023
		internal static int __PropertyOffset_holdToDragTime;

		// Token: 0x04011188 RID: 70024
		internal static int __PropertyOffset_interactionSource;
	}
}
