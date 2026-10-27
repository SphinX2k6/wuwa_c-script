using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001296 RID: 4758
	[UnrealObjectPath("/Script/Engine.WpSplitPakHelper")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FWpSplitPakHelper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011769 RID: 71529 RVA: 0x0019A326 File Offset: 0x00198526
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWpSplitPakHelper._ScriptStructPtr != 0) ? FWpSplitPakHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WpSplitPakHelper", ref FWpSplitPakHelper._ScriptStructPtr);
		}

		// Token: 0x0601176A RID: 71530 RVA: 0x0019A34A File Offset: 0x0019854A
		public FWpSplitPakHelper()
		{
		}

		// Token: 0x0601176B RID: 71531 RVA: 0x0019A352 File Offset: 0x00198552
		[NullableContext(1)]
		public FWpSplitPakHelper(TArray<URegionPackFilter> RegionPakFilters, TArray<string> ExcludeGrids, TMap<FName, FBox> BoundsMap)
		{
		}

		// Token: 0x0601176C RID: 71532 RVA: 0x0019A35A File Offset: 0x0019855A
		protected override IntPtr GetUStructPtr()
		{
			return FWpSplitPakHelper.StaticStruct();
		}

		// Token: 0x0601176D RID: 71533 RVA: 0x0019A366 File Offset: 0x00198566
		[NullableContext(2)]
		public FWpSplitPakHelper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601176E RID: 71534 RVA: 0x0019A370 File Offset: 0x00198570
		public FWpSplitPakHelper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601176F RID: 71535 RVA: 0x0019A37B File Offset: 0x0019857B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWpSplitPakHelper(Pointer, false, true);
		}

		// Token: 0x06011770 RID: 71536 RVA: 0x0019A385 File Offset: 0x00198585
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWpSplitPakHelper(Pointer, MemoryOwner);
		}

		// Token: 0x04009590 RID: 38288
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WpSplitPakHelper";

		// Token: 0x04009591 RID: 38289
		private static IntPtr _ScriptStructPtr;
	}
}
