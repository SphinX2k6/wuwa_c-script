using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000146 RID: 326
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.QualifiedFrameTime")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FQualifiedFrameTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060012D8 RID: 4824 RVA: 0x0001DC5A File Offset: 0x0001BE5A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQualifiedFrameTime._ScriptStructPtr != 0) ? FQualifiedFrameTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.QualifiedFrameTime", ref FQualifiedFrameTime._ScriptStructPtr);
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0001DC80 File Offset: 0x0001BE80
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0001DCC3 File Offset: 0x0001BEC3
		public FFrameTime Time
		{
			get
			{
				base.FastCheckIsValid();
				FFrameTime result;
				if ((result = this._Time) == null)
				{
					result = (this._Time = new FFrameTime(base.NativePtr + (IntPtr)FQualifiedFrameTime.__PropertyOffset_Time, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FQualifiedFrameTime.__PropertyOffset_Time, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x0001DCF8 File Offset: 0x0001BEF8
		public unsafe FFrameRate Rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualifiedFrameTime.__PropertyOffset_Rate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualifiedFrameTime.__PropertyOffset_Rate) = value;
			}
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x0001DD0D File Offset: 0x0001BF0D
		public FQualifiedFrameTime()
		{
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x0001DD15 File Offset: 0x0001BF15
		protected override IntPtr GetUStructPtr()
		{
			return FQualifiedFrameTime.StaticStruct();
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x0001DD21 File Offset: 0x0001BF21
		[NullableContext(2)]
		public FQualifiedFrameTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x0001DD2B File Offset: 0x0001BF2B
		public FQualifiedFrameTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x0001DD36 File Offset: 0x0001BF36
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQualifiedFrameTime(Pointer, false, true);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x0001DD40 File Offset: 0x0001BF40
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQualifiedFrameTime(Pointer, MemoryOwner);
		}

		// Token: 0x040005E4 RID: 1508
		public const string __ObjectPath = "/Script/CoreUObject.QualifiedFrameTime";

		// Token: 0x040005E5 RID: 1509
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040005E6 RID: 1510
		internal static int __PropertyOffset_Time;

		// Token: 0x040005E7 RID: 1511
		[Nullable(2)]
		private FFrameTime _Time;

		// Token: 0x040005E8 RID: 1512
		internal static int __PropertyOffset_Rate;
	}
}
