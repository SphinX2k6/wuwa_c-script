using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000669 RID: 1641
	[UnrealObjectPath("/Script/LGUI.LGUIBaseRaycaster")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public abstract class ULGUIBaseRaycaster : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DF8 RID: 36344 RVA: 0x000D5D11 File Offset: 0x000D3F11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBaseRaycaster._ClassPtr;
		}

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x000D5D1D File Offset: 0x000D3F1D
		// (set) Token: 0x06008DFA RID: 36346 RVA: 0x000D5D2D File Offset: 0x000D3F2D
		public unsafe int depth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_depth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_depth) = value;
			}
		}

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x06008DFB RID: 36347 RVA: 0x000D5D3E File Offset: 0x000D3F3E
		// (set) Token: 0x06008DFC RID: 36348 RVA: 0x000D5D4E File Offset: 0x000D3F4E
		public unsafe float rayLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_rayLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_rayLength) = value;
			}
		}

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x06008DFD RID: 36349 RVA: 0x000D5D5F File Offset: 0x000D3F5F
		// (set) Token: 0x06008DFE RID: 36350 RVA: 0x000D5D73 File Offset: 0x000D3F73
		public unsafe TEnumAsByte<ETraceTypeQuery> traceChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_traceChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_traceChannel) = value;
			}
		}

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x000D5D88 File Offset: 0x000D3F88
		// (set) Token: 0x06008E00 RID: 36352 RVA: 0x000D5D98 File Offset: 0x000D3F98
		public unsafe ELGUIEventFireType eventFireType
		{
			get
			{
				return (ELGUIEventFireType)(*(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_eventFireType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBaseRaycaster.__PropertyOffset_eventFireType) = (byte)value;
			}
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x000D5DA9 File Offset: 0x000D3FA9
		public void DeactivateRaycaster()
		{
			ULGUIBaseRaycaster.__DeactivateRaycaster_Internal(base.NativePtr);
		}

		// Token: 0x06008E02 RID: 36354 RVA: 0x000D5DB6 File Offset: 0x000D3FB6
		public void ActivateRaycaster()
		{
			ULGUIBaseRaycaster.__ActivateRaycaster_Internal(base.NativePtr);
		}

		// Token: 0x06008E03 RID: 36355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateRaycaster_Internal(IntPtr @this);

		// Token: 0x06008E04 RID: 36356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateRaycaster_Internal(IntPtr @this);

		// Token: 0x06008E05 RID: 36357 RVA: 0x000D5DC3 File Offset: 0x000D3FC3
		static ULGUIBaseRaycaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBaseRaycaster");
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x000D5DD4 File Offset: 0x000D3FD4
		protected ULGUIBaseRaycaster() : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseRaycaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x000D5DFC File Offset: 0x000D3FFC
		protected ULGUIBaseRaycaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E91 RID: 16017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBaseRaycaster";

		// Token: 0x04003E92 RID: 16018
		private static IntPtr _ClassPtr;

		// Token: 0x04003E93 RID: 16019
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003E94 RID: 16020
		internal static int __PropertyOffset_depth;

		// Token: 0x04003E95 RID: 16021
		internal static int __PropertyOffset_rayLength;

		// Token: 0x04003E96 RID: 16022
		internal static int __PropertyOffset_traceChannel;

		// Token: 0x04003E97 RID: 16023
		internal static int __PropertyOffset_eventFireType;
	}
}
