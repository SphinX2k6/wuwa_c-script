using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000111 RID: 273
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.FrameTime")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FFrameTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001159 RID: 4441 RVA: 0x0001B7A4 File Offset: 0x000199A4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameTime._ScriptStructPtr != 0) ? FFrameTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameTime", ref FFrameTime._ScriptStructPtr);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0001B7C8 File Offset: 0x000199C8
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x0001B80B File Offset: 0x00019A0B
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

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x0001B82C File Offset: 0x00019A2C
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x0001B83C File Offset: 0x00019A3C
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

		// Token: 0x0600115E RID: 4446 RVA: 0x0001B84D File Offset: 0x00019A4D
		public FFrameTime()
		{
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0001B855 File Offset: 0x00019A55
		protected override IntPtr GetUStructPtr()
		{
			return FFrameTime.StaticStruct();
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0001B861 File Offset: 0x00019A61
		[NullableContext(2)]
		public FFrameTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0001B86B File Offset: 0x00019A6B
		public FFrameTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0001B876 File Offset: 0x00019A76
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameTime(Pointer, false, true);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0001B880 File Offset: 0x00019A80
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameTime(Pointer, MemoryOwner);
		}

		// Token: 0x040004FA RID: 1274
		public const string __ObjectPath = "/Script/CoreUObject.FrameTime";

		// Token: 0x040004FB RID: 1275
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040004FC RID: 1276
		internal static int __PropertyOffset_FrameNumber;

		// Token: 0x040004FD RID: 1277
		[Nullable(2)]
		private FFrameNumber _FrameNumber;

		// Token: 0x040004FE RID: 1278
		internal static int __PropertyOffset_SubFrame;
	}
}
