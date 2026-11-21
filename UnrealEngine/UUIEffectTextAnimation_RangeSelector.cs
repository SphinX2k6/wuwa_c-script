using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FC RID: 1788
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_RangeSelector")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UUIEffectTextAnimation_RangeSelector : UUIEffectTextAnimation_Selector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009849 RID: 38985 RVA: 0x000E556A File Offset: 0x000E376A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_RangeSelector._ClassPtr;
		}

		// Token: 0x0600984A RID: 38986 RVA: 0x000E5578 File Offset: 0x000E3778
		public UUIEffectTextAnimation_RangeSelector() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RangeSelector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600984B RID: 38987 RVA: 0x000E55A0 File Offset: 0x000E37A0
		[NullableContext(1)]
		public UUIEffectTextAnimation_RangeSelector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RangeSelector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x0600984C RID: 38988 RVA: 0x000E55D3 File Offset: 0x000E37D3
		// (set) Token: 0x0600984D RID: 38989 RVA: 0x000E55E3 File Offset: 0x000E37E3
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

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x0600984E RID: 38990 RVA: 0x000E55F4 File Offset: 0x000E37F4
		// (set) Token: 0x0600984F RID: 38991 RVA: 0x000E5604 File Offset: 0x000E3804
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

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06009850 RID: 38992 RVA: 0x000E5615 File Offset: 0x000E3815
		// (set) Token: 0x06009851 RID: 38993 RVA: 0x000E5625 File Offset: 0x000E3825
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

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06009852 RID: 38994 RVA: 0x000E5636 File Offset: 0x000E3836
		// (set) Token: 0x06009853 RID: 38995 RVA: 0x000E5646 File Offset: 0x000E3846
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

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06009854 RID: 38996 RVA: 0x000E5657 File Offset: 0x000E3857
		// (set) Token: 0x06009855 RID: 38997 RVA: 0x000E5667 File Offset: 0x000E3867
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

		// Token: 0x06009856 RID: 38998 RVA: 0x000E5678 File Offset: 0x000E3878
		public void SetStart(float value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetStart_Internal(base.NativePtr, value);
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x000E5686 File Offset: 0x000E3886
		public void SetRange(float value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetRange_Internal(base.NativePtr, value);
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x000E5694 File Offset: 0x000E3894
		public void SetFlipDirection(bool value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetFlipDirection_Internal(base.NativePtr, value);
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x000E56A2 File Offset: 0x000E38A2
		public void SetEnd(float value)
		{
			UUIEffectTextAnimation_RangeSelector.__SetEnd_Internal(base.NativePtr, value);
		}

		// Token: 0x0600985A RID: 39002 RVA: 0x000E56B0 File Offset: 0x000E38B0
		public float GetStart()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetStart_Internal(base.NativePtr);
		}

		// Token: 0x0600985B RID: 39003 RVA: 0x000E56BD File Offset: 0x000E38BD
		public float GetRange()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetRange_Internal(base.NativePtr);
		}

		// Token: 0x0600985C RID: 39004 RVA: 0x000E56CA File Offset: 0x000E38CA
		public bool GetFlipDirection()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetFlipDirection_Internal(base.NativePtr);
		}

		// Token: 0x0600985D RID: 39005 RVA: 0x000E56D7 File Offset: 0x000E38D7
		public float GetEnd()
		{
			return UUIEffectTextAnimation_RangeSelector.__GetEnd_Internal(base.NativePtr);
		}

		// Token: 0x0600985E RID: 39006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStart_Internal(IntPtr @this, float value);

		// Token: 0x0600985F RID: 39007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRange_Internal(IntPtr @this, float value);

		// Token: 0x06009860 RID: 39008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFlipDirection_Internal(IntPtr @this, bool value);

		// Token: 0x06009861 RID: 39009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnd_Internal(IntPtr @this, float value);

		// Token: 0x06009862 RID: 39010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStart_Internal(IntPtr @this);

		// Token: 0x06009863 RID: 39011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRange_Internal(IntPtr @this);

		// Token: 0x06009864 RID: 39012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFlipDirection_Internal(IntPtr @this);

		// Token: 0x06009865 RID: 39013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEnd_Internal(IntPtr @this);

		// Token: 0x06009866 RID: 39014 RVA: 0x000E56E4 File Offset: 0x000E38E4
		static UUIEffectTextAnimation_RangeSelector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_RangeSelector");
		}

		// Token: 0x06009867 RID: 39015 RVA: 0x000E56F2 File Offset: 0x000E38F2
		protected UUIEffectTextAnimation_RangeSelector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004227 RID: 16935
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_RangeSelector";

		// Token: 0x04004228 RID: 16936
		private static IntPtr _ClassPtr;

		// Token: 0x04004229 RID: 16937
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400422A RID: 16938
		internal static int __PropertyOffset_range;

		// Token: 0x0400422B RID: 16939
		internal static int __PropertyOffset_flipDirection;

		// Token: 0x0400422C RID: 16940
		internal static int __PropertyOffset_start;

		// Token: 0x0400422D RID: 16941
		internal static int __PropertyOffset_end;

		// Token: 0x0400422E RID: 16942
		internal static int __PropertyOffset_lineByLine;
	}
}
