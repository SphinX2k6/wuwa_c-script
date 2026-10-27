using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001077 RID: 4215
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ReferencePose")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FReferencePose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EFD9 RID: 61401 RVA: 0x0016395B File Offset: 0x00161B5B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FReferencePose._ScriptStructPtr != 0) ? FReferencePose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ReferencePose", ref FReferencePose._ScriptStructPtr);
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0600EFDA RID: 61402 RVA: 0x0016397F File Offset: 0x00161B7F
		// (set) Token: 0x0600EFDB RID: 61403 RVA: 0x00163993 File Offset: 0x00161B93
		public unsafe FName PoseName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FReferencePose.__PropertyOffset_PoseName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FReferencePose.__PropertyOffset_PoseName) = value;
			}
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0600EFDC RID: 61404 RVA: 0x001639A8 File Offset: 0x00161BA8
		// (set) Token: 0x0600EFDD RID: 61405 RVA: 0x001639EB File Offset: 0x00161BEB
		public TArray<FTransform> ReferencePose
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._ReferencePose) == null)
				{
					result = (this._ReferencePose = new TArray<FTransform>(base.NativePtr + (IntPtr)FReferencePose.__PropertyOffset_ReferencePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReferencePose.CopyAssign(value);
			}
		}

		// Token: 0x0600EFDE RID: 61406 RVA: 0x001639F9 File Offset: 0x00161BF9
		public FReferencePose()
		{
		}

		// Token: 0x0600EFDF RID: 61407 RVA: 0x00163A01 File Offset: 0x00161C01
		public FReferencePose(FName PoseName, TArray<FTransform> ReferencePose, TSoftObjectPtr<USkeletalMesh> SourceReferenceMesh)
		{
			this.PoseName = PoseName;
			this.ReferencePose = ReferencePose;
		}

		// Token: 0x0600EFE0 RID: 61408 RVA: 0x00163A17 File Offset: 0x00161C17
		protected override IntPtr GetUStructPtr()
		{
			return FReferencePose.StaticStruct();
		}

		// Token: 0x0600EFE1 RID: 61409 RVA: 0x00163A23 File Offset: 0x00161C23
		[NullableContext(2)]
		public FReferencePose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EFE2 RID: 61410 RVA: 0x00163A2D File Offset: 0x00161C2D
		public FReferencePose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EFE3 RID: 61411 RVA: 0x00163A38 File Offset: 0x00161C38
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FReferencePose(Pointer, false, true);
		}

		// Token: 0x0600EFE4 RID: 61412 RVA: 0x00163A42 File Offset: 0x00161C42
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FReferencePose(Pointer, MemoryOwner);
		}

		// Token: 0x040081BB RID: 33211
		public const string __ObjectPath = "/Script/Engine.ReferencePose";

		// Token: 0x040081BC RID: 33212
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040081BD RID: 33213
		internal static int __PropertyOffset_PoseName;

		// Token: 0x040081BE RID: 33214
		internal static int __PropertyOffset_ReferencePose;

		// Token: 0x040081BF RID: 33215
		[Nullable(2)]
		private TArray<FTransform> _ReferencePose;
	}
}
