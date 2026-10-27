using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020EA RID: 8426
	[UnrealObjectPath("/Script/LGUI.LGUI_WorldRaycaster")]
	[UnrealStructLayout(640, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class ULGUI_WorldRaycaster : ULGUIBaseRaycaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FBB6 RID: 129974 RVA: 0x002F2D3C File Offset: 0x002F0F3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_WorldRaycaster._ClassPtr;
		}

		// Token: 0x0601FBB7 RID: 129975 RVA: 0x002F2D48 File Offset: 0x002F0F48
		public ULGUI_WorldRaycaster() : this(BuiltinUtils.AllocNativeUObject(ULGUI_WorldRaycaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FBB8 RID: 129976 RVA: 0x002F2D70 File Offset: 0x002F0F70
		[NullableContext(1)]
		public ULGUI_WorldRaycaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_WorldRaycaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FBB9 RID: 129977 RVA: 0x002F2DA3 File Offset: 0x002F0FA3
		static ULGUI_WorldRaycaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_WorldRaycaster");
		}

		// Token: 0x0601FBBA RID: 129978 RVA: 0x002F2DB1 File Offset: 0x002F0FB1
		protected ULGUI_WorldRaycaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040111B6 RID: 70070
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_WorldRaycaster";

		// Token: 0x040111B7 RID: 70071
		private static IntPtr _ClassPtr;

		// Token: 0x040111B8 RID: 70072
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
