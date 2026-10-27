using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002484 RID: 9348
	[UnrealObjectPath("/Script/NavigationSystem.NavBatchProjectionResult")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FNavBatchProjectionResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022F67 RID: 143207 RVA: 0x0033B17A File Offset: 0x0033937A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavBatchProjectionResult._ScriptStructPtr != 0) ? FNavBatchProjectionResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/NavigationSystem.NavBatchProjectionResult", ref FNavBatchProjectionResult._ScriptStructPtr);
		}

		// Token: 0x1700864C RID: 34380
		// (get) Token: 0x06022F68 RID: 143208 RVA: 0x0033B19E File Offset: 0x0033939E
		// (set) Token: 0x06022F69 RID: 143209 RVA: 0x0033B1B2 File Offset: 0x003393B2
		public unsafe FVectorDouble OutLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavBatchProjectionResult.__PropertyOffset_OutLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavBatchProjectionResult.__PropertyOffset_OutLocation) = value;
			}
		}

		// Token: 0x1700864D RID: 34381
		// (get) Token: 0x06022F6A RID: 143210 RVA: 0x0033B1C7 File Offset: 0x003393C7
		// (set) Token: 0x06022F6B RID: 143211 RVA: 0x0033B1D7 File Offset: 0x003393D7
		public unsafe bool bResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavBatchProjectionResult.__PropertyOffset_bResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavBatchProjectionResult.__PropertyOffset_bResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022F6C RID: 143212 RVA: 0x0033B1E8 File Offset: 0x003393E8
		public FNavBatchProjectionResult()
		{
		}

		// Token: 0x06022F6D RID: 143213 RVA: 0x0033B1F0 File Offset: 0x003393F0
		public FNavBatchProjectionResult(FVectorDouble OutLocation, bool bResult)
		{
			this.OutLocation = OutLocation;
			this.bResult = bResult;
		}

		// Token: 0x06022F6E RID: 143214 RVA: 0x0033B206 File Offset: 0x00339406
		protected override IntPtr GetUStructPtr()
		{
			return FNavBatchProjectionResult.StaticStruct();
		}

		// Token: 0x06022F6F RID: 143215 RVA: 0x0033B212 File Offset: 0x00339412
		[NullableContext(2)]
		public FNavBatchProjectionResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022F70 RID: 143216 RVA: 0x0033B21C File Offset: 0x0033941C
		public FNavBatchProjectionResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022F71 RID: 143217 RVA: 0x0033B227 File Offset: 0x00339427
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavBatchProjectionResult(Pointer, false, true);
		}

		// Token: 0x06022F72 RID: 143218 RVA: 0x0033B231 File Offset: 0x00339431
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavBatchProjectionResult(Pointer, MemoryOwner);
		}

		// Token: 0x04012ABB RID: 76475
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavBatchProjectionResult";

		// Token: 0x04012ABC RID: 76476
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012ABD RID: 76477
		internal static int __PropertyOffset_OutLocation;

		// Token: 0x04012ABE RID: 76478
		internal static int __PropertyOffset_bResult;
	}
}
