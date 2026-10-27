using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000135 RID: 309
	[UnrealObjectPath("/Script/AIModule.BTComposite_Selector")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UBTComposite_Selector : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x00020239 File Offset: 0x0001E439
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_Selector._ClassPtr;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00020248 File Offset: 0x0001E448
		public UBTComposite_Selector() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Selector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00020270 File Offset: 0x0001E470
		[NullableContext(1)]
		public UBTComposite_Selector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTComposite_Selector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x000202A3 File Offset: 0x0001E4A3
		static UBTComposite_Selector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTComposite_Selector");
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x000202B1 File Offset: 0x0001E4B1
		protected UBTComposite_Selector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004C9 RID: 1225
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTComposite_Selector";

		// Token: 0x040004CA RID: 1226
		private static IntPtr _ClassPtr;

		// Token: 0x040004CB RID: 1227
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
