using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BCB RID: 3019
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ExposedValueHandler")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FExposedValueHandler : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009468 RID: 37992 RVA: 0x000D3E19 File Offset: 0x000D2019
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExposedValueHandler._ScriptStructPtr != 0) ? FExposedValueHandler._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExposedValueHandler", ref FExposedValueHandler._ScriptStructPtr);
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06009469 RID: 37993 RVA: 0x000D3E3D File Offset: 0x000D203D
		// (set) Token: 0x0600946A RID: 37994 RVA: 0x000D3E51 File Offset: 0x000D2051
		public unsafe FName BoundFunction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExposedValueHandler.__PropertyOffset_BoundFunction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExposedValueHandler.__PropertyOffset_BoundFunction) = value;
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x0600946B RID: 37995 RVA: 0x000D3E68 File Offset: 0x000D2068
		// (set) Token: 0x0600946C RID: 37996 RVA: 0x000D3EAB File Offset: 0x000D20AB
		public TArray<FExposedValueCopyRecord> CopyRecords
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FExposedValueCopyRecord> result;
				if ((result = this._CopyRecords) == null)
				{
					result = (this._CopyRecords = new TArray<FExposedValueCopyRecord>(base.NativePtr + (IntPtr)FExposedValueHandler.__PropertyOffset_CopyRecords, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CopyRecords.CopyAssign(value);
			}
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x0600946D RID: 37997 RVA: 0x000D3EB9 File Offset: 0x000D20B9
		// (set) Token: 0x0600946E RID: 37998 RVA: 0x000D3ECD File Offset: 0x000D20CD
		[Nullable(2)]
		public unsafe UFunction Function
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FExposedValueHandler.__PropertyOffset_Function);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FExposedValueHandler.__PropertyOffset_Function, value);
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x0600946F RID: 37999 RVA: 0x000D3EE2 File Offset: 0x000D20E2
		// (set) Token: 0x06009470 RID: 38000 RVA: 0x000D3EF2 File Offset: 0x000D20F2
		public unsafe Unusable ValueHandlerNodeProperty
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExposedValueHandler.__PropertyOffset_ValueHandlerNodeProperty);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExposedValueHandler.__PropertyOffset_ValueHandlerNodeProperty) = value;
			}
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x000D3F03 File Offset: 0x000D2103
		public FExposedValueHandler()
		{
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x000D3F0B File Offset: 0x000D210B
		public FExposedValueHandler(FName BoundFunction, TArray<FExposedValueCopyRecord> CopyRecords, UFunction Function, Unusable ValueHandlerNodeProperty)
		{
			this.BoundFunction = BoundFunction;
			this.CopyRecords = CopyRecords;
			this.Function = Function;
			this.ValueHandlerNodeProperty = ValueHandlerNodeProperty;
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x000D3F30 File Offset: 0x000D2130
		protected override IntPtr GetUStructPtr()
		{
			return FExposedValueHandler.StaticStruct();
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x000D3F3C File Offset: 0x000D213C
		[NullableContext(2)]
		public FExposedValueHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x000D3F46 File Offset: 0x000D2146
		public FExposedValueHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009476 RID: 38006 RVA: 0x000D3F51 File Offset: 0x000D2151
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExposedValueHandler(Pointer, false, true);
		}

		// Token: 0x06009477 RID: 38007 RVA: 0x000D3F5B File Offset: 0x000D215B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExposedValueHandler(Pointer, MemoryOwner);
		}

		// Token: 0x04005367 RID: 21351
		public const string __ObjectPath = "/Script/Engine.ExposedValueHandler";

		// Token: 0x04005368 RID: 21352
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005369 RID: 21353
		internal static int __PropertyOffset_BoundFunction;

		// Token: 0x0400536A RID: 21354
		internal static int __PropertyOffset_CopyRecords;

		// Token: 0x0400536B RID: 21355
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FExposedValueCopyRecord> _CopyRecords;

		// Token: 0x0400536C RID: 21356
		internal static int __PropertyOffset_Function;

		// Token: 0x0400536D RID: 21357
		internal static int __PropertyOffset_ValueHandlerNodeProperty;
	}
}
