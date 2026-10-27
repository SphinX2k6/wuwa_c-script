using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200132B RID: 4907
	[UnrealObjectPath("/Script/GameplayAbilities.AttributeSet")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAttributeSet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012124 RID: 74020 RVA: 0x001A8AAE File Offset: 0x001A6CAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAttributeSet._ClassPtr;
		}

		// Token: 0x06012125 RID: 74021 RVA: 0x001A8ABC File Offset: 0x001A6CBC
		public UAttributeSet() : this(BuiltinUtils.AllocNativeUObject(UAttributeSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012126 RID: 74022 RVA: 0x001A8AE4 File Offset: 0x001A6CE4
		[NullableContext(1)]
		public UAttributeSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAttributeSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06012127 RID: 74023 RVA: 0x001A8B17 File Offset: 0x001A6D17
		static UAttributeSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AttributeSet");
		}

		// Token: 0x06012128 RID: 74024 RVA: 0x001A8B25 File Offset: 0x001A6D25
		protected UAttributeSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009A61 RID: 39521
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AttributeSet";

		// Token: 0x04009A62 RID: 39522
		private static IntPtr _ClassPtr;

		// Token: 0x04009A63 RID: 39523
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
