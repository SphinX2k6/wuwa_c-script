using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001188 RID: 4488
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StatColorMapping")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FStatColorMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060107E7 RID: 67559 RVA: 0x0018389B File Offset: 0x00181A9B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStatColorMapping._ScriptStructPtr != 0) ? FStatColorMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StatColorMapping", ref FStatColorMapping._ScriptStructPtr);
		}

		// Token: 0x17004051 RID: 16465
		// (get) Token: 0x060107E8 RID: 67560 RVA: 0x001838BF File Offset: 0x00181ABF
		// (set) Token: 0x060107E9 RID: 67561 RVA: 0x001838D3 File Offset: 0x00181AD3
		public unsafe string StatName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FStatColorMapping.__PropertyOffset_StatName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FStatColorMapping.__PropertyOffset_StatName)), value);
			}
		}

		// Token: 0x17004052 RID: 16466
		// (get) Token: 0x060107EA RID: 67562 RVA: 0x001838E8 File Offset: 0x00181AE8
		// (set) Token: 0x060107EB RID: 67563 RVA: 0x0018392B File Offset: 0x00181B2B
		public TArray<FStatColorMapEntry> ColorMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStatColorMapEntry> result;
				if ((result = this._ColorMap) == null)
				{
					result = (this._ColorMap = new TArray<FStatColorMapEntry>(base.NativePtr + (IntPtr)FStatColorMapping.__PropertyOffset_ColorMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorMap.CopyAssign(value);
			}
		}

		// Token: 0x17004053 RID: 16467
		// (get) Token: 0x060107EC RID: 67564 RVA: 0x00183939 File Offset: 0x00181B39
		// (set) Token: 0x060107ED RID: 67565 RVA: 0x00183952 File Offset: 0x00181B52
		public unsafe bool DisableBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FStatColorMapping.__PropertyOffset_DisableBlend) & FStatColorMapping.__PropertyMask_DisableBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FStatColorMapping.__PropertyOffset_DisableBlend) = ((*(base.NativePtr + (IntPtr)FStatColorMapping.__PropertyOffset_DisableBlend) & ~FStatColorMapping.__PropertyMask_DisableBlend) | (value ? FStatColorMapping.__PropertyMask_DisableBlend : 0));
			}
		}

		// Token: 0x060107EE RID: 67566 RVA: 0x00183982 File Offset: 0x00181B82
		public FStatColorMapping()
		{
		}

		// Token: 0x060107EF RID: 67567 RVA: 0x0018398A File Offset: 0x00181B8A
		public FStatColorMapping(string StatName, TArray<FStatColorMapEntry> ColorMap, bool DisableBlend)
		{
			this.StatName = StatName;
			this.ColorMap = ColorMap;
			this.DisableBlend = DisableBlend;
		}

		// Token: 0x060107F0 RID: 67568 RVA: 0x001839A7 File Offset: 0x00181BA7
		protected override IntPtr GetUStructPtr()
		{
			return FStatColorMapping.StaticStruct();
		}

		// Token: 0x060107F1 RID: 67569 RVA: 0x001839B3 File Offset: 0x00181BB3
		[NullableContext(2)]
		public FStatColorMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060107F2 RID: 67570 RVA: 0x001839BD File Offset: 0x00181BBD
		public FStatColorMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060107F3 RID: 67571 RVA: 0x001839C8 File Offset: 0x00181BC8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStatColorMapping(Pointer, false, true);
		}

		// Token: 0x060107F4 RID: 67572 RVA: 0x001839D2 File Offset: 0x00181BD2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStatColorMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04008D29 RID: 36137
		public const string __ObjectPath = "/Script/Engine.StatColorMapping";

		// Token: 0x04008D2A RID: 36138
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008D2B RID: 36139
		internal static int __PropertyOffset_StatName;

		// Token: 0x04008D2C RID: 36140
		internal static int __PropertyOffset_ColorMap;

		// Token: 0x04008D2D RID: 36141
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStatColorMapEntry> _ColorMap;

		// Token: 0x04008D2E RID: 36142
		internal static int __PropertyOffset_DisableBlend;

		// Token: 0x04008D2F RID: 36143
		internal static byte __PropertyMask_DisableBlend;
	}
}
