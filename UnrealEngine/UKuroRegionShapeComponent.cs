using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001760 RID: 5984
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionShapeComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public abstract class UKuroRegionShapeComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015833 RID: 88115 RVA: 0x001F9CBD File Offset: 0x001F7EBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionShapeComponent._ClassPtr;
		}

		// Token: 0x06015834 RID: 88116 RVA: 0x001F9CC9 File Offset: 0x001F7EC9
		static UKuroRegionShapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionShapeComponent");
		}

		// Token: 0x06015835 RID: 88117 RVA: 0x001F9CD8 File Offset: 0x001F7ED8
		protected UKuroRegionShapeComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionShapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015836 RID: 88118 RVA: 0x001F9D00 File Offset: 0x001F7F00
		protected UKuroRegionShapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBCA RID: 48074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionShapeComponent";

		// Token: 0x0400BBCB RID: 48075
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBCC RID: 48076
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
