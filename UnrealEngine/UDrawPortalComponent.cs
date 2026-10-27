using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000269 RID: 617
	[UnrealObjectPath("/Script/AkAudio.DrawPortalComponent")]
	[UnrealStructLayout(1568, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class UDrawPortalComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002401 RID: 9217 RVA: 0x00035698 File Offset: 0x00033898
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDrawPortalComponent._ClassPtr;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x000356A4 File Offset: 0x000338A4
		public UDrawPortalComponent() : this(BuiltinUtils.AllocNativeUObject(UDrawPortalComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x000356CC File Offset: 0x000338CC
		[NullableContext(1)]
		public UDrawPortalComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDrawPortalComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000356FF File Offset: 0x000338FF
		static UDrawPortalComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.DrawPortalComponent");
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0003570D File Offset: 0x0003390D
		protected UDrawPortalComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C88 RID: 3208
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.DrawPortalComponent";

		// Token: 0x04000C89 RID: 3209
		private static IntPtr _ClassPtr;

		// Token: 0x04000C8A RID: 3210
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
