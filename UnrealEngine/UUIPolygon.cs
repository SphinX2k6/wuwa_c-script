using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002194 RID: 8596
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIPolygon")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class UUIPolygon : UUISpriteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020992 RID: 133522 RVA: 0x00304251 File Offset: 0x00302451
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIPolygon._ClassPtr;
		}

		// Token: 0x06020993 RID: 133523 RVA: 0x00304260 File Offset: 0x00302460
		public UUIPolygon() : this(BuiltinUtils.AllocNativeUObject(UUIPolygon.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020994 RID: 133524 RVA: 0x00304288 File Offset: 0x00302488
		public UUIPolygon(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIPolygon.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F75 RID: 32629
		// (get) Token: 0x06020995 RID: 133525 RVA: 0x003042BB File Offset: 0x003024BB
		// (set) Token: 0x06020996 RID: 133526 RVA: 0x003042CB File Offset: 0x003024CB
		public unsafe bool FullCycle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_FullCycle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_FullCycle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007F76 RID: 32630
		// (get) Token: 0x06020997 RID: 133527 RVA: 0x003042DC File Offset: 0x003024DC
		// (set) Token: 0x06020998 RID: 133528 RVA: 0x003042EC File Offset: 0x003024EC
		public unsafe float StartAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_StartAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_StartAngle) = value;
			}
		}

		// Token: 0x17007F77 RID: 32631
		// (get) Token: 0x06020999 RID: 133529 RVA: 0x003042FD File Offset: 0x003024FD
		// (set) Token: 0x0602099A RID: 133530 RVA: 0x0030430D File Offset: 0x0030250D
		public unsafe float EndAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_EndAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_EndAngle) = value;
			}
		}

		// Token: 0x17007F78 RID: 32632
		// (get) Token: 0x0602099B RID: 133531 RVA: 0x0030431E File Offset: 0x0030251E
		// (set) Token: 0x0602099C RID: 133532 RVA: 0x0030432E File Offset: 0x0030252E
		public unsafe int Sides
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_Sides);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_Sides) = value;
			}
		}

		// Token: 0x17007F79 RID: 32633
		// (get) Token: 0x0602099D RID: 133533 RVA: 0x0030433F File Offset: 0x0030253F
		// (set) Token: 0x0602099E RID: 133534 RVA: 0x0030434F File Offset: 0x0030254F
		public unsafe UIPolygonUVType UVType
		{
			get
			{
				return (UIPolygonUVType)(*(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_UVType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_UVType) = (byte)value;
			}
		}

		// Token: 0x17007F7A RID: 32634
		// (get) Token: 0x0602099F RID: 133535 RVA: 0x00304360 File Offset: 0x00302560
		// (set) Token: 0x060209A0 RID: 133536 RVA: 0x00304399 File Offset: 0x00302599
		public TArray<float> VertexOffsetArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._VertexOffsetArray) == null)
				{
					result = (this._VertexOffsetArray = new TArray<float>(base.NativePtr + (IntPtr)UUIPolygon.__PropertyOffset_VertexOffsetArray, this));
				}
				return result;
			}
			set
			{
				this.VertexOffsetArray.CopyAssign(value);
			}
		}

		// Token: 0x060209A1 RID: 133537 RVA: 0x003043A7 File Offset: 0x003025A7
		[NullableContext(2)]
		public ULTweener StartAngleTo(float endValue, float duration = 0.5f, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUIPolygon.__StartAngleTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x060209A2 RID: 133538 RVA: 0x003043BE File Offset: 0x003025BE
		[NullableContext(2)]
		public void SetVertexOffsetArray(in TArray<float> value)
		{
			UUIPolygon.__SetVertexOffsetArray_Internal(base.NativePtr, (value ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x060209A3 RID: 133539 RVA: 0x003043DB File Offset: 0x003025DB
		public void SetUVType(UIPolygonUVType value)
		{
			UUIPolygon.__SetUVType_Internal(base.NativePtr, value);
		}

		// Token: 0x060209A4 RID: 133540 RVA: 0x003043E9 File Offset: 0x003025E9
		public void SetStartAngle(float value)
		{
			UUIPolygon.__SetStartAngle_Internal(base.NativePtr, value);
		}

		// Token: 0x060209A5 RID: 133541 RVA: 0x003043F7 File Offset: 0x003025F7
		public void SetSides(int value)
		{
			UUIPolygon.__SetSides_Internal(base.NativePtr, value);
		}

		// Token: 0x060209A6 RID: 133542 RVA: 0x00304405 File Offset: 0x00302605
		public void SetEndAngle(float value)
		{
			UUIPolygon.__SetEndAngle_Internal(base.NativePtr, value);
		}

		// Token: 0x060209A7 RID: 133543 RVA: 0x00304413 File Offset: 0x00302613
		public TArray<float> GetVertexOffsetArray()
		{
			return new TArray<float>(UUIPolygon.__GetVertexOffsetArray_Internal(base.NativePtr), null);
		}

		// Token: 0x060209A8 RID: 133544 RVA: 0x00304426 File Offset: 0x00302626
		public UIPolygonUVType GetUVType()
		{
			return UUIPolygon.__GetUVType_Internal(base.NativePtr);
		}

		// Token: 0x060209A9 RID: 133545 RVA: 0x00304433 File Offset: 0x00302633
		public float GetStartAngle()
		{
			return UUIPolygon.__GetStartAngle_Internal(base.NativePtr);
		}

		// Token: 0x060209AA RID: 133546 RVA: 0x00304440 File Offset: 0x00302640
		public int GetSides()
		{
			return UUIPolygon.__GetSides_Internal(base.NativePtr);
		}

		// Token: 0x060209AB RID: 133547 RVA: 0x0030444D File Offset: 0x0030264D
		public float GetEndAngle()
		{
			return UUIPolygon.__GetEndAngle_Internal(base.NativePtr);
		}

		// Token: 0x060209AC RID: 133548 RVA: 0x0030445A File Offset: 0x0030265A
		[NullableContext(2)]
		public ULTweener EndAngleTo(float endValue, float duration = 0.5f, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUIPolygon.__EndAngleTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x060209AD RID: 133549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartAngleTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x060209AE RID: 133550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertexOffsetArray_Internal(IntPtr @this, IntPtr value);

		// Token: 0x060209AF RID: 133551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUVType_Internal(IntPtr @this, UIPolygonUVType value);

		// Token: 0x060209B0 RID: 133552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartAngle_Internal(IntPtr @this, float value);

		// Token: 0x060209B1 RID: 133553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSides_Internal(IntPtr @this, int value);

		// Token: 0x060209B2 RID: 133554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndAngle_Internal(IntPtr @this, float value);

		// Token: 0x060209B3 RID: 133555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVertexOffsetArray_Internal(IntPtr @this);

		// Token: 0x060209B4 RID: 133556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIPolygonUVType __GetUVType_Internal(IntPtr @this);

		// Token: 0x060209B5 RID: 133557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartAngle_Internal(IntPtr @this);

		// Token: 0x060209B6 RID: 133558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSides_Internal(IntPtr @this);

		// Token: 0x060209B7 RID: 133559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEndAngle_Internal(IntPtr @this);

		// Token: 0x060209B8 RID: 133560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EndAngleTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x060209B9 RID: 133561 RVA: 0x00304471 File Offset: 0x00302671
		static UUIPolygon()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIPolygon");
		}

		// Token: 0x060209BA RID: 133562 RVA: 0x0030447F File Offset: 0x0030267F
		protected UUIPolygon(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401172E RID: 71470
		public new const string __ObjectPath = "/Script/LGUI.UIPolygon";

		// Token: 0x0401172F RID: 71471
		private static IntPtr _ClassPtr;

		// Token: 0x04011730 RID: 71472
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011731 RID: 71473
		internal static int __PropertyOffset_FullCycle;

		// Token: 0x04011732 RID: 71474
		internal static int __PropertyOffset_StartAngle;

		// Token: 0x04011733 RID: 71475
		internal static int __PropertyOffset_EndAngle;

		// Token: 0x04011734 RID: 71476
		internal static int __PropertyOffset_Sides;

		// Token: 0x04011735 RID: 71477
		internal static int __PropertyOffset_UVType;

		// Token: 0x04011736 RID: 71478
		internal static int __PropertyOffset_VertexOffsetArray;

		// Token: 0x04011737 RID: 71479
		[Nullable(2)]
		private TArray<float> _VertexOffsetArray;
	}
}
