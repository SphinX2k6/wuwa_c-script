using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000EC0 RID: 3776
	[UnrealObjectPath("/Script/Engine.MovementProperties")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FMovementProperties : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CC73 RID: 52339 RVA: 0x00129E99 File Offset: 0x00128099
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovementProperties._ScriptStructPtr != 0) ? FMovementProperties._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MovementProperties", ref FMovementProperties._ScriptStructPtr);
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x0600CC74 RID: 52340 RVA: 0x00129EBD File Offset: 0x001280BD
		// (set) Token: 0x0600CC75 RID: 52341 RVA: 0x00129ED6 File Offset: 0x001280D6
		public unsafe bool bCanCrouch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanCrouch) & FMovementProperties.__PropertyMask_bCanCrouch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanCrouch) = ((*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanCrouch) & ~FMovementProperties.__PropertyMask_bCanCrouch) | (value ? FMovementProperties.__PropertyMask_bCanCrouch : 0));
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0600CC76 RID: 52342 RVA: 0x00129F06 File Offset: 0x00128106
		// (set) Token: 0x0600CC77 RID: 52343 RVA: 0x00129F1F File Offset: 0x0012811F
		public unsafe bool bCanJump
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanJump) & FMovementProperties.__PropertyMask_bCanJump) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanJump) = ((*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanJump) & ~FMovementProperties.__PropertyMask_bCanJump) | (value ? FMovementProperties.__PropertyMask_bCanJump : 0));
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0600CC78 RID: 52344 RVA: 0x00129F4F File Offset: 0x0012814F
		// (set) Token: 0x0600CC79 RID: 52345 RVA: 0x00129F68 File Offset: 0x00128168
		public unsafe bool bCanWalk
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanWalk) & FMovementProperties.__PropertyMask_bCanWalk) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanWalk) = ((*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanWalk) & ~FMovementProperties.__PropertyMask_bCanWalk) | (value ? FMovementProperties.__PropertyMask_bCanWalk : 0));
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x0600CC7A RID: 52346 RVA: 0x00129F98 File Offset: 0x00128198
		// (set) Token: 0x0600CC7B RID: 52347 RVA: 0x00129FB1 File Offset: 0x001281B1
		public unsafe bool bCanSwim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanSwim) & FMovementProperties.__PropertyMask_bCanSwim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanSwim) = ((*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanSwim) & ~FMovementProperties.__PropertyMask_bCanSwim) | (value ? FMovementProperties.__PropertyMask_bCanSwim : 0));
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x0600CC7C RID: 52348 RVA: 0x00129FE1 File Offset: 0x001281E1
		// (set) Token: 0x0600CC7D RID: 52349 RVA: 0x00129FFA File Offset: 0x001281FA
		public unsafe bool bCanFly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanFly) & FMovementProperties.__PropertyMask_bCanFly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanFly) = ((*(base.NativePtr + (IntPtr)FMovementProperties.__PropertyOffset_bCanFly) & ~FMovementProperties.__PropertyMask_bCanFly) | (value ? FMovementProperties.__PropertyMask_bCanFly : 0));
			}
		}

		// Token: 0x0600CC7E RID: 52350 RVA: 0x0012A02A File Offset: 0x0012822A
		public FMovementProperties()
		{
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x0012A032 File Offset: 0x00128232
		public FMovementProperties(bool bCanCrouch, bool bCanJump, bool bCanWalk, bool bCanSwim, bool bCanFly)
		{
			this.bCanCrouch = bCanCrouch;
			this.bCanJump = bCanJump;
			this.bCanWalk = bCanWalk;
			this.bCanSwim = bCanSwim;
			this.bCanFly = bCanFly;
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x0012A05F File Offset: 0x0012825F
		protected override IntPtr GetUStructPtr()
		{
			return FMovementProperties.StaticStruct();
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x0012A06B File Offset: 0x0012826B
		[NullableContext(2)]
		public FMovementProperties(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CC82 RID: 52354 RVA: 0x0012A075 File Offset: 0x00128275
		public FMovementProperties(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CC83 RID: 52355 RVA: 0x0012A080 File Offset: 0x00128280
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovementProperties(Pointer, false, true);
		}

		// Token: 0x0600CC84 RID: 52356 RVA: 0x0012A08A File Offset: 0x0012828A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovementProperties(Pointer, MemoryOwner);
		}

		// Token: 0x04006E19 RID: 28185
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MovementProperties";

		// Token: 0x04006E1A RID: 28186
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E1B RID: 28187
		internal static int __PropertyOffset_bCanCrouch;

		// Token: 0x04006E1C RID: 28188
		internal static byte __PropertyMask_bCanCrouch;

		// Token: 0x04006E1D RID: 28189
		internal static int __PropertyOffset_bCanJump;

		// Token: 0x04006E1E RID: 28190
		internal static byte __PropertyMask_bCanJump;

		// Token: 0x04006E1F RID: 28191
		internal static int __PropertyOffset_bCanWalk;

		// Token: 0x04006E20 RID: 28192
		internal static byte __PropertyMask_bCanWalk;

		// Token: 0x04006E21 RID: 28193
		internal static int __PropertyOffset_bCanSwim;

		// Token: 0x04006E22 RID: 28194
		internal static byte __PropertyMask_bCanSwim;

		// Token: 0x04006E23 RID: 28195
		internal static int __PropertyOffset_bCanFly;

		// Token: 0x04006E24 RID: 28196
		internal static byte __PropertyMask_bCanFly;
	}
}
