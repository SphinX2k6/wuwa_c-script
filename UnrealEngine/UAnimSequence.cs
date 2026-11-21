using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200017F RID: 383
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimSequence")]
	[UnrealStructLayout(1104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UAnimSequence : UAnimSequenceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x000253A7 File Offset: 0x000235A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimSequence._ClassPtr;
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x000253B4 File Offset: 0x000235B4
		public UAnimSequence() : this(BuiltinUtils.AllocNativeUObject(UAnimSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x000253DC File Offset: 0x000235DC
		public UAnimSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0002540F File Offset: 0x0002360F
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0002541F File Offset: 0x0002361F
		public unsafe int NumFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_NumFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_NumFrames) = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00025430 File Offset: 0x00023630
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x00025444 File Offset: 0x00023644
		[Nullable(2)]
		public unsafe UAnimSequence RefPoseSeq
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_RefPoseSeq);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimSequence.__PropertyOffset_RefPoseSeq, value);
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x00025459 File Offset: 0x00023659
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x00025469 File Offset: 0x00023669
		public unsafe int RefFrameIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RefFrameIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RefFrameIndex) = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0002547A File Offset: 0x0002367A
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x0002548E File Offset: 0x0002368E
		public unsafe FName RetargetSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RetargetSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RetargetSource) = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x000254A3 File Offset: 0x000236A3
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x000254B3 File Offset: 0x000236B3
		public unsafe bool bHasNonUniformScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bHasNonUniformScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bHasNonUniformScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x000254C4 File Offset: 0x000236C4
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x000254D4 File Offset: 0x000236D4
		public unsafe bool bApplyRootOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bApplyRootOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bApplyRootOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x000254E5 File Offset: 0x000236E5
		// (set) Token: 0x06001880 RID: 6272 RVA: 0x000254F9 File Offset: 0x000236F9
		public unsafe FTransform RootOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootOffset) = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x0002550E File Offset: 0x0002370E
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x0002551E File Offset: 0x0002371E
		public unsafe bool bEnableRootMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bEnableRootMotion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bEnableRootMotion) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0002552F File Offset: 0x0002372F
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0002553F File Offset: 0x0002373F
		public unsafe bool bForceRootLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceRootLock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceRootLock) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00025550 File Offset: 0x00023750
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x00025560 File Offset: 0x00023760
		public unsafe bool bUseNormalizedRootMotionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bUseNormalizedRootMotionScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bUseNormalizedRootMotionScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00025571 File Offset: 0x00023771
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x00025581 File Offset: 0x00023781
		public unsafe bool bRootMotionSettingsCopiedFromMontage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bRootMotionSettingsCopiedFromMontage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bRootMotionSettingsCopiedFromMontage) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00025592 File Offset: 0x00023792
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x000255A2 File Offset: 0x000237A2
		public unsafe bool bForceFlyMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceFlyMotion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_bForceFlyMotion) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x000255B4 File Offset: 0x000237B4
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x000255ED File Offset: 0x000237ED
		public TArray<float> ForceFlyMotionTimeArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ForceFlyMotionTimeArray) == null)
				{
					result = (this._ForceFlyMotionTimeArray = new TArray<float>(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_ForceFlyMotionTimeArray, this));
				}
				return result;
			}
			set
			{
				this.ForceFlyMotionTimeArray.CopyAssign(value);
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x000255FB File Offset: 0x000237FB
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x0002560B File Offset: 0x0002380B
		public unsafe byte RootMotionMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootMotionMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimSequence.__PropertyOffset_RootMotionMask) = value;
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0002561C File Offset: 0x0002381C
		public void SetUseNormalizedRootMotionScale(bool bInbUseNormalizedRootMotionScale)
		{
			UAnimSequence.__SetUseNormalizedRootMotionScale_Internal(base.NativePtr, bInbUseNormalizedRootMotionScale);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0002562A File Offset: 0x0002382A
		public void SetKuroRootMotionSettings(bool ForceFlyMotion)
		{
			UAnimSequence.__SetKuroRootMotionSettings_Internal(base.NativePtr, ForceFlyMotion);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00025638 File Offset: 0x00023838
		public void SetForceRootLock(bool bInForceRootLock)
		{
			UAnimSequence.__SetForceRootLock_Internal(base.NativePtr, bInForceRootLock);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00025646 File Offset: 0x00023846
		public void SetEnableRootMotion(bool bInEnableRootMotion)
		{
			UAnimSequence.__SetEnableRootMotion_Internal(base.NativePtr, bInEnableRootMotion);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00025654 File Offset: 0x00023854
		public unsafe void GetKuroRootMotionSettings(ref bool ForceFlyMotion)
		{
			fixed (bool* ptr = &ForceFlyMotion)
			{
				void* ptr2 = (void*)ptr;
				UAnimSequence.__GetKuroRootMotionSettings_Internal(base.NativePtr, ref ForceFlyMotion);
			}
		}

		// Token: 0x06001894 RID: 6292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseNormalizedRootMotionScale_Internal(IntPtr @this, bool bInbUseNormalizedRootMotionScale);

		// Token: 0x06001895 RID: 6293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroRootMotionSettings_Internal(IntPtr @this, bool ForceFlyMotion);

		// Token: 0x06001896 RID: 6294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceRootLock_Internal(IntPtr @this, bool bInForceRootLock);

		// Token: 0x06001897 RID: 6295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableRootMotion_Internal(IntPtr @this, bool bInEnableRootMotion);

		// Token: 0x06001898 RID: 6296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetKuroRootMotionSettings_Internal(IntPtr @this, ref bool ForceFlyMotion);

		// Token: 0x06001899 RID: 6297 RVA: 0x00025675 File Offset: 0x00023875
		static UAnimSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimSequence");
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00025683 File Offset: 0x00023883
		protected UAnimSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007BF RID: 1983
		public new const string __ObjectPath = "/Script/Engine.AnimSequence";

		// Token: 0x040007C0 RID: 1984
		private static IntPtr _ClassPtr;

		// Token: 0x040007C1 RID: 1985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007C2 RID: 1986
		internal static int __PropertyOffset_NumFrames;

		// Token: 0x040007C3 RID: 1987
		internal static int __PropertyOffset_RefPoseSeq;

		// Token: 0x040007C4 RID: 1988
		internal static int __PropertyOffset_RefFrameIndex;

		// Token: 0x040007C5 RID: 1989
		internal static int __PropertyOffset_RetargetSource;

		// Token: 0x040007C6 RID: 1990
		internal static int __PropertyOffset_bHasNonUniformScale;

		// Token: 0x040007C7 RID: 1991
		internal static int __PropertyOffset_bApplyRootOffset;

		// Token: 0x040007C8 RID: 1992
		internal static int __PropertyOffset_RootOffset;

		// Token: 0x040007C9 RID: 1993
		internal static int __PropertyOffset_bEnableRootMotion;

		// Token: 0x040007CA RID: 1994
		internal static int __PropertyOffset_bForceRootLock;

		// Token: 0x040007CB RID: 1995
		internal static int __PropertyOffset_bUseNormalizedRootMotionScale;

		// Token: 0x040007CC RID: 1996
		internal static int __PropertyOffset_bRootMotionSettingsCopiedFromMontage;

		// Token: 0x040007CD RID: 1997
		internal static int __PropertyOffset_bForceFlyMotion;

		// Token: 0x040007CE RID: 1998
		internal static int __PropertyOffset_ForceFlyMotionTimeArray;

		// Token: 0x040007CF RID: 1999
		[Nullable(2)]
		private TArray<float> _ForceFlyMotionTimeArray;

		// Token: 0x040007D0 RID: 2000
		internal static int __PropertyOffset_RootMotionMask;
	}
}
