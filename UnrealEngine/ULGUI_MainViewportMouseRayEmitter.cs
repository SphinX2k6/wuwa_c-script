using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E2 RID: 8418
	[UnrealObjectPath("/Script/LGUI.LGUI_MainViewportMouseRayEmitter")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class ULGUI_MainViewportMouseRayEmitter : ULGUIBaseRayEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB37 RID: 129847 RVA: 0x002F2466 File Offset: 0x002F0666
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_MainViewportMouseRayEmitter._ClassPtr;
		}

		// Token: 0x0601FB38 RID: 129848 RVA: 0x002F2474 File Offset: 0x002F0674
		public ULGUI_MainViewportMouseRayEmitter() : this(BuiltinUtils.AllocNativeUObject(ULGUI_MainViewportMouseRayEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB39 RID: 129849 RVA: 0x002F249C File Offset: 0x002F069C
		[NullableContext(1)]
		public ULGUI_MainViewportMouseRayEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_MainViewportMouseRayEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FB3A RID: 129850 RVA: 0x002F24CF File Offset: 0x002F06CF
		static ULGUI_MainViewportMouseRayEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_MainViewportMouseRayEmitter");
		}

		// Token: 0x0601FB3B RID: 129851 RVA: 0x002F24DD File Offset: 0x002F06DD
		protected ULGUI_MainViewportMouseRayEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011193 RID: 70035
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_MainViewportMouseRayEmitter";

		// Token: 0x04011194 RID: 70036
		private static IntPtr _ClassPtr;

		// Token: 0x04011195 RID: 70037
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
