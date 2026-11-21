using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010E RID: 270
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.FrameNumberRange")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFrameNumberRange : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600113C RID: 4412 RVA: 0x0001B4E1 File Offset: 0x000196E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameNumberRange._ScriptStructPtr != 0) ? FFrameNumberRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameNumberRange", ref FFrameNumberRange._ScriptStructPtr);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0001B508 File Offset: 0x00019708
		// (set) Token: 0x0600113E RID: 4414 RVA: 0x0001B54B File Offset: 0x0001974B
		public FFrameNumberRangeBound LowerBound
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumberRangeBound result;
				if ((result = this._LowerBound) == null)
				{
					result = (this._LowerBound = new FFrameNumberRangeBound(base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_LowerBound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumberRangeBound.StaticStruct(), base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_LowerBound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0001B56C File Offset: 0x0001976C
		// (set) Token: 0x06001140 RID: 4416 RVA: 0x0001B5AF File Offset: 0x000197AF
		public FFrameNumberRangeBound UpperBound
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumberRangeBound result;
				if ((result = this._UpperBound) == null)
				{
					result = (this._UpperBound = new FFrameNumberRangeBound(base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_UpperBound, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumberRangeBound.StaticStruct(), base.NativePtr + (IntPtr)FFrameNumberRange.__PropertyOffset_UpperBound, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x0001B5D0 File Offset: 0x000197D0
		public FFrameNumberRange()
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x0001B5D8 File Offset: 0x000197D8
		protected override IntPtr GetUStructPtr()
		{
			return FFrameNumberRange.StaticStruct();
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x0001B5E4 File Offset: 0x000197E4
		[NullableContext(2)]
		public FFrameNumberRange(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x0001B5EE File Offset: 0x000197EE
		public FFrameNumberRange(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0001B5F9 File Offset: 0x000197F9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameNumberRange(Pointer, false, true);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0001B603 File Offset: 0x00019803
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameNumberRange(Pointer, MemoryOwner);
		}

		// Token: 0x040004EB RID: 1259
		public const string __ObjectPath = "/Script/CoreUObject.FrameNumberRange";

		// Token: 0x040004EC RID: 1260
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040004ED RID: 1261
		internal static int __PropertyOffset_LowerBound;

		// Token: 0x040004EE RID: 1262
		[Nullable(2)]
		private FFrameNumberRangeBound _LowerBound;

		// Token: 0x040004EF RID: 1263
		internal static int __PropertyOffset_UpperBound;

		// Token: 0x040004F0 RID: 1264
		[Nullable(2)]
		private FFrameNumberRangeBound _UpperBound;
	}
}
