using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024DB RID: 9435
	[UnrealObjectPath("/Script/Niagara.EmitterCompiledScriptPair")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FEmitterCompiledScriptPair : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023407 RID: 144391 RVA: 0x0034238C File Offset: 0x0034058C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterCompiledScriptPair._ScriptStructPtr != 0) ? FEmitterCompiledScriptPair._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.EmitterCompiledScriptPair", ref FEmitterCompiledScriptPair._ScriptStructPtr);
		}

		// Token: 0x06023408 RID: 144392 RVA: 0x003423B0 File Offset: 0x003405B0
		public FEmitterCompiledScriptPair()
		{
		}

		// Token: 0x06023409 RID: 144393 RVA: 0x003423B8 File Offset: 0x003405B8
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterCompiledScriptPair.StaticStruct();
		}

		// Token: 0x0602340A RID: 144394 RVA: 0x003423C4 File Offset: 0x003405C4
		[NullableContext(2)]
		public FEmitterCompiledScriptPair(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602340B RID: 144395 RVA: 0x003423CE File Offset: 0x003405CE
		public FEmitterCompiledScriptPair(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602340C RID: 144396 RVA: 0x003423D9 File Offset: 0x003405D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterCompiledScriptPair(Pointer, false, true);
		}

		// Token: 0x0602340D RID: 144397 RVA: 0x003423E3 File Offset: 0x003405E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterCompiledScriptPair(Pointer, MemoryOwner);
		}

		// Token: 0x04012D96 RID: 77206
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.EmitterCompiledScriptPair";

		// Token: 0x04012D97 RID: 77207
		private static IntPtr _ScriptStructPtr;
	}
}
