using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F8 RID: 5624
	[UnrealObjectPath("/Script/KuroAI.BTSaveLoadComposite_Sequence")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UBTSaveLoadComposite_Sequence : UBTSaveLoadCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143F6 RID: 82934 RVA: 0x001DBB26 File Offset: 0x001D9D26
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTSaveLoadComposite_Sequence._ClassPtr;
		}

		// Token: 0x060143F7 RID: 82935 RVA: 0x001DBB34 File Offset: 0x001D9D34
		public UBTSaveLoadComposite_Sequence() : this(BuiltinUtils.AllocNativeUObject(UBTSaveLoadComposite_Sequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143F8 RID: 82936 RVA: 0x001DBB5C File Offset: 0x001D9D5C
		[NullableContext(1)]
		public UBTSaveLoadComposite_Sequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTSaveLoadComposite_Sequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060143F9 RID: 82937 RVA: 0x001DBB8F File Offset: 0x001D9D8F
		static UBTSaveLoadComposite_Sequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTSaveLoadComposite_Sequence");
		}

		// Token: 0x060143FA RID: 82938 RVA: 0x001DBB9D File Offset: 0x001D9D9D
		protected UBTSaveLoadComposite_Sequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B040 RID: 45120
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.BTSaveLoadComposite_Sequence";

		// Token: 0x0400B041 RID: 45121
		private static IntPtr _ClassPtr;

		// Token: 0x0400B042 RID: 45122
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
