using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000453 RID: 1107
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectTraceStaticMesh")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKuroInteractionEffectTraceStaticMesh : FKuroInteractionEffectNDCConfigBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006B05 RID: 27397 RVA: 0x0009BD59 File Offset: 0x00099F59
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInteractionEffectTraceStaticMesh._ScriptStructPtr != 0) ? FKuroInteractionEffectTraceStaticMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroInteractionEffectTraceStaticMesh", ref FKuroInteractionEffectTraceStaticMesh._ScriptStructPtr);
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x06006B06 RID: 27398 RVA: 0x0009BD7D File Offset: 0x00099F7D
		// (set) Token: 0x06006B07 RID: 27399 RVA: 0x0009BD9C File Offset: 0x00099F9C
		public TSoftObjectPtr<UStaticMesh> StaticMesh
		{
			get
			{
				return new TSoftObjectPtr<UStaticMesh>(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceStaticMesh.__PropertyOffset_StaticMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceStaticMesh.__PropertyOffset_StaticMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06006B08 RID: 27400 RVA: 0x0009BDC1 File Offset: 0x00099FC1
		public FKuroInteractionEffectTraceStaticMesh()
		{
		}

		// Token: 0x06006B09 RID: 27401 RVA: 0x0009BDC9 File Offset: 0x00099FC9
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInteractionEffectTraceStaticMesh.StaticStruct();
		}

		// Token: 0x06006B0A RID: 27402 RVA: 0x0009BDD5 File Offset: 0x00099FD5
		[NullableContext(2)]
		public FKuroInteractionEffectTraceStaticMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B0B RID: 27403 RVA: 0x0009BDDF File Offset: 0x00099FDF
		public FKuroInteractionEffectTraceStaticMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B0C RID: 27404 RVA: 0x0009BDEA File Offset: 0x00099FEA
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInteractionEffectTraceStaticMesh(Pointer, false, true);
		}

		// Token: 0x06006B0D RID: 27405 RVA: 0x0009BDF4 File Offset: 0x00099FF4
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInteractionEffectTraceStaticMesh(Pointer, MemoryOwner);
		}

		// Token: 0x04002D62 RID: 11618
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectTraceStaticMesh";

		// Token: 0x04002D63 RID: 11619
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D64 RID: 11620
		internal static int __PropertyOffset_StaticMesh;
	}
}
