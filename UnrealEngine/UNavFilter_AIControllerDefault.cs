using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001CE RID: 462
	[UnrealObjectPath("/Script/AIModule.NavFilter_AIControllerDefault")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UNavFilter_AIControllerDefault : UNavigationQueryFilter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B41 RID: 6977 RVA: 0x00028B13 File Offset: 0x00026D13
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavFilter_AIControllerDefault._ClassPtr;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00028B20 File Offset: 0x00026D20
		public UNavFilter_AIControllerDefault() : this(BuiltinUtils.AllocNativeUObject(UNavFilter_AIControllerDefault.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00028B48 File Offset: 0x00026D48
		[NullableContext(1)]
		public UNavFilter_AIControllerDefault(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavFilter_AIControllerDefault.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00028B7B File Offset: 0x00026D7B
		static UNavFilter_AIControllerDefault()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.NavFilter_AIControllerDefault");
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00028B89 File Offset: 0x00026D89
		protected UNavFilter_AIControllerDefault(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008B8 RID: 2232
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.NavFilter_AIControllerDefault";

		// Token: 0x040008B9 RID: 2233
		private static IntPtr _ClassPtr;

		// Token: 0x040008BA RID: 2234
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
