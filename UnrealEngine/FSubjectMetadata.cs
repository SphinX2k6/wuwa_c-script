using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002235 RID: 8757
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.SubjectMetadata")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FSubjectMetadata : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602154A RID: 136522 RVA: 0x00311E21 File Offset: 0x00310021
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubjectMetadata._ScriptStructPtr != 0) ? FSubjectMetadata._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.SubjectMetadata", ref FSubjectMetadata._ScriptStructPtr);
		}

		// Token: 0x1700820D RID: 33293
		// (get) Token: 0x0602154B RID: 136523 RVA: 0x00311E48 File Offset: 0x00310048
		// (set) Token: 0x0602154C RID: 136524 RVA: 0x00311E8B File Offset: 0x0031008B
		public TMap<FName, string> StringMetadata
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, string> result;
				if ((result = this._StringMetadata) == null)
				{
					result = (this._StringMetadata = new TMap<FName, string>(base.NativePtr + (IntPtr)FSubjectMetadata.__PropertyOffset_StringMetadata, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StringMetadata.CopyAssign(value);
			}
		}

		// Token: 0x1700820E RID: 33294
		// (get) Token: 0x0602154D RID: 136525 RVA: 0x00311E99 File Offset: 0x00310099
		// (set) Token: 0x0602154E RID: 136526 RVA: 0x00311EAD File Offset: 0x003100AD
		public unsafe FTimecode SceneTimecode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubjectMetadata.__PropertyOffset_SceneTimecode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubjectMetadata.__PropertyOffset_SceneTimecode) = value;
			}
		}

		// Token: 0x1700820F RID: 33295
		// (get) Token: 0x0602154F RID: 136527 RVA: 0x00311EC2 File Offset: 0x003100C2
		// (set) Token: 0x06021550 RID: 136528 RVA: 0x00311ED6 File Offset: 0x003100D6
		public unsafe FFrameRate SceneFramerate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubjectMetadata.__PropertyOffset_SceneFramerate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubjectMetadata.__PropertyOffset_SceneFramerate) = value;
			}
		}

		// Token: 0x06021551 RID: 136529 RVA: 0x00311EEB File Offset: 0x003100EB
		public FSubjectMetadata()
		{
		}

		// Token: 0x06021552 RID: 136530 RVA: 0x00311EF3 File Offset: 0x003100F3
		public FSubjectMetadata(TMap<FName, string> StringMetadata, FTimecode SceneTimecode, FFrameRate SceneFramerate)
		{
			this.StringMetadata = StringMetadata;
			this.SceneTimecode = SceneTimecode;
			this.SceneFramerate = SceneFramerate;
		}

		// Token: 0x06021553 RID: 136531 RVA: 0x00311F10 File Offset: 0x00310110
		protected override IntPtr GetUStructPtr()
		{
			return FSubjectMetadata.StaticStruct();
		}

		// Token: 0x06021554 RID: 136532 RVA: 0x00311F1C File Offset: 0x0031011C
		[NullableContext(2)]
		public FSubjectMetadata(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021555 RID: 136533 RVA: 0x00311F26 File Offset: 0x00310126
		public FSubjectMetadata(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021556 RID: 136534 RVA: 0x00311F31 File Offset: 0x00310131
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubjectMetadata(Pointer, false, true);
		}

		// Token: 0x06021557 RID: 136535 RVA: 0x00311F3B File Offset: 0x0031013B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubjectMetadata(Pointer, MemoryOwner);
		}

		// Token: 0x04011C54 RID: 72788
		public const string __ObjectPath = "/Script/LiveLinkInterface.SubjectMetadata";

		// Token: 0x04011C55 RID: 72789
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C56 RID: 72790
		internal static int __PropertyOffset_StringMetadata;

		// Token: 0x04011C57 RID: 72791
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, string> _StringMetadata;

		// Token: 0x04011C58 RID: 72792
		internal static int __PropertyOffset_SceneTimecode;

		// Token: 0x04011C59 RID: 72793
		internal static int __PropertyOffset_SceneFramerate;
	}
}
