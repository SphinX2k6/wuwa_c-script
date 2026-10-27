using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002951 RID: 10577
	[UnrealObjectPath("/Script/UMG.DynamicPropertyPath")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FDynamicPropertyPath : FCachedPropertyPath, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060272B3 RID: 160435 RVA: 0x003BB789 File Offset: 0x003B9989
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDynamicPropertyPath._ScriptStructPtr != 0) ? FDynamicPropertyPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.DynamicPropertyPath", ref FDynamicPropertyPath._ScriptStructPtr);
		}

		// Token: 0x060272B4 RID: 160436 RVA: 0x003BB7AD File Offset: 0x003B99AD
		public FDynamicPropertyPath()
		{
		}

		// Token: 0x060272B5 RID: 160437 RVA: 0x003BB7B5 File Offset: 0x003B99B5
		[NullableContext(1)]
		public FDynamicPropertyPath(TArray<FPropertyPathSegment> Segments, UFunction CachedFunction)
		{
			base.Segments = Segments;
			base.CachedFunction = CachedFunction;
		}

		// Token: 0x060272B6 RID: 160438 RVA: 0x003BB7CB File Offset: 0x003B99CB
		protected override IntPtr GetUStructPtr()
		{
			return FDynamicPropertyPath.StaticStruct();
		}

		// Token: 0x060272B7 RID: 160439 RVA: 0x003BB7D7 File Offset: 0x003B99D7
		[NullableContext(2)]
		public FDynamicPropertyPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060272B8 RID: 160440 RVA: 0x003BB7E1 File Offset: 0x003B99E1
		public FDynamicPropertyPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060272B9 RID: 160441 RVA: 0x003BB7EC File Offset: 0x003B99EC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDynamicPropertyPath(Pointer, false, true);
		}

		// Token: 0x060272BA RID: 160442 RVA: 0x003BB7F6 File Offset: 0x003B99F6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDynamicPropertyPath(Pointer, MemoryOwner);
		}

		// Token: 0x04015817 RID: 88087
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.DynamicPropertyPath";

		// Token: 0x04015818 RID: 88088
		private static IntPtr _ScriptStructPtr;
	}
}
