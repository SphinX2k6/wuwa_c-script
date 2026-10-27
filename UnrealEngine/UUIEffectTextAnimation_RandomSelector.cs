using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002159 RID: 8537
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_RandomSelector")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UUIEffectTextAnimation_RandomSelector : UUIEffectTextAnimation_Selector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602030D RID: 131853 RVA: 0x002FD245 File Offset: 0x002FB445
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_RandomSelector._ClassPtr;
		}

		// Token: 0x0602030E RID: 131854 RVA: 0x002FD254 File Offset: 0x002FB454
		public UUIEffectTextAnimation_RandomSelector() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RandomSelector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602030F RID: 131855 RVA: 0x002FD27C File Offset: 0x002FB47C
		[NullableContext(1)]
		public UUIEffectTextAnimation_RandomSelector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_RandomSelector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E4A RID: 32330
		// (get) Token: 0x06020310 RID: 131856 RVA: 0x002FD2AF File Offset: 0x002FB4AF
		// (set) Token: 0x06020311 RID: 131857 RVA: 0x002FD2BF File Offset: 0x002FB4BF
		public unsafe int seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RandomSelector.__PropertyOffset_seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RandomSelector.__PropertyOffset_seed) = value;
			}
		}

		// Token: 0x17007E4B RID: 32331
		// (get) Token: 0x06020312 RID: 131858 RVA: 0x002FD2D0 File Offset: 0x002FB4D0
		// (set) Token: 0x06020313 RID: 131859 RVA: 0x002FD2E0 File Offset: 0x002FB4E0
		public unsafe float start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RandomSelector.__PropertyOffset_start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RandomSelector.__PropertyOffset_start) = value;
			}
		}

		// Token: 0x17007E4C RID: 32332
		// (get) Token: 0x06020314 RID: 131860 RVA: 0x002FD2F1 File Offset: 0x002FB4F1
		// (set) Token: 0x06020315 RID: 131861 RVA: 0x002FD301 File Offset: 0x002FB501
		public unsafe float end
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RandomSelector.__PropertyOffset_end);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_RandomSelector.__PropertyOffset_end) = value;
			}
		}

		// Token: 0x06020316 RID: 131862 RVA: 0x002FD312 File Offset: 0x002FB512
		public void SetStart(float value)
		{
			UUIEffectTextAnimation_RandomSelector.__SetStart_Internal(base.NativePtr, value);
		}

		// Token: 0x06020317 RID: 131863 RVA: 0x002FD320 File Offset: 0x002FB520
		public void SetSeed(int value)
		{
			UUIEffectTextAnimation_RandomSelector.__SetSeed_Internal(base.NativePtr, value);
		}

		// Token: 0x06020318 RID: 131864 RVA: 0x002FD32E File Offset: 0x002FB52E
		public void SetEnd(float value)
		{
			UUIEffectTextAnimation_RandomSelector.__SetEnd_Internal(base.NativePtr, value);
		}

		// Token: 0x06020319 RID: 131865 RVA: 0x002FD33C File Offset: 0x002FB53C
		public float GetStart()
		{
			return UUIEffectTextAnimation_RandomSelector.__GetStart_Internal(base.NativePtr);
		}

		// Token: 0x0602031A RID: 131866 RVA: 0x002FD349 File Offset: 0x002FB549
		public int GetSeed()
		{
			return UUIEffectTextAnimation_RandomSelector.__GetSeed_Internal(base.NativePtr);
		}

		// Token: 0x0602031B RID: 131867 RVA: 0x002FD356 File Offset: 0x002FB556
		public float GetEnd()
		{
			return UUIEffectTextAnimation_RandomSelector.__GetEnd_Internal(base.NativePtr);
		}

		// Token: 0x0602031C RID: 131868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStart_Internal(IntPtr @this, float value);

		// Token: 0x0602031D RID: 131869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeed_Internal(IntPtr @this, int value);

		// Token: 0x0602031E RID: 131870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnd_Internal(IntPtr @this, float value);

		// Token: 0x0602031F RID: 131871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStart_Internal(IntPtr @this);

		// Token: 0x06020320 RID: 131872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSeed_Internal(IntPtr @this);

		// Token: 0x06020321 RID: 131873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetEnd_Internal(IntPtr @this);

		// Token: 0x06020322 RID: 131874 RVA: 0x002FD363 File Offset: 0x002FB563
		static UUIEffectTextAnimation_RandomSelector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_RandomSelector");
		}

		// Token: 0x06020323 RID: 131875 RVA: 0x002FD371 File Offset: 0x002FB571
		protected UUIEffectTextAnimation_RandomSelector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114E3 RID: 70883
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_RandomSelector";

		// Token: 0x040114E4 RID: 70884
		private static IntPtr _ClassPtr;

		// Token: 0x040114E5 RID: 70885
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114E6 RID: 70886
		internal static int __PropertyOffset_seed;

		// Token: 0x040114E7 RID: 70887
		internal static int __PropertyOffset_start;

		// Token: 0x040114E8 RID: 70888
		internal static int __PropertyOffset_end;
	}
}
