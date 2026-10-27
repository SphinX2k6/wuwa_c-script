using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200103A RID: 4154
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrimaryAssetRulesOverride")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FPrimaryAssetRulesOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E9A9 RID: 59817 RVA: 0x0015B219 File Offset: 0x00159419
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetRulesOverride._ScriptStructPtr != 0) ? FPrimaryAssetRulesOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrimaryAssetRulesOverride", ref FPrimaryAssetRulesOverride._ScriptStructPtr);
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600E9AA RID: 59818 RVA: 0x0015B240 File Offset: 0x00159440
		// (set) Token: 0x0600E9AB RID: 59819 RVA: 0x0015B283 File Offset: 0x00159483
		public FPrimaryAssetId PrimaryAssetId
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetId result;
				if ((result = this._PrimaryAssetId) == null)
				{
					result = (this._PrimaryAssetId = new FPrimaryAssetId(base.NativePtr + (IntPtr)FPrimaryAssetRulesOverride.__PropertyOffset_PrimaryAssetId, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetId.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetRulesOverride.__PropertyOffset_PrimaryAssetId, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600E9AC RID: 59820 RVA: 0x0015B2A4 File Offset: 0x001594A4
		// (set) Token: 0x0600E9AD RID: 59821 RVA: 0x0015B2E7 File Offset: 0x001594E7
		public FPrimaryAssetRules Rules
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetRules result;
				if ((result = this._Rules) == null)
				{
					result = (this._Rules = new FPrimaryAssetRules(base.NativePtr + (IntPtr)FPrimaryAssetRulesOverride.__PropertyOffset_Rules, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetRules.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetRulesOverride.__PropertyOffset_Rules, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600E9AE RID: 59822 RVA: 0x0015B308 File Offset: 0x00159508
		public FPrimaryAssetRulesOverride()
		{
		}

		// Token: 0x0600E9AF RID: 59823 RVA: 0x0015B310 File Offset: 0x00159510
		public FPrimaryAssetRulesOverride(FPrimaryAssetId PrimaryAssetId, FPrimaryAssetRules Rules)
		{
			this.PrimaryAssetId = PrimaryAssetId;
			this.Rules = Rules;
		}

		// Token: 0x0600E9B0 RID: 59824 RVA: 0x0015B326 File Offset: 0x00159526
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetRulesOverride.StaticStruct();
		}

		// Token: 0x0600E9B1 RID: 59825 RVA: 0x0015B332 File Offset: 0x00159532
		[NullableContext(2)]
		public FPrimaryAssetRulesOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E9B2 RID: 59826 RVA: 0x0015B33C File Offset: 0x0015953C
		public FPrimaryAssetRulesOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E9B3 RID: 59827 RVA: 0x0015B347 File Offset: 0x00159547
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetRulesOverride(Pointer, false, true);
		}

		// Token: 0x0600E9B4 RID: 59828 RVA: 0x0015B351 File Offset: 0x00159551
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetRulesOverride(Pointer, MemoryOwner);
		}

		// Token: 0x04007ED8 RID: 32472
		public const string __ObjectPath = "/Script/Engine.PrimaryAssetRulesOverride";

		// Token: 0x04007ED9 RID: 32473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007EDA RID: 32474
		internal static int __PropertyOffset_PrimaryAssetId;

		// Token: 0x04007EDB RID: 32475
		[Nullable(2)]
		private FPrimaryAssetId _PrimaryAssetId;

		// Token: 0x04007EDC RID: 32476
		internal static int __PropertyOffset_Rules;

		// Token: 0x04007EDD RID: 32477
		[Nullable(2)]
		private FPrimaryAssetRules _Rules;
	}
}
