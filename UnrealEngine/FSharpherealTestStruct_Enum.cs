using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200273F RID: 10047
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Enum")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FSharpherealTestStruct_Enum : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602538A RID: 152458 RVA: 0x00372EED File Offset: 0x003710ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_Enum._ScriptStructPtr != 0) ? FSharpherealTestStruct_Enum._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_Enum", ref FSharpherealTestStruct_Enum._ScriptStructPtr);
		}

		// Token: 0x17008FB2 RID: 36786
		// (get) Token: 0x0602538B RID: 152459 RVA: 0x00372F11 File Offset: 0x00371111
		// (set) Token: 0x0602538C RID: 152460 RVA: 0x00372F25 File Offset: 0x00371125
		[Nullable(0)]
		public unsafe TEnumAsByte<FSharpherealTestCEnum> EnumAsByte
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByte);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByte) = value;
			}
		}

		// Token: 0x17008FB3 RID: 36787
		// (get) Token: 0x0602538D RID: 152461 RVA: 0x00372F3A File Offset: 0x0037113A
		// (set) Token: 0x0602538E RID: 152462 RVA: 0x00372F4A File Offset: 0x0037114A
		public unsafe FSharpherealTestEnum Enum
		{
			get
			{
				return (FSharpherealTestEnum)(*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_Enum));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_Enum) = (byte)value;
			}
		}

		// Token: 0x17008FB4 RID: 36788
		// (get) Token: 0x0602538F RID: 152463 RVA: 0x00372F5C File Offset: 0x0037115C
		// (set) Token: 0x06025390 RID: 152464 RVA: 0x00372F9F File Offset: 0x0037119F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteArray) == null)
				{
					result = (this._EnumAsByteArray = new TArray<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FB5 RID: 36789
		// (get) Token: 0x06025391 RID: 152465 RVA: 0x00372FB0 File Offset: 0x003711B0
		// (set) Token: 0x06025392 RID: 152466 RVA: 0x00372FF3 File Offset: 0x003711F3
		public TArray<FSharpherealTestEnum> EnumArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSharpherealTestEnum> result;
				if ((result = this._EnumArray) == null)
				{
					result = (this._EnumArray = new TArray<FSharpherealTestEnum>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FB6 RID: 36790
		// (get) Token: 0x06025393 RID: 152467 RVA: 0x00373004 File Offset: 0x00371204
		// (set) Token: 0x06025394 RID: 152468 RVA: 0x00373048 File Offset: 0x00371248
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TFixedArray<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteFixedArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TFixedArray<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteFixedArray) == null)
				{
					result = (this._EnumAsByteFixedArray = new TFixedArray<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FB7 RID: 36791
		// (get) Token: 0x06025395 RID: 152469 RVA: 0x00373058 File Offset: 0x00371258
		// (set) Token: 0x06025396 RID: 152470 RVA: 0x0037309C File Offset: 0x0037129C
		public TFixedArray<FSharpherealTestEnum> EnumFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FSharpherealTestEnum> result;
				if ((result = this._EnumFixedArray) == null)
				{
					result = (this._EnumFixedArray = new TFixedArray<FSharpherealTestEnum>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x17008FB8 RID: 36792
		// (get) Token: 0x06025397 RID: 152471 RVA: 0x003730AC File Offset: 0x003712AC
		// (set) Token: 0x06025398 RID: 152472 RVA: 0x003730EF File Offset: 0x003712EF
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TSet<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteSet
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TEnumAsByte<FSharpherealTestCEnum>> result;
				if ((result = this._EnumAsByteSet) == null)
				{
					result = (this._EnumAsByteSet = new TSet<TEnumAsByte<FSharpherealTestCEnum>>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FB9 RID: 36793
		// (get) Token: 0x06025399 RID: 152473 RVA: 0x00373100 File Offset: 0x00371300
		// (set) Token: 0x0602539A RID: 152474 RVA: 0x00373143 File Offset: 0x00371343
		public TSet<FSharpherealTestEnum> EnumSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FSharpherealTestEnum> result;
				if ((result = this._EnumSet) == null)
				{
					result = (this._EnumSet = new TSet<FSharpherealTestEnum>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumSet.CopyAssign(value);
			}
		}

		// Token: 0x17008FBA RID: 36794
		// (get) Token: 0x0602539B RID: 152475 RVA: 0x00373154 File Offset: 0x00371354
		// (set) Token: 0x0602539C RID: 152476 RVA: 0x00373197 File Offset: 0x00371397
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TMap<TEnumAsByte<FSharpherealTestCEnum>, int> EnumAsByteMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<FSharpherealTestCEnum>, int> result;
				if ((result = this._EnumAsByteMap) == null)
				{
					result = (this._EnumAsByteMap = new TMap<TEnumAsByte<FSharpherealTestCEnum>, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumAsByteMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.EnumAsByteMap.CopyAssign(value);
			}
		}

		// Token: 0x17008FBB RID: 36795
		// (get) Token: 0x0602539D RID: 152477 RVA: 0x003731A8 File Offset: 0x003713A8
		// (set) Token: 0x0602539E RID: 152478 RVA: 0x003731EB File Offset: 0x003713EB
		public TMap<FSharpherealTestEnum, int> EnumMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSharpherealTestEnum, int> result;
				if ((result = this._EnumMap) == null)
				{
					result = (this._EnumMap = new TMap<FSharpherealTestEnum, int>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Enum.__PropertyOffset_EnumMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EnumMap.CopyAssign(value);
			}
		}

		// Token: 0x0602539F RID: 152479 RVA: 0x003731F9 File Offset: 0x003713F9
		public FSharpherealTestStruct_Enum()
		{
		}

		// Token: 0x060253A0 RID: 152480 RVA: 0x00373204 File Offset: 0x00371404
		public FSharpherealTestStruct_Enum([Nullable(0)] TEnumAsByte<FSharpherealTestCEnum> EnumAsByte, FSharpherealTestEnum Enum, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteArray, TArray<FSharpherealTestEnum> EnumArray, [Nullable(new byte[]
		{
			1,
			0
		})] TFixedArray<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteFixedArray, TFixedArray<FSharpherealTestEnum> EnumFixedArray, [Nullable(new byte[]
		{
			1,
			0
		})] TSet<TEnumAsByte<FSharpherealTestCEnum>> EnumAsByteSet, TSet<FSharpherealTestEnum> EnumSet, [Nullable(new byte[]
		{
			1,
			0
		})] TMap<TEnumAsByte<FSharpherealTestCEnum>, int> EnumAsByteMap, TMap<FSharpherealTestEnum, int> EnumMap)
		{
			this.EnumAsByte = EnumAsByte;
			this.Enum = Enum;
			this.EnumAsByteArray = EnumAsByteArray;
			this.EnumArray = EnumArray;
			this.EnumAsByteFixedArray = EnumAsByteFixedArray;
			this.EnumFixedArray = EnumFixedArray;
			this.EnumAsByteSet = EnumAsByteSet;
			this.EnumSet = EnumSet;
			this.EnumAsByteMap = EnumAsByteMap;
			this.EnumMap = EnumMap;
		}

		// Token: 0x060253A1 RID: 152481 RVA: 0x00373264 File Offset: 0x00371464
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_Enum.StaticStruct();
		}

		// Token: 0x060253A2 RID: 152482 RVA: 0x00373270 File Offset: 0x00371470
		[NullableContext(2)]
		public FSharpherealTestStruct_Enum(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060253A3 RID: 152483 RVA: 0x0037327A File Offset: 0x0037147A
		public FSharpherealTestStruct_Enum(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060253A4 RID: 152484 RVA: 0x00373285 File Offset: 0x00371485
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_Enum(Pointer, false, true);
		}

		// Token: 0x060253A5 RID: 152485 RVA: 0x0037328F File Offset: 0x0037148F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_Enum(Pointer, MemoryOwner);
		}

		// Token: 0x0401412B RID: 82219
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Enum";

		// Token: 0x0401412C RID: 82220
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401412D RID: 82221
		internal static int __PropertyOffset_EnumAsByte;

		// Token: 0x0401412E RID: 82222
		internal static int __PropertyOffset_Enum;

		// Token: 0x0401412F RID: 82223
		internal static int __PropertyOffset_EnumAsByteArray;

		// Token: 0x04014130 RID: 82224
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteArray;

		// Token: 0x04014131 RID: 82225
		internal static int __PropertyOffset_EnumArray;

		// Token: 0x04014132 RID: 82226
		[Nullable(2)]
		private TArray<FSharpherealTestEnum> _EnumArray;

		// Token: 0x04014133 RID: 82227
		internal static int __PropertyOffset_EnumAsByteFixedArray;

		// Token: 0x04014134 RID: 82228
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TFixedArray<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteFixedArray;

		// Token: 0x04014135 RID: 82229
		internal static int __PropertyOffset_EnumFixedArray;

		// Token: 0x04014136 RID: 82230
		[Nullable(2)]
		private TFixedArray<FSharpherealTestEnum> _EnumFixedArray;

		// Token: 0x04014137 RID: 82231
		internal static int __PropertyOffset_EnumAsByteSet;

		// Token: 0x04014138 RID: 82232
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TSet<TEnumAsByte<FSharpherealTestCEnum>> _EnumAsByteSet;

		// Token: 0x04014139 RID: 82233
		internal static int __PropertyOffset_EnumSet;

		// Token: 0x0401413A RID: 82234
		[Nullable(2)]
		private TSet<FSharpherealTestEnum> _EnumSet;

		// Token: 0x0401413B RID: 82235
		internal static int __PropertyOffset_EnumAsByteMap;

		// Token: 0x0401413C RID: 82236
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TMap<TEnumAsByte<FSharpherealTestCEnum>, int> _EnumAsByteMap;

		// Token: 0x0401413D RID: 82237
		internal static int __PropertyOffset_EnumMap;

		// Token: 0x0401413E RID: 82238
		[Nullable(2)]
		private TMap<FSharpherealTestEnum, int> _EnumMap;
	}
}
