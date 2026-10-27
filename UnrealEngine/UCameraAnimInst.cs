using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000908 RID: 2312
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraAnimInst")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UCameraAnimInst : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007EE9 RID: 32489 RVA: 0x000B6152 File Offset: 0x000B4352
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraAnimInst._ClassPtr;
		}

		// Token: 0x06007EEA RID: 32490 RVA: 0x000B6160 File Offset: 0x000B4360
		public UCameraAnimInst() : this(BuiltinUtils.AllocNativeUObject(UCameraAnimInst.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007EEB RID: 32491 RVA: 0x000B6188 File Offset: 0x000B4388
		[NullableContext(1)]
		public UCameraAnimInst(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraAnimInst.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x06007EEC RID: 32492 RVA: 0x000B61BB File Offset: 0x000B43BB
		// (set) Token: 0x06007EED RID: 32493 RVA: 0x000B61CF File Offset: 0x000B43CF
		public unsafe UCameraAnim CamAnim
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnim>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_CamAnim);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_CamAnim, value);
			}
		}

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x06007EEE RID: 32494 RVA: 0x000B61E4 File Offset: 0x000B43E4
		// (set) Token: 0x06007EEF RID: 32495 RVA: 0x000B61F8 File Offset: 0x000B43F8
		public unsafe UInterpGroupInst InterpGroupInst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpGroupInst>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_InterpGroupInst);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_InterpGroupInst, value);
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x06007EF0 RID: 32496 RVA: 0x000B620D File Offset: 0x000B440D
		// (set) Token: 0x06007EF1 RID: 32497 RVA: 0x000B621D File Offset: 0x000B441D
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCameraAnimInst.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraAnimInst.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x06007EF2 RID: 32498 RVA: 0x000B622E File Offset: 0x000B442E
		// (set) Token: 0x06007EF3 RID: 32499 RVA: 0x000B6242 File Offset: 0x000B4442
		public unsafe UInterpTrackMove MoveTrack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpTrackMove>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_MoveTrack);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_MoveTrack, value);
			}
		}

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x06007EF4 RID: 32500 RVA: 0x000B6257 File Offset: 0x000B4457
		// (set) Token: 0x06007EF5 RID: 32501 RVA: 0x000B626B File Offset: 0x000B446B
		public unsafe UInterpTrackInstMove MoveInst
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInterpTrackInstMove>(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_MoveInst);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCameraAnimInst.__PropertyOffset_MoveInst, value);
			}
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x06007EF6 RID: 32502 RVA: 0x000B6280 File Offset: 0x000B4480
		// (set) Token: 0x06007EF7 RID: 32503 RVA: 0x000B6290 File Offset: 0x000B4490
		public unsafe ECameraShakePlaySpace PlaySpace
		{
			get
			{
				return (ECameraShakePlaySpace)(*(base.NativePtr + (IntPtr)UCameraAnimInst.__PropertyOffset_PlaySpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCameraAnimInst.__PropertyOffset_PlaySpace) = (byte)value;
			}
		}

		// Token: 0x06007EF8 RID: 32504 RVA: 0x000B62A1 File Offset: 0x000B44A1
		public void Stop(bool bImmediate = false)
		{
			UCameraAnimInst.__Stop_Internal(base.NativePtr, bImmediate);
		}

		// Token: 0x06007EF9 RID: 32505 RVA: 0x000B62AF File Offset: 0x000B44AF
		public void SetScale(float NewDuration)
		{
			UCameraAnimInst.__SetScale_Internal(base.NativePtr, NewDuration);
		}

		// Token: 0x06007EFA RID: 32506 RVA: 0x000B62BD File Offset: 0x000B44BD
		public void SetDuration(float NewDuration)
		{
			UCameraAnimInst.__SetDuration_Internal(base.NativePtr, NewDuration);
		}

		// Token: 0x06007EFB RID: 32507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this, bool bImmediate);

		// Token: 0x06007EFC RID: 32508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScale_Internal(IntPtr @this, float NewDuration);

		// Token: 0x06007EFD RID: 32509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDuration_Internal(IntPtr @this, float NewDuration);

		// Token: 0x06007EFE RID: 32510 RVA: 0x000B62CB File Offset: 0x000B44CB
		static UCameraAnimInst()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraAnimInst");
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x000B62D9 File Offset: 0x000B44D9
		protected UCameraAnimInst(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CE7 RID: 15591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraAnimInst";

		// Token: 0x04003CE8 RID: 15592
		private static IntPtr _ClassPtr;

		// Token: 0x04003CE9 RID: 15593
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003CEA RID: 15594
		internal static int __PropertyOffset_CamAnim;

		// Token: 0x04003CEB RID: 15595
		internal static int __PropertyOffset_InterpGroupInst;

		// Token: 0x04003CEC RID: 15596
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04003CED RID: 15597
		internal static int __PropertyOffset_MoveTrack;

		// Token: 0x04003CEE RID: 15598
		internal static int __PropertyOffset_MoveInst;

		// Token: 0x04003CEF RID: 15599
		internal static int __PropertyOffset_PlaySpace;
	}
}
