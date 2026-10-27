using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002196 RID: 8598
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIPolygonLine")]
	[UnrealStructLayout(2304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2304)]
	public class UUIPolygonLine : UUI2DLineRendererBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209C2 RID: 133570 RVA: 0x0030452F File Offset: 0x0030272F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIPolygonLine._ClassPtr;
		}

		// Token: 0x060209C3 RID: 133571 RVA: 0x0030453C File Offset: 0x0030273C
		public UUIPolygonLine() : this(BuiltinUtils.AllocNativeUObject(UUIPolygonLine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209C4 RID: 133572 RVA: 0x00304564 File Offset: 0x00302764
		public UUIPolygonLine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIPolygonLine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F7C RID: 32636
		// (get) Token: 0x060209C5 RID: 133573 RVA: 0x00304597 File Offset: 0x00302797
		// (set) Token: 0x060209C6 RID: 133574 RVA: 0x003045A7 File Offset: 0x003027A7
		public unsafe bool FullCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_FullCycle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_FullCycle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F7D RID: 32637
		// (get) Token: 0x060209C7 RID: 133575 RVA: 0x003045B8 File Offset: 0x003027B8
		// (set) Token: 0x060209C8 RID: 133576 RVA: 0x003045C8 File Offset: 0x003027C8
		public unsafe float StartAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_StartAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_StartAngle) = value;
			}
		}

		// Token: 0x17007F7E RID: 32638
		// (get) Token: 0x060209C9 RID: 133577 RVA: 0x003045D9 File Offset: 0x003027D9
		// (set) Token: 0x060209CA RID: 133578 RVA: 0x003045E9 File Offset: 0x003027E9
		public unsafe float EndAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_EndAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_EndAngle) = value;
			}
		}

		// Token: 0x17007F7F RID: 32639
		// (get) Token: 0x060209CB RID: 133579 RVA: 0x003045FA File Offset: 0x003027FA
		// (set) Token: 0x060209CC RID: 133580 RVA: 0x0030460A File Offset: 0x0030280A
		public unsafe int Sides
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_Sides);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_Sides) = value;
			}
		}

		// Token: 0x17007F80 RID: 32640
		// (get) Token: 0x060209CD RID: 133581 RVA: 0x0030461C File Offset: 0x0030281C
		// (set) Token: 0x060209CE RID: 133582 RVA: 0x00304655 File Offset: 0x00302855
		public TArray<float> VertexOffsetArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._VertexOffsetArray) == null)
				{
					result = (this._VertexOffsetArray = new TArray<float>(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_VertexOffsetArray, this));
				}
				return result;
			}
			set
			{
				this.VertexOffsetArray.CopyAssign(value);
			}
		}

		// Token: 0x17007F81 RID: 32641
		// (get) Token: 0x060209CF RID: 133583 RVA: 0x00304664 File Offset: 0x00302864
		// (set) Token: 0x060209D0 RID: 133584 RVA: 0x0030469D File Offset: 0x0030289D
		public TArray<FVector2D> CurrentPointArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._CurrentPointArray) == null)
				{
					result = (this._CurrentPointArray = new TArray<FVector2D>(base.NativePtr + (IntPtr)UUIPolygonLine.__PropertyOffset_CurrentPointArray, this));
				}
				return result;
			}
			set
			{
				this.CurrentPointArray.CopyAssign(value);
			}
		}

		// Token: 0x060209D1 RID: 133585 RVA: 0x003046AB File Offset: 0x003028AB
		[NullableContext(2)]
		public ULTweener StartAngleTo(float endValue, float duration = 0.5f, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUIPolygonLine.__StartAngleTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x060209D2 RID: 133586 RVA: 0x003046C2 File Offset: 0x003028C2
		[NullableContext(2)]
		public void SetVertexOffsetArray(in TArray<float> value)
		{
			UUIPolygonLine.__SetVertexOffsetArray_Internal(base.NativePtr, (value ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x060209D3 RID: 133587 RVA: 0x003046DF File Offset: 0x003028DF
		public void SetStartAngle(float value)
		{
			UUIPolygonLine.__SetStartAngle_Internal(base.NativePtr, value);
		}

		// Token: 0x060209D4 RID: 133588 RVA: 0x003046ED File Offset: 0x003028ED
		public void SetSides(int value)
		{
			UUIPolygonLine.__SetSides_Internal(base.NativePtr, value);
		}

		// Token: 0x060209D5 RID: 133589 RVA: 0x003046FB File Offset: 0x003028FB
		public void SetEndAngle(float value)
		{
			UUIPolygonLine.__SetEndAngle_Internal(base.NativePtr, value);
		}

		// Token: 0x060209D6 RID: 133590 RVA: 0x00304709 File Offset: 0x00302909
		public TArray<float> GetVertexOffsetArray()
		{
			return new TArray<float>(UUIPolygonLine.__GetVertexOffsetArray_Internal(base.NativePtr), null);
		}

		// Token: 0x060209D7 RID: 133591 RVA: 0x0030471C File Offset: 0x0030291C
		public float GetStartAngle()
		{
			return UUIPolygonLine.__GetStartAngle_Internal(base.NativePtr);
		}

		// Token: 0x060209D8 RID: 133592 RVA: 0x00304729 File Offset: 0x00302929
		public int GetSides()
		{
			return UUIPolygonLine.__GetSides_Internal(base.NativePtr);
		}

		// Token: 0x060209D9 RID: 133593 RVA: 0x00304736 File Offset: 0x00302936
		public float GetEndAngle()
		{
			return UUIPolygonLine.__GetEndAngle_Internal(base.NativePtr);
		}

		// Token: 0x060209DA RID: 133594 RVA: 0x00304743 File Offset: 0x00302943
		[NullableContext(2)]
		public ULTweener EndAngleTo(float endValue, float duration = 0.5f, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUIPolygonLine.__EndAngleTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x060209DB RID: 133595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartAngleTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x060209DC RID: 133596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexOffsetArray_Internal(IntPtr @this, IntPtr value);

		// Token: 0x060209DD RID: 133597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartAngle_Internal(IntPtr @this, float value);

		// Token: 0x060209DE RID: 133598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSides_Internal(IntPtr @this, int value);

		// Token: 0x060209DF RID: 133599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndAngle_Internal(IntPtr @this, float value);

		// Token: 0x060209E0 RID: 133600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexOffsetArray_Internal(IntPtr @this);

		// Token: 0x060209E1 RID: 133601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartAngle_Internal(IntPtr @this);

		// Token: 0x060209E2 RID: 133602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSides_Internal(IntPtr @this);

		// Token: 0x060209E3 RID: 133603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEndAngle_Internal(IntPtr @this);

		// Token: 0x060209E4 RID: 133604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EndAngleTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x060209E5 RID: 133605 RVA: 0x0030475A File Offset: 0x0030295A
		static UUIPolygonLine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIPolygonLine");
		}

		// Token: 0x060209E6 RID: 133606 RVA: 0x00304768 File Offset: 0x00302968
		protected UUIPolygonLine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401173C RID: 71484
		public new const string __ObjectPath = "/Script/LGUI.UIPolygonLine";

		// Token: 0x0401173D RID: 71485
		private static IntPtr _ClassPtr;

		// Token: 0x0401173E RID: 71486
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401173F RID: 71487
		internal static int __PropertyOffset_FullCycle;

		// Token: 0x04011740 RID: 71488
		internal static int __PropertyOffset_StartAngle;

		// Token: 0x04011741 RID: 71489
		internal static int __PropertyOffset_EndAngle;

		// Token: 0x04011742 RID: 71490
		internal static int __PropertyOffset_Sides;

		// Token: 0x04011743 RID: 71491
		internal static int __PropertyOffset_VertexOffsetArray;

		// Token: 0x04011744 RID: 71492
		[Nullable(2)]
		private TArray<float> _VertexOffsetArray;

		// Token: 0x04011745 RID: 71493
		internal static int __PropertyOffset_CurrentPointArray;

		// Token: 0x04011746 RID: 71494
		[Nullable(2)]
		private TArray<FVector2D> _CurrentPointArray;
	}
}
