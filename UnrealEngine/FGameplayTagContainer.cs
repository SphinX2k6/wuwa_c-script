using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013DE RID: 5086
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagContainer")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayTagContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012998 RID: 76184 RVA: 0x001B5F3B File Offset: 0x001B413B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagContainer._ScriptStructPtr != 0) ? FGameplayTagContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagContainer", ref FGameplayTagContainer._ScriptStructPtr);
		}

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x06012999 RID: 76185 RVA: 0x001B5F60 File Offset: 0x001B4160
		// (set) Token: 0x0601299A RID: 76186 RVA: 0x001B5FA3 File Offset: 0x001B41A3
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

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x0601299B RID: 76187 RVA: 0x001B5FB4 File Offset: 0x001B41B4
		// (set) Token: 0x0601299C RID: 76188 RVA: 0x001B5FF7 File Offset: 0x001B41F7
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

		// Token: 0x0601299D RID: 76189 RVA: 0x001B6005 File Offset: 0x001B4205
		public FGameplayTagContainer()
		{
		}

		// Token: 0x0601299E RID: 76190 RVA: 0x001B600D File Offset: 0x001B420D
		public FGameplayTagContainer(TArray<FGameplayTag> GameplayTags, TArray<FGameplayTag> ParentTags)
		{
			this.GameplayTags = GameplayTags;
			this.ParentTags = ParentTags;
		}

		// Token: 0x0601299F RID: 76191 RVA: 0x001B6023 File Offset: 0x001B4223
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagContainer.StaticStruct();
		}

		// Token: 0x060129A0 RID: 76192 RVA: 0x001B602F File Offset: 0x001B422F
		[NullableContext(2)]
		public FGameplayTagContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060129A1 RID: 76193 RVA: 0x001B6039 File Offset: 0x001B4239
		public FGameplayTagContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060129A2 RID: 76194 RVA: 0x001B6044 File Offset: 0x001B4244
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagContainer(Pointer, false, true);
		}

		// Token: 0x060129A3 RID: 76195 RVA: 0x001B604E File Offset: 0x001B424E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04009F04 RID: 40708
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagContainer";

		// Token: 0x04009F05 RID: 40709
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F06 RID: 40710
		internal static int __PropertyOffset_GameplayTags;

		// Token: 0x04009F07 RID: 40711
		[Nullable(2)]
		private TArray<FGameplayTag> _GameplayTags;

		// Token: 0x04009F08 RID: 40712
		internal static int __PropertyOffset_ParentTags;

		// Token: 0x04009F09 RID: 40713
		[Nullable(2)]
		private TArray<FGameplayTag> _ParentTags;
	}
}
