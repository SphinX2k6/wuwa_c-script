using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001700 RID: 5888
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletObstacle")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroBulletObstacle : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015444 RID: 87108 RVA: 0x001F41CB File Offset: 0x001F23CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletObstacle._ClassPtr;
		}

		// Token: 0x06015445 RID: 87109 RVA: 0x001F41D8 File Offset: 0x001F23D8
		public UKuroBulletObstacle() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletObstacle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015446 RID: 87110 RVA: 0x001F4200 File Offset: 0x001F2400
		[NullableContext(1)]
		public UKuroBulletObstacle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletObstacle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015447 RID: 87111 RVA: 0x001F4233 File Offset: 0x001F2433
		static UKuroBulletObstacle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletObstacle");
		}

		// Token: 0x06015448 RID: 87112 RVA: 0x001F4241 File Offset: 0x001F2441
		protected UKuroBulletObstacle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B986 RID: 47494
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletObstacle";

		// Token: 0x0400B987 RID: 47495
		private static IntPtr _ClassPtr;

		// Token: 0x0400B988 RID: 47496
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
