using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200026D RID: 621
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PredictProjectilePathResult")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FPredictProjectilePathResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003DAA RID: 15786 RVA: 0x00058E37 File Offset: 0x00057037
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPredictProjectilePathResult._ScriptStructPtr != 0) ? FPredictProjectilePathResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PredictProjectilePathResult", ref FPredictProjectilePathResult._ScriptStructPtr);
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06003DAB RID: 15787 RVA: 0x00058E5C File Offset: 0x0005705C
		// (set) Token: 0x06003DAC RID: 15788 RVA: 0x00058E9F File Offset: 0x0005709F
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

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06003DAD RID: 15789 RVA: 0x00058EB0 File Offset: 0x000570B0
		// (set) Token: 0x06003DAE RID: 15790 RVA: 0x00058EF3 File Offset: 0x000570F3
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

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x00058F14 File Offset: 0x00057114
		// (set) Token: 0x06003DB0 RID: 15792 RVA: 0x00058F57 File Offset: 0x00057157
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

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00058F78 File Offset: 0x00057178
		public FPredictProjectilePathResult()
		{
		}

		// Token: 0x06003DB2 RID: 15794 RVA: 0x00058F80 File Offset: 0x00057180
		protected override IntPtr GetUStructPtr()
		{
			return FPredictProjectilePathResult.StaticStruct();
		}

		// Token: 0x06003DB3 RID: 15795 RVA: 0x00058F8C File Offset: 0x0005718C
		[NullableContext(2)]
		public FPredictProjectilePathResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003DB4 RID: 15796 RVA: 0x00058F96 File Offset: 0x00057196
		public FPredictProjectilePathResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003DB5 RID: 15797 RVA: 0x00058FA1 File Offset: 0x000571A1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPredictProjectilePathResult(Pointer, false, true);
		}

		// Token: 0x06003DB6 RID: 15798 RVA: 0x00058FAB File Offset: 0x000571AB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPredictProjectilePathResult(Pointer, MemoryOwner);
		}

		// Token: 0x04001813 RID: 6163
		public const string __ObjectPath = "/Script/Engine.PredictProjectilePathResult";

		// Token: 0x04001814 RID: 6164
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001815 RID: 6165
		internal static int __PropertyOffset_PathData;

		// Token: 0x04001816 RID: 6166
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPredictProjectilePathPointData> _PathData;

		// Token: 0x04001817 RID: 6167
		internal static int __PropertyOffset_LastTraceDestination;

		// Token: 0x04001818 RID: 6168
		[Nullable(2)]
		private FPredictProjectilePathPointData _LastTraceDestination;

		// Token: 0x04001819 RID: 6169
		internal static int __PropertyOffset_HitResult;

		// Token: 0x0400181A RID: 6170
		[Nullable(2)]
		private FHitResult _HitResult;
	}
}
