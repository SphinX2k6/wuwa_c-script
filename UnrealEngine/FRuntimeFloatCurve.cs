using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010AD RID: 4269
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RuntimeFloatCurve")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FRuntimeFloatCurve : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F409 RID: 62473 RVA: 0x00169EB5 File Offset: 0x001680B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimeFloatCurve._ScriptStructPtr != 0) ? FRuntimeFloatCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimeFloatCurve", ref FRuntimeFloatCurve._ScriptStructPtr);
		}

		// Token: 0x17003B70 RID: 15216
		// (get) Token: 0x0600F40A RID: 62474 RVA: 0x00169EDC File Offset: 0x001680DC
		// (set) Token: 0x0600F40B RID: 62475 RVA: 0x00169F1F File Offset: 0x0016811F
		public FRichCurve EditorCurveData
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._EditorCurveData) == null)
				{
					result = (this._EditorCurveData = new FRichCurve(base.NativePtr + (IntPtr)FRuntimeFloatCurve.__PropertyOffset_EditorCurveData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)FRuntimeFloatCurve.__PropertyOffset_EditorCurveData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B71 RID: 15217
		// (get) Token: 0x0600F40C RID: 62476 RVA: 0x00169F40 File Offset: 0x00168140
		// (set) Token: 0x0600F40D RID: 62477 RVA: 0x00169F54 File Offset: 0x00168154
		[Nullable(2)]
		public unsafe UCurveFloat ExternalCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimeFloatCurve.__PropertyOffset_ExternalCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRuntimeFloatCurve.__PropertyOffset_ExternalCurve, value);
			}
		}

		// Token: 0x0600F40E RID: 62478 RVA: 0x00169F69 File Offset: 0x00168169
		public FRuntimeFloatCurve()
		{
		}

		// Token: 0x0600F40F RID: 62479 RVA: 0x00169F71 File Offset: 0x00168171
		public FRuntimeFloatCurve(FRichCurve EditorCurveData, UCurveFloat ExternalCurve)
		{
			this.EditorCurveData = EditorCurveData;
			this.ExternalCurve = ExternalCurve;
		}

		// Token: 0x0600F410 RID: 62480 RVA: 0x00169F87 File Offset: 0x00168187
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimeFloatCurve.StaticStruct();
		}

		// Token: 0x0600F411 RID: 62481 RVA: 0x00169F93 File Offset: 0x00168193
		[NullableContext(2)]
		public FRuntimeFloatCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F412 RID: 62482 RVA: 0x00169F9D File Offset: 0x0016819D
		public FRuntimeFloatCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F413 RID: 62483 RVA: 0x00169FA8 File Offset: 0x001681A8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimeFloatCurve(Pointer, false, true);
		}

		// Token: 0x0600F414 RID: 62484 RVA: 0x00169FB2 File Offset: 0x001681B2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimeFloatCurve(Pointer, MemoryOwner);
		}

		// Token: 0x04008442 RID: 33858
		public const string __ObjectPath = "/Script/Engine.RuntimeFloatCurve";

		// Token: 0x04008443 RID: 33859
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008444 RID: 33860
		internal static int __PropertyOffset_EditorCurveData;

		// Token: 0x04008445 RID: 33861
		[Nullable(2)]
		private FRichCurve _EditorCurveData;

		// Token: 0x04008446 RID: 33862
		internal static int __PropertyOffset_ExternalCurve;
	}
}
