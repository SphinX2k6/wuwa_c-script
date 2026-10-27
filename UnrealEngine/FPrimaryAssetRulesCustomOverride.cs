using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001039 RID: 4153
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PrimaryAssetRulesCustomOverride")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPrimaryAssetRulesCustomOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E999 RID: 59801 RVA: 0x0015B03A File Offset: 0x0015923A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetRulesCustomOverride._ScriptStructPtr != 0) ? FPrimaryAssetRulesCustomOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PrimaryAssetRulesCustomOverride", ref FPrimaryAssetRulesCustomOverride._ScriptStructPtr);
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600E99A RID: 59802 RVA: 0x0015B060 File Offset: 0x00159260
		// (set) Token: 0x0600E99B RID: 59803 RVA: 0x0015B0A3 File Offset: 0x001592A3
		public FPrimaryAssetType PrimaryAssetType
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetType result;
				if ((result = this._PrimaryAssetType) == null)
				{
					result = (this._PrimaryAssetType = new FPrimaryAssetType(base.NativePtr + (IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_PrimaryAssetType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetType.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_PrimaryAssetType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600E99C RID: 59804 RVA: 0x0015B0C4 File Offset: 0x001592C4
		// (set) Token: 0x0600E99D RID: 59805 RVA: 0x0015B107 File Offset: 0x00159307
		public FDirectoryPath FilterDirectory
		{
			get
			{
				base.FastCheckIsValid();
				FDirectoryPath result;
				if ((result = this._FilterDirectory) == null)
				{
					result = (this._FilterDirectory = new FDirectoryPath(base.NativePtr + (IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_FilterDirectory, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDirectoryPath.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_FilterDirectory, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600E99E RID: 59806 RVA: 0x0015B128 File Offset: 0x00159328
		// (set) Token: 0x0600E99F RID: 59807 RVA: 0x0015B13C File Offset: 0x0015933C
		public unsafe string FilterString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_FilterString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_FilterString)), value);
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600E9A0 RID: 59808 RVA: 0x0015B154 File Offset: 0x00159354
		// (set) Token: 0x0600E9A1 RID: 59809 RVA: 0x0015B197 File Offset: 0x00159397
		public FPrimaryAssetRules Rules
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetRules result;
				if ((result = this._Rules) == null)
				{
					result = (this._Rules = new FPrimaryAssetRules(base.NativePtr + (IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_Rules, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetRules.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetRulesCustomOverride.__PropertyOffset_Rules, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600E9A2 RID: 59810 RVA: 0x0015B1B8 File Offset: 0x001593B8
		public FPrimaryAssetRulesCustomOverride()
		{
		}

		// Token: 0x0600E9A3 RID: 59811 RVA: 0x0015B1C0 File Offset: 0x001593C0
		public FPrimaryAssetRulesCustomOverride(FPrimaryAssetType PrimaryAssetType, FDirectoryPath FilterDirectory, string FilterString, FPrimaryAssetRules Rules)
		{
			this.PrimaryAssetType = PrimaryAssetType;
			this.FilterDirectory = FilterDirectory;
			this.FilterString = FilterString;
			this.Rules = Rules;
		}

		// Token: 0x0600E9A4 RID: 59812 RVA: 0x0015B1E5 File Offset: 0x001593E5
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetRulesCustomOverride.StaticStruct();
		}

		// Token: 0x0600E9A5 RID: 59813 RVA: 0x0015B1F1 File Offset: 0x001593F1
		[NullableContext(2)]
		public FPrimaryAssetRulesCustomOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E9A6 RID: 59814 RVA: 0x0015B1FB File Offset: 0x001593FB
		public FPrimaryAssetRulesCustomOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E9A7 RID: 59815 RVA: 0x0015B206 File Offset: 0x00159406
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetRulesCustomOverride(Pointer, false, true);
		}

		// Token: 0x0600E9A8 RID: 59816 RVA: 0x0015B210 File Offset: 0x00159410
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetRulesCustomOverride(Pointer, MemoryOwner);
		}

		// Token: 0x04007ECF RID: 32463
		public const string __ObjectPath = "/Script/Engine.PrimaryAssetRulesCustomOverride";

		// Token: 0x04007ED0 RID: 32464
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007ED1 RID: 32465
		internal static int __PropertyOffset_PrimaryAssetType;

		// Token: 0x04007ED2 RID: 32466
		[Nullable(2)]
		private FPrimaryAssetType _PrimaryAssetType;

		// Token: 0x04007ED3 RID: 32467
		internal static int __PropertyOffset_FilterDirectory;

		// Token: 0x04007ED4 RID: 32468
		[Nullable(2)]
		private FDirectoryPath _FilterDirectory;

		// Token: 0x04007ED5 RID: 32469
		internal static int __PropertyOffset_FilterString;

		// Token: 0x04007ED6 RID: 32470
		internal static int __PropertyOffset_Rules;

		// Token: 0x04007ED7 RID: 32471
		[Nullable(2)]
		private FPrimaryAssetRules _Rules;
	}
}
