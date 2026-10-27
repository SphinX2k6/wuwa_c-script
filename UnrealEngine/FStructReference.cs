using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000700 RID: 1792
	[UnrealObjectPath("/Script/ControlRig.StructReference")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FStructReference : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600610E RID: 24846 RVA: 0x0008B25D File Offset: 0x0008945D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructReference._ScriptStructPtr != 0) ? FStructReference._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.StructReference", ref FStructReference._ScriptStructPtr);
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x0008B281 File Offset: 0x00089481
		public FStructReference()
		{
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x0008B289 File Offset: 0x00089489
		protected override IntPtr GetUStructPtr()
		{
			return FStructReference.StaticStruct();
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x0008B295 File Offset: 0x00089495
		[NullableContext(2)]
		public FStructReference(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x0008B29F File Offset: 0x0008949F
		public FStructReference(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x0008B2AA File Offset: 0x000894AA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructReference(Pointer, false, true);
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x0008B2B4 File Offset: 0x000894B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructReference(Pointer, MemoryOwner);
		}

		// Token: 0x04002D62 RID: 11618
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.StructReference";

		// Token: 0x04002D63 RID: 11619
		private static IntPtr _ScriptStructPtr;
	}
}
