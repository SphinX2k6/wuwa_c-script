using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D2 RID: 5074
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQueryExpression")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEditableGameplayTagQueryExpression : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012952 RID: 76114 RVA: 0x001B56A1 File Offset: 0x001B38A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQueryExpression._ClassPtr;
		}

		// Token: 0x06012953 RID: 76115 RVA: 0x001B56AD File Offset: 0x001B38AD
		static UEditableGameplayTagQueryExpression()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQueryExpression");
		}

		// Token: 0x06012954 RID: 76116 RVA: 0x001B56BC File Offset: 0x001B38BC
		protected UEditableGameplayTagQueryExpression() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012955 RID: 76117 RVA: 0x001B56E4 File Offset: 0x001B38E4
		protected UEditableGameplayTagQueryExpression(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009ECD RID: 40653
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQueryExpression";

		// Token: 0x04009ECE RID: 40654
		private static IntPtr _ClassPtr;

		// Token: 0x04009ECF RID: 40655
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
