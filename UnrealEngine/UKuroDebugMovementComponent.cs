using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200046F RID: 1135
	[UnrealObjectPath("/Script/KuroMovement.KuroDebugMovementComponent")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class UKuroDebugMovementComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006BF8 RID: 27640 RVA: 0x0009D28F File Offset: 0x0009B48F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDebugMovementComponent._ClassPtr;
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x0009D29C File Offset: 0x0009B49C
		public UKuroDebugMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroDebugMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x0009D2C4 File Offset: 0x0009B4C4
		[NullableContext(1)]
		public UKuroDebugMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDebugMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x0009D2F7 File Offset: 0x0009B4F7
		// (set) Token: 0x06006BFC RID: 27644 RVA: 0x0009D307 File Offset: 0x0009B507
		public unsafe int DrawDebugCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_DrawDebugCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_DrawDebugCount) = value;
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06006BFD RID: 27645 RVA: 0x0009D318 File Offset: 0x0009B518
		// (set) Token: 0x06006BFE RID: 27646 RVA: 0x0009D331 File Offset: 0x0009B531
		public unsafe bool bShowLog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bShowLog) & UKuroDebugMovementComponent.__PropertyMask_bShowLog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bShowLog) = ((*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bShowLog) & ~UKuroDebugMovementComponent.__PropertyMask_bShowLog) | (value ? UKuroDebugMovementComponent.__PropertyMask_bShowLog : 0));
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06006BFF RID: 27647 RVA: 0x0009D361 File Offset: 0x0009B561
		// (set) Token: 0x06006C00 RID: 27648 RVA: 0x0009D37A File Offset: 0x0009B57A
		public unsafe bool bRecording
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bRecording) & UKuroDebugMovementComponent.__PropertyMask_bRecording) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bRecording) = ((*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bRecording) & ~UKuroDebugMovementComponent.__PropertyMask_bRecording) | (value ? UKuroDebugMovementComponent.__PropertyMask_bRecording : 0));
			}
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06006C01 RID: 27649 RVA: 0x0009D3AA File Offset: 0x0009B5AA
		// (set) Token: 0x06006C02 RID: 27650 RVA: 0x0009D3C3 File Offset: 0x0009B5C3
		public unsafe bool bHasPersistentRecord
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bHasPersistentRecord) & UKuroDebugMovementComponent.__PropertyMask_bHasPersistentRecord) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bHasPersistentRecord) = ((*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bHasPersistentRecord) & ~UKuroDebugMovementComponent.__PropertyMask_bHasPersistentRecord) | (value ? UKuroDebugMovementComponent.__PropertyMask_bHasPersistentRecord : 0));
			}
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x0009D3F3 File Offset: 0x0009B5F3
		public void UnResigter()
		{
			UKuroDebugMovementComponent.__UnResigter_Internal(base.NativePtr);
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x0009D400 File Offset: 0x0009B600
		public void SetDebug(bool bDebug, bool bDetial)
		{
			UKuroDebugMovementComponent.__SetDebug_Internal(base.NativePtr, bDebug, bDetial);
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x0009D40F File Offset: 0x0009B60F
		public void Resigter()
		{
			UKuroDebugMovementComponent.__Resigter_Internal(base.NativePtr);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x0009D41C File Offset: 0x0009B61C
		[NullableContext(1)]
		public unsafe void RecordModifyInfo(string Context, FVector CustomVector, EKDMRecordType Type = EKDMRecordType.KDM_ALL)
		{
			FString fstring = FString.AllocTemp(Context);
			UKuroDebugMovementComponent.__RecordModifyInfo_Internal(base.NativePtr, fstring, CustomVector, Type);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x0009D44D File Offset: 0x0009B64D
		public int GetRecordFrames()
		{
			return UKuroDebugMovementComponent.__GetRecordFrames_Internal(base.NativePtr);
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x0009D45A File Offset: 0x0009B65A
		public int GetMaxRecordFrameCount()
		{
			return UKuroDebugMovementComponent.__GetMaxRecordFrameCount_Internal(base.NativePtr);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x0009D467 File Offset: 0x0009B667
		[NullableContext(1)]
		public string GetFrameCountInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroDebugMovementComponent.__GetFrameCountInfo_Internal(base.NativePtr));
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x0009D479 File Offset: 0x0009B679
		public int GetCurrentFrameIndex()
		{
			return UKuroDebugMovementComponent.__GetCurrentFrameIndex_Internal(base.NativePtr);
		}

		// Token: 0x06006C0B RID: 27659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnResigter_Internal(IntPtr @this);

		// Token: 0x06006C0C RID: 27660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebug_Internal(IntPtr @this, bool bDebug, bool bDetial);

		// Token: 0x06006C0D RID: 27661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resigter_Internal(IntPtr @this);

		// Token: 0x06006C0E RID: 27662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecordModifyInfo_Internal(IntPtr @this, in FString Context, FVector CustomVector, TEnumAsByte<EKDMRecordType> Type);

		// Token: 0x06006C0F RID: 27663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRecordFrames_Internal(IntPtr @this);

		// Token: 0x06006C10 RID: 27664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxRecordFrameCount_Internal(IntPtr @this);

		// Token: 0x06006C11 RID: 27665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFrameCountInfo_Internal(IntPtr @this);

		// Token: 0x06006C12 RID: 27666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentFrameIndex_Internal(IntPtr @this);

		// Token: 0x06006C13 RID: 27667 RVA: 0x0009D486 File Offset: 0x0009B686
		static UKuroDebugMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroDebugMovementComponent");
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x0009D494 File Offset: 0x0009B694
		protected UKuroDebugMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E18 RID: 11800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroDebugMovementComponent";

		// Token: 0x04002E19 RID: 11801
		private static IntPtr _ClassPtr;

		// Token: 0x04002E1A RID: 11802
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E1B RID: 11803
		internal static int __PropertyOffset_DrawDebugCount;

		// Token: 0x04002E1C RID: 11804
		internal static int __PropertyOffset_bShowLog;

		// Token: 0x04002E1D RID: 11805
		internal static byte __PropertyMask_bShowLog;

		// Token: 0x04002E1E RID: 11806
		internal static int __PropertyOffset_bRecording;

		// Token: 0x04002E1F RID: 11807
		internal static byte __PropertyMask_bRecording;

		// Token: 0x04002E20 RID: 11808
		internal static int __PropertyOffset_bHasPersistentRecord;

		// Token: 0x04002E21 RID: 11809
		internal static byte __PropertyMask_bHasPersistentRecord;
	}
}
