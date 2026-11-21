using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003FF RID: 1023
	[UnrealObjectPath("/Script/KuroGameplay.KuroRoadwayIntersection")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroRoadwayIntersection : UKuroRoadway, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600645E RID: 25694 RVA: 0x0008F614 File Offset: 0x0008D814
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRoadwayIntersection._ClassPtr;
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x0008F620 File Offset: 0x0008D820
		public UKuroRoadwayIntersection() : this(BuiltinUtils.AllocNativeUObject(UKuroRoadwayIntersection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x0008F648 File Offset: 0x0008D848
		[NullableContext(1)]
		public UKuroRoadwayIntersection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRoadwayIntersection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x0008F67B File Offset: 0x0008D87B
		static UKuroRoadwayIntersection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroRoadwayIntersection");
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x0008F689 File Offset: 0x0008D889
		protected UKuroRoadwayIntersection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A5B RID: 10843
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroRoadwayIntersection";

		// Token: 0x04002A5C RID: 10844
		private static IntPtr _ClassPtr;

		// Token: 0x04002A5D RID: 10845
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
