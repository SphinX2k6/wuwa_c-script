using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002BE RID: 702
	[UnrealObjectPath("/Script/GameplayAbilities.AttributeSet")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAttributeSet : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004CF8 RID: 19704 RVA: 0x0006BB49 File Offset: 0x00069D49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAttributeSet._ClassPtr;
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x0006BB58 File Offset: 0x00069D58
		public UAttributeSet() : this(BuiltinUtils.AllocNativeUObject(UAttributeSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x0006BB80 File Offset: 0x00069D80
		[NullableContext(1)]
		public UAttributeSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAttributeSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x0006BBB3 File Offset: 0x00069DB3
		static UAttributeSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AttributeSet");
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x0006BBC1 File Offset: 0x00069DC1
		protected UAttributeSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001EB2 RID: 7858
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AttributeSet";

		// Token: 0x04001EB3 RID: 7859
		private static IntPtr _ClassPtr;

		// Token: 0x04001EB4 RID: 7860
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
