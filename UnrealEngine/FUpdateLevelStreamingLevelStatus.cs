using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001214 RID: 4628
	[UnrealObjectPath("/Script/Engine.UpdateLevelStreamingLevelStatus")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FUpdateLevelStreamingLevelStatus : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601109C RID: 69788 RVA: 0x0019008C File Offset: 0x0018E28C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUpdateLevelStreamingLevelStatus._ScriptStructPtr != 0) ? FUpdateLevelStreamingLevelStatus._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.UpdateLevelStreamingLevelStatus", ref FUpdateLevelStreamingLevelStatus._ScriptStructPtr);
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x0601109D RID: 69789 RVA: 0x001900B0 File Offset: 0x0018E2B0
		// (set) Token: 0x0601109E RID: 69790 RVA: 0x001900C4 File Offset: 0x0018E2C4
		public unsafe FName PackageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_PackageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_PackageName) = value;
			}
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x0601109F RID: 69791 RVA: 0x001900D9 File Offset: 0x0018E2D9
		// (set) Token: 0x060110A0 RID: 69792 RVA: 0x001900E9 File Offset: 0x0018E2E9
		public unsafe int LODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_LODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_LODIndex) = value;
			}
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x060110A1 RID: 69793 RVA: 0x001900FA File Offset: 0x0018E2FA
		// (set) Token: 0x060110A2 RID: 69794 RVA: 0x00190113 File Offset: 0x0018E313
		public unsafe bool bNewShouldBeLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBeLoaded) & FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBeLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBeLoaded) = ((*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBeLoaded) & ~FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBeLoaded) | (value ? FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBeLoaded : 0));
			}
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x060110A3 RID: 69795 RVA: 0x00190143 File Offset: 0x0018E343
		// (set) Token: 0x060110A4 RID: 69796 RVA: 0x0019015C File Offset: 0x0018E35C
		public unsafe bool bNewShouldBeVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBeVisible) & FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBeVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBeVisible) = ((*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBeVisible) & ~FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBeVisible) | (value ? FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBeVisible : 0));
			}
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x060110A5 RID: 69797 RVA: 0x0019018C File Offset: 0x0018E38C
		// (set) Token: 0x060110A6 RID: 69798 RVA: 0x001901A5 File Offset: 0x0018E3A5
		public unsafe bool bNewShouldBlockOnLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBlockOnLoad) & FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBlockOnLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBlockOnLoad) = ((*(base.NativePtr + (IntPtr)FUpdateLevelStreamingLevelStatus.__PropertyOffset_bNewShouldBlockOnLoad) & ~FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBlockOnLoad) | (value ? FUpdateLevelStreamingLevelStatus.__PropertyMask_bNewShouldBlockOnLoad : 0));
			}
		}

		// Token: 0x060110A7 RID: 69799 RVA: 0x001901D5 File Offset: 0x0018E3D5
		public FUpdateLevelStreamingLevelStatus()
		{
		}

		// Token: 0x060110A8 RID: 69800 RVA: 0x001901DD File Offset: 0x0018E3DD
		public FUpdateLevelStreamingLevelStatus(FName PackageName, int LODIndex, bool bNewShouldBeLoaded, bool bNewShouldBeVisible, bool bNewShouldBlockOnLoad)
		{
			this.PackageName = PackageName;
			this.LODIndex = LODIndex;
			this.bNewShouldBeLoaded = bNewShouldBeLoaded;
			this.bNewShouldBeVisible = bNewShouldBeVisible;
			this.bNewShouldBlockOnLoad = bNewShouldBlockOnLoad;
		}

		// Token: 0x060110A9 RID: 69801 RVA: 0x0019020A File Offset: 0x0018E40A
		protected override IntPtr GetUStructPtr()
		{
			return FUpdateLevelStreamingLevelStatus.StaticStruct();
		}

		// Token: 0x060110AA RID: 69802 RVA: 0x00190216 File Offset: 0x0018E416
		[NullableContext(2)]
		public FUpdateLevelStreamingLevelStatus(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060110AB RID: 69803 RVA: 0x00190220 File Offset: 0x0018E420
		public FUpdateLevelStreamingLevelStatus(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060110AC RID: 69804 RVA: 0x0019022B File Offset: 0x0018E42B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUpdateLevelStreamingLevelStatus(Pointer, false, true);
		}

		// Token: 0x060110AD RID: 69805 RVA: 0x00190235 File Offset: 0x0018E435
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUpdateLevelStreamingLevelStatus(Pointer, MemoryOwner);
		}

		// Token: 0x040091EA RID: 37354
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.UpdateLevelStreamingLevelStatus";

		// Token: 0x040091EB RID: 37355
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091EC RID: 37356
		internal static int __PropertyOffset_PackageName;

		// Token: 0x040091ED RID: 37357
		internal static int __PropertyOffset_LODIndex;

		// Token: 0x040091EE RID: 37358
		internal static int __PropertyOffset_bNewShouldBeLoaded;

		// Token: 0x040091EF RID: 37359
		internal static byte __PropertyMask_bNewShouldBeLoaded;

		// Token: 0x040091F0 RID: 37360
		internal static int __PropertyOffset_bNewShouldBeVisible;

		// Token: 0x040091F1 RID: 37361
		internal static byte __PropertyMask_bNewShouldBeVisible;

		// Token: 0x040091F2 RID: 37362
		internal static int __PropertyOffset_bNewShouldBlockOnLoad;

		// Token: 0x040091F3 RID: 37363
		internal static byte __PropertyMask_bNewShouldBlockOnLoad;
	}
}
