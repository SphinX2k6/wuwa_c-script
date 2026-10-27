using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013E2 RID: 5090
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagRedirect")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameplayTagRedirect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060129C2 RID: 76226 RVA: 0x001B62F0 File Offset: 0x001B44F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagRedirect._ScriptStructPtr != 0) ? FGameplayTagRedirect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayTags.GameplayTagRedirect", ref FGameplayTagRedirect._ScriptStructPtr);
		}

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x060129C3 RID: 76227 RVA: 0x001B6314 File Offset: 0x001B4514
		// (set) Token: 0x060129C4 RID: 76228 RVA: 0x001B6328 File Offset: 0x001B4528
		public unsafe FName OldTagName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagRedirect.__PropertyOffset_OldTagName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagRedirect.__PropertyOffset_OldTagName) = value;
			}
		}

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x060129C5 RID: 76229 RVA: 0x001B633D File Offset: 0x001B453D
		// (set) Token: 0x060129C6 RID: 76230 RVA: 0x001B6351 File Offset: 0x001B4551
		public unsafe FName NewTagName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayTagRedirect.__PropertyOffset_NewTagName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayTagRedirect.__PropertyOffset_NewTagName) = value;
			}
		}

		// Token: 0x060129C7 RID: 76231 RVA: 0x001B6366 File Offset: 0x001B4566
		public FGameplayTagRedirect()
		{
		}

		// Token: 0x060129C8 RID: 76232 RVA: 0x001B636E File Offset: 0x001B456E
		public FGameplayTagRedirect(FName OldTagName, FName NewTagName)
		{
			this.OldTagName = OldTagName;
			this.NewTagName = NewTagName;
		}

		// Token: 0x060129C9 RID: 76233 RVA: 0x001B6384 File Offset: 0x001B4584
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagRedirect.StaticStruct();
		}

		// Token: 0x060129CA RID: 76234 RVA: 0x001B6390 File Offset: 0x001B4590
		[NullableContext(2)]
		public FGameplayTagRedirect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060129CB RID: 76235 RVA: 0x001B639A File Offset: 0x001B459A
		public FGameplayTagRedirect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060129CC RID: 76236 RVA: 0x001B63A5 File Offset: 0x001B45A5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagRedirect(Pointer, false, true);
		}

		// Token: 0x060129CD RID: 76237 RVA: 0x001B63AF File Offset: 0x001B45AF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagRedirect(Pointer, MemoryOwner);
		}

		// Token: 0x04009F17 RID: 40727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTags.GameplayTagRedirect";

		// Token: 0x04009F18 RID: 40728
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009F19 RID: 40729
		internal static int __PropertyOffset_OldTagName;

		// Token: 0x04009F1A RID: 40730
		internal static int __PropertyOffset_NewTagName;
	}
}
