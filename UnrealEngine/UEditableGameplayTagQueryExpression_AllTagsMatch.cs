using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D4 RID: 5076
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQueryExpression_AllTagsMatch")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UEditableGameplayTagQueryExpression_AllTagsMatch : UEditableGameplayTagQueryExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601295D RID: 76125 RVA: 0x001B57B6 File Offset: 0x001B39B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQueryExpression_AllTagsMatch._ClassPtr;
		}

		// Token: 0x0601295E RID: 76126 RVA: 0x001B57C4 File Offset: 0x001B39C4
		public UEditableGameplayTagQueryExpression_AllTagsMatch() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AllTagsMatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601295F RID: 76127 RVA: 0x001B57EC File Offset: 0x001B39EC
		public UEditableGameplayTagQueryExpression_AllTagsMatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AllTagsMatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x06012960 RID: 76128 RVA: 0x001B5820 File Offset: 0x001B3A20
		// (set) Token: 0x06012961 RID: 76129 RVA: 0x001B5859 File Offset: 0x001B3A59
		public FGameplayTagContainer Tags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_AllTagsMatch.__PropertyOffset_Tags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_AllTagsMatch.__PropertyOffset_Tags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012962 RID: 76130 RVA: 0x001B587A File Offset: 0x001B3A7A
		static UEditableGameplayTagQueryExpression_AllTagsMatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQueryExpression_AllTagsMatch");
		}

		// Token: 0x06012963 RID: 76131 RVA: 0x001B5888 File Offset: 0x001B3A88
		protected UEditableGameplayTagQueryExpression_AllTagsMatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009ED5 RID: 40661
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQueryExpression_AllTagsMatch";

		// Token: 0x04009ED6 RID: 40662
		private static IntPtr _ClassPtr;

		// Token: 0x04009ED7 RID: 40663
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009ED8 RID: 40664
		internal static int __PropertyOffset_Tags;

		// Token: 0x04009ED9 RID: 40665
		[Nullable(2)]
		private FGameplayTagContainer _Tags;
	}
}
