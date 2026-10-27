using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001905 RID: 6405
	[UnrealObjectPath("/Script/KuroGameplay.KuroRoadwayIntersection")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroRoadwayIntersection : UKuroRoadway, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C69 RID: 97385 RVA: 0x0022D4E9 File Offset: 0x0022B6E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRoadwayIntersection._ClassPtr;
		}

		// Token: 0x06017C6A RID: 97386 RVA: 0x0022D4F8 File Offset: 0x0022B6F8
		public UKuroRoadwayIntersection() : this(BuiltinUtils.AllocNativeUObject(UKuroRoadwayIntersection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C6B RID: 97387 RVA: 0x0022D520 File Offset: 0x0022B720
		[NullableContext(1)]
		public UKuroRoadwayIntersection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRoadwayIntersection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017C6C RID: 97388 RVA: 0x0022D553 File Offset: 0x0022B753
		static UKuroRoadwayIntersection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroRoadwayIntersection");
		}

		// Token: 0x06017C6D RID: 97389 RVA: 0x0022D561 File Offset: 0x0022B761
		protected UKuroRoadwayIntersection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE55 RID: 52821
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroRoadwayIntersection";

		// Token: 0x0400CE56 RID: 52822
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE57 RID: 52823
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
