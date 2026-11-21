using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C8 RID: 712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagContainer")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayTagContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004DC4 RID: 19908 RVA: 0x0006CA8A File Offset: 0x0006AC8A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagContainer._ScriptStructPtr != 0) ? FGameplayTagContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagContainer", ref FGameplayTagContainer._ScriptStructPtr);
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06004DC5 RID: 19909 RVA: 0x0006CAB0 File Offset: 0x0006ACB0
		// (set) Token: 0x06004DC6 RID: 19910 RVA: 0x0006CAF3 File Offset: 0x0006ACF3
		public TArray<FGameplayTag> GameplayTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._GameplayTags) == null)
				{
					result = (this._GameplayTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)FGameplayTagContainer.__PropertyOffset_GameplayTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GameplayTags.CopyAssign(value);
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06004DC7 RID: 19911 RVA: 0x0006CB04 File Offset: 0x0006AD04
		// (set) Token: 0x06004DC8 RID: 19912 RVA: 0x0006CB47 File Offset: 0x0006AD47
		public TArray<FGameplayTag> ParentTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._ParentTags) == null)
				{
					result = (this._ParentTags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)FGameplayTagContainer.__PropertyOffset_ParentTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParentTags.CopyAssign(value);
			}
		}

		// Token: 0x06004DC9 RID: 19913 RVA: 0x0006CB55 File Offset: 0x0006AD55
		public FGameplayTagContainer()
		{
		}

		// Token: 0x06004DCA RID: 19914 RVA: 0x0006CB5D File Offset: 0x0006AD5D
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagContainer.StaticStruct();
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x0006CB69 File Offset: 0x0006AD69
		[NullableContext(2)]
		public FGameplayTagContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x0006CB73 File Offset: 0x0006AD73
		public FGameplayTagContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x0006CB7E File Offset: 0x0006AD7E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagContainer(Pointer, false, true);
		}

		// Token: 0x06004DCE RID: 19918 RVA: 0x0006CB88 File Offset: 0x0006AD88
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04001F07 RID: 7943
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagContainer";

		// Token: 0x04001F08 RID: 7944
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F09 RID: 7945
		internal static int __PropertyOffset_GameplayTags;

		// Token: 0x04001F0A RID: 7946
		[Nullable(2)]
		private TArray<FGameplayTag> _GameplayTags;

		// Token: 0x04001F0B RID: 7947
		internal static int __PropertyOffset_ParentTags;

		// Token: 0x04001F0C RID: 7948
		[Nullable(2)]
		private TArray<FGameplayTag> _ParentTags;
	}
}
