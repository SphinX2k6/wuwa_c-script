using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200138E RID: 5006
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectQuery")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 376)]
	public class FGameplayEffectQuery : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012608 RID: 75272 RVA: 0x001B0025 File Offset: 0x001AE225
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectQuery._ScriptStructPtr != 0) ? FGameplayEffectQuery._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectQuery", ref FGameplayEffectQuery._ScriptStructPtr);
		}

		// Token: 0x1700479C RID: 18332
		// (get) Token: 0x06012609 RID: 75273 RVA: 0x001B004C File Offset: 0x001AE24C
		// (set) Token: 0x0601260A RID: 75274 RVA: 0x001B008F File Offset: 0x001AE28F
		public FActiveGameplayEffectQueryCustomMatch_Dynamic CustomMatchDelegate_BP
		{
			get
			{
				base.FastCheckIsValid();
				FActiveGameplayEffectQueryCustomMatch_Dynamic result;
				if ((result = this._CustomMatchDelegate_BP) == null)
				{
					result = (this._CustomMatchDelegate_BP = new FActiveGameplayEffectQueryCustomMatch_Dynamic(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_CustomMatchDelegate_BP, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_CustomMatchDelegate_BP, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700479D RID: 18333
		// (get) Token: 0x0601260B RID: 75275 RVA: 0x001B00B0 File Offset: 0x001AE2B0
		// (set) Token: 0x0601260C RID: 75276 RVA: 0x001B00F3 File Offset: 0x001AE2F3
		public FGameplayTagQuery OwningTagQuery
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagQuery result;
				if ((result = this._OwningTagQuery) == null)
				{
					result = (this._OwningTagQuery = new FGameplayTagQuery(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_OwningTagQuery, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagQuery.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_OwningTagQuery, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700479E RID: 18334
		// (get) Token: 0x0601260D RID: 75277 RVA: 0x001B0114 File Offset: 0x001AE314
		// (set) Token: 0x0601260E RID: 75278 RVA: 0x001B0157 File Offset: 0x001AE357
		public FGameplayTagQuery EffectTagQuery
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagQuery result;
				if ((result = this._EffectTagQuery) == null)
				{
					result = (this._EffectTagQuery = new FGameplayTagQuery(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_EffectTagQuery, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagQuery.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_EffectTagQuery, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x0601260F RID: 75279 RVA: 0x001B0178 File Offset: 0x001AE378
		// (set) Token: 0x06012610 RID: 75280 RVA: 0x001B01BB File Offset: 0x001AE3BB
		public FGameplayTagQuery SourceTagQuery
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagQuery result;
				if ((result = this._SourceTagQuery) == null)
				{
					result = (this._SourceTagQuery = new FGameplayTagQuery(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_SourceTagQuery, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagQuery.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_SourceTagQuery, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047A0 RID: 18336
		// (get) Token: 0x06012611 RID: 75281 RVA: 0x001B01DC File Offset: 0x001AE3DC
		// (set) Token: 0x06012612 RID: 75282 RVA: 0x001B021F File Offset: 0x001AE41F
		public FGameplayAttribute ModifyingAttribute
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttribute result;
				if ((result = this._ModifyingAttribute) == null)
				{
					result = (this._ModifyingAttribute = new FGameplayAttribute(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_ModifyingAttribute, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttribute.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_ModifyingAttribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047A1 RID: 18337
		// (get) Token: 0x06012613 RID: 75283 RVA: 0x001B0240 File Offset: 0x001AE440
		// (set) Token: 0x06012614 RID: 75284 RVA: 0x001B0254 File Offset: 0x001AE454
		[Nullable(2)]
		public unsafe UObject EffectSource
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectQuery.__PropertyOffset_EffectSource);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectQuery.__PropertyOffset_EffectSource, value);
			}
		}

		// Token: 0x170047A2 RID: 18338
		// (get) Token: 0x06012615 RID: 75285 RVA: 0x001B0269 File Offset: 0x001AE469
		// (set) Token: 0x06012616 RID: 75286 RVA: 0x001B027D File Offset: 0x001AE47D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayEffect> EffectDefinition
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_EffectDefinition);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectQuery.__PropertyOffset_EffectDefinition) = value;
			}
		}

		// Token: 0x06012617 RID: 75287 RVA: 0x001B0292 File Offset: 0x001AE492
		public FGameplayEffectQuery()
		{
		}

		// Token: 0x06012618 RID: 75288 RVA: 0x001B029A File Offset: 0x001AE49A
		public FGameplayEffectQuery(FActiveGameplayEffectQueryCustomMatch_Dynamic CustomMatchDelegate_BP, FGameplayTagQuery OwningTagQuery, FGameplayTagQuery EffectTagQuery, FGameplayTagQuery SourceTagQuery, FGameplayAttribute ModifyingAttribute, UObject EffectSource, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayEffect> EffectDefinition)
		{
			this.CustomMatchDelegate_BP = CustomMatchDelegate_BP;
			this.OwningTagQuery = OwningTagQuery;
			this.EffectTagQuery = EffectTagQuery;
			this.SourceTagQuery = SourceTagQuery;
			this.ModifyingAttribute = ModifyingAttribute;
			this.EffectSource = EffectSource;
			this.EffectDefinition = EffectDefinition;
		}

		// Token: 0x06012619 RID: 75289 RVA: 0x001B02D7 File Offset: 0x001AE4D7
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectQuery.StaticStruct();
		}

		// Token: 0x0601261A RID: 75290 RVA: 0x001B02E3 File Offset: 0x001AE4E3
		[NullableContext(2)]
		public FGameplayEffectQuery(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601261B RID: 75291 RVA: 0x001B02ED File Offset: 0x001AE4ED
		public FGameplayEffectQuery(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601261C RID: 75292 RVA: 0x001B02F8 File Offset: 0x001AE4F8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectQuery(Pointer, false, true);
		}

		// Token: 0x0601261D RID: 75293 RVA: 0x001B0302 File Offset: 0x001AE502
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectQuery(Pointer, MemoryOwner);
		}

		// Token: 0x04009D6C RID: 40300
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectQuery";

		// Token: 0x04009D6D RID: 40301
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D6E RID: 40302
		internal static int __PropertyOffset_CustomMatchDelegate_BP;

		// Token: 0x04009D6F RID: 40303
		[Nullable(2)]
		private FActiveGameplayEffectQueryCustomMatch_Dynamic _CustomMatchDelegate_BP;

		// Token: 0x04009D70 RID: 40304
		internal static int __PropertyOffset_OwningTagQuery;

		// Token: 0x04009D71 RID: 40305
		[Nullable(2)]
		private FGameplayTagQuery _OwningTagQuery;

		// Token: 0x04009D72 RID: 40306
		internal static int __PropertyOffset_EffectTagQuery;

		// Token: 0x04009D73 RID: 40307
		[Nullable(2)]
		private FGameplayTagQuery _EffectTagQuery;

		// Token: 0x04009D74 RID: 40308
		internal static int __PropertyOffset_SourceTagQuery;

		// Token: 0x04009D75 RID: 40309
		[Nullable(2)]
		private FGameplayTagQuery _SourceTagQuery;

		// Token: 0x04009D76 RID: 40310
		internal static int __PropertyOffset_ModifyingAttribute;

		// Token: 0x04009D77 RID: 40311
		[Nullable(2)]
		private FGameplayAttribute _ModifyingAttribute;

		// Token: 0x04009D78 RID: 40312
		internal static int __PropertyOffset_EffectSource;

		// Token: 0x04009D79 RID: 40313
		internal static int __PropertyOffset_EffectDefinition;
	}
}
