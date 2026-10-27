using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200137A RID: 4986
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueTranslator_Test")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UGameplayCueTranslator_Test : UGameplayCueTranslator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060124B7 RID: 74935 RVA: 0x001ADA47 File Offset: 0x001ABC47
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayCueTranslator_Test._ClassPtr;
		}

		// Token: 0x060124B8 RID: 74936 RVA: 0x001ADA54 File Offset: 0x001ABC54
		public UGameplayCueTranslator_Test() : this(BuiltinUtils.AllocNativeUObject(UGameplayCueTranslator_Test.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060124B9 RID: 74937 RVA: 0x001ADA7C File Offset: 0x001ABC7C
		[NullableContext(1)]
		public UGameplayCueTranslator_Test(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayCueTranslator_Test.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060124BA RID: 74938 RVA: 0x001ADAAF File Offset: 0x001ABCAF
		static UGameplayCueTranslator_Test()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayCueTranslator_Test");
		}

		// Token: 0x060124BB RID: 74939 RVA: 0x001ADABD File Offset: 0x001ABCBD
		protected UGameplayCueTranslator_Test(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009CA7 RID: 40103
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueTranslator_Test";

		// Token: 0x04009CA8 RID: 40104
		private static IntPtr _ClassPtr;

		// Token: 0x04009CA9 RID: 40105
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
