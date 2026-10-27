using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D8 RID: 5080
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQueryExpression_NoTagsMatch")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UEditableGameplayTagQueryExpression_NoTagsMatch : UEditableGameplayTagQueryExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012979 RID: 76153 RVA: 0x001B5AFE File Offset: 0x001B3CFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQueryExpression_NoTagsMatch._ClassPtr;
		}

		// Token: 0x0601297A RID: 76154 RVA: 0x001B5B0C File Offset: 0x001B3D0C
		public UEditableGameplayTagQueryExpression_NoTagsMatch() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_NoTagsMatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601297B RID: 76155 RVA: 0x001B5B34 File Offset: 0x001B3D34
		public UEditableGameplayTagQueryExpression_NoTagsMatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_NoTagsMatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x0601297C RID: 76156 RVA: 0x001B5B68 File Offset: 0x001B3D68
		// (set) Token: 0x0601297D RID: 76157 RVA: 0x001B5BA1 File Offset: 0x001B3DA1
		public FGameplayTagContainer Tags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Tags) == null)
				{
					result = (this._Tags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_NoTagsMatch.__PropertyOffset_Tags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_NoTagsMatch.__PropertyOffset_Tags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601297E RID: 76158 RVA: 0x001B5BC2 File Offset: 0x001B3DC2
		static UEditableGameplayTagQueryExpression_NoTagsMatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQueryExpression_NoTagsMatch");
		}

		// Token: 0x0601297F RID: 76159 RVA: 0x001B5BD0 File Offset: 0x001B3DD0
		protected UEditableGameplayTagQueryExpression_NoTagsMatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EE9 RID: 40681
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQueryExpression_NoTagsMatch";

		// Token: 0x04009EEA RID: 40682
		private static IntPtr _ClassPtr;

		// Token: 0x04009EEB RID: 40683
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009EEC RID: 40684
		internal static int __PropertyOffset_Tags;

		// Token: 0x04009EED RID: 40685
		[Nullable(2)]
		private FGameplayTagContainer _Tags;
	}
}
