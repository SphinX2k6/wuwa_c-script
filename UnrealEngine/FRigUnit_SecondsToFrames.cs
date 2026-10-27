using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006AF RID: 1711
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SecondsToFrames")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRigUnit_SecondsToFrames : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B3F RID: 23359 RVA: 0x0008300C File Offset: 0x0008120C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SecondsToFrames._ScriptStructPtr != 0) ? FRigUnit_SecondsToFrames._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SecondsToFrames", ref FRigUnit_SecondsToFrames._ScriptStructPtr);
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06005B40 RID: 23360 RVA: 0x00083030 File Offset: 0x00081230
		// (set) Token: 0x06005B41 RID: 23361 RVA: 0x00083040 File Offset: 0x00081240
		public unsafe float Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SecondsToFrames.__PropertyOffset_Seconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SecondsToFrames.__PropertyOffset_Seconds) = value;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06005B42 RID: 23362 RVA: 0x00083051 File Offset: 0x00081251
		// (set) Token: 0x06005B43 RID: 23363 RVA: 0x00083061 File Offset: 0x00081261
		public unsafe float Frames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SecondsToFrames.__PropertyOffset_Frames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SecondsToFrames.__PropertyOffset_Frames) = value;
			}
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x00083072 File Offset: 0x00081272
		public FRigUnit_SecondsToFrames()
		{
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x0008307A File Offset: 0x0008127A
		public FRigUnit_SecondsToFrames(float Seconds, float Frames)
		{
			this.Seconds = Seconds;
			this.Frames = Frames;
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x00083090 File Offset: 0x00081290
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SecondsToFrames.StaticStruct();
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x0008309C File Offset: 0x0008129C
		[NullableContext(2)]
		public FRigUnit_SecondsToFrames(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x000830A6 File Offset: 0x000812A6
		public FRigUnit_SecondsToFrames(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x000830B1 File Offset: 0x000812B1
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SecondsToFrames(Pointer, false, true);
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x000830BB File Offset: 0x000812BB
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SecondsToFrames(Pointer, MemoryOwner);
		}

		// Token: 0x04002AB9 RID: 10937
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SecondsToFrames";

		// Token: 0x04002ABA RID: 10938
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002ABB RID: 10939
		internal static int __PropertyOffset_Seconds;

		// Token: 0x04002ABC RID: 10940
		internal static int __PropertyOffset_Frames;
	}
}
