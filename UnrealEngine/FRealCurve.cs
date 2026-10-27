using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001073 RID: 4211
	[UnrealObjectPath("/Script/Engine.RealCurve")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FRealCurve : FIndexedCurve, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF99 RID: 61337 RVA: 0x0016350D File Offset: 0x0016170D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRealCurve._ScriptStructPtr != 0) ? FRealCurve._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RealCurve", ref FRealCurve._ScriptStructPtr);
		}

		// Token: 0x170039FE RID: 14846
		// (get) Token: 0x0600EF9A RID: 61338 RVA: 0x00163531 File Offset: 0x00161731
		// (set) Token: 0x0600EF9B RID: 61339 RVA: 0x00163541 File Offset: 0x00161741
		public unsafe float DefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_DefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_DefaultValue) = value;
			}
		}

		// Token: 0x170039FF RID: 14847
		// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x00163552 File Offset: 0x00161752
		// (set) Token: 0x0600EF9D RID: 61341 RVA: 0x00163566 File Offset: 0x00161766
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PreInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PreInfinityExtrap) = value;
			}
		}

		// Token: 0x17003A00 RID: 14848
		// (get) Token: 0x0600EF9E RID: 61342 RVA: 0x0016357B File Offset: 0x0016177B
		// (set) Token: 0x0600EF9F RID: 61343 RVA: 0x0016358F File Offset: 0x0016178F
		public unsafe TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PostInfinityExtrap);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRealCurve.__PropertyOffset_PostInfinityExtrap) = value;
			}
		}

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x001635A4 File Offset: 0x001617A4
		public FRealCurve()
		{
		}

		// Token: 0x0600EFA1 RID: 61345 RVA: 0x001635AC File Offset: 0x001617AC
		public FRealCurve(float DefaultValue, TEnumAsByte<ERichCurveExtrapolation> PreInfinityExtrap, TEnumAsByte<ERichCurveExtrapolation> PostInfinityExtrap, [Nullable(1)] FKeyHandleMap KeyHandlesToIndices)
		{
			this.DefaultValue = DefaultValue;
			this.PreInfinityExtrap = PreInfinityExtrap;
			this.PostInfinityExtrap = PostInfinityExtrap;
			base.KeyHandlesToIndices = KeyHandlesToIndices;
		}

		// Token: 0x0600EFA2 RID: 61346 RVA: 0x001635D1 File Offset: 0x001617D1
		protected override IntPtr GetUStructPtr()
		{
			return FRealCurve.StaticStruct();
		}

		// Token: 0x0600EFA3 RID: 61347 RVA: 0x001635DD File Offset: 0x001617DD
		[NullableContext(2)]
		public FRealCurve(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EFA4 RID: 61348 RVA: 0x001635E7 File Offset: 0x001617E7
		public FRealCurve(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x001635F2 File Offset: 0x001617F2
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRealCurve(Pointer, false, true);
		}

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x001635FC File Offset: 0x001617FC
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRealCurve(Pointer, MemoryOwner);
		}

		// Token: 0x040081A3 RID: 33187
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RealCurve";

		// Token: 0x040081A4 RID: 33188
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040081A5 RID: 33189
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x040081A6 RID: 33190
		internal static int __PropertyOffset_PreInfinityExtrap;

		// Token: 0x040081A7 RID: 33191
		internal static int __PropertyOffset_PostInfinityExtrap;
	}
}
