using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002160 RID: 8544
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_ScaleRandomProperty")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UUIEffectTextAnimation_ScaleRandomProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020394 RID: 131988 RVA: 0x002FDA13 File Offset: 0x002FBC13
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_ScaleRandomProperty._ClassPtr;
		}

		// Token: 0x06020395 RID: 131989 RVA: 0x002FDA20 File Offset: 0x002FBC20
		public UUIEffectTextAnimation_ScaleRandomProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ScaleRandomProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020396 RID: 131990 RVA: 0x002FDA48 File Offset: 0x002FBC48
		[NullableContext(1)]
		public UUIEffectTextAnimation_ScaleRandomProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ScaleRandomProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E5C RID: 32348
		// (get) Token: 0x06020397 RID: 131991 RVA: 0x002FDA7B File Offset: 0x002FBC7B
		// (set) Token: 0x06020398 RID: 131992 RVA: 0x002FDA8B File Offset: 0x002FBC8B
		public unsafe int seed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleRandomProperty.__PropertyOffset_seed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleRandomProperty.__PropertyOffset_seed) = value;
			}
		}

		// Token: 0x17007E5D RID: 32349
		// (get) Token: 0x06020399 RID: 131993 RVA: 0x002FDA9C File Offset: 0x002FBC9C
		// (set) Token: 0x0602039A RID: 131994 RVA: 0x002FDAB0 File Offset: 0x002FBCB0
		public unsafe FVector min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleRandomProperty.__PropertyOffset_min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleRandomProperty.__PropertyOffset_min) = value;
			}
		}

		// Token: 0x17007E5E RID: 32350
		// (get) Token: 0x0602039B RID: 131995 RVA: 0x002FDAC5 File Offset: 0x002FBCC5
		// (set) Token: 0x0602039C RID: 131996 RVA: 0x002FDAD9 File Offset: 0x002FBCD9
		public unsafe FVector max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleRandomProperty.__PropertyOffset_max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleRandomProperty.__PropertyOffset_max) = value;
			}
		}

		// Token: 0x0602039D RID: 131997 RVA: 0x002FDAEE File Offset: 0x002FBCEE
		public void SetSeed(int value)
		{
			UUIEffectTextAnimation_ScaleRandomProperty.__SetSeed_Internal(base.NativePtr, value);
		}

		// Token: 0x0602039E RID: 131998 RVA: 0x002FDAFC File Offset: 0x002FBCFC
		public void SetMin(FVector value)
		{
			UUIEffectTextAnimation_ScaleRandomProperty.__SetMin_Internal(base.NativePtr, value);
		}

		// Token: 0x0602039F RID: 131999 RVA: 0x002FDB0A File Offset: 0x002FBD0A
		public void SetMax(FVector value)
		{
			UUIEffectTextAnimation_ScaleRandomProperty.__SetMax_Internal(base.NativePtr, value);
		}

		// Token: 0x060203A0 RID: 132000 RVA: 0x002FDB18 File Offset: 0x002FBD18
		public int GetSeed()
		{
			return UUIEffectTextAnimation_ScaleRandomProperty.__GetSeed_Internal(base.NativePtr);
		}

		// Token: 0x060203A1 RID: 132001 RVA: 0x002FDB25 File Offset: 0x002FBD25
		public FVector GetMin()
		{
			return UUIEffectTextAnimation_ScaleRandomProperty.__GetMin_Internal(base.NativePtr);
		}

		// Token: 0x060203A2 RID: 132002 RVA: 0x002FDB32 File Offset: 0x002FBD32
		public FVector GetMax()
		{
			return UUIEffectTextAnimation_ScaleRandomProperty.__GetMax_Internal(base.NativePtr);
		}

		// Token: 0x060203A3 RID: 132003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeed_Internal(IntPtr @this, int value);

		// Token: 0x060203A4 RID: 132004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMin_Internal(IntPtr @this, FVector value);

		// Token: 0x060203A5 RID: 132005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMax_Internal(IntPtr @this, FVector value);

		// Token: 0x060203A6 RID: 132006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSeed_Internal(IntPtr @this);

		// Token: 0x060203A7 RID: 132007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMin_Internal(IntPtr @this);

		// Token: 0x060203A8 RID: 132008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetMax_Internal(IntPtr @this);

		// Token: 0x060203A9 RID: 132009 RVA: 0x002FDB3F File Offset: 0x002FBD3F
		static UUIEffectTextAnimation_ScaleRandomProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_ScaleRandomProperty");
		}

		// Token: 0x060203AA RID: 132010 RVA: 0x002FDB4D File Offset: 0x002FBD4D
		protected UUIEffectTextAnimation_ScaleRandomProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401150A RID: 70922
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_ScaleRandomProperty";

		// Token: 0x0401150B RID: 70923
		private static IntPtr _ClassPtr;

		// Token: 0x0401150C RID: 70924
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401150D RID: 70925
		internal static int __PropertyOffset_seed;

		// Token: 0x0401150E RID: 70926
		internal static int __PropertyOffset_min;

		// Token: 0x0401150F RID: 70927
		internal static int __PropertyOffset_max;
	}
}
