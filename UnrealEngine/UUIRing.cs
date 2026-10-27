using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200219D RID: 8605
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIRing")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UUIRing : UUI2DLineRendererBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020A2C RID: 133676 RVA: 0x00304C9E File Offset: 0x00302E9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIRing._ClassPtr;
		}

		// Token: 0x06020A2D RID: 133677 RVA: 0x00304CAC File Offset: 0x00302EAC
		public UUIRing() : this(BuiltinUtils.AllocNativeUObject(UUIRing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020A2E RID: 133678 RVA: 0x00304CD4 File Offset: 0x00302ED4
		public UUIRing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIRing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F93 RID: 32659
		// (get) Token: 0x06020A2F RID: 133679 RVA: 0x00304D07 File Offset: 0x00302F07
		// (set) Token: 0x06020A30 RID: 133680 RVA: 0x00304D17 File Offset: 0x00302F17
		public unsafe float StartAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRing.__PropertyOffset_StartAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRing.__PropertyOffset_StartAngle) = value;
			}
		}

		// Token: 0x17007F94 RID: 32660
		// (get) Token: 0x06020A31 RID: 133681 RVA: 0x00304D28 File Offset: 0x00302F28
		// (set) Token: 0x06020A32 RID: 133682 RVA: 0x00304D38 File Offset: 0x00302F38
		public unsafe float EndAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRing.__PropertyOffset_EndAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRing.__PropertyOffset_EndAngle) = value;
			}
		}

		// Token: 0x17007F95 RID: 32661
		// (get) Token: 0x06020A33 RID: 133683 RVA: 0x00304D49 File Offset: 0x00302F49
		// (set) Token: 0x06020A34 RID: 133684 RVA: 0x00304D59 File Offset: 0x00302F59
		public unsafe int Segment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIRing.__PropertyOffset_Segment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIRing.__PropertyOffset_Segment) = value;
			}
		}

		// Token: 0x17007F96 RID: 32662
		// (get) Token: 0x06020A35 RID: 133685 RVA: 0x00304D6C File Offset: 0x00302F6C
		// (set) Token: 0x06020A36 RID: 133686 RVA: 0x00304DA5 File Offset: 0x00302FA5
		public TArray<FVector2D> CurrentPointArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._CurrentPointArray) == null)
				{
					result = (this._CurrentPointArray = new TArray<FVector2D>(base.NativePtr + (IntPtr)UUIRing.__PropertyOffset_CurrentPointArray, this));
				}
				return result;
			}
			set
			{
				this.CurrentPointArray.CopyAssign(value);
			}
		}

		// Token: 0x06020A37 RID: 133687 RVA: 0x00304DB3 File Offset: 0x00302FB3
		[NullableContext(2)]
		public ULTweener StartAngleTo(float endValue, float duration = 0.5f, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUIRing.__StartAngleTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x06020A38 RID: 133688 RVA: 0x00304DCA File Offset: 0x00302FCA
		public void SetStartAngle(float newValue)
		{
			UUIRing.__SetStartAngle_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020A39 RID: 133689 RVA: 0x00304DD8 File Offset: 0x00302FD8
		public void SetSegment(int newValue)
		{
			UUIRing.__SetSegment_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020A3A RID: 133690 RVA: 0x00304DE6 File Offset: 0x00302FE6
		public void SetEndAngle(float newValue)
		{
			UUIRing.__SetEndAngle_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020A3B RID: 133691 RVA: 0x00304DF4 File Offset: 0x00302FF4
		public float GetStartAngle()
		{
			return UUIRing.__GetStartAngle_Internal(base.NativePtr);
		}

		// Token: 0x06020A3C RID: 133692 RVA: 0x00304E01 File Offset: 0x00303001
		public int GetSegment()
		{
			return UUIRing.__GetSegment_Internal(base.NativePtr);
		}

		// Token: 0x06020A3D RID: 133693 RVA: 0x00304E0E File Offset: 0x0030300E
		public float GetEndAngle()
		{
			return UUIRing.__GetEndAngle_Internal(base.NativePtr);
		}

		// Token: 0x06020A3E RID: 133694 RVA: 0x00304E1B File Offset: 0x0030301B
		[NullableContext(2)]
		public ULTweener EndAngleTo(float endValue, float duration = 0.5f, float delay = 0f, LTweenEase easeType = LTweenEase.OutCubic)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULTweener>(UUIRing.__EndAngleTo_Internal(base.NativePtr, endValue, duration, delay, easeType));
		}

		// Token: 0x06020A3F RID: 133695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartAngleTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x06020A40 RID: 133696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartAngle_Internal(IntPtr @this, float newValue);

		// Token: 0x06020A41 RID: 133697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSegment_Internal(IntPtr @this, int newValue);

		// Token: 0x06020A42 RID: 133698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEndAngle_Internal(IntPtr @this, float newValue);

		// Token: 0x06020A43 RID: 133699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartAngle_Internal(IntPtr @this);

		// Token: 0x06020A44 RID: 133700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSegment_Internal(IntPtr @this);

		// Token: 0x06020A45 RID: 133701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEndAngle_Internal(IntPtr @this);

		// Token: 0x06020A46 RID: 133702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EndAngleTo_Internal(IntPtr @this, float endValue, float duration, float delay, LTweenEase easeType);

		// Token: 0x06020A47 RID: 133703 RVA: 0x00304E32 File Offset: 0x00303032
		static UUIRing()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIRing");
		}

		// Token: 0x06020A48 RID: 133704 RVA: 0x00304E40 File Offset: 0x00303040
		protected UUIRing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401176D RID: 71533
		public new const string __ObjectPath = "/Script/LGUI.UIRing";

		// Token: 0x0401176E RID: 71534
		private static IntPtr _ClassPtr;

		// Token: 0x0401176F RID: 71535
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011770 RID: 71536
		internal static int __PropertyOffset_StartAngle;

		// Token: 0x04011771 RID: 71537
		internal static int __PropertyOffset_EndAngle;

		// Token: 0x04011772 RID: 71538
		internal static int __PropertyOffset_Segment;

		// Token: 0x04011773 RID: 71539
		internal static int __PropertyOffset_CurrentPointArray;

		// Token: 0x04011774 RID: 71540
		[Nullable(2)]
		private TArray<FVector2D> _CurrentPointArray;
	}
}
