using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D3F RID: 3391
	[UnrealObjectPath("/Script/Engine.LevelStreamingStatus")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FLevelStreamingStatus : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B5B5 RID: 46517 RVA: 0x001033E2 File Offset: 0x001015E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLevelStreamingStatus._ScriptStructPtr != 0) ? FLevelStreamingStatus._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LevelStreamingStatus", ref FLevelStreamingStatus._ScriptStructPtr);
		}

		// Token: 0x1700298C RID: 10636
		// (get) Token: 0x0600B5B6 RID: 46518 RVA: 0x00103406 File Offset: 0x00101606
		// (set) Token: 0x0600B5B7 RID: 46519 RVA: 0x0010341A File Offset: 0x0010161A
		public unsafe FName PackageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_PackageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_PackageName) = value;
			}
		}

		// Token: 0x1700298D RID: 10637
		// (get) Token: 0x0600B5B8 RID: 46520 RVA: 0x0010342F File Offset: 0x0010162F
		// (set) Token: 0x0600B5B9 RID: 46521 RVA: 0x00103448 File Offset: 0x00101648
		public unsafe bool bShouldBeLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_bShouldBeLoaded) & FLevelStreamingStatus.__PropertyMask_bShouldBeLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_bShouldBeLoaded) = ((*(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_bShouldBeLoaded) & ~FLevelStreamingStatus.__PropertyMask_bShouldBeLoaded) | (value ? FLevelStreamingStatus.__PropertyMask_bShouldBeLoaded : 0));
			}
		}

		// Token: 0x1700298E RID: 10638
		// (get) Token: 0x0600B5BA RID: 46522 RVA: 0x00103478 File Offset: 0x00101678
		// (set) Token: 0x0600B5BB RID: 46523 RVA: 0x00103491 File Offset: 0x00101691
		public unsafe bool bShouldBeVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_bShouldBeVisible) & FLevelStreamingStatus.__PropertyMask_bShouldBeVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_bShouldBeVisible) = ((*(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_bShouldBeVisible) & ~FLevelStreamingStatus.__PropertyMask_bShouldBeVisible) | (value ? FLevelStreamingStatus.__PropertyMask_bShouldBeVisible : 0));
			}
		}

		// Token: 0x1700298F RID: 10639
		// (get) Token: 0x0600B5BC RID: 46524 RVA: 0x001034C1 File Offset: 0x001016C1
		// (set) Token: 0x0600B5BD RID: 46525 RVA: 0x001034D1 File Offset: 0x001016D1
		public unsafe uint LODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_LODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLevelStreamingStatus.__PropertyOffset_LODIndex) = (int)value;
			}
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x001034E2 File Offset: 0x001016E2
		public FLevelStreamingStatus()
		{
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x001034EA File Offset: 0x001016EA
		public FLevelStreamingStatus(FName PackageName, bool bShouldBeLoaded, bool bShouldBeVisible, uint LODIndex)
		{
			this.PackageName = PackageName;
			this.bShouldBeLoaded = bShouldBeLoaded;
			this.bShouldBeVisible = bShouldBeVisible;
			this.LODIndex = LODIndex;
		}

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x0010350F File Offset: 0x0010170F
		protected override IntPtr GetUStructPtr()
		{
			return FLevelStreamingStatus.StaticStruct();
		}

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x0010351B File Offset: 0x0010171B
		[NullableContext(2)]
		public FLevelStreamingStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x00103525 File Offset: 0x00101725
		public FLevelStreamingStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x00103530 File Offset: 0x00101730
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLevelStreamingStatus(Pointer, false, true);
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x0010353A File Offset: 0x0010173A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLevelStreamingStatus(Pointer, MemoryOwner);
		}

		// Token: 0x04005F7F RID: 24447
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LevelStreamingStatus";

		// Token: 0x04005F80 RID: 24448
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005F81 RID: 24449
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04005F82 RID: 24450
		internal static int __PropertyOffset_bShouldBeLoaded;

		// Token: 0x04005F83 RID: 24451
		internal static byte __PropertyMask_bShouldBeLoaded;

		// Token: 0x04005F84 RID: 24452
		internal static int __PropertyOffset_bShouldBeVisible;

		// Token: 0x04005F85 RID: 24453
		internal static byte __PropertyMask_bShouldBeVisible;

		// Token: 0x04005F86 RID: 24454
		internal static int __PropertyOffset_LODIndex;
	}
}
