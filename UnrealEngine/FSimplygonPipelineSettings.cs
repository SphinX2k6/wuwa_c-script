using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020027DE RID: 10206
	[UnrealObjectPath("/Script/SimplygonUObjects.SimplygonPipelineSettings")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSimplygonPipelineSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060260DC RID: 155868 RVA: 0x0039B851 File Offset: 0x00399A51
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimplygonPipelineSettings._ScriptStructPtr != 0) ? FSimplygonPipelineSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SimplygonUObjects.SimplygonPipelineSettings", ref FSimplygonPipelineSettings._ScriptStructPtr);
		}

		// Token: 0x060260DD RID: 155869 RVA: 0x0039B875 File Offset: 0x00399A75
		public FSimplygonPipelineSettings()
		{
		}

		// Token: 0x060260DE RID: 155870 RVA: 0x0039B87D File Offset: 0x00399A7D
		protected override IntPtr GetUStructPtr()
		{
			return FSimplygonPipelineSettings.StaticStruct();
		}

		// Token: 0x060260DF RID: 155871 RVA: 0x0039B889 File Offset: 0x00399A89
		[NullableContext(2)]
		public FSimplygonPipelineSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060260E0 RID: 155872 RVA: 0x0039B893 File Offset: 0x00399A93
		public FSimplygonPipelineSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060260E1 RID: 155873 RVA: 0x0039B89E File Offset: 0x00399A9E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimplygonPipelineSettings(Pointer, false, true);
		}

		// Token: 0x060260E2 RID: 155874 RVA: 0x0039B8A8 File Offset: 0x00399AA8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimplygonPipelineSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04014C7C RID: 85116
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SimplygonUObjects.SimplygonPipelineSettings";

		// Token: 0x04014C7D RID: 85117
		private static IntPtr _ScriptStructPtr;
	}
}
