using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E6 RID: 8422
	[UnrealObjectPath("/Script/LGUI.LGUI_ScreenSpaceUIMouseRayemitter")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class ULGUI_ScreenSpaceUIMouseRayemitter : ULGUIBaseRayEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB80 RID: 129920 RVA: 0x002F2920 File Offset: 0x002F0B20
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_ScreenSpaceUIMouseRayemitter._ClassPtr;
		}

		// Token: 0x0601FB81 RID: 129921 RVA: 0x002F292C File Offset: 0x002F0B2C
		public ULGUI_ScreenSpaceUIMouseRayemitter() : this(BuiltinUtils.AllocNativeUObject(ULGUI_ScreenSpaceUIMouseRayemitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB82 RID: 129922 RVA: 0x002F2954 File Offset: 0x002F0B54
		[NullableContext(1)]
		public ULGUI_ScreenSpaceUIMouseRayemitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_ScreenSpaceUIMouseRayemitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CED RID: 31981
		// (get) Token: 0x0601FB83 RID: 129923 RVA: 0x002F2987 File Offset: 0x002F0B87
		// (set) Token: 0x0601FB84 RID: 129924 RVA: 0x002F299B File Offset: 0x002F0B9B
		[Nullable(2)]
		public unsafe ULGUICanvas RenderCanvas
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUICanvas>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_ScreenSpaceUIMouseRayemitter.__PropertyOffset_RenderCanvas);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUI_ScreenSpaceUIMouseRayemitter.__PropertyOffset_RenderCanvas, value);
			}
		}

		// Token: 0x0601FB85 RID: 129925 RVA: 0x002F29B0 File Offset: 0x002F0BB0
		static ULGUI_ScreenSpaceUIMouseRayemitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_ScreenSpaceUIMouseRayemitter");
		}

		// Token: 0x0601FB86 RID: 129926 RVA: 0x002F29BE File Offset: 0x002F0BBE
		protected ULGUI_ScreenSpaceUIMouseRayemitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040111A6 RID: 70054
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_ScreenSpaceUIMouseRayemitter";

		// Token: 0x040111A7 RID: 70055
		private static IntPtr _ClassPtr;

		// Token: 0x040111A8 RID: 70056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040111A9 RID: 70057
		internal static int __PropertyOffset_RenderCanvas;
	}
}
