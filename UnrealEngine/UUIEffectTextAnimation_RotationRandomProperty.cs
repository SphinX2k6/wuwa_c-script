using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200215D RID: 8541
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_RotationRandomProperty")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UUIEffectTextAnimation_RotationRandomProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020365 RID: 131941 RVA: 0x002FD71E File Offset: 0x002FB91E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_RotationRandomProperty._ClassPtr;
		}

		// Token: 0x06020366 RID: 131942 RVA: 0x002FD72C File Offset: 0x002FB92C
		public UUIEffectTextAnimation_RotationRandomProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RotationRandomProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020367 RID: 131943 RVA: 0x002FD754 File Offset: 0x002FB954
		[NullableContext(1)]
		public UUIEffectTextAnimation_RotationRandomProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RotationRandomProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E56 RID: 32342
		// (get) Token: 0x06020368 RID: 131944 RVA: 0x002FD787 File Offset: 0x002FB987
		// (set) Token: 0x06020369 RID: 131945 RVA: 0x002FD797 File Offset: 0x002FB997
		public unsafe int seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationRandomProperty.__PropertyOffset_seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationRandomProperty.__PropertyOffset_seed) = value;
			}
		}

		// Token: 0x17007E57 RID: 32343
		// (get) Token: 0x0602036A RID: 131946 RVA: 0x002FD7A8 File Offset: 0x002FB9A8
		// (set) Token: 0x0602036B RID: 131947 RVA: 0x002FD7BC File Offset: 0x002FB9BC
		public unsafe FRotator min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationRandomProperty.__PropertyOffset_min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationRandomProperty.__PropertyOffset_min) = value;
			}
		}

		// Token: 0x17007E58 RID: 32344
		// (get) Token: 0x0602036C RID: 131948 RVA: 0x002FD7D1 File Offset: 0x002FB9D1
		// (set) Token: 0x0602036D RID: 131949 RVA: 0x002FD7E5 File Offset: 0x002FB9E5
		public unsafe FRotator max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationRandomProperty.__PropertyOffset_max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RotationRandomProperty.__PropertyOffset_max) = value;
			}
		}

		// Token: 0x0602036E RID: 131950 RVA: 0x002FD7FA File Offset: 0x002FB9FA
		public void SetSeed(int value)
		{
			UUIEffectTextAnimation_RotationRandomProperty.__SetSeed_Internal(base.NativePtr, value);
		}

		// Token: 0x0602036F RID: 131951 RVA: 0x002FD808 File Offset: 0x002FBA08
		public void SetMin(FRotator value)
		{
			UUIEffectTextAnimation_RotationRandomProperty.__SetMin_Internal(base.NativePtr, value);
		}

		// Token: 0x06020370 RID: 131952 RVA: 0x002FD816 File Offset: 0x002FBA16
		public void SetMax(FRotator value)
		{
			UUIEffectTextAnimation_RotationRandomProperty.__SetMax_Internal(base.NativePtr, value);
		}

		// Token: 0x06020371 RID: 131953 RVA: 0x002FD824 File Offset: 0x002FBA24
		public int GetSeed()
		{
			return UUIEffectTextAnimation_RotationRandomProperty.__GetSeed_Internal(base.NativePtr);
		}

		// Token: 0x06020372 RID: 131954 RVA: 0x002FD831 File Offset: 0x002FBA31
		public FRotator GetMin()
		{
			return UUIEffectTextAnimation_RotationRandomProperty.__GetMin_Internal(base.NativePtr);
		}

		// Token: 0x06020373 RID: 131955 RVA: 0x002FD83E File Offset: 0x002FBA3E
		public FRotator GetMax()
		{
			return UUIEffectTextAnimation_RotationRandomProperty.__GetMax_Internal(base.NativePtr);
		}

		// Token: 0x06020374 RID: 131956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeed_Internal(IntPtr @this, int value);

		// Token: 0x06020375 RID: 131957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMin_Internal(IntPtr @this, FRotator value);

		// Token: 0x06020376 RID: 131958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMax_Internal(IntPtr @this, FRotator value);

		// Token: 0x06020377 RID: 131959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSeed_Internal(IntPtr @this);

		// Token: 0x06020378 RID: 131960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetMin_Internal(IntPtr @this);

		// Token: 0x06020379 RID: 131961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetMax_Internal(IntPtr @this);

		// Token: 0x0602037A RID: 131962 RVA: 0x002FD84B File Offset: 0x002FBA4B
		static UUIEffectTextAnimation_RotationRandomProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_RotationRandomProperty");
		}

		// Token: 0x0602037B RID: 131963 RVA: 0x002FD859 File Offset: 0x002FBA59
		protected UUIEffectTextAnimation_RotationRandomProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114FB RID: 70907
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_RotationRandomProperty";

		// Token: 0x040114FC RID: 70908
		private static IntPtr _ClassPtr;

		// Token: 0x040114FD RID: 70909
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114FE RID: 70910
		internal static int __PropertyOffset_seed;

		// Token: 0x040114FF RID: 70911
		internal static int __PropertyOffset_min;

		// Token: 0x04011500 RID: 70912
		internal static int __PropertyOffset_max;
	}
}
