using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CF RID: 1743
	[UnrealObjectPath("/Script/LGUI.LGUI_UIRaycaster")]
	[UnrealStructLayout(656, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class ULGUI_UIRaycaster : ULGUIBaseRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060094A7 RID: 38055 RVA: 0x000E017C File Offset: 0x000DE37C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_UIRaycaster._ClassPtr;
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x000E0188 File Offset: 0x000DE388
		public ULGUI_UIRaycaster() : this(BuiltinUtils.AllocNativeUObject(ULGUI_UIRaycaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x000E01B0 File Offset: 0x000DE3B0
		[NullableContext(1)]
		public ULGUI_UIRaycaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_UIRaycaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x060094AA RID: 38058 RVA: 0x000E01E3 File Offset: 0x000DE3E3
		// (set) Token: 0x060094AB RID: 38059 RVA: 0x000E01F3 File Offset: 0x000DE3F3
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

		// Token: 0x060094AC RID: 38060 RVA: 0x000E0204 File Offset: 0x000DE404
		static ULGUI_UIRaycaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_UIRaycaster");
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x000E0212 File Offset: 0x000DE412
		protected ULGUI_UIRaycaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040040AA RID: 16554
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_UIRaycaster";

		// Token: 0x040040AB RID: 16555
		private static IntPtr _ClassPtr;

		// Token: 0x040040AC RID: 16556
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040040AD RID: 16557
		internal static int __PropertyOffset_uiSortDependOnDistanceThreshold;
	}
}
