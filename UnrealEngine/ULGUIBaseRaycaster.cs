using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002023 RID: 8227
	[UnrealObjectPath("/Script/LGUI.LGUIBaseRaycaster")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public abstract class ULGUIBaseRaycaster : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFD8 RID: 126936 RVA: 0x002E15B9 File Offset: 0x002DF7B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBaseRaycaster._ClassPtr;
		}

		// Token: 0x17007B54 RID: 31572
		// (get) Token: 0x0601EFD9 RID: 126937 RVA: 0x002E15C5 File Offset: 0x002DF7C5
		// (set) Token: 0x0601EFDA RID: 126938 RVA: 0x002E15D5 File Offset: 0x002DF7D5
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

		// Token: 0x17007B55 RID: 31573
		// (get) Token: 0x0601EFDB RID: 126939 RVA: 0x002E15E6 File Offset: 0x002DF7E6
		// (set) Token: 0x0601EFDC RID: 126940 RVA: 0x002E15F6 File Offset: 0x002DF7F6
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

		// Token: 0x17007B56 RID: 31574
		// (get) Token: 0x0601EFDD RID: 126941 RVA: 0x002E1607 File Offset: 0x002DF807
		// (set) Token: 0x0601EFDE RID: 126942 RVA: 0x002E161B File Offset: 0x002DF81B
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

		// Token: 0x17007B57 RID: 31575
		// (get) Token: 0x0601EFDF RID: 126943 RVA: 0x002E1630 File Offset: 0x002DF830
		// (set) Token: 0x0601EFE0 RID: 126944 RVA: 0x002E1640 File Offset: 0x002DF840
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

		// Token: 0x17007B58 RID: 31576
		// (get) Token: 0x0601EFE1 RID: 126945 RVA: 0x002E1651 File Offset: 0x002DF851
		// (set) Token: 0x0601EFE2 RID: 126946 RVA: 0x002E1665 File Offset: 0x002DF865
		[Nullable(2)]
		public unsafe ULGUIBaseRayEmitter rayEmitter
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUIBaseRayEmitter>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIBaseRaycaster.__PropertyOffset_rayEmitter);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUIBaseRaycaster.__PropertyOffset_rayEmitter, value);
			}
		}

		// Token: 0x0601EFE3 RID: 126947 RVA: 0x002E167A File Offset: 0x002DF87A
		public void DeactivateRaycaster()
		{
			ULGUIBaseRaycaster.__DeactivateRaycaster_Internal(base.NativePtr);
		}

		// Token: 0x0601EFE4 RID: 126948 RVA: 0x002E1687 File Offset: 0x002DF887
		public void ActivateRaycaster()
		{
			ULGUIBaseRaycaster.__ActivateRaycaster_Internal(base.NativePtr);
		}

		// Token: 0x0601EFE5 RID: 126949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateRaycaster_Internal(IntPtr @this);

		// Token: 0x0601EFE6 RID: 126950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateRaycaster_Internal(IntPtr @this);

		// Token: 0x0601EFE7 RID: 126951 RVA: 0x002E1694 File Offset: 0x002DF894
		static ULGUIBaseRaycaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBaseRaycaster");
		}

		// Token: 0x0601EFE8 RID: 126952 RVA: 0x002E16A4 File Offset: 0x002DF8A4
		protected ULGUIBaseRaycaster() : this(BuiltinUtils.AllocNativeUObject(ULGUIBaseRaycaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFE9 RID: 126953 RVA: 0x002E16CC File Offset: 0x002DF8CC
		protected ULGUIBaseRaycaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D89 RID: 69001
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBaseRaycaster";

		// Token: 0x04010D8A RID: 69002
		private static IntPtr _ClassPtr;

		// Token: 0x04010D8B RID: 69003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D8C RID: 69004
		internal static int __PropertyOffset_depth;

		// Token: 0x04010D8D RID: 69005
		internal static int __PropertyOffset_rayLength;

		// Token: 0x04010D8E RID: 69006
		internal static int __PropertyOffset_traceChannel;

		// Token: 0x04010D8F RID: 69007
		internal static int __PropertyOffset_eventFireType;

		// Token: 0x04010D90 RID: 69008
		internal static int __PropertyOffset_rayEmitter;
	}
}
