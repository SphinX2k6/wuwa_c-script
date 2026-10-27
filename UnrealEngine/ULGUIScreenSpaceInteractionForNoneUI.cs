using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020BA RID: 8378
	[UnrealObjectPath("/Script/LGUI.LGUIScreenSpaceInteractionForNoneUI")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class ULGUIScreenSpaceInteractionForNoneUI : ULGUI_WorldRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F8F5 RID: 129269 RVA: 0x002EEA52 File Offset: 0x002ECC52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIScreenSpaceInteractionForNoneUI._ClassPtr;
		}

		// Token: 0x0601F8F6 RID: 129270 RVA: 0x002EEA60 File Offset: 0x002ECC60
		public ULGUIScreenSpaceInteractionForNoneUI() : this(BuiltinUtils.AllocNativeUObject(ULGUIScreenSpaceInteractionForNoneUI.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F8F7 RID: 129271 RVA: 0x002EEA88 File Offset: 0x002ECC88
		[NullableContext(1)]
		public ULGUIScreenSpaceInteractionForNoneUI(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIScreenSpaceInteractionForNoneUI.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C78 RID: 31864
		// (get) Token: 0x0601F8F8 RID: 129272 RVA: 0x002EEABB File Offset: 0x002ECCBB
		// (set) Token: 0x0601F8F9 RID: 129273 RVA: 0x002EEACB File Offset: 0x002ECCCB
		public unsafe float clickThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteractionForNoneUI.__PropertyOffset_clickThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteractionForNoneUI.__PropertyOffset_clickThreshold) = value;
			}
		}

		// Token: 0x17007C79 RID: 31865
		// (get) Token: 0x0601F8FA RID: 129274 RVA: 0x002EEADC File Offset: 0x002ECCDC
		// (set) Token: 0x0601F8FB RID: 129275 RVA: 0x002EEAEC File Offset: 0x002ECCEC
		public unsafe bool holdToDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteractionForNoneUI.__PropertyOffset_holdToDrag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteractionForNoneUI.__PropertyOffset_holdToDrag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007C7A RID: 31866
		// (get) Token: 0x0601F8FC RID: 129276 RVA: 0x002EEAFD File Offset: 0x002ECCFD
		// (set) Token: 0x0601F8FD RID: 129277 RVA: 0x002EEB0D File Offset: 0x002ECD0D
		public unsafe float holdToDragTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteractionForNoneUI.__PropertyOffset_holdToDragTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIScreenSpaceInteractionForNoneUI.__PropertyOffset_holdToDragTime) = value;
			}
		}

		// Token: 0x0601F8FE RID: 129278 RVA: 0x002EEB1E File Offset: 0x002ECD1E
		public void SetHoldToDragTime(float value)
		{
			ULGUIScreenSpaceInteractionForNoneUI.__SetHoldToDragTime_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F8FF RID: 129279 RVA: 0x002EEB2C File Offset: 0x002ECD2C
		public void SetHoldToDrag(bool value)
		{
			ULGUIScreenSpaceInteractionForNoneUI.__SetHoldToDrag_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F900 RID: 129280 RVA: 0x002EEB3A File Offset: 0x002ECD3A
		public void SetClickThreshold(float value)
		{
			ULGUIScreenSpaceInteractionForNoneUI.__SetClickThreshold_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F901 RID: 129281 RVA: 0x002EEB48 File Offset: 0x002ECD48
		public float GetHoldToDragTime()
		{
			return ULGUIScreenSpaceInteractionForNoneUI.__GetHoldToDragTime_Internal(base.NativePtr);
		}

		// Token: 0x0601F902 RID: 129282 RVA: 0x002EEB55 File Offset: 0x002ECD55
		public bool GetHoldToDrag()
		{
			return ULGUIScreenSpaceInteractionForNoneUI.__GetHoldToDrag_Internal(base.NativePtr);
		}

		// Token: 0x0601F903 RID: 129283 RVA: 0x002EEB62 File Offset: 0x002ECD62
		public float GetClickThreshold()
		{
			return ULGUIScreenSpaceInteractionForNoneUI.__GetClickThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0601F904 RID: 129284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDragTime_Internal(IntPtr @this, float value);

		// Token: 0x0601F905 RID: 129285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHoldToDrag_Internal(IntPtr @this, bool value);

		// Token: 0x0601F906 RID: 129286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClickThreshold_Internal(IntPtr @this, float value);

		// Token: 0x0601F907 RID: 129287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHoldToDragTime_Internal(IntPtr @this);

		// Token: 0x0601F908 RID: 129288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHoldToDrag_Internal(IntPtr @this);

		// Token: 0x0601F909 RID: 129289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClickThreshold_Internal(IntPtr @this);

		// Token: 0x0601F90A RID: 129290 RVA: 0x002EEB6F File Offset: 0x002ECD6F
		static ULGUIScreenSpaceInteractionForNoneUI()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIScreenSpaceInteractionForNoneUI");
		}

		// Token: 0x0601F90B RID: 129291 RVA: 0x002EEB7D File Offset: 0x002ECD7D
		protected ULGUIScreenSpaceInteractionForNoneUI(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401109E RID: 69790
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIScreenSpaceInteractionForNoneUI";

		// Token: 0x0401109F RID: 69791
		private static IntPtr _ClassPtr;

		// Token: 0x040110A0 RID: 69792
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040110A1 RID: 69793
		internal static int __PropertyOffset_clickThreshold;

		// Token: 0x040110A2 RID: 69794
		internal static int __PropertyOffset_holdToDrag;

		// Token: 0x040110A3 RID: 69795
		internal static int __PropertyOffset_holdToDragTime;
	}
}
