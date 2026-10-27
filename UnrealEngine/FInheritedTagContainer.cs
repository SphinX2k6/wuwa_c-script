using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013A2 RID: 5026
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.InheritedTagContainer")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FInheritedTagContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012742 RID: 75586 RVA: 0x001B2077 File Offset: 0x001B0277
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInheritedTagContainer._ScriptStructPtr != 0) ? FInheritedTagContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.InheritedTagContainer", ref FInheritedTagContainer._ScriptStructPtr);
		}

		// Token: 0x170047F0 RID: 18416
		// (get) Token: 0x06012743 RID: 75587 RVA: 0x001B209C File Offset: 0x001B029C
		// (set) Token: 0x06012744 RID: 75588 RVA: 0x001B20DF File Offset: 0x001B02DF
		public FGameplayTagContainer CombinedTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._CombinedTags) == null)
				{
					result = (this._CombinedTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FInheritedTagContainer.__PropertyOffset_CombinedTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FInheritedTagContainer.__PropertyOffset_CombinedTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047F1 RID: 18417
		// (get) Token: 0x06012745 RID: 75589 RVA: 0x001B2100 File Offset: 0x001B0300
		// (set) Token: 0x06012746 RID: 75590 RVA: 0x001B2143 File Offset: 0x001B0343
		public FGameplayTagContainer Added
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Added) == null)
				{
					result = (this._Added = new FGameplayTagContainer(base.NativePtr + (IntPtr)FInheritedTagContainer.__PropertyOffset_Added, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FInheritedTagContainer.__PropertyOffset_Added, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047F2 RID: 18418
		// (get) Token: 0x06012747 RID: 75591 RVA: 0x001B2164 File Offset: 0x001B0364
		// (set) Token: 0x06012748 RID: 75592 RVA: 0x001B21A7 File Offset: 0x001B03A7
		public FGameplayTagContainer Removed
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._Removed) == null)
				{
					result = (this._Removed = new FGameplayTagContainer(base.NativePtr + (IntPtr)FInheritedTagContainer.__PropertyOffset_Removed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FInheritedTagContainer.__PropertyOffset_Removed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012749 RID: 75593 RVA: 0x001B21C8 File Offset: 0x001B03C8
		public FInheritedTagContainer()
		{
		}

		// Token: 0x0601274A RID: 75594 RVA: 0x001B21D0 File Offset: 0x001B03D0
		public FInheritedTagContainer(FGameplayTagContainer CombinedTags, FGameplayTagContainer Added, FGameplayTagContainer Removed)
		{
			this.CombinedTags = CombinedTags;
			this.Added = Added;
			this.Removed = Removed;
		}

		// Token: 0x0601274B RID: 75595 RVA: 0x001B21ED File Offset: 0x001B03ED
		protected override IntPtr GetUStructPtr()
		{
			return FInheritedTagContainer.StaticStruct();
		}

		// Token: 0x0601274C RID: 75596 RVA: 0x001B21F9 File Offset: 0x001B03F9
		[NullableContext(2)]
		public FInheritedTagContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601274D RID: 75597 RVA: 0x001B2203 File Offset: 0x001B0403
		public FInheritedTagContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601274E RID: 75598 RVA: 0x001B220E File Offset: 0x001B040E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInheritedTagContainer(Pointer, false, true);
		}

		// Token: 0x0601274F RID: 75599 RVA: 0x001B2218 File Offset: 0x001B0418
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInheritedTagContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04009E16 RID: 40470
		public const string __ObjectPath = "/Script/GameplayAbilities.InheritedTagContainer";

		// Token: 0x04009E17 RID: 40471
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009E18 RID: 40472
		internal static int __PropertyOffset_CombinedTags;

		// Token: 0x04009E19 RID: 40473
		[Nullable(2)]
		private FGameplayTagContainer _CombinedTags;

		// Token: 0x04009E1A RID: 40474
		internal static int __PropertyOffset_Added;

		// Token: 0x04009E1B RID: 40475
		[Nullable(2)]
		private FGameplayTagContainer _Added;

		// Token: 0x04009E1C RID: 40476
		internal static int __PropertyOffset_Removed;

		// Token: 0x04009E1D RID: 40477
		[Nullable(2)]
		private FGameplayTagContainer _Removed;
	}
}
