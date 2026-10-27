using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000760 RID: 1888
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.QualifiedFrameTime")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FQualifiedFrameTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600637F RID: 25471 RVA: 0x0008ED52 File Offset: 0x0008CF52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQualifiedFrameTime._ScriptStructPtr != 0) ? FQualifiedFrameTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.QualifiedFrameTime", ref FQualifiedFrameTime._ScriptStructPtr);
		}

		// Token: 0x170017AA RID: 6058
		// (get) Token: 0x06006380 RID: 25472 RVA: 0x0008ED78 File Offset: 0x0008CF78
		// (set) Token: 0x06006381 RID: 25473 RVA: 0x0008EDBB File Offset: 0x0008CFBB
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

		// Token: 0x170017AB RID: 6059
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x0008EDDC File Offset: 0x0008CFDC
		// (set) Token: 0x06006383 RID: 25475 RVA: 0x0008EDF0 File Offset: 0x0008CFF0
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

		// Token: 0x06006384 RID: 25476 RVA: 0x0008EE05 File Offset: 0x0008D005
		public FQualifiedFrameTime()
		{
		}

		// Token: 0x06006385 RID: 25477 RVA: 0x0008EE0D File Offset: 0x0008D00D
		public FQualifiedFrameTime(FFrameTime Time, FFrameRate Rate)
		{
			this.Time = Time;
			this.Rate = Rate;
		}

		// Token: 0x06006386 RID: 25478 RVA: 0x0008EE23 File Offset: 0x0008D023
		protected override IntPtr GetUStructPtr()
		{
			return FQualifiedFrameTime.StaticStruct();
		}

		// Token: 0x06006387 RID: 25479 RVA: 0x0008EE2F File Offset: 0x0008D02F
		[NullableContext(2)]
		public FQualifiedFrameTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006388 RID: 25480 RVA: 0x0008EE39 File Offset: 0x0008D039
		public FQualifiedFrameTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006389 RID: 25481 RVA: 0x0008EE44 File Offset: 0x0008D044
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQualifiedFrameTime(Pointer, false, true);
		}

		// Token: 0x0600638A RID: 25482 RVA: 0x0008EE4E File Offset: 0x0008D04E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQualifiedFrameTime(Pointer, MemoryOwner);
		}

		// Token: 0x04002FAE RID: 12206
		public const string __ObjectPath = "/Script/CoreUObject.QualifiedFrameTime";

		// Token: 0x04002FAF RID: 12207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002FB0 RID: 12208
		internal static int __PropertyOffset_Time;

		// Token: 0x04002FB1 RID: 12209
		[Nullable(2)]
		private FFrameTime _Time;

		// Token: 0x04002FB2 RID: 12210
		internal static int __PropertyOffset_Rate;
	}
}
