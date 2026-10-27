using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001394 RID: 5012
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectUIData_TextOnly")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UGameplayEffectUIData_TextOnly : UGameplayEffectUIData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601267F RID: 75391 RVA: 0x001B0DF1 File Offset: 0x001AEFF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayEffectUIData_TextOnly._ClassPtr;
		}

		// Token: 0x06012680 RID: 75392 RVA: 0x001B0E00 File Offset: 0x001AF000
		public UGameplayEffectUIData_TextOnly() : this(BuiltinUtils.AllocNativeUObject(UGameplayEffectUIData_TextOnly.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012681 RID: 75393 RVA: 0x001B0E28 File Offset: 0x001AF028
		public UGameplayEffectUIData_TextOnly(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayEffectUIData_TextOnly.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170047C2 RID: 18370
		// (get) Token: 0x06012682 RID: 75394 RVA: 0x001B0E5C File Offset: 0x001AF05C
		// (set) Token: 0x06012683 RID: 75395 RVA: 0x001B0E95 File Offset: 0x001AF095
		public unsafe FText Description
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._Description) == null)
				{
					result = (this._Description = new FText(base.NativePtr + (IntPtr)UGameplayEffectUIData_TextOnly.__PropertyOffset_Description, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UGameplayEffectUIData_TextOnly.__PropertyOffset_Description)), value.NativePtr, 1);
			}
		}

		// Token: 0x06012684 RID: 75396 RVA: 0x001B0EB0 File Offset: 0x001AF0B0
		static UGameplayEffectUIData_TextOnly()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayEffectUIData_TextOnly");
		}

		// Token: 0x06012685 RID: 75397 RVA: 0x001B0EBE File Offset: 0x001AF0BE
		protected UGameplayEffectUIData_TextOnly(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009DB5 RID: 40373
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectUIData_TextOnly";

		// Token: 0x04009DB6 RID: 40374
		private static IntPtr _ClassPtr;

		// Token: 0x04009DB7 RID: 40375
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009DB8 RID: 40376
		internal static int __PropertyOffset_Description;

		// Token: 0x04009DB9 RID: 40377
		[Nullable(2)]
		private FText _Description;
	}
}
