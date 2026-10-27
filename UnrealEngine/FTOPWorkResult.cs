using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200150C RID: 5388
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.TOPWorkResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTOPWorkResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060139BF RID: 80319 RVA: 0x001CCD29 File Offset: 0x001CAF29
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTOPWorkResult._ScriptStructPtr != 0) ? FTOPWorkResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HoudiniEngineRuntime.TOPWorkResult", ref FTOPWorkResult._ScriptStructPtr);
		}

		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x060139C0 RID: 80320 RVA: 0x001CCD4D File Offset: 0x001CAF4D
		// (set) Token: 0x060139C1 RID: 80321 RVA: 0x001CCD5D File Offset: 0x001CAF5D
		public unsafe int WorkItemIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTOPWorkResult.__PropertyOffset_WorkItemIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTOPWorkResult.__PropertyOffset_WorkItemIndex) = value;
			}
		}

		// Token: 0x17004CD5 RID: 19669
		// (get) Token: 0x060139C2 RID: 80322 RVA: 0x001CCD6E File Offset: 0x001CAF6E
		// (set) Token: 0x060139C3 RID: 80323 RVA: 0x001CCD7E File Offset: 0x001CAF7E
		public unsafe int WorkItemID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTOPWorkResult.__PropertyOffset_WorkItemID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTOPWorkResult.__PropertyOffset_WorkItemID) = value;
			}
		}

		// Token: 0x17004CD6 RID: 19670
		// (get) Token: 0x060139C4 RID: 80324 RVA: 0x001CCD90 File Offset: 0x001CAF90
		// (set) Token: 0x060139C5 RID: 80325 RVA: 0x001CCDD3 File Offset: 0x001CAFD3
		public TArray<FTOPWorkResultObject> ResultObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTOPWorkResultObject> result;
				if ((result = this._ResultObjects) == null)
				{
					result = (this._ResultObjects = new TArray<FTOPWorkResultObject>(base.NativePtr + (IntPtr)FTOPWorkResult.__PropertyOffset_ResultObjects, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ResultObjects.CopyAssign(value);
			}
		}

		// Token: 0x060139C6 RID: 80326 RVA: 0x001CCDE1 File Offset: 0x001CAFE1
		public FTOPWorkResult()
		{
		}

		// Token: 0x060139C7 RID: 80327 RVA: 0x001CCDE9 File Offset: 0x001CAFE9
		public FTOPWorkResult(int WorkItemIndex, int WorkItemID, TArray<FTOPWorkResultObject> ResultObjects)
		{
			this.WorkItemIndex = WorkItemIndex;
			this.WorkItemID = WorkItemID;
			this.ResultObjects = ResultObjects;
		}

		// Token: 0x060139C8 RID: 80328 RVA: 0x001CCE06 File Offset: 0x001CB006
		protected override IntPtr GetUStructPtr()
		{
			return FTOPWorkResult.StaticStruct();
		}

		// Token: 0x060139C9 RID: 80329 RVA: 0x001CCE12 File Offset: 0x001CB012
		[NullableContext(2)]
		public FTOPWorkResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060139CA RID: 80330 RVA: 0x001CCE1C File Offset: 0x001CB01C
		public FTOPWorkResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060139CB RID: 80331 RVA: 0x001CCE27 File Offset: 0x001CB027
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTOPWorkResult(Pointer, false, true);
		}

		// Token: 0x060139CC RID: 80332 RVA: 0x001CCE31 File Offset: 0x001CB031
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTOPWorkResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400A97A RID: 43386
		public const string __ObjectPath = "/Script/HoudiniEngineRuntime.TOPWorkResult";

		// Token: 0x0400A97B RID: 43387
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A97C RID: 43388
		internal static int __PropertyOffset_WorkItemIndex;

		// Token: 0x0400A97D RID: 43389
		internal static int __PropertyOffset_WorkItemID;

		// Token: 0x0400A97E RID: 43390
		internal static int __PropertyOffset_ResultObjects;

		// Token: 0x0400A97F RID: 43391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTOPWorkResultObject> _ResultObjects;
	}
}
