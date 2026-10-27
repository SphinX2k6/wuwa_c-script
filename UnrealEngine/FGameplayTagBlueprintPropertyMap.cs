using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200139A RID: 5018
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTagBlueprintPropertyMap")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FGameplayTagBlueprintPropertyMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060126DA RID: 75482 RVA: 0x001B17E9 File Offset: 0x001AF9E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayTagBlueprintPropertyMap._ScriptStructPtr != 0) ? FGameplayTagBlueprintPropertyMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayTagBlueprintPropertyMap", ref FGameplayTagBlueprintPropertyMap._ScriptStructPtr);
		}

		// Token: 0x170047DB RID: 18395
		// (get) Token: 0x060126DB RID: 75483 RVA: 0x001B1810 File Offset: 0x001AFA10
		// (set) Token: 0x060126DC RID: 75484 RVA: 0x001B1853 File Offset: 0x001AFA53
		public TArray<FGameplayTagBlueprintPropertyMapping> PropertyMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagBlueprintPropertyMapping> result;
				if ((result = this._PropertyMappings) == null)
				{
					result = (this._PropertyMappings = new TArray<FGameplayTagBlueprintPropertyMapping>(base.NativePtr + (IntPtr)FGameplayTagBlueprintPropertyMap.__PropertyOffset_PropertyMappings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyMappings.CopyAssign(value);
			}
		}

		// Token: 0x060126DD RID: 75485 RVA: 0x001B1861 File Offset: 0x001AFA61
		public FGameplayTagBlueprintPropertyMap()
		{
		}

		// Token: 0x060126DE RID: 75486 RVA: 0x001B1869 File Offset: 0x001AFA69
		public FGameplayTagBlueprintPropertyMap(TArray<FGameplayTagBlueprintPropertyMapping> PropertyMappings)
		{
			this.PropertyMappings = PropertyMappings;
		}

		// Token: 0x060126DF RID: 75487 RVA: 0x001B1878 File Offset: 0x001AFA78
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayTagBlueprintPropertyMap.StaticStruct();
		}

		// Token: 0x060126E0 RID: 75488 RVA: 0x001B1884 File Offset: 0x001AFA84
		[NullableContext(2)]
		public FGameplayTagBlueprintPropertyMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060126E1 RID: 75489 RVA: 0x001B188E File Offset: 0x001AFA8E
		public FGameplayTagBlueprintPropertyMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060126E2 RID: 75490 RVA: 0x001B1899 File Offset: 0x001AFA99
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayTagBlueprintPropertyMap(Pointer, false, true);
		}

		// Token: 0x060126E3 RID: 75491 RVA: 0x001B18A3 File Offset: 0x001AFAA3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayTagBlueprintPropertyMap(Pointer, MemoryOwner);
		}

		// Token: 0x04009DE9 RID: 40425
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayTagBlueprintPropertyMap";

		// Token: 0x04009DEA RID: 40426
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DEB RID: 40427
		internal static int __PropertyOffset_PropertyMappings;

		// Token: 0x04009DEC RID: 40428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagBlueprintPropertyMapping> _PropertyMappings;
	}
}
