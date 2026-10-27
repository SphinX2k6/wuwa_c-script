using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D6 RID: 5078
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyTagsMatch")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UEditableGameplayTagQueryExpression_AnyTagsMatch : UEditableGameplayTagQueryExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601296B RID: 76139 RVA: 0x001B595A File Offset: 0x001B3B5A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQueryExpression_AnyTagsMatch._ClassPtr;
		}

		// Token: 0x0601296C RID: 76140 RVA: 0x001B5968 File Offset: 0x001B3B68
		public UEditableGameplayTagQueryExpression_AnyTagsMatch() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AnyTagsMatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601296D RID: 76141 RVA: 0x001B5990 File Offset: 0x001B3B90
		public UEditableGameplayTagQueryExpression_AnyTagsMatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AnyTagsMatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x0601296E RID: 76142 RVA: 0x001B59C4 File Offset: 0x001B3BC4
		// (set) Token: 0x0601296F RID: 76143 RVA: 0x001B59FD File Offset: 0x001B3BFD
		public FGameplayTagContainer Tags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_AnyTagsMatch.__PropertyOffset_Tags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_AnyTagsMatch.__PropertyOffset_Tags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012970 RID: 76144 RVA: 0x001B5A1E File Offset: 0x001B3C1E
		static UEditableGameplayTagQueryExpression_AnyTagsMatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyTagsMatch");
		}

		// Token: 0x06012971 RID: 76145 RVA: 0x001B5A2C File Offset: 0x001B3C2C
		protected UEditableGameplayTagQueryExpression_AnyTagsMatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EDF RID: 40671
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyTagsMatch";

		// Token: 0x04009EE0 RID: 40672
		private static IntPtr _ClassPtr;

		// Token: 0x04009EE1 RID: 40673
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009EE2 RID: 40674
		internal static int __PropertyOffset_Tags;

		// Token: 0x04009EE3 RID: 40675
		[Nullable(2)]
		private FGameplayTagContainer _Tags;
	}
}
