using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BE8 RID: 3048
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FontParameterValue")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FFontParameterValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009643 RID: 38467 RVA: 0x000D64C0 File Offset: 0x000D46C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFontParameterValue._ScriptStructPtr != 0) ? FFontParameterValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FontParameterValue", ref FFontParameterValue._ScriptStructPtr);
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x06009644 RID: 38468 RVA: 0x000D64E4 File Offset: 0x000D46E4
		// (set) Token: 0x06009645 RID: 38469 RVA: 0x000D6527 File Offset: 0x000D4727
		public FMaterialParameterInfo ParameterInfo
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialParameterInfo result;
				if ((result = this._ParameterInfo) == null)
				{
					result = (this._ParameterInfo = new FMaterialParameterInfo(base.NativePtr + (IntPtr)FFontParameterValue.__PropertyOffset_ParameterInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialParameterInfo.StaticStruct(), base.NativePtr + (IntPtr)FFontParameterValue.__PropertyOffset_ParameterInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700240D RID: 9229
		// (get) Token: 0x06009646 RID: 38470 RVA: 0x000D6548 File Offset: 0x000D4748
		// (set) Token: 0x06009647 RID: 38471 RVA: 0x000D655C File Offset: 0x000D475C
		[Nullable(2)]
		public unsafe UFont FontValue
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + FFontParameterValue.__PropertyOffset_FontValue);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFontParameterValue.__PropertyOffset_FontValue, value);
			}
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x06009648 RID: 38472 RVA: 0x000D6571 File Offset: 0x000D4771
		// (set) Token: 0x06009649 RID: 38473 RVA: 0x000D6581 File Offset: 0x000D4781
		public unsafe int FontPage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontParameterValue.__PropertyOffset_FontPage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontParameterValue.__PropertyOffset_FontPage) = value;
			}
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x0600964A RID: 38474 RVA: 0x000D6592 File Offset: 0x000D4792
		// (set) Token: 0x0600964B RID: 38475 RVA: 0x000D65A6 File Offset: 0x000D47A6
		public unsafe FGuid ExpressionGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFontParameterValue.__PropertyOffset_ExpressionGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFontParameterValue.__PropertyOffset_ExpressionGUID) = value;
			}
		}

		// Token: 0x0600964C RID: 38476 RVA: 0x000D65BB File Offset: 0x000D47BB
		public FFontParameterValue()
		{
		}

		// Token: 0x0600964D RID: 38477 RVA: 0x000D65C3 File Offset: 0x000D47C3
		public FFontParameterValue(FName ParameterName_DEPRECATED, FMaterialParameterInfo ParameterInfo, UFont FontValue, int FontPage, FGuid ExpressionGUID)
		{
			this.ParameterInfo = ParameterInfo;
			this.FontValue = FontValue;
			this.FontPage = FontPage;
			this.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x0600964E RID: 38478 RVA: 0x000D65E9 File Offset: 0x000D47E9
		protected override IntPtr GetUStructPtr()
		{
			return FFontParameterValue.StaticStruct();
		}

		// Token: 0x0600964F RID: 38479 RVA: 0x000D65F5 File Offset: 0x000D47F5
		[NullableContext(2)]
		public FFontParameterValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009650 RID: 38480 RVA: 0x000D65FF File Offset: 0x000D47FF
		public FFontParameterValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009651 RID: 38481 RVA: 0x000D660A File Offset: 0x000D480A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFontParameterValue(Pointer, false, true);
		}

		// Token: 0x06009652 RID: 38482 RVA: 0x000D6614 File Offset: 0x000D4814
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFontParameterValue(Pointer, MemoryOwner);
		}

		// Token: 0x0400544F RID: 21583
		public const string __ObjectPath = "/Script/Engine.FontParameterValue";

		// Token: 0x04005450 RID: 21584
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005451 RID: 21585
		internal static int __PropertyOffset_ParameterInfo;

		// Token: 0x04005452 RID: 21586
		[Nullable(2)]
		private FMaterialParameterInfo _ParameterInfo;

		// Token: 0x04005453 RID: 21587
		internal static int __PropertyOffset_FontValue;

		// Token: 0x04005454 RID: 21588
		internal static int __PropertyOffset_FontPage;

		// Token: 0x04005455 RID: 21589
		internal static int __PropertyOffset_ExpressionGUID;
	}
}
