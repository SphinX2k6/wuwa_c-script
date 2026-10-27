using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F7 RID: 5623
	[UnrealObjectPath("/Script/KuroAI.BTSaveLoadComposite_Selector")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UBTSaveLoadComposite_Selector : UBTSaveLoadCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143F1 RID: 82929 RVA: 0x001DBAA5 File Offset: 0x001D9CA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTSaveLoadComposite_Selector._ClassPtr;
		}

		// Token: 0x060143F2 RID: 82930 RVA: 0x001DBAB4 File Offset: 0x001D9CB4
		public UBTSaveLoadComposite_Selector() : this(BuiltinUtils.AllocNativeUObject(UBTSaveLoadComposite_Selector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143F3 RID: 82931 RVA: 0x001DBADC File Offset: 0x001D9CDC
		[NullableContext(1)]
		public UBTSaveLoadComposite_Selector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTSaveLoadComposite_Selector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060143F4 RID: 82932 RVA: 0x001DBB0F File Offset: 0x001D9D0F
		static UBTSaveLoadComposite_Selector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTSaveLoadComposite_Selector");
		}

		// Token: 0x060143F5 RID: 82933 RVA: 0x001DBB1D File Offset: 0x001D9D1D
		protected UBTSaveLoadComposite_Selector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B03D RID: 45117
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.BTSaveLoadComposite_Selector";

		// Token: 0x0400B03E RID: 45118
		private static IntPtr _ClassPtr;

		// Token: 0x0400B03F RID: 45119
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
