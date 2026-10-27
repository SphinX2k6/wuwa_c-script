using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020B9 RID: 8377
	[UnrealObjectPath("/Script/LGUI.LGUIScreenSpaceInteraction")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class ULGUIScreenSpaceInteraction : ULGUI_UIRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8DE RID: 129246 RVA: 0x002EE920 File Offset: 0x002ECB20
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIScreenSpaceInteraction._ClassPtr;
		}

		// Token: 0x0601F8DF RID: 129247 RVA: 0x002EE92C File Offset: 0x002ECB2C
		public ULGUIScreenSpaceInteraction() : this(BuiltinUtils.AllocNativeUObject(ULGUIScreenSpaceInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8E0 RID: 129248 RVA: 0x002EE954 File Offset: 0x002ECB54
		[NullableContext(1)]
		public ULGUIScreenSpaceInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIScreenSpaceInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C75 RID: 31861
		// (get) Token: 0x0601F8E1 RID: 129249 RVA: 0x002EE987 File Offset: 0x002ECB87
		// (set) Token: 0x0601F8E2 RID: 129250 RVA: 0x002EE997 File Offset: 0x002ECB97
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

		// Token: 0x17007C76 RID: 31862
		// (get) Token: 0x0601F8E3 RID: 129251 RVA: 0x002EE9A8 File Offset: 0x002ECBA8
		// (set) Token: 0x0601F8E4 RID: 129252 RVA: 0x002EE9B8 File Offset: 0x002ECBB8
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

		// Token: 0x17007C77 RID: 31863
		// (get) Token: 0x0601F8E5 RID: 129253 RVA: 0x002EE9C9 File Offset: 0x002ECBC9
		// (set) Token: 0x0601F8E6 RID: 129254 RVA: 0x002EE9D9 File Offset: 0x002ECBD9
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

		// Token: 0x0601F8E7 RID: 129255 RVA: 0x002EE9EA File Offset: 0x002ECBEA
		public void SetHoldToDragTime(float value)
		{
			ULGUIScreenSpaceInteraction.__SetHoldToDragTime_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F8E8 RID: 129256 RVA: 0x002EE9F8 File Offset: 0x002ECBF8
		public void SetHoldToDrag(bool value)
		{
			ULGUIScreenSpaceInteraction.__SetHoldToDrag_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F8E9 RID: 129257 RVA: 0x002EEA06 File Offset: 0x002ECC06
		public void SetClickThreshold(float value)
		{
			ULGUIScreenSpaceInteraction.__SetClickThreshold_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F8EA RID: 129258 RVA: 0x002EEA14 File Offset: 0x002ECC14
		public float GetHoldToDragTime()
		{
			return ULGUIScreenSpaceInteraction.__GetHoldToDragTime_Internal(base.NativePtr);
		}

		// Token: 0x0601F8EB RID: 129259 RVA: 0x002EEA21 File Offset: 0x002ECC21
		public bool GetHoldToDrag()
		{
			return ULGUIScreenSpaceInteraction.__GetHoldToDrag_Internal(base.NativePtr);
		}

		// Token: 0x0601F8EC RID: 129260 RVA: 0x002EEA2E File Offset: 0x002ECC2E
		public float GetClickThreshold()
		{
			return ULGUIScreenSpaceInteraction.__GetClickThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0601F8ED RID: 129261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDragTime_Internal(IntPtr @this, float value);

		// Token: 0x0601F8EE RID: 129262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDrag_Internal(IntPtr @this, bool value);

		// Token: 0x0601F8EF RID: 129263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float value);

		// Token: 0x0601F8F0 RID: 129264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHoldToDragTime_Internal(IntPtr @this);

		// Token: 0x0601F8F1 RID: 129265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHoldToDrag_Internal(IntPtr @this);

		// Token: 0x0601F8F2 RID: 129266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClickThreshold_Internal(IntPtr @this);

		// Token: 0x0601F8F3 RID: 129267 RVA: 0x002EEA3B File Offset: 0x002ECC3B
		static ULGUIScreenSpaceInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIScreenSpaceInteraction");
		}

		// Token: 0x0601F8F4 RID: 129268 RVA: 0x002EEA49 File Offset: 0x002ECC49
		protected ULGUIScreenSpaceInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011098 RID: 69784
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIScreenSpaceInteraction";

		// Token: 0x04011099 RID: 69785
		private static IntPtr _ClassPtr;

		// Token: 0x0401109A RID: 69786
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401109B RID: 69787
		internal static int __PropertyOffset_clickThreshold;

		// Token: 0x0401109C RID: 69788
		internal static int __PropertyOffset_holdToDrag;

		// Token: 0x0401109D RID: 69789
		internal static int __PropertyOffset_holdToDragTime;
	}
}
