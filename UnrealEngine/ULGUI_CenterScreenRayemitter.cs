using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E1 RID: 8417
	[UnrealObjectPath("/Script/LGUI.LGUI_CenterScreenRayemitter")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class ULGUI_CenterScreenRayemitter : ULGUIBaseRayEmitter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB32 RID: 129842 RVA: 0x002F23E6 File Offset: 0x002F05E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_CenterScreenRayemitter._ClassPtr;
		}

		// Token: 0x0601FB33 RID: 129843 RVA: 0x002F23F4 File Offset: 0x002F05F4
		public ULGUI_CenterScreenRayemitter() : this(BuiltinUtils.AllocNativeUObject(ULGUI_CenterScreenRayemitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB34 RID: 129844 RVA: 0x002F241C File Offset: 0x002F061C
		[NullableContext(1)]
		public ULGUI_CenterScreenRayemitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_CenterScreenRayemitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FB35 RID: 129845 RVA: 0x002F244F File Offset: 0x002F064F
		static ULGUI_CenterScreenRayemitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_CenterScreenRayemitter");
		}

		// Token: 0x0601FB36 RID: 129846 RVA: 0x002F245D File Offset: 0x002F065D
		protected ULGUI_CenterScreenRayemitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011190 RID: 70032
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_CenterScreenRayemitter";

		// Token: 0x04011191 RID: 70033
		private static IntPtr _ClassPtr;

		// Token: 0x04011192 RID: 70034
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
