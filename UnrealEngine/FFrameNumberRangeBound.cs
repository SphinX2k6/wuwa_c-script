using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010F RID: 271
	[UnrealObjectPath("/Script/CoreUObject.FrameNumberRangeBound")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FFrameNumberRangeBound : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001147 RID: 4423 RVA: 0x0001B60C File Offset: 0x0001980C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameNumberRangeBound._ScriptStructPtr != 0) ? FFrameNumberRangeBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FrameNumberRangeBound", ref FFrameNumberRangeBound._ScriptStructPtr);
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0001B630 File Offset: 0x00019830
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x0001B644 File Offset: 0x00019844
		public unsafe TEnumAsByte<ERangeBoundTypes> Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0001B65C File Offset: 0x0001985C
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x0001B69F File Offset: 0x0001989F
		[Nullable(1)]
		public FFrameNumber Value
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FFrameNumber(base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FFrameNumberRangeBound.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0001B6C0 File Offset: 0x000198C0
		public FFrameNumberRangeBound()
		{
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0001B6C8 File Offset: 0x000198C8
		protected override IntPtr GetUStructPtr()
		{
			return FFrameNumberRangeBound.StaticStruct();
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0001B6D4 File Offset: 0x000198D4
		[NullableContext(2)]
		public FFrameNumberRangeBound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0001B6DE File Offset: 0x000198DE
		public FFrameNumberRangeBound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0001B6E9 File Offset: 0x000198E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameNumberRangeBound(Pointer, false, true);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0001B6F3 File Offset: 0x000198F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameNumberRangeBound(Pointer, MemoryOwner);
		}

		// Token: 0x040004F1 RID: 1265
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.FrameNumberRangeBound";

		// Token: 0x040004F2 RID: 1266
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040004F3 RID: 1267
		internal static int __PropertyOffset_Type;

		// Token: 0x040004F4 RID: 1268
		internal static int __PropertyOffset_Value;

		// Token: 0x040004F5 RID: 1269
		[Nullable(2)]
		private FFrameNumber _Value;
	}
}
