using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200072B RID: 1835
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.FrameTime")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FFrameTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060061F5 RID: 25077 RVA: 0x0008C73C File Offset: 0x0008A93C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameTime._ScriptStructPtr != 0) ? FFrameTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameTime", ref FFrameTime._ScriptStructPtr);
		}

		// Token: 0x17001783 RID: 6019
		// (get) Token: 0x060061F6 RID: 25078 RVA: 0x0008C760 File Offset: 0x0008A960
		// (set) Token: 0x060061F7 RID: 25079 RVA: 0x0008C7A3 File Offset: 0x0008A9A3
		public FFrameNumber FrameNumber
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._FrameNumber) == null)
				{
					result = (this._FrameNumber = new FFrameNumber(base.NativePtr + (IntPtr)FFrameTime.__PropertyOffset_FrameNumber, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FFrameTime.__PropertyOffset_FrameNumber, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001784 RID: 6020
		// (get) Token: 0x060061F8 RID: 25080 RVA: 0x0008C7C4 File Offset: 0x0008A9C4
		// (set) Token: 0x060061F9 RID: 25081 RVA: 0x0008C7D4 File Offset: 0x0008A9D4
		public unsafe float SubFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameTime.__PropertyOffset_SubFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameTime.__PropertyOffset_SubFrame) = value;
			}
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x0008C7E5 File Offset: 0x0008A9E5
		public FFrameTime()
		{
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x0008C7ED File Offset: 0x0008A9ED
		public FFrameTime(FFrameNumber FrameNumber, float SubFrame)
		{
			this.FrameNumber = FrameNumber;
			this.SubFrame = SubFrame;
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x0008C803 File Offset: 0x0008AA03
		protected override IntPtr GetUStructPtr()
		{
			return FFrameTime.StaticStruct();
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x0008C80F File Offset: 0x0008AA0F
		[NullableContext(2)]
		public FFrameTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x0008C819 File Offset: 0x0008AA19
		public FFrameTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x0008C824 File Offset: 0x0008AA24
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameTime(Pointer, false, true);
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x0008C82E File Offset: 0x0008AA2E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameTime(Pointer, MemoryOwner);
		}

		// Token: 0x04002EC4 RID: 11972
		public const string __ObjectPath = "/Script/CoreUObject.FrameTime";

		// Token: 0x04002EC5 RID: 11973
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002EC6 RID: 11974
		internal static int __PropertyOffset_FrameNumber;

		// Token: 0x04002EC7 RID: 11975
		[Nullable(2)]
		private FFrameNumber _FrameNumber;

		// Token: 0x04002EC8 RID: 11976
		internal static int __PropertyOffset_SubFrame;
	}
}
