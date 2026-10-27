using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BF0 RID: 3056
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FormatArgumentData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FFormatArgumentData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060096C2 RID: 38594 RVA: 0x000D7110 File Offset: 0x000D5310
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFormatArgumentData._ScriptStructPtr != 0) ? FFormatArgumentData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FormatArgumentData", ref FFormatArgumentData._ScriptStructPtr);
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x060096C3 RID: 38595 RVA: 0x000D7134 File Offset: 0x000D5334
		// (set) Token: 0x060096C4 RID: 38596 RVA: 0x000D7148 File Offset: 0x000D5348
		public unsafe string ArgumentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentName)), value);
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x060096C5 RID: 38597 RVA: 0x000D715D File Offset: 0x000D535D
		// (set) Token: 0x060096C6 RID: 38598 RVA: 0x000D7171 File Offset: 0x000D5371
		[Nullable(0)]
		public unsafe TEnumAsByte<EFormatArgumentType> ArgumentValueType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueType) = value;
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x060096C7 RID: 38599 RVA: 0x000D7188 File Offset: 0x000D5388
		// (set) Token: 0x060096C8 RID: 38600 RVA: 0x000D71CB File Offset: 0x000D53CB
		public unsafe FText ArgumentValue
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._ArgumentValue) == null)
				{
					result = (this._ArgumentValue = new FText(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValue)), value.NativePtr, 1);
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x060096C9 RID: 38601 RVA: 0x000D71E6 File Offset: 0x000D53E6
		// (set) Token: 0x060096CA RID: 38602 RVA: 0x000D71F6 File Offset: 0x000D53F6
		public unsafe int ArgumentValueInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueInt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueInt) = value;
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x060096CB RID: 38603 RVA: 0x000D7207 File Offset: 0x000D5407
		// (set) Token: 0x060096CC RID: 38604 RVA: 0x000D7217 File Offset: 0x000D5417
		public unsafe float ArgumentValueFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueFloat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueFloat) = value;
			}
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x060096CD RID: 38605 RVA: 0x000D7228 File Offset: 0x000D5428
		// (set) Token: 0x060096CE RID: 38606 RVA: 0x000D7238 File Offset: 0x000D5438
		public unsafe ETextGender ArgumentValueGender
		{
			get
			{
				return (ETextGender)(*(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueGender));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFormatArgumentData.__PropertyOffset_ArgumentValueGender) = (byte)value;
			}
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x000D7249 File Offset: 0x000D5449
		public FFormatArgumentData()
		{
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x000D7251 File Offset: 0x000D5451
		public FFormatArgumentData(string ArgumentName, [Nullable(0)] TEnumAsByte<EFormatArgumentType> ArgumentValueType, FText ArgumentValue, int ArgumentValueInt, float ArgumentValueFloat, ETextGender ArgumentValueGender)
		{
			this.ArgumentName = ArgumentName;
			this.ArgumentValueType = ArgumentValueType;
			this.ArgumentValue = ArgumentValue;
			this.ArgumentValueInt = ArgumentValueInt;
			this.ArgumentValueFloat = ArgumentValueFloat;
			this.ArgumentValueGender = ArgumentValueGender;
		}

		// Token: 0x060096D1 RID: 38609 RVA: 0x000D7286 File Offset: 0x000D5486
		protected override IntPtr GetUStructPtr()
		{
			return FFormatArgumentData.StaticStruct();
		}

		// Token: 0x060096D2 RID: 38610 RVA: 0x000D7292 File Offset: 0x000D5492
		[NullableContext(2)]
		public FFormatArgumentData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060096D3 RID: 38611 RVA: 0x000D729C File Offset: 0x000D549C
		public FFormatArgumentData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060096D4 RID: 38612 RVA: 0x000D72A7 File Offset: 0x000D54A7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFormatArgumentData(Pointer, false, true);
		}

		// Token: 0x060096D5 RID: 38613 RVA: 0x000D72B1 File Offset: 0x000D54B1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFormatArgumentData(Pointer, MemoryOwner);
		}

		// Token: 0x04005493 RID: 21651
		public const string __ObjectPath = "/Script/Engine.FormatArgumentData";

		// Token: 0x04005494 RID: 21652
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005495 RID: 21653
		internal static int __PropertyOffset_ArgumentName;

		// Token: 0x04005496 RID: 21654
		internal static int __PropertyOffset_ArgumentValueType;

		// Token: 0x04005497 RID: 21655
		internal static int __PropertyOffset_ArgumentValue;

		// Token: 0x04005498 RID: 21656
		[Nullable(2)]
		private FText _ArgumentValue;

		// Token: 0x04005499 RID: 21657
		internal static int __PropertyOffset_ArgumentValueInt;

		// Token: 0x0400549A RID: 21658
		internal static int __PropertyOffset_ArgumentValueFloat;

		// Token: 0x0400549B RID: 21659
		internal static int __PropertyOffset_ArgumentValueGender;
	}
}
