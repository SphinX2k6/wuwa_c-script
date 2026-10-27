using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001031 RID: 4145
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PredictProjectilePathResult")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FPredictProjectilePathResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E93D RID: 59709 RVA: 0x0015A7C0 File Offset: 0x001589C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredictProjectilePathResult._ScriptStructPtr != 0) ? FPredictProjectilePathResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PredictProjectilePathResult", ref FPredictProjectilePathResult._ScriptStructPtr);
		}

		// Token: 0x1700387D RID: 14461
		// (get) Token: 0x0600E93E RID: 59710 RVA: 0x0015A7E4 File Offset: 0x001589E4
		// (set) Token: 0x0600E93F RID: 59711 RVA: 0x0015A827 File Offset: 0x00158A27
		public TArray<FPredictProjectilePathPointData> PathData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPredictProjectilePathPointData> result;
				if ((result = this._PathData) == null)
				{
					result = (this._PathData = new TArray<FPredictProjectilePathPointData>(base.NativePtr + (IntPtr)FPredictProjectilePathResult.__PropertyOffset_PathData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PathData.CopyAssign(value);
			}
		}

		// Token: 0x1700387E RID: 14462
		// (get) Token: 0x0600E940 RID: 59712 RVA: 0x0015A838 File Offset: 0x00158A38
		// (set) Token: 0x0600E941 RID: 59713 RVA: 0x0015A87B File Offset: 0x00158A7B
		public FPredictProjectilePathPointData LastTraceDestination
		{
			get
			{
				base.FastCheckIsValid();
				FPredictProjectilePathPointData result;
				if ((result = this._LastTraceDestination) == null)
				{
					result = (this._LastTraceDestination = new FPredictProjectilePathPointData(base.NativePtr + (IntPtr)FPredictProjectilePathResult.__PropertyOffset_LastTraceDestination, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictProjectilePathPointData.StaticStruct(), base.NativePtr + (IntPtr)FPredictProjectilePathResult.__PropertyOffset_LastTraceDestination, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700387F RID: 14463
		// (get) Token: 0x0600E942 RID: 59714 RVA: 0x0015A89C File Offset: 0x00158A9C
		// (set) Token: 0x0600E943 RID: 59715 RVA: 0x0015A8DF File Offset: 0x00158ADF
		public FHitResult HitResult
		{
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._HitResult) == null)
				{
					result = (this._HitResult = new FHitResult(base.NativePtr + (IntPtr)FPredictProjectilePathResult.__PropertyOffset_HitResult, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)FPredictProjectilePathResult.__PropertyOffset_HitResult, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600E944 RID: 59716 RVA: 0x0015A900 File Offset: 0x00158B00
		public FPredictProjectilePathResult()
		{
		}

		// Token: 0x0600E945 RID: 59717 RVA: 0x0015A908 File Offset: 0x00158B08
		public FPredictProjectilePathResult(TArray<FPredictProjectilePathPointData> PathData, FPredictProjectilePathPointData LastTraceDestination, FHitResult HitResult)
		{
			this.PathData = PathData;
			this.LastTraceDestination = LastTraceDestination;
			this.HitResult = HitResult;
		}

		// Token: 0x0600E946 RID: 59718 RVA: 0x0015A925 File Offset: 0x00158B25
		protected override IntPtr GetUStructPtr()
		{
			return FPredictProjectilePathResult.StaticStruct();
		}

		// Token: 0x0600E947 RID: 59719 RVA: 0x0015A931 File Offset: 0x00158B31
		[NullableContext(2)]
		public FPredictProjectilePathResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E948 RID: 59720 RVA: 0x0015A93B File Offset: 0x00158B3B
		public FPredictProjectilePathResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E949 RID: 59721 RVA: 0x0015A946 File Offset: 0x00158B46
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredictProjectilePathResult(Pointer, false, true);
		}

		// Token: 0x0600E94A RID: 59722 RVA: 0x0015A950 File Offset: 0x00158B50
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredictProjectilePathResult(Pointer, MemoryOwner);
		}

		// Token: 0x04007E9E RID: 32414
		public const string __ObjectPath = "/Script/Engine.PredictProjectilePathResult";

		// Token: 0x04007E9F RID: 32415
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007EA0 RID: 32416
		internal static int __PropertyOffset_PathData;

		// Token: 0x04007EA1 RID: 32417
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPredictProjectilePathPointData> _PathData;

		// Token: 0x04007EA2 RID: 32418
		internal static int __PropertyOffset_LastTraceDestination;

		// Token: 0x04007EA3 RID: 32419
		[Nullable(2)]
		private FPredictProjectilePathPointData _LastTraceDestination;

		// Token: 0x04007EA4 RID: 32420
		internal static int __PropertyOffset_HitResult;

		// Token: 0x04007EA5 RID: 32421
		[Nullable(2)]
		private FHitResult _HitResult;
	}
}
