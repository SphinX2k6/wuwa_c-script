using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C48 RID: 3144
	[UnrealObjectPath("/Script/Engine.InertializationPose")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FInertializationPose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F81 RID: 40833 RVA: 0x000E2A8B File Offset: 0x000E0C8B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInertializationPose._ScriptStructPtr != 0) ? FInertializationPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InertializationPose", ref FInertializationPose._ScriptStructPtr);
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x000E2AAF File Offset: 0x000E0CAF
		public FInertializationPose()
		{
		}

		// Token: 0x06009F83 RID: 40835 RVA: 0x000E2AB7 File Offset: 0x000E0CB7
		protected override IntPtr GetUStructPtr()
		{
			return FInertializationPose.StaticStruct();
		}

		// Token: 0x06009F84 RID: 40836 RVA: 0x000E2AC3 File Offset: 0x000E0CC3
		[NullableContext(2)]
		public FInertializationPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F85 RID: 40837 RVA: 0x000E2ACD File Offset: 0x000E0CCD
		public FInertializationPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F86 RID: 40838 RVA: 0x000E2AD8 File Offset: 0x000E0CD8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInertializationPose(Pointer, false, true);
		}

		// Token: 0x06009F87 RID: 40839 RVA: 0x000E2AE2 File Offset: 0x000E0CE2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInertializationPose(Pointer, MemoryOwner);
		}

		// Token: 0x040057C5 RID: 22469
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InertializationPose";

		// Token: 0x040057C6 RID: 22470
		private static IntPtr _ScriptStructPtr;
	}
}
