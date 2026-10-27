using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200075C RID: 1884
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.PrimaryAssetId")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPrimaryAssetId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006360 RID: 25440 RVA: 0x0008EAE8 File Offset: 0x0008CCE8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetId._ScriptStructPtr != 0) ? FPrimaryAssetId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PrimaryAssetId", ref FPrimaryAssetId._ScriptStructPtr);
		}

		// Token: 0x170017A7 RID: 6055
		// (get) Token: 0x06006361 RID: 25441 RVA: 0x0008EB0C File Offset: 0x0008CD0C
		// (set) Token: 0x06006362 RID: 25442 RVA: 0x0008EB4F File Offset: 0x0008CD4F
		public FPrimaryAssetType PrimaryAssetType
		{
			get
			{
				base.FastCheckIsValid();
				FPrimaryAssetType result;
				if ((result = this._PrimaryAssetType) == null)
				{
					result = (this._PrimaryAssetType = new FPrimaryAssetType(base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPrimaryAssetType.StaticStruct(), base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170017A8 RID: 6056
		// (get) Token: 0x06006363 RID: 25443 RVA: 0x0008EB70 File Offset: 0x0008CD70
		// (set) Token: 0x06006364 RID: 25444 RVA: 0x0008EB84 File Offset: 0x0008CD84
		public unsafe FName PrimaryAssetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetId.__PropertyOffset_PrimaryAssetName) = value;
			}
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x0008EB99 File Offset: 0x0008CD99
		public FPrimaryAssetId()
		{
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x0008EBA1 File Offset: 0x0008CDA1
		public FPrimaryAssetId(FPrimaryAssetType PrimaryAssetType, FName PrimaryAssetName)
		{
			this.PrimaryAssetType = PrimaryAssetType;
			this.PrimaryAssetName = PrimaryAssetName;
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x0008EBB7 File Offset: 0x0008CDB7
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetId.StaticStruct();
		}

		// Token: 0x06006368 RID: 25448 RVA: 0x0008EBC3 File Offset: 0x0008CDC3
		[NullableContext(2)]
		public FPrimaryAssetId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006369 RID: 25449 RVA: 0x0008EBCD File Offset: 0x0008CDCD
		public FPrimaryAssetId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600636A RID: 25450 RVA: 0x0008EBD8 File Offset: 0x0008CDD8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetId(Pointer, false, true);
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x0008EBE2 File Offset: 0x0008CDE2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetId(Pointer, MemoryOwner);
		}

		// Token: 0x04002FA0 RID: 12192
		public const string __ObjectPath = "/Script/CoreUObject.PrimaryAssetId";

		// Token: 0x04002FA1 RID: 12193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002FA2 RID: 12194
		internal static int __PropertyOffset_PrimaryAssetType;

		// Token: 0x04002FA3 RID: 12195
		[Nullable(2)]
		private FPrimaryAssetType _PrimaryAssetType;

		// Token: 0x04002FA4 RID: 12196
		internal static int __PropertyOffset_PrimaryAssetName;
	}
}
