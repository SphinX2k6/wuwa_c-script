using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005AE RID: 1454
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FramesToSeconds")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_FramesToSeconds : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E5B RID: 20059 RVA: 0x00073CE5 File Offset: 0x00071EE5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FramesToSeconds._ScriptStructPtr != 0) ? FRigUnit_FramesToSeconds._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FramesToSeconds", ref FRigUnit_FramesToSeconds._ScriptStructPtr);
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06004E5C RID: 20060 RVA: 0x00073D09 File Offset: 0x00071F09
		// (set) Token: 0x06004E5D RID: 20061 RVA: 0x00073D19 File Offset: 0x00071F19
		public unsafe float Frames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FramesToSeconds.__PropertyOffset_Frames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FramesToSeconds.__PropertyOffset_Frames) = value;
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06004E5E RID: 20062 RVA: 0x00073D2A File Offset: 0x00071F2A
		// (set) Token: 0x06004E5F RID: 20063 RVA: 0x00073D3A File Offset: 0x00071F3A
		public unsafe float Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FramesToSeconds.__PropertyOffset_Seconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FramesToSeconds.__PropertyOffset_Seconds) = value;
			}
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x00073D4B File Offset: 0x00071F4B
		public FRigUnit_FramesToSeconds()
		{
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x00073D53 File Offset: 0x00071F53
		public FRigUnit_FramesToSeconds(float Frames, float Seconds)
		{
			this.Frames = Frames;
			this.Seconds = Seconds;
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00073D69 File Offset: 0x00071F69
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FramesToSeconds.StaticStruct();
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x00073D75 File Offset: 0x00071F75
		[NullableContext(2)]
		public FRigUnit_FramesToSeconds(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x00073D7F File Offset: 0x00071F7F
		public FRigUnit_FramesToSeconds(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x00073D8A File Offset: 0x00071F8A
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FramesToSeconds(Pointer, false, true);
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x00073D94 File Offset: 0x00071F94
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FramesToSeconds(Pointer, MemoryOwner);
		}

		// Token: 0x040025DF RID: 9695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_FramesToSeconds";

		// Token: 0x040025E0 RID: 9696
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025E1 RID: 9697
		internal static int __PropertyOffset_Frames;

		// Token: 0x040025E2 RID: 9698
		internal static int __PropertyOffset_Seconds;
	}
}
