using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000349 RID: 841
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionShapeComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public abstract class UKuroRegionShapeComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005649 RID: 22089 RVA: 0x00078F4D File Offset: 0x0007714D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionShapeComponent._ClassPtr;
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x00078F59 File Offset: 0x00077159
		static UKuroRegionShapeComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionShapeComponent");
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00078F68 File Offset: 0x00077168
		protected UKuroRegionShapeComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionShapeComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00078F90 File Offset: 0x00077190
		protected UKuroRegionShapeComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002364 RID: 9060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionShapeComponent";

		// Token: 0x04002365 RID: 9061
		private static IntPtr _ClassPtr;

		// Token: 0x04002366 RID: 9062
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
