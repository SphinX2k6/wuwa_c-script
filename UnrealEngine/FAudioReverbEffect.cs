using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200086E RID: 2158
	[UnrealObjectPath("/Script/Engine.AudioReverbEffect")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAudioReverbEffect : FAudioEffectParameters, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007521 RID: 29985 RVA: 0x000A7E0D File Offset: 0x000A600D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioReverbEffect._ScriptStructPtr != 0) ? FAudioReverbEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AudioReverbEffect", ref FAudioReverbEffect._ScriptStructPtr);
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x000A7E31 File Offset: 0x000A6031
		public FAudioReverbEffect()
		{
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x000A7E39 File Offset: 0x000A6039
		protected override IntPtr GetUStructPtr()
		{
			return FAudioReverbEffect.StaticStruct();
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x000A7E45 File Offset: 0x000A6045
		[NullableContext(2)]
		public FAudioReverbEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x000A7E4F File Offset: 0x000A604F
		public FAudioReverbEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x000A7E5A File Offset: 0x000A605A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioReverbEffect(Pointer, false, true);
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x000A7E64 File Offset: 0x000A6064
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioReverbEffect(Pointer, MemoryOwner);
		}

		// Token: 0x0400384D RID: 14413
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AudioReverbEffect";

		// Token: 0x0400384E RID: 14414
		private static IntPtr _ScriptStructPtr;
	}
}
