using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001934 RID: 6452
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.SceneDissolveBatchResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSceneDissolveBatchResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017EC2 RID: 97986 RVA: 0x00230EC0 File Offset: 0x0022F0C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSceneDissolveBatchResult._ScriptStructPtr != 0) ? FSceneDissolveBatchResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.SceneDissolveBatchResult", ref FSceneDissolveBatchResult._ScriptStructPtr);
		}

		// Token: 0x17005FFD RID: 24573
		// (get) Token: 0x06017EC3 RID: 97987 RVA: 0x00230EE4 File Offset: 0x0022F0E4
		// (set) Token: 0x06017EC4 RID: 97988 RVA: 0x00230EF4 File Offset: 0x0022F0F4
		public unsafe int NumModified
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveBatchResult.__PropertyOffset_NumModified);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveBatchResult.__PropertyOffset_NumModified) = value;
			}
		}

		// Token: 0x17005FFE RID: 24574
		// (get) Token: 0x06017EC5 RID: 97989 RVA: 0x00230F05 File Offset: 0x0022F105
		// (set) Token: 0x06017EC6 RID: 97990 RVA: 0x00230F15 File Offset: 0x0022F115
		public unsafe int NumDisabledFromHistory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSceneDissolveBatchResult.__PropertyOffset_NumDisabledFromHistory);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSceneDissolveBatchResult.__PropertyOffset_NumDisabledFromHistory) = value;
			}
		}

		// Token: 0x17005FFF RID: 24575
		// (get) Token: 0x06017EC7 RID: 97991 RVA: 0x00230F28 File Offset: 0x0022F128
		// (set) Token: 0x06017EC8 RID: 97992 RVA: 0x00230F6B File Offset: 0x0022F16B
		public TArray<UMaterialInterface> ProcessedMICs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ProcessedMICs) == null)
				{
					result = (this._ProcessedMICs = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)FSceneDissolveBatchResult.__PropertyOffset_ProcessedMICs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProcessedMICs.CopyAssign(value);
			}
		}

		// Token: 0x06017EC9 RID: 97993 RVA: 0x00230F79 File Offset: 0x0022F179
		public FSceneDissolveBatchResult()
		{
		}

		// Token: 0x06017ECA RID: 97994 RVA: 0x00230F81 File Offset: 0x0022F181
		public FSceneDissolveBatchResult(int NumModified, int NumDisabledFromHistory, TArray<UMaterialInterface> ProcessedMICs)
		{
			this.NumModified = NumModified;
			this.NumDisabledFromHistory = NumDisabledFromHistory;
			this.ProcessedMICs = ProcessedMICs;
		}

		// Token: 0x06017ECB RID: 97995 RVA: 0x00230F9E File Offset: 0x0022F19E
		protected override IntPtr GetUStructPtr()
		{
			return FSceneDissolveBatchResult.StaticStruct();
		}

		// Token: 0x06017ECC RID: 97996 RVA: 0x00230FAA File Offset: 0x0022F1AA
		[NullableContext(2)]
		public FSceneDissolveBatchResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017ECD RID: 97997 RVA: 0x00230FB4 File Offset: 0x0022F1B4
		public FSceneDissolveBatchResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017ECE RID: 97998 RVA: 0x00230FBF File Offset: 0x0022F1BF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSceneDissolveBatchResult(Pointer, false, true);
		}

		// Token: 0x06017ECF RID: 97999 RVA: 0x00230FC9 File Offset: 0x0022F1C9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSceneDissolveBatchResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF3A RID: 53050
		public const string __ObjectPath = "/Script/KuroGameplay.SceneDissolveBatchResult";

		// Token: 0x0400CF3B RID: 53051
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF3C RID: 53052
		internal static int __PropertyOffset_NumModified;

		// Token: 0x0400CF3D RID: 53053
		internal static int __PropertyOffset_NumDisabledFromHistory;

		// Token: 0x0400CF3E RID: 53054
		internal static int __PropertyOffset_ProcessedMICs;

		// Token: 0x0400CF3F RID: 53055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ProcessedMICs;
	}
}
