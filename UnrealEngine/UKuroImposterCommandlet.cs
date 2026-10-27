using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200198E RID: 6542
	[UnrealObjectPath("/Script/KuroImposter.KuroImposterCommandlet")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroImposterCommandlet : UCommandlet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060184EF RID: 99567 RVA: 0x0023D92A File Offset: 0x0023BB2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroImposterCommandlet._ClassPtr;
		}

		// Token: 0x060184F0 RID: 99568 RVA: 0x0023D938 File Offset: 0x0023BB38
		public UKuroImposterCommandlet() : this(BuiltinUtils.AllocNativeUObject(UKuroImposterCommandlet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060184F1 RID: 99569 RVA: 0x0023D960 File Offset: 0x0023BB60
		[NullableContext(1)]
		public UKuroImposterCommandlet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroImposterCommandlet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060184F2 RID: 99570 RVA: 0x0023D993 File Offset: 0x0023BB93
		static UKuroImposterCommandlet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroImposter.KuroImposterCommandlet");
		}

		// Token: 0x060184F3 RID: 99571 RVA: 0x0023D9A1 File Offset: 0x0023BBA1
		protected UKuroImposterCommandlet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D265 RID: 53861
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroImposter.KuroImposterCommandlet";

		// Token: 0x0400D266 RID: 53862
		private static IntPtr _ClassPtr;

		// Token: 0x0400D267 RID: 53863
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
