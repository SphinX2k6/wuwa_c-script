using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001292 RID: 4754
	[UnrealObjectPath("/Script/Engine.WpHLODCategory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FWpHLODCategory : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011737 RID: 71479 RVA: 0x00199F31 File Offset: 0x00198131
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWpHLODCategory._ScriptStructPtr != 0) ? FWpHLODCategory._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WpHLODCategory", ref FWpHLODCategory._ScriptStructPtr);
		}

		// Token: 0x06011738 RID: 71480 RVA: 0x00199F55 File Offset: 0x00198155
		public FWpHLODCategory()
		{
		}

		// Token: 0x06011739 RID: 71481 RVA: 0x00199F5D File Offset: 0x0019815D
		[NullableContext(1)]
		public FWpHLODCategory(string CategoryName, TArray<FName> BaseMaterialTypes, TArray<string> MeshTags)
		{
		}

		// Token: 0x0601173A RID: 71482 RVA: 0x00199F65 File Offset: 0x00198165
		protected override IntPtr GetUStructPtr()
		{
			return FWpHLODCategory.StaticStruct();
		}

		// Token: 0x0601173B RID: 71483 RVA: 0x00199F71 File Offset: 0x00198171
		[NullableContext(2)]
		public FWpHLODCategory(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601173C RID: 71484 RVA: 0x00199F7B File Offset: 0x0019817B
		public FWpHLODCategory(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601173D RID: 71485 RVA: 0x00199F86 File Offset: 0x00198186
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWpHLODCategory(Pointer, false, true);
		}

		// Token: 0x0601173E RID: 71486 RVA: 0x00199F90 File Offset: 0x00198190
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWpHLODCategory(Pointer, MemoryOwner);
		}

		// Token: 0x0400957B RID: 38267
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.WpHLODCategory";

		// Token: 0x0400957C RID: 38268
		private static IntPtr _ScriptStructPtr;
	}
}
