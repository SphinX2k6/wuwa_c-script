using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010AC RID: 4268
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimeCurveLinearColor")]
	[UnrealStructLayout(520, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 520)]
	public class FRuntimeCurveLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F3FD RID: 62461 RVA: 0x00169DC3 File Offset: 0x00167FC3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimeCurveLinearColor._ScriptStructPtr != 0) ? FRuntimeCurveLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimeCurveLinearColor", ref FRuntimeCurveLinearColor._ScriptStructPtr);
		}

		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x0600F3FE RID: 62462 RVA: 0x00169DE8 File Offset: 0x00167FE8
		// (set) Token: 0x0600F3FF RID: 62463 RVA: 0x00169E2C File Offset: 0x0016802C
		public TFixedArray<FRichCurve> ColorCurves
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FRichCurve> result;
				if ((result = this._ColorCurves) == null)
				{
					result = (this._ColorCurves = new TFixedArray<FRichCurve>(base.NativePtr + (IntPtr)FRuntimeCurveLinearColor.__PropertyOffset_ColorCurves, 4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorCurves.CopyAssign(value);
			}
		}

		// Token: 0x17003B6F RID: 15215
		// (get) Token: 0x0600F400 RID: 62464 RVA: 0x00169E3A File Offset: 0x0016803A
		// (set) Token: 0x0600F401 RID: 62465 RVA: 0x00169E4E File Offset: 0x0016804E
		[Nullable(2)]
		public unsafe UCurveLinearColor ExternalCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveLinearColor>(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimeCurveLinearColor.__PropertyOffset_ExternalCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimeCurveLinearColor.__PropertyOffset_ExternalCurve, value);
			}
		}

		// Token: 0x0600F402 RID: 62466 RVA: 0x00169E63 File Offset: 0x00168063
		public FRuntimeCurveLinearColor()
		{
		}

		// Token: 0x0600F403 RID: 62467 RVA: 0x00169E6B File Offset: 0x0016806B
		public FRuntimeCurveLinearColor(TFixedArray<FRichCurve> ColorCurves, UCurveLinearColor ExternalCurve)
		{
			this.ColorCurves = ColorCurves;
			this.ExternalCurve = ExternalCurve;
		}

		// Token: 0x0600F404 RID: 62468 RVA: 0x00169E81 File Offset: 0x00168081
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimeCurveLinearColor.StaticStruct();
		}

		// Token: 0x0600F405 RID: 62469 RVA: 0x00169E8D File Offset: 0x0016808D
		[NullableContext(2)]
		public FRuntimeCurveLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F406 RID: 62470 RVA: 0x00169E97 File Offset: 0x00168097
		public FRuntimeCurveLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F407 RID: 62471 RVA: 0x00169EA2 File Offset: 0x001680A2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimeCurveLinearColor(Pointer, false, true);
		}

		// Token: 0x0600F408 RID: 62472 RVA: 0x00169EAC File Offset: 0x001680AC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimeCurveLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x0400843D RID: 33853
		public const string __ObjectPath = "/Script/Engine.RuntimeCurveLinearColor";

		// Token: 0x0400843E RID: 33854
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400843F RID: 33855
		internal static int __PropertyOffset_ColorCurves;

		// Token: 0x04008440 RID: 33856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FRichCurve> _ColorCurves;

		// Token: 0x04008441 RID: 33857
		internal static int __PropertyOffset_ExternalCurve;
	}
}
