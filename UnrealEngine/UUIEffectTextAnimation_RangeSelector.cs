using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200215A RID: 8538
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_RangeSelector")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UUIEffectTextAnimation_RangeSelector : UUIEffectTextAnimation_Selector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020324 RID: 131876 RVA: 0x002FD37A File Offset: 0x002FB57A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_RangeSelector._ClassPtr;
		}

		// Token: 0x06020325 RID: 131877 RVA: 0x002FD388 File Offset: 0x002FB588
		public UUIEffectTextAnimation_RangeSelector() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RangeSelector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020326 RID: 131878 RVA: 0x002FD3B0 File Offset: 0x002FB5B0
		[NullableContext(1)]
		public UUIEffectTextAnimation_RangeSelector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RangeSelector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E4D RID: 32333
		// (get) Token: 0x06020327 RID: 131879 RVA: 0x002FD3E3 File Offset: 0x002FB5E3
		// (set) Token: 0x06020328 RID: 131880 RVA: 0x002FD3F3 File Offset: 0x002FB5F3
		public unsafe float range
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_range);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_range) = value;
			}
		}

		// Token: 0x17007E4E RID: 32334
		// (get) Token: 0x06020329 RID: 131881 RVA: 0x002FD404 File Offset: 0x002FB604
		// (set) Token: 0x0602032A RID: 131882 RVA: 0x002FD414 File Offset: 0x002FB614
		public unsafe bool flipDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_flipDirection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_flipDirection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007E4F RID: 32335
		// (get) Token: 0x0602032B RID: 131883 RVA: 0x002FD425 File Offset: 0x002FB625
		// (set) Token: 0x0602032C RID: 131884 RVA: 0x002FD435 File Offset: 0x002FB635
		public unsafe float start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_start) = value;
			}
		}

		// Token: 0x17007E50 RID: 32336
		// (get) Token: 0x0602032D RID: 131885 RVA: 0x002FD446 File Offset: 0x002FB646
		// (set) Token: 0x0602032E RID: 131886 RVA: 0x002FD456 File Offset: 0x002FB656
		public unsafe float end
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_end);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_end) = value;
			}
		}

		// Token: 0x17007E51 RID: 32337
		// (get) Token: 0x0602032F RID: 131887 RVA: 0x002FD467 File Offset: 0x002FB667
		// (set) Token: 0x06020330 RID: 131888 RVA: 0x002FD477 File Offset: 0x002FB677
		public unsafe bool lineByLine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_lineByLine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RangeSelector.__PropertyOffset_lineByLine) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020331 RID: 131889 RVA: 0x002FD488 File Offset: 0x002FB688
		public void SetStart(float value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetStart_Internal(base.NativePtr, value);
		}

		// Token: 0x06020332 RID: 131890 RVA: 0x002FD496 File Offset: 0x002FB696
		public void SetRange(float value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetRange_Internal(base.NativePtr, value);
		}

		// Token: 0x06020333 RID: 131891 RVA: 0x002FD4A4 File Offset: 0x002FB6A4
		public void SetFlipDirection(bool value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetFlipDirection_Internal(base.NativePtr, value);
		}

		// Token: 0x06020334 RID: 131892 RVA: 0x002FD4B2 File Offset: 0x002FB6B2
		public void SetEnd(float value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetEnd_Internal(base.NativePtr, value);
		}

		// Token: 0x06020335 RID: 131893 RVA: 0x002FD4C0 File Offset: 0x002FB6C0
		public float GetStart()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetStart_Internal(base.NativePtr);
		}

		// Token: 0x06020336 RID: 131894 RVA: 0x002FD4CD File Offset: 0x002FB6CD
		public float GetRange()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetRange_Internal(base.NativePtr);
		}

		// Token: 0x06020337 RID: 131895 RVA: 0x002FD4DA File Offset: 0x002FB6DA
		public bool GetFlipDirection()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetFlipDirection_Internal(base.NativePtr);
		}

		// Token: 0x06020338 RID: 131896 RVA: 0x002FD4E7 File Offset: 0x002FB6E7
		public float GetEnd()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetEnd_Internal(base.NativePtr);
		}

		// Token: 0x06020339 RID: 131897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStart_Internal(IntPtr @this, float value);

		// Token: 0x0602033A RID: 131898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRange_Internal(IntPtr @this, float value);

		// Token: 0x0602033B RID: 131899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFlipDirection_Internal(IntPtr @this, bool value);

		// Token: 0x0602033C RID: 131900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnd_Internal(IntPtr @this, float value);

		// Token: 0x0602033D RID: 131901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStart_Internal(IntPtr @this);

		// Token: 0x0602033E RID: 131902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRange_Internal(IntPtr @this);

		// Token: 0x0602033F RID: 131903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFlipDirection_Internal(IntPtr @this);

		// Token: 0x06020340 RID: 131904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEnd_Internal(IntPtr @this);

		// Token: 0x06020341 RID: 131905 RVA: 0x002FD4F4 File Offset: 0x002FB6F4
		static UUIEffectTextAnimation_RangeSelector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_RangeSelector");
		}

		// Token: 0x06020342 RID: 131906 RVA: 0x002FD502 File Offset: 0x002FB702
		protected UUIEffectTextAnimation_RangeSelector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114E9 RID: 70889
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_RangeSelector";

		// Token: 0x040114EA RID: 70890
		private static IntPtr _ClassPtr;

		// Token: 0x040114EB RID: 70891
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114EC RID: 70892
		internal static int __PropertyOffset_range;

		// Token: 0x040114ED RID: 70893
		internal static int __PropertyOffset_flipDirection;

		// Token: 0x040114EE RID: 70894
		internal static int __PropertyOffset_start;

		// Token: 0x040114EF RID: 70895
		internal static int __PropertyOffset_end;

		// Token: 0x040114F0 RID: 70896
		internal static int __PropertyOffset_lineByLine;
	}
}
