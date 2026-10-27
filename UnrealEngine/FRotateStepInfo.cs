using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200176A RID: 5994
	[UnrealObjectPath("/Script/KuroComponent.RotateStepInfo")]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRotateStepInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060158EE RID: 88302 RVA: 0x001FB88B File Offset: 0x001F9A8B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRotateStepInfo._ScriptStructPtr != 0) ? FRotateStepInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.RotateStepInfo", ref FRotateStepInfo._ScriptStructPtr);
		}

		// Token: 0x17005516 RID: 21782
		// (get) Token: 0x060158EF RID: 88303 RVA: 0x001FB8AF File Offset: 0x001F9AAF
		// (set) Token: 0x060158F0 RID: 88304 RVA: 0x001FB8C3 File Offset: 0x001F9AC3
		[Nullable(2)]
		public unsafe UCurveFloat RotateCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FRotateStepInfo.__PropertyOffset_RotateCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRotateStepInfo.__PropertyOffset_RotateCurve, value);
			}
		}

		// Token: 0x060158F1 RID: 88305 RVA: 0x001FB8D8 File Offset: 0x001F9AD8
		public FRotateStepInfo()
		{
		}

		// Token: 0x060158F2 RID: 88306 RVA: 0x001FB8E0 File Offset: 0x001F9AE0
		[NullableContext(1)]
		public FRotateStepInfo(UCurveFloat RotateCurve)
		{
			this.RotateCurve = RotateCurve;
		}

		// Token: 0x060158F3 RID: 88307 RVA: 0x001FB8EF File Offset: 0x001F9AEF
		protected override IntPtr GetUStructPtr()
		{
			return FRotateStepInfo.StaticStruct();
		}

		// Token: 0x060158F4 RID: 88308 RVA: 0x001FB8FB File Offset: 0x001F9AFB
		[NullableContext(2)]
		public FRotateStepInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060158F5 RID: 88309 RVA: 0x001FB905 File Offset: 0x001F9B05
		public FRotateStepInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060158F6 RID: 88310 RVA: 0x001FB910 File Offset: 0x001F9B10
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRotateStepInfo(Pointer, false, true);
		}

		// Token: 0x060158F7 RID: 88311 RVA: 0x001FB91A File Offset: 0x001F9B1A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRotateStepInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC3A RID: 48186
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComponent.RotateStepInfo";

		// Token: 0x0400BC3B RID: 48187
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BC3C RID: 48188
		internal static int __PropertyOffset_RotateCurve;
	}
}
