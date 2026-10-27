using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009DA RID: 2522
	[UnrealObjectPath("/Script/Engine.DrawSphereComponent")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UDrawSphereComponent : USphereComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E87 RID: 36487 RVA: 0x000CBD34 File Offset: 0x000C9F34
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDrawSphereComponent._ClassPtr;
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x000CBD40 File Offset: 0x000C9F40
		public UDrawSphereComponent() : this(BuiltinUtils.AllocNativeUObject(UDrawSphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x000CBD68 File Offset: 0x000C9F68
		[NullableContext(1)]
		public UDrawSphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDrawSphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x000CBD9B File Offset: 0x000C9F9B
		static UDrawSphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DrawSphereComponent");
		}

		// Token: 0x06008E8B RID: 36491 RVA: 0x000CBDA9 File Offset: 0x000C9FA9
		protected UDrawSphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043CD RID: 17357
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DrawSphereComponent";

		// Token: 0x040043CE RID: 17358
		private static IntPtr _ClassPtr;

		// Token: 0x040043CF RID: 17359
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
