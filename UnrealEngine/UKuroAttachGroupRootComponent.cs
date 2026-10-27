using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C8C RID: 7308
	[UnrealObjectPath("/Script/KuroScene.KuroAttachGroupRootComponent")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UKuroAttachGroupRootComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C5CB RID: 116171 RVA: 0x0029CEEC File Offset: 0x0029B0EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAttachGroupRootComponent._ClassPtr;
		}

		// Token: 0x0601C5CC RID: 116172 RVA: 0x0029CEF8 File Offset: 0x0029B0F8
		public UKuroAttachGroupRootComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAttachGroupRootComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C5CD RID: 116173 RVA: 0x0029CF20 File Offset: 0x0029B120
		[NullableContext(1)]
		public UKuroAttachGroupRootComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAttachGroupRootComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601C5CE RID: 116174 RVA: 0x0029CF53 File Offset: 0x0029B153
		static UKuroAttachGroupRootComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroScene.KuroAttachGroupRootComponent");
		}

		// Token: 0x0601C5CF RID: 116175 RVA: 0x0029CF61 File Offset: 0x0029B161
		protected UKuroAttachGroupRootComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F3E5 RID: 62437
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroScene.KuroAttachGroupRootComponent";

		// Token: 0x0400F3E6 RID: 62438
		private static IntPtr _ClassPtr;

		// Token: 0x0400F3E7 RID: 62439
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
