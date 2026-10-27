using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E1 RID: 6625
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMovement.KuroDebugMovementComponent")]
	[UnrealStructLayout(2176, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2176)]
	public class UKuroDebugMovementComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018949 RID: 100681 RVA: 0x00243362 File Offset: 0x00241562
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDebugMovementComponent._ClassPtr;
		}

		// Token: 0x0601894A RID: 100682 RVA: 0x00243370 File Offset: 0x00241570
		public UKuroDebugMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroDebugMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601894B RID: 100683 RVA: 0x00243398 File Offset: 0x00241598
		public UKuroDebugMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDebugMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061EA RID: 25066
		// (get) Token: 0x0601894C RID: 100684 RVA: 0x002433CB File Offset: 0x002415CB
		// (set) Token: 0x0601894D RID: 100685 RVA: 0x002433DB File Offset: 0x002415DB
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

		// Token: 0x170061EB RID: 25067
		// (get) Token: 0x0601894E RID: 100686 RVA: 0x002433EC File Offset: 0x002415EC
		// (set) Token: 0x0601894F RID: 100687 RVA: 0x00243405 File Offset: 0x00241605
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

		// Token: 0x170061EC RID: 25068
		// (get) Token: 0x06018950 RID: 100688 RVA: 0x00243435 File Offset: 0x00241635
		// (set) Token: 0x06018951 RID: 100689 RVA: 0x00243445 File Offset: 0x00241645
		public unsafe EKDMDrawDebugType bDrawDebug
		{
			get
			{
				return (EKDMDrawDebugType)(*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bDrawDebug));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroDebugMovementComponent.__PropertyOffset_bDrawDebug) = (byte)value;
			}
		}

		// Token: 0x170061ED RID: 25069
		// (get) Token: 0x06018952 RID: 100690 RVA: 0x00243456 File Offset: 0x00241656
		// (set) Token: 0x06018953 RID: 100691 RVA: 0x0024346F File Offset: 0x0024166F
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

		// Token: 0x170061EE RID: 25070
		// (get) Token: 0x06018954 RID: 100692 RVA: 0x0024349F File Offset: 0x0024169F
		// (set) Token: 0x06018955 RID: 100693 RVA: 0x002434B8 File Offset: 0x002416B8
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

		// Token: 0x06018956 RID: 100694 RVA: 0x002434E8 File Offset: 0x002416E8
		public void UnResigter()
		{
			UKuroDebugMovementComponent.__UnResigter_Internal(base.NativePtr);
		}

		// Token: 0x06018957 RID: 100695 RVA: 0x002434F5 File Offset: 0x002416F5
		public void SetDebug(bool bDebug, bool bDetial)
		{
			UKuroDebugMovementComponent.__SetDebug_Internal(base.NativePtr, bDebug, bDetial);
		}

		// Token: 0x06018958 RID: 100696 RVA: 0x00243504 File Offset: 0x00241704
		public void Resigter()
		{
			UKuroDebugMovementComponent.__Resigter_Internal(base.NativePtr);
		}

		// Token: 0x06018959 RID: 100697 RVA: 0x00243514 File Offset: 0x00241714
		public unsafe void RecordModifyInfo(string Context, FVector CustomVector, EKDMRecordType Type = EKDMRecordType.KDM_ALL)
		{
			FString fstring = FString.AllocTemp(Context);
			UKuroDebugMovementComponent.__RecordModifyInfo_Internal(base.NativePtr, fstring, CustomVector, Type);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601895A RID: 100698 RVA: 0x00243545 File Offset: 0x00241745
		public static string KuroDebugMovementBaseRecordToString([Nullable(2)] FBaseRecord Record)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroDebugMovementComponent.__KuroDebugMovementBaseRecordToString_Internal((Record ?? new FBaseRecord()).NativePtr));
		}

		// Token: 0x0601895B RID: 100699 RVA: 0x00243560 File Offset: 0x00241760
		public int GetRecordFrames()
		{
			return UKuroDebugMovementComponent.__GetRecordFrames_Internal(base.NativePtr);
		}

		// Token: 0x0601895C RID: 100700 RVA: 0x0024356D File Offset: 0x0024176D
		public TArray<FSingleFrameDebugInfo> GetRecentRecords()
		{
			return new TArray<FSingleFrameDebugInfo>(UKuroDebugMovementComponent.__GetRecentRecords_Internal(base.NativePtr), null);
		}

		// Token: 0x0601895D RID: 100701 RVA: 0x00243580 File Offset: 0x00241780
		public FSingleFrameDebugInfo GetPreviousRecord(int preNum)
		{
			return new FSingleFrameDebugInfo(UKuroDebugMovementComponent.__GetPreviousRecord_Internal(base.NativePtr, preNum), null);
		}

		// Token: 0x0601895E RID: 100702 RVA: 0x00243594 File Offset: 0x00241794
		public int GetMaxRecordFrameCount()
		{
			return UKuroDebugMovementComponent.__GetMaxRecordFrameCount_Internal(base.NativePtr);
		}

		// Token: 0x0601895F RID: 100703 RVA: 0x002435A1 File Offset: 0x002417A1
		public string GetFrameCountInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroDebugMovementComponent.__GetFrameCountInfo_Internal(base.NativePtr));
		}

		// Token: 0x06018960 RID: 100704 RVA: 0x002435B3 File Offset: 0x002417B3
		public int GetCurrentFrameIndex()
		{
			return UKuroDebugMovementComponent.__GetCurrentFrameIndex_Internal(base.NativePtr);
		}

		// Token: 0x06018961 RID: 100705 RVA: 0x002435C0 File Offset: 0x002417C0
		[NullableContext(2)]
		public void DrawRecord(in FBaseRecord Record, float SphereRadius = 4f, float ArrowLength = 50f)
		{
			UKuroDebugMovementComponent.__DrawRecord_Internal(base.NativePtr, (Record ?? new FBaseRecord()).NativePtr, SphereRadius, ArrowLength);
		}

		// Token: 0x06018962 RID: 100706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnResigter_Internal(IntPtr @this);

		// Token: 0x06018963 RID: 100707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebug_Internal(IntPtr @this, bool bDebug, bool bDetial);

		// Token: 0x06018964 RID: 100708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Resigter_Internal(IntPtr @this);

		// Token: 0x06018965 RID: 100709
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecordModifyInfo_Internal(IntPtr @this, in FString Context, FVector CustomVector, TEnumAsByte<EKDMRecordType> Type);

		// Token: 0x06018966 RID: 100710
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __KuroDebugMovementBaseRecordToString_Internal(IntPtr Record);

		// Token: 0x06018967 RID: 100711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetRecordFrames_Internal(IntPtr @this);

		// Token: 0x06018968 RID: 100712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRecentRecords_Internal(IntPtr @this);

		// Token: 0x06018969 RID: 100713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPreviousRecord_Internal(IntPtr @this, int preNum);

		// Token: 0x0601896A RID: 100714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMaxRecordFrameCount_Internal(IntPtr @this);

		// Token: 0x0601896B RID: 100715
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetFrameCountInfo_Internal(IntPtr @this);

		// Token: 0x0601896C RID: 100716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentFrameIndex_Internal(IntPtr @this);

		// Token: 0x0601896D RID: 100717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawRecord_Internal(IntPtr @this, IntPtr Record, float SphereRadius, float ArrowLength);

		// Token: 0x0601896E RID: 100718 RVA: 0x002435DF File Offset: 0x002417DF
		static UKuroDebugMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroDebugMovementComponent");
		}

		// Token: 0x0601896F RID: 100719 RVA: 0x002435ED File Offset: 0x002417ED
		protected UKuroDebugMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D499 RID: 54425
		public new const string __ObjectPath = "/Script/KuroMovement.KuroDebugMovementComponent";

		// Token: 0x0400D49A RID: 54426
		private static IntPtr _ClassPtr;

		// Token: 0x0400D49B RID: 54427
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D49C RID: 54428
		internal static int __PropertyOffset_DrawDebugCount;

		// Token: 0x0400D49D RID: 54429
		internal static int __PropertyOffset_bShowLog;

		// Token: 0x0400D49E RID: 54430
		internal static byte __PropertyMask_bShowLog;

		// Token: 0x0400D49F RID: 54431
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x0400D4A0 RID: 54432
		internal static int __PropertyOffset_bRecording;

		// Token: 0x0400D4A1 RID: 54433
		internal static byte __PropertyMask_bRecording;

		// Token: 0x0400D4A2 RID: 54434
		internal static int __PropertyOffset_bHasPersistentRecord;

		// Token: 0x0400D4A3 RID: 54435
		internal static byte __PropertyMask_bHasPersistentRecord;
	}
}
