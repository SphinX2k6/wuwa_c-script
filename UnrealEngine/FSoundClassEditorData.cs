using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001128 RID: 4392
	[UnrealObjectPath("/Script/Engine.SoundClassEditorData")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FSoundClassEditorData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010119 RID: 65817 RVA: 0x0017ABE6 File Offset: 0x00178DE6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundClassEditorData._ScriptStructPtr != 0) ? FSoundClassEditorData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundClassEditorData", ref FSoundClassEditorData._ScriptStructPtr);
		}

		// Token: 0x0601011A RID: 65818 RVA: 0x0017AC0A File Offset: 0x00178E0A
		public FSoundClassEditorData()
		{
		}

		// Token: 0x0601011B RID: 65819 RVA: 0x0017AC12 File Offset: 0x00178E12
		protected override IntPtr GetUStructPtr()
		{
			return FSoundClassEditorData.StaticStruct();
		}

		// Token: 0x0601011C RID: 65820 RVA: 0x0017AC1E File Offset: 0x00178E1E
		[NullableContext(2)]
		public FSoundClassEditorData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601011D RID: 65821 RVA: 0x0017AC28 File Offset: 0x00178E28
		public FSoundClassEditorData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601011E RID: 65822 RVA: 0x0017AC33 File Offset: 0x00178E33
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundClassEditorData(Pointer, false, true);
		}

		// Token: 0x0601011F RID: 65823 RVA: 0x0017AC3D File Offset: 0x00178E3D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundClassEditorData(Pointer, MemoryOwner);
		}

		// Token: 0x04008A36 RID: 35382
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundClassEditorData";

		// Token: 0x04008A37 RID: 35383
		private static IntPtr _ScriptStructPtr;
	}
}
