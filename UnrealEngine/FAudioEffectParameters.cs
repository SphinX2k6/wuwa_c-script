using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200086A RID: 2154
	[UnrealObjectPath("/Script/Engine.AudioEffectParameters")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FAudioEffectParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060074EA RID: 29930 RVA: 0x000A7A0B File Offset: 0x000A5C0B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioEffectParameters._ScriptStructPtr != 0) ? FAudioEffectParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AudioEffectParameters", ref FAudioEffectParameters._ScriptStructPtr);
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x000A7A2F File Offset: 0x000A5C2F
		public FAudioEffectParameters()
		{
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x000A7A37 File Offset: 0x000A5C37
		protected override IntPtr GetUStructPtr()
		{
			return FAudioEffectParameters.StaticStruct();
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x000A7A43 File Offset: 0x000A5C43
		[NullableContext(2)]
		public FAudioEffectParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x000A7A4D File Offset: 0x000A5C4D
		public FAudioEffectParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x000A7A58 File Offset: 0x000A5C58
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioEffectParameters(Pointer, false, true);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x000A7A62 File Offset: 0x000A5C62
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioEffectParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04003835 RID: 14389
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AudioEffectParameters";

		// Token: 0x04003836 RID: 14390
		private static IntPtr _ScriptStructPtr;
	}
}
