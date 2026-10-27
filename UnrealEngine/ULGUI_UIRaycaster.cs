using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E9 RID: 8425
	[UnrealObjectPath("/Script/LGUI.LGUI_UIRaycaster")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class ULGUI_UIRaycaster : ULGUIBaseRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FBAD RID: 129965 RVA: 0x002F2C7C File Offset: 0x002F0E7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_UIRaycaster._ClassPtr;
		}

		// Token: 0x0601FBAE RID: 129966 RVA: 0x002F2C88 File Offset: 0x002F0E88
		public ULGUI_UIRaycaster() : this(BuiltinUtils.AllocNativeUObject(ULGUI_UIRaycaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FBAF RID: 129967 RVA: 0x002F2CB0 File Offset: 0x002F0EB0
		[NullableContext(1)]
		public ULGUI_UIRaycaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_UIRaycaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CEF RID: 31983
		// (get) Token: 0x0601FBB0 RID: 129968 RVA: 0x002F2CE3 File Offset: 0x002F0EE3
		// (set) Token: 0x0601FBB1 RID: 129969 RVA: 0x002F2CF3 File Offset: 0x002F0EF3
		public unsafe EUIRaycastSortType uiSortType
		{
			get
			{
				return (EUIRaycastSortType)(*(base.NativePtr + (IntPtr)ULGUI_UIRaycaster.__PropertyOffset_uiSortType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUI_UIRaycaster.__PropertyOffset_uiSortType) = (byte)value;
			}
		}

		// Token: 0x17007CF0 RID: 31984
		// (get) Token: 0x0601FBB2 RID: 129970 RVA: 0x002F2D04 File Offset: 0x002F0F04
		// (set) Token: 0x0601FBB3 RID: 129971 RVA: 0x002F2D14 File Offset: 0x002F0F14
		public unsafe float uiSortDependOnDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUI_UIRaycaster.__PropertyOffset_uiSortDependOnDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUI_UIRaycaster.__PropertyOffset_uiSortDependOnDistanceThreshold) = value;
			}
		}

		// Token: 0x0601FBB4 RID: 129972 RVA: 0x002F2D25 File Offset: 0x002F0F25
		static ULGUI_UIRaycaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_UIRaycaster");
		}

		// Token: 0x0601FBB5 RID: 129973 RVA: 0x002F2D33 File Offset: 0x002F0F33
		protected ULGUI_UIRaycaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040111B1 RID: 70065
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_UIRaycaster";

		// Token: 0x040111B2 RID: 70066
		private static IntPtr _ClassPtr;

		// Token: 0x040111B3 RID: 70067
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040111B4 RID: 70068
		internal static int __PropertyOffset_uiSortType;

		// Token: 0x040111B5 RID: 70069
		internal static int __PropertyOffset_uiSortDependOnDistanceThreshold;
	}
}
