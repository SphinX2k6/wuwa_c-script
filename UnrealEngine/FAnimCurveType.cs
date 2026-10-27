using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000806 RID: 2054
	[UnrealObjectPath("/Script/Engine.AnimCurveType")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FAnimCurveType : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006D78 RID: 28024 RVA: 0x0009D8F7 File Offset: 0x0009BAF7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimCurveType._ScriptStructPtr != 0) ? FAnimCurveType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimCurveType", ref FAnimCurveType._ScriptStructPtr);
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x0009D91B File Offset: 0x0009BB1B
		public FAnimCurveType()
		{
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x0009D923 File Offset: 0x0009BB23
		protected override IntPtr GetUStructPtr()
		{
			return FAnimCurveType.StaticStruct();
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x0009D92F File Offset: 0x0009BB2F
		[NullableContext(2)]
		public FAnimCurveType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x0009D939 File Offset: 0x0009BB39
		public FAnimCurveType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x0009D944 File Offset: 0x0009BB44
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimCurveType(Pointer, false, true);
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x0009D94E File Offset: 0x0009BB4E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimCurveType(Pointer, MemoryOwner);
		}

		// Token: 0x040034E2 RID: 13538
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimCurveType";

		// Token: 0x040034E3 RID: 13539
		private static IntPtr _ScriptStructPtr;
	}
}
