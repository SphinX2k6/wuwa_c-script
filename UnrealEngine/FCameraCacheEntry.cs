using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200090A RID: 2314
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraCacheEntry")]
	[UnrealStructLayout(2752, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2752)]
	public class FCameraCacheEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007F05 RID: 32517 RVA: 0x000B6362 File Offset: 0x000B4562
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraCacheEntry._ScriptStructPtr != 0) ? FCameraCacheEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CameraCacheEntry", ref FCameraCacheEntry._ScriptStructPtr);
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x06007F06 RID: 32518 RVA: 0x000B6386 File Offset: 0x000B4586
		// (set) Token: 0x06007F07 RID: 32519 RVA: 0x000B6396 File Offset: 0x000B4596
		public unsafe float TimeStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraCacheEntry.__PropertyOffset_TimeStamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraCacheEntry.__PropertyOffset_TimeStamp) = value;
			}
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x06007F08 RID: 32520 RVA: 0x000B63A8 File Offset: 0x000B45A8
		// (set) Token: 0x06007F09 RID: 32521 RVA: 0x000B63EB File Offset: 0x000B45EB
		public FMinimalViewInfo POV
		{
			get
			{
				base.FastCheckIsValid();
				FMinimalViewInfo result;
				if ((result = this._POV) == null)
				{
					result = (this._POV = new FMinimalViewInfo(base.NativePtr + (IntPtr)FCameraCacheEntry.__PropertyOffset_POV, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMinimalViewInfo.StaticStruct(), base.NativePtr + (IntPtr)FCameraCacheEntry.__PropertyOffset_POV, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06007F0A RID: 32522 RVA: 0x000B640C File Offset: 0x000B460C
		public FCameraCacheEntry()
		{
		}

		// Token: 0x06007F0B RID: 32523 RVA: 0x000B6414 File Offset: 0x000B4614
		public FCameraCacheEntry(float TimeStamp, FMinimalViewInfo POV)
		{
			this.TimeStamp = TimeStamp;
			this.POV = POV;
		}

		// Token: 0x06007F0C RID: 32524 RVA: 0x000B642A File Offset: 0x000B462A
		protected override IntPtr GetUStructPtr()
		{
			return FCameraCacheEntry.StaticStruct();
		}

		// Token: 0x06007F0D RID: 32525 RVA: 0x000B6436 File Offset: 0x000B4636
		[NullableContext(2)]
		public FCameraCacheEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007F0E RID: 32526 RVA: 0x000B6440 File Offset: 0x000B4640
		public FCameraCacheEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007F0F RID: 32527 RVA: 0x000B644B File Offset: 0x000B464B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraCacheEntry(Pointer, false, true);
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x000B6455 File Offset: 0x000B4655
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraCacheEntry(Pointer, MemoryOwner);
		}

		// Token: 0x04003CF3 RID: 15603
		public const string __ObjectPath = "/Script/Engine.CameraCacheEntry";

		// Token: 0x04003CF4 RID: 15604
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CF5 RID: 15605
		internal static int __PropertyOffset_TimeStamp;

		// Token: 0x04003CF6 RID: 15606
		internal static int __PropertyOffset_POV;

		// Token: 0x04003CF7 RID: 15607
		[Nullable(2)]
		private FMinimalViewInfo _POV;
	}
}
