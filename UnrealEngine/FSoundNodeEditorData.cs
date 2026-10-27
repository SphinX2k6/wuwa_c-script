using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001142 RID: 4418
	[UnrealObjectPath("/Script/Engine.SoundNodeEditorData")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FSoundNodeEditorData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601025F RID: 66143 RVA: 0x0017CB5D File Offset: 0x0017AD5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundNodeEditorData._ScriptStructPtr != 0) ? FSoundNodeEditorData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundNodeEditorData", ref FSoundNodeEditorData._ScriptStructPtr);
		}

		// Token: 0x06010260 RID: 66144 RVA: 0x0017CB81 File Offset: 0x0017AD81
		public FSoundNodeEditorData()
		{
		}

		// Token: 0x06010261 RID: 66145 RVA: 0x0017CB89 File Offset: 0x0017AD89
		protected override IntPtr GetUStructPtr()
		{
			return FSoundNodeEditorData.StaticStruct();
		}

		// Token: 0x06010262 RID: 66146 RVA: 0x0017CB95 File Offset: 0x0017AD95
		[NullableContext(2)]
		public FSoundNodeEditorData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010263 RID: 66147 RVA: 0x0017CB9F File Offset: 0x0017AD9F
		public FSoundNodeEditorData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010264 RID: 66148 RVA: 0x0017CBAA File Offset: 0x0017ADAA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundNodeEditorData(Pointer, false, true);
		}

		// Token: 0x06010265 RID: 66149 RVA: 0x0017CBB4 File Offset: 0x0017ADB4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundNodeEditorData(Pointer, MemoryOwner);
		}

		// Token: 0x04008AFC RID: 35580
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SoundNodeEditorData";

		// Token: 0x04008AFD RID: 35581
		private static IntPtr _ScriptStructPtr;
	}
}
