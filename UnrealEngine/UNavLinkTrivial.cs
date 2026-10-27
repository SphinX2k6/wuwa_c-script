using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200249F RID: 9375
	[UnrealObjectPath("/Script/NavigationSystem.NavLinkTrivial")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UNavLinkTrivial : UNavLinkDefinition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023186 RID: 143750 RVA: 0x0033E67A File Offset: 0x0033C87A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavLinkTrivial._ClassPtr;
		}

		// Token: 0x06023187 RID: 143751 RVA: 0x0033E688 File Offset: 0x0033C888
		public UNavLinkTrivial() : this(BuiltinUtils.AllocNativeUObject(UNavLinkTrivial.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023188 RID: 143752 RVA: 0x0033E6B0 File Offset: 0x0033C8B0
		[NullableContext(1)]
		public UNavLinkTrivial(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavLinkTrivial.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023189 RID: 143753 RVA: 0x0033E6E3 File Offset: 0x0033C8E3
		static UNavLinkTrivial()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavLinkTrivial");
		}

		// Token: 0x0602318A RID: 143754 RVA: 0x0033E6F1 File Offset: 0x0033C8F1
		protected UNavLinkTrivial(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BC4 RID: 76740
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavLinkTrivial";

		// Token: 0x04012BC5 RID: 76741
		private static IntPtr _ClassPtr;

		// Token: 0x04012BC6 RID: 76742
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
